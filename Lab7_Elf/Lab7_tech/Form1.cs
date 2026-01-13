using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Linq.Expressions;

namespace Lab7_tech
{
    public partial class Form1: Form
    {
        private List<double> numbers = new List<double>();
        private List<char> operations = new List<char>();

        private string currentLogFile = null;

        public Form1()
        {
            InitializeComponent();
            UpdateControls();
        }

        private void BtnAddNumber_Click(object sender, EventArgs e)
        {
            if (double.TryParse(comboBoxNumber.Text, out double number))
            {
                numbers.Add(number);
                comboBoxNumber.Items.Add(number);
                listBoxNumbers.Items.Add(number.ToString());
                comboBoxNumber.Text = "";
                UpdateControls();
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректное числовое значение.", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void OperationButton_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            char op = btn.Text[0];

            operations.Add(op);
            listBoxOperations.Items.Add(op.ToString());
            UpdateControls();
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            if (!ValidateExpression())
                return;

            try
            {
                UpdateResult();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateExpression()
        {
            if (numbers.Count < 2)
            {
                MessageBox.Show("Нужно минимум 2 числа!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (operations.Count != numbers.Count - 1)
            {
                MessageBox.Show($"Нужно {numbers.Count - 1} операций!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            for (int i = 0; i < operations.Count; i++)
            {
                if (operations[i] == '/' && numbers[i + 1] == 0)
                {
                    MessageBox.Show("Деление на ноль невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private string GetExpressionString()
        {
            string nums = string.Join(" ", numbers);
            string ops = string.Join(" ", operations);
            return $"{nums} {ops}";
        }

        private void UpdateControls()
        {
            buttonDeleteNumber.Enabled = listBoxNumbers.Items.Count > 0;
            buttonDeleteOprts.Enabled = listBoxOperations.Items.Count > 0;
        }

        private void UpdateResult()
        {
            lstExpression.Items.Clear();
            listBoxResult.Items.Clear();

            double result = Calculator.Calculation(numbers, operations);
            string expression = GetExpressionString();

            listBoxResult.Items.Add(result.ToString());
            lstExpression.Items.Add(expression);
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeleteNumber_Click(object sender, EventArgs e)
        {
            if (listBoxNumbers.SelectedIndex >= 0)
            {
                int index = listBoxNumbers.SelectedIndex;
                numbers.RemoveAt(index);
                listBoxNumbers.Items.RemoveAt(index);
            }
            UpdateControls();
        }

        private void buttonDeleteOprts_Click(object sender, EventArgs e)
        {
            if (listBoxOperations.SelectedIndex >= 0)
            {
                operations.RemoveAt(listBoxOperations.SelectedIndex);
                listBoxOperations.Items.RemoveAt(listBoxOperations.SelectedIndex);
                UpdateControls();
            }
        }

        private void buttonClearOprnds_Click(object sender, EventArgs e)
        {
            numbers.Clear();
            listBoxNumbers.Items.Clear();
            listBoxResult.Items.Clear();
            UpdateControls();
        }

        private void buttonSaveToFile_Click(object sender, EventArgs e)
        {
            if (!ValidateExpression())
            {
                MessageBox.Show("Невозможно сохранить некорректное выражение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string polishExpression = lstExpression.Items[0].ToString();

                // Если файл еще не выбран - показать диалог сохранения
                if (string.IsNullOrEmpty(currentLogFile))
                {
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Log files (*.log)|*.log";
                    saveDialog.Title = "Выберите файл для сохранения логов";

                    if (saveDialog.ShowDialog() == DialogResult.OK)
                    {
                        currentLogFile = saveDialog.FileName;
                    }
                    else
                    {
                        return; // Пользователь отменил
                    }
                }

                // Дописываем выражение в файл
                File.AppendAllText(currentLogFile, $"{polishExpression}\n");
                MessageBox.Show("Выражение сохранено!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка сохранения: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            OpenFileDialog openDialog = new OpenFileDialog();
            openDialog.Filter = "Log files (*.log)|*.log";

            if (openDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] lines = File.ReadAllLines(openDialog.FileName);

                    if (lines.Length == 0)
                    {
                        MessageBox.Show("Файл пуст.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string input = Microsoft.VisualBasic.Interaction.InputBox(
                        $"В файле {lines.Length} строк(и).\nВведите номер строки (от 1 до {lines.Length}):",
                        "Выбор строки",
                        "1"
                    );

                    if (!int.TryParse(input, out int lineIndex) || lineIndex < 1 || lineIndex > lines.Length)
                    {
                        MessageBox.Show("Некорректный номер строки.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    numbers.Clear();
                    operations.Clear();
                    listBoxNumbers.Items.Clear();
                    listBoxOperations.Items.Clear();


                    string selectedLine = lines[lineIndex - 1];
                    string[] tokens = selectedLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    foreach (var token in tokens)
                    {
                        if (double.TryParse(token, out double number))
                        {
                            listBoxNumbers.Items.Add(number);
                            numbers.Add(number);
                        }
                        else
                        {
                            listBoxOperations.Items.Add(token);
                            operations.Add(token[0]);
                        }
                    }

                    UpdateResult();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonClearOprts_Click(object sender, EventArgs e)
        {
            listBoxOperations.Items.Clear();
            operations.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lstExpression.Items.Clear();
            listBoxResult.Items.Clear();
        }
    }
}
