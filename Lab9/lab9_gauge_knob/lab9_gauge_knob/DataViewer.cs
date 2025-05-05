using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace Lab9
{
    public partial class DataViewer : Form
    {
        public DataViewer(Graph<dynamic> graph)
        {
            InitializeComponent();

            DataTable table = new DataTable();

            if (Graph<object>.IsCategoricalType(graph.Type))
            {
                SortedSet<string> allLabels = new SortedSet<string>();

                foreach (var seria in graph.Series)
                {
                    foreach (var item in seria.Points)
                    {
                        if (item is Category cat)
                            allLabels.Add(cat.Label);
                    }
                }

                table.Columns.Add("Категория", typeof(string));

                for (int i = 0; i < graph.Series.Length; i++)
                {
                    table.Columns.Add($"V{i + 1}", typeof(float));
                }

                foreach (string label in allLabels)
                {
                    DataRow row = table.NewRow();
                    row["Категория"] = label;

                    for (int i = 0; i < graph.Series.Length; i++)
                    {
                        var seria = graph.Series[i];
                        var match = seria.Points.Cast<Category?>().FirstOrDefault(p => p?.Label == label);
                        if (match != null)
                        {
                            row[i + 1] = match.Value.Value;
                        }
                    }

                    table.Rows.Add(row);
                }
            }
            else
            {
                SortedSet<float> allX = new SortedSet<float>();

                foreach (var seria in graph.Series)
                {
                    foreach (var item in seria.Points)
                    {
                        if (item is Point pt)
                            allX.Add(pt.X);
                    }
                }

                table.Columns.Add("X", typeof(float));

                for (int i = 0; i < graph.Series.Length; i++)
                {
                    table.Columns.Add($"Y{i + 1}", typeof(float));
                }

                foreach (float x in allX)
                {
                    DataRow row = table.NewRow();
                    row["X"] = x;

                    for (int i = 0; i < graph.Series.Length; i++)
                    {
                        var seria = graph.Series[i];
                        var match = seria.Points.Cast<Point?>().FirstOrDefault(p => p?.X == x);
                        if (match != null)
                        {
                            row[i + 1] = match.Value.Y;
                        }
                    }

                    table.Rows.Add(row);
                }
            }

            dataGridView.DataSource = table;
        }
    }
}
