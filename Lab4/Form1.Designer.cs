namespace Lab4
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
            this.runButton = new System.Windows.Forms.Button();
            this.pathTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pickFolder = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageBefore = new System.Windows.Forms.TabPage();
            this.tabPageAfter = new System.Windows.Forms.TabPage();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickFolder)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.runButton.Location = new System.Drawing.Point(134, 119);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(139, 42);
            this.runButton.TabIndex = 0;
            this.runButton.Text = "Run Tasks";
            this.runButton.UseVisualStyleBackColor = false;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // pathTextBox
            // 
            this.pathTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.pathTextBox.Location = new System.Drawing.Point(18, 69);
            this.pathTextBox.Name = "pathTextBox";
            this.pathTextBox.Size = new System.Drawing.Size(380, 29);
            this.pathTextBox.TabIndex = 1;
            this.pathTextBox.Text = "D:\\iT\\TEST_FOLDER";
            this.pathTextBox.Enter += new System.EventHandler(this.pathTextBox_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.pickFolder);
            this.groupBox1.Controls.Add(this.runButton);
            this.groupBox1.Controls.Add(this.pathTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 319);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(413, 180);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Введите путь до папки:";
            // 
            // pickFolder
            // 
            this.pickFolder.Image = ((System.Drawing.Image)(resources.GetObject("pickFolder.Image")));
            this.pickFolder.Location = new System.Drawing.Point(370, 74);
            this.pickFolder.Name = "pickFolder";
            this.pickFolder.Size = new System.Drawing.Size(15, 15);
            this.pickFolder.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pickFolder.TabIndex = 2;
            this.pickFolder.TabStop = false;
            this.pickFolder.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 2;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox3.Controls.Add(this.richTextBox1);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(413, 301);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Info";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(18, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(380, 259);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = resources.GetString("richTextBox1.Text");
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.groupBox2.Controls.Add(this.tabControl1);
            this.groupBox2.Location = new System.Drawing.Point(431, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(446, 487);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Folders";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageBefore);
            this.tabControl1.Controls.Add(this.tabPageAfter);
            this.tabControl1.Location = new System.Drawing.Point(18, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(422, 444);
            this.tabControl1.TabIndex = 10;
            // 
            // tabPageBefore
            // 
            this.tabPageBefore.Location = new System.Drawing.Point(4, 33);
            this.tabPageBefore.Name = "tabPageBefore";
            this.tabPageBefore.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageBefore.Size = new System.Drawing.Size(414, 407);
            this.tabPageBefore.TabIndex = 0;
            this.tabPageBefore.Text = "Было";
            this.tabPageBefore.UseVisualStyleBackColor = true;
            // 
            // tabPageAfter
            // 
            this.tabPageAfter.Location = new System.Drawing.Point(4, 33);
            this.tabPageAfter.Name = "tabPageAfter";
            this.tabPageAfter.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAfter.Size = new System.Drawing.Size(414, 407);
            this.tabPageAfter.TabIndex = 1;
            this.tabPageAfter.Text = "Стало";
            this.tabPageAfter.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 512);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickFolder)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox pathTextBox;
        private System.Windows.Forms.PictureBox pickFolder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageBefore;
        private System.Windows.Forms.TabPage tabPageAfter;
    }
}

