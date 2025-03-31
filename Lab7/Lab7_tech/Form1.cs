using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7_tech
{
    public partial class Form1: Form
    {
        private List<double> numbers = new List<double>();
        private List<char> operations = new List<char>();
        private bool expressionValid = false;

        public Form1()
        {
            InitializeComponent();
            UpdateControls();
        }

        private void BtnAddNumber_Click(object sender, EventArgs e)
        {
            if (double.TryParse(comboBoxNumber.Text, out double number))
            {
                if (operations.Count > 0 && operations.Last() == '/' && number == 0)
                {
                    MessageBox.Show("Деление на ноль невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

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

            if (numbers.Count == 0)
            {
                MessageBox.Show("Деление на ноль невозможно!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            listBoxOperations.Items.Add(op.ToString());
            UpdateControls();
        }

        private void ButtonCalc_Click(object sender, EventArgs e)
        {
            if (!ValidateExpression())
                return;

            try
            {
                string expression = BuildExpression();
                double result = CalculateResult();
                listBoxResult.Items.Add($"{expression} = {result}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при вычислении: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private bool ValidateExpression()
        {
            if (numbers.Count < 2 || operations.Count < 1 || operations.Count != numbers.Count - 1)
            {
                MessageBox.Show("Некорректное выражение!\nПример: 2 + 3 * 4", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private double CalculateResult()
        {
            List<double> numCopy = new List<double>(numbers);
            List<char> oprtsCopy = new List<char>(operations);

            for(int i = 0; i < oprtsCopy.Count; i++)
            {
                if (oprtsCopy[i] == '*' || oprtsCopy[i] == '/')
                {
                    double res = MakeOperation(numCopy[i], numCopy[i + 1], oprtsCopy[i]);
                    numCopy[i] = res;
                    numCopy.RemoveAt(i+1);
                    oprtsCopy.RemoveAt(i);
                }
            }

            double result = numCopy[0];
            for(int i = 0; i < oprtsCopy.Count; i++)
            {
                result = MakeOperation(result, numCopy[i + 1], oprtsCopy[i]);
            }
            return result;
        }

        private void ButtonBuildExpression_Click(object sender, EventArgs e)
        {
            if (listBoxNumbers.Items.Count != listBoxOperations.Items.Count + 1)
            {
                MessageBox.Show($"Нужно {listBoxNumbers.Items.Count - 1} операций", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            numbers.Clear();
            operations.Clear();

            
        }
        private double MakeOperation(double a, double b, char op)
        {
            switch (op)
            {
                case '+':
                    return a + b;
                case '-':
                    return a - b;
                case '*':
                    return a * b;
                case '/':
                    return a / b;
                default:
                    throw new ArgumentException("Неизвестная операция");
            }
        }
        private void UpdateControls()
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDeleteNumber_Click(object sender, EventArgs e)
        {

        }
    }
}
