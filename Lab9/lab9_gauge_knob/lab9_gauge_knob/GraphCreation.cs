using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab9
{
    public partial class GraphCreation : Form
    {
        public Graph<object> Result { get; private set; }


        public GraphCreation()
        {
            InitializeComponent();
            comboBoxType.Items.AddRange(Graph<object>.AllTypesNames());
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                openDialog.Filter = "CSV файлы (*.csv)|*.csv";
                openDialog.Title = "Выберите CSV файл с данными";

                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxDataPath.Text = openDialog.FileName;
                    textBoxName.Text = textBoxName.Text == "" ? openDialog.FileName.Split('\\').Last() : textBoxName.Text;
                }
            }

        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("Введите название графика.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDataPath.Text))
            {
                MessageBox.Show("Укажите путь к CSV файлу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!File.Exists(textBoxDataPath.Text))
            {
                MessageBox.Show("Файл не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Path.GetExtension(textBoxDataPath.Text).ToLower() != ".csv")
            {
                MessageBox.Show("Файл не является CSV.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GraphType type = Graph<object>.ConvertGraphType(comboBoxType.SelectedItem?.ToString());
            string name = textBoxName.Text.Trim();
            string desc = textBoxDescription.Text.Trim();
            string path = textBoxDataPath.Text.Trim();

            Seria<object>[] series = DataReader.ReadFromCSV(path, type);
            if (series != null)
            {
                Result = new Graph<object>
                {
                    Name = name,
                    Description = desc,
                    Type = type,
                    Series = series
                };
            } else
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            labelNameSymb.Text = $"{textBoxName.TextLength}/{textBoxName.MaxLength}";
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            labelDescriptionSymb.Text = $"{textBoxDescription.TextLength}/{textBoxDescription.MaxLength}";
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxName.Clear();
            textBoxDescription.Clear();
            textBoxDataPath.Clear();
            comboBoxType.SelectedIndex = 0;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void GraphCreation_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
                DialogResult = DialogResult.Cancel;
        }
    }
}
