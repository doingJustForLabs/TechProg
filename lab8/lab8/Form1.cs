using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lab8
{
    public partial class Form1: Form
    {
        private char? currentLetterFilter = null;
        private char? currentDigitFilter = null;
        private string matrixFile = @"D:\holn\Desktop\test_lab8.txt";
        private string[,] originalMatrix;
        private string[,] filteredMatrix;

        public Form1()
        {
            InitializeComponent();
            LoadMatrix(matrixFile);
        }

        private void LoadMatrix(string filePath)
        {
            try
            {
                var lines = File.ReadAllLines(filePath);
                int rows = lines.Length;
                int cols = lines[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Length;

                originalMatrix = new string[rows, cols];

                for (int i = 0; i < rows; i++)
                {
                    var elements = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    for (int j = 0; j < cols && j < elements.Length; j++)
                    {
                        originalMatrix[i, j] = elements[j];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading matrix: {ex.Message}");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void LetterCounter_ValueChanged(object sender, EventArgs e)
        {
            letterLabel.Text = $"Буква: {(char)letterCounter.Value}";
            if (startsWithLetterOrDigit.Checked)
            {
                currentLetterFilter = (char)letterCounter.Value;
            }
        }

        private void DigitCounter_ValueChanged(object sender, EventArgs e)
        {
            digitLabel.Text = $"Цифра: {digitCounter.Value}";
            if (startsWithLetterOrDigit.Checked)
            {
                currentDigitFilter = digitCounter.Value.ToString()[0];
            }
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            UpdateCountersState();
        }

        private void UpdateCountersState()
        {
            if (noFilter.Checked)
            {
                // Без фильтров - блокируем оба счетчика
                letterCounter.Enabled = false;
                digitCounter.Enabled = false;
                currentLetterFilter = null;
                currentDigitFilter = null;
            }
            else if (startsWithLetter.Checked)
            {
                // Только буквы - блокируем счетчик цифр
                letterCounter.Enabled = true;
                digitCounter.Enabled = false;
                currentLetterFilter = (char)letterCounter.Value;
                currentDigitFilter = null;
            }
            else if (startsWithDigit.Checked)
            {
                // Только цифры - блокируем счетчик букв
                letterCounter.Enabled = false;
                digitCounter.Enabled = true;
                currentLetterFilter = null;
                currentDigitFilter = digitCounter.Value.ToString()[0];
            }
            else if (startsWithLetterOrDigit.Checked)
            {
                // Буквы или цифры - разрешаем оба счетчика
                letterCounter.Enabled = true;
                digitCounter.Enabled = true;
                currentLetterFilter = (char)letterCounter.Value;
                currentDigitFilter = digitCounter.Value.ToString()[0];
            }
        }
    }
}
