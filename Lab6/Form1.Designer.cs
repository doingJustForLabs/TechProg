namespace Lab6
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
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addTabBtn = new System.Windows.Forms.Button();
            this.runBtn = new System.Windows.Forms.Button();
            this.deleteTabBtn = new System.Windows.Forms.Button();
            this.logRichTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Location = new System.Drawing.Point(6, 28);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(403, 257);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.richTextBox2);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(395, 220);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(48, 101);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(319, 69);
            this.richTextBox2.TabIndex = 3;
            this.richTextBox2.Tag = "y";
            this.richTextBox2.Text = "";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(48, 16);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(319, 69);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Tag = "x";
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(22, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "x";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "y";
            // 
            // addTabBtn
            // 
            this.addTabBtn.Location = new System.Drawing.Point(37, 49);
            this.addTabBtn.Name = "addTabBtn";
            this.addTabBtn.Size = new System.Drawing.Size(66, 63);
            this.addTabBtn.TabIndex = 1;
            this.addTabBtn.Text = "+";
            this.addTabBtn.UseVisualStyleBackColor = true;
            this.addTabBtn.Click += new System.EventHandler(this.addTabBtn_Click);
            // 
            // runBtn
            // 
            this.runBtn.Location = new System.Drawing.Point(10, 304);
            this.runBtn.Name = "runBtn";
            this.runBtn.Size = new System.Drawing.Size(241, 54);
            this.runBtn.TabIndex = 4;
            this.runBtn.Text = "Рассчитать наборы";
            this.runBtn.UseVisualStyleBackColor = true;
            this.runBtn.Click += new System.EventHandler(this.runBtn_Click);
            // 
            // deleteTabBtn
            // 
            this.deleteTabBtn.Location = new System.Drawing.Point(37, 134);
            this.deleteTabBtn.Name = "deleteTabBtn";
            this.deleteTabBtn.Size = new System.Drawing.Size(66, 63);
            this.deleteTabBtn.TabIndex = 5;
            this.deleteTabBtn.Text = "-";
            this.deleteTabBtn.UseVisualStyleBackColor = true;
            this.deleteTabBtn.Click += new System.EventHandler(this.deleteTabBtn_Click);
            // 
            // logRichTextBox
            // 
            this.logRichTextBox.Location = new System.Drawing.Point(651, 12);
            this.logRichTextBox.Name = "logRichTextBox";
            this.logRichTextBox.Size = new System.Drawing.Size(320, 308);
            this.logRichTextBox.TabIndex = 6;
            this.logRichTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addTabBtn);
            this.groupBox1.Controls.Add(this.deleteTabBtn);
            this.groupBox1.Location = new System.Drawing.Point(411, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(134, 253);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Наборы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.runBtn);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.tabControl);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(567, 382);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 404);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.logRichTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "Просчет наборов";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button addTabBtn;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button runBtn;
        private System.Windows.Forms.Button deleteTabBtn;
        private System.Windows.Forms.RichTextBox logRichTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

