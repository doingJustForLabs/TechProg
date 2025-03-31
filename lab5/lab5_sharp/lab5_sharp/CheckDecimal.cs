
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_sharp
{
    public static class CheckDecimal
    {
        public static decimal? ValDecimal(string inputDialogText)
        {
            try
            {
                if (string.IsNullOrEmpty(inputDialogText))
                {
                    throw new ArgumentNullException("Пустой ввод");
                }

                decimal valueInput = Convert.ToDecimal(inputDialogText);
                return valueInput;
            }
            catch (ArgumentException)
            {
                ErrorBox("Ошибка аргумента.");
            }
            catch (OverflowException)
            {
                ErrorBox("Ошибка переполнения данных");
            }
            catch (Exception ex)
            {
                ErrorBox($"Ошибка: {ex.Message}");
            }

            return null;
        }

        public static void ErrorBox(string errorMessage)
        {
            DialogResult result = MessageBox.Show(
                errorMessage + "\nПовторить ввод?",
                "Ошибка",
                MessageBoxButtons.RetryCancel,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                );

            if (result == DialogResult.Retry)
            {
                Application.Restart(); // Перезапуск программы для нового ввода
            }
            else
            {
                Application.Exit(); // Завершение программы
            }
        }

        public static void ShowInputBox()
        {
            string inputDialog = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите значение (decimal):",
                "Ввод данных",
                "0"
            );

            decimal? result = ValDecimal(inputDialog);

            if (result.HasValue)
            {
                MessageBox.Show(
                    "Вы ввели правильное значение: " + result,
                    "Закрывай",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );

            }
        }
    }
}
