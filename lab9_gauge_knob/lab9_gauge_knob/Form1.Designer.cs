namespace lab9_gauge_knob
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
            this.glgControl1 = new GenLogic.GlgControl();
            this.glgControl2 = new GenLogic.GlgControl();
            this.glgControl3 = new GenLogic.GlgControl();
            this.glgControl4 = new GenLogic.GlgControl();
            this.SuspendLayout();
            // 
            // glgControl1
            // 
            this.glgControl1.DrawingFile = "";
            this.glgControl1.DrawingObject = null;
            this.glgControl1.DrawingURL = "";
            this.glgControl1.HierarchyEnabled = true;
            this.glgControl1.Location = new System.Drawing.Point(31, 67);
            this.glgControl1.MinimumSize = new System.Drawing.Size(5, 5);
            this.glgControl1.Name = "glgControl1";
            this.glgControl1.SelectEnabled = false;
            this.glgControl1.Size = new System.Drawing.Size(352, 394);
            this.glgControl1.TabIndex = 0;
            this.glgControl1.Text = "glgControl1";
            this.glgControl1.Trace2Enabled = false;
            this.glgControl1.TraceEnabled = false;
            // 
            // glgControl2
            // 
            this.glgControl2.DrawingFile = "";
            this.glgControl2.DrawingObject = null;
            this.glgControl2.DrawingURL = "";
            this.glgControl2.HierarchyEnabled = true;
            this.glgControl2.Location = new System.Drawing.Point(443, 27);
            this.glgControl2.MinimumSize = new System.Drawing.Size(5, 5);
            this.glgControl2.Name = "glgControl2";
            this.glgControl2.SelectEnabled = false;
            this.glgControl2.Size = new System.Drawing.Size(111, 80);
            this.glgControl2.TabIndex = 1;
            this.glgControl2.Text = "glgControl2";
            this.glgControl2.Trace2Enabled = false;
            this.glgControl2.TraceEnabled = false;
            // 
            // glgControl3
            // 
            this.glgControl3.DrawingFile = "";
            this.glgControl3.DrawingObject = null;
            this.glgControl3.DrawingURL = "";
            this.glgControl3.HierarchyEnabled = true;
            this.glgControl3.Location = new System.Drawing.Point(443, 113);
            this.glgControl3.MinimumSize = new System.Drawing.Size(5, 5);
            this.glgControl3.Name = "glgControl3";
            this.glgControl3.SelectEnabled = false;
            this.glgControl3.Size = new System.Drawing.Size(283, 280);
            this.glgControl3.TabIndex = 2;
            this.glgControl3.Text = "glgControl3";
            this.glgControl3.Trace2Enabled = false;
            this.glgControl3.TraceEnabled = false;
            // 
            // glgControl4
            // 
            this.glgControl4.DrawingFile = "";
            this.glgControl4.DrawingObject = null;
            this.glgControl4.DrawingURL = "";
            this.glgControl4.HierarchyEnabled = true;
            this.glgControl4.Location = new System.Drawing.Point(713, 487);
            this.glgControl4.MinimumSize = new System.Drawing.Size(5, 5);
            this.glgControl4.Name = "glgControl4";
            this.glgControl4.SelectEnabled = false;
            this.glgControl4.Size = new System.Drawing.Size(149, 46);
            this.glgControl4.TabIndex = 3;
            this.glgControl4.Text = "glgControl4";
            this.glgControl4.Trace2Enabled = false;
            this.glgControl4.TraceEnabled = false;
            this.glgControl4.Click += new System.EventHandler(this.glgControl4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1082, 558);
            this.Controls.Add(this.glgControl4);
            this.Controls.Add(this.glgControl3);
            this.Controls.Add(this.glgControl2);
            this.Controls.Add(this.glgControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private GenLogic.GlgControl glgControl1;
        private GenLogic.GlgControl glgControl2;
        private GenLogic.GlgControl glgControl3;
        private GenLogic.GlgControl glgControl4;
    }
}

