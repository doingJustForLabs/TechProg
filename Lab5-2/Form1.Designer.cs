namespace Lab5_2
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.yStep = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.xk = new System.Windows.Forms.NumericUpDown();
            this.x0 = new System.Windows.Forms.NumericUpDown();
            this.yk = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.y0 = new System.Windows.Forms.NumericUpDown();
            this.xStep = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.solveButton = new System.Windows.Forms.Button();
            this.addPageButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.y0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xStep)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(13, 13);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(453, 195);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.yStep);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.xk);
            this.tabPage1.Controls.Add(this.x0);
            this.tabPage1.Controls.Add(this.yk);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.y0);
            this.tabPage1.Controls.Add(this.xStep);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(445, 158);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "x0";
            // 
            // yStep
            // 
            this.yStep.DecimalPlaces = 2;
            this.yStep.Location = new System.Drawing.Point(313, 108);
            this.yStep.Name = "yStep";
            this.yStep.Size = new System.Drawing.Size(120, 29);
            this.yStep.TabIndex = 12;
            this.yStep.Tag = "yStep";
            this.yStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "yk";
            // 
            // xk
            // 
            this.xk.DecimalPlaces = 2;
            this.xk.Location = new System.Drawing.Point(92, 62);
            this.xk.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xk.Name = "xk";
            this.xk.Size = new System.Drawing.Size(120, 29);
            this.xk.TabIndex = 5;
            this.xk.Tag = "xk";
            // 
            // x0
            // 
            this.x0.DecimalPlaces = 2;
            this.x0.Location = new System.Drawing.Point(92, 20);
            this.x0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x0.Name = "x0";
            this.x0.Size = new System.Drawing.Size(120, 29);
            this.x0.TabIndex = 15;
            this.x0.Tag = "x0";
            // 
            // yk
            // 
            this.yk.DecimalPlaces = 2;
            this.yk.Location = new System.Drawing.Point(313, 62);
            this.yk.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.yk.Name = "yk";
            this.yk.Size = new System.Drawing.Size(120, 29);
            this.yk.TabIndex = 13;
            this.yk.Tag = "yk";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "xk";
            // 
            // y0
            // 
            this.y0.DecimalPlaces = 2;
            this.y0.Location = new System.Drawing.Point(313, 20);
            this.y0.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.y0.Name = "y0";
            this.y0.Size = new System.Drawing.Size(120, 29);
            this.y0.TabIndex = 14;
            this.y0.Tag = "y0";
            // 
            // xStep
            // 
            this.xStep.DecimalPlaces = 2;
            this.xStep.Location = new System.Drawing.Point(92, 106);
            this.xStep.Name = "xStep";
            this.xStep.Size = new System.Drawing.Size(120, 29);
            this.xStep.TabIndex = 6;
            this.xStep.Tag = "xStep";
            this.xStep.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Шаг X";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(239, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Шаг Y";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(238, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 25);
            this.label6.TabIndex = 7;
            this.label6.Text = "y0";
            // 
            // solveButton
            // 
            this.solveButton.Location = new System.Drawing.Point(129, 326);
            this.solveButton.Name = "solveButton";
            this.solveButton.Size = new System.Drawing.Size(228, 54);
            this.solveButton.TabIndex = 16;
            this.solveButton.Text = "Рассчитать";
            this.solveButton.UseVisualStyleBackColor = true;
            this.solveButton.Click += new System.EventHandler(this.solveButton_Click);
            // 
            // addPageButton
            // 
            this.addPageButton.Location = new System.Drawing.Point(17, 224);
            this.addPageButton.Name = "addPageButton";
            this.addPageButton.Size = new System.Drawing.Size(189, 48);
            this.addPageButton.TabIndex = 16;
            this.addPageButton.Text = "Добавить набор";
            this.addPageButton.UseVisualStyleBackColor = true;
            this.addPageButton.Click += new System.EventHandler(this.addPageButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(472, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 72;
            this.dataGridView1.RowTemplate.Height = 31;
            this.dataGridView1.Size = new System.Drawing.Size(652, 580);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 610);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.solveButton);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.addPageButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.yStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.y0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xStep)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown yStep;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown xStep;
        private System.Windows.Forms.NumericUpDown xk;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button solveButton;
        private System.Windows.Forms.NumericUpDown x0;
        private System.Windows.Forms.NumericUpDown y0;
        private System.Windows.Forms.NumericUpDown yk;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button addPageButton;
    }
}

