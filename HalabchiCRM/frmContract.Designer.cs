namespace HalabchiCRM
{
    partial class frmContract
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
            this.txtContractID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvAddType = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtCustomerID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtContractTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtContractDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnAddType = new DevComponents.DotNetBar.ButtonX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddType)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContractID
            // 
            // 
            // 
            // 
            this.txtContractID.Border.Class = "TextBoxBorder";
            this.txtContractID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContractID.Location = new System.Drawing.Point(272, 11);
            this.txtContractID.MaxLength = 10;
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractID.Size = new System.Drawing.Size(154, 23);
            this.txtContractID.TabIndex = 1;
            this.txtContractID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(432, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(92, 18);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "شماره قرارداد : ";
            // 
            // dgvAddType
            // 
            this.dgvAddType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAddType.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAddType.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvAddType.Location = new System.Drawing.Point(7, 176);
            this.dgvAddType.Name = "dgvAddType";
            this.dgvAddType.Size = new System.Drawing.Size(517, 150);
            this.dgvAddType.TabIndex = 7;
            // 
            // txtCustomerID
            // 
            // 
            // 
            // 
            this.txtCustomerID.Border.Class = "TextBoxBorder";
            this.txtCustomerID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtCustomerID.Location = new System.Drawing.Point(7, 12);
            this.txtCustomerID.MaxLength = 10;
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCustomerID.Size = new System.Drawing.Size(154, 23);
            this.txtCustomerID.TabIndex = 2;
            this.txtCustomerID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(167, 13);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(100, 18);
            this.labelX2.TabIndex = 4;
            this.labelX2.Text = "شماره مشتری : ";
            // 
            // txtContractTitle
            // 
            // 
            // 
            // 
            this.txtContractTitle.Border.Class = "TextBoxBorder";
            this.txtContractTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContractTitle.Location = new System.Drawing.Point(7, 41);
            this.txtContractTitle.MaxLength = 100;
            this.txtContractTitle.Name = "txtContractTitle";
            this.txtContractTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractTitle.Size = new System.Drawing.Size(154, 23);
            this.txtContractTitle.TabIndex = 4;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(167, 42);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(87, 18);
            this.labelX3.TabIndex = 8;
            this.labelX3.Text = "عنوان قرارداد : ";
            // 
            // txtContractDate
            // 
            // 
            // 
            // 
            this.txtContractDate.Border.Class = "TextBoxBorder";
            this.txtContractDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContractDate.Location = new System.Drawing.Point(272, 40);
            this.txtContractDate.MaxLength = 10;
            this.txtContractDate.Name = "txtContractDate";
            this.txtContractDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractDate.Size = new System.Drawing.Size(154, 23);
            this.txtContractDate.TabIndex = 3;
            this.txtContractDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContractDate.WatermarkText = "__/__/____";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(432, 41);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(82, 18);
            this.labelX4.TabIndex = 6;
            this.labelX4.Text = "تاریخ قرارداد : ";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(7, 65);
            this.labelX5.Name = "labelX5";
            this.labelX5.Size = new System.Drawing.Size(509, 62);
            this.labelX5.TabIndex = 8;
            this.labelX5.Text = "مشخصات مشتری وارد شده";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnAddType
            // 
            this.btnAddType.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddType.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddType.Location = new System.Drawing.Point(449, 133);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(75, 37);
            this.btnAddType.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddType.TabIndex = 5;
            this.btnAddType.Text = "مفاد قرارداد";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(449, 332);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 37);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "ثبت قرارداد";
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 371);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtContractTitle);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtContractDate);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtContractID);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.dgvAddType);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قرارداد ها";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddType)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvAddType;
        public DevComponents.DotNetBar.Controls.TextBoxX txtContractID;
        public DevComponents.DotNetBar.Controls.TextBoxX txtCustomerID;
        private DevComponents.DotNetBar.LabelX labelX2;
        public DevComponents.DotNetBar.Controls.TextBoxX txtContractTitle;
        private DevComponents.DotNetBar.LabelX labelX3;
        public DevComponents.DotNetBar.Controls.TextBoxX txtContractDate;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnAddType;
        private DevComponents.DotNetBar.ButtonX btnSave;
    }
}