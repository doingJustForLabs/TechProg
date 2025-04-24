using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab5_2_sharp
{
    public class DataBinaryLoader
    {
        public CalculationData ReadFromBinaryFile(string filePath)
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            using (var reader = new BinaryReader(stream))
            {
                int xCount = reader.ReadInt32();
                int yCount = reader.ReadInt32();

                double[] xValues = new double[xCount];
                for (int i = 0; i < xCount; i++)
                    xValues[i] = reader.ReadDouble();

                double[] yValues = new double[yCount];
                for (int i = 0; i < yCount; i++)
                    yValues[i] = reader.ReadDouble();

                double[,] results = new double[yCount, xCount];
                for (int i = 0; i < yCount; i++)
                {
                    for (int j = 0; j < xCount; j++)
                    {
                        results[i, j] = reader.ReadDouble();
                    }
                }

                return new CalculationData
                {
                    FilePath = filePath,
                    XValues = xValues,
                    YValues = yValues,
                    Results = results
                };
            }
        }

        public CalculationData ReadSubmatrixFromBinaryFile(string filePath, int yStart, int xStart, int yEnd, int xEnd)
        {
            using (var stream = new FileStream(filePath, FileMode.Open))
            using (var reader = new BinaryReader(stream))
            {
                int xCount = reader.ReadInt32();
                int yCount = reader.ReadInt32();

                double[] xValuesFull = new double[xCount];
                for (int i = 0; i < xCount; i++)
                    xValuesFull[i] = reader.ReadDouble();

                double[] yValuesFull = new double[yCount];
                for (int i = 0; i < yCount; i++)
                    yValuesFull[i] = reader.ReadDouble();

                // Проверка границ
                if (xStart < 0 || xEnd >= xCount || yStart < 0 || yEnd >= yCount)
                    throw new ArgumentOutOfRangeException("Указанные координаты выходят за границы массива.");

                int subXCount = xEnd - xStart + 1;
                int subYCount = yEnd - yStart + 1;

                double[] xValues = xValuesFull.Skip(xStart).Take(subXCount).ToArray();
                double[] yValues = yValuesFull.Skip(yStart).Take(subYCount).ToArray();

                double[,] results = new double[subYCount, subXCount];

                // Перейти к началу блока данных
                long dataOffset = sizeof(int) * 2 + sizeof(double) * (xCount + yCount);
                stream.Seek(dataOffset, SeekOrigin.Begin);

                for (int i = 0; i < yCount; i++)
                {
                    for (int j = 0; j < xCount; j++)
                    {
                        double value = reader.ReadDouble();
                        if (i >= yStart && i <= yEnd && j >= xStart && j <= xEnd)
                        {
                            results[i - yStart, j - xStart] = value;
                        }
                    }
                }

                return new CalculationData
                {
                    FilePath = filePath,
                    XValues = xValues,
                    YValues = yValues,
                    Results = results
                };
            }
        }
    }
}
