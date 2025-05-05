using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Lab9
{
    public static class DataReader
    {
        public static Seria<object>[] ReadFromCSV(string path, GraphType type)
        {
            try
            {
                string[] lines = File.ReadAllLines(path);

                if (lines.Length == 0)
                {
                    MessageBox.Show("Ошибка при чтении CSV:\nФайл пуст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return null;
                }

                int numberOfColumns = lines[0].Split(',').Length;

                if (!Graph<object>.IsCategoricalType(type))
                {
                    List<Seria<object>> seriesP = new List<Seria<object>>();
                    List<object[]> pointsSeries = new List<object[]>();

                    for (int columnIndex = 1; columnIndex < numberOfColumns; columnIndex++)
                    {
                        List<object> points = new List<object>();
                        for (int i = 0; i < lines.Length; i++)
                        {
                            string[] parts = lines[i].Split(',');
                            if (parts.Length < 2) continue;

                            if (float.TryParse(parts[0].Replace('.', ','), out float x) && float.TryParse(parts[columnIndex].Replace('.', ','), out float y))
                            {
                                points.Add(new Point { X = x, Y = y });
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при чтении CSV:\nНечисловое значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                        }

                        if (points.Count > 0)
                        {
                            pointsSeries.Add(points.ToArray());
                        }
                    }

                    foreach (var pointsArray in pointsSeries)
                    {
                        seriesP.Add(new Seria<object> { Points = pointsArray, Count = pointsArray.Length });
                    }


                    return seriesP.ToArray();
                }
                else
                {
                    List<Seria<object>> seriesC = new List<Seria<object>>();
                    List<object[]> categorySeries = new List<object[]>();

                    for (int columnIndex = 1; columnIndex < numberOfColumns; columnIndex++)
                    {
                        List<object> categories = new List<object>();
                        for (int i = 0; i < lines.Length; i++)
                        {
                            string[] parts = lines[i].Split(',');
                            if (parts.Length < 2) continue;

                            if (float.TryParse(parts[columnIndex], out float value))
                            {
                                categories.Add(new Category { Label = parts[0], Value = value });
                            }
                            else
                            {
                                MessageBox.Show("Ошибка при чтении CSV:\nНечисловое значение.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                return null;
                            }
                        }

                        if (categories.Count > 0)
                        {
                            categorySeries.Add(categories.ToArray());
                        }
                    }

                    foreach (var categoryArray in categorySeries)
                    {
                        seriesC.Add(new Seria<object> { Points = categoryArray, Count = categoryArray.Length });
                    }

                    return seriesC.ToArray();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении CSV: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
