using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_2_sharp
{
    public static class PointGenerator
    {
        public static (List<double> XValues, List<double> YValues) GeneratePoints(
            double xStart, double xEnd, double xStep,
            double yStart, double yCount, double yStep)
        {
            var xValues = new List<double>();
            for (double x = xStart; x <= xEnd; x += xStep)
            {
                xValues.Add(x);
            }

            var yValues = new List<double>();
            for (int i = 0; i < yCount; i++)
            {
                yValues.Add(yStart + i * yStep);
            }

            return (xValues, yValues);
        }

        public static List<string> FormatPoints(List<double> xValues, List<double> yValues)
        {
            var lines = new List<string>
            {
                "Точки для расчета:",
                "",
                "Значения X:"
            };

            lines.AddRange(xValues.Select((x) => $"{x:F2}"));

            lines.Add("");
            lines.Add("Значения Y:");
            lines.AddRange(yValues.Select((y) => $"{y:F2}"));

            return lines;
        }
    }
}