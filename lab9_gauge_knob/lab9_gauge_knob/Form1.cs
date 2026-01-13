using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            glgControl1.DrawingFile = "C:\\Program Files\\GlgCE.4.5_x64\\DEMOS\\widgets\\controls\\meter1.g";
            glgControl2.DrawingFile = "C:\\Program Files\\GlgCE.4.5_x64\\DEMOS\\widgets\\controls\\knob1.g";
            //glgControl2.GlgInput += GlgKnob_Input;
            _updateTimer = new Timer { Interval = 50 };
            _updateTimer.Tick += UpdateMeterFromKnob;
            _updateTimer.Start();
        }

        private void UpdateMeterFromKnob(object sender, EventArgs e)
        {
            try
            {
                // Получаем значение Knob (0-100)
                double knobValue = glgControl2.GetDResource("Value");
                Console.WriteLine($"Knob Value: {knobValue}");

                // Обновляем Meter
                glgControl1.SetDResource("Value", knobValue);

                glgControl1.Update();
                glgControl1.Refresh();
                //glgControl2.Refresh();

                double currentValue = glgControl1.GetDResource("Value");
                Console.WriteLine($"Meter Value: {currentValue}");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            _updateTimer.Stop(); // Важно: останавливаем таймер
            base.OnFormClosing(e);
        }

        private void glgControl4_Click(object sender, EventArgs e)
        {

        }
    }
}
