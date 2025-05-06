namespace lab9
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.buttonFormat = new System.Windows.Forms.Button();
            this.buttonChangeChartType = new System.Windows.Forms.Button();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.buttonCreateTab = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControl.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabControl.Location = new System.Drawing.Point(3, 38);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(570, 509);
            this.tabControl.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.comboBoxChartType);
            this.panel1.Controls.Add(this.buttonFormat);
            this.panel1.Controls.Add(this.buttonChangeChartType);
            this.panel1.Controls.Add(this.buttonLoadData);
            this.panel1.Location = new System.Drawing.Point(612, 66);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(435, 481);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Тип диаграммы/графика";
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxChartType.FormattingEnabled = true;
            this.comboBoxChartType.Items.AddRange(new object[] {
            "Линейная(ый)",
            "Точечная(ый)"});
            this.comboBoxChartType.Location = new System.Drawing.Point(251, 42);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(159, 21);
            this.comboBoxChartType.TabIndex = 6;
            // 
            // buttonFormat
            // 
            this.buttonFormat.Location = new System.Drawing.Point(20, 161);
            this.buttonFormat.Name = "buttonFormat";
            this.buttonFormat.Size = new System.Drawing.Size(104, 23);
            this.buttonFormat.TabIndex = 5;
            this.buttonFormat.Text = "Форматировать";
            this.buttonFormat.UseVisualStyleBackColor = true;
            this.buttonFormat.Click += new System.EventHandler(this.buttonFormat_Click);
            // 
            // buttonChangeChartType
            // 
            this.buttonChangeChartType.Location = new System.Drawing.Point(20, 106);
            this.buttonChangeChartType.Name = "buttonChangeChartType";
            this.buttonChangeChartType.Size = new System.Drawing.Size(104, 23);
            this.buttonChangeChartType.TabIndex = 4;
            this.buttonChangeChartType.Text = "Изменить тип графика";
            this.buttonChangeChartType.UseVisualStyleBackColor = true;
            this.buttonChangeChartType.Click += new System.EventHandler(this.buttonChangeChartType_Click);
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Location = new System.Drawing.Point(20, 42);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(104, 23);
            this.buttonLoadData.TabIndex = 3;
            this.buttonLoadData.Text = "Загрузить данные";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.buttonLoadData_Click);
            // 
            // buttonCreateTab
            // 
            this.buttonCreateTab.Location = new System.Drawing.Point(612, 23);
            this.buttonCreateTab.Name = "buttonCreateTab";
            this.buttonCreateTab.Size = new System.Drawing.Size(104, 23);
            this.buttonCreateTab.TabIndex = 2;
            this.buttonCreateTab.Text = "Создать вкладку";
            this.buttonCreateTab.UseVisualStyleBackColor = true;
            this.buttonCreateTab.Click += new System.EventHandler(this.buttonCreateTab_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 559);
            this.Controls.Add(this.buttonCreateTab);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonFormat;
        private System.Windows.Forms.Button buttonChangeChartType;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.Button buttonCreateTab;
        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.Label label1;
    }
}

