using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;


namespace Lab9
{
    public partial class Form1: Form
    {

        public Form1()
        {
            InitializeComponent();
            GraphicManager graphicManager = new GraphicManager(zedGraphControl);
        }
  
        private void addTabBtn_Click(object sender, EventArgs e)
        {
            TabPage currentTabPage = tabControl.SelectedTab;

            TabPage newTabPage = new TabPage();
            newTabPage.Text = $"Диаграмма {(tabControl.Controls.Count + 1)}";
            newTabPage.BackColor = currentTabPage.BackColor;

            tabControl.Controls.Add(newTabPage);
            tabControl.SelectedTab = newTabPage;

            foreach (Control control in currentTabPage.Controls)
            {
                Control newControl = null;

                if (control is RichTextBox textBox)
                {
                    newControl = new RichTextBox
                    {
                        Text = textBox.Text,
                        Location = textBox.Location,
                        Size = textBox.Size,
                        Name = textBox.Name,
                    };
                }

                if (control is System.Windows.Forms.Label label)
                {
                    newControl = new System.Windows.Forms.Label
                    {
                        Text = label.Text,
                        Location = label.Location,
                        Size = label.Size
                    };
                }

                if (control is ZedGraphControl graph)
                {
                    newControl = new ZedGraphControl
                    {
                        Text = graph.Text,
                        Location = graph.Location,
                        Size = graph.Size,
                    };
                }

                newTabPage.Controls.Add(newControl);
            }
        }

        private void delTabBtn_Click(object sender, EventArgs e)
        {
            TabPage currentTabPage = tabControl.SelectedTab;

            int prevTabIndex = tabControl.Controls.Count - 2;

            if (prevTabIndex < 0)
            {
                MessageBox.Show("Должен быть хотя-бы один набор", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var prev_tabPage = tabControl.TabPages[prevTabIndex];

            tabControl.Controls.RemoveAt(tabControl.Controls.Count - 1);
            tabControl.SelectedTab = prev_tabPage;
        }
    }
}
