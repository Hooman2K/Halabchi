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
            this.btnRegister = new DevComponents.DotNetBar.ButtonX();
            this.btnConfirm = new DevComponents.DotNetBar.ButtonX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.grbxContractInfo = new System.Windows.Forms.GroupBox();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.txtContractDate = new System.Windows.Forms.MaskedTextBox();
            this.lblInfo = new DevComponents.DotNetBar.LabelX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtContractTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtFactoryName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtContractID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.grbxType = new System.Windows.Forms.GroupBox();
            this.cmbxSelectStorage = new System.Windows.Forms.ComboBox();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtProductUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.lblProductCode = new DevComponents.DotNetBar.LabelX();
            this.dgvProduct = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnSetProduct = new DevComponents.DotNetBar.ButtonX();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.grbxContractInfo.SuspendLayout();
            this.grbxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegister.Location = new System.Drawing.Point(90, 199);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(424, 23);
            this.btnRegister.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "ثبت موقت";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnConfirm.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnConfirm.Location = new System.Drawing.Point(12, 486);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(502, 23);
            this.btnConfirm.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "ثبت نهایی";
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(12, 199);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "لغو";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // grbxContractInfo
            // 
            this.grbxContractInfo.BackColor = System.Drawing.Color.Transparent;
            this.grbxContractInfo.Controls.Add(this.lblDate);
            this.grbxContractInfo.Controls.Add(this.txtContractDate);
            this.grbxContractInfo.Controls.Add(this.lblInfo);
            this.grbxContractInfo.Controls.Add(this.labelX3);
            this.grbxContractInfo.Controls.Add(this.txtContractTitle);
            this.grbxContractInfo.Controls.Add(this.labelX4);
            this.grbxContractInfo.Controls.Add(this.labelX2);
            this.grbxContractInfo.Controls.Add(this.txtFactoryName);
            this.grbxContractInfo.Controls.Add(this.labelX1);
            this.grbxContractInfo.Controls.Add(this.txtContractID);
            this.grbxContractInfo.Location = new System.Drawing.Point(12, 12);
            this.grbxContractInfo.Name = "grbxContractInfo";
            this.grbxContractInfo.Size = new System.Drawing.Size(502, 179);
            this.grbxContractInfo.TabIndex = 0;
            this.grbxContractInfo.TabStop = false;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate.Location = new System.Drawing.Point(418, 76);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(54, 18);
            this.lblDate.TabIndex = 44;
            this.lblDate.Text = "-----------";
            this.lblDate.Visible = false;
            // 
            // txtContractDate
            // 
            this.txtContractDate.Location = new System.Drawing.Point(249, 50);
            this.txtContractDate.Mask = "0000/00/00";
            this.txtContractDate.Name = "txtContractDate";
            this.txtContractDate.Size = new System.Drawing.Size(143, 23);
            this.txtContractDate.TabIndex = 12;
            this.txtContractDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContractDate.DoubleClick += new System.EventHandler(this.txtContractDate_DoubleClick);
            // 
            // lblInfo
            // 
            // 
            // 
            // 
            this.lblInfo.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblInfo.Location = new System.Drawing.Point(6, 80);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblInfo.Size = new System.Drawing.Size(484, 71);
            this.lblInfo.TabIndex = 17;
            this.lblInfo.Text = "مشخصات مشتری";
            this.lblInfo.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(155, 52);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(87, 18);
            this.labelX3.TabIndex = 18;
            this.labelX3.Text = "عنوان قرارداد : ";
            // 
            // txtContractTitle
            // 
            // 
            // 
            // 
            this.txtContractTitle.Border.Class = "TextBoxBorder";
            this.txtContractTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContractTitle.Location = new System.Drawing.Point(6, 51);
            this.txtContractTitle.MaxLength = 100;
            this.txtContractTitle.Name = "txtContractTitle";
            this.txtContractTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractTitle.Size = new System.Drawing.Size(143, 23);
            this.txtContractTitle.TabIndex = 14;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(398, 52);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(82, 18);
            this.labelX4.TabIndex = 16;
            this.labelX4.Text = "تاریخ قرارداد : ";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(155, 23);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(77, 18);
            this.labelX2.TabIndex = 15;
            this.labelX2.Text = "نام کارخانه : ";
            // 
            // txtFactoryName
            // 
            // 
            // 
            // 
            this.txtFactoryName.Border.Class = "TextBoxBorder";
            this.txtFactoryName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFactoryName.Location = new System.Drawing.Point(6, 22);
            this.txtFactoryName.MaxLength = 50;
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFactoryName.Size = new System.Drawing.Size(143, 23);
            this.txtFactoryName.TabIndex = 11;
            this.txtFactoryName.Leave += new System.EventHandler(this.txtFactoryName_Leave);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(398, 23);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(92, 18);
            this.labelX1.TabIndex = 13;
            this.labelX1.Text = "شماره قرارداد : ";
            // 
            // txtContractID
            // 
            // 
            // 
            // 
            this.txtContractID.Border.Class = "TextBoxBorder";
            this.txtContractID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContractID.Location = new System.Drawing.Point(249, 22);
            this.txtContractID.MaxLength = 10;
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractID.Size = new System.Drawing.Size(143, 23);
            this.txtContractID.TabIndex = 10;
            this.txtContractID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grbxType
            // 
            this.grbxType.BackColor = System.Drawing.Color.Transparent;
            this.grbxType.Controls.Add(this.cmbxSelectStorage);
            this.grbxType.Controls.Add(this.labelX6);
            this.grbxType.Controls.Add(this.labelX5);
            this.grbxType.Controls.Add(this.txtProductName);
            this.grbxType.Controls.Add(this.labelX7);
            this.grbxType.Controls.Add(this.txtProductUnit);
            this.grbxType.Controls.Add(this.lblProductCode);
            this.grbxType.Controls.Add(this.dgvProduct);
            this.grbxType.Controls.Add(this.btnSetProduct);
            this.grbxType.Location = new System.Drawing.Point(12, 224);
            this.grbxType.Name = "grbxType";
            this.grbxType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.grbxType.Size = new System.Drawing.Size(502, 256);
            this.grbxType.TabIndex = 1;
            this.grbxType.TabStop = false;
            // 
            // cmbxSelectStorage
            // 
            this.cmbxSelectStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectStorage.FormattingEnabled = true;
            this.cmbxSelectStorage.Location = new System.Drawing.Point(12, 20);
            this.cmbxSelectStorage.Name = "cmbxSelectStorage";
            this.cmbxSelectStorage.Size = new System.Drawing.Size(401, 24);
            this.cmbxSelectStorage.TabIndex = 25;
            this.cmbxSelectStorage.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectStorage_SelectedIndexChanged);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(418, 20);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(78, 18);
            this.labelX6.TabIndex = 24;
            this.labelX6.Text = "انتخاب انبار : ";
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(418, 54);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(78, 18);
            this.labelX5.TabIndex = 23;
            this.labelX5.Text = "نام محصول : ";
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.Border.Class = "TextBoxBorder";
            this.txtProductName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductName.Location = new System.Drawing.Point(309, 52);
            this.txtProductName.MaxLength = 10;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductName.Size = new System.Drawing.Size(104, 23);
            this.txtProductName.TabIndex = 17;
            this.txtProductName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductName.Leave += new System.EventHandler(this.txtProductName_Leave);
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(180, 54);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(47, 18);
            this.labelX7.TabIndex = 22;
            this.labelX7.Text = "مقدار : ";
            // 
            // txtProductUnit
            // 
            // 
            // 
            // 
            this.txtProductUnit.Border.Class = "TextBoxBorder";
            this.txtProductUnit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductUnit.Location = new System.Drawing.Point(90, 53);
            this.txtProductUnit.MaxLength = 20;
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductUnit.Size = new System.Drawing.Size(84, 23);
            this.txtProductUnit.TabIndex = 18;
            this.txtProductUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductUnit_KeyPress);
            // 
            // lblProductCode
            // 
            // 
            // 
            // 
            this.lblProductCode.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblProductCode.Location = new System.Drawing.Point(233, 54);
            this.lblProductCode.Name = "lblProductCode";
            this.lblProductCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblProductCode.Size = new System.Drawing.Size(70, 18);
            this.lblProductCode.TabIndex = 21;
            this.lblProductCode.Text = "کد کالا : ---";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column6,
            this.Column3,
            this.Column4,
            this.Column5});
            this.contextMenuBar1.SetContextMenuEx(this.dgvProduct, this.buttonItem1);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvProduct.Location = new System.Drawing.Point(12, 82);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProduct.Size = new System.Drawing.Size(484, 168);
            this.dgvProduct.TabIndex = 20;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ContractID";
            this.Column1.HeaderText = "شماره قرارداد";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.HeaderText = "شماره مشتری";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FactoryName";
            this.Column6.HeaderText = "نام کارخانه";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ProductCode";
            this.Column3.HeaderText = "کد محصول";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProductName";
            this.Column4.HeaderText = "نام محصول";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 160;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProductUnit";
            this.Column5.HeaderText = "مقدار";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // btnSetProduct
            // 
            this.btnSetProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSetProduct.Location = new System.Drawing.Point(12, 54);
            this.btnSetProduct.Name = "btnSetProduct";
            this.btnSetProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSetProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSetProduct.TabIndex = 19;
            this.btnSetProduct.Text = "اضافه کردن";
            this.btnSetProduct.Click += new System.EventHandler(this.btnSetProduct_Click);
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar1.Location = new System.Drawing.Point(12, 169);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(75, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 24;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem2});
            this.buttonItem1.Text = "buttonItem1";
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "خذف از جدول";
            this.buttonItem2.Click += new System.EventHandler(this.buttonItem2_Click);
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 521);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.grbxType);
            this.Controls.Add(this.grbxContractInfo);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnRegister);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قرارداد ها";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmContract_FormClosing);
            this.Load += new System.EventHandler(this.frmContract_Load);
            this.grbxContractInfo.ResumeLayout(false);
            this.grbxContractInfo.PerformLayout();
            this.grbxType.ResumeLayout(false);
            this.grbxType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX btnRegister;
        private DevComponents.DotNetBar.ButtonX btnConfirm;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.GroupBox grbxContractInfo;
        private DevComponents.DotNetBar.LabelX lblInfo;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContractTitle;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFactoryName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContractID;
        private System.Windows.Forms.GroupBox grbxType;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductUnit;
        private DevComponents.DotNetBar.LabelX lblProductCode;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvProduct;
        private DevComponents.DotNetBar.ButtonX btnSetProduct;
        private System.Windows.Forms.MaskedTextBox txtContractDate;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.ComboBox cmbxSelectStorage;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX lblDate;
    }
}