namespace Lab3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button_calc = new System.Windows.Forms.Button();
            this.x0Value = new System.Windows.Forms.NumericUpDown();
            this.xkValue = new System.Windows.Forms.NumericUpDown();
            this.stepValue = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.autoStepButton = new System.Windows.Forms.Button();
            this.randStartButton = new System.Windows.Forms.Button();
            this.randEndButton = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.listViewOutput = new System.Windows.Forms.ListView();
            this.columnHeaderX = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderF1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonClearOutput = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0Value)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xkValue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepValue)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1024, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Start";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "End";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Step";
            // 
            // button_calc
            // 
            this.button_calc.Location = new System.Drawing.Point(135, 28);
            this.button_calc.Name = "button_calc";
            this.button_calc.Size = new System.Drawing.Size(174, 50);
            this.button_calc.TabIndex = 7;
            this.button_calc.Text = "Calculate";
            this.button_calc.UseVisualStyleBackColor = true;
            this.button_calc.Click += new System.EventHandler(this.button_calc_Click);
            // 
            // x0Value
            // 
            this.x0Value.DecimalPlaces = 2;
            this.x0Value.Location = new System.Drawing.Point(89, 36);
            this.x0Value.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.x0Value.Name = "x0Value";
            this.x0Value.Size = new System.Drawing.Size(120, 29);
            this.x0Value.TabIndex = 10;
            // 
            // xkValue
            // 
            this.xkValue.DecimalPlaces = 2;
            this.xkValue.Location = new System.Drawing.Point(89, 86);
            this.xkValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.xkValue.Name = "xkValue";
            this.xkValue.Size = new System.Drawing.Size(120, 29);
            this.xkValue.TabIndex = 11;
            this.xkValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // stepValue
            // 
            this.stepValue.DecimalPlaces = 3;
            this.stepValue.Increment = new decimal(new int[] {
            25,
            0,
            0,
            131072});
            this.stepValue.Location = new System.Drawing.Point(89, 136);
            this.stepValue.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.stepValue.Name = "stepValue";
            this.stepValue.Size = new System.Drawing.Size(120, 29);
            this.stepValue.TabIndex = 12;
            this.stepValue.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(12, 119);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(438, 349);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button_calc);
            this.groupBox5.Location = new System.Drawing.Point(6, 238);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(422, 101);
            this.groupBox5.TabIndex = 16;
            this.groupBox5.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.autoStepButton);
            this.groupBox4.Controls.Add(this.randStartButton);
            this.groupBox4.Controls.Add(this.randEndButton);
            this.groupBox4.Location = new System.Drawing.Point(240, 39);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(188, 193);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Helper";
            // 
            // autoStepButton
            // 
            this.autoStepButton.Location = new System.Drawing.Point(12, 129);
            this.autoStepButton.Name = "autoStepButton";
            this.autoStepButton.Size = new System.Drawing.Size(151, 42);
            this.autoStepButton.TabIndex = 15;
            this.autoStepButton.Text = "AutoStep";
            this.autoStepButton.UseVisualStyleBackColor = true;
            this.autoStepButton.Click += new System.EventHandler(this.autoStepButton_Click);
            // 
            // randStartButton
            // 
            this.randStartButton.Location = new System.Drawing.Point(12, 31);
            this.randStartButton.Name = "randStartButton";
            this.randStartButton.Size = new System.Drawing.Size(151, 42);
            this.randStartButton.TabIndex = 15;
            this.randStartButton.Text = "RandomStart";
            this.randStartButton.UseVisualStyleBackColor = true;
            this.randStartButton.Click += new System.EventHandler(this.randStartButton_Click);
            // 
            // randEndButton
            // 
            this.randEndButton.Location = new System.Drawing.Point(12, 81);
            this.randEndButton.Name = "randEndButton";
            this.randEndButton.Size = new System.Drawing.Size(151, 42);
            this.randEndButton.TabIndex = 15;
            this.randEndButton.Text = "RandomEnd";
            this.randEndButton.UseVisualStyleBackColor = true;
            this.randEndButton.Click += new System.EventHandler(this.randEndButton_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.x0Value);
            this.groupBox3.Controls.Add(this.stepValue);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.xkValue);
            this.groupBox3.Location = new System.Drawing.Point(6, 39);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(228, 193);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Values";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.saveButton);
            this.groupBox2.Controls.Add(this.listViewOutput);
            this.groupBox2.Controls.Add(this.buttonClearOutput);
            this.groupBox2.Location = new System.Drawing.Point(456, 119);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(592, 562);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(20, 489);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(148, 50);
            this.saveButton.TabIndex = 16;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // listViewOutput
            // 
            this.listViewOutput.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderX,
            this.columnHeaderF1});
            this.listViewOutput.HideSelection = false;
            this.listViewOutput.Location = new System.Drawing.Point(20, 39);
            this.listViewOutput.Name = "listViewOutput";
            this.listViewOutput.Size = new System.Drawing.Size(550, 430);
            this.listViewOutput.TabIndex = 15;
            this.listViewOutput.UseCompatibleStateImageBehavior = false;
            this.listViewOutput.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderX
            // 
            this.columnHeaderX.Text = "x";
            this.columnHeaderX.Width = 164;
            // 
            // columnHeaderF1
            // 
            this.columnHeaderF1.Text = "F(x)";
            this.columnHeaderF1.Width = 225;
            // 
            // buttonClearOutput
            // 
            this.buttonClearOutput.Location = new System.Drawing.Point(436, 489);
            this.buttonClearOutput.Name = "buttonClearOutput";
            this.buttonClearOutput.Size = new System.Drawing.Size(134, 50);
            this.buttonClearOutput.TabIndex = 1;
            this.buttonClearOutput.Text = "Clear";
            this.buttonClearOutput.UseVisualStyleBackColor = true;
            this.buttonClearOutput.Click += new System.EventHandler(this.buttonClearOutput_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox6.Controls.Add(this.pictureBox1);
            this.groupBox6.Location = new System.Drawing.Point(12, 12);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(1036, 101);
            this.groupBox6.TabIndex = 15;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Info";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox7.Location = new System.Drawing.Point(13, 475);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(437, 204);
            this.groupBox7.TabIndex = 16;
            this.groupBox7.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 691);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.x0Value)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xkValue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepValue)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_calc;
        private System.Windows.Forms.NumericUpDown x0Value;
        private System.Windows.Forms.NumericUpDown xkValue;
        private System.Windows.Forms.NumericUpDown stepValue;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonClearOutput;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView listViewOutput;
        private System.Windows.Forms.ColumnHeader columnHeaderX;
        private System.Windows.Forms.ColumnHeader columnHeaderF1;
        private System.Windows.Forms.Button randStartButton;
        private System.Windows.Forms.Button randEndButton;
        private System.Windows.Forms.Button autoStepButton;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

