using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Lab7.IntegralMethods;
using static Lab7.FileManager;


namespace Lab7
{
    public partial class Form1: Form
    {
        public string[] selectedFunctions;
        public string selectedMethod;
        DataTable dataTable = new DataTable();

        GraphicManager graphicManager = new GraphicManager();

        public Form1()
        {
            InitializeComponent();
            InitializeDataTable();
            graphicManager.PreRenderGraphs();
        }

        private void InitializeDataTable()
        {
            dataTable.Columns.Clear();
            dataTable.Columns.Add("№", typeof(int));
            dataTable.Columns.Add("x", typeof(double));
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            try
            {
                if (selectedFunctions == null || selectedFunctions.Length == 0)
                {
                    MessageBox.Show("Выберите хотя бы одну функцию!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(selectedMethod))
                {
                    MessageBox.Show("Выберите метод интегрирования!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (!double.TryParse(inputA.Text, out double a) ||
                    !double.TryParse(inputB.Text, out double b) ||
                    !double.TryParse(inputDeltaX.Text, out double deltaX) ||
                    a >= b || deltaX <= 0)
                {
                    MessageBox.Show("Ошибка ввода параметров! Убедитесь, что a < b и Δx > 0", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                buttonOK.Enabled = true;

                dataTable.Rows.Clear();
                InitializeMethodColumns();

                foreach (var functionName in selectedFunctions)
                {
                    Func<double, double> selectedFunc = GetSelectedFunction(functionName);
                    double result = CalculateIntegral(selectedFunc, a, b, deltaX, selectedMethod);

                    FileManager.SaveCalculationToFile(
                        selectedMethod,
                        functionName,
                        a, b, deltaX,
                        result,
                        dataTable
                    );
                }
                MessageBox.Show($"Вычисления записаны в файл {historyFilePath}", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);

                dataGridView.DataSource = dataTable;

            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Ошибка", MessageBoxButtons.OK);
            }
        }

        private void InitializeMethodColumns()
        {
            while (dataTable.Columns.Count > 2)
            {
                dataTable.Columns.RemoveAt(2);
            }

            switch (selectedMethod)
            {
                case "Метод правых прямоугольников":
                    dataTable.Columns.Add("f(x + Δx)");
                    dataTable.Columns.Add("sum");
                    break;

                case "Метод левых прямоугольников":
                    dataTable.Columns.Add("f(x)");
                    dataTable.Columns.Add("sum");
                    break;
            }
        }

        private Func<double, double> GetSelectedFunction(string functionName)
        {
            switch (functionName)
            {
                case "exp(x)": 
                    return x => Math.Exp(x);
                case "ln(x)": 
                    return x => Math.Log(x);
                case "lg(x)": 
                    return x => Math.Log10(x);
                default: 
                    throw new ArgumentException("Неизвестная функция");
            }
        }

        private double CalculateIntegral(Func<double, double> f, double a, double b, double deltaX, string methodName)
        {
            dataTable.Rows.Clear();

            switch (methodName)
            {
                case "Метод правых прямоугольников":
                    return RightRectangleMethod(f, a, b, deltaX, dataTable);

                case "Метод левых прямоугольников":
                    return LeftRectangleMethod(f, a, b, deltaX, dataTable);

                default:
                    throw new ArgumentException("Неизвестный метод");
            }
        }
    }
}
