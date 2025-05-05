using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using GenLogic;
using lab9_gauge_knob;
using ZedGraph;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Lab9
{
    public partial class GraphsViewer : Form
    {
        public Dictionary<string, Graph<object>> Graphs;
        public GraphsViewer()
        {
            InitializeComponent();
            Graphs = new Dictionary<string, Graph<dynamic>>();
        }

        private void toolCreate_Click(object sender, EventArgs e)
        {
            using (GraphCreation dialog = new GraphCreation())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    Graph<dynamic> result = dialog.Result;
                    Graphs[result.Name] = result;

                    TabPage newTab = new TabPage(result.Name);

                    ZedGraphControl zgc = new ZedGraphControl
                    {
                        Dock = DockStyle.Fill
                    };

                    newTab.Controls.Add(zgc);

                    tabControlGraphs.TabPages.Add(newTab);

                    BuildGraph(zgc, result);

                    if (tabControlGraphs.TabPages.Count == 1)
                    {
                        textBoxName.Text = result.Name;
                        textBoxDescription.Text = result.Description;
                    }

                    tabControlGraphs.SelectedTab = newTab;

                    groupBoxInfo.Enabled = true;
                    toolDelete.Enabled = true;
                    toolEditView.Enabled = true;
                }
            }
        }

        private void BuildGraph(ZedGraphControl zgc, Graph<dynamic> graph)
        {
            GraphType type = graph.Type;
            Seria<dynamic>[] series = graph.Series;

            GraphPane graphPane = zgc.GraphPane;
            graphPane.XAxis.MajorGrid.IsZeroLine = true;
            graphPane.CurveList.Clear();

            switch (type)
            {
                case GraphType.Line:

                    for (int i = 0; i < series.Length; i++)
                    {
                        var seria = series[i];
                        PointPairList points = new PointPairList();
                        foreach (var point in seria.Points)
                        {
                            points.Add(point.X, point.Y);
                        }

                        var curve = graphPane.AddCurve($"Серия {i + 1}", points, GraphColors.GetSeriesColor(i), SymbolType.None);
                        curve.Line.IsVisible = true;
                    }
                    break;

                case GraphType.Scatter:
                    for (int i = 0; i < series.Length; i++)
                    {
                        var seria = series[i];
                        PointPairList points = new PointPairList();
                        foreach (var point in seria.Points)
                        {
                            points.Add(point.X, point.Y);
                        }

                        var curve = graphPane.AddCurve($"Серия {i + 1}", points, GraphColors.GetSeriesColor(i), SymbolType.Circle);
                        curve.Line.IsVisible = false;
                        curve.Symbol.Fill = new Fill(curve.Color);
                        curve.Symbol.Size = 8;
                    }
                    break;

                case GraphType.Bar:
                    {
                        var labels = new List<string>();
                        for (int i = 0; i < series.Length; i++)
                        {
                            var seria = series[i];
                            PointPairList points = new PointPairList();
                            int index = 0;
                            foreach (var point in seria.Points)
                            {
                                points.Add(index, point.Value);
                                if (labels.Count <= index)
                                    labels.Add(point.Label);
                                index++;
                            }

                            graphPane.AddBar($"Серия {i + 1}", points, GraphColors.GetSeriesColor(i));
                        }

                        graphPane.XAxis.Type = AxisType.Text;
                        graphPane.XAxis.Scale.TextLabels = labels.ToArray();
                        break;
                    }

                default:
                    MessageBox.Show("Неизвестный тип графика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            zgc.AxisChange();
            zgc.Invalidate();
        }



        private void toolClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tabControlGraphs_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                Graph<object> selectedGraph = Graphs[tabControlGraphs.SelectedTab.Text];
                textBoxName.Text = selectedGraph.Name;
                textBoxDescription.Text = selectedGraph.Description;
            }
            catch { }

        }

        private void buttonViewData_Click(object sender, EventArgs e)
        {
            if (tabControlGraphs.SelectedTab == null)
                return;

            string name = tabControlGraphs.SelectedTab.Text;

            if (!Graphs.ContainsKey(name))
            {
                MessageBox.Show("График не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataViewer viewer = new DataViewer(Graphs[name]);
            viewer.ShowDialog();
        }

        private void buttonEditData_Click(object sender, EventArgs e)
        {
            if (tabControlGraphs.SelectedTab == null)
                return;

            string name = tabControlGraphs.SelectedTab.Text;

            if (!Graphs.ContainsKey(name))
            {
                MessageBox.Show("График не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (GraphEditData editor = new GraphEditData(Graphs[name]))
            {
                if (editor.ShowDialog() == DialogResult.OK)
                {
                    Graph<dynamic> result = editor.Result;

                    Graphs[result.Name] = result;

                    TabPage currentTab = tabControlGraphs.SelectedTab;
                    currentTab.Text = result.Name;

                    currentTab.Controls.Clear();

                    ZedGraphControl zgc = new ZedGraphControl
                    {
                        Dock = DockStyle.Fill
                    };

                    currentTab.Controls.Add(zgc);
                    BuildGraph(zgc, result);

                    textBoxName.Text = result.Name;
                    textBoxDescription.Text = result.Description;
                }
            };
        }

        private void toolEditView_Click(object sender, EventArgs e)
        {
            if (tabControlGraphs.SelectedTab == null)
                return;

            ZedGraph.ZedGraphControl zedGraph = null;

            foreach (Control ctrl in tabControlGraphs.SelectedTab.Controls)
            {
                if (ctrl is ZedGraph.ZedGraphControl zg)
                {
                    zedGraph = zg;
                    break;
                }
            }

            if (zedGraph == null)
            {
                MessageBox.Show("График не найден на выбранной вкладке.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            GraphEditView editor = new GraphEditView(zedGraph);

            if (editor.ShowDialog() == DialogResult.OK)
            {
                zedGraph.Invalidate();
            }
        }

        private void toolDelete_Click(object sender, EventArgs e)
        {
            if (tabControlGraphs.SelectedTab == null)
                return;

            string name = tabControlGraphs.SelectedTab.Text;

            if (!Graphs.ContainsKey(name))
            {
                MessageBox.Show("График не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Вы уверены, что хотите удалить график?", "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Graphs.Remove(name);
                TabPage currentTab = tabControlGraphs.SelectedTab;
                tabControlGraphs.TabPages.Remove(currentTab);
                if (tabControlGraphs.TabPages.Count == 0)
                {
                    textBoxName.Clear();
                    textBoxDescription.Clear();
                    groupBoxInfo.Enabled = false;
                    toolDelete.Enabled = false;
                    toolEditView.Enabled = false;
                }
            }
        }
    }

}
