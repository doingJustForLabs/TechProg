namespace Lab9
{
    partial class GraphEditData
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
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonOK = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDataPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelDescriptionSymb = new System.Windows.Forms.Label();
            this.labelNameSymb = new System.Windows.Forms.Label();
            this.buttonRecover = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(508, 372);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(102, 30);
            this.buttonCancel.TabIndex = 17;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(508, 84);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(102, 30);
            this.buttonClear.TabIndex = 16;
            this.buttonClear.Text = "Очистить";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonOK
            // 
            this.buttonOK.Location = new System.Drawing.Point(508, 12);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(102, 30);
            this.buttonOK.TabIndex = 15;
            this.buttonOK.Text = "ОК";
            this.buttonOK.UseVisualStyleBackColor = true;
            this.buttonOK.Click += new System.EventHandler(this.buttonOK_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDataPath);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.buttonBrowse);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBoxType);
            this.groupBox1.Controls.Add(this.textBoxDescription);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.labelDescriptionSymb);
            this.groupBox1.Controls.Add(this.labelNameSymb);
            this.groupBox1.Location = new System.Drawing.Point(10, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(492, 402);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // textBoxDataPath
            // 
            this.textBoxDataPath.Location = new System.Drawing.Point(180, 369);
            this.textBoxDataPath.Name = "textBoxDataPath";
            this.textBoxDataPath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.textBoxDataPath.Size = new System.Drawing.Size(212, 27);
            this.textBoxDataPath.TabIndex = 10;
            this.textBoxDataPath.TextChanged += new System.EventHandler(this.textBoxDataPath_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название:";
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBrowse.Location = new System.Drawing.Point(398, 367);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(86, 30);
            this.buttonBrowse.TabIndex = 9;
            this.buttonBrowse.Text = "Обзор...";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(110, 31);
            this.textBoxName.MaxLength = 50;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(292, 27);
            this.textBoxName.TabIndex = 1;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(167, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "Заменить данные:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Описание:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Location = new System.Drawing.Point(110, 75);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(292, 28);
            this.comboBoxType.TabIndex = 7;
            this.comboBoxType.SelectedIndexChanged += new System.EventHandler(this.comboBoxType_SelectedIndexChanged);
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(109, 119);
            this.textBoxDescription.MaxLength = 1000;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(375, 240);
            this.textBoxDescription.TabIndex = 3;
            this.textBoxDescription.TextChanged += new System.EventHandler(this.textBoxDescription_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Тип:";
            // 
            // labelDescriptionSymb
            // 
            this.labelDescriptionSymb.AutoSize = true;
            this.labelDescriptionSymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDescriptionSymb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelDescriptionSymb.Location = new System.Drawing.Point(8, 139);
            this.labelDescriptionSymb.Name = "labelDescriptionSymb";
            this.labelDescriptionSymb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelDescriptionSymb.Size = new System.Drawing.Size(46, 16);
            this.labelDescriptionSymb.TabIndex = 4;
            this.labelDescriptionSymb.Text = "0/1000";
            this.labelDescriptionSymb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelNameSymb
            // 
            this.labelNameSymb.AutoSize = true;
            this.labelNameSymb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameSymb.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.labelNameSymb.Location = new System.Drawing.Point(8, 54);
            this.labelNameSymb.Name = "labelNameSymb";
            this.labelNameSymb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelNameSymb.Size = new System.Drawing.Size(32, 16);
            this.labelNameSymb.TabIndex = 5;
            this.labelNameSymb.Text = "0/50";
            this.labelNameSymb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonRecover
            // 
            this.buttonRecover.Location = new System.Drawing.Point(508, 48);
            this.buttonRecover.Name = "buttonRecover";
            this.buttonRecover.Size = new System.Drawing.Size(102, 30);
            this.buttonRecover.TabIndex = 18;
            this.buttonRecover.Text = "Вернуть";
            this.buttonRecover.UseVisualStyleBackColor = true;
            this.buttonRecover.Click += new System.EventHandler(this.buttonRecover_Click);
            // 
            // GraphEditData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 413);
            this.Controls.Add(this.buttonRecover);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "GraphEditData";
            this.Text = "Редактирование данных";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonOK;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDataPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelDescriptionSymb;
        private System.Windows.Forms.Label labelNameSymb;
        private System.Windows.Forms.Button buttonRecover;
    }
}