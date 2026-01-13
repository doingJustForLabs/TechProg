using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;
using System.IO;
using System.Globalization;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Color GridColor { get; set; } = Color.LightGray;
        public bool ShowGrid { get; set; } = false;
        public Form1()
        {
            InitializeComponent();
            TabControl tabControl = new TabControl
            {
                Dock = DockStyle.Fill,
                Parent = this
            };
            comboBoxChartType.SelectedIndex = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void buttonLoadData_Click(object sender, EventArgs e)
        {
            var currentTab = tabControl.SelectedTab;
            if (currentTab == null) return;

            var zgc = currentTab.Controls.OfType<ZedGraphControl>().FirstOrDefault();
            if (zgc == null) return;

            LoadData(zgc);
        }

        private void buttonChangeChartType_Click(object sender, EventArgs e)
        {
            var currentTab = tabControl.SelectedTab;
            if (currentTab == null) return;

            var zgc = currentTab.Controls.OfType<ZedGraphControl>().FirstOrDefault();
            if (zgc == null) return;

            ChangeChartType(zgc);
        }


        private void buttonCreateTab_Click(object sender, EventArgs e)
        {
            var newTab = new TabPage($"{tabControl.TabCount + 1}");
            var zedGraphControl = new ZedGraphControl()
            {
                Dock = DockStyle.Fill
            };
            newTab.Controls.Add(zedGraphControl);
            tabControl.TabPages.Add(newTab);
            tabControl.SelectedTab = newTab;
        }

        private void LoadData(ZedGraphControl zedGraphControl)
        {
            zedGraphControl.GraphPane.CurveList.Clear();
            zedGraphControl.Invalidate();

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "CSV Files|*.csv";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(openFileDialog.FileName);

                        if(lines.Length < 2)
                            throw new Exception("Файл должен содержать как минимум заголовок и одну строку данных.");

                        string[] headers = lines[0].Split(';');

                        // Преобразуем данные в точки и добавляем на график
                        var dataPoints = new List<PointPairList>();

                        foreach (var line in lines.Skip(1))
                        {
                            var parts = line.Split(';');
                            for (int i = dataPoints.Count; i < parts.Length - 1; i++)
                            {
                                dataPoints.Add(new PointPairList());
                            }

                            double x = double.Parse(parts[0], CultureInfo.InvariantCulture);
                            for (int i = 1; i < parts.Length; i++)
                            {
                                double y = double.Parse(parts[i], CultureInfo.InvariantCulture);  // Читаем каждую серию y
                                dataPoints[i - 1].Add(x, y);
                            }
                        }

                        for (int i = 0; i < dataPoints.Count; i++)
                        {
                            //AddSeriesToChart(zedGraphControl, dataPoints[i], $"Серия {i + 1}");
                            string seriesName = headers.Length > i + 1 ? headers[i + 1] : $"Серия {i + 1}";
                            AddSeriesToChart(zedGraphControl, dataPoints[i], seriesName);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка: {ex.Message}");
                    }
                }
            }
        }

        private void AddSeriesToChart(ZedGraphControl zedGraphControl, PointPairList pointList, string seriesName)
        {
            GraphPane graphPane = zedGraphControl.GraphPane;

            graphPane.Title.Text = "Вариант 31";
            graphPane.XAxis.Title.Text = "Ось X";
            graphPane.YAxis.Title.Text = "Ось Y";

            LineItem curve = graphPane.AddCurve(seriesName, pointList, Color.Blue, SymbolType.Circle);

            curve.Line.Width = 2.0F;  // Ширина линии
            curve.Symbol.Size = 5;     // Размер маркера
            curve.Symbol.Fill = new Fill(Color.Red);  // Цвет маркера


            zedGraphControl.Invalidate();
        }

        private void ChangeChartType(ZedGraphControl zedGraphControl)
        {
            // Меняем тип графика

            GraphPane pane = zedGraphControl.GraphPane;

            //if (pane.CurveList.Count > 0)
            //{
            //    var curve = pane.CurveList[0] as LineItem;
            //    curve.Line.Style = curve.Line.Style == System.Drawing.Drawing2D.DashStyle.Solid ? System.Drawing.Drawing2D.DashStyle.Dot : System.Drawing.Drawing2D.DashStyle.Solid;
            //}
            foreach (var curve in pane.CurveList.OfType<LineItem>())
            {
                if (comboBoxChartType.SelectedItem?.ToString() == "Точечная")
                {
                    curve.Line.IsVisible = false;
                    curve.Symbol.Type = SymbolType.Circle;
                }
                else  // Линейная
                {
                    curve.Line.IsVisible = true;
                    curve.Symbol.Type = SymbolType.Star;
                }
            }

            zedGraphControl.Invalidate();
        }

        private void OpenFormatSettings(ZedGraphControl zedGraphControl)
        {
            using (var form = new FormatSettingsForm(zedGraphControl.GraphPane, ShowGrid, GridColor))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    ApplyFormatting(zedGraphControl, form);
                    ShowGrid = form.ShowGrid;
                    GridColor = form.GridColor;
                    zedGraphControl.Invalidate();
                }
            }
        }

        private void ApplyFormatting(ZedGraphControl zedGraphControl, FormatSettingsForm form)
        {
            GraphPane pane = zedGraphControl.GraphPane;

            pane.Title.Text = form.ChartTitle;
            pane.XAxis.Title.Text = form.XAxisTitle;
            pane.YAxis.Title.Text = form.YAxisTitle;

            // Применяем настройки осей
            if (form.AxisType != null)
            {
                switch (form.AxisType)
                {
                    case "Log":
                        pane.XAxis.Type = AxisType.Log;
                        pane.YAxis.Type = AxisType.Log;
                        break;
                    case "Linear":
                        pane.XAxis.Type = AxisType.Linear;
                        pane.YAxis.Type = AxisType.Linear;
                        break;
                    case "Date":
                        pane.XAxis.Type = AxisType.Date;
                        break;
                    case "Exponent":
                        pane.XAxis.Type = AxisType.Exponent;
                        break;
                    default:
                        pane.XAxis.Type = AxisType.Linear;
                        pane.YAxis.Type = AxisType.Linear;
                        break;
                }
            }

            pane.XAxis.MajorGrid.IsVisible = form.ShowGrid;
            pane.YAxis.MajorGrid.IsVisible = form.ShowGrid;
            pane.XAxis.MajorGrid.Color = form.GridColor;
            pane.YAxis.MajorGrid.Color = form.GridColor;

            // Применяем настройки маркеров для каждой серии
            for (int i = 0; i < form.MarkerColors.Count; i++)
            {
                if (i < pane.CurveList.Count && pane.CurveList[i] is LineItem li)
                {
                    li.Symbol.Fill.Color = form.MarkerColors.Count > i ? form.MarkerColors[i] : li.Color;
                    li.Color = form.MarkerColors.Count > i ? form.MarkerColors[i] : li.Color;
                }
            }

            //foreach (var curve in pane.CurveList)
            //{
            //    if (curve is LineItem line)
            //    {
            //        // Если тип линии не задан, ставим по дефолту Solid
            //        line.Line.Style = line.Line.Style == System.Drawing.Drawing2D.DashStyle.Solid ? line.Line.Style : System.Drawing.Drawing2D.DashStyle.Solid;
            //    }
            //}

            zedGraphControl.Invalidate();
        }

        private void buttonFormat_Click(object sender, EventArgs e)
        {
            var currentTab = tabControl.SelectedTab;
            if (currentTab == null) return;

            var zgc = currentTab.Controls.OfType<ZedGraphControl>().FirstOrDefault();
            if (zgc == null) return;

            //FormatActiveTabGraph();
            OpenFormatSettings(zgc);
        }

        //private void FormatActiveTabGraph()
        //{
        //    // Найдём текущую вкладку
        //    var currentTab = tabControl.SelectedTab;
        //    if (currentTab == null) return;

        //    var zgc = currentTab.Controls.OfType<ZedGraphControl>().FirstOrDefault();
        //    if (zgc == null) return;

        //    var pane = zgc.GraphPane;

        //    // Применим форматирование к существующим кривым
        //    foreach (var curve in pane.CurveList)
        //    {
        //        curve.Color = Color.DarkMagenta;
        //        if (curve is LineItem line)
        //        {
        //            line.Symbol.Type = SymbolType.Triangle;
        //            line.Symbol.Fill = new Fill(Color.Yellow);
        //        }
        //    }

        //    zgc.Invalidate();  // Обновить отображение
        //}

    }
}
