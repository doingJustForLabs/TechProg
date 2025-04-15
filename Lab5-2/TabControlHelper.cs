using System;
using System.Windows.Forms;

public static class TabControlHelper
{
    // Рекурсивный поиск элемента по Tag (работает внутри GroupBox/Panel)
    //public static T FindControlByTag<T>(Control parent, string tag) where T : Control
    //{
    //    if (parent == null || string.IsNullOrEmpty(tag))
    //        return null;

    //    foreach (Control control in parent.Controls)
    //    {
    //        // Если нашли нужный элемент
    //        if (control.Tag != null && control.Tag.ToString() == tag && control is T)
    //            return (T)control;

    //        // Рекурсивный поиск во вложенных контейнерах
    //        if (control.HasChildren)
    //        {
    //            T foundControl = FindControlByTag<T>(control, tag);
    //            if (foundControl != null)
    //                return foundControl;
    //        }
    //    }
    //    return null;
    //}

    // Рекурсивное копирование элемента и его дочерних компонентов
    private static Control CloneControlWithChildren(Control sourceControl)
    {
        if (sourceControl == null)
            return null;

        // Создаём новый экземпляр того же типа
        Control newControl = (Control)Activator.CreateInstance(sourceControl.GetType());

        // Копируем основные свойства
        newControl.Text = sourceControl.Text;
        newControl.Tag = sourceControl.Tag;
        newControl.Location = sourceControl.Location;
        newControl.Size = sourceControl.Size;
        newControl.Font = sourceControl.Font;
        newControl.BackColor = sourceControl.BackColor;

        // Особые свойства для NumericUpDown
        if (sourceControl is NumericUpDown sourceNumeric && newControl is NumericUpDown newNumeric)
        {
            newNumeric.Value = sourceNumeric.Value;
            newNumeric.Minimum = sourceNumeric.Minimum;
            newNumeric.Maximum = sourceNumeric.Maximum;
            newNumeric.DecimalPlaces = sourceNumeric.DecimalPlaces;
            newNumeric.Increment = sourceNumeric.Increment;
        }

        // Копируем дочерние элементы (для GroupBox, Panel и т. д.)
        //if (sourceControl.HasChildren)
        //{
        //    foreach (Control child in sourceControl.Controls)
        //    {
        //        Control clonedChild = CloneControlWithChildren(child);
        //        newControl.Controls.Add(clonedChild);
        //    }
        //}

        return newControl;
    }

    // Добавление новой вкладки (копии существующей)
    public static TabPage CloneTabPage(TabPage sourceTab)
    {
        if (sourceTab == null)
            throw new ArgumentNullException(nameof(sourceTab));

        // Создаем новую вкладку с таким же заголовком
        TabPage newTab = new TabPage(sourceTab.Text + " (Копия)");

        // Глубокое копирование всех элементов управления
        CopyControls(sourceTab, newTab);

        return newTab;
    }

    private static void CopyControls(Control sourceParent, Control destinationParent)
    {
        foreach (Control sourceControl in sourceParent.Controls)
        {
            // Создаем копию элемента управления
            Control newControl = (Control)Activator.CreateInstance(sourceControl.GetType());

            // Копируем основные свойства
            newControl.Name = sourceControl.Name;
            newControl.Text = sourceControl.Text;
            newControl.Tag = sourceControl.Tag;
            newControl.Location = sourceControl.Location;
            newControl.Size = sourceControl.Size;
            newControl.Font = sourceControl.Font;
            newControl.BackColor = sourceControl.BackColor;
            newControl.ForeColor = sourceControl.ForeColor;
            newControl.Enabled = sourceControl.Enabled;
            newControl.Visible = sourceControl.Visible;

            // Особые свойства для NumericUpDown
            if (sourceControl is NumericUpDown sourceNumeric && newControl is NumericUpDown newNumeric)
            {
                newNumeric.Value = sourceNumeric.Value;
                newNumeric.Minimum = sourceNumeric.Minimum;
                newNumeric.Maximum = sourceNumeric.Maximum;
                newNumeric.DecimalPlaces = sourceNumeric.DecimalPlaces;
                newNumeric.Increment = sourceNumeric.Increment;
            }
            // Аналогично для других специальных контролов (CheckBox, ComboBox и т.д.)

            // Добавляем элемент в новый контейнер
            destinationParent.Controls.Add(newControl);

            // Рекурсивно копируем дочерние элементы
            if (sourceControl.HasChildren)
            {
                CopyControls(sourceControl, newControl);
            }
        }
    }
}