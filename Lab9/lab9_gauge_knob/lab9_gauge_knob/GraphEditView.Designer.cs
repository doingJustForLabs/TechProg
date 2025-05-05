namespace lab9_gauge_knob
{
    partial class GraphEditView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControlTools = new System.Windows.Forms.TabControl();
            this.tabPageLabels = new System.Windows.Forms.TabPage();
            this.checkBoxLegend = new System.Windows.Forms.CheckBox();
            this.dataGridViewLegend = new System.Windows.Forms.DataGridView();
            this.SeriesIndex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriesLabel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageAxis = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.numericMinorTicsLength = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.numericMajorTicsLength = new System.Windows.Forms.NumericUpDown();
            this.buttonGridColorSelect = new System.Windows.Forms.Button();
            this.checkBoxYShow = new System.Windows.Forms.CheckBox();
            this.checkBoxGridShow = new System.Windows.Forms.CheckBox();
            this.checkBoxXShow = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonYColorSelect = new System.Windows.Forms.Button();
            this.numeriсYThickness = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonXColorSelect = new System.Windows.Forms.Button();
            this.numeriсXThickness = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPageSeries = new System.Windows.Forms.TabPage();
            this.dataGridViewSeriesStyles = new System.Windows.Forms.DataGridView();
            this.SeriaNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SeriaShow = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.SeriaColor = new System.Windows.Forms.DataGridViewButtonColumn();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.buttonRecover = new System.Windows.Forms.Button();
            this.tabControlTools.SuspendLayout();
            this.tabPageLabels.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLegend)).BeginInit();
            this.tabPageAxis.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinorTicsLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMajorTicsLength)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсYThickness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсXThickness)).BeginInit();
            this.tabPageSeries.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeriesStyles)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlTools
            // 
            this.tabControlTools.Controls.Add(this.tabPageLabels);
            this.tabControlTools.Controls.Add(this.tabPageAxis);
            this.tabControlTools.Controls.Add(this.tabPageSeries);
            this.tabControlTools.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabControlTools.Location = new System.Drawing.Point(0, 0);
            this.tabControlTools.Name = "tabControlTools";
            this.tabControlTools.SelectedIndex = 0;
            this.tabControlTools.Size = new System.Drawing.Size(373, 290);
            this.tabControlTools.TabIndex = 0;
            // 
            // tabPageLabels
            // 
            this.tabPageLabels.Controls.Add(this.checkBoxLegend);
            this.tabPageLabels.Controls.Add(this.dataGridViewLegend);
            this.tabPageLabels.Controls.Add(this.label4);
            this.tabPageLabels.Controls.Add(this.label3);
            this.tabPageLabels.Controls.Add(this.textBoxY);
            this.tabPageLabels.Controls.Add(this.label2);
            this.tabPageLabels.Controls.Add(this.textBoxX);
            this.tabPageLabels.Controls.Add(this.textBoxTitle);
            this.tabPageLabels.Controls.Add(this.label1);
            this.tabPageLabels.Location = new System.Drawing.Point(4, 29);
            this.tabPageLabels.Name = "tabPageLabels";
            this.tabPageLabels.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLabels.Size = new System.Drawing.Size(365, 257);
            this.tabPageLabels.TabIndex = 0;
            this.tabPageLabels.Text = "Надписи";
            this.tabPageLabels.UseVisualStyleBackColor = true;
            // 
            // checkBoxLegend
            // 
            this.checkBoxLegend.AutoSize = true;
            this.checkBoxLegend.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxLegend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxLegend.Location = new System.Drawing.Point(12, 119);
            this.checkBoxLegend.Name = "checkBoxLegend";
            this.checkBoxLegend.Size = new System.Drawing.Size(14, 13);
            this.checkBoxLegend.TabIndex = 8;
            this.checkBoxLegend.UseVisualStyleBackColor = true;
            // 
            // dataGridViewLegend
            // 
            this.dataGridViewLegend.AllowUserToAddRows = false;
            this.dataGridViewLegend.AllowUserToDeleteRows = false;
            this.dataGridViewLegend.AllowUserToResizeRows = false;
            this.dataGridViewLegend.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLegend.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeriesIndex,
            this.SeriesLabel});
            this.dataGridViewLegend.Location = new System.Drawing.Point(117, 115);
            this.dataGridViewLegend.Name = "dataGridViewLegend";
            this.dataGridViewLegend.RowHeadersVisible = false;
            this.dataGridViewLegend.RowHeadersWidth = 51;
            this.dataGridViewLegend.RowTemplate.Height = 24;
            this.dataGridViewLegend.Size = new System.Drawing.Size(240, 134);
            this.dataGridViewLegend.TabIndex = 7;
            // 
            // SeriesIndex
            // 
            this.SeriesIndex.HeaderText = "Серия";
            this.SeriesIndex.MinimumWidth = 6;
            this.SeriesIndex.Name = "SeriesIndex";
            this.SeriesIndex.ReadOnly = true;
            this.SeriesIndex.Width = 125;
            // 
            // SeriesLabel
            // 
            this.SeriesLabel.HeaderText = "Надпись";
            this.SeriesLabel.MinimumWidth = 6;
            this.SeriesLabel.Name = "SeriesLabel";
            this.SeriesLabel.Width = 125;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Легенда:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ось Y:";
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(117, 77);
            this.textBoxY.MaxLength = 50;
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(100, 27);
            this.textBoxY.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ось X:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(117, 42);
            this.textBoxX.MaxLength = 50;
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(100, 27);
            this.textBoxX.TabIndex = 2;
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(117, 6);
            this.textBoxTitle.MaxLength = 50;
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(240, 27);
            this.textBoxTitle.TabIndex = 1;
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Заголовок:";
            // 
            // tabPageAxis
            // 
            this.tabPageAxis.Controls.Add(this.groupBox1);
            this.tabPageAxis.Controls.Add(this.buttonGridColorSelect);
            this.tabPageAxis.Controls.Add(this.checkBoxYShow);
            this.tabPageAxis.Controls.Add(this.checkBoxGridShow);
            this.tabPageAxis.Controls.Add(this.checkBoxXShow);
            this.tabPageAxis.Controls.Add(this.label7);
            this.tabPageAxis.Controls.Add(this.buttonYColorSelect);
            this.tabPageAxis.Controls.Add(this.numeriсYThickness);
            this.tabPageAxis.Controls.Add(this.label6);
            this.tabPageAxis.Controls.Add(this.buttonXColorSelect);
            this.tabPageAxis.Controls.Add(this.numeriсXThickness);
            this.tabPageAxis.Controls.Add(this.label5);
            this.tabPageAxis.Location = new System.Drawing.Point(4, 29);
            this.tabPageAxis.Name = "tabPageAxis";
            this.tabPageAxis.Size = new System.Drawing.Size(365, 257);
            this.tabPageAxis.TabIndex = 2;
            this.tabPageAxis.Text = "Оси";
            this.tabPageAxis.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.numericMinorTicsLength);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.numericMajorTicsLength);
            this.groupBox1.Location = new System.Drawing.Point(8, 143);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 100);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Засечки";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Осн. засечки:";
            // 
            // numericMinorTicsLength
            // 
            this.numericMinorTicsLength.DecimalPlaces = 2;
            this.numericMinorTicsLength.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericMinorTicsLength.Location = new System.Drawing.Point(144, 61);
            this.numericMinorTicsLength.Name = "numericMinorTicsLength";
            this.numericMinorTicsLength.Size = new System.Drawing.Size(71, 27);
            this.numericMinorTicsLength.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 63);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Доп. засечки:";
            // 
            // numericMajorTicsLength
            // 
            this.numericMajorTicsLength.DecimalPlaces = 2;
            this.numericMajorTicsLength.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numericMajorTicsLength.Location = new System.Drawing.Point(144, 30);
            this.numericMajorTicsLength.Name = "numericMajorTicsLength";
            this.numericMajorTicsLength.Size = new System.Drawing.Size(71, 27);
            this.numericMajorTicsLength.TabIndex = 15;
            // 
            // buttonGridColorSelect
            // 
            this.buttonGridColorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGridColorSelect.Location = new System.Drawing.Point(116, 79);
            this.buttonGridColorSelect.Name = "buttonGridColorSelect";
            this.buttonGridColorSelect.Size = new System.Drawing.Size(27, 27);
            this.buttonGridColorSelect.TabIndex = 10;
            this.buttonGridColorSelect.UseVisualStyleBackColor = true;
            this.buttonGridColorSelect.Click += new System.EventHandler(this.buttonGridColorSelect_Click);
            // 
            // checkBoxYShow
            // 
            this.checkBoxYShow.AutoSize = true;
            this.checkBoxYShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxYShow.Location = new System.Drawing.Point(28, 49);
            this.checkBoxYShow.Name = "checkBoxYShow";
            this.checkBoxYShow.Size = new System.Drawing.Size(14, 13);
            this.checkBoxYShow.TabIndex = 9;
            this.checkBoxYShow.UseVisualStyleBackColor = true;
            // 
            // checkBoxGridShow
            // 
            this.checkBoxGridShow.AutoSize = true;
            this.checkBoxGridShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxGridShow.Location = new System.Drawing.Point(28, 86);
            this.checkBoxGridShow.Name = "checkBoxGridShow";
            this.checkBoxGridShow.Size = new System.Drawing.Size(14, 13);
            this.checkBoxGridShow.TabIndex = 8;
            this.checkBoxGridShow.UseVisualStyleBackColor = true;
            // 
            // checkBoxXShow
            // 
            this.checkBoxXShow.AutoSize = true;
            this.checkBoxXShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxXShow.Location = new System.Drawing.Point(28, 13);
            this.checkBoxXShow.Name = "checkBoxXShow";
            this.checkBoxXShow.Size = new System.Drawing.Size(14, 13);
            this.checkBoxXShow.TabIndex = 7;
            this.checkBoxXShow.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Сетка:";
            // 
            // buttonYColorSelect
            // 
            this.buttonYColorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonYColorSelect.Location = new System.Drawing.Point(193, 43);
            this.buttonYColorSelect.Name = "buttonYColorSelect";
            this.buttonYColorSelect.Size = new System.Drawing.Size(27, 27);
            this.buttonYColorSelect.TabIndex = 5;
            this.buttonYColorSelect.UseVisualStyleBackColor = true;
            this.buttonYColorSelect.Click += new System.EventHandler(this.buttonYColorSelect_Click);
            // 
            // numeriсYThickness
            // 
            this.numeriсYThickness.DecimalPlaces = 2;
            this.numeriсYThickness.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeriсYThickness.Location = new System.Drawing.Point(116, 43);
            this.numeriсYThickness.Name = "numeriсYThickness";
            this.numeriсYThickness.Size = new System.Drawing.Size(71, 27);
            this.numeriсYThickness.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ось Y:";
            // 
            // buttonXColorSelect
            // 
            this.buttonXColorSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonXColorSelect.Location = new System.Drawing.Point(193, 7);
            this.buttonXColorSelect.Name = "buttonXColorSelect";
            this.buttonXColorSelect.Size = new System.Drawing.Size(27, 27);
            this.buttonXColorSelect.TabIndex = 2;
            this.buttonXColorSelect.UseVisualStyleBackColor = true;
            this.buttonXColorSelect.Click += new System.EventHandler(this.buttonXColorSelect_Click);
            // 
            // numeriсXThickness
            // 
            this.numeriсXThickness.DecimalPlaces = 2;
            this.numeriсXThickness.Increment = new decimal(new int[] {
            5,
            0,
            0,
            65536});
            this.numeriсXThickness.Location = new System.Drawing.Point(116, 7);
            this.numeriсXThickness.Name = "numeriсXThickness";
            this.numeriсXThickness.Size = new System.Drawing.Size(71, 27);
            this.numeriсXThickness.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 20);
            this.label5.TabIndex = 0;
            this.label5.Text = "Ось X:";
            // 
            // tabPageSeries
            // 
            this.tabPageSeries.Controls.Add(this.dataGridViewSeriesStyles);
            this.tabPageSeries.Location = new System.Drawing.Point(4, 29);
            this.tabPageSeries.Name = "tabPageSeries";
            this.tabPageSeries.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSeries.Size = new System.Drawing.Size(365, 257);
            this.tabPageSeries.TabIndex = 1;
            this.tabPageSeries.Text = "Серии данных";
            this.tabPageSeries.UseVisualStyleBackColor = true;
            // 
            // dataGridViewSeriesStyles
            // 
            this.dataGridViewSeriesStyles.AllowUserToAddRows = false;
            this.dataGridViewSeriesStyles.AllowUserToDeleteRows = false;
            this.dataGridViewSeriesStyles.AllowUserToResizeRows = false;
            this.dataGridViewSeriesStyles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSeriesStyles.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SeriaNumber,
            this.SeriaShow,
            this.SeriaColor});
            this.dataGridViewSeriesStyles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewSeriesStyles.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewSeriesStyles.Name = "dataGridViewSeriesStyles";
            this.dataGridViewSeriesStyles.RowHeadersVisible = false;
            this.dataGridViewSeriesStyles.RowHeadersWidth = 51;
            this.dataGridViewSeriesStyles.RowTemplate.Height = 24;
            this.dataGridViewSeriesStyles.Size = new System.Drawing.Size(359, 251);
            this.dataGridViewSeriesStyles.TabIndex = 0;
            this.dataGridViewSeriesStyles.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewSeriesStyles_CellClick);
            // 
            // SeriaNumber
            // 
            this.SeriaNumber.HeaderText = "Серия";
            this.SeriaNumber.MinimumWidth = 6;
            this.SeriaNumber.Name = "SeriaNumber";
            this.SeriaNumber.ReadOnly = true;
            this.SeriaNumber.Width = 125;
            // 
            // SeriaShow
            // 
            this.SeriaShow.HeaderText = "Отображение";
            this.SeriaShow.MinimumWidth = 6;
            this.SeriaShow.Name = "SeriaShow";
            this.SeriaShow.Width = 125;
            // 
            // SeriaColor
            // 
            this.SeriaColor.HeaderText = "Цвет";
            this.SeriaColor.MinimumWidth = 6;
            this.SeriaColor.Name = "SeriaColor";
            this.SeriaColor.Width = 125;
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(379, 257);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(100, 29);
            this.buttonCancel.TabIndex = 1;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(379, 29);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(100, 29);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // buttonRecover
            // 
            this.buttonRecover.Location = new System.Drawing.Point(379, 64);
            this.buttonRecover.Name = "buttonRecover";
            this.buttonRecover.Size = new System.Drawing.Size(100, 29);
            this.buttonRecover.TabIndex = 3;
            this.buttonRecover.Text = "Вернуть";
            this.buttonRecover.UseVisualStyleBackColor = true;
            this.buttonRecover.Click += new System.EventHandler(this.buttonRecover_Click);
            // 
            // GraphEditView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 290);
            this.Controls.Add(this.buttonRecover);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.tabControlTools);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GraphEditView";
            this.Text = "Форматирование";
            this.tabControlTools.ResumeLayout(false);
            this.tabPageLabels.ResumeLayout(false);
            this.tabPageLabels.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLegend)).EndInit();
            this.tabPageAxis.ResumeLayout(false);
            this.tabPageAxis.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericMinorTicsLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericMajorTicsLength)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсYThickness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numeriсXThickness)).EndInit();
            this.tabPageSeries.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSeriesStyles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlTools;
        private System.Windows.Forms.TabPage tabPageLabels;
        private System.Windows.Forms.TabPage tabPageSeries;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageAxis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.CheckBox checkBoxLegend;
        private System.Windows.Forms.DataGridView dataGridViewLegend;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.Button buttonRecover;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriesIndex;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriesLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxXShow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonYColorSelect;
        private System.Windows.Forms.NumericUpDown numeriсYThickness;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonXColorSelect;
        private System.Windows.Forms.NumericUpDown numeriсXThickness;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonGridColorSelect;
        private System.Windows.Forms.CheckBox checkBoxYShow;
        private System.Windows.Forms.CheckBox checkBoxGridShow;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numericMajorTicsLength;
        private System.Windows.Forms.NumericUpDown numericMinorTicsLength;
        private System.Windows.Forms.DataGridView dataGridViewSeriesStyles;
        private System.Windows.Forms.DataGridViewTextBoxColumn SeriaNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SeriaShow;
        private System.Windows.Forms.DataGridViewButtonColumn SeriaColor;
    }
}