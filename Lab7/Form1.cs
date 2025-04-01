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
        private ErrorHandler errorHandler = new ErrorHandler();
        private Methods methods = new Methods();

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
            if (!errorHandler.ValidateComboBox(selectedFunction) || !errorHandler.ValidateComboBox(selectedMethod))
            {
                return;
            }

            double a = (double)inputA.Value;
            double b = (double)inputB.Value;

            if (!errorHandler.ValidateIntervals(a, b))
            {
                return;
            }

            int n = (int)inputN.Value;

            MessageBox.Show($"Выбрано: {selectedFunction}, {selectedMethod}");

            if (selectedMethod == "Метод левых прямоугольников")
            {
                double result = methods.LeftRectangleMethod(selectedFunction, a, b, n);
            }
            else if (selectedMethod == "Метод правых прямоугольников")
            {
                double result = methods.RightRectangleMethod(selectedFunction, a, b, n);
            }

        }
    }

    public class Methods
    {
        public float RightRectangleMethod(string func, double a, double b, int n)
        {
            float sum = 0;
            double deltaX = (a - b) / n;

            return sum;
        }

        public float LeftRectangleMethod(string func, double a, double b, int n)
        {
            float sum = 0;
            double deltaX = (a - b) / n;

            return sum;
        }
    }

    public class Solution
    {
        Methods methods = new Methods();

        public float f(double x)
        {
            return 0;
        }
    }

    public class ErrorHandler
    {
        public bool ValidateComboBox(string selectedComboBox)
        {
            if (selectedComboBox == null)
            {
                MessageBox.Show("Выберите функцию и метод", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public bool ValidateIntervals(double a, double b)
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
