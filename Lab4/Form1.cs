using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1 : Form
    {
        public List<string> initialFolders = new List<string>();

        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                pathTextBox.Text = folderBrowserDialog1.SelectedPath;
                pathTextBox.ForeColor = Color.Black;
            }
        }

        private void pathTextBox_Enter(object sender, EventArgs e)
        {
            if (pathTextBox.Text == "D:\\iT\\TEST_FOLDER")
            {
                pathTextBox.Text = "";
                pathTextBox.ForeColor = Color.Black;
            }
        }

        //private void clearButton_Click(object sender, EventArgs e)
        //{
        //    tabPageAfter.Controls.Clear();
        //    tabPageBefore.Controls.Clear();
        //}

        private void runButton_Click(object sender, EventArgs e)
        {
            string rootDir = pathTextBox.Text;

            if (!Directory.Exists(rootDir))
            {
                MessageBox.Show("Такого пути не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            initialFolders = Directory.GetDirectories(rootDir, "*", SearchOption.AllDirectories).ToList();

            DisplayFolders(tabPageBefore, initialFolders);

            using (var progressForm = new TaskProgress(rootDir))
            {
                if (progressForm.ShowDialog() == DialogResult.OK)
                { 
                    DisplayFolders(tabPageAfter, progressForm.UpdatedFolders, initialFolders);
                    tabControl1.SelectedTab = tabPageAfter;
                }
            }
        }

        private void DisplayFolders(TabPage tabPage, List<string> folders, List<string> oldFolders = null)
        {
            tabPage.Controls.Clear();

            RichTextBox rtb = new RichTextBox
            {
                Dock = DockStyle.Fill,
                ReadOnly = true,
            };

            foreach (var folder in folders)
            {
                string displayName = folder;

                // Подсвечиваем если:
                // 1. Это первая или последняя папка (они поменялись местами)
                // 2. Или если папки не было в oldFolders

                bool isSwapped = (folders.IndexOf(folder) == 0 ||
                                (folders.IndexOf(folder) == folders.Count - 1));

                if ((oldFolders != null && isSwapped) ||
                    (oldFolders != null && !oldFolders.Contains(folder)))
                {
                    rtb.SelectionColor = Color.Green;
                }
                else
                {
                    rtb.SelectionColor = rtb.ForeColor;
                }

                rtb.AppendText(displayName + Environment.NewLine);
                rtb.SelectionColor = rtb.ForeColor;
            }

            tabPage.Controls.Add(rtb);
        }
    }
}