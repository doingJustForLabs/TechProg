using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form1: Form
    {
        private DataProcessor processor = new DataProcessor();

        public Form1()
        {
            InitializeComponent();
            InitializeComboBoxes();
            AutoScaleMode = AutoScaleMode.None;
            try
            {
                string currentLabDir = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
                string filePath = Path.Combine(currentLabDir, "text.txt");

                processor.LoadDataFromFile(filePath);
                dataGridView.DataSource = processor.Table;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                chosenColumn.Maximum = processor.Table.Columns.Count;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeComboBoxes()
        {
            sortComboBox.SelectedIndex = 0;
            transformComboBox.SelectedIndex = 0;
            sortTypeComboBox.SelectedIndex = 0;
        }

        private void chosenColumn_ValueChanged(object sender, EventArgs e)
        {
            int columnIndex = (int)chosenColumn.Value - 1;
            dataGridView.ClearSelection();

            foreach (DataGridViewRow row in dataGridView.Rows)
                row.Cells[columnIndex].Selected = true;

            bool isNum = processor.IsColumnNumeric(columnIndex);

            if (!isNum)
            {
                sortTypeComboBox.SelectedItem = "\"как строки\"";
                
            } else
            {
                transformComboBox.SelectedItem = "Не преобразовывать";
            }
            sortTypeComboBox.Enabled = isNum;
            transformComboBox.Enabled = !isNum;
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            int columnIndex = (int)chosenColumn.Value - 1;
            string sortOrder = sortComboBox.Text;
            string sortType = sortTypeComboBox.Text;

            if (sortOrder != "Не сортировать")
            {
                processor.Sort(columnIndex, sortOrder, sortType);
            }

            if (transformComboBox.Text != "Не преобразовывать")
            {
                processor.TransformText(columnIndex, transformComboBox.Text);
            }

            DataWindow dataWindow = new DataWindow(processor.Table);
            dataWindow.Show();

            dataGridView.ClearSelection();

            foreach (DataGridViewRow row in dataGridView.Rows)
                row.Cells[columnIndex].Selected = true;
        }
    }
}
