namespace HalabchiCRM
{
    partial class frmAddProduct
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
            this.dgvProduct = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtProductCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbxUnit = new System.Windows.Forms.ComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbxSelectStorage = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtProductCount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.btnAddProduct = new DevComponents.DotNetBar.ButtonX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.lblLastCount = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.btnCancell = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvProduct.Location = new System.Drawing.Point(12, 100);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProduct.Size = new System.Drawing.Size(496, 211);
            this.dgvProduct.TabIndex = 7;
            this.dgvProduct.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProduct_CellContentDoubleClick);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "شماره";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StorageName";
            this.Column2.HeaderText = "نام انبار";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
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
            this.Column4.Width = 150;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProductUnit";
            this.Column5.HeaderText = "تعداد اولیه";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ProductType";
            this.Column6.HeaderText = "نوع واحد";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 80;
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.Border.Class = "TextBoxBorder";
            this.txtProductName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductName.Location = new System.Drawing.Point(12, 12);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductName.Size = new System.Drawing.Size(200, 23);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(218, 13);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(78, 18);
            this.labelX2.TabIndex = 12;
            this.labelX2.Text = "نام محصول : ";
            // 
            // txtProductCode
            // 
            // 
            // 
            // 
            this.txtProductCode.Border.Class = "TextBoxBorder";
            this.txtProductCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductCode.Location = new System.Drawing.Point(302, 12);
            this.txtProductCode.MaxLength = 10;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductCode.Size = new System.Drawing.Size(124, 23);
            this.txtProductCode.TabIndex = 0;
            this.txtProductCode.TextChanged += new System.EventHandler(this.txtProductCode_TextChanged);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(432, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(76, 18);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "کد محصول : ";
            // 
            // cmbxUnit
            // 
            this.cmbxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUnit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbxUnit.FormattingEnabled = true;
            this.cmbxUnit.Items.AddRange(new object[] {
            "کیلوگر",
            "عدد",
            "لیتر"});
            this.cmbxUnit.Location = new System.Drawing.Point(168, 41);
            this.cmbxUnit.Name = "cmbxUnit";
            this.cmbxUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxUnit.Size = new System.Drawing.Size(79, 24);
            this.cmbxUnit.TabIndex = 3;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(253, 42);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(43, 18);
            this.labelX4.TabIndex = 17;
            this.labelX4.Text = "واحد : ";
            // 
            // cmbxSelectStorage
            // 
            this.cmbxSelectStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectStorage.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbxSelectStorage.FormattingEnabled = true;
            this.cmbxSelectStorage.Location = new System.Drawing.Point(302, 40);
            this.cmbxSelectStorage.Name = "cmbxSelectStorage";
            this.cmbxSelectStorage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxSelectStorage.Size = new System.Drawing.Size(124, 24);
            this.cmbxSelectStorage.TabIndex = 2;
            this.cmbxSelectStorage.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectStorage_SelectedIndexChanged);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(432, 41);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(78, 18);
            this.labelX3.TabIndex = 16;
            this.labelX3.Text = "انتخاب انبار : ";
            // 
            // txtProductCount
            // 
            // 
            // 
            // 
            this.txtProductCount.Border.Class = "TextBoxBorder";
            this.txtProductCount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductCount.Location = new System.Drawing.Point(302, 69);
            this.txtProductCount.MaxLength = 20;
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductCount.Size = new System.Drawing.Size(124, 23);
            this.txtProductCount.TabIndex = 4;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(432, 70);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(78, 18);
            this.labelX5.TabIndex = 19;
            this.labelX5.Text = "مقدار جدید : ";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddProduct.Location = new System.Drawing.Point(104, 69);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(143, 23);
            this.btnAddProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "اضافه کردن";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(84, 42);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(71, 18);
            this.labelX6.TabIndex = 20;
            this.labelX6.Text = "مقدار انبار : ";
            // 
            // lblLastCount
            // 
            this.lblLastCount.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblLastCount.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblLastCount.Location = new System.Drawing.Point(12, 42);
            this.lblLastCount.Name = "lblLastCount";
            this.lblLastCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblLastCount.Size = new System.Drawing.Size(66, 18);
            this.lblLastCount.TabIndex = 21;
            this.lblLastCount.Text = "-----";
            this.lblLastCount.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Iranian Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX7.ForeColor = System.Drawing.Color.Red;
            this.labelX7.Location = new System.Drawing.Point(12, 317);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(496, 57);
            this.labelX7.TabIndex = 22;
            this.labelX7.Text = "! توجه !\r\nمقدار جدید وارد شده با مقدار انبار جمع میشود";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnCancell
            // 
            this.btnCancell.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancell.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancell.Location = new System.Drawing.Point(12, 69);
            this.btnCancell.Name = "btnCancell";
            this.btnCancell.Size = new System.Drawing.Size(86, 23);
            this.btnCancell.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancell.TabIndex = 6;
            this.btnCancell.Text = "لغو";
            this.btnCancell.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // frmAddProduct
            // 
            this.AcceptButton = this.btnAddProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 377);
            this.Controls.Add(this.btnCancell);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.lblLastCount);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProductCount);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmbxUnit);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cmbxSelectStorage);
            this.Controls.Add(this.labelX3);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmAddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اضافه کردن کالا";
            this.Load += new System.EventHandler(this.frmAddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvProduct;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductCode;
        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cmbxUnit;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ComboBox cmbxSelectStorage;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductCount;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.ButtonX btnAddProduct;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX lblLastCount;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.ButtonX btnCancell;
    }
}