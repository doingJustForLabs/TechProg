using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace lab4_sharp
{
    public partial class Form1: Form
    {
        private string currentDirectory;
        public Form1()
        {
            InitializeComponent();
            currentDirectory = "D:\\holn\\Desktop\\test";
            textBoxPath.Text = currentDirectory;
            LoadDirectory(currentDirectory);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ButtonDialog_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK)
            {
                currentDirectory = folderBrowserDialog1.SelectedPath;
                textBoxPath.Text = currentDirectory;
                LoadDirectory(currentDirectory); // Загрузка содержимого выбранной папки
            }
        }

        private void LoadDirectory(string path)
        {
            // Очищаем текущие элементы в ListView
            listView1.Items.Clear();
            currentDirectory = path;
            textBoxPath.Text = path;

            try
            {
                var (filesWithDigit, filesWithoutDigit) = GetSortedFiles(path);
                ConfigureListView();
                DisplayFiles(filesWithDigit, "Файлы с числом в названии");
                DisplayFiles(filesWithoutDigit, "Файлы без числа в названии");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки файлов:\n{ex.Message}");
            }
        }

        private (List<string> filesWithDigit, List<string> filesWithoutDigit) GetSortedFiles(string path)
        {
            var files = Directory.GetFiles(path);
            var filesWithDigit = files.Where(f => Regex.IsMatch(Path.GetFileName(f), @"\d")).OrderByDescending(f => f).ToList();
            var filesWithoutDigit = files.Except(filesWithDigit).OrderByDescending(f => f).ToList();

            return (filesWithDigit, filesWithoutDigit);
        }

        private void ConfigureListView()
        {
            listView1.View = View.Details;
            listView1.Columns.Clear();
            listView1.Columns.Add("Имя файла", 200);
            listView1.Columns.Add("Путь", 400);
        }

        private void DisplayFiles(List<string> files, string groupName)
        {
            var group = new ListViewGroup(groupName);
            listView1.Groups.Add(group);

            foreach (var file in files)
            {
                var item = new ListViewItem(Path.GetFileName(file)) { Group = group };
                item.SubItems.Add(file);
                listView1.Items.Add(item);
            }
        }

        private void ButtonCopyFiles_Click(object sender, EventArgs e)
        {
            string targetDirectory = @"D:\holn\Desktop\final";

            if (!Directory.Exists(targetDirectory))
            {
                try
                {
                    Directory.CreateDirectory(targetDirectory); // Создаём директорию, если её нет
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ошибка при создании директории: {ex.Message}");
                    return;
                }
            }

            try
            {
                string[] files = Directory.GetFiles(currentDirectory);

                foreach (var file in files)
                {
                    string fileName = Path.GetFileName(file);
                    string filePrefix = fileName.Substring(0, Math.Min(3, fileName.Length));

                    string subFolderPath = Path.Combine(targetDirectory, filePrefix);

                    if (!Directory.Exists(subFolderPath))
                    {
                        Directory.CreateDirectory(subFolderPath);
                    }

                    string finalFilePath = Path.Combine(subFolderPath, fileName);

                    File.Copy(file, finalFilePath, overwrite: true);
                    //File.Move(Path.GetFullPath(file), finalFilePath);
                }
                LoadDirectory(currentDirectory);
                MessageBox.Show($"Файлы успешно скопированы в папку {Path.GetFullPath(targetDirectory)}");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при копировании в финальную папку с подпапками: {ex.Message}");
            }
        }

        private void ButtonDeleteMark_Click(object sender, EventArgs e)
        {
            try
            {
                string[] files = Directory.GetFiles(currentDirectory);

                foreach (var file in files)
                {
                    string fileName = Path.GetFileNameWithoutExtension(file);
                    string getExtension = Path.GetExtension(file);
                    if (fileName.EndsWith("!"))
                    {
                        string newFileName = fileName.TrimEnd('!') + getExtension;
                        string newFilePath = Path.Combine(Path.GetDirectoryName(file), newFileName);
                        File.Move(file, newFilePath);
                    }

                    // После переименования файлов перезагружаем директорию для обновления ListView
                    LoadDirectory(currentDirectory);
                }
                MessageBox.Show("Конечные '!' успешно удалены из имен файлов.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при удалении ! на конце файла: {ex.Message}");
            }
        }

        private void TextBoxPath_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newPath = textBoxPath.Text;
                if (Directory.Exists(newPath))
                {
                    LoadDirectory(newPath);
                }
            }
        }
    }
}
