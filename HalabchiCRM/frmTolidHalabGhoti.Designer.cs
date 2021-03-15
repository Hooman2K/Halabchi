namespace HalabchiCRM
{
    partial class frmTolidHalabGhoti
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnRegister = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvTolid = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtMojodiAval = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtTolid = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtJamKol = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtTahvilAnbar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtMandeAkhar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbxPipeLine = new System.Windows.Forms.ComboBox();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.chbxAmarKhat = new DevComponents.DotNetBar.Controls.CheckBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTolid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegister.Location = new System.Drawing.Point(99, 71);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnRegister.Size = new System.Drawing.Size(80, 23);
            this.btnRegister.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegister.TabIndex = 7;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(725, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(44, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "تاریخ : ";
            // 
            // dgvTolid
            // 
            this.dgvTolid.AllowUserToAddRows = false;
            this.dgvTolid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTolid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvTolid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTolid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTolid.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTolid.EnableHeadersVisualStyles = false;
            this.dgvTolid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTolid.Location = new System.Drawing.Point(12, 99);
            this.dgvTolid.Name = "dgvTolid";
            this.dgvTolid.ReadOnly = true;
            this.dgvTolid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTolid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTolid.Size = new System.Drawing.Size(757, 150);
            this.dgvTolid.TabIndex = 9;
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
            this.Column5.Width = 90;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "PipeLineName";
            this.Column6.HeaderText = "خط تولید";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MojodiAval";
            this.Column7.HeaderText = "موجودی اول وقت";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Tolid";
            this.Column8.HeaderText = "تولید";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "JamKol";
            this.Column9.HeaderText = "جمع کل";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "TahvilAnbar";
            this.Column10.HeaderText = "تحویل انبار";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "MandeAkhar";
            this.Column11.HeaderText = "مانده آخر";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // txtMojodiAval
            // 
            // 
            // 
            // 
            this.txtMojodiAval.Border.Class = "TextBoxBorder";
            this.txtMojodiAval.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMojodiAval.Location = new System.Drawing.Point(12, 12);
            this.txtMojodiAval.MaxLength = 20;
            this.txtMojodiAval.Name = "txtMojodiAval";
            this.txtMojodiAval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMojodiAval.Size = new System.Drawing.Size(167, 23);
            this.txtMojodiAval.TabIndex = 2;
            this.txtMojodiAval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMojodiAval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMojodiAval_KeyPress);
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(552, 12);
            this.txtDate.Mask = "0000/00/00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(167, 23);
            this.txtDate.TabIndex = 0;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.DoubleClick += new System.EventHandler(this.txtDate_DoubleClick);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(185, 14);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(111, 18);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "موجودی اول وقت : ";
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(558, 43);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(44, 18);
            this.labelX3.TabIndex = 16;
            this.labelX3.Text = "تولید : ";
            // 
            // txtTolid
            // 
            // 
            // 
            // 
            this.txtTolid.Border.Class = "TextBoxBorder";
            this.txtTolid.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTolid.Location = new System.Drawing.Point(385, 42);
            this.txtTolid.MaxLength = 20;
            this.txtTolid.Name = "txtTolid";
            this.txtTolid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTolid.Size = new System.Drawing.Size(167, 23);
            this.txtTolid.TabIndex = 3;
            this.txtTolid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTolid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMojodiAval_KeyPress);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(674, 72);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(63, 18);
            this.labelX4.TabIndex = 18;
            this.labelX4.Text = "جمع کل : ";
            // 
            // txtJamKol
            // 
            // 
            // 
            // 
            this.txtJamKol.Border.Class = "TextBoxBorder";
            this.txtJamKol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJamKol.Location = new System.Drawing.Point(495, 70);
            this.txtJamKol.MaxLength = 20;
            this.txtJamKol.Name = "txtJamKol";
            this.txtJamKol.ReadOnly = true;
            this.txtJamKol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJamKol.Size = new System.Drawing.Size(167, 23);
            this.txtJamKol.TabIndex = 5;
            this.txtJamKol.Text = "0";
            this.txtJamKol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(289, 43);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(90, 18);
            this.labelX5.TabIndex = 20;
            this.labelX5.Text = "تحویل به انبار : ";
            // 
            // txtTahvilAnbar
            // 
            // 
            // 
            // 
            this.txtTahvilAnbar.Border.Class = "TextBoxBorder";
            this.txtTahvilAnbar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTahvilAnbar.Location = new System.Drawing.Point(116, 42);
            this.txtTahvilAnbar.MaxLength = 20;
            this.txtTahvilAnbar.Name = "txtTahvilAnbar";
            this.txtTahvilAnbar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTahvilAnbar.Size = new System.Drawing.Size(167, 23);
            this.txtTahvilAnbar.TabIndex = 4;
            this.txtTahvilAnbar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTahvilAnbar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMojodiAval_KeyPress);
            this.txtTahvilAnbar.Leave += new System.EventHandler(this.txtTahvilAnbar_Leave);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(394, 71);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(95, 18);
            this.labelX6.TabIndex = 22;
            this.labelX6.Text = "مانده آخر وقت : ";
            // 
            // txtMandeAkhar
            // 
            // 
            // 
            // 
            this.txtMandeAkhar.Border.Class = "TextBoxBorder";
            this.txtMandeAkhar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMandeAkhar.Location = new System.Drawing.Point(221, 70);
            this.txtMandeAkhar.MaxLength = 20;
            this.txtMandeAkhar.Name = "txtMandeAkhar";
            this.txtMandeAkhar.ReadOnly = true;
            this.txtMandeAkhar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMandeAkhar.Size = new System.Drawing.Size(167, 23);
            this.txtMandeAkhar.TabIndex = 6;
            this.txtMandeAkhar.Text = "0";
            this.txtMandeAkhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMandeAkhar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMojodiAval_KeyPress);
            // 
            // cmbxPipeLine
            // 
            this.cmbxPipeLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPipeLine.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbxPipeLine.FormattingEnabled = true;
            this.cmbxPipeLine.Location = new System.Drawing.Point(305, 12);
            this.cmbxPipeLine.Name = "cmbxPipeLine";
            this.cmbxPipeLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxPipeLine.Size = new System.Drawing.Size(167, 24);
            this.cmbxPipeLine.TabIndex = 1;
            this.cmbxPipeLine.SelectedIndexChanged += new System.EventHandler(this.cmbxPipeLine_SelectedIndexChanged);
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(481, 14);
            this.labelX10.Name = "labelX10";
            this.labelX10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX10.Size = new System.Drawing.Size(56, 18);
            this.labelX10.TabIndex = 42;
            this.labelX10.Text = "نام خط : ";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(12, 71);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(80, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "لغو";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate.Location = new System.Drawing.Point(665, 48);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(54, 18);
            this.lblDate.TabIndex = 43;
            this.lblDate.Text = "-----------";
            this.lblDate.Visible = false;
            // 
            // chbxAmarKhat
            // 
            // 
            // 
            // 
            this.chbxAmarKhat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.chbxAmarKhat.Location = new System.Drawing.Point(12, 42);
            this.chbxAmarKhat.Name = "chbxAmarKhat";
            this.chbxAmarKhat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbxAmarKhat.Size = new System.Drawing.Size(65, 23);
            this.chbxAmarKhat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.chbxAmarKhat.TabIndex = 44;
            this.chbxAmarKhat.Text = "آمار خط";
            this.chbxAmarKhat.CheckedChanged += new System.EventHandler(this.chbxAmarKhat_CheckedChanged);
            // 
            // frmTolidHalabGhoti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 252);
            this.Controls.Add(this.chbxAmarKhat);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.cmbxPipeLine);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtMandeAkhar);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtTahvilAnbar);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtJamKol);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtTolid);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtMojodiAval);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvTolid);
            this.Controls.Add(this.btnRegister);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmTolidHalabGhoti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آمار تولیدات";
            this.Load += new System.EventHandler(this.frmTolidHalabGhoti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTolid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnRegister;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTolid;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMojodiAval;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTolid;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtJamKol;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTahvilAnbar;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMandeAkhar;
        private System.Windows.Forms.ComboBox cmbxPipeLine;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.DotNetBar.Controls.CheckBoxX chbxAmarKhat;
    }
}