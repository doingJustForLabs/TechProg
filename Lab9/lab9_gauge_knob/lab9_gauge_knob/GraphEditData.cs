using LiveCharts.Wpf;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Lab9
{
    public partial class GraphEditData : Form
    {
        public Graph<object> Result;
        public Graph<object> OldGraph;

        public GraphEditData(Graph<object> graph)
        {
            InitializeComponent();
            comboBoxType.Items.AddRange(Graph<object>.AllTypesNames(t => Graph<object>.IsCategoricalType(t) == Graph<object>.IsCategoricalType(graph.Type)));
            OldGraph = graph;
            textBoxName.Text = graph.Name;
            textBoxDescription.Text = graph.Description;
            comboBoxType.SelectedIndex = comboBoxType.Items.IndexOf(Graph<object>.ConvertGraphType(graph.Type));
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

            string path = textBoxDataPath.Text.Trim();

            if (!File.Exists(textBoxDataPath.Text) && !string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Файл не существует.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Path.GetExtension(textBoxDataPath.Text).ToLower() != ".csv" && !string.IsNullOrEmpty(path))
            {
                MessageBox.Show("Файл не является CSV.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            GraphType type = Graph<object>.ConvertGraphType(comboBoxType.SelectedItem?.ToString());
            string name = textBoxName.Text.Trim();
            string desc = textBoxDescription.Text.Trim();

            Seria<object>[] series = !string.IsNullOrEmpty(path) ? DataReader.ReadFromCSV(path, type) : OldGraph.Series;

            if (series != null)
            {
                Result = new Graph<object>
                {
                    Name = name,
                    Description = desc,
                    Type = type,
                    Series = series
                };


            }
            else
            {
                return;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
        
        
        private bool IsChanged()
        {
            return textBoxName.Text != OldGraph.Name || textBoxDescription.Text != OldGraph.Description || Graph<object>.ConvertGraphType(comboBoxType.SelectedItem?.ToString()) != OldGraph.Type || !string.IsNullOrEmpty(textBoxDataPath.Text);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            labelNameSymb.Text = $"{textBoxName.TextLength}/{textBoxName.MaxLength}";
            buttonRecover.Enabled = IsChanged();
        }

        private void textBoxDescription_TextChanged(object sender, EventArgs e)
        {
            labelDescriptionSymb.Text = $"{textBoxDescription.TextLength}/{textBoxDescription.MaxLength}";
            buttonRecover.Enabled = IsChanged();
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

        private void buttonRecover_Click(object sender, EventArgs e)
        {
            textBoxName.Text = OldGraph.Name;
            textBoxDescription.Text = OldGraph.Description;
            comboBoxType.SelectedIndex = comboBoxType.Items.IndexOf(OldGraph.Type);
            textBoxDataPath.Clear();
        }

        private void textBoxDataPath_TextChanged(object sender, EventArgs e)
        {
            buttonRecover.Enabled = IsChanged();
        }

        private void comboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            buttonRecover.Enabled = IsChanged();
        }
    }
}
