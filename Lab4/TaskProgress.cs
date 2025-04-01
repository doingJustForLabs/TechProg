using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Lab4
{
    public partial class TaskProgress: Form
    {
        private string rootDir;
        public List<string> UpdatedFolders { get; private set; } = new List<string>();

        public TaskProgress(string folderPath)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            rootDir = folderPath;
        }

        private void TaskProgress_Load(object sender, EventArgs e)
        {
            backgroundWorker.RunWorkerAsync();
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread.Sleep(500);

            // Задача 1
            backgroundWorker.ReportProgress(0, "1. Подсчет папок с цифрами...");
            backgroundWorker.ReportProgress(25, $"Найдено папок с цифрами: {Tasks.CountFoldersWithDigits(rootDir)}");

            System.Threading.Thread.Sleep(500);

            // Задача 2
            backgroundWorker.ReportProgress(30, $"2. {Tasks.ReplaceDigitsInFolderNames(rootDir)}");
            backgroundWorker.ReportProgress(55, "Замена цифр завершена");

            System.Threading.Thread.Sleep(500);

            // Задача 3
            backgroundWorker.ReportProgress(60, $"3. {Tasks.TrimZerosFromFolderNames(rootDir)}");
            backgroundWorker.ReportProgress(85, "Удаление нулей завершено");

            UpdatedFolders = Directory.GetDirectories(rootDir, "*", SearchOption.AllDirectories).ToList();

            System.Threading.Thread.Sleep(500);

            // Задача 4
            backgroundWorker.ReportProgress(90, $"4. {Tasks.SwapFirstAndLastFolders(UpdatedFolders)}");
            backgroundWorker.ReportProgress(100, "Готово!");

        }
        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
            lblStatus.Text = e.UserState.ToString();
        }
        
        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show($"Ошибка: {e.Error.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
            {
                this.DialogResult = DialogResult.OK;
            }
            closeButton.Enabled = true;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
