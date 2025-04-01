using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_1
{
    class Density
    {
        // Структура для хранения коэффициентов уравнения Тейта
        struct Coefficients
        {
            public double A0, A1, A2;
            public double B0, B1, B2;
            public double C, Pref;
        }

        // Функция для расчета плотности по уравнению Тейта
        static double CalculateDensity(double p, double T, Coefficients coeffs)
        {
            double numerator = coeffs.A0 + coeffs.A1 * T + coeffs.A2 * T * T;
            double denominator = 1 - coeffs.C * Math.Log((coeffs.B0 + coeffs.B1 * T + coeffs.B2 * T * T + p) /
                (coeffs.B0 + coeffs.B1 * T + coeffs.B2 * T * T + coeffs.Pref));

            if (denominator == 0)
            {
                return double.NaN;  // Возвращаем NaN, если произошла ошибка (деление на ноль)
            }

            return numerator / denominator;
        }

        // Функция для вывода матрицы данных
        static void PrintMatrix(List<List<string>> matrix, List<double> pressures, List<double> temperatures)
        {
            // Заголовок таблицы
            Console.Write("{0,10}", "p/MPa");
            foreach (double temp in temperatures)
            {
                Console.Write("{0,10} K", temp);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 10 + 10 * temperatures.Count));

            // Вывод данных
            for (int i = 0; i < pressures.Count; i++)
            {
                Console.Write("{0,10}", pressures[i]); // Вывод давления

                // Для каждого давления выводим плотность для каждой температуры
                for (int j = 0; j < temperatures.Count; j++)
                {
                    if (matrix[i][j] == "NONE")
                    {
                        Console.Write("{0,10}", "NONE"); // Если данных нет, выводим "NONE"
                    }
                    else
                    {
                        Console.Write("{0,10}", matrix[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }

        // Функция для вычисления расчетных данных и возвращения матрицы
        static List<List<double>> CalculateDataMatrix(List<double> pressures, List<double> temperatures, Coefficients coeffs)
        {
            List<List<double>> matrix = pressures.Select(p => temperatures.Select(t => double.NaN).ToList()).ToList();

            // Для каждого давления и температуры вычисляем плотность
            for (int i = 0; i < pressures.Count; i++)
            {
                for (int j = 0; j < temperatures.Count; j++)
                {
                    double density = CalculateDensity(pressures[i], temperatures[j], coeffs);
                    if (!double.IsNaN(density))
                    {
                        matrix[i][j] = density; // Присваиваем плотность напрямую в матрицу
                    }
                }
            }
            return matrix;
        }

        // Функция для вывода числовой матрицы с расчетными данными
        static void PrintNumericMatrix(List<List<double>> matrix, List<double> pressures, List<double> temperatures)
        {
            // Заголовок таблицы
            Console.Write("{0,10}", "p/MPa");
            foreach (double temp in temperatures)
            {
                Console.Write("{0,10} K", temp);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 10 + 10 * temperatures.Count));

            // Вывод данных
            for (int i = 0; i < pressures.Count; i++)
            {
                Console.Write("{0,10}", pressures[i]); // Вывод давления

                // Для каждого давления выводим плотность для каждой температуры
                for (int j = 0; j < temperatures.Count; j++)
                {
                    if (double.IsNaN(matrix[i][j]))
                    {
                        Console.Write("{0,10}", "NONE"); // Если данных нет, выводим "NONE"
                    }
                    else
                    {
                        Console.Write("{0,10:F1}", matrix[i][j]);
                    }
                }
                Console.WriteLine();
            }
        }

        // Функция для вычисления разницы между экспериментальными и расчетными данными
        static void PrintDelta(List<List<string>> experimentalMatrix, List<List<double>> calculatedMatrix, List<double> pressures, List<double> temperatures)
        {
            Console.WriteLine("(Experimental - Calculated)");

            // Заголовок таблицы
            Console.Write("{0,10}", "p/MPa");
            foreach (double temp in temperatures)
            {
                Console.Write("{0,10} K", temp);
            }
            Console.WriteLine();
            Console.WriteLine(new string('-', 10 + 10 * temperatures.Count));

            // Вычисление разницы между экспериментальными и расчетными данными
            for (int i = 0; i < pressures.Count; i++)
            {
                Console.Write("{0,10:F1}", pressures[i]); // Вывод давления

                // Для каждого давления выводим разницу для каждой температуры
                for (int j = 0; j < temperatures.Count; j++)
                {
                    if (experimentalMatrix[i][j] == "NONE" || double.IsNaN(calculatedMatrix[i][j]))
                    {
                        Console.Write("{0,12}", "NONE"); // Если данных нет, выводим "NONE"
                    }
                    else
                    {
                        double expDensity = Convert.ToDouble(experimentalMatrix[i][j]);
                        double diff = Math.Abs(expDensity - calculatedMatrix[i][j]);
                        Console.Write("{0,12:F4}", diff);
                    }
                }
                Console.WriteLine();
            }
        }

        static void Main()
        {
            // Инициализация коэффициентов уравнения Тейта
            Coefficients coeffs = new Coefficients
            {
                A0 = 1232.7,
                A1 = -0.8404,
                A2 = 0.1143e-3,
                B0 = 452.16,
                B1 = -1.5087,
                B2 = 1.4034e-3,
                C = 0.08365,
                Pref = 1.0
            };

            // Давление (MPa)
            List<double> pressures = new List<double> { 0.1, 0.3, 1.0, 5.0, 10.0, 20.0, 30.0, 40.0, 50.0, 60.0 };

            // Температуры (K)
            List<double> temperatures = new List<double> { 298.15, 323.15, 348.15, 373.15, 398.15 };

            // Пример экспериментальных данных
            List<List<string>> experimentalMatrix = new List<List<string>>
        {
            new List<string> { "991.7", "972.4", "953.2", "934.4", "NONE" },
            new List<string> { "NONE", "NONE", "NONE", "NONE", "915.4" },
            new List<string> { "992.3", "973.1", "953.9", "935.1", "916.2" },
            new List<string> { "994.8", "976.0", "957.1", "938.6", "920.2" },
            new List<string> { "998.0", "979.4", "961.0", "942.9", "925.0" },
            new List<string> { "1003.9", "986.0", "968.3", "951.0", "933.9" },
            new List<string> { "1009.5", "992.2", "975.2", "958.4", "942.0" },
            new List<string> { "1014.9", "998.0", "981.5", "965.3", "949.5" },
            new List<string> { "1019.9", "1003.5", "987.5", "971.8", "956.5" },
            new List<string> { "1024.8", "1008.7", "993.1", "977.9", "963.1" }
        };

            // Вычисляем расчетные данные
            var calculatedMatrix = CalculateDataMatrix(pressures, temperatures, coeffs);

            // Вывод матрицы с экспериментальными данными
            Console.WriteLine("Experimental Data:");
            PrintMatrix(experimentalMatrix, pressures, temperatures);
            Console.WriteLine();

            // Вывод матрицы с расчетными данными
            Console.WriteLine("Calculated Data:");
            PrintNumericMatrix(calculatedMatrix, pressures, temperatures);
            Console.WriteLine();

            // Вывод разницы
            Console.WriteLine("Delta:");
            PrintDelta(experimentalMatrix, calculatedMatrix, pressures, temperatures);
            Console.WriteLine();
        }
    }
}