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

namespace lab9
{
    public partial class FormatSettingsForm: Form
    {
        private GraphPane targetPane;
        public string AxisType { get; private set; } = "Linear";
        public bool ShowGrid { get; private set; } = false;
        public Color GridColor { get; private set; } = Color.LightGray;
        public List<Color> MarkerColors { get; private set; } = new List<Color>();

        private List<Button> markerColorButtons = new List<Button>();

        private Button gridColorButton;

        public string ChartTitle { get; private set; } = "Вариант 31";
        public string XAxisTitle { get; private set; } = "Ось X";
        public string YAxisTitle { get; private set; } = "Ось Y";

        private TextBox textBoxChartTitle;
        private TextBox textBoxXAxisTitle;
        private TextBox textBoxYAxisTitle;

        public FormatSettingsForm(GraphPane pane, bool showGrid, Color gridColor)
        {
            InitializeComponent();
            this.targetPane = pane;
            this.ShowGrid = showGrid;
            this.GridColor = gridColor;
            InitMe(pane.CurveList.Count);
        }

        private void InitMe(int count)
        {
            int currentTop = 120;

            var labelChartTitle = new System.Windows.Forms.Label() { Text = "Заголовок диаграммы", Left = 10, Top = currentTop + 5 };
            textBoxChartTitle = new TextBox() { Left = 150, Top = currentTop, Width = 170, Text = ChartTitle };
            this.Controls.Add(labelChartTitle);
            this.Controls.Add(textBoxChartTitle);
            currentTop += 40;

            var labelXAxisTitle = new System.Windows.Forms.Label() { Text = "Заголовок оси X", Left = 10, Top = currentTop + 5 };
            textBoxXAxisTitle = new TextBox() { Left = 150, Top = currentTop, Width = 170, Text = XAxisTitle };
            this.Controls.Add(labelXAxisTitle);
            this.Controls.Add(textBoxXAxisTitle);
            currentTop += 40;

            var labelYAxisTitle = new System.Windows.Forms.Label() { Text = "Заголовок оси Y", Left = 10, Top = currentTop + 5 };
            textBoxYAxisTitle = new TextBox() { Left = 150, Top = currentTop, Width = 170, Text = YAxisTitle };
            this.Controls.Add(labelYAxisTitle);
            this.Controls.Add(textBoxYAxisTitle);
            currentTop += 40;

            for (int i = 0; i < count; i++)
            {
                var label = new System.Windows.Forms.Label() { Text = $"Серия {i + 1}", Left = 10, Top = currentTop + 5 };
                var button = new Button() { Text = "Выбрать цвет", Left = 150, Top = currentTop, Width = 170 };
                int index = i;

                var currentColor = targetPane.CurveList[i] is LineItem line ? line.Color : Color.Blue;

                button.BackColor = currentColor;

                button.Click += (s, e) =>
                {
                    if (colorDialog1.ShowDialog() == DialogResult.OK)
                    {
                        MarkerColors[index] = colorDialog1.Color;
                        button.BackColor = colorDialog1.Color;
                    }
                };

                this.Controls.Add(label);
                this.Controls.Add(button);
                markerColorButtons.Add(button);
                MarkerColors.Add(currentColor); // начальное значение
                currentTop += 40;
            }

            var gridColorLabel = new System.Windows.Forms.Label() { Text = "Цвет сетки", Left = 10, Top = currentTop + 5 };
            var gridColorButton = new Button() { Text = "Выбрать цвет сетки", Left = 150, Top = currentTop, Width = 170 };
            gridColorButton.BackColor = GridColor;

            gridColorButton.Click += (s, e) =>
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    GridColor = colorDialog1.Color;
                    gridColorButton.BackColor = colorDialog1.Color;
                }
            };
            this.Controls.Add(gridColorLabel);
            this.Controls.Add(gridColorButton);
            currentTop += 40;
        }

        private void FormatSettingsForm_Load(object sender, EventArgs e)
        {
            comboBoxAxisType.SelectedIndex = comboBoxAxisType.Items.IndexOf(AxisType);
            checkBoxGrid.Checked = ShowGrid;
            if (gridColorButton != null)
            {
                gridColorButton.BackColor = GridColor;
            }
        }

        private void buttonApply_Click(object sender, EventArgs e)
        {
            ChartTitle = textBoxChartTitle.Text;
        XAxisTitle = textBoxXAxisTitle.Text;
        YAxisTitle = textBoxYAxisTitle.Text;

            AxisType = comboBoxAxisType.SelectedItem?.ToString() ?? "Linear";
            ShowGrid = checkBoxGrid.Checked;
            if (gridColorButton != null)
            {
                GridColor = gridColorButton.BackColor;
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
