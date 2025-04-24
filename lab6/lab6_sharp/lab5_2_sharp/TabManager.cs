using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_2_sharp
{
    public class TabManager
    {
        private readonly TabControl _tabControl;
        private readonly Random _rand = new Random();

        public TabManager(TabControl tabControl)
        {
            _tabControl = tabControl;
        }

        public void InitializeAdditionalTabs(int count)
        {
            for (int i = 2; i <= count; i++)
            {
                AddTab(i.ToString());
            }
        }

        public void AddTab(string tabName)
        {
            var newTab = new TabPage(tabName);
            if (_tabControl.TabCount > 0)
            {
                var template = _tabControl.TabPages[0];
                foreach (Control control in template.Controls)
                {
                    var clone = CloneControl(control);
                    newTab.Controls.Add(clone);
                }
            }
            _tabControl.TabPages.Add(newTab);
        }

        public void RemoveTab(TabPage tab)
        {
            if (_tabControl.TabCount > 3)
            {
                _tabControl.TabPages.Remove(tab);
            }
            else
            {
                throw new InvalidOperationException("Должно оставаться минимум 3 набора данных!");
            }
        }

        public Control CloneControl(Control original)
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
                return new Button
                {
                    Name = button.Name,
                    Text = button.Text,
                    Location = button.Location,
                    Size = button.Size,
                    Tag = button.Parent // Сохраняем родительскую вкладку
                };
            }

            return null;
        }

        public (double X0, double Y0, double Xk, double yCount, double StepX, double StepY) GetInputValues(TabPage tab)
        {
            double x0 = GetValueFromTab(tab, "textBoxX0");
            double xk = GetValueFromTab(tab, "textBoxXk");
            double stepX = GetValueFromTab(tab, "textBoxStepX");
            double yCount = GetValueFromTab(tab, "textBoxNy");
            double stepY = GetValueFromTab(tab, "textBoxStepY");
            double y0 = GetValueFromTab(tab, "textBoxY0");

            // Проверка количества точек по X
            double xPoints = (xk - x0) / stepX + 1;
            if (xPoints > 100)
            {
                throw new Exception($"Количество точек по X ({xPoints}) превышает 100. Увеличьте шаг StepX.");
            }

            // Проверка количества точек по Y
            if (yCount > 100)
            {
                throw new Exception($"Количество точек по Y ({yCount}) превышает 100.");
            }

            return (x0, y0, xk, yCount, stepX, stepY);
        }

        public double GetValueFromTab(TabPage tab, string controlName)
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

        public void FillTabWithValues(TabPage tab, (double X0, double Y0, double Xk, double yCount, double StepX, double StepY) values)
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

        public (double X0, double Y0, double Xk, double yCount, double StepX, double StepY) GenerateValidValues()
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
    }
}
