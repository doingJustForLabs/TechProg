namespace lab5_2_sharp
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
            this.components = new System.ComponentModel.Container();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.btnShowPoints = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.dataGridViewFiles = new System.Windows.Forms.DataGridView();
            this.buttonLoadData = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.timerFilesUpdate = new System.Windows.Forms.Timer(this.components);
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.labelHY = new System.Windows.Forms.Label();
            this.labelNy = new System.Windows.Forms.Label();
            this.labelY0 = new System.Windows.Forms.Label();
            this.labelHX = new System.Windows.Forms.Label();
            this.labelXk = new System.Windows.Forms.Label();
            this.labelX0 = new System.Windows.Forms.Label();
            this.textBoxStepY = new System.Windows.Forms.TextBox();
            this.textBoxNy = new System.Windows.Forms.TextBox();
            this.textBoxY0 = new System.Windows.Forms.TextBox();
            this.textBoxStepX = new System.Windows.Forms.TextBox();
            this.textBoxXk = new System.Windows.Forms.TextBox();
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.btnValidate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(36, 387);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(121, 35);
            this.buttonCalc.TabIndex = 1;
            this.buttonCalc.Text = "Расчёт";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCancel.Location = new System.Drawing.Point(350, 387);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(121, 35);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // btnShowPoints
            // 
            this.btnShowPoints.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnShowPoints.Location = new System.Drawing.Point(494, 352);
            this.btnShowPoints.Name = "btnShowPoints";
            this.btnShowPoints.Size = new System.Drawing.Size(121, 35);
            this.btnShowPoints.TabIndex = 3;
            this.btnShowPoints.Text = "Вывести точки";
            this.btnShowPoints.UseVisualStyleBackColor = true;
            this.btnShowPoints.Click += new System.EventHandler(this.btnShowPoints_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(532, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(59, 53);
            this.button1.TabIndex = 4;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BtnAddTab_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(606, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(59, 53);
            this.button2.TabIndex = 5;
            this.button2.Text = "-";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.BtnRemoveTab_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(494, 82);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(357, 264);
            this.listBox1.TabIndex = 6;
            // 
            // dataGridViewFiles
            // 
            this.dataGridViewFiles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridViewFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFiles.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewFiles.Location = new System.Drawing.Point(0, 455);
            this.dataGridViewFiles.Name = "dataGridViewFiles";
            this.dataGridViewFiles.Size = new System.Drawing.Size(1210, 264);
            this.dataGridViewFiles.TabIndex = 7;
            this.dataGridViewFiles.Visible = false;
            // 
            // buttonLoadData
            // 
            this.buttonLoadData.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonLoadData.Location = new System.Drawing.Point(986, 377);
            this.buttonLoadData.Name = "buttonLoadData";
            this.buttonLoadData.Size = new System.Drawing.Size(191, 45);
            this.buttonLoadData.TabIndex = 8;
            this.buttonLoadData.Text = "Вывести данные из файла";
            this.buttonLoadData.UseVisualStyleBackColor = true;
            this.buttonLoadData.Click += new System.EventHandler(this.BtnLoadData_Click);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(878, 73);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(299, 277);
            this.listBoxFiles.TabIndex = 9;
            this.listBoxFiles.SelectedIndexChanged += new System.EventHandler(this.ListBoxFiles_SelectedIndexChanged);
            // 
            // timerFilesUpdate
            // 
            this.timerFilesUpdate.Interval = 500;
            this.timerFilesUpdate.Tick += new System.EventHandler(this.timerFilesUpdate_Tick);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.labelHY);
            this.tabPage1.Controls.Add(this.labelNy);
            this.tabPage1.Controls.Add(this.labelY0);
            this.tabPage1.Controls.Add(this.labelHX);
            this.tabPage1.Controls.Add(this.labelXk);
            this.tabPage1.Controls.Add(this.labelX0);
            this.tabPage1.Controls.Add(this.textBoxStepY);
            this.tabPage1.Controls.Add(this.textBoxNy);
            this.tabPage1.Controls.Add(this.textBoxY0);
            this.tabPage1.Controls.Add(this.textBoxStepX);
            this.tabPage1.Controls.Add(this.textBoxXk);
            this.tabPage1.Controls.Add(this.textBoxX0);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(431, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // labelHY
            // 
            this.labelHY.AutoSize = true;
            this.labelHY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHY.Location = new System.Drawing.Point(193, 162);
            this.labelHY.Name = "labelHY";
            this.labelHY.Size = new System.Drawing.Size(53, 20);
            this.labelHY.TabIndex = 11;
            this.labelHY.Text = "Шаг Y";
            // 
            // labelNy
            // 
            this.labelNy.AutoSize = true;
            this.labelNy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNy.Location = new System.Drawing.Point(219, 89);
            this.labelNy.Name = "labelNy";
            this.labelNy.Size = new System.Drawing.Size(27, 20);
            this.labelNy.TabIndex = 10;
            this.labelNy.Text = "Ny";
            // 
            // labelY0
            // 
            this.labelY0.AutoSize = true;
            this.labelY0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelY0.Location = new System.Drawing.Point(217, 25);
            this.labelY0.Name = "labelY0";
            this.labelY0.Size = new System.Drawing.Size(29, 20);
            this.labelY0.TabIndex = 9;
            this.labelY0.Text = "Y0";
            // 
            // labelHX
            // 
            this.labelHX.AutoSize = true;
            this.labelHX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelHX.Location = new System.Drawing.Point(17, 162);
            this.labelHX.Name = "labelHX";
            this.labelHX.Size = new System.Drawing.Size(53, 20);
            this.labelHX.TabIndex = 8;
            this.labelHX.Text = "Шаг X";
            // 
            // labelXk
            // 
            this.labelXk.AutoSize = true;
            this.labelXk.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelXk.Location = new System.Drawing.Point(17, 89);
            this.labelXk.Name = "labelXk";
            this.labelXk.Size = new System.Drawing.Size(28, 20);
            this.labelXk.TabIndex = 7;
            this.labelXk.Text = "Xk";
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelX0.Location = new System.Drawing.Point(17, 25);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(29, 20);
            this.labelX0.TabIndex = 6;
            this.labelX0.Text = "X0";
            // 
            // textBoxStepY
            // 
            this.textBoxStepY.Location = new System.Drawing.Point(274, 162);
            this.textBoxStepY.Name = "textBoxStepY";
            this.textBoxStepY.Size = new System.Drawing.Size(86, 20);
            this.textBoxStepY.TabIndex = 5;
            this.textBoxStepY.Text = "1";
            // 
            // textBoxNy
            // 
            this.textBoxNy.Location = new System.Drawing.Point(274, 89);
            this.textBoxNy.Name = "textBoxNy";
            this.textBoxNy.Size = new System.Drawing.Size(86, 20);
            this.textBoxNy.TabIndex = 4;
            this.textBoxNy.Text = "10";
            // 
            // textBoxY0
            // 
            this.textBoxY0.Location = new System.Drawing.Point(274, 25);
            this.textBoxY0.Name = "textBoxY0";
            this.textBoxY0.Size = new System.Drawing.Size(86, 20);
            this.textBoxY0.TabIndex = 3;
            this.textBoxY0.Text = "-10";
            // 
            // textBoxStepX
            // 
            this.textBoxStepX.Location = new System.Drawing.Point(87, 162);
            this.textBoxStepX.Name = "textBoxStepX";
            this.textBoxStepX.Size = new System.Drawing.Size(86, 20);
            this.textBoxStepX.TabIndex = 2;
            this.textBoxStepX.Text = "1";
            // 
            // textBoxXk
            // 
            this.textBoxXk.Location = new System.Drawing.Point(87, 89);
            this.textBoxXk.Name = "textBoxXk";
            this.textBoxXk.Size = new System.Drawing.Size(86, 20);
            this.textBoxXk.TabIndex = 1;
            this.textBoxXk.Text = "10";
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(87, 25);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(86, 20);
            this.textBoxX0.TabIndex = 0;
            this.textBoxX0.Text = "-10";
            // 
            // tabControl1
            // 
            this.tabControl1.CausesValidation = false;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(32, 31);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(439, 319);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.TabControl1_SelectedIndexChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnGenerate.Location = new System.Drawing.Point(680, 387);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(171, 35);
            this.btnGenerate.TabIndex = 10;
            this.btnGenerate.Text = "Сгенерировать точки";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.BtnGenerate_Click);
            // 
            // btnValidate
            // 
            this.btnValidate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnValidate.Location = new System.Drawing.Point(163, 387);
            this.btnValidate.Name = "btnValidate";
            this.btnValidate.Size = new System.Drawing.Size(181, 35);
            this.btnValidate.TabIndex = 11;
            this.btnValidate.Text = "Проверка данных";
            this.btnValidate.UseVisualStyleBackColor = true;
            this.btnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 719);
            this.Controls.Add(this.btnValidate);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.buttonLoadData);
            this.Controls.Add(this.dataGridViewFiles);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnShowPoints);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFiles)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button btnShowPoints;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.DataGridView dataGridViewFiles;
        private System.Windows.Forms.Button buttonLoadData;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.Timer timerFilesUpdate;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label labelHY;
        private System.Windows.Forms.Label labelNy;
        private System.Windows.Forms.Label labelY0;
        private System.Windows.Forms.Label labelHX;
        private System.Windows.Forms.Label labelXk;
        private System.Windows.Forms.Label labelX0;
        private System.Windows.Forms.TextBox textBoxStepY;
        private System.Windows.Forms.TextBox textBoxNy;
        private System.Windows.Forms.TextBox textBoxY0;
        private System.Windows.Forms.TextBox textBoxStepX;
        private System.Windows.Forms.TextBox textBoxXk;
        private System.Windows.Forms.TextBox textBoxX0;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Button btnValidate;
    }
}

