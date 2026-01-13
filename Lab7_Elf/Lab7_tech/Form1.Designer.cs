namespace Lab7_tech
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
            this.comboBoxNumber = new System.Windows.Forms.ComboBox();
            this.listBoxOperations = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonDeleteNumber = new System.Windows.Forms.Button();
            this.buttonClearOprnds = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.buttonExtrct = new System.Windows.Forms.Button();
            this.buttonDivis = new System.Windows.Forms.Button();
            this.buttonMltpl = new System.Windows.Forms.Button();
            this.buttonDeleteOprts = new System.Windows.Forms.Button();
            this.buttonClearOprts = new System.Windows.Forms.Button();
            this.buttonDownload = new System.Windows.Forms.Button();
            this.buttonSaveToFile = new System.Windows.Forms.Button();
            this.listBoxResult = new System.Windows.Forms.ListBox();
            this.buttonCalc = new System.Windows.Forms.Button();
            this.lstExpression = new System.Windows.Forms.ListBox();
            this.listBoxNumbers = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBoxNumber
            // 
            this.comboBoxNumber.FormattingEnabled = true;
            this.comboBoxNumber.Location = new System.Drawing.Point(39, 62);
            this.comboBoxNumber.Name = "comboBoxNumber";
            this.comboBoxNumber.Size = new System.Drawing.Size(213, 21);
            this.comboBoxNumber.TabIndex = 0;
            // 
            // listBoxOperations
            // 
            this.listBoxOperations.FormattingEnabled = true;
            this.listBoxOperations.Location = new System.Drawing.Point(601, 62);
            this.listBoxOperations.Name = "listBoxOperations";
            this.listBoxOperations.Size = new System.Drawing.Size(291, 251);
            this.listBoxOperations.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Операнды";
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(39, 108);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(213, 61);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "Принять";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.BtnAddNumber_Click);
            // 
            // buttonDeleteNumber
            // 
            this.buttonDeleteNumber.Location = new System.Drawing.Point(39, 175);
            this.buttonDeleteNumber.Name = "buttonDeleteNumber";
            this.buttonDeleteNumber.Size = new System.Drawing.Size(213, 61);
            this.buttonDeleteNumber.TabIndex = 4;
            this.buttonDeleteNumber.Text = "Удалить";
            this.buttonDeleteNumber.UseVisualStyleBackColor = true;
            this.buttonDeleteNumber.Click += new System.EventHandler(this.buttonDeleteNumber_Click);
            // 
            // buttonClearOprnds
            // 
            this.buttonClearOprnds.Location = new System.Drawing.Point(39, 246);
            this.buttonClearOprnds.Name = "buttonClearOprnds";
            this.buttonClearOprnds.Size = new System.Drawing.Size(213, 61);
            this.buttonClearOprnds.TabIndex = 5;
            this.buttonClearOprnds.Text = "Очистить числа";
            this.buttonClearOprnds.UseVisualStyleBackColor = true;
            this.buttonClearOprnds.Click += new System.EventHandler(this.buttonClearOprnds_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(598, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Операции";
            // 
            // buttonPlus
            // 
            this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPlus.Location = new System.Drawing.Point(937, 62);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(59, 52);
            this.buttonPlus.TabIndex = 7;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = true;
            this.buttonPlus.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonExtrct
            // 
            this.buttonExtrct.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExtrct.Location = new System.Drawing.Point(937, 130);
            this.buttonExtrct.Name = "buttonExtrct";
            this.buttonExtrct.Size = new System.Drawing.Size(59, 52);
            this.buttonExtrct.TabIndex = 8;
            this.buttonExtrct.Text = "-";
            this.buttonExtrct.UseVisualStyleBackColor = true;
            this.buttonExtrct.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonDivis
            // 
            this.buttonDivis.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDivis.Location = new System.Drawing.Point(1002, 62);
            this.buttonDivis.Name = "buttonDivis";
            this.buttonDivis.Size = new System.Drawing.Size(59, 52);
            this.buttonDivis.TabIndex = 9;
            this.buttonDivis.Text = "/";
            this.buttonDivis.UseVisualStyleBackColor = true;
            this.buttonDivis.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonMltpl
            // 
            this.buttonMltpl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonMltpl.Location = new System.Drawing.Point(1002, 130);
            this.buttonMltpl.Name = "buttonMltpl";
            this.buttonMltpl.Size = new System.Drawing.Size(59, 52);
            this.buttonMltpl.TabIndex = 10;
            this.buttonMltpl.Text = "*";
            this.buttonMltpl.UseVisualStyleBackColor = true;
            this.buttonMltpl.Click += new System.EventHandler(this.OperationButton_Click);
            // 
            // buttonDeleteOprts
            // 
            this.buttonDeleteOprts.Location = new System.Drawing.Point(937, 197);
            this.buttonDeleteOprts.Name = "buttonDeleteOprts";
            this.buttonDeleteOprts.Size = new System.Drawing.Size(124, 52);
            this.buttonDeleteOprts.TabIndex = 11;
            this.buttonDeleteOprts.Text = "Удалить";
            this.buttonDeleteOprts.UseVisualStyleBackColor = true;
            this.buttonDeleteOprts.Click += new System.EventHandler(this.buttonDeleteOprts_Click);
            // 
            // buttonClearOprts
            // 
            this.buttonClearOprts.Location = new System.Drawing.Point(937, 255);
            this.buttonClearOprts.Name = "buttonClearOprts";
            this.buttonClearOprts.Size = new System.Drawing.Size(124, 52);
            this.buttonClearOprts.TabIndex = 12;
            this.buttonClearOprts.Text = "Очистить операции";
            this.buttonClearOprts.UseVisualStyleBackColor = true;
            this.buttonClearOprts.Click += new System.EventHandler(this.buttonClearOprts_Click);
            // 
            // buttonDownload
            // 
            this.buttonDownload.Location = new System.Drawing.Point(913, 357);
            this.buttonDownload.Name = "buttonDownload";
            this.buttonDownload.Size = new System.Drawing.Size(148, 52);
            this.buttonDownload.TabIndex = 13;
            this.buttonDownload.Text = "Загрузить";
            this.buttonDownload.UseVisualStyleBackColor = true;
            this.buttonDownload.Click += new System.EventHandler(this.buttonDownload_Click);
            // 
            // buttonSaveToFile
            // 
            this.buttonSaveToFile.Location = new System.Drawing.Point(913, 413);
            this.buttonSaveToFile.Name = "buttonSaveToFile";
            this.buttonSaveToFile.Size = new System.Drawing.Size(148, 52);
            this.buttonSaveToFile.TabIndex = 14;
            this.buttonSaveToFile.Text = "Сохранить в файл";
            this.buttonSaveToFile.UseVisualStyleBackColor = true;
            this.buttonSaveToFile.Click += new System.EventHandler(this.buttonSaveToFile_Click);
            // 
            // listBoxResult
            // 
            this.listBoxResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listBoxResult.FormattingEnabled = true;
            this.listBoxResult.ItemHeight = 20;
            this.listBoxResult.Items.AddRange(new object[] {
            "Результат выполнения всех операций"});
            this.listBoxResult.Location = new System.Drawing.Point(224, 505);
            this.listBoxResult.Name = "listBoxResult";
            this.listBoxResult.Size = new System.Drawing.Size(583, 104);
            this.listBoxResult.TabIndex = 15;
            this.listBoxResult.Tag = "";
            // 
            // buttonCalc
            // 
            this.buttonCalc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCalc.Location = new System.Drawing.Point(51, 505);
            this.buttonCalc.Name = "buttonCalc";
            this.buttonCalc.Size = new System.Drawing.Size(129, 108);
            this.buttonCalc.TabIndex = 16;
            this.buttonCalc.Text = "Рассчитать введеные параметры";
            this.buttonCalc.UseVisualStyleBackColor = true;
            this.buttonCalc.Click += new System.EventHandler(this.ButtonCalc_Click);
            // 
            // lstExpression
            // 
            this.lstExpression.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstExpression.FormattingEnabled = true;
            this.lstExpression.ItemHeight = 20;
            this.lstExpression.Items.AddRange(new object[] {
            "Ваше готовое выражение"});
            this.lstExpression.Location = new System.Drawing.Point(224, 357);
            this.lstExpression.Name = "lstExpression";
            this.lstExpression.Size = new System.Drawing.Size(530, 104);
            this.lstExpression.TabIndex = 17;
            // 
            // listBoxNumbers
            // 
            this.listBoxNumbers.FormattingEnabled = true;
            this.listBoxNumbers.Location = new System.Drawing.Point(288, 62);
            this.listBoxNumbers.Name = "listBoxNumbers";
            this.listBoxNumbers.Size = new System.Drawing.Size(291, 251);
            this.listBoxNumbers.TabIndex = 18;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Выбранные числа";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 370);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 76);
            this.button1.TabIndex = 20;
            this.button1.Text = "Очистить вывод и выражение";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1145, 660);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listBoxNumbers);
            this.Controls.Add(this.lstExpression);
            this.Controls.Add(this.buttonCalc);
            this.Controls.Add(this.listBoxResult);
            this.Controls.Add(this.buttonSaveToFile);
            this.Controls.Add(this.buttonDownload);
            this.Controls.Add(this.buttonClearOprts);
            this.Controls.Add(this.buttonDeleteOprts);
            this.Controls.Add(this.buttonMltpl);
            this.Controls.Add(this.buttonDivis);
            this.Controls.Add(this.buttonExtrct);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonClearOprnds);
            this.Controls.Add(this.buttonDeleteNumber);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBoxOperations);
            this.Controls.Add(this.comboBoxNumber);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxNumber;
        private System.Windows.Forms.ListBox listBoxOperations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonDeleteNumber;
        private System.Windows.Forms.Button buttonClearOprnds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button buttonExtrct;
        private System.Windows.Forms.Button buttonDivis;
        private System.Windows.Forms.Button buttonMltpl;
        private System.Windows.Forms.Button buttonDeleteOprts;
        private System.Windows.Forms.Button buttonClearOprts;
        private System.Windows.Forms.Button buttonDownload;
        private System.Windows.Forms.Button buttonSaveToFile;
        private System.Windows.Forms.ListBox listBoxResult;
        private System.Windows.Forms.Button buttonCalc;
        private System.Windows.Forms.ListBox lstExpression;
        private System.Windows.Forms.ListBox listBoxNumbers;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}

