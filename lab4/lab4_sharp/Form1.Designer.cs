namespace lab4_sharp
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
            this.buttonDialog = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.buttonCopyFinal = new System.Windows.Forms.Button();
            this.buttonDeleteMark = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonDialog
            // 
            this.buttonDialog.Location = new System.Drawing.Point(351, 215);
            this.buttonDialog.Name = "buttonDialog";
            this.buttonDialog.Size = new System.Drawing.Size(33, 26);
            this.buttonDialog.TabIndex = 0;
            this.buttonDialog.Text = "...";
            this.buttonDialog.UseVisualStyleBackColor = true;
            this.buttonDialog.Click += new System.EventHandler(this.ButtonDialog_Click);
            // 
            // textBoxPath
            // 
            this.textBoxPath.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxPath.Location = new System.Drawing.Point(12, 215);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(333, 26);
            this.textBoxPath.TabIndex = 1;
            this.textBoxPath.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPath_KeyDown);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(390, 43);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(755, 449);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // buttonCopyFinal
            // 
            this.buttonCopyFinal.Location = new System.Drawing.Point(23, 345);
            this.buttonCopyFinal.Name = "buttonCopyFinal";
            this.buttonCopyFinal.Size = new System.Drawing.Size(131, 112);
            this.buttonCopyFinal.TabIndex = 4;
            this.buttonCopyFinal.Text = "Нажми и скопируй файлы в Final";
            this.buttonCopyFinal.UseVisualStyleBackColor = true;
            this.buttonCopyFinal.Click += new System.EventHandler(this.ButtonCopyFiles_Click);
            // 
            // buttonDeleteMark
            // 
            this.buttonDeleteMark.Location = new System.Drawing.Point(214, 345);
            this.buttonDeleteMark.Name = "buttonDeleteMark";
            this.buttonDeleteMark.Size = new System.Drawing.Size(131, 112);
            this.buttonDeleteMark.TabIndex = 5;
            this.buttonDeleteMark.Text = "Удали ! на конце файликов";
            this.buttonDeleteMark.UseVisualStyleBackColor = true;
            this.buttonDeleteMark.Click += new System.EventHandler(this.ButtonDeleteMark_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1169, 530);
            this.Controls.Add(this.buttonDeleteMark);
            this.Controls.Add(this.buttonCopyFinal);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBoxPath);
            this.Controls.Add(this.buttonDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDialog;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button buttonCopyFinal;
        private System.Windows.Forms.Button buttonDeleteMark;
    }
}

