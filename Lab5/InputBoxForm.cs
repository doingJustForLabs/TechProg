using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Lab5.Modules
{
    public partial class InputBoxForm: Form
    {
        public string UserInput { get; private set; }

        public InputBoxForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.StartPosition = FormStartPosition.CenterParent;

            this.AcceptButton = buttonCancel;

        }
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            UserInput = userInputTextBox.Text.Trim().ToLower();

            if (UserInput != "1" && UserInput != "0" && UserInput != "true" && UserInput != "false")
            {
                MessageBox.Show("Неверный тип данных", "Информация", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
