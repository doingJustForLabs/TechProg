using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string selectedFunction;
        public string selectedMethod;

        private void methodComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedMethod = methodComboBox.SelectedItem.ToString();
        }

        private void funcComboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            selectedFunction = funcComboBox.SelectedItem.ToString();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ErrorHandler.ValidateComboBox(selectedFunction) || !ErrorHandler.ValidateComboBox(selectedMethod))
                {
                    return;
                }

                double a = (double)inputA.Value;
                double b = (double)inputB.Value;

                if (!ErrorHandler.ValidateIntervals(a, b))
                {
                    return;
                }

                int n = (int)inputN.Value;

                MessageBox.Show($"Выбрано: {selectedFunction}, {selectedMethod}");

                if (selectedMethod == "Метод левых прямоугольников")
                {
                    double result = Methods.LeftRectangleMethod(selectedFunction, a, b, n);
                }
                else if (selectedMethod == "Метод правых прямоугольников")
                {
                    double result = Methods.RightRectangleMethod(selectedFunction, a, b, n);
                }

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK);
            }
        }
    }

    public static class Methods
    {
        public static float RightRectangleMethod(string func, double a, double b, int n)
        {
            float sum = 0;
            double deltaX = (a - b) / n;

            return sum;
        }

        public static float LeftRectangleMethod(string func, double a, double b, int n)
        {
            float sum = 0;
            double deltaX = (a - b) / n;

            return sum;
        }
    }

    public class Solution
    {
        public float f(double x)
        {
            return 0;
        }
    }

    public static class ErrorHandler
    {
        public static bool ValidateComboBox(string selectedComboBox)
        {
            if (selectedComboBox == null)
            {
                MessageBox.Show("Выберите функцию и метод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool ValidateIntervals(double a, double b)
        {
            if (a > b)
            {
                MessageBox.Show("Некорректный интервал", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
