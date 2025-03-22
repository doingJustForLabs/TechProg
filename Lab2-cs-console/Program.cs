using System;
using System.Diagnostics;

const double B1 = -1.64587;
const double B2 = 0.00626;
const double B3 = 4.6575;
const double DA = B3;

const double C1 = 172.12865;
const double C2 = 0.16221;
const double C3 = -0.00038;

double[][] data =
{
    new double[] { 87.83, 89.36, 96.46, 106.08, 128.11, 154.42, 185.76, 223.04, 267.28 },
    new double[] { 57.07, 58.01, 62.34, 68.16, 81.30, 96.66, 114.55, 135.32, 159.34 },
    new double[] { 28.14, 28.55, 30.44, 32.95, 38.51, 44.83, 52.00, 60.09, 69.17 },
    new double[] { 16.05, 16.27, 17.25, 18.55, 21.37, 24.52, 28.01, 31.86, 36.09 },
    new double[] { 10.39, 10.52, 11.13, 11.92, 13.61, 15.47, 17.49, 19.67, 22.02 },
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

    Console.WriteLine("{0, 16} |{1, 16} |{2, 16} |{3, 16} |{4, 16} |{5, 20}", "Температура, K", "Давление, p", "Вязкость(эксп.)", "Вязкость(расч.)", "Абс. ошибка", "Отн. погрешность");
    Console.WriteLine("{0, 16}+{1, 16}+{2, 16}+{3, 16}+{4, 16}+{5, 20}", "-----------------", "-----------------", "-----------------", "-----------------", "-----------------", "---------------------");

    for (int i = 0; i < temperature_data.Length; i++)
    {
        double temperature = temperature_data[i];

        for (int j = 0; j < pressure_data.Length; j++)
        {
            double pressure = pressure_data[j];
            double nu_exp = data[i][j];

            double error = Math.Abs(nu_exp - nu(temperature, pressure));
            double relative_error = error / nu_exp * 100;

            Console.WriteLine("{0, 16} |{1, 16} |{2, 16} |{3, 16} |{4, 16} |{5, 20}", temperature, pressure, nu_exp, String.Format("{0:f2}", nu(temperature, pressure)), String.Format("{0:f2}", error), String.Format("{0:f2}%", relative_error));
        }
        Console.WriteLine("{0, 16}+{1, 16}+{2, 16}+{3, 16}+{4, 16}+{5, 20}", "-----------------", "-----------------", "-----------------", "-----------------", "-----------------", "---------------------");
    }
    
    Console.WriteLine($"\nВерсия программы: {Environment.Version}");
    const string LastModified = "25.02.2025";
    Console.WriteLine($"Последняя дата изменения: {LastModified}");
}

find_viscosity();
