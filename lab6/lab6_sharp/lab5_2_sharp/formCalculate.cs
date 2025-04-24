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

        public CalculationResult ProcessCalculation(CalculationInputs inputs)
        {

            var (xValues, yValues) = PointGenerator.GeneratePoints(inputs.X0, inputs.Xk, inputs.StepX, inputs.Y0, inputs.YCount, inputs.StepY);

            var result = new CalculationResult
            {
                XValues = xValues,
                YValues = yValues,
                Results = new double[yValues.Length, xValues.Length],
                Errors = new List<CalculationError>()
            };

            for (int i = 0; i < yValues.Length; i++)
            {
                for (int j = 0; j < xValues.Length; j++)
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

            SaveResultsToBinaryFile(result, inputs.TabName);
            LogErrors(result.Errors);

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

        private void SaveResultsToBinaryFile(CalculationResult result, string tabName)
        {
            string fileName = GetDataFileName();

            using (var stream = new FileStream(fileName, FileMode.Create))
            using (var writer = new BinaryWriter(stream))
            {
                writer.Write(result.XValues.Length);
                writer.Write(result.YValues.Length);

                foreach (var x in result.XValues)
                    writer.Write(x);

                foreach (var y in result.YValues)
                    writer.Write(y);

                for (int i = 0; i < result.YValues.Length; i++)
                {
                    for (int j = 0; j < result.XValues.Length; j++)
                    {
                        writer.Write(result.Results[i, j]);
                    }
                }
            }

            //const int yColWidth = 10;
            //const int xColWidth = 30;
            //const int valueColWidth = 30;

            //content.Append("y\\x".PadRight(yColWidth));
            //foreach (var x in result.XValues)
            //{
            //    content.Append(x.ToString("0.###############").PadLeft(xColWidth));
            //}
            //content.AppendLine();



            //for (int i = 0; i < result.YValues.Count; i++)
            //{
            //    content.Append(result.YValues[i].ToString("0.####").PadRight(yColWidth));

            //    // Значения функции
            //    for (int j = 0; j < result.XValues.Count; j++)
            //    {
            //        string value = double.IsNaN(result.Results[i, j])
            //            ? "NaN".PadLeft(valueColWidth)
            //            : result.Results[i, j].ToString("0.###############").PadLeft(valueColWidth);

            //        content.Append(value);
            //    }
            //    content.AppendLine();
            //}

            //File.WriteAllText(fileName, content.ToString());
            File.AppendAllText(_logFilePath, $"Файл с результатами: {fileName}{Environment.NewLine}");
        }

        private void LogErrors(List<CalculationError> errors)
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
            string fileName = $"G{(_fileCounter - 1).ToString().PadLeft(_digitsInFileName, '0')}.rez";
            return Path.Combine(_resultsDirectory, fileName);
        }

        private string GetDataFileName()
        {
            string fileName = $"G{_fileCounter++.ToString().PadLeft(_digitsInFileName, '0')}.rez";
            return Path.Combine(_resultsDirectory, fileName);
        }

        //private string GetDataFileName() => $"G{_fileCounter++.ToString().PadLeft(_digitsInFileName, '0')}.dat";
        //public string GetCurrentDataFileName() => $"G{(_fileCounter - 1).ToString().PadLeft(_digitsInFileName, '0')}.dat";
    }

    public class CalculationResult
    {
        public double[] XValues { get; set; }
        public double[] YValues { get; set; }
        public double[,] Results { get; set; }
        public List<CalculationError> Errors { get; set; }
    }

    public class CalculationError
    {
        public double X { get; set; }
        public double Y { get; set; }
        public string ErrorMessage { get; set; }
    }

    public struct CalculationInputs
    {
        public double X0 { get; }
        public double Y0 { get; }
        public double Xk { get; }
        public int YCount { get; }
        public double StepX { get; }
        public double StepY { get; }
        public string TabName { get; }

        public CalculationInputs(double x0, double y0, double xk, int yCount, double stepX, double stepY, string tabName)
        {
            X0 = x0;
            Y0 = y0;
            Xk = xk;
            YCount = yCount;
            StepX = stepX;
            StepY = stepY;
            TabName = tabName;
        }
    }

}
