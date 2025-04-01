using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab8
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDataFromFile("text.txt");
        }

        public void LoadDataFromFile(string fileName)
        {
            sortComboBox.Items.Insert(0, "Не сортировать"); // Добавляем в начало
            sortComboBox.SelectedIndex = 0; // Выбираем его
            
            try {
                string currentLabDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string filePath = Path.Combine(currentLabDir, fileName);

                string[] lines = File.ReadAllLines(filePath);

                DataTable table = new DataTable();

                // Заполняем столбцы

                string[] headers = lines[0].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                for (int i = 0; i < headers.Length; i++)
                {
                    table.Columns.Add($"Column {i + 1}");
                }

                // Добавляем строки

                for (int i = 0; i < lines.Length; i++)
                {
                    string[] parts = lines[i].Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                    table.Rows.Add(parts);
                }

                dataGridView.DataSource = table;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                chosenColumn.Maximum = headers.Length;

            } catch (Exception  e)
            {
                MessageBox.Show(e.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void sortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //string sortText = sortComboBox.Text;

            //if (sortText == "Не сортировать")
            //{
            //    sortTypeComboBox.Enabled = false;
            //} else { 
            //    sortTypeComboBox.Enabled = true;
            //}
        }

        private void chosenColumn_ValueChanged(object sender, EventArgs e)
        {
            int columnIndex = (int)chosenColumn.Value - 1;

            dataGridView.ClearSelection();

            // Выделяем ячейки
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Cells[columnIndex].Selected = true;
            }

            string firstColVal = dataGridView.Rows[0].Cells[columnIndex].Value.ToString();

            bool isNum = double.TryParse(firstColVal, NumberStyles.Any, CultureInfo.InvariantCulture, out double result);

            //MessageBox.Show(isNum ? $"Это число {result}" : $"Это не число {result}");

            if (isNum)
            {
                sortTypeComboBox.Enabled = true;
            } else
            {
                sortTypeComboBox.SelectedItem = "\"как строки\"";
                sortTypeComboBox.Enabled = false;
            }
        }
    }
}
