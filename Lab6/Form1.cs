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
                foreach (TabPage tabPage in tabControl.TabPages)
                {
                    RichTextBox xTextBox = tabPage.Controls["richTextBox1"] as RichTextBox;
                    RichTextBox yTextBox = tabPage.Controls["richTextBox2"] as RichTextBox;

                    List<double> xValues = ValidationError.ValidateRichTextBox(xTextBox, tabPage);
                    List<double> yValues = ValidationError.ValidateRichTextBox(yTextBox, tabPage);

                    if (!ValidationError.ValidateValues(xValues, yValues))
                    {
                        return;
                    }

                    FileManager.DataToRezFiles(tabControl, xValues, yValues);

                    for (int i = 0; i < xValues.Count; i++)
                    {
                        logRichTextBox.Text += $"x: {xValues[i].ToString()}\n";
                        logRichTextBox.Text += $"y: {yValues[i].ToString()}\n";
                        logRichTextBox.Text += $"G(x,y) {CalculateManager.G(xValues[i], yValues[i])}\n";
                    }
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }

    public static class ValidationError
    {
        public static bool ValidateValues(List<double> x, List<double> y)
        {
            if (x.Count == 0 ||  y.Count == 0)
            {
                MessageBox.Show("Данные не заполнены", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (x.Count != y.Count)
            {
                MessageBox.Show("Данных должно быть равное количество", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static List<double> ValidateRichTextBox(RichTextBox richTextBox, TabPage tabPage)
        {
            string[] strings = richTextBox.Text.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            List<double> values = new List<double>();

            for (int i = 0; i < strings.Length; i++)
            {
                if (double.TryParse(strings[i], out double value))
                {
                    values.Add(value);
                }
                else
                {
                    MessageBox.Show($"Некорректные данные в наборе {tabPage.Text}");
                    return null;
                }
            }
            return values;
        }
    }
}
