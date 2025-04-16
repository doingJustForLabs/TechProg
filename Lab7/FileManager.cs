using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace Lab7
{
    public static class FileManager
    {
        public static readonly string historyFilePath = "calculation_history.txt";

        public static void SaveCalculationToFile(
            string methodName,
            string functionName,
            double a,
            double b,
            double deltaX,
            double result,
            DataTable dataTable)
        {
            try
            {
                var sb = new StringBuilder();

                sb.AppendLine($"Дата: {DateTime.Now}");
                sb.AppendLine($"Метод: {methodName}");
                sb.AppendLine($"Функция: {functionName}");
                sb.AppendLine($"Интервал: [{a}; {b}]");
                sb.AppendLine($"Шаг: {deltaX}");
                sb.AppendLine($"Результат интегрирования: {result}");
                sb.AppendLine("Детали расчёта:");

                foreach (DataColumn column in dataTable.Columns)
                {
                    sb.Append($"{column.ColumnName}\t");
                }
                sb.AppendLine();

                foreach (DataRow row in dataTable.Rows)
                {
                    foreach (var item in row.ItemArray)
                    {
                        sb.Append($"{item}\t");
                    }
                    sb.AppendLine();
                }

                sb.AppendLine(new string('-', 80));

                File.AppendAllText(historyFilePath, sb.ToString(), Encoding.UTF8);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Ошибка при сохранении в файл:\n" + ex.Message,
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }
    }

}
