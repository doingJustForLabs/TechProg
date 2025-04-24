using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_2_sharp
{
    public static class PointGenerator
    {
        public static (double[] XValues, double[] YValues) GeneratePoints(
            double xStart, double xEnd, double xStep,
            double yStart, int yCount, double yStep)
        {
            int xPointsCount = (int)((xEnd - xStart) / xStep) + 1;
            double[] xValues = new double[xPointsCount];
            for (int i = 0; i < xPointsCount; i++)
            {
                xValues[i] = xStart + i * xStep;
            }

            double[] yValues = new double[yCount];
            for (int i = 0; i < yCount; i++)
            {
                yValues[i] = yStart + i * yStep;
            }

            return (xValues, yValues);
        }

        public static List<string> FormatPoints(double[] xValues, double[] yValues)
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