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
            this.inputGroupBox = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.inputDeltaX = new System.Windows.Forms.NumericUpDown();
            this.Δx = new System.Windows.Forms.Label();
            this.buttonOK = new System.Windows.Forms.Button();
            this.inputB = new System.Windows.Forms.NumericUpDown();
            this.inputA = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.funcListBox = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.methodListBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.graphsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.inputGroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDeltaX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // inputGroupBox
            // 
            this.inputGroupBox.Controls.Add(this.groupBox2);
            this.inputGroupBox.Controls.Add(this.methodListBox);
            this.inputGroupBox.Controls.Add(this.label5);
            this.inputGroupBox.Controls.Add(this.buttonOK);
            this.inputGroupBox.Controls.Add(this.label6);
            this.inputGroupBox.Controls.Add(this.funcListBox);
            this.inputGroupBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.inputGroupBox.Location = new System.Drawing.Point(0, 0);
            this.inputGroupBox.Name = "inputGroupBox";
            this.inputGroupBox.Size = new System.Drawing.Size(1185, 206);
            this.inputGroupBox.TabIndex = 2;
            this.inputGroupBox.TabStop = false;
            this.inputGroupBox.Text = "Input";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(0, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 580);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(3, 25);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersWidth = 72;
            this.dataGridView.RowTemplate.Height = 31;
            this.dataGridView.Size = new System.Drawing.Size(779, 552);
            this.dataGridView.TabIndex = 6;
            // 
            // inputDeltaX
            // 
            this.inputDeltaX.DecimalPlaces = 3;
            this.inputDeltaX.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.inputDeltaX.Location = new System.Drawing.Point(73, 129);
            this.inputDeltaX.Name = "inputDeltaX";
            this.inputDeltaX.Size = new System.Drawing.Size(107, 29);
            this.inputDeltaX.TabIndex = 7;
            this.inputDeltaX.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inputDeltaX.ValueChanged += new System.EventHandler(this.inputDeltaX_ValueChanged);
            // 
            // Δx
            // 
            this.Δx.AutoSize = true;
            this.Δx.Location = new System.Drawing.Point(31, 131);
            this.Δx.Name = "Δx";
            this.Δx.Size = new System.Drawing.Size(36, 25);
            this.Δx.TabIndex = 6;
            this.Δx.Text = "Δx";
            // 
            // buttonOK
            // 
            this.buttonOK.Enabled = false;
            this.buttonOK.Location = new System.Drawing.Point(892, 86);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(144, 48);
            this.buttonOK.TabIndex = 3;
            this.buttonOK.Text = "Run";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // inputB
            // 
            this.inputB.DecimalPlaces = 1;
            this.inputB.Location = new System.Drawing.Point(60, 84);
            this.inputB.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputB.Name = "inputB";
            this.inputB.Size = new System.Drawing.Size(120, 29);
            this.inputB.TabIndex = 2;
            this.inputB.ValueChanged += new System.EventHandler(this.inputB_ValueChanged);
            // 
            // inputA
            // 
            this.inputA.DecimalPlaces = 1;
            this.inputA.Location = new System.Drawing.Point(60, 42);
            this.inputA.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.inputA.Name = "inputA";
            this.inputA.Size = new System.Drawing.Size(120, 29);
            this.inputA.TabIndex = 2;
            this.inputA.ValueChanged += new System.EventHandler(this.inputA_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "b";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "a";
            // 
            // funcListBox
            // 
            this.funcListBox.FormattingEnabled = true;
            this.funcListBox.ItemHeight = 24;
            this.funcListBox.Items.AddRange(new object[] {
            "exp(x)",
            "ln(x)",
            "lg(x)"});
            this.funcListBox.Location = new System.Drawing.Point(24, 78);
            this.funcListBox.Name = "funcListBox";
            this.funcListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.funcListBox.Size = new System.Drawing.Size(192, 100);
            this.funcListBox.TabIndex = 6;
            this.funcListBox.SelectedIndexChanged += new System.EventHandler(this.funcListBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(197, 25);
            this.label5.TabIndex = 3;
            this.label5.Text = "Выберите функцию";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(328, 25);
            this.label6.TabIndex = 3;
            this.label6.Text = "Выберите метод интегрирования";
            // 
            // methodListBox
            // 
            this.methodListBox.FormattingEnabled = true;
            this.methodListBox.ItemHeight = 24;
            this.methodListBox.Items.AddRange(new object[] {
            "Метод левых прямоугольников",
            "Метод правых прямоугольников"});
            this.methodListBox.Location = new System.Drawing.Point(242, 78);
            this.methodListBox.Name = "methodListBox";
            this.methodListBox.Size = new System.Drawing.Size(323, 100);
            this.methodListBox.TabIndex = 7;
            this.methodListBox.SelectedIndexChanged += new System.EventHandler(this.methodListBox_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.inputDeltaX);
            this.groupBox2.Controls.Add(this.inputA);
            this.groupBox2.Controls.Add(this.inputB);
            this.groupBox2.Controls.Add(this.Δx);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(581, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(204, 206);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Params";
            // 
            // graphsPanel
            // 
            this.graphsPanel.AutoScroll = true;
            this.graphsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.graphsPanel.Location = new System.Drawing.Point(3, 25);
            this.graphsPanel.Name = "graphsPanel";
            this.graphsPanel.Size = new System.Drawing.Size(391, 552);
            this.graphsPanel.TabIndex = 5;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.graphsPanel);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox3.Location = new System.Drawing.Point(788, 206);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(397, 580);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Graphs";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1185, 786);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.inputGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Form1";
            this.inputGroupBox.ResumeLayout(false);
            this.inputGroupBox.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputDeltaX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inputA)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox inputGroupBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown inputB;
        private System.Windows.Forms.NumericUpDown inputA;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label Δx;
        private System.Windows.Forms.NumericUpDown inputDeltaX;
        private System.Windows.Forms.ListBox funcListBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ListBox methodListBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel graphsPanel;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

