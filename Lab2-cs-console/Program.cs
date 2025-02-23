using System;
using System.Diagnostics;

const double B1 = -1.64587;
const double B2 = 0.00626;
const double B3 = 4.6575;
const double DA = B3;

const double C1 = 172.12865;
const double C2 = 0.16221;
const double C3 = -0.00038;

var data = new Dictionary<double, Dictionary<double, double>>
{
    {303.15, new Dictionary<double, double> {
        [0.1] = 87.83, [1] = 89.36, [5] = 96.46,
        [10] = 106.08, [20] = 128.11, [30] = 154.42,
        [40] = 185.76, [50] = 223.04, [60] = 267.28
    }},
    {313.15, new Dictionary<double, double> {
        [0.1] = 57.07,
        [1] = 58.01,
        [5] = 62.34,
        [10] = 68.16,
        [20] = 81.30,
        [30] = 96.66,
        [40] = 114.55,
        [50] = 135.32,
        [60] = 159.34
    }},
    {333.15,new Dictionary<double, double> {
        [0.1] = 28.14,
        [1] = 28.55,
        [5] = 30.44,
        [10] = 32.95,
        [20] = 38.51,
        [30] = 44.83,
        [40] = 52.00,
        [50] = 60.09,
        [60] = 69.17
    }},
    {353.15, new Dictionary<double, double> {
        [0.1] = 16.05,
        [1] = 16.27,
        [5] = 17.25,
        [10] = 18.55,
        [20] = 21.37,
        [30] = 24.52,
        [40] = 28.01,
        [50] = 31.86,
        [60] = 36.09
    }},
    {373.15, new Dictionary<double, double> {
        [0.1] = 10.39,
        [1] = 10.52,
        [5] = 11.13,
        [10] = 11.92,
        [20] = 13.61,
        [30] = 15.47,
        [40] = 17.49,
        [50] = 19.67,
        [60] = 22.02
    }}
};

double nu(double temperature, double p)
{
    return Math.Exp(B1 + B2 * p + DA * t_0(p) / (temperature - t_0(p)));
}
double t_0(double p)
{
    return C1 + C2 * p + C3 * Math.Pow(p, 2);
}

void find_viscosity()
{
    double[] temperature_data = { 303.15, 313.15, 333.15, 353.15, 373.15 };
    double[] pressure_data = { 0.1, 1, 5, 10, 20, 30, 40, 50, 60 };

    for (int i = 0; i < temperature_data.Length; i++)
    {
        double temperature = temperature_data[i];

        for (int j = 0; j < pressure_data.Length; j++)
        {
            double pressure = pressure_data[j];
            double nu_exp = data[temperature][pressure];

            if (data.TryGetValue(temperature, out var value1))
            {
                if (!data[temperature].TryGetValue(pressure, out var value2))
                {
                    Console.WriteLine("Такого давления нет в базе");
                }
            }
            else
            {
                Console.WriteLine("Такой температуры нет в базе");
            }

            Console.WriteLine($"Температура, T: {temperature}");
            Console.WriteLine($"Давление, p: {pressure}");
            Console.WriteLine($"Вязкость (эксп.): {data[temperature][pressure]}");
            Console.WriteLine(String.Format("Вязкость (расч.): {0:f2}", nu(temperature, pressure)));

            double error = Math.Abs(data[temperature][pressure] - nu(temperature, pressure));
            Console.WriteLine(String.Format("Абсолютная ошибка: {0:f2}", error));

            double relative_error = error / data[temperature][pressure];
            Console.WriteLine(String.Format("Относительная погрешность: {0:f2}%\n", relative_error * 100));
        }
    }
    
    Console.WriteLine($"Версия программы: {Environment.Version}");
    const string LastModified = "18.02.2025";
    Console.WriteLine($"Последняя дата изменения: {LastModified}");
}

find_viscosity();
