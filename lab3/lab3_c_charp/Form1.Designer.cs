using System.Windows.Forms;

namespace lab3_c_charp
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
            this.textBoxX0 = new System.Windows.Forms.TextBox();
            this.textBoxXk = new System.Windows.Forms.TextBox();
            this.textBoxStep = new System.Windows.Forms.TextBox();
            this.labelX0 = new System.Windows.Forms.Label();
            this.labelXk = new System.Windows.Forms.Label();
            this.labelPoints = new System.Windows.Forms.Label();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxX0
            // 
            this.textBoxX0.Location = new System.Drawing.Point(10, 10);
            this.textBoxX0.Name = "textBoxX0";
            this.textBoxX0.Size = new System.Drawing.Size(100, 20);
            this.textBoxX0.TabIndex = 0;
            // 
            // textBoxXk
            // 
            this.textBoxXk.Location = new System.Drawing.Point(10, 40);
            this.textBoxXk.Name = "textBoxXk";
            this.textBoxXk.Size = new System.Drawing.Size(100, 20);
            this.textBoxXk.TabIndex = 1;
            // 
            // textBoxStep
            // 
            this.textBoxStep.Location = new System.Drawing.Point(10, 70);
            this.textBoxStep.Name = "textBoxStep";
            this.textBoxStep.Size = new System.Drawing.Size(100, 20);
            this.textBoxStep.TabIndex = 2;
            // 
            // labelX0
            // 
            this.labelX0.AutoSize = true;
            this.labelX0.Location = new System.Drawing.Point(110, 10);
            this.labelX0.Name = "labelX0";
            this.labelX0.Size = new System.Drawing.Size(20, 13);
            this.labelX0.TabIndex = 3;
            this.labelX0.Text = "X0";
            // 
            // labelXk
            // 
            this.labelXk.AutoSize = true;
            this.labelXk.Location = new System.Drawing.Point(110, 40);
            this.labelXk.Name = "labelXk";
            this.labelXk.Size = new System.Drawing.Size(20, 13);
            this.labelXk.TabIndex = 4;
            this.labelXk.Text = "Xk";
            // 
            // labelPoints
            // 
            this.labelPoints.AutoSize = true;
            this.labelPoints.Location = new System.Drawing.Point(110, 70);
            this.labelPoints.Name = "labelPoints";
            this.labelPoints.Size = new System.Drawing.Size(159, 13);
            this.labelPoints.TabIndex = 5;
            this.labelPoints.Text = "Число точек (от 1000 до 5000)";
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(10, 100);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(75, 23);
            this.CalculateButton.TabIndex = 6;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.Click += new System.EventHandler(this.CalculateButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.Location = new System.Drawing.Point(10, 130);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(700, 400);
            this.dataGridView.TabIndex = 7;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(342, 86);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(368, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(455, 22);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(142, 31);
            this.saveButton.TabIndex = 8;
            this.saveButton.Text = "Сохранить в файл";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.textBoxX0);
            this.Controls.Add(this.textBoxXk);
            this.Controls.Add(this.textBoxStep);
            this.Controls.Add(this.labelX0);
            this.Controls.Add(this.labelXk);
            this.Controls.Add(this.labelPoints);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.dataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox textBoxX0;
        private TextBox textBoxXk;
        private TextBox textBoxStep;
        private Button CalculateButton;
        private DataGridView dataGridView;
        private Label labelX0;
        private Label labelXk;
        private Label labelPoints;
        private ProgressBar progressBar1;
        private Button saveButton;
        //private ProgressBar progressBar2;
    }
}

