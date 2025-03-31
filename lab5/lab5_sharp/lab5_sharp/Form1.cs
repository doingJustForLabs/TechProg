using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_sharp
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string inputDialog = Microsoft.VisualBasic.Interaction.InputBox(
                "Введите значение. Тип: decimal",
                "Ввод данных",
                "0"
            );

            decimal? result = CheckDecimal.ValDecimal(inputDialog);

            if (result.HasValue)
            {
                MessageBox.Show("Ввод корректный: " + result,
                                "Успех",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }

        private void InputButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
