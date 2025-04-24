namespace lab8
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.digitCounter = new System.Windows.Forms.NumericUpDown();
            this.letterLabel = new System.Windows.Forms.Label();
            this.digitLabel = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.countersTab = new System.Windows.Forms.TabPage();
            this.comboBoxLetters = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Row = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Original = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transformed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtersTab = new System.Windows.Forms.TabPage();
            this.transformGroup = new System.Windows.Forms.GroupBox();
            this.noTransform = new System.Windows.Forms.RadioButton();
            this.toUpper = new System.Windows.Forms.RadioButton();
            this.toLower = new System.Windows.Forms.RadioButton();
            this.firstCharGroup = new System.Windows.Forms.GroupBox();
            this.startsWithLetter = new System.Windows.Forms.RadioButton();
            this.noFilter = new System.Windows.Forms.RadioButton();
            this.startsWithDigit = new System.Windows.Forms.RadioButton();
            this.startsWithLetterOrDigit = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.digitCounter)).BeginInit();
            this.tabControl.SuspendLayout();
            this.countersTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.filtersTab.SuspendLayout();
            this.transformGroup.SuspendLayout();
            this.firstCharGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // digitCounter
            // 
            this.digitCounter.Enabled = false;
            this.digitCounter.Location = new System.Drawing.Point(165, 54);
            this.digitCounter.Maximum = new decimal(new int[] {
            9,
            0,
            0,
            0});
            this.digitCounter.Name = "digitCounter";
            this.digitCounter.Size = new System.Drawing.Size(120, 20);
            this.digitCounter.TabIndex = 1;
            this.digitCounter.ValueChanged += new System.EventHandler(this.DigitCounter_ValueChanged);
            // 
            // letterLabel
            // 
            this.letterLabel.AutoSize = true;
            this.letterLabel.Location = new System.Drawing.Point(15, 12);
            this.letterLabel.Name = "letterLabel";
            this.letterLabel.Size = new System.Drawing.Size(50, 13);
            this.letterLabel.TabIndex = 2;
            this.letterLabel.Text = "Буква: А";
            // 
            // digitLabel
            // 
            this.digitLabel.AutoSize = true;
            this.digitLabel.Location = new System.Drawing.Point(162, 12);
            this.digitLabel.Name = "digitLabel";
            this.digitLabel.Size = new System.Drawing.Size(53, 13);
            this.digitLabel.TabIndex = 3;
            this.digitLabel.Text = "Цифра: 0";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.countersTab);
            this.tabControl.Controls.Add(this.filtersTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1033, 557);
            this.tabControl.TabIndex = 4;
            // 
            // countersTab
            // 
            this.countersTab.Controls.Add(this.comboBoxLetters);
            this.countersTab.Controls.Add(this.dataGridView1);
            this.countersTab.Controls.Add(this.digitLabel);
            this.countersTab.Controls.Add(this.letterLabel);
            this.countersTab.Controls.Add(this.digitCounter);
            this.countersTab.Location = new System.Drawing.Point(4, 22);
            this.countersTab.Name = "countersTab";
            this.countersTab.Padding = new System.Windows.Forms.Padding(3);
            this.countersTab.Size = new System.Drawing.Size(1025, 531);
            this.countersTab.TabIndex = 0;
            this.countersTab.Text = "Счётчики";
            this.countersTab.UseVisualStyleBackColor = true;
            // 
            // comboBoxLetters
            // 
            this.comboBoxLetters.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLetters.Enabled = false;
            this.comboBoxLetters.FormattingEnabled = true;
            this.comboBoxLetters.Location = new System.Drawing.Point(18, 54);
            this.comboBoxLetters.Name = "comboBoxLetters";
            this.comboBoxLetters.Size = new System.Drawing.Size(121, 21);
            this.comboBoxLetters.TabIndex = 5;
            this.comboBoxLetters.SelectedIndexChanged += new System.EventHandler(this.ComboBoxLetters_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Row,
            this.Col,
            this.Original,
            this.Transformed});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(3, 101);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1019, 427);
            this.dataGridView1.TabIndex = 4;
            // 
            // Row
            // 
            this.Row.HeaderText = "Номер строки";
            this.Row.Name = "Row";
            // 
            // Col
            // 
            this.Col.HeaderText = "Номер столбца";
            this.Col.Name = "Col";
            // 
            // Original
            // 
            this.Original.HeaderText = "Старое значение";
            this.Original.Name = "Original";
            // 
            // Transformed
            // 
            this.Transformed.HeaderText = "Преобразованное значение";
            this.Transformed.Name = "Transformed";
            // 
            // filtersTab
            // 
            this.filtersTab.Controls.Add(this.transformGroup);
            this.filtersTab.Controls.Add(this.firstCharGroup);
            this.filtersTab.Location = new System.Drawing.Point(4, 22);
            this.filtersTab.Name = "filtersTab";
            this.filtersTab.Padding = new System.Windows.Forms.Padding(3);
            this.filtersTab.Size = new System.Drawing.Size(1025, 531);
            this.filtersTab.TabIndex = 1;
            this.filtersTab.Text = "Фильтры";
            this.filtersTab.UseVisualStyleBackColor = true;
            // 
            // transformGroup
            // 
            this.transformGroup.Controls.Add(this.noTransform);
            this.transformGroup.Controls.Add(this.toUpper);
            this.transformGroup.Controls.Add(this.toLower);
            this.transformGroup.Location = new System.Drawing.Point(37, 255);
            this.transformGroup.Name = "transformGroup";
            this.transformGroup.Size = new System.Drawing.Size(241, 209);
            this.transformGroup.TabIndex = 1;
            this.transformGroup.TabStop = false;
            this.transformGroup.Text = "Преобразование первой буквы";
            // 
            // noTransform
            // 
            this.noTransform.AutoSize = true;
            this.noTransform.Checked = true;
            this.noTransform.Location = new System.Drawing.Point(6, 126);
            this.noTransform.Name = "noTransform";
            this.noTransform.Size = new System.Drawing.Size(131, 17);
            this.noTransform.TabIndex = 7;
            this.noTransform.TabStop = true;
            this.noTransform.Text = "Без преобразований";
            this.noTransform.UseVisualStyleBackColor = true;
            this.noTransform.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // toUpper
            // 
            this.toUpper.AutoSize = true;
            this.toUpper.Location = new System.Drawing.Point(6, 39);
            this.toUpper.Name = "toUpper";
            this.toUpper.Size = new System.Drawing.Size(131, 17);
            this.toUpper.TabIndex = 5;
            this.toUpper.Text = "К верхнему регистру";
            this.toUpper.UseVisualStyleBackColor = true;
            this.toUpper.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // toLower
            // 
            this.toLower.AutoSize = true;
            this.toLower.Location = new System.Drawing.Point(6, 84);
            this.toLower.Name = "toLower";
            this.toLower.Size = new System.Drawing.Size(128, 17);
            this.toLower.TabIndex = 6;
            this.toLower.Text = "К нижнему регистру";
            this.toLower.UseVisualStyleBackColor = true;
            this.toLower.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // firstCharGroup
            // 
            this.firstCharGroup.Controls.Add(this.startsWithLetter);
            this.firstCharGroup.Controls.Add(this.noFilter);
            this.firstCharGroup.Controls.Add(this.startsWithDigit);
            this.firstCharGroup.Controls.Add(this.startsWithLetterOrDigit);
            this.firstCharGroup.Location = new System.Drawing.Point(37, 20);
            this.firstCharGroup.Name = "firstCharGroup";
            this.firstCharGroup.Size = new System.Drawing.Size(241, 198);
            this.firstCharGroup.TabIndex = 0;
            this.firstCharGroup.TabStop = false;
            this.firstCharGroup.Text = "Фильтр по первому символу";
            // 
            // startsWithLetter
            // 
            this.startsWithLetter.AutoSize = true;
            this.startsWithLetter.Location = new System.Drawing.Point(9, 36);
            this.startsWithLetter.Name = "startsWithLetter";
            this.startsWithLetter.Size = new System.Drawing.Size(128, 17);
            this.startsWithLetter.TabIndex = 1;
            this.startsWithLetter.Text = "Начинается с буквы";
            this.startsWithLetter.UseVisualStyleBackColor = true;
            this.startsWithLetter.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // noFilter
            // 
            this.noFilter.AutoSize = true;
            this.noFilter.Checked = true;
            this.noFilter.Location = new System.Drawing.Point(9, 165);
            this.noFilter.Name = "noFilter";
            this.noFilter.Size = new System.Drawing.Size(96, 17);
            this.noFilter.TabIndex = 4;
            this.noFilter.TabStop = true;
            this.noFilter.Text = "Без фильтров";
            this.noFilter.UseVisualStyleBackColor = true;
            this.noFilter.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // startsWithDigit
            // 
            this.startsWithDigit.AutoSize = true;
            this.startsWithDigit.Location = new System.Drawing.Point(9, 78);
            this.startsWithDigit.Name = "startsWithDigit";
            this.startsWithDigit.Size = new System.Drawing.Size(131, 17);
            this.startsWithDigit.TabIndex = 2;
            this.startsWithDigit.Text = "Начинается с цифры";
            this.startsWithDigit.UseVisualStyleBackColor = true;
            this.startsWithDigit.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // startsWithLetterOrDigit
            // 
            this.startsWithLetterOrDigit.AutoSize = true;
            this.startsWithLetterOrDigit.Location = new System.Drawing.Point(9, 123);
            this.startsWithLetterOrDigit.Name = "startsWithLetterOrDigit";
            this.startsWithLetterOrDigit.Size = new System.Drawing.Size(186, 17);
            this.startsWithLetterOrDigit.TabIndex = 3;
            this.startsWithLetterOrDigit.Text = "Начинается с цифры или буквы";
            this.startsWithLetterOrDigit.UseVisualStyleBackColor = true;
            this.startsWithLetterOrDigit.CheckedChanged += new System.EventHandler(this.FilterChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 557);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.digitCounter)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.countersTab.ResumeLayout(false);
            this.countersTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.filtersTab.ResumeLayout(false);
            this.transformGroup.ResumeLayout(false);
            this.transformGroup.PerformLayout();
            this.firstCharGroup.ResumeLayout(false);
            this.firstCharGroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.NumericUpDown digitCounter;
        private System.Windows.Forms.Label letterLabel;
        private System.Windows.Forms.Label digitLabel;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage countersTab;
        private System.Windows.Forms.TabPage filtersTab;
        private System.Windows.Forms.GroupBox firstCharGroup;
        private System.Windows.Forms.RadioButton startsWithLetter;
        private System.Windows.Forms.RadioButton noFilter;
        private System.Windows.Forms.RadioButton startsWithLetterOrDigit;
        private System.Windows.Forms.RadioButton startsWithDigit;
        private System.Windows.Forms.RadioButton noTransform;
        private System.Windows.Forms.RadioButton toLower;
        private System.Windows.Forms.RadioButton toUpper;
        private System.Windows.Forms.GroupBox transformGroup;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Row;
        private System.Windows.Forms.DataGridViewTextBoxColumn Col;
        private System.Windows.Forms.DataGridViewTextBoxColumn Original;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transformed;
        private System.Windows.Forms.ComboBox comboBoxLetters;
    }
}

