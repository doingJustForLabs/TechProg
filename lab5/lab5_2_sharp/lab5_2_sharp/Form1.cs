//using Lab5;
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

namespace lab5_2_sharp
{
    public partial class Form1: Form
    {
        private readonly CalculationManager _calculationManager;
        private readonly DataLoader _dataLoader = new DataLoader();
        private readonly string resultsPath = @"D:\Holn\Desktop\results";
        private readonly Random _rand = new Random();
        public Form1()
        {
            InitializeComponent();
            _calculationManager = new CalculationManager(resultsPath);
            _calculationManager.InitializeLogFile();
            timerFilesUpdate.Enabled = true;
            InitializeAdditionalTabs();
        }

        private void InitializeAdditionalTabs()
        {
            for (int i = 2; i <= 3; i++)
            {
                var newTab = new TabPage($"{i}");

                foreach (Control control in tabControl1.TabPages[0].Controls)
                {
                    var clone = CloneControl(control);
                    newTab.Controls.Add(clone);
                }

                tabControl1.TabPages.Add(newTab);
            }
        }

        private void BtnAddTab_Click(object sender, EventArgs e)
        {
            var newTab = new TabPage($"{tabControl1.TabCount + 1}");

            // Копируем содержимое с первой вкладки
            if (tabControl1.TabCount > 0)
            {
                var template = tabControl1.TabPages[0];
                foreach (Control control in template.Controls)
                {
                    var clone = CloneControl(control);
                    newTab.Controls.Add(clone);
                }
            }

            tabControl1.TabPages.Add(newTab);
        }

        private void BtnRemoveTab_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount > 3)
            {
                tabControl1.TabPages.Remove(tabControl1.SelectedTab);
            }
            else
            {
                MessageBox.Show("Должно оставаться минимум 3 набора данных!", "Предупреждение",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private Control CloneControl(Control original)
        {
            if (original is TextBox textBox)
            {
                return new TextBox
                {
                    Name = textBox.Name,
                    Location = textBox.Location,
                    Size = textBox.Size,
                    Text = textBox.Text
                };
            }

            if (original is Label label)
            {
                return new Label
                {
                    Name = label.Name,
                    Text = label.Text,
                    Font = new Font(label.Font.FontFamily, label.Font.Size, label.Font.Style),
                    Location = label.Location,
                    Size = label.Size
                };
            }

            if (original is Button button)
            {
                var newButton = new Button
                {
                    Name = button.Name,
                    Text = button.Text,
                    Location = button.Location,
                    Size = button.Size
                };

                if (button.Name == "btnCalculate")
                {
                    // Сохраняем ссылку на родительскую вкладку в Tag
                    var parentTab = (TabPage)button.Parent;
                    if (button.Name == "btnCalculate")
                    {
                        newButton.Click += BtnCalculate_Click;
                    }
                    else if (button.Name == "btnGenerate")
                    {
                        newButton.Click += BtnGenerate_Click;
                    }
                }

                return newButton;
            }

            return null;
        }

        private void BtnCalculate_Click(object sender, EventArgs e)
        {
            if (tabControl1.TabCount == 0)
            {
                MessageBox.Show("Нет вкладок для расчета!", "Информация",
                               MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            List<string> failedTabs = new List<string>();

            foreach (TabPage tab in tabControl1.TabPages)
            {
                try
                {
                    var inputs = GetInputValues(tab);
                    _calculationManager.ProcessCalculation(
                        inputs.X0, inputs.Y0, inputs.Xk, inputs.yCount,
                        inputs.StepX, inputs.StepY, tab.Text);
                }
                catch (Exception ex)
                {
                    // Запоминаем вкладки с ошибками
                    failedTabs.Add($"{tab.Text} ({ex.Message})");
                }
            }

            LoadFileList();

            if (failedTabs.Any())
            {
                string message = "Не удалось рассчитать следующие вкладки:\n" +
                                string.Join("\n", failedTabs);

                MessageBox.Show(message, "Результаты расчета",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Все вкладки успешно рассчитаны!", "Успех",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Information);
            }
        }

        //private bool CalculateForTab(TabPage tab)
        //{
        //    List<string> failedTabs = new List<string>();

        //    try
        //    {
        //        var inputs = GetInputValues(tab);
        //        _calculationManager.ProcessCalculation(
        //            inputs.X0, inputs.Y0, inputs.Xk, inputs.yCount,
        //            inputs.StepX, inputs.StepY, tab.Text);
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }
        //}

        private (double X0, double Y0, double Xk, double yCount, double StepX, double StepY) GetInputValues(TabPage tab)
        {
            return (
                GetValueFromTab(tab, "textBoxX0"),
                GetValueFromTab(tab, "textBoxY0"),
                GetValueFromTab(tab, "textBoxXk"),
                GetValueFromTab(tab, "textBoxNy"),
                GetValueFromTab(tab, "textBoxStepX"),
                GetValueFromTab(tab, "textBoxStepY")
            );
        }

        private (double X0, double Y0, double Xk, double yCount, double StepX, double StepY) GenerateValidValues()
        {
            double x0 = Math.Round((_rand.NextDouble() * 20) - 10, 2);
            double xk = x0 + Math.Round(_rand.NextDouble() * 10 + 1, 2);
            double stepX = Math.Round((xk - x0) / (_rand.Next(3, 10)), 2);
            stepX = Math.Max(stepX, 0.1);

            double y0 = Math.Round((_rand.NextDouble() * 20) - 10, 2);
            double yCount = _rand.Next(1, 20);
            double stepY = Math.Round(_rand.NextDouble() * 3 + 0.5, 2);

            return (x0, y0, xk, yCount, stepX, stepY);
        }

        private void FillTabWithValues(TabPage tab, (double X0, double Y0, double Xk, double yCount, double StepX, double StepY) values)
        {
            var fieldMap = new Dictionary<string, string>
            {
                {"textBoxX0", values.X0.ToString()},
                {"textBoxY0", values.Y0.ToString()},
                {"textBoxXk", values.Xk.ToString()},
                {"textBoxNy", values.yCount.ToString()},
                {"textBoxStepX", values.StepX.ToString()},
                {"textBoxStepY", values.StepY.ToString()}
            };

            foreach (Control control in tab.Controls)
            {
                if (control is TextBox textBox && fieldMap.ContainsKey(textBox.Name))
                {
                    textBox.Text = fieldMap[textBox.Name];
                }
            }
        }

        private void BtnGenerate_Click(object sender, EventArgs e)
        {
            var tabValues = new Dictionary<TabPage, (double X0, double Y0, double Xk, double yCount, double StepX, double StepY)>();

            // Генерируем уникальные значения для каждой вкладки
            foreach (TabPage tab in tabControl1.TabPages)
            {
                tabValues[tab] = GenerateValidValues();
            }

            // Заполняем вкладки сгенерированными значениями
            foreach (var kvp in tabValues)
            {
                FillTabWithValues(kvp.Key, kvp.Value);
            }

            MessageBox.Show("Все вкладки заполнены уникальными корректными значениями!", "Готово",
                          MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private double GetValueFromTab(TabPage tab, string controlName)
        {
            foreach (Control control in tab.Controls)
            {
                if (control is TextBox textBox && control.Name == controlName)
                {
                    if (double.TryParse(textBox.Text, out double value))
                        return value;

                    throw new Exception($"Неверное значение в поле {controlName}");
                }
            }
            throw new Exception($"Поле {controlName} не найдено");
        }

        private void BtnLoadData_Click(object sender, EventArgs e)
        {
            using(var dialog = new OpenFileDialog())
            {
                dialog.Filter = "DAT files (*.dat)|*.dat";
                //dialog.Multiselect = false;
                dialog.InitialDirectory = @"D:\User\Desktop\results";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    var data = _dataLoader.LoadFromFile(dialog.FileName);
                    if (data != null)
                    {
                        DisplayLoadedData(data);
                    }
                    else
                    {
                        MessageBox.Show("Ошибка загрузки файла!", "Ошибка",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void DisplayLoadedData(CalculationData data)
        {
            dataGridViewFiles.Visible = true;
            dataGridViewFiles.Columns.Clear();

            dataGridViewFiles.Columns.Add("y\\x", "y\\x");
            foreach (var x in data.XValues)
                dataGridViewFiles.Columns.Add(x.ToString(), x.ToString());

            // Добавляем строки с результатами
            for (int i = 0; i < data.YValues.Length; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridViewFiles);
                row.Cells[0].Value = data.YValues[i];

                for (int j = 0; j < data.XValues.Length; j++)
                {
                    if (double.IsNaN(data.Results[i, j]))
                    {
                        row.Cells[j + 1].Value = "NaN";
                    }
                    else
                    {
                        row.Cells[j + 1].Value = data.Results[i, j];
                    }
                }

                dataGridViewFiles.Rows.Add(row);
            }
        }

        private void DisplayCalculationData(CalculationData data)
        {
            dataGridViewFiles.Visible = true;
            dataGridViewFiles.Columns.Clear();
            dataGridViewFiles.Columns.Add("y\\x", "y\\x");

            foreach (var x in data.XValues)
                dataGridViewFiles.Columns.Add($"x{x}", x.ToString());

            for (int i = 0; i < data.YValues.Length; i++)
            {
                var row = new DataGridViewRow();
                row.CreateCells(dataGridViewFiles);
                row.Cells[0].Value = data.YValues[i];

                for (int j = 0; j < data.XValues.Length; j++)
                {
                    if (double.IsNaN(data.Results[i, j]))
                    {
                        row.Cells[j + 1].Value = "NaN";
                    }
                    else
                    {
                        row.Cells[j + 1].Value = data.Results[i, j];
                    }
                }

                dataGridViewFiles.Rows.Add(row);
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdatePointsList();
        }

        private void btnShowPoints_Click(object sender, EventArgs e)
        {
            UpdatePointsList();
        }

        private void UpdatePointsList()
        {
            if (tabControl1.SelectedTab != null)
            {
                ShowPointsForTab(tabControl1.SelectedTab);
            }
            else
            {
                MessageBox.Show("Нет выбранной вкладки!", "Ошибка",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ShowPointsForTab(TabPage tab)
        {
            listBox1.Items.Clear();

            try
            {
                var inputs = GetInputValues(tab);
                var (xValues, yValues) = PointGenerator.GeneratePoints(
                    inputs.X0, inputs.Xk, inputs.StepX,
                    inputs.Y0, inputs.yCount, inputs.StepY);

                listBox1.Items.Add($"=== Точки для вкладки {tab.Text} ===");
                listBox1.Items.AddRange(PointGenerator.FormatPoints(xValues, yValues).ToArray());
            }
            catch (Exception ex)
            {
                listBox1.Items.Add($"Ошибка чтения параметров для вкладки {tab.Text}: {ex.Message}");
            }
        }

        private void LoadFileList()
        {
            listBoxFiles.Items.Clear();

            try
            {
                // Получаем все файлы по шаблону G####.dat
                var files = Directory.GetFiles(resultsPath, "G*.dat")
                                   .Select(Path.GetFileName)
                                   .OrderBy(f => f)  // Сортируем по имени
                                   .ToArray();

                if (files.Length == 0)
                {
                    listBoxFiles.Items.Add("Файлы не найдены");
                    return;
                }

                listBoxFiles.Items.AddRange(files);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке списка файлов: {ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void ListBoxFiles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem == null) return;

            string fileName = listBoxFiles.SelectedItem.ToString();
            string filePath = Path.Combine(resultsPath, fileName);

            try
            {
                var data = _dataLoader.LoadFromFile(filePath);
                if (data != null)
                {
                    DisplayCalculationData(data);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при загрузке файла {fileName}:\n{ex.Message}",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void timerFilesUpdate_Tick(object sender, EventArgs e)
        {
            LoadFileList();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
