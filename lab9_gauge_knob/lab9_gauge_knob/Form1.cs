using System;
using System.Windows.Forms;
using GenLogic;

namespace lab9_gauge_knob
{
    public partial class Form1: Form
    {
        private Timer _updateTimer;

        public Form1()
        {
            InitializeComponent();
            InitializeTimer();

            SetupTemeratureValues();
        }

        private void SetupTemeratureValues()
        {
            glgKnob1.DrawingFile = @"C:\Program Files\GlgCE.4.5_x64\DEMOS\widgets\controls\knob1.g";
            glgMeter1.DrawingFile = @"C:\Program Files\GlgCE.4.5_x64\DEMOS\widgets\controls\alarm1.g";

            glgKnob1.SetDResource("Low", 0);
            glgKnob1.SetDResource("High", 10);
            glgKnob1.SetDResource("Value", 0);
            glgMeter1.SetDResource("Value", 0);
        }

        private void InitializeTimer()
        {
            _updateTimer = new Timer { Interval = 100 };
            _updateTimer.Tick += UpdateMeterFromKnob;
            _updateTimer.Start();
        }

        private void UpdateMeterFromKnob(object sender, EventArgs e)
        {
            try
            {
                // Получение значения с регулятора
                double knobValue = glgKnob1.GetDResource("Value");

                // Установка значения на шкале
                glgMeter1.SetDResource("Value", knobValue * 10);

                // Обновление отображения
                glgMeter1.Update();
                glgMeter1.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _updateTimer.Stop();
            base.OnFormClosing(e);
        }
    }
}
