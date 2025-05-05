using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using ZedGraph;
using static Lab9.CSVManager;
using static Lab9.GraphicManager;

namespace Lab9
{
    public partial class Form1 : Form
    {
        private readonly ColorDialog colorDialog = new ColorDialog();
        private Dictionary<TabPage, ChartType> chartTypesByTab = new Dictionary<TabPage, ChartType>();

        public Form1()
        {
            InitializeComponent();

            comboBoxChartType.DataSource = Enum.GetValues(typeof(ChartType));
            comboBoxXAxis.Items.AddRange(new string[] { "Обычная", "Логарифмическая" });
            comboBoxYAxis.Items.AddRange(new string[] { "Обычная", "Логарифмическая" });
            comboBoxXAxis.SelectedIndex = 0;
            comboBoxYAxis.SelectedIndex = 0;

            panelColorPreview.BackColor = Color.White;
            tabControl.TabPages.Clear();
            tabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            panelColorPreview.Click += PanelColorPreview_Click;
        }

        private void buttonCreateGraph_Click(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog ofd = new OpenFileDialog())
                {
                    ofd.Filter = "CSV files (*.csv)|*.csv";
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        var data = LoadCsv(ofd.FileName);

                        if (data.Item1.Count < 2)
                        {
                            MessageBox.Show("Нужно как минимум две серии данных (X и минимум два Y).");
                            return;
                        }

                        string title = textBoxGraphTitle.Text.Trim();

                        if (string.IsNullOrWhiteSpace(title))
                            title = $"Вариант {tabControl.TabPages.Count + 1}";

                        CreateGraphTab(data.Item1, data.Item2, (ChartType)comboBoxChartType.SelectedItem, title);
                    }
                }

                settingsGroupBox.Enabled = true;
                applyChangesBtn.Enabled = true;
                diagramGroupBox.Enabled = true;
                axesGroupBox.Enabled = true;
                dataGroupBox.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void CreateGraphTab(List<string> headers, List<List<double>> series, ChartType chartType, string title)
        {
            var tab = new TabPage(title);

            var zed = new ZedGraphControl { Dock = DockStyle.Fill };
            CreateGraph(zed, headers, series, chartType, title);
            chartTypesByTab[tab] = chartType;

            var panel = new Panel
            {
                Dock = DockStyle.Bottom,
                Height = 40
            };

            var btnDelete = new Button
            {
                Text = "Удалить график",
                Width = 120,
                Left = 10,
                Top = 5
            };

            btnDelete.Click += (s, e) =>
            {
                var result = MessageBox.Show("Вы уверены, что хотите удалить этот график?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tabControl.TabPages.Remove(tab);
                }
            };

            panel.Controls.Add(btnDelete);
            tab.Controls.Add(zed);
            tab.Controls.Add(panel);
            tabControl.TabPages.Add(tab);
            tabControl.SelectedTab = tab;
            currentGraphicTextBox.Text = tab.Text;
        }

        private ZedGraphControl GetCurrentGraph()
        {
            if (tabControl.SelectedTab != null)
            {
                return tabControl.SelectedTab.Controls
                    .OfType<ZedGraphControl>()
                    .FirstOrDefault();
            }
            return null;
        }

        private void ApplyFormatting()
        {
            var zgc = GetCurrentGraph();
            if (zgc == null)
            {
                MessageBox.Show("График не найден.");
                return;
            }

            var pane = zgc.GraphPane;

            pane.Legend.IsVisible = checkBoxLegend.Checked;

            float width = (float)numericLineWidth.Value;
            foreach (var curve in pane.CurveList)
            {
                if (curve is LineItem li)
                    li.Line.Width = width;
            }

            pane.XAxis.Type = comboBoxXAxis.SelectedItem?.ToString() == "Логарифмическая" ? AxisType.Log : AxisType.Linear;
            pane.YAxis.Type = comboBoxYAxis.SelectedItem?.ToString() == "Логарифмическая" ? AxisType.Log : AxisType.Linear;

            pane.Chart.Fill = new Fill(panelColorPreview.BackColor);

            zgc.AxisChange();
            zgc.Invalidate();
        }

        private void applyChangesBtn_Click(object sender, EventArgs e)
        {
            ApplyFormatting();
            MessageBox.Show("График обновлён!");
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            var zgc = GetCurrentGraph();
            if (zgc == null)
            {
                currentGraphicTextBox.Text = "";
                settingsGroupBox.Enabled = false;
                diagramGroupBox.Enabled = false;
                dataGroupBox.Enabled = false;
                axesGroupBox.Enabled = false;
                return;
            }

            var pane = zgc.GraphPane;
            currentGraphicTextBox.Text = tabControl.SelectedTab.Text;
            checkBoxLegend.Checked = pane.Legend.IsVisible;

            if (pane.CurveList.Count > 0 && pane.CurveList[0] is LineItem li)
            {
                numericLineWidth.Value = (decimal)li.Line.Width;
            }

            comboBoxXAxis.SelectedItem = pane.XAxis.Type == AxisType.Log ? "Логарифмическая" : "Обычная";
            comboBoxYAxis.SelectedItem = pane.YAxis.Type == AxisType.Log ? "Логарифмическая" : "Обычная";

            panelColorPreview.BackColor = pane.Chart.Fill.Type == FillType.Solid
                ? pane.Chart.Fill.Color
                : Color.White;

            settingsGroupBox.Enabled = true;
            axesGroupBox.Enabled = true;

            if (chartTypesByTab.TryGetValue(tabControl.SelectedTab, out ChartType currentType))
            {
                dataGroupBox.Enabled = currentType == ChartType.Line;
            }
            else
            {
                dataGroupBox.Enabled = false;
            }
        }

        private void PanelColorPreview_Click(object sender, EventArgs e)
        {
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                panelColorPreview.BackColor = colorDialog.Color;
            }
        }
    }
}
