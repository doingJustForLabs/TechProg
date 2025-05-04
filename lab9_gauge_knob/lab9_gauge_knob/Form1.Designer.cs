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
            this.glgKnob1 = new GenLogic.GlgControl();
            this.glgMeter1 = new GenLogic.GlgControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.glgKnob2 = new GenLogic.GlgControl();
            this.glgMeter2 = new GenLogic.GlgControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // glgKnob1
            // 
            this.glgKnob1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.glgKnob1.DrawingFile = "";
            this.glgKnob1.DrawingObject = null;
            this.glgKnob1.DrawingURL = "";
            this.glgKnob1.HierarchyEnabled = true;
            this.glgKnob1.Location = new System.Drawing.Point(11, 80);
            this.glgKnob1.MinimumSize = new System.Drawing.Size(5, 5);
            this.glgKnob1.Name = "glgKnob1";
            this.glgKnob1.SelectEnabled = false;
            this.glgKnob1.Size = new System.Drawing.Size(213, 195);
            this.glgKnob1.TabIndex = 0;
            this.glgKnob1.Trace2Enabled = false;
            this.glgKnob1.TraceEnabled = false;
            // 
            // glgMeter1
            // 
            this.glgMeter1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.glgMeter1.DrawingFile = "";
            this.glgMeter1.DrawingObject = null;
            this.glgMeter1.DrawingURL = "";
            this.glgMeter1.HierarchyEnabled = true;
            this.glgMeter1.Location = new System.Drawing.Point(252, 80);
            this.glgMeter1.MinimumSize = new System.Drawing.Size(5, 5);
            this.glgMeter1.Name = "glgMeter1";
            this.glgMeter1.SelectEnabled = false;
            this.glgMeter1.Size = new System.Drawing.Size(216, 195);
            this.glgMeter1.TabIndex = 1;
            this.glgMeter1.Trace2Enabled = false;
            this.glgMeter1.TraceEnabled = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(247, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Температура воды";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(232, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Мощность нагревателя";
            // 
            // glgKnob2
            // 
            this.glgKnob2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.glgKnob2.DrawingFile = "";
            this.glgKnob2.DrawingObject = null;
            this.glgKnob2.DrawingURL = "";
            this.glgKnob2.HierarchyEnabled = true;
            this.glgKnob2.Location = new System.Drawing.Point(704, 92);
            this.glgKnob2.MinimumSize = new System.Drawing.Size(5, 5);
            this.glgKnob2.Name = "glgKnob2";
            this.glgKnob2.SelectEnabled = false;
            this.glgKnob2.Size = new System.Drawing.Size(213, 195);
            this.glgKnob2.TabIndex = 5;
            this.glgKnob2.Trace2Enabled = false;
            this.glgKnob2.TraceEnabled = false;
            // 
            // glgMeter2
            // 
            this.glgMeter2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.glgMeter2.DrawingFile = "";
            this.glgMeter2.DrawingObject = null;
            this.glgMeter2.DrawingURL = "";
            this.glgMeter2.HierarchyEnabled = true;
            this.glgMeter2.Location = new System.Drawing.Point(943, 92);
            this.glgMeter2.MinimumSize = new System.Drawing.Size(5, 5);
            this.glgMeter2.Name = "glgMeter2";
            this.glgMeter2.SelectEnabled = false;
            this.glgMeter2.Size = new System.Drawing.Size(213, 195);
            this.glgMeter2.TabIndex = 6;
            this.glgMeter2.Trace2Enabled = false;
            this.glgMeter2.TraceEnabled = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.glgKnob1);
            this.groupBox1.Controls.Add(this.glgMeter1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(498, 298);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Температура котла";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1246, 678);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.glgMeter2);
            this.Controls.Add(this.glgKnob2);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form1";
            this.Text = "Виртуальный парогенератор";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GenLogic.GlgControl glgKnob1;
        private GenLogic.GlgControl glgMeter1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private GenLogic.GlgControl glgKnob2;
        private GenLogic.GlgControl glgMeter2;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

