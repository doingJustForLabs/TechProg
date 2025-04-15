using System;
using System.Data;
using System.IO;

public static class Logger
{
    private static readonly string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
    private static readonly string logFile = Path.Combine(desktopPath, "myProgram.log");
    private static readonly string errorLogFile = Path.Combine(desktopPath, "myErrors.log");

    public static void LogProgramStart()
    {
        using (StreamWriter writer = new StreamWriter(logFile, true))
        {
            writer.WriteLine($"Программа: Lab5_2 | Вариант: 16");
            writer.WriteLine($"Дата и время начала: {DateTime.Now}");
            writer.WriteLine("Функция: G(x, y) = x / (y - 2)");
            writer.WriteLine("--------------------------------------");
        }
    }

    public static void SaveResultsToFile(string fileName, DataTable table)
    {
        string filePath = Path.Combine(desktopPath, fileName);
        using (StreamWriter writer = new StreamWriter(filePath))
        {
            foreach (DataRow row in table.Rows)
            {
                writer.WriteLine($"{row[0]} {row[1]} {row[2]}");
            }
        }
    }

    public static void LogError(double x, double y, string error)
    {
        using (StreamWriter writer = new StreamWriter(errorLogFile, true))
        {
            writer.WriteLine($"Функция: G(x, y) = x / (y - 2)");
            writer.WriteLine($"Аргументы: x = {x}, y = {y}");
            writer.WriteLine($"Ошибка: {error}");
            writer.WriteLine("--------------------------------------");
        }
    }
}