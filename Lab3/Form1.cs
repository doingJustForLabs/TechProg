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

namespace Lab3
{
    public partial class Form1: Form
    {
        List<string[]> matrix_values = new List<string[]>();

        public Form1()
        {
            InitializeComponent();
        }

        private void button_calc_Click(object sender, EventArgs e)
        {
            listViewOutput.Items.Clear();
            ErrorCatch error = new ErrorCatch();
            Calculate calc = new Calculate();

            double x0 = (double)x0Value.Value;
            double xk = (double)xkValue.Value;
            double step = (double)stepValue.Value;

            double j_sum = 0;
            for (int j = 1; j < 1_000_000; j++)
            {
                j_sum += Math.Sqrt(j);
            }

            double x = x0;

            if (!error.ValidateStepValue(step, x0, xk))
            {
                return;
            }

            if (step > 0)
            {
                while (x <= xk)
                {
                    double res = calc.calculate(x, j_sum);
                    string[] values = { Math.Round(x, 3).ToString(), res.ToString() };

                    listViewOutput.Items.Add(new ListViewItem(values));
                    matrix_values.Add(values);

                    x += step;
                }
            } else
            {
                while (x >= xk)
                {
                    double res = calc.calculate(x, j_sum);
                    string[] values = { Math.Round(x, 3).ToString(), res.ToString() };

                    listViewOutput.Items.Add(new ListViewItem(values));
                    matrix_values.Add(values);

                    x += step;
                }
            }
            
        }

        private void buttonClearOutput_Click(object sender, EventArgs e)
        {
            listViewOutput.Items.Clear();
        }

        private void autoStepButton_Click(object sender, EventArgs e)
        {
            stepValue.Value = (xkValue.Value - x0Value.Value) / 1000;
        }

        private void randEndButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            xkValue.Value = random.Next(-100, 100);
        }

        private void randStartButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            x0Value.Value = random.Next(-100, 100);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog.Title = "Сохранить файл";
            saveFileDialog.FileName = "data.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = saveFileDialog.FileName; 
                SaveToFile(filePath);
            }
        }

        private void SaveToFile(string filePath)
        {
            if (matrix_values.Count == 0)
            {
                MessageBox.Show("Нет данных для сохранения.");
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    foreach (var array in matrix_values)
                    {
                        writer.WriteLine(string.Join(",", array)); 
                    }
                }
                MessageBox.Show("Данные успешно сохранены в файл: " + filePath);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении файла: " + ex.Message);
            }
        }
    }

    public class Calculate
    {
        public double F1(double x)
        {
            return Math.Exp(Math.Pow(x, 2) - 1);
        }

        public double F2(double x)
        {
            return Math.Cosh(1 / x);
        }

        public double F3(double x)
        {
            return (x <= 0) ? 1 / Math.Tan(1 + Math.Pow(x, 2)) : Math.Sin(Math.Sqrt(10 - x) - Math.Log(x));
        }

        public double F4(double x, double j)
        {
            return 1 / (x + j);
        }

        public double calculate(double x, double j_sum)
        {
            double res = 0;

            //try
            //{
                res += this.F1(x);
            //} catch (OverflowException)
            //{
                //return double.NaN;
            //}

            //try
            //{
                res += this.F2(x);
            //} catch (Exception)
            //{
            //    return double.NaN;
            //}

            //try
            //{
                res += this.F3(x);
            //} catch (Exception)
            //{
            //    return double.NaN;
            //}

            //try
            //{
                res += this.F4(x, j_sum);
            //}
            //catch (Exception)
            //{
            //    return double.NaN;
            //}

            return res;
        }
    }

    public class ErrorCatch
    {
        public bool ValidateStepValue(double step, double x0, double xk)
        {
            if (step == 0)
            {
                MessageBox.Show("Invalid step");
                return false;
            }

            if ((xk - x0) / 1000 < step)
            {
                MessageBox.Show("Rise up step (min 1000 operations)");
                return false;
            }
            return true;
        }
    }
}
