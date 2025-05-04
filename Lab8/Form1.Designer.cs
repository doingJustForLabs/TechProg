namespace Lab8
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.sortTypeComboBox = new System.Windows.Forms.ComboBox();
            this.sortComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.transformComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.runButton = new System.Windows.Forms.Button();
            this.chosenColumn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenColumn)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridView.Location = new System.Drawing.Point(3, 30);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView.Size = new System.Drawing.Size(809, 606);
            this.dataGridView.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Size = new System.Drawing.Size(815, 638);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Предварительный просмотр";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(15, 81);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(512, 265);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.sortTypeComboBox);
            this.tabPage1.Controls.Add(this.sortComboBox);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage1.Size = new System.Drawing.Size(504, 222);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Действия и сортировка";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // sortTypeComboBox
            // 
            this.sortTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortTypeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sortTypeComboBox.Items.AddRange(new object[] {
            "\"как строки\"",
            "\"как числа\""});
            this.sortTypeComboBox.Location = new System.Drawing.Point(186, 88);
            this.sortTypeComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortTypeComboBox.Name = "sortTypeComboBox";
            this.sortTypeComboBox.Size = new System.Drawing.Size(295, 38);
            this.sortTypeComboBox.TabIndex = 3;
            // 
            // sortComboBox
            // 
            this.sortComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.sortComboBox.FormattingEnabled = true;
            this.sortComboBox.Items.AddRange(new object[] {
            "Не сортировать",
            "По алфавиту",
            "По алфавиту (обратный порядок)"});
            this.sortComboBox.Location = new System.Drawing.Point(186, 29);
            this.sortComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sortComboBox.Name = "sortComboBox";
            this.sortComboBox.Size = new System.Drawing.Size(295, 38);
            this.sortComboBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Сортировка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тип сортировки";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.transformComboBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPage2.Size = new System.Drawing.Size(504, 228);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Преобразование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 30);
            this.label4.TabIndex = 0;
            this.label4.Text = "Преобразование";
            // 
            // transformComboBox
            // 
            this.transformComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transformComboBox.Enabled = false;
            this.transformComboBox.FormattingEnabled = true;
            this.transformComboBox.Items.AddRange(new object[] {
            "Не преобразовывать",
            "К верхнему регистру",
            "К нижнему регистру"});
            this.transformComboBox.Location = new System.Drawing.Point(19, 72);
            this.transformComboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.transformComboBox.Name = "transformComboBox";
            this.transformComboBox.Size = new System.Drawing.Size(318, 38);
            this.transformComboBox.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.runButton);
            this.groupBox2.Controls.Add(this.chosenColumn);
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(815, 0);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Size = new System.Drawing.Size(539, 638);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // runButton
            // 
            this.runButton.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.runButton.Location = new System.Drawing.Point(15, 361);
            this.runButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(512, 65);
            this.runButton.TabIndex = 4;
            this.runButton.Text = "Запустить";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // chosenColumn
            // 
            this.chosenColumn.Location = new System.Drawing.Point(247, 28);
            this.chosenColumn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.chosenColumn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chosenColumn.Name = "chosenColumn";
            this.chosenColumn.Size = new System.Drawing.Size(81, 35);
            this.chosenColumn.TabIndex = 2;
            this.chosenColumn.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.chosenColumn.ValueChanged += new System.EventHandler(this.chosenColumn_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(215, 30);
            this.label3.TabIndex = 0;
            this.label3.Text = "Выбранный столбец:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(168F, 168F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1361, 638);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chosenColumn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox sortTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox sortComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown chosenColumn;
        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox transformComboBox;
    }
}

