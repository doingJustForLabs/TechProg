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

namespace Lab5_2
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void solveButton_Click(object sender, EventArgs e)
        {
            try
            {
                Logger.LogProgramStart();
                TabPage currentTab = tabControl.SelectedTab; 

                NumericUpDown x0Numeric = FindNumericByTag(currentTab, "x0");
                NumericUpDown xkNumeric = FindNumericByTag(currentTab, "xk");
                NumericUpDown xStepNumeric = FindNumericByTag(currentTab, "xStep");

                NumericUpDown y0Numeric = FindNumericByTag(currentTab, "y0");
                NumericUpDown ykNumeric = FindNumericByTag(currentTab, "yk");
                NumericUpDown yStepNumeric = FindNumericByTag(currentTab, "yStep");

                double x0 = (double)x0Numeric.Value;
                double xk = (double)xkNumeric.Value;
                double xStep = (double)xStepNumeric.Value;

                double y0 = (double)y0Numeric.Value;
                double yk = (double)ykNumeric.Value;
                double yStep = (double)yStepNumeric.Value;

                if (yStep <= 0 || xStep <= 0)
                {
                    MessageBox.Show("Шаг должен быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();

                DataTable table = new DataTable();
                table.Clear();
                table.Columns.Clear();

                table.Columns.Add("x");
                table.Columns.Add("y");
                table.Columns.Add("G(x, y)");

                // Алгоритм
                double x = x0;

                while (x <= xk + 1e-9)
                {
                    double y = y0;

                    while (y <= yk + 1e-9)
                    {
                        double result = CalculateG(x, y);
                        table.Rows.Add(x, y, result);

                        double nextYStep = Math.Min(yStep, yk - y);
                        if (nextYStep <= 0) break;
                        y += nextYStep;
                    }

                    double nextXStep = Math.Min(xStep, xk - x);
                    if (nextXStep <= 0) break;
                    x += nextXStep;
                }

                Logger.SaveResultsToFile($"G{tabControl.SelectedIndex + 1:D4}.dat", table);
                MessageBox.Show($"Создан файл G{tabControl.SelectedIndex + 1:D4}.dat");
                //Logger.SaveResultsToFile("myErrors.log", table);
                //Logger.SaveResultsToFile("myProgram.log", table);

                dataGridView1.DataSource = table;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private NumericUpDown FindNumericByTag(Control parent, string tagName)
        {
            foreach (Control control in parent.Controls)
            {
                if (control is NumericUpDown numeric && control.Tag?.ToString() == tagName)
                    return numeric;

                if (control.HasChildren)
                {
                    var foundControl = FindNumericByTag(control, tagName);
                    if (foundControl != null)
                        return foundControl;
                }
            }
            return null;
        }

        private void deletePageButton_Click(object sender, EventArgs e)
        {

        }

        private void addPageButton_Click(object sender, EventArgs e)
        {
            if (tabControl.TabPages.Count == 0)
            {
                MessageBox.Show("Нет доступных вкладок для клонирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            TabPage firstTab = tabControl.TabPages[0];
            
            TabPage newTab = new TabPage($"{tabControl.TabPages.Count + 1 }");

            // Копируем все элементы первой вкладки
            foreach (Control control in firstTab.Controls)
            {
                Control clonedControl = CloneControl(control);
                if (clonedControl != null) 
                {
                    newTab.Controls.Add(clonedControl);
                }
            }

            // Добавляем новую вкладку в TabControl
            tabControl.TabPages.Add(newTab);
        }

        private Control CloneControl(Control original)
        {
            if (original is NumericUpDown numeric)
            {
                return new NumericUpDown
                {
                    Tag = numeric.Tag,
                    DecimalPlaces = numeric.DecimalPlaces,
                    Value = numeric.Value,
                    Minimum = numeric.Minimum,
                    Maximum = numeric.Maximum,
                    Increment = numeric.Increment,
                    Size = numeric.Size,
                    Location = numeric.Location
                };
            }

            if (original is Label label)
            {
                return new Label
                {
                    Name = label.Name,
                    Text = label.Text,
                    Font = new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style),
                    Location = label.Location,
                    Size = label.Size
                };
            }

            // Если это GroupBox, копируем все вложенные элементы
            //if (original is GroupBox groupBox)
            //{
            //    GroupBox groupBoxCopy = new GroupBox
            //    {
            //        Name = groupBox.Name + "_copy",
            //        Text = groupBox.Text,
            //        Size = groupBox.Size,
            //        Location = groupBox.Location,
            //        Font = groupBox.Font
            //    };

            //    foreach (Control child in groupBox.Controls)
            //    {
            //        Control clonedChild = CloneControl(child);
            //        if (clonedChild != null)
            //        {
            //            groupBoxCopy.Controls.Add(clonedChild);
            //        }
            //    }
            //    return groupBoxCopy;
            //}

            return null;
        }

        private double CalculateG(double x, double y)
        {
            try
            {
                return x / (y - 2);
            }
            catch (DivideByZeroException)
            {
                Logger.LogError(x, y, "Деление на 0");
                return double.NaN;
            }
            catch (OverflowException)
            {
                Logger.LogError(x, y, "Переполнение");
                return double.NaN;
            }
            catch (Exception ex)
            {
                Logger.LogError(x, y, ex.Message);
                return double.NaN;
            }
        }
    }
}
