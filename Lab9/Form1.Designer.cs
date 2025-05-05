namespace Lab9
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
            this.comboBoxChartType = new System.Windows.Forms.ComboBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCreateGraph = new System.Windows.Forms.Button();
            this.textBoxGraphTitle = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.settingsGroupBox = new System.Windows.Forms.GroupBox();
            this.currentGraphicTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.applyChangesBtn = new System.Windows.Forms.Button();
            this.checkBoxLegend = new System.Windows.Forms.CheckBox();
            this.numericLineWidth = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxXAxis = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.diagramGroupBox = new System.Windows.Forms.GroupBox();
            this.dataGroupBox = new System.Windows.Forms.GroupBox();
            this.axesGroupBox = new System.Windows.Forms.GroupBox();
            this.comboBoxYAxis = new System.Windows.Forms.ComboBox();
            this.panelColorPreview = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.settingsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineWidth)).BeginInit();
            this.diagramGroupBox.SuspendLayout();
            this.dataGroupBox.SuspendLayout();
            this.axesGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBoxChartType
            // 
            this.comboBoxChartType.FormattingEnabled = true;
            this.comboBoxChartType.Location = new System.Drawing.Point(81, 109);
            this.comboBoxChartType.Name = "comboBoxChartType";
            this.comboBoxChartType.Size = new System.Drawing.Size(221, 32);
            this.comboBoxChartType.TabIndex = 0;
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(22, 35);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1128, 995);
            this.tabControl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Тип";
            // 
            // buttonCreateGraph
            // 
            this.buttonCreateGraph.Location = new System.Drawing.Point(23, 188);
            this.buttonCreateGraph.Name = "buttonCreateGraph";
            this.buttonCreateGraph.Size = new System.Drawing.Size(279, 59);
            this.buttonCreateGraph.TabIndex = 3;
            this.buttonCreateGraph.Text = "Создать график";
            this.buttonCreateGraph.UseVisualStyleBackColor = true;
            this.buttonCreateGraph.Click += new System.EventHandler(this.buttonCreateGraph_Click);
            // 
            // textBoxGraphTitle
            // 
            this.textBoxGraphTitle.Location = new System.Drawing.Point(134, 58);
            this.textBoxGraphTitle.Name = "textBoxGraphTitle";
            this.textBoxGraphTitle.Size = new System.Drawing.Size(168, 29);
            this.textBoxGraphTitle.TabIndex = 4;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(18, 61);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(99, 25);
            this.label.TabIndex = 5;
            this.label.Text = "Название";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxChartType);
            this.groupBox2.Controls.Add(this.buttonCreateGraph);
            this.groupBox2.Controls.Add(this.label);
            this.groupBox2.Controls.Add(this.textBoxGraphTitle);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 294);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Создание";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl);
            this.groupBox3.Location = new System.Drawing.Point(347, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1173, 1047);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Графики";
            // 
            // settingsGroupBox
            // 
            this.settingsGroupBox.Controls.Add(this.currentGraphicTextBox);
            this.settingsGroupBox.Controls.Add(this.label2);
            this.settingsGroupBox.Location = new System.Drawing.Point(12, 312);
            this.settingsGroupBox.Name = "settingsGroupBox";
            this.settingsGroupBox.Size = new System.Drawing.Size(329, 132);
            this.settingsGroupBox.TabIndex = 10;
            this.settingsGroupBox.TabStop = false;
            this.settingsGroupBox.Text = "Информация";
            // 
            // currentGraphicTextBox
            // 
            this.currentGraphicTextBox.Location = new System.Drawing.Point(23, 75);
            this.currentGraphicTextBox.Name = "currentGraphicTextBox";
            this.currentGraphicTextBox.ReadOnly = true;
            this.currentGraphicTextBox.Size = new System.Drawing.Size(279, 29);
            this.currentGraphicTextBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Текущий график";
            // 
            // applyChangesBtn
            // 
            this.applyChangesBtn.Enabled = false;
            this.applyChangesBtn.Location = new System.Drawing.Point(35, 983);
            this.applyChangesBtn.Name = "applyChangesBtn";
            this.applyChangesBtn.Size = new System.Drawing.Size(279, 59);
            this.applyChangesBtn.TabIndex = 2;
            this.applyChangesBtn.Text = "Подтвердить изменения";
            this.applyChangesBtn.UseVisualStyleBackColor = true;
            this.applyChangesBtn.Click += new System.EventHandler(this.applyChangesBtn_Click);
            // 
            // checkBoxLegend
            // 
            this.checkBoxLegend.AutoSize = true;
            this.checkBoxLegend.Checked = true;
            this.checkBoxLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxLegend.Location = new System.Drawing.Point(23, 45);
            this.checkBoxLegend.Name = "checkBoxLegend";
            this.checkBoxLegend.Size = new System.Drawing.Size(205, 29);
            this.checkBoxLegend.TabIndex = 3;
            this.checkBoxLegend.Text = "Показать легенду";
            this.checkBoxLegend.UseVisualStyleBackColor = true;
            // 
            // numericLineWidth
            // 
            this.numericLineWidth.Location = new System.Drawing.Point(23, 85);
            this.numericLineWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericLineWidth.Name = "numericLineWidth";
            this.numericLineWidth.Size = new System.Drawing.Size(279, 29);
            this.numericLineWidth.TabIndex = 4;
            this.numericLineWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(157, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Толщина линий";
            // 
            // comboBoxXAxis
            // 
            this.comboBoxXAxis.FormattingEnabled = true;
            this.comboBoxXAxis.Location = new System.Drawing.Point(111, 67);
            this.comboBoxXAxis.Name = "comboBoxXAxis";
            this.comboBoxXAxis.Size = new System.Drawing.Size(191, 32);
            this.comboBoxXAxis.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 31);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Изменение типа осей";
            // 
            // diagramGroupBox
            // 
            this.diagramGroupBox.Controls.Add(this.label5);
            this.diagramGroupBox.Controls.Add(this.panelColorPreview);
            this.diagramGroupBox.Controls.Add(this.checkBoxLegend);
            this.diagramGroupBox.Enabled = false;
            this.diagramGroupBox.Location = new System.Drawing.Point(12, 450);
            this.diagramGroupBox.Name = "diagramGroupBox";
            this.diagramGroupBox.Size = new System.Drawing.Size(329, 156);
            this.diagramGroupBox.TabIndex = 11;
            this.diagramGroupBox.TabStop = false;
            this.diagramGroupBox.Text = "Диаграмма";
            // 
            // dataGroupBox
            // 
            this.dataGroupBox.Controls.Add(this.label3);
            this.dataGroupBox.Controls.Add(this.numericLineWidth);
            this.dataGroupBox.Enabled = false;
            this.dataGroupBox.Location = new System.Drawing.Point(12, 612);
            this.dataGroupBox.Name = "dataGroupBox";
            this.dataGroupBox.Size = new System.Drawing.Size(329, 156);
            this.dataGroupBox.TabIndex = 12;
            this.dataGroupBox.TabStop = false;
            this.dataGroupBox.Text = "Серии данных";
            // 
            // axesGroupBox
            // 
            this.axesGroupBox.Controls.Add(this.label7);
            this.axesGroupBox.Controls.Add(this.label6);
            this.axesGroupBox.Controls.Add(this.comboBoxYAxis);
            this.axesGroupBox.Controls.Add(this.label4);
            this.axesGroupBox.Controls.Add(this.comboBoxXAxis);
            this.axesGroupBox.Enabled = false;
            this.axesGroupBox.Location = new System.Drawing.Point(12, 774);
            this.axesGroupBox.Name = "axesGroupBox";
            this.axesGroupBox.Size = new System.Drawing.Size(329, 182);
            this.axesGroupBox.TabIndex = 13;
            this.axesGroupBox.TabStop = false;
            this.axesGroupBox.Text = "Оси";
            // 
            // comboBoxYAxis
            // 
            this.comboBoxYAxis.FormattingEnabled = true;
            this.comboBoxYAxis.Location = new System.Drawing.Point(111, 125);
            this.comboBoxYAxis.Name = "comboBoxYAxis";
            this.comboBoxYAxis.Size = new System.Drawing.Size(191, 32);
            this.comboBoxYAxis.TabIndex = 8;
            // 
            // panelColorPreview
            // 
            this.panelColorPreview.Location = new System.Drawing.Point(263, 94);
            this.panelColorPreview.Name = "panelColorPreview";
            this.panelColorPreview.Size = new System.Drawing.Size(39, 34);
            this.panelColorPreview.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Изменить фон графика";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Ось X";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 128);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Ось Y";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1532, 1074);
            this.Controls.Add(this.applyChangesBtn);
            this.Controls.Add(this.axesGroupBox);
            this.Controls.Add(this.dataGroupBox);
            this.Controls.Add(this.diagramGroupBox);
            this.Controls.Add(this.settingsGroupBox);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.settingsGroupBox.ResumeLayout(false);
            this.settingsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericLineWidth)).EndInit();
            this.diagramGroupBox.ResumeLayout(false);
            this.diagramGroupBox.PerformLayout();
            this.dataGroupBox.ResumeLayout(false);
            this.dataGroupBox.PerformLayout();
            this.axesGroupBox.ResumeLayout(false);
            this.axesGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxChartType;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCreateGraph;
        private System.Windows.Forms.TextBox textBoxGraphTitle;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox settingsGroupBox;
        private System.Windows.Forms.TextBox currentGraphicTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button applyChangesBtn;
        private System.Windows.Forms.CheckBox checkBoxLegend;
        private System.Windows.Forms.NumericUpDown numericLineWidth;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxXAxis;
        private System.Windows.Forms.GroupBox diagramGroupBox;
        private System.Windows.Forms.GroupBox dataGroupBox;
        private System.Windows.Forms.GroupBox axesGroupBox;
        private System.Windows.Forms.ComboBox comboBoxYAxis;
        private System.Windows.Forms.Panel panelColorPreview;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}

