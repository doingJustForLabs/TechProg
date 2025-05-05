using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace lab9_gauge_knob
{
    public partial class GraphEditView : Form
    {
        private ZedGraphControl GraphControl;
        private GraphPane Pane;
        private GraphPane BackupPane;
        public GraphEditView(ZedGraphControl control)
        {
            GraphControl = control;
            Pane = GraphControl.GraphPane;
            BackupPane = CloneGraphPane(Pane);
            InitializeComponent();
            InitializeGraphInfo();
        }

        private void InitializeGraphInfo()
        {

            // Надписи

            textBoxTitle.Text = BackupPane.Title.Text;
            textBoxX.Text = BackupPane.XAxis.Title.Text;
            textBoxY.Text = BackupPane.YAxis.Title.Text;
            checkBoxLegend.Checked = BackupPane.Legend.IsVisible;

            dataGridViewLegend.Rows.Clear();
            int index = 1;
            foreach (CurveItem curve in BackupPane.CurveList)
            {
                dataGridViewLegend.Rows.Add(index, curve.Label.Text);
                index++;
            }

            // Оси

            checkBoxXShow.Checked = BackupPane.XAxis.IsVisible;
            numeriсXThickness.Value = (decimal) BackupPane.XAxis.MajorTic.PenWidth;
            buttonXColorSelect.BackColor = BackupPane.XAxis.Color;

            checkBoxYShow.Checked = BackupPane.YAxis.IsVisible;
            numeriсYThickness.Value = (decimal)BackupPane.YAxis.MajorTic.PenWidth;
            buttonYColorSelect.BackColor = BackupPane.YAxis.Color;

            checkBoxGridShow.Checked = BackupPane.XAxis.MajorGrid.IsVisible;
            buttonGridColorSelect.BackColor = BackupPane.XAxis.MajorGrid.Color;

            numericMajorTicsLength.Value = (decimal)BackupPane.XAxis.MajorTic.Size;
            numericMinorTicsLength.Value = (decimal)BackupPane.XAxis.MinorTic.Size;


            // Серии данных

            dataGridViewSeriesStyles.Rows.Clear();
            int seriesIndex = 1;
            foreach (CurveItem curve in BackupPane.CurveList)
            {
                int rowIndex = dataGridViewSeriesStyles.Rows.Add();
                var row = dataGridViewSeriesStyles.Rows[rowIndex];

                row.Cells["SeriaNumber"].Value = seriesIndex;
                row.Cells["SeriaShow"].Value = curve.IsVisible;

                var colorCell = (DataGridViewButtonCell)row.Cells["SeriaColor"];
                colorCell.Style.BackColor = curve.Color;
                colorCell.Style.SelectionBackColor = curve.Color;
                colorCell.FlatStyle = FlatStyle.Flat;
                colorCell.Value = "";

                seriesIndex++;
            }

        }

        private GraphPane CloneGraphPane(GraphPane source)
        {
            GraphPane clone = new GraphPane();

            // Заголовки
            clone.Title.Text = source.Title.Text;
            clone.XAxis.Title.Text = source.XAxis.Title.Text;
            clone.YAxis.Title.Text = source.YAxis.Title.Text;

            // Легенда
            clone.Legend.IsVisible = source.Legend.IsVisible;

            // Оси: X
            clone.XAxis.IsVisible = source.XAxis.IsVisible;
            clone.XAxis.Color = source.XAxis.Color;
            clone.XAxis.MajorTic.PenWidth = source.XAxis.MajorTic.PenWidth;
            clone.XAxis.MinorTic.PenWidth = source.XAxis.MinorTic.PenWidth;
            clone.XAxis.MajorTic.Size = source.XAxis.MajorTic.Size;
            clone.XAxis.MinorTic.Size = source.XAxis.MinorTic.Size;
            clone.YAxis.MajorGrid.IsZeroLine = source.XAxis.IsVisible;

            // Оси: Y
            clone.YAxis.IsVisible = source.YAxis.IsVisible;
            clone.YAxis.Color = source.YAxis.Color;
            clone.YAxis.MajorTic.PenWidth = source.YAxis.MajorTic.PenWidth;
            clone.YAxis.MinorTic.PenWidth = source.YAxis.MinorTic.PenWidth;
            clone.YAxis.MajorTic.Size = source.YAxis.MajorTic.Size;
            clone.YAxis.MinorTic.Size = source.YAxis.MinorTic.Size;
            clone.XAxis.MajorGrid.IsZeroLine = source.YAxis.IsVisible;

            // Сетка
            clone.XAxis.MajorGrid.IsVisible = source.XAxis.MajorGrid.IsVisible;
            clone.YAxis.MajorGrid.IsVisible = source.YAxis.MajorGrid.IsVisible;
            clone.XAxis.MajorGrid.Color = source.XAxis.MajorGrid.Color;
            clone.YAxis.MajorGrid.Color = source.YAxis.MajorGrid.Color;
            clone.XAxis.MajorGrid.PenWidth = source.XAxis.MajorGrid.PenWidth;
            clone.YAxis.MajorGrid.PenWidth = source.YAxis.MajorGrid.PenWidth;

            // Серии данных
            foreach (CurveItem curve in source.CurveList)
            {
                if (curve is LineItem line)
                {
                    IPointList points = line.Points;
                    PointPairList newPoints = new PointPairList();
                    for (int i = 0; i < points.Count; i++)
                    {
                        var pt = points[i];
                        newPoints.Add(pt.X, pt.Y);
                    }

                    var newLine = new LineItem(line.Label.Text, newPoints, line.Color, line.Symbol.Type)
                    {
                        IsVisible = line.IsVisible,
                        Line = { Width = line.Line.Width }
                    };

                    clone.CurveList.Add(newLine);
                }
            }

            return clone;
        }


        private void buttonOK_Click(object sender, EventArgs e)
        {
            // Названия графика и осей
            
            Pane.XAxis.Title.Text = textBoxX.Text;
            Pane.YAxis.Title.Text = textBoxY.Text;

            // Легенда
            Pane.Legend.IsVisible = checkBoxLegend.Checked;

            // Подписи серий
            for (int i = 0; i < dataGridViewLegend.Rows.Count; i++)
            {
                if (i < Pane.CurveList.Count)
                {
                    var cellValue = dataGridViewLegend.Rows[i].Cells[1].Value;
                    if (cellValue != null)
                    {
                        Pane.CurveList[i].Label.Text = cellValue.ToString();
                    }
                }
            }

            // Оси X
            Pane.XAxis.IsVisible = checkBoxXShow.Checked;
            Pane.XAxis.Color = buttonXColorSelect.BackColor;
            Pane.XAxis.MajorTic.PenWidth = (float)numeriсXThickness.Value;
            Pane.YAxis.MajorGrid.IsZeroLine = Pane.XAxis.IsVisible;

            // Оси Y
            Pane.YAxis.IsVisible = checkBoxYShow.Checked;
            Pane.YAxis.Color = buttonYColorSelect.BackColor;
            Pane.YAxis.MajorTic.PenWidth = (float)numeriсYThickness.Value;
            Pane.XAxis.MajorGrid.IsZeroLine = Pane.YAxis.IsVisible;

            // Сетка
            Pane.XAxis.MajorGrid.IsVisible = checkBoxGridShow.Checked;
            Pane.XAxis.MajorGrid.Color = buttonGridColorSelect.BackColor;
            Pane.YAxis.MajorGrid.IsVisible = checkBoxGridShow.Checked;
            Pane.YAxis.MajorGrid.Color = buttonGridColorSelect.BackColor;

            // Толщины засечек
            Pane.XAxis.MajorTic.Size = (float)numericMajorTicsLength.Value;
            Pane.XAxis.MinorTic.Size = (float)numericMinorTicsLength.Value;
            Pane.YAxis.MajorTic.Size = (float)numericMajorTicsLength.Value;
            Pane.YAxis.MinorTic.Size = (float)numericMinorTicsLength.Value;

            // Серии
            for (int i = 0; i < dataGridViewSeriesStyles.Rows.Count; i++)
            {
                if (i < Pane.CurveList.Count)
                {
                    var curve = Pane.CurveList[i];

                    var visibleCell = dataGridViewSeriesStyles.Rows[i].Cells["SeriaShow"] as DataGridViewCheckBoxCell;
                    if (visibleCell?.Value != null && bool.TryParse(visibleCell.Value.ToString(), out bool isVisible))
                    {
                        curve.IsVisible = isVisible;
                    }

                    var colorCell = dataGridViewSeriesStyles.Rows[i].Cells["SeriaColor"];
                    if (colorCell?.Style.BackColor != null)
                    {
                        curve.Color = colorCell.Style.BackColor;
                    }
                }
            }

            Pane.AxisChange();
            GraphControl.Invalidate();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonXColorSelect_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = buttonXColorSelect.BackColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    buttonXColorSelect.BackColor = colorDialog.Color;
                }
            }
        }

        private void buttonYColorSelect_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = buttonYColorSelect.BackColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    buttonYColorSelect.BackColor = colorDialog.Color;
                }
            }
        }

        private void buttonGridColorSelect_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                colorDialog.Color = buttonGridColorSelect.BackColor;
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    buttonGridColorSelect.BackColor = colorDialog.Color;
                }
            }
        }

        private void dataGridViewSeriesStyles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            if (dataGridViewSeriesStyles.Columns[e.ColumnIndex].Name == "SeriaColor")
            {
                var cell = dataGridViewSeriesStyles.Rows[e.RowIndex].Cells[e.ColumnIndex] as DataGridViewButtonCell;

                using (ColorDialog colorDialog = new ColorDialog())
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        Color selectedColor = colorDialog.Color;
                        cell.Style.BackColor = selectedColor;
                        cell.Style.SelectionBackColor = selectedColor;
                    }
                }
            }
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            Pane.Title.Text = textBoxTitle.Text;
        }

        private void buttonRecover_Click(object sender, EventArgs e)
        {
            InitializeGraphInfo();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {

            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
