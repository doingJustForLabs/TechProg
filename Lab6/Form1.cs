using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lab6.Modules;

namespace Lab6
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView.DataSource = null;
                dataGridView.Rows.Clear();   

                DataTable table = new DataTable();
                table.Clear();
                table.Columns.Clear();

                table.Columns.Add("x");
                table.Columns.Add("y");
                table.Columns.Add("G(x, y)");


                double x0 = Convert.ToDouble(x0Val.Value);
                double xk = Convert.ToDouble(xkVal.Value);
                double stepX = Convert.ToDouble(xStepVal.Value);

                double y0 = Convert.ToDouble(y0Val.Value);
                double yk = Convert.ToDouble(ykVal.Value);
                double stepY = Convert.ToDouble(yStepVal.Value);

                if (stepX <= 0 || stepY <= 0)
                {
                    MessageBox.Show("Шаг должен быть больше 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                double x = x0;

                while (x <= xk + 1e-9)
                {
                    double y = y0;

                    while (y <= yk + 1e-9)
                    {
                        double result = Calculate.G(x, y);
                        table.Rows.Add(x, y, result);

                        double nextYStep = Math.Min(stepY, yk - y);
                        if (nextYStep <= 0) break;  
                        y += nextYStep;
                    }

                    double nextXStep = Math.Min(stepX, xk - x);
                    if (nextXStep <= 0) break; 
                    x += nextXStep;
                }

                dataGridView.DataSource = table;
                dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
    public static class Calculate
    {
        public static double G(double x, double y)
        {
            try
            {
                return x / (y - 2);

            } catch (DivideByZeroException)
            {
                return double.NaN;
            }
        }
    }
}
