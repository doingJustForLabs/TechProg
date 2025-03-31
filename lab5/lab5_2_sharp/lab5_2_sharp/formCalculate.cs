using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace lab5_2_sharp
{
    public class CalculationManager
    {
        private readonly string _resultsDirectory;
        private readonly string _logFilePath ;
        private readonly string _errorLogPath;
        private int _fileCounter = 1;
        private readonly int _digitsInFileName = 4;

        public CalculationManager(string resultsDirectory)
        {
            _resultsDirectory = resultsDirectory;

            // Создаем директорию, если ее нет
            Directory.CreateDirectory(_resultsDirectory);

            _logFilePath = Path.Combine(_resultsDirectory, "myProgram.log");
            _errorLogPath = Path.Combine(_resultsDirectory, "myErrors.log");
        }

        public void InitializeLogFile()
        {
            var logContent = new StringBuilder();
            logContent.AppendLine("Программа: Расчет функции G(x,y)");
            logContent.AppendLine($"Вариант: 18");
            logContent.AppendLine($"Дата и время начала расчета: {DateTime.Now}");
            logContent.AppendLine("Рассчитываемая функция: exp(-y^(1/2)/(1+x))");

            File.WriteAllText(_logFilePath, logContent.ToString());
            File.WriteAllText(_errorLogPath, string.Empty);
        }

        public CalculationResult ProcessCalculation(double x0, double y0, double xk, double yCount, double stepX, double stepY, string tabName)
        {

            var (xValues, yValues) = PointGenerator.GeneratePoints(x0, xk, stepX, y0, yCount, stepY);

            var result = new CalculationResult
            {
                XValues = xValues,
                YValues = yValues,
                Results = new double[yValues.Count, xValues.Count],
                Errors = new List<CalculationError>()
            };

            for (int i = 0; i < yValues.Count; i++)
            {
                for (int j = 0; j < xValues.Count; j++)
                {
                    try
                    {
                        result.Results[i, j] = CalculateG18(xValues[j], yValues[i]);
                    }
                    catch (Exception ex)
                    {
                        result.Errors.Add(new CalculationError
                        {
                            X = xValues[j],
                            Y = yValues[i],
                            ErrorMessage = ex.Message
                        });
                        result.Results[i, j] = double.NaN;
                    }
                }
            }

            SaveResultsToFile(result, tabName);
            LogErrors(result.Errors, tabName);

            return result;
        }

        private double CalculateG18(double x, double y)
        {
            if (Math.Abs(1 + x) < double.Epsilon) throw new DivideByZeroException("Деление на ноль");
            if (y/(1+x) < 0) throw new ArgumentException("Отрицательное значение под корнем");

            double sqrtPart = Math.Sqrt(y/(1+x));
            return Math.Exp(-sqrtPart);
        }

        private List<double> GenerateSequence(double start, double end, double step)
        {
            var sequence = new List<double>();
            for (double value = start; value <= end; value += step)
            {
                sequence.Add(value);
            }
            return sequence;
        }

        private void SaveResultsToFile(CalculationResult result, string tabName)
        {
            string fileName = GetDataFileName();

            var content = new StringBuilder();
            content.AppendLine("Функция: exp(-(y/(1+x))^(1/2))");
            content.AppendLine($"Количество точек для X: {result.XValues.Count}");
            content.AppendLine($"Количество точек для Y: {result.YValues.Count}");
            content.AppendLine();

            content.Append("y\\x\t");
            foreach (var x in result.XValues) content.Append($"{x}\t");
            content.AppendLine();

            for (int i = 0; i < result.YValues.Count; i++)
            {
                content.Append($"{result.YValues[i]}\t");
                for (int j = 0; j < result.XValues.Count; j++)
                {
                    content.Append(double.IsNaN(result.Results[i, j]) ? "NaN\t" : $"{result.Results[i, j]}\t");
                }
                content.AppendLine();
            }

            File.WriteAllText(fileName, content.ToString());
            File.AppendAllText(_logFilePath, $"Файл с результатами: {fileName}{Environment.NewLine}");
        }

        private void LogErrors(List<CalculationError> errors, string tabName)
        {
            foreach (var error in errors)
            {
                File.AppendAllText(_errorLogPath,
                    $"Файл: {GetCurrentDataFileName()}\n" +
                    $"Функция: exp(-(y/(1+x))^(1/2))\n" +
                    $"Аргументы: x={error.X}, y={error.Y}\n" +
                    $"Ошибка: {error.ErrorMessage}\n\n");
            }
        }

        public string GetCurrentDataFileName()
        {
            string fileName = $"G{(_fileCounter - 1).ToString().PadLeft(_digitsInFileName, '0')}.dat";
            return Path.Combine(_resultsDirectory, fileName);
        }

        private string GetDataFileName()
        {
            string fileName = $"G{_fileCounter++.ToString().PadLeft(_digitsInFileName, '0')}.dat";
            return Path.Combine(_resultsDirectory, fileName);
        }

        //private string GetDataFileName() => $"G{_fileCounter++.ToString().PadLeft(_digitsInFileName, '0')}.dat";
        //public string GetCurrentDataFileName() => $"G{(_fileCounter - 1).ToString().PadLeft(_digitsInFileName, '0')}.dat";
    }

    public class CalculationResult
    {
        public List<double> XValues { get; set; }
        public List<double> YValues { get; set; }
        public double[,] Results { get; set; }
        public List<CalculationError> Errors { get; set; }
    }

    public class CalculationError
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string ErrorMessage { get; set; }
    }
}
