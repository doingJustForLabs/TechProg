using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Lab9
{
    static public class CSVManager
    {
        public static (List<string>, List<List<double>>) LoadCsv(string path)
        {
            var lines = File.ReadAllLines(path);
            var headers = lines[0].Split(',').ToList();
            var series = new List<List<double>>();

            for (int i = 0; i < headers.Count; i++)
                series.Add(new List<double>());

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');
                for (int j = 0; j < parts.Length; j++)
                {
                    if (double.TryParse(parts[j], out double val))
                        series[j].Add(val);
                    else
                        series[j].Add(0);
                }
            }
            return (headers, series);
        }
    }
}
