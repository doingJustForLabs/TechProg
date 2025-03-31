using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_c_charp
{
    public partial class Form1: Form
    {
        struct Coefficients
        {
            public double A0, A1, A2;
            public double B0, B1, B2;
            public double C, Pref;
        }

        private Coefficients coeffs;
        private double[] pressures;
        private double[] temperatures;
        private double[,] experimentalMatrix;
        private double[,] calculatedMatrix;

        private const double MinPressure = 0.1; // Минимальное давление (МПа)
        private const double MaxPressure = 60.0; // Максимальное давление (МПа)
        private const double MinTemperature = 0.0; // Минимальная температура (К)
        private const double MaxTemperature = 500.0; // Максимальная температура (К)

        private TextBox txtPressures;
        private TextBox txtTemperatures;
        private Button btnCalculate;

        public Form1()
        {
            InitializeComponent();
            InitializeData();
            InitializeTabs();
            InitializeVersionOutput();
        }
        private void InitializeData()
        {
            //CultureInfo.CurrentCulture = new CultureInfo("en-US"); // для работы с точками в числах, а не запятыми (ru-RU)

            coeffs = new Coefficients
            {
                A0 = 1232.7,
                A1 = -0.8404,
                A2 = 0.1143e-3,
                B0 = 452.16,
                B1 = -1.5087,
                B2 = 1.4034e-3,
                C = 0.08365,
                Pref = 1.0
            };

            pressures = new[] {0.1, 0.3, 1.0, 5.0, 10.0, 20.0, 30.0, 40.0, 50.0, 60.0};
            temperatures = new[] {298.15, 323.15, 348.15, 373.15, 398.15};

            experimentalMatrix = new[,]
            {
                {991.7, 972.4, 953.2, 934.4, double.NaN},
                {double.NaN, double.NaN, double.NaN, double.NaN, 915.4},
                {992.3, 973.1, 953.9, 935.1, 916.2},
                {994.8, 976.0, 957.1, 938.6, 920.2},
                {998.0, 979.4, 961.0, 942.9, 925.0},
                {1003.9, 986.0, 968.3, 951.0, 933.9},
                {1009.5, 992.2, 975.2, 958.4, 942.0},
                {1014.9, 998.0, 981.5, 965.3, 949.5},
                {1019.9, 1003.5, 987.5, 971.8, 956.5},
                {1024.8, 1008.7, 993.1, 977.9, 963.1}
            };
        }

        private void InitializeTabs()
        {
            AddTabWithTable("Experimental Data", experimentalMatrix, pressures, temperatures);
            AddTabWithTable("Calculated Data", null, pressures, null);
            AddTabWithTable("Delta", null, pressures, temperatures);
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double[] userPressures = txtPressures.Text.Split(',')
                    .Select(p => double.Parse(p.Trim(), CultureInfo.InvariantCulture))
                    .ToArray();

                double[] userTemperatures = txtTemperatures.Text.Split(',')
                    .Select(t => double.Parse(t.Trim(), CultureInfo.InvariantCulture))
                    .ToArray();

                // Проверяем диапазон давлений
                foreach (var pressure in userPressures)
                {
                    if (pressure < MinPressure || pressure > MaxPressure)
                    {
                        MessageBox.Show($"Давление {pressure} вне диапазона. Диапазон: от {MinPressure} до {MaxPressure} MPa.");
                        return;
                    }
                }
                // Проверяем диапазон температур
                foreach (var temperature in userTemperatures)
                {
                    if (temperature < MinTemperature || temperature > MaxTemperature)
                    {
                        MessageBox.Show($"Температура {temperature} вне диапазона. Диапазон: от {MinTemperature} до {MaxTemperature} K.");
                        return;
                    }
                }

                if (userPressures.Length == 0 || userTemperatures.Length == 0)
                {
                    MessageBox.Show("Введите значения давления и температуры.");
                    return;
                }

                // Рассчитываем calculatedMatrix
                calculatedMatrix = CalculateDataMatrix(userPressures, userTemperatures, coeffs);

                // Обновляем вкладку "Calculated Data"
                var calculatedTab = tabControl1.TabPages
                    .Cast<TabPage>()
                    .FirstOrDefault(t => t.Text == "Calculated Data");

                if (calculatedTab != null)
                {
                    var dataGridView = calculatedTab.Controls
                        .OfType<DataGridView>()
                        .FirstOrDefault();

                    if (dataGridView != null)
                    {
                        dataGridView.Rows.Clear();
                        dataGridView.Columns.Clear();
                        FillDataGridView(dataGridView, calculatedMatrix, userPressures, userTemperatures);
                    }
                }

                // Рассчитываем дельту только после инициализации calculatedMatrix
                var deltaMatrix = CalculateDeltaMatrix(userPressures, userTemperatures);

                // Обновляем вкладку "Delta"
                var deltaTab = tabControl1.TabPages
                    .Cast<TabPage>()
                    .FirstOrDefault(t => t.Text == "Delta");

                if (deltaTab != null)
                {
                    var deltaDataGridView = deltaTab.Controls
                        .OfType<DataGridView>()
                        .FirstOrDefault();

                    if (deltaDataGridView != null)
                    {
                        deltaDataGridView.Rows.Clear();
                        deltaDataGridView.Columns.Clear();
                        FillDataGridView(deltaDataGridView, deltaMatrix, userPressures, userTemperatures);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибки сбора входных данных: " + ex.Message);
            }
        }


        private void AddTabWithTable(string title, double[,] data, double[] pressures, double[] temperatures)
        {
            var tabPage = new TabPage(title);
            var dataGridView = new DataGridView
            {
                Dock = DockStyle.Top,
                Height = 200,
                BackgroundColor = Color.Gray,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                ReadOnly = true,
            };

            CustomiseDataGridView(dataGridView);

            if (data != null)
            {
                FillDataGridView(dataGridView, data, pressures, temperatures);
            }
            else
            {
                // Создаем пустую таблицу
                dataGridView.Columns.Add("Pressure", "p/MPa");

                // Добавляем столбцы для температур только если temperatures не null
                if (temperatures != null)
                {
                    for (int i = 0; i < temperatures.Length; i++)
                    {
                        dataGridView.Columns.Add($"Temp{i}", $"{temperatures[i]} K");
                    }
                }
            }

            tabPage.Controls.Add(dataGridView);

            // Если это вкладка "Calculated Data", добавляем ввод пользователя
            if (title == "Calculated Data" && !tabPage.Controls.Contains(txtPressures))
            {
                var lblPressures = new Label { Text = "Давления (MPa, разделить запятой):", Top = 220, Left = 10, Width = 300};
                txtPressures = new TextBox { Top = 250, Left = 10, Width = 300 };
                var lblTemperatures = new Label { Text = "Температуры (K, разделить запятой):", Top = 270, Left = 10, Width = 300 };
                txtTemperatures = new TextBox { Top = 300, Left = 10, Width = 300 };
                btnCalculate = new Button { Text = "Рассчитать", Top = 330, Left = 10 };
                btnCalculate.Click += BtnCalculate_Click;

                tabPage.Controls.Add(lblPressures);
                tabPage.Controls.Add(txtPressures);
                tabPage.Controls.Add(lblTemperatures);
                tabPage.Controls.Add(txtTemperatures);
                tabPage.Controls.Add(btnCalculate);
            }

            tabControl1.TabPages.Add(tabPage);
        }


        private void CustomiseDataGridView(DataGridView dgv)
        {
            dgv.RowHeadersVisible = false;
            dgv.DefaultCellStyle.BackColor = Color.AliceBlue;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }

        private void FillDataGridView(DataGridView dgv, double[,] data, double[] pressures, double[] temperatures)
        {
            dgv.Columns.Add("Pressure", "p/MPa");

            for (int i = 0; i < temperatures.Length; i++)
            {
                dgv.Columns.Add($"Temp{i}", $"{temperatures[i]} K");
            }

            for (int row = 0; row < pressures.Length; row++)
            {
                string[] items = new string[temperatures.Length + 1];
                items[0] = pressures[row].ToString("F2");

                for (int col = 0; col < temperatures.Length; col++)
                {
                    items[col + 1] = double.IsNaN(data[row, col]) ? "NONE" : data[row, col].ToString("F3");
                }

                dgv.Rows.Add(items);
            }
        }


        private double[,] CalculateDataMatrix(double[] pressures, double[] temperatures, Coefficients coeffs)
        {
            double[,] matrix = new double[pressures.Length, temperatures.Length];
            
            for (int i = 0; i < pressures.Length; i++)
            {
                for (int j = 0; j < temperatures.Length; j++)
                {
                    matrix[i, j] = CalculateDensity(pressures[i], temperatures[j], coeffs);
                }
            }
            return matrix;
        }

        private double CalculateDensity(double p, double T, Coefficients coeffs)
        {
            double numerator = coeffs.A0 + coeffs.A1 * T + coeffs.A2 * T * T;
            double denominator = 1 - coeffs.C * Math.Log(
                (coeffs.B0 + coeffs.B1 * T + coeffs.B2 * T * T + p) /
                (coeffs.B0 + coeffs.B1 * T + coeffs.B2 * T * T + coeffs.Pref));

            return denominator == 0 ? double.NaN : numerator / denominator;
        }

        private double[,] CalculateDeltaMatrix(double[] userPressures, double[] userTemperatures)
        {
            double[,] deltaMatrix = new double[userPressures.Length, userTemperatures.Length];

            // Проверяем, инициализирован ли calculatedMatrix
            if (calculatedMatrix == null)
            {
                MessageBox.Show("Данные для расчета не доступны. Сначала рассчитайте их.");
                return deltaMatrix; // Возвращаем пустую матрицу
            }

            for (int i = 0; i < userPressures.Length; i++)
            {
                for (int j = 0; j < userTemperatures.Length; j++)
                {
                    int expPressureIndex = Array.IndexOf(pressures, userPressures[i]);
                    int expTemperatureIndex = Array.IndexOf(temperatures, userTemperatures[j]);

                    if (expPressureIndex != -1 && expTemperatureIndex != -1 &&
                        !double.IsNaN(experimentalMatrix[expPressureIndex, expTemperatureIndex]) &&
                        !double.IsNaN(calculatedMatrix[i, j])) // Теперь calculatedMatrix проверен на null
                    {
                        deltaMatrix[i, j] = Math.Abs(experimentalMatrix[expPressureIndex, expTemperatureIndex] - calculatedMatrix[i, j]);
                    }
                    else
                    {
                        deltaMatrix[i, j] = double.NaN;
                    }
                }
            }

            return deltaMatrix;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void InitializeVersionOutput()
        {
            string version1 = Application.ProductVersion;
            const string programDataChanging = "25/02/2025";
            //Console.WriteLine(version1.GetType().Name);
            var title = "Version";
            var tabPage = new TabPage(title);
            var textBox = new TextBox
            {
                Text = $"The version is: {version1}" + Environment.NewLine +
                $"Date of the program change: {programDataChanging}",
                Dock = DockStyle.Fill,
                Multiline = true,
                ReadOnly = true,

            };
                

            tabPage.Controls.Add(textBox);
            tabControl1.TabPages.Add(tabPage);


        }
    }
}
