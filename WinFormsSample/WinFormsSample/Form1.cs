using System;
using System.Drawing;
using System.Windows.Forms;
using LiveCharts.WinForms;

namespace WinFormsSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetupGauges();
        }

        private void SetupGauges()
        {
            CreateGaugePair("Скорость (км/ч)", 0, 200, 50, 0, 200);
            CreateGaugePair("Температура (°C)", -20, 100, 25, -20, 100);
            CreateGaugePair("Давление (бар)", 0, 10, 5, 0, 10);
            CreateGaugePair("Влажность (%)", 0, 100, 30, 0, 100);
            CreateGaugePair("Напряжение (В)", 0, 220, 110, 0, 220);
            CreateGaugePair("Ток (А)", 0, 50, 10, 0, 50);
            CreateGaugePair("Частота (Гц)", 0, 60, 50, 0, 60);
            CreateGaugePair("Уровень топлива", 0, 100, 75, 0, 100);
            CreateGaugePair("Обороты (RPM)", 0, 8000, 3000, 0, 8000);
            CreateGaugePair("Заряд батареи", 0, 100, 80, 0, 100);
        }

        private void CreateGaugePair(string title, double min, double max,
                                   double initialValue, double gaugeMin, double gaugeMax)
        {
            var panel = new Panel
            {
                Dock = DockStyle.Top,
                Height = 120,
                Padding = new Padding(10)
            };

            // 1. Шкала (WinForms-версия)
            var gauge = new LiveCharts.WinForms.AngularGauge
            {
                Dock = DockStyle.Left,
                Width = 120,
                Value = initialValue,
                FromValue = gaugeMin,
                ToValue = gaugeMax,
                Labels = title,
                Font = new Font("Segoe UI", 8, FontStyle.Bold),
                Sections = new[]
                {
                    new LiveCharts.WinForms.AngularSection
                    {
                        FromValue = gaugeMin,
                        ToValue = (gaugeMax - gaugeMin) * 0.3,
                        Fill = Color.Green
                    },
                    new LiveCharts.WinForms.AngularSection
                    {
                        FromValue = (gaugeMax - gaugeMin) * 0.3,
                        ToValue = (gaugeMax - gaugeMin) * 0.7,
                        Fill = Color.Yellow
                    },
                    new LiveCharts.WinForms.AngularSection
                    {
                        FromValue = (gaugeMax - gaugeMin) * 0.7,
                        ToValue = gaugeMax,
                        Fill = Color.Red
                    }
                }
            };

            // 2. Регулятор (MaterialSlider)
            var trackBar = new TrackBar
            {
                Dock = DockStyle.Fill,
                Minimum = (int)min,
                Maximum = (int)max,
                Value = (int)initialValue,
                TickFrequency = (int)((max - min) / 10),
                LargeChange = (int)((max - min) / 5)
            };

            // Связь регулятора и шкалы
            trackBar.ValueChanged += (sender, e) =>
            {
                gauge.Value = trackBar.Value;
            };

            // Подпись
            var label = new MaterialLabel
            {
                Text = $"{title}: {initialValue}",
                Dock = DockStyle.Bottom,
                TextAlign = ContentAlignment.MiddleCenter
            };

            // Обновление подписи
            trackBar.ValueChanged += (sender, e) =>
            {
                label.Text = $"{title}: {trackBar.Value}";
            };

            panel.Controls.Add(gauge);
            panel.Controls.Add(trackBar);
            panel.Controls.Add(label);
            this.Controls.Add(panel);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
