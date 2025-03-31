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
    public partial class InputBoxForm: Form
    {
        public InputBoxForm()
        {
            InitializeComponent();
        }

        private void DeactivateWindow(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            if (Application.OpenForms["Form1"] == null) // Если Form1 закрыта, создаем новую
            {
                Form1 form1 = new Form1();
                form1.Show();
            }
        }
    }
}
