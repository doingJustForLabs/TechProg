using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public static class Tasks
    {
        public static string CountFoldersWithDigits(string dirPath)
        {
            // Задание 1. Находим количество папок с цифрами в названии
            int res = Directory.EnumerateDirectories(dirPath, "*", SearchOption.AllDirectories).Count(dir => Path.GetFileName(dir).Any(char.IsDigit));

            return $"Папок с числом в названии: {res}";
        }

        public static string ReplaceDigitsInFolderNames(string dirPath)
        {
            // Задание 2. Заменяем цифры в названии на их буквенные эквиваленты

            var digitToLetterMap = new Dictionary<string, string>
            {
                {"1", "A"}, {"2", "B"}, {"3", "C"}, {"4", "D"},
                {"5", "E"}, {"6", "F"}, {"7", "G"}, {"8", "H"}, {"9", "I"}
            };

            // Создаем регулярное выражение для поиска всех цифр
            var regex = new Regex(@"\d");

            foreach (var dir in Directory.EnumerateDirectories(dirPath, "*", SearchOption.AllDirectories))
            {
                string folderName = Path.GetFileName(dir);

                // Заменяем цифры на буквы с помощью регулярного выражения
                string newFolderName = regex.Replace(folderName, match =>
                {
                    // Если цифра найдена в словаре, заменяем её
                    if (digitToLetterMap.TryGetValue(match.Value, out string replacement))
                    {
                        return replacement;
                    }
                    return match.Value;
                });

                // Если имя изменилось, переименовываем папку
                if (newFolderName != folderName)
                {
                    string newFolderPath = Path.GetDirectoryName(dir);
                    newFolderPath = Path.Combine(newFolderPath, newFolderName);

                    try
                    {
                        Directory.Move(dir, newFolderPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при переименовании папки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return "Цифры заменены их эквивалентами";
        }

        public static string TrimZerosFromFolderNames(string dirPath)
        {
            // Задание 3. Удаляем начальные и конечные символы "0" в именах папок

            foreach (var dir in Directory.EnumerateDirectories(dirPath, "*", SearchOption.AllDirectories))
            {
                string folderName = Path.GetFileName(dir);
                string newFolderName = RemoveFirstAndLastZero(folderName);

                if (string.IsNullOrEmpty(newFolderName))
                {
                    var result = MessageBox.Show("Вы уверены, что хотите удалить папку с именем '00'?", "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            Directory.Delete(dir, true);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Ошибка при удалении папки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    continue;
                }

                if (newFolderName != folderName)
                {
                    string newFolderPath = Path.GetDirectoryName(dir);
                    newFolderPath = Path.Combine(newFolderPath, newFolderName);

                    try
                    {
                        Directory.Move(dir, newFolderPath);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка при переименовании папки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            return "Нули удалены";
        }

        public static string RemoveFirstAndLastZero(string folderName)
        {
            string newFolderName;
            int firstZeroIndex = folderName.IndexOf('0');

            if (firstZeroIndex >= 0)
            {
                newFolderName = folderName.Remove(firstZeroIndex, 1);
            } else
            {
                return folderName;
            }

            int lastZeroIndex = newFolderName.LastIndexOf('0');

            if (lastZeroIndex >= 0)
            {
                newFolderName = newFolderName.Remove(lastZeroIndex, 1);
            } else
            {
                return folderName;
            }

            return newFolderName;
        }

        public static string SwapFirstAndLastFolders(List<string> folders)
        {
            // Задание 4. Меняем местами первую и последнюю папку

            if (folders == null)
                return "Список папок не инициализирован";

            if (folders.Count < 2)
                return "Необходимо хотя бы две папки в списке";

            string temp = folders[0];
            folders[0] = folders[folders.Count - 1]; 
            folders[folders.Count - 1] = temp;

            return "Первый и последний элементы списка поменялись местами";
        }
    }
}
