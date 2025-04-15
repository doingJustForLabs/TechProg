using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addTabBtn_Click(object sender, EventArgs e)
        {
            TabPage currentTabPage = tabControl.SelectedTab;

            TabPage newTabPage = new TabPage();
            newTabPage.Text = (tabControl.Controls.Count + 1).ToString();
            newTabPage.BackColor = currentTabPage.BackColor;

            tabControl.Controls.Add(newTabPage);
            tabControl.SelectedTab = newTabPage;

            foreach (Control control in currentTabPage.Controls)
            {
                Control newControl = null;

                if (control is RichTextBox textBox)
                {
                    newControl = new RichTextBox
                    {
                        Text = textBox.Text,
                        Location = textBox.Location,
                        Size = textBox.Size,
                        Name = textBox.Name,
                    };
                }

                if (control is Label label)
                {
                    newControl = new Label
                    {
                        Text = label.Text,
                        Location = label.Location,
                        Size = label.Size
                    };
                }
                newTabPage.Controls.Add(newControl);
            }
        }

        private void deleteTabBtn_Click(object sender, EventArgs e)
        {
            TabPage currentTabPage = tabControl.SelectedTab;

            int prevTabIndex = tabControl.Controls.Count - 2;

            if (prevTabIndex < 0)
            {
                MessageBox.Show("Должен быть хотя-бы один набор", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var prev_tabPage = tabControl.TabPages[prevTabIndex];

            tabControl.Controls.RemoveAt(tabControl.Controls.Count - 1);
            tabControl.SelectedTab = prev_tabPage;
        }

        private void runBtn_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox.Items.Clear();

                for (int tab = 0; tab < tabControl.TabPages.Count; tab++)
                {
                    TabPage tabPage = tabControl.TabPages[tab];

                    RichTextBox xTextBox = tabPage.Controls["richTextBox1"] as RichTextBox;
                    RichTextBox yTextBox = tabPage.Controls["richTextBox2"] as RichTextBox;

                    int[] xValues = ValidationError.ValidateRichTextBox(xTextBox, tabPage);
                    int[] yValues = ValidationError.ValidateRichTextBox(yTextBox, tabPage);

                    if (!ValidationError.ValidateValues(xValues, yValues))
                    {
                        return;
                    }

                    string fileName = $"G{tab + 1:0000}.rez";
                    FileManager.DataToRezFile(fileName, tab, xValues, yValues);

                    comboBox.Items.Add(fileName);    
                    comboBox.SelectedIndex = tab;
                    comboBox.Enabled = true;
                }

                MessageBox.Show("Наборы расчитаны!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                readBtn.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void readBtn_Click(object sender, EventArgs e)
        {
            string fileName = comboBox.SelectedItem.ToString();
            FileManager.RezFileToData(dataGridView, fileName, upLeftCoords, bottomRightCoords);
        }
    }

    public static class ValidationError
    {
        public static bool ValidateValues(int[] x, int[] y)
        {
            if (x == null || y == null)
            {
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (x.Length == 0 ||  y.Length == 0)
            {
                MessageBox.Show("Данные не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (x.Length != y.Length)
            {
                MessageBox.Show("Непарное количество x и y", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static int[] ValidateRichTextBox(RichTextBox richTextBox, TabPage tabPage)
        {
            string[] strings = richTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<int> values = new List<int>();

            for (int i = 0; i < strings.Length; i++)
            {
                if (int.TryParse(strings[i], out int value))
                {
                    values.Add(value);
                }
                else
                {
                    return null;
                }
            }
            return values.ToArray();
        }
    }
}
