using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace lab5_2_sharp
{
    public class DataLoader
    {
        private readonly CultureInfo _culture = CultureInfo.InvariantCulture;

        public CalculationData LoadFromFile(string filePath)
        {
            try
            {
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException($"Файл не найден: {filePath}");
                }

                var lines = File.ReadAllLines(filePath)
                              .Where(line => !string.IsNullOrWhiteSpace(line))
                              .ToArray();

                if (lines.Length < 3)
                {
                    throw new Exception("Файл слишком короткий или поврежден");
                }

                int tableStart = -1;
                for (int i = 0; i < lines.Length; i++)
                {
                    if (lines[i].Contains("y\\x"))
                    {
                        tableStart = i;
                        break;
                    }
                }

                if (tableStart == -1) throw new Exception("Не найдена строка с заголовком таблицы (y\\x)");

                var xHeaders = lines[tableStart].Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                var xValues = new double[xHeaders.Length - 1];
                for (int i = 1; i < xHeaders.Length; i++)
                {
                    if (!double.TryParse(xHeaders[i].Trim(), NumberStyles.Any, _culture, out xValues[i - 1]))
                    {
                        throw new Exception($"Неверный формат X значения: {xHeaders[i]}");
                    }
                }

                var yValues = new List<double>();
                var results = new List<double[]>();

                for (int i = tableStart + 1; i < lines.Length; i++)
                {
                    var parts = lines[i].Split(new[] { '\t' }, StringSplitOptions.RemoveEmptyEntries);
                    if (parts.Length < 2) continue;

                    if (!double.TryParse(parts[0].Trim(), NumberStyles.Any, _culture, out double yValue))
                    {
                        throw new Exception($"Неверный формат Y значения: {parts[0]}");
                    }
                    yValues.Add(yValue);

                    var row = new double[xValues.Length];
                    for (int j = 1; j < parts.Length && j - 1 < row.Length; j++)
                    {
                        if (parts[j] == "NaN")
                        {
                            row[j - 1] = double.NaN;
                        }
                        else if (!double.TryParse(parts[j].Trim(), NumberStyles.Any, _culture, out row[j - 1]))
                        {
                            throw new Exception($"Неверный формат значения в строке {i}, столбце {j}: {parts[j]}");
                        }
                    }
                    results.Add(row);
                }

                var data = new CalculationData
                {
                    FileName = Path.GetFileName(filePath),
                    FilePath = filePath,
                    XValues = xValues,
                    YValues = yValues.ToArray(),
                    Results = ConvertTo2DArray(results)
                };

                return data;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файла:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
                return null;
            }
        }

        private double[,] ConvertTo2DArray(List<double[]> list)
        {
            if (list.Count == 0) return new double[0, 0];

            int rows = list.Count;
            int cols = list[0].Length;
            var array = new double[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = list[i][j];
                }
            }

            return array;
        }
    }

    public class CalculationData
    {
        public string FileName { get; set; }
        public string FilePath { get; set; }
        public string Function { get; set; }
        public double[] XValues { get; set; }
        public double[] YValues { get; set; }
        public double[,] Results { get; set; }
    }
}