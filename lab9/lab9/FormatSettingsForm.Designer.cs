namespace lab9
{
    partial class FormatSettingsForm
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
            this.comboBoxAxisType = new System.Windows.Forms.ComboBox();
            this.checkBoxGrid = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.labelAxis = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxAxisType
            // 
            this.comboBoxAxisType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAxisType.FormattingEnabled = true;
            this.comboBoxAxisType.Items.AddRange(new object[] {
            "Linear",
            "Log",
            "Date",
            "Exponent"});
            this.comboBoxAxisType.Location = new System.Drawing.Point(82, 85);
            this.comboBoxAxisType.Name = "comboBoxAxisType";
            this.comboBoxAxisType.Size = new System.Drawing.Size(225, 21);
            this.comboBoxAxisType.TabIndex = 0;
            // 
            // checkBoxGrid
            // 
            this.checkBoxGrid.AutoSize = true;
            this.checkBoxGrid.Location = new System.Drawing.Point(100, 438);
            this.checkBoxGrid.Name = "checkBoxGrid";
            this.checkBoxGrid.Size = new System.Drawing.Size(106, 17);
            this.checkBoxGrid.TabIndex = 1;
            this.checkBoxGrid.Text = "Показать сетку";
            this.checkBoxGrid.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(572, 407);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(91, 48);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Применить";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // labelAxis
            // 
            this.labelAxis.AutoSize = true;
            this.labelAxis.Location = new System.Drawing.Point(12, 85);
            this.labelAxis.Name = "labelAxis";
            this.labelAxis.Size = new System.Drawing.Size(50, 13);
            this.labelAxis.TabIndex = 5;
            this.labelAxis.Text = "Тип оси:";
            // 
            // FormatSettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 510);
            this.Controls.Add(this.labelAxis);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.checkBoxGrid);
            this.Controls.Add(this.comboBoxAxisType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormatSettingsForm";
            this.Text = "FormatSettingsForm";
            this.Load += new System.EventHandler(this.FormatSettingsForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxAxisType;
        private System.Windows.Forms.CheckBox checkBoxGrid;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label labelAxis;
    }
}