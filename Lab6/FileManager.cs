using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lab6
{
    public static class FileManager
    {
        public static void DataToRezFile(string fileName, int idx, int[] x, int[] y)
        {
            using (BinaryWriter writer = new BinaryWriter(File.Open(fileName, FileMode.Create)))
            {
                writer.Write(x.Length);
                writer.Write(y.Length);

                foreach (var val in x)
                {
                    writer.Write(val);
                }

                foreach (var val in y)
                {
                    writer.Write(val);
                }

                foreach (var xi in x)
                {
                    foreach (var yj in y)
                    {
                        writer.Write(CalculateManager.G(xi, yj));        
                    }
                }
            }
        }

        public static void RezFileToData(DataGridView dataGridView, string fileName, TextBox ulCoords, TextBox brCoords)
        {
            try
            {
                if (!TryParsePoint(ulCoords.Text, out Point point1) || !TryParsePoint(brCoords.Text, out Point point2))
                {
                    MessageBox.Show("Некорректный формат точки!");
                    return;
                }

                using (BinaryReader reader = new BinaryReader(File.Open(fileName, FileMode.Open)))
                {
                    int nx = reader.ReadInt32();
                    int ny = reader.ReadInt32();

                    if (point1.X < 0 || point2.X >= nx || point1.Y < 0 || point2.Y >= ny)
                    {
                        MessageBox.Show("Координаты выходят за границы данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    int subNx = point2.X - point1.X + 1;
                    int subNy = point2.Y - point1.Y + 1;

                    reader.BaseStream.Seek(sizeof(int) * (2 + point1.X), SeekOrigin.Begin);
                    int[] xValues = new int[subNx];
                    for (int i = 0; i < subNx; i++)
                    {
                        xValues[i] = reader.ReadInt32();
                    }

                    reader.BaseStream.Seek(sizeof(int) * (2 + nx + point1.Y), SeekOrigin.Begin);
                    int[] yValues = new int[subNy];
                    for (int j = 0; j < subNy; j++)
                    {
                        yValues[j] = reader.ReadInt32();
                    }

                    long resultOffset = sizeof(int) * (2 + nx + ny) +
                                      sizeof(double) * (point1.Y * nx + point1.X);
                    reader.BaseStream.Seek(resultOffset, SeekOrigin.Begin);

                    double[,] result = new double[subNx, subNy];
                    for (int i = 0; i < subNx; i++)
                    {
                        if (i > 0)
                        {
                            reader.BaseStream.Seek(sizeof(double) * (nx - subNy), SeekOrigin.Current);
                        }

                        for (int j = 0; j < subNy; j++)
                        {
                            result[i, j] = reader.ReadDouble();
                        }
                    }

                    // Заполняем DataGridView
                    dataGridView.Columns.Clear();
                    dataGridView.Columns.Add("X_Header", "X \\ Y");

                    // Добавляем столбцы для y-значений
                    foreach (var yVal in yValues)
                    {
                        dataGridView.Columns.Add($"Y_{yVal}", yVal.ToString());
                    }

                    // Добавляем строки с данными
                    for (int i = 0; i < subNx; i++)
                    {
                        var row = new DataGridViewRow();
                        row.CreateCells(dataGridView);
                        row.Cells[0].Value = xValues[i];

                        for (int j = 0; j < subNy; j++)
                        {
                            row.Cells[j + 1].Value = result[i, j];
                        }

                        dataGridView.Rows.Add(row);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка чтения файла",
                               MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static bool TryParsePoint(string input, out Point point)
        {
            point = null;
            if (string.IsNullOrWhiteSpace(input)) return false;

            try
            {
                var parts = input.Trim('(', ')').Split(';');
                if (parts.Length != 2) return false;

                point = new Point
                {
                    X = int.Parse(parts[0].Trim()),
                    Y = int.Parse(parts[1].Trim())
                };
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
    public class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
