using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_c_charp
{
    public static class FileSaver
    {
        public static void SaveResultsToFile(string filePath, List<(double x, double result, string error)> results)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    writer.WriteLine("X;Sum;Error");
                    foreach (var r in results)
                    {
                        string errorText = string.IsNullOrEmpty(r.error) ? "noError" : r.error;
                        writer.WriteLine($"{r.x:F5};{r.result:E5};{errorText}");
                    }
                }
                MessageBox.Show("Результаты успешно сохранены в файл.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при сохранении файла: {ex.Message}");
            }
        }
    }
}
