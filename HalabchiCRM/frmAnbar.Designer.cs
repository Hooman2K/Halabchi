namespace HalabchiCRM
{
    partial class frmAnbar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvAnbar = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbxPipeLine = new System.Windows.Forms.ComboBox();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.cExport = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnExportContext = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnbar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExport)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAnbar
            // 
            this.dgvAnbar.AllowUserToAddRows = false;
            this.dgvAnbar.AllowUserToDeleteRows = false;
            this.dgvAnbar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAnbar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.cExport.SetContextMenuEx(this.dgvAnbar, this.btnExportContext);
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAnbar.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAnbar.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAnbar.Location = new System.Drawing.Point(12, 38);
            this.dgvAnbar.Name = "dgvAnbar";
            this.dgvAnbar.ReadOnly = true;
            this.dgvAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvAnbar.Size = new System.Drawing.Size(392, 380);
            this.dgvAnbar.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Id";
            this.Column1.HeaderText = "شماره";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Year";
            this.Column2.HeaderText = "سال";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Month";
            this.Column3.HeaderText = "ماه";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Day";
            this.Column4.HeaderText = "روز";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Date";
            this.Column5.HeaderText = "تاریخ";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PipeLineName";
            this.Column6.HeaderText = "خط تولید";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 120;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TahvilAnbar";
            this.Column7.HeaderText = "تحویل شده";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // cmbxPipeLine
            // 
            this.cmbxPipeLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPipeLine.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbxPipeLine.FormattingEnabled = true;
            this.cmbxPipeLine.Items.AddRange(new object[] {
            "تمامی تحویل ها"});
            this.cmbxPipeLine.Location = new System.Drawing.Point(12, 8);
            this.cmbxPipeLine.Name = "cmbxPipeLine";
            this.cmbxPipeLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxPipeLine.Size = new System.Drawing.Size(340, 24);
            this.cmbxPipeLine.TabIndex = 0;
            this.cmbxPipeLine.SelectedIndexChanged += new System.EventHandler(this.cmbxPipeLine_SelectedIndexChanged);
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(348, 10);
            this.labelX10.Name = "labelX10";
            this.labelX10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX10.Size = new System.Drawing.Size(56, 18);
            this.labelX10.TabIndex = 44;
            this.labelX10.Text = "نام خط : ";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate.Location = new System.Drawing.Point(12, 424);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(54, 18);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "-----------";
            this.lblDate.Visible = false;
            // 
            // cExport
            // 
            this.cExport.AntiAlias = true;
            this.cExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cExport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExportContext});
            this.cExport.Location = new System.Drawing.Point(83, 424);
            this.cExport.Name = "cExport";
            this.cExport.Size = new System.Drawing.Size(75, 25);
            this.cExport.Stretch = true;
            this.cExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cExport.TabIndex = 47;
            this.cExport.TabStop = false;
            this.cExport.Text = "contextMenuBar1";
            // 
            // btnExportContext
            // 
            this.btnExportContext.AutoExpandOnClick = true;
            this.btnExportContext.Name = "btnExportContext";
            this.btnExportContext.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem3});
            this.btnExportContext.Text = "خروجی";
            // 
            // buttonItem3
            // 
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2});
            this.buttonItem3.Text = "خروجی";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "از جدول";
            this.buttonItem1.Click += new System.EventHandler(this.buttonItem1_Click);
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "PDF";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // frmAnbar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 451);
            this.Controls.Add(this.cExport);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.cmbxPipeLine);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.dgvAnbar);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAnbar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نمایش انبار";
            this.Load += new System.EventHandler(this.frmAnbar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAnbar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvAnbar;
        private System.Windows.Forms.ComboBox cmbxPipeLine;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.DotNetBar.ContextMenuBar cExport;
        private DevComponents.DotNetBar.ButtonItem btnExportContext;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
    }
}