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
using System.Diagnostics;

namespace lab8
{
    public partial class Form1: Form
    {
        private char? currentLetterFilter = null;
        private char? currentDigitFilter = null;
        private MatrixTransformation _process;
        private string matrixFile = @"D:\holn\Desktop\Study\technology\lab8\test_lab8.txt";
        private List<List<string>> originalMatrix;
        //private string[,] filteredMatrix;

        public Form1()
        {
            InitializeComponent();
            originalMatrix = LoadMatrix(matrixFile);
            _process = new MatrixTransformation(originalMatrix);
            InitializeLetterSelector();
        }

        //private void LoadMatrix(string filePath)
        //{
        //    try
        //    {
        //        var lines = File.ReadAllLines(filePath);
        //        int rows = lines.Length;
        //        int maxCols = 0;

        //        foreach (var line in lines)
        //        {
        //            var elements = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //            if (elements.Length > maxCols) maxCols = elements.Length;
        //        }

        //        originalMatrix = new string[rows, maxCols];

        //        for (int i = 0; i < rows; i++)
        //        {
        //            var elements = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
        //            for (int j = 0; j < maxCols && j < elements.Length; j++)
        //            {
        //                originalMatrix[i, j] = j < elements.Length ? elements[j] : string.Empty;
        //            }
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show($"Error loading matrix: {ex.Message}");
        //    }
        //}

        
        private List<List<string>> LoadMatrix(string filePath)
        {
            //matrix[0]: ["Apple", "123", "orange", ...]
            //matrix[1]: ["Banana", ...]
            //...

            var matrix = new List<List<string>>();

            try
            {
                var lines = File.ReadAllLines(filePath);

                foreach (var line in lines)
                {
                    // Разделяем строку на элементы и убираем пустые элементы
                    var elements = line.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                    // Добавляем строку (список) в матрицу
                    matrix.Add(elements.ToList());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading matrix: {ex.Message}");
            }

            return matrix;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeLetterSelector()
        {
            comboBoxLetters.Items.Clear();
            for(char c = 'A'; c <= 'Z'; c++)
            {
                comboBoxLetters.Items.Add(c.ToString());
            }
            comboBoxLetters.SelectedIndex = 0;
        }

        private void ComboBoxLetters_SelectedIndexChanged(object sender, EventArgs e)
        {
            letterLabel.Text = $"Буква: {comboBoxLetters.SelectedItem}";
            if (startsWithLetterOrDigit.Checked || startsWithLetter.Checked)
            {
                currentLetterFilter = comboBoxLetters.SelectedItem.ToString()[0];
            }
            ApplyFiltersAndDisplayResults();
        }

        private void DigitCounter_ValueChanged(object sender, EventArgs e)
        {
            digitLabel.Text = $"Цифра: {digitCounter.Value}";
            if (startsWithLetterOrDigit.Checked || startsWithDigit.Checked)
            {
                currentDigitFilter = digitCounter.Value.ToString()[0];
            }
            ApplyFiltersAndDisplayResults();
        }

        private void FilterChanged(object sender, EventArgs e)
        {
            UpdateCountersState();
            ApplyFiltersAndDisplayResults();
        }

        private void UpdateCountersState()
        {
            if (noFilter.Checked)
            {
                // Без фильтров - блокируем оба счетчика
                comboBoxLetters.Enabled = false;
                digitCounter.Enabled = false;
                currentLetterFilter = null;
                currentDigitFilter = null;
            }
            else if (startsWithLetter.Checked)
            {
                // Только буквы - блокируем счетчик цифр
                comboBoxLetters.Enabled = true;
                digitCounter.Enabled = false;
                currentLetterFilter = comboBoxLetters.SelectedItem.ToString()[0];
                currentDigitFilter = null;
            }
            else if (startsWithDigit.Checked)
            {
                // Только цифры - блокируем счетчик букв
                comboBoxLetters.Enabled = false;
                digitCounter.Enabled = true;
                currentLetterFilter = null;
                currentDigitFilter = digitCounter.Value.ToString()[0];
            }
            else if (startsWithLetterOrDigit.Checked)
            {
                // Буквы или цифры - разрешаем оба счетчика
                comboBoxLetters.Enabled = true;
                digitCounter.Enabled = true;
                currentLetterFilter = comboBoxLetters.SelectedItem.ToString()[0];
                currentDigitFilter = digitCounter.Value.ToString()[0];
            }
        }

        private void ApplyFiltersAndDisplayResults()
        {
            var settings = new FilterSettings
            {
                NoFilter = noFilter.Checked,
                StartsWithLetter = startsWithLetter.Checked,
                StartsWithDigit = startsWithDigit.Checked,
                StartsWithLetterOrDigit = startsWithLetterOrDigit.Checked,
                ToUpper = toUpper.Checked,
                ToLower = toLower.Checked,
                LetterFilter = comboBoxLetters.SelectedItem?.ToString()[0],
                DigitFilter = digitCounter.Value.ToString()[0]
            };

            var results = _process.ApplyFilters(settings);
            DisplayResults(results);
        }

        private void DisplayResults(List<FilterResult> results)
        {
            if (dataGridView1.Columns.Count == 0)
            {
                dataGridView1.Columns.Add("Row", "Номер строки");
                dataGridView1.Columns.Add("Column", "Номер столбца");
                dataGridView1.Columns.Add("Original", "Старое значение");
                dataGridView1.Columns.Add("Transformed", "Преобразованное значение");
            }

            dataGridView1.Rows.Clear();

            foreach (var result in results)
            {
                dataGridView1.Rows.Add(result.Row, result.Column, result.OriginalValue, result.TransformedValue);
            }
        }

        //private void TransformationChanged(object sender, EventArgs e)
        //{
        //    ApplyFiltersAndDisplay();
        //}
    }
}
