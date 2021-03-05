namespace HalabchiCRM
{
    partial class frmProduction
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
            this.txtLastCount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnAddProduct = new DevComponents.DotNetBar.ButtonX();
            this.txtProductCount = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.dgvProduct = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtProductCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cmbxUnit = new System.Windows.Forms.ComboBox();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.cmbxSelectStorage = new System.Windows.Forms.ComboBox();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.lblHalab = new DevComponents.DotNetBar.LabelX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.cmbxPipeLine = new System.Windows.Forms.ComboBox();
            this.cmbxFormula = new System.Windows.Forms.ComboBox();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnAdds = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtLastCount
            // 
            // 
            // 
            // 
            this.txtLastCount.Border.Class = "TextBoxBorder";
            this.txtLastCount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtLastCount.Location = new System.Drawing.Point(12, 41);
            this.txtLastCount.MaxLength = 20;
            this.txtLastCount.Name = "txtLastCount";
            this.txtLastCount.ReadOnly = true;
            this.txtLastCount.Size = new System.Drawing.Size(116, 23);
            this.txtLastCount.TabIndex = 4;
            this.txtLastCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX7
            // 
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Font = new System.Drawing.Font("Iranian Sans", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX7.ForeColor = System.Drawing.Color.Red;
            this.labelX7.Location = new System.Drawing.Point(12, 354);
            this.labelX7.Name = "labelX7";
            this.labelX7.Size = new System.Drawing.Size(496, 57);
            this.labelX7.TabIndex = 38;
            this.labelX7.Text = "! توجه !\r\nمقدار جدید وارد شده با مقدار انبار جمع میشود";
            this.labelX7.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(123, 43);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(39, 18);
            this.labelX6.TabIndex = 37;
            this.labelX6.Text = "انبار : ";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddProduct.Location = new System.Drawing.Point(104, 101);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(143, 23);
            this.btnAddProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddProduct.TabIndex = 9;
            this.btnAddProduct.Text = "اضافه کردن";
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtProductCount
            // 
            // 
            // 
            // 
            this.txtProductCount.Border.Class = "TextBoxBorder";
            this.txtProductCount.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductCount.Location = new System.Drawing.Point(290, 101);
            this.txtProductCount.MaxLength = 20;
            this.txtProductCount.Name = "txtProductCount";
            this.txtProductCount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductCount.Size = new System.Drawing.Size(136, 23);
            this.txtProductCount.TabIndex = 7;
            this.txtProductCount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductCount_KeyPress);
            this.txtProductCount.Leave += new System.EventHandler(this.txtProductCount_Leave);
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(432, 103);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(78, 18);
            this.labelX5.TabIndex = 36;
            this.labelX5.Text = "مقدار جدید : ";
            // 
            // dgvProduct
            // 
            this.dgvProduct.AllowUserToAddRows = false;
            this.dgvProduct.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProduct.EnableHeadersVisualStyles = false;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvProduct.Location = new System.Drawing.Point(12, 136);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.ReadOnly = true;
            this.dgvProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProduct.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProduct.Size = new System.Drawing.Size(496, 211);
            this.dgvProduct.TabIndex = 11;
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
            // Column7
            // 
            this.Column7.DataPropertyName = "PipeLineName";
            this.Column7.HeaderText = "خط تولید";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
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
            this.labelX2.TabIndex = 33;
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
            // cmbxUnit
            // 
            this.cmbxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxUnit.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbxUnit.FormattingEnabled = true;
            this.cmbxUnit.Items.AddRange(new object[] {
            "کیلوگرم",
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
            this.labelX4.TabIndex = 35;
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
            this.labelX3.Location = new System.Drawing.Point(432, 43);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(78, 18);
            this.labelX3.TabIndex = 34;
            this.labelX3.Text = "انتخاب انبار : ";
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
            this.labelX1.TabIndex = 32;
            this.labelX1.Text = "کد محصول : ";
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.lblHalab);
            this.groupPanel1.Controls.Add(this.labelX8);
            this.groupPanel1.Location = new System.Drawing.Point(12, 417);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupPanel1.Size = new System.Drawing.Size(496, 162);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 39;
            this.groupPanel1.Text = "اطلاعات تولید";
            // 
            // lblHalab
            // 
            this.lblHalab.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.lblHalab.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblHalab.Font = new System.Drawing.Font("Iranian Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lblHalab.Location = new System.Drawing.Point(3, 27);
            this.lblHalab.Name = "lblHalab";
            this.lblHalab.Size = new System.Drawing.Size(484, 108);
            this.lblHalab.TabIndex = 2;
            this.lblHalab.Text = "-----";
            this.lblHalab.TextAlignment = System.Drawing.StringAlignment.Center;
            this.lblHalab.TextLineAlignment = System.Drawing.StringAlignment.Near;
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Font = new System.Drawing.Font("Iranian Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.labelX8.Location = new System.Drawing.Point(105, 3);
            this.labelX8.Name = "labelX8";
            this.labelX8.Size = new System.Drawing.Size(301, 18);
            this.labelX8.TabIndex = 0;
            this.labelX8.Text = "نیازمندی های ساخت برای مقدار محصول وارد شده";
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(432, 73);
            this.labelX10.Name = "labelX10";
            this.labelX10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX10.Size = new System.Drawing.Size(56, 18);
            this.labelX10.TabIndex = 40;
            this.labelX10.Text = "نام خط : ";
            // 
            // cmbxPipeLine
            // 
            this.cmbxPipeLine.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPipeLine.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbxPipeLine.FormattingEnabled = true;
            this.cmbxPipeLine.Items.AddRange(new object[] {
            "کیلوگر",
            "عدد",
            "لیتر"});
            this.cmbxPipeLine.Location = new System.Drawing.Point(253, 71);
            this.cmbxPipeLine.Name = "cmbxPipeLine";
            this.cmbxPipeLine.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxPipeLine.Size = new System.Drawing.Size(173, 24);
            this.cmbxPipeLine.TabIndex = 5;
            // 
            // cmbxFormula
            // 
            this.cmbxFormula.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFormula.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbxFormula.FormattingEnabled = true;
            this.cmbxFormula.Location = new System.Drawing.Point(12, 71);
            this.cmbxFormula.Name = "cmbxFormula";
            this.cmbxFormula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxFormula.Size = new System.Drawing.Size(173, 24);
            this.cmbxFormula.TabIndex = 6;
            this.cmbxFormula.SelectedIndexChanged += new System.EventHandler(this.cmbxFormula_SelectedIndexChanged);
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(189, 73);
            this.labelX12.Name = "labelX12";
            this.labelX12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX12.Size = new System.Drawing.Size(51, 18);
            this.labelX12.TabIndex = 43;
            this.labelX12.Text = "فرمول : ";
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(12, 101);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(86, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "لغو";
            this.btnCancel.Click += new System.EventHandler(this.btnCancell_Click);
            // 
            // btnAdds
            // 
            this.btnAdds.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdds.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdds.Location = new System.Drawing.Point(253, 101);
            this.btnAdds.Name = "btnAdds";
            this.btnAdds.Size = new System.Drawing.Size(31, 23);
            this.btnAdds.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdds.TabIndex = 8;
            this.btnAdds.Text = "+";
            this.btnAdds.Click += new System.EventHandler(this.btnAdds_Click);
            // 
            // frmProduction
            // 
            this.AcceptButton = this.btnAddProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 587);
            this.Controls.Add(this.btnAdds);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.cmbxFormula);
            this.Controls.Add(this.cmbxPipeLine);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.groupPanel1);
            this.Controls.Add(this.txtLastCount);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtProductCount);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.cmbxUnit);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.cmbxSelectStorage);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmProduction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تولید";
            this.Load += new System.EventHandler(this.frmProduction_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtLastCount;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnAddProduct;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductCount;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvProduct;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductCode;
        private System.Windows.Forms.ComboBox cmbxUnit;
        private DevComponents.DotNetBar.LabelX labelX4;
        private System.Windows.Forms.ComboBox cmbxSelectStorage;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX lblHalab;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX10;
        private System.Windows.Forms.ComboBox cmbxPipeLine;
        private System.Windows.Forms.ComboBox cmbxFormula;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnAdds;
    }
}