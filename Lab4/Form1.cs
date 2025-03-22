using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();
            pathTextBox.Text = "";
            pathTextBox.ForeColor = Color.Black;
            pathTextBox.Text = folderBrowserDialog1.SelectedPath;
        }

        private void showButton_Click(object sender, EventArgs e)
        {
            string rootDir = pathTextBox.Text;

            if (!Directory.Exists(rootDir))
            {
                MessageBox.Show("Такого пути не существует");
                return;
            }

            logTextBox.Text = $"Папка: {rootDir}\n\n";

            foreach (var dir in Directory.EnumerateDirectories(rootDir, "*", SearchOption.AllDirectories))
            {
                logTextBox.Text += $"{dir}\n";
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

        private void clearButton_Click(object sender, EventArgs e)
        {
            logTextBox.Text = "";
        }

        private void runButton_Click(object sender, EventArgs e)
        {
            string rootDir = pathTextBox.Text;

            if (!Directory.Exists(rootDir))
            {
                MessageBox.Show("Такого пути не существует");
                return;
            }

            logTextBox.Text = $"Папка: {rootDir}\n\n";

            int task1 = findFilesWithNums(rootDir);

            logTextBox.Text += $"Задание 1. Папок с числом в названии: {task1}";
        }

        private void stopButton_Click(object sender, EventArgs e)
        {

        }

        public int findFilesWithNums(string dirPath)
        {
            string rootDir = pathTextBox.Text;
            int countFiles = 0;

            foreach (var dir in Directory.EnumerateDirectories(rootDir, "*", SearchOption.AllDirectories))
            {
                string folderName = new DirectoryInfo(dir).Name;

                if (folderName.Any(char.IsDigit))
                {
                    countFiles += 1;
                }
            }
            return countFiles;
        }
    }
}
