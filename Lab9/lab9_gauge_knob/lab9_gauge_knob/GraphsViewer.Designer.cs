namespace Lab9
{
    partial class GraphsViewer
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
            this.tabControlGraphs = new System.Windows.Forms.TabControl();
            this.labelName = new System.Windows.Forms.Label();
            this.groupBoxInfo = new System.Windows.Forms.GroupBox();
            this.buttonViewData = new System.Windows.Forms.Button();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonEditData = new System.Windows.Forms.Button();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolCreate = new System.Windows.Forms.ToolStripLabel();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolClose = new System.Windows.Forms.ToolStripLabel();
            this.Separator6 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolEditView = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolDelete = new System.Windows.Forms.ToolStripLabel();
            this.groupBoxInfo.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlGraphs
            // 
            this.tabControlGraphs.Location = new System.Drawing.Point(13, 30);
            this.tabControlGraphs.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlGraphs.Name = "tabControlGraphs";
            this.tabControlGraphs.SelectedIndex = 0;
            this.tabControlGraphs.Size = new System.Drawing.Size(660, 473);
            this.tabControlGraphs.TabIndex = 0;
            this.tabControlGraphs.SelectedIndexChanged += new System.EventHandler(this.tabControlGraphs_SelectedIndexChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(8, 30);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название:";
            // 
            // groupBoxInfo
            // 
            this.groupBoxInfo.Controls.Add(this.buttonViewData);
            this.groupBoxInfo.Controls.Add(this.textBoxName);
            this.groupBoxInfo.Controls.Add(this.buttonEditData);
            this.groupBoxInfo.Controls.Add(this.textBoxDescription);
            this.groupBoxInfo.Controls.Add(this.labelDescription);
            this.groupBoxInfo.Controls.Add(this.labelName);
            this.groupBoxInfo.Enabled = false;
            this.groupBoxInfo.Location = new System.Drawing.Point(681, 30);
            this.groupBoxInfo.Margin = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Name = "groupBoxInfo";
            this.groupBoxInfo.Padding = new System.Windows.Forms.Padding(4);
            this.groupBoxInfo.Size = new System.Drawing.Size(416, 473);
            this.groupBoxInfo.TabIndex = 4;
            this.groupBoxInfo.TabStop = false;
            this.groupBoxInfo.Text = "Информация";
            // 
            // buttonViewData
            // 
            this.buttonViewData.Enabled = false;
            this.buttonViewData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonViewData.Location = new System.Drawing.Point(12, 438);
            this.buttonViewData.Name = "buttonViewData";
            this.buttonViewData.Size = new System.Drawing.Size(97, 28);
            this.buttonViewData.TabIndex = 6;
            this.buttonViewData.Text = "Данные...";
            this.buttonViewData.UseVisualStyleBackColor = true;
            this.buttonViewData.Click += new System.EventHandler(this.buttonViewData_Click);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(109, 27);
            this.textBoxName.MaxLength = 20;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(297, 27);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(13, 95);
            this.textBoxDescription.MaxLength = 1000;
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.ReadOnly = true;
            this.textBoxDescription.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxDescription.Size = new System.Drawing.Size(393, 337);
            this.textBoxDescription.TabIndex = 4;
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(8, 73);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(96, 20);
            this.labelDescription.TabIndex = 3;
            this.labelDescription.Text = "Описание:";
            // 
            // buttonEditData
            // 
            this.buttonEditData.Location = new System.Drawing.Point(115, 438);
            this.buttonEditData.Name = "buttonEditData";
            this.buttonEditData.Size = new System.Drawing.Size(103, 28);
            this.buttonEditData.TabIndex = 0;
            this.buttonEditData.Text = "Изменить";
            this.buttonEditData.UseVisualStyleBackColor = true;
            this.buttonEditData.Click += new System.EventHandler(this.buttonEditData_Click);
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolCreate
            // 
            this.toolCreate.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolCreate.Name = "toolCreate";
            this.toolCreate.Size = new System.Drawing.Size(64, 28);
            this.toolCreate.Text = "Создать";
            this.toolCreate.Click += new System.EventHandler(this.toolCreate_Click);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolClose
            // 
            this.toolClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolClose.Name = "toolClose";
            this.toolClose.Size = new System.Drawing.Size(53, 28);
            this.toolClose.Text = "Выход";
            this.toolClose.Click += new System.EventHandler(this.toolClose_Click);
            // 
            // Separator6
            // 
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator1,
            this.toolCreate,
            this.Separator2,
            this.toolStripSeparator2,
            this.toolEditView,
            this.toolStripSeparator1,
            this.toolDelete,
            this.toolStripSeparator3,
            this.toolClose,
            this.Separator6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1105, 25);
            this.toolStrip1.TabIndex = 6;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolEditView
            // 
            this.toolEditView.Enabled = false;
            this.toolEditView.Name = "toolEditView";
            this.toolEditView.Size = new System.Drawing.Size(63, 22);
            this.toolEditView.Text = "Формат";
            this.toolEditView.Click += new System.EventHandler(this.toolEditView_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 31);
            // 
            // toolDelete
            // 
            this.toolDelete.Enabled = false;
            this.toolDelete.Name = "toolDelete";
            this.toolDelete.Size = new System.Drawing.Size(65, 22);
            this.toolDelete.Text = "Удалить";
            this.toolDelete.Click += new System.EventHandler(this.toolDelete_Click);
            // 
            // GraphsViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1105, 514);
            this.Controls.Add(this.groupBoxInfo);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.tabControlGraphs);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "GraphsViewer";
            this.Text = "Form1";
            this.groupBoxInfo.ResumeLayout(false);
            this.groupBoxInfo.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlGraphs;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.GroupBox groupBoxInfo;
        private System.Windows.Forms.Button buttonViewData;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonEditData;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        private System.Windows.Forms.ToolStripLabel toolCreate;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        private System.Windows.Forms.ToolStripLabel toolClose;
        private System.Windows.Forms.ToolStripSeparator Separator6;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolEditView;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

