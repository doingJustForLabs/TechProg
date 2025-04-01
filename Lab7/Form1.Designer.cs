namespace Lab7
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
            this.funcComboBox = new System.Windows.Forms.ComboBox();
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.methodComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonOK = new System.Windows.Forms.Button();
            this.inputB = new System.Windows.Forms.NumericUpDown();
            this.inputA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.inputN = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.inputGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).BeginInit();
            this.SuspendLayout();
            // 
            // funcComboBox
            // 
            this.funcComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.funcComboBox.FormattingEnabled = true;
            this.funcComboBox.Items.AddRange(new object[] {
            "exp(x)",
            "log(x)",
            "log10(x)"});
            this.funcComboBox.Location = new System.Drawing.Point(11, 62);
            this.funcComboBox.Name = "funcComboBox";
            this.funcComboBox.Size = new System.Drawing.Size(192, 32);
            this.funcComboBox.Sorted = true;
            this.funcComboBox.TabIndex = 0;
            this.funcComboBox.SelectedIndexChanged += new System.EventHandler(this.funcComboBox_SelectedIndexChanged_1);
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.label2);
            this.inputGroupBox.Controls.Add(this.label1);
            this.inputGroupBox.Controls.Add(this.methodComboBox);
            this.inputGroupBox.Controls.Add(this.funcComboBox);
            this.inputGroupBox.Location = new System.Drawing.Point(12, 12);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(356, 247);
            this.inputGroupBox.TabIndex = 2;
            this.inputGroupBox.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Выберите метод интегрирования";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Выберите функцию";
            // 
            // methodComboBox
            // 
            this.methodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.methodComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.methodComboBox.Items.AddRange(new object[] {
            "Метод правых прямоугольников",
            "Метод левых прямоугольников"});
            this.methodComboBox.Location = new System.Drawing.Point(11, 146);
            this.methodComboBox.Name = "methodComboBox";
            this.methodComboBox.Size = new System.Drawing.Size(323, 32);
            this.methodComboBox.TabIndex = 0;
            this.methodComboBox.SelectedIndexChanged += new System.EventHandler(this.methodComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 265);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 290);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(11, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(515, 246);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "x";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "F(x)";
            this.columnHeader2.Width = 110;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "F(x + Δx)";
            this.columnHeader3.Width = 100;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputN);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.buttonOK);
            this.groupBox2.Controls.Add(this.inputB);
            this.groupBox2.Controls.Add(this.inputA);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(374, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 247);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(20, 176);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(144, 48);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "OK";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // inputB
            // 
            this.inputB.DecimalPlaces = 1;
            this.inputB.Location = new System.Drawing.Point(35, 66);
            this.inputB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(120, 29);
            this.inputB.TabIndex = 2;
            // 
            // inputA
            // 
            this.inputA.DecimalPlaces = 1;
            this.inputA.Location = new System.Drawing.Point(35, 24);
            this.inputA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(120, 29);
            this.inputA.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "a";
            // 
            // inputN
            // 
            this.inputN.Location = new System.Drawing.Point(35, 108);
            this.inputN.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputN.Name = "inputN";
            this.inputN.Size = new System.Drawing.Size(120, 29);
            this.inputN.TabIndex = 5;
            this.inputN.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1490, 571);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputGroupBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputN)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox funcComboBox;
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox methodComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inputB;
        private System.Windows.Forms.NumericUpDown inputA;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.NumericUpDown inputN;
        private System.Windows.Forms.Label label5;
    }
}

