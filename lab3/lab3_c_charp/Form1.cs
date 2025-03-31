using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;
//using TextBox = System.Windows.Forms.TextBox;
//using Button = System.Windows.Forms.Button;

namespace lab3_c_charp
{
    public partial class Form1: Form
    {
        private List<(double x, double result, string error)> _calculationResults = new List<(double x, double result, string error)>();
        

        public static int N_j = 1000000;
        private static double[] j = new double[N_j];
        private static void jSqrt(double[] j)
        {

            for (int i = 0; i < N_j; i++)
            {
                j[i] = Math.Sqrt(i + 1);
                //Console.WriteLine(j[i]);
            }
        }

        public Form1()
        {
            jSqrt(j);
            InitializeComponent();
            
            this.Size = new Size(800, 600);

            //CalculateButton.Click += new EventHandler(CalculateButton_Click);

            //dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //dataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        }

        public static double F1(double x)
        {
            return Math.Exp(x / Math.PI);
        }

        public static double F2(double x)
        {
            if ((1-1/(1-x)) > 0){
                return Math.Log(1 - 1 / (1 - x))/Math.Log(4);
            }
            else
            {
                return double.NaN;
            }
        }

        public static double F3(double x)
        {
            if(x <= 0)
            {
                return Math.Tan(1/Math.Pow(x, 2));
            }
            else
            {
                //return Math.Sinh(Math.Pow(x, 2) - Math.Log(x));
                double result = Math.Sinh(Math.Pow(x, 2) - Math.Log(x));
                //if (double.IsNaN(result) || double.IsInfinity(result))
                //    return double.NaN;
                return result;
            }
                
        }

        public static double F4(double x)
        {
            double sumF4 = 0.0;
            //double[] j = Array.Empty<double>();
            int i = 0;
            do
            {
                if (x + j[i] != 0)
                //if (x + Math.Sqrt(i) != 0)
                {
                    sumF4 += 1 / (x + j[i]);
                    //sumF4 += 1 / (x + Math.Sqrt(i));
                }
                else
                {
                    return double.NaN;
                }
                i++;
            } while (i < N_j);
            return sumF4;

        }

        private async void CalculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                double x0 = double.Parse(textBoxX0.Text);
                double xk = double.Parse(textBoxXk.Text);
                int numberOfPoints = int.Parse(textBoxStep.Text);

                if (numberOfPoints <= 0 || numberOfPoints > 5000)
                {
                    MessageBox.Show("Кол-во чисел в диапазоне должен быть больше 999 и не больше 5000.");
                    return;
                }
                if(xk <= x0)
                {
                    MessageBox.Show("x0 должно быть меньше xk");
                    return;
                }

                await functionResult(x0, xk, numberOfPoints);
            }
            catch (FormatException)
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private async Task functionResult(double x0, double xk, int numberOfPoints)
        {
            Console.WriteLine("Запуск метода functionResult");

            dataGridView.Rows.Clear();
            dataGridView.Columns.Clear();

            dataGridView.Columns.Add("X", "X");
            //dataGridView.Columns.Add("F1", "F1");
            //dataGridView.Columns.Add("F2", "F2");
            //dataGridView.Columns.Add("F3", "F3");
            dataGridView.Columns.Add("Sum", "Sum");
            dataGridView.Columns.Add("Error", "Ошибка");

            //int i = 0;
            //double x = x0;
            double step = (xk - x0) / (numberOfPoints - 1);

            double[] resultsArray = new double[numberOfPoints];
            var results = new ConcurrentBag<(double x, double result, string error)>();
            bool flag1 = false;

            progressBar1.Value = 0;
            progressBar1.Maximum = numberOfPoints;

            //var tasks = new List<Task>();
            await Task.Run(() =>
            {
                Parallel.For(0, numberOfPoints, i =>
                {
                    //string errorDetails = "";
                    double x = x0 + i * step;
                    //await ProcessPointAsync(x);
                    try
                    {
                        //var f1Task = Task.Run(() => F1(x));
                        //var f2Task = Task.Run(() => F2(x));
                        //var f3Task = Task.Run(() => F3(x));
                        //var f4Task = Task.Run(() => F4(x));

                        //await Task.WhenAll(f1Task, f2Task, f3Task, f4Task);

                        double f1 = F1(x);
                        if (double.IsNaN(f1) || double.IsInfinity(f1))
                        {
                            //errorDetails += "F1 ";
                            throw new ArgumentException("F1 вернула некорректное значение.");
                        }

                        double f2 = F2(x);
                        if (double.IsNaN(f2) || double.IsInfinity(f2))
                        {
                            //errorDetails += "F2 ";
                            throw new ArgumentException("F2 вернула некорректное значение.");
                        }

                        double f3 = F3(x);
                        if (double.IsNaN(f3) || double.IsInfinity(f3))
                        {
                            //errorDetails += "F3 ";
                            throw new ArgumentException("F3 вернула некорректное значение.");
                        }

                        double f4 = F4(x);
                        if (double.IsNaN(f4) || double.IsInfinity(f4))
                        {
                            //errorDetails += "F4 ";
                            throw new ArgumentException("F4 вернула некорректное значение.");
                        }

                        double result = f1 + f2 + f3 + f4;
                        results.Add((x, result, "NoError"));
                        resultsArray[i] = result;
                    }
                    catch (ArgumentException ex)
                    {
                        results.Add((x, double.NaN, ex.Message));
                        flag1 = true;
                    }
                    progressBar1.Invoke((MethodInvoker)(() => progressBar1.Value++));
                    //i++;
                });
            });
            //while (i < numberOfPoints);

            //await Task.WhenAll(tasks);

            var sortedResults = results.OrderBy(r => r.x).ToList();
            _calculationResults = sortedResults;

            dataGridView.Invoke((MethodInvoker)(() =>
            {
                foreach (var r in sortedResults)
                {
                    dataGridView.Rows.Add(
                        r.x.ToString("F5"), // Форматируем X до 5 знаков
                        r.result.ToString("E5"), // Форматируем результат до 5 знаков
                        r.error
                        );
                }
            }));


            if (flag1)
            {
                MessageBox.Show("Некорректные аргументы функции");
            }

            saveButton.Invoke((MethodInvoker)(() => saveButton.Enabled = true));
        }
        //async Task ProcessPointAsync(double x)
        //{
        //    var result = await Calculate(x);
        //    dataGridView.Rows.Add(x, result); // Добавляем в том же порядке
        //}


        //private async Task functionResult(double x0, double xk)
        //{
        //    //CultureInfo.CurrentCulture = new CultureInfo("en-US");
        //    int i = 0;
        //    int numberOfPoints = 100;
        //    double step = (xk - x0) / (numberOfPoints - 1);
        //    double[] results = new double[numberOfPoints];
        //    do
        //    {
        //        double x = x0 + i * step;
        //        Task<double> task1 = Task.Run(() => F1(x));
        //        Task<double> task2 = Task.Run(() => F2(x));
        //        Task<double> task3 = Task.Run(() => F3(x));


        //        try
        //        {
        //            await Task.WhenAll(task1, task2, task3);

        //            if (double.IsNaN(task1.Result)) throw new ArgumentException("F1 вернула NaN.");
        //            if (double.IsNaN(task2.Result)) throw new ArgumentException("F2 вернула NaN.");
        //            if (double.IsNaN(task3.Result)) throw new ArgumentException("F3 вернула NaN.");

        //            // Проверка на Infinity
        //            if (double.IsInfinity(task1.Result)) throw new ArgumentException("F1 вернула Infinity.");
        //            if (double.IsInfinity(task2.Result)) throw new ArgumentException("F2 вернула Infinity.");
        //            if (double.IsInfinity(task3.Result)) throw new ArgumentException("F3 вернула Infinity.");

        //            results[i] = F1(x) + F2(x) + F3(x);
        //        }
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine($"Ошибка: {ex.Message}");
        //            results[i] = double.NaN;
        //        }
        //        Console.WriteLine(Double.IsNaN(results[i]) ? double.NaN : results[i]);
        //        i++;
        //    } while (i < numberOfPoints);

        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            // Инициализация компонентов формы
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Сохранить результаты"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileSaver.SaveResultsToFile(saveFileDialog.FileName, _calculationResults);
            }
        }
    }
}
