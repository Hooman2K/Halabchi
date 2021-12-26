namespace HalabchiCRM
{
    partial class frmProductionFormula
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.dgvFormula = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbxSelectStorage = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtProductUnitPerOne = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtFormulaName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAddFormula = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.cmbxProductName = new System.Windows.Forms.ComboBox();
            this.grbxProductionFormula = new System.Windows.Forms.GroupBox();
            this.contextMenuBar1 = new DevComponents.DotNetBar.ContextMenuBar();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.DeleteF = new DevComponents.DotNetBar.ButtonItem();
            this.dgvProductionFormula = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtMaterial = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).BeginInit();
            this.grbxProductionFormula.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(6, 86);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(124, 28);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "اضافه کردن";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvFormula
            // 
            this.dgvFormula.AllowUserToAddRows = false;
            this.dgvFormula.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormula.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvFormula.EnableHeadersVisualStyles = false;
            this.dgvFormula.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFormula.Location = new System.Drawing.Point(6, 127);
            this.dgvFormula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFormula.Name = "dgvFormula";
            this.dgvFormula.ReadOnly = true;
            this.dgvFormula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvFormula.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.dgvFormula.Size = new System.Drawing.Size(406, 141);
            this.dgvFormula.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FormulaID";
            this.Column1.HeaderText = "شماره فرمول";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "ProductName";
            this.Column2.HeaderText = "نام محصول";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "MaterialName";
            this.Column3.HeaderText = "مواد اولیه";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 200;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProductUnitPerOne";
            this.Column4.HeaderText = "مقدار مورد نیاز";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // cmbxSelectStorage
            // 
            this.cmbxSelectStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectStorage.FormattingEnabled = true;
            this.cmbxSelectStorage.Location = new System.Drawing.Point(272, 23);
            this.cmbxSelectStorage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxSelectStorage.Name = "cmbxSelectStorage";
            this.cmbxSelectStorage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxSelectStorage.Size = new System.Drawing.Size(140, 24);
            this.cmbxSelectStorage.TabIndex = 2;
            this.cmbxSelectStorage.SelectedIndexChanged += new System.EventHandler(this.cmbxSelectStorage_SelectedIndexChanged);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(418, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(78, 18);
            this.labelX1.TabIndex = 4;
            this.labelX1.Text = "انتخاب انبار : ";
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(418, 56);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(69, 18);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "مواد اولیه : ";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(136, 54);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(75, 23);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "مقدار نیاز : ";
            // 
            // txtProductUnitPerOne
            // 
            // 
            // 
            // 
            this.txtProductUnitPerOne.Border.Class = "TextBoxBorder";
            this.txtProductUnitPerOne.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductUnitPerOne.Location = new System.Drawing.Point(6, 55);
            this.txtProductUnitPerOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductUnitPerOne.MaxLength = 20;
            this.txtProductUnitPerOne.Name = "txtProductUnitPerOne";
            this.txtProductUnitPerOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductUnitPerOne.Size = new System.Drawing.Size(124, 23);
            this.txtProductUnitPerOne.TabIndex = 5;
            this.txtProductUnitPerOne.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductUnitPerOne_KeyPress);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(418, 183);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(84, 18);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "جدول فرمول : ";
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(136, 276);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(124, 28);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(180, 23);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(75, 23);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "نام محصول : ";
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(424, 14);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(70, 18);
            this.labelX7.TabIndex = 16;
            this.labelX7.Text = "نام فرمول : ";
            // 
            // txtFormulaName
            // 
            // 
            // 
            // 
            this.txtFormulaName.Border.Class = "TextBoxBorder";
            this.txtFormulaName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFormulaName.Location = new System.Drawing.Point(142, 13);
            this.txtFormulaName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFormulaName.MaxLength = 50;
            this.txtFormulaName.Name = "txtFormulaName";
            this.txtFormulaName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFormulaName.Size = new System.Drawing.Size(276, 23);
            this.txtFormulaName.TabIndex = 0;
            // 
            // btnAddFormula
            // 
            this.btnAddFormula.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAddFormula.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAddFormula.Location = new System.Drawing.Point(12, 11);
            this.btnAddFormula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddFormula.Name = "btnAddFormula";
            this.btnAddFormula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddFormula.Size = new System.Drawing.Size(124, 28);
            this.btnAddFormula.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAddFormula.TabIndex = 1;
            this.btnAddFormula.Text = "اضافه کردن";
            this.btnAddFormula.Click += new System.EventHandler(this.btnAddFormula_Click);
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.Red;
            this.labelX8.Location = new System.Drawing.Point(136, 86);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(366, 28);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "توجه : مقدار مورد نیاز برای ساخت 1 واحد و به گرم میباشد!!";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(6, 276);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(124, 28);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "لغو";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cmbxProductName
            // 
            this.cmbxProductName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxProductName.FormattingEnabled = true;
            this.cmbxProductName.Location = new System.Drawing.Point(6, 23);
            this.cmbxProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxProductName.Name = "cmbxProductName";
            this.cmbxProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxProductName.Size = new System.Drawing.Size(168, 24);
            this.cmbxProductName.TabIndex = 3;
            // 
            // grbxProductionFormula
            // 
            this.grbxProductionFormula.Controls.Add(this.txtMaterial);
            this.grbxProductionFormula.Controls.Add(this.cmbxProductName);
            this.grbxProductionFormula.Controls.Add(this.btnAdd);
            this.grbxProductionFormula.Controls.Add(this.dgvFormula);
            this.grbxProductionFormula.Controls.Add(this.btnCancel);
            this.grbxProductionFormula.Controls.Add(this.labelX8);
            this.grbxProductionFormula.Controls.Add(this.cmbxSelectStorage);
            this.grbxProductionFormula.Controls.Add(this.labelX1);
            this.grbxProductionFormula.Controls.Add(this.labelX2);
            this.grbxProductionFormula.Controls.Add(this.txtProductUnitPerOne);
            this.grbxProductionFormula.Controls.Add(this.btnSave);
            this.grbxProductionFormula.Controls.Add(this.labelX5);
            this.grbxProductionFormula.Controls.Add(this.labelX4);
            this.grbxProductionFormula.Controls.Add(this.labelX3);
            this.grbxProductionFormula.Location = new System.Drawing.Point(12, 46);
            this.grbxProductionFormula.Name = "grbxProductionFormula";
            this.grbxProductionFormula.Size = new System.Drawing.Size(515, 313);
            this.grbxProductionFormula.TabIndex = 1;
            this.grbxProductionFormula.TabStop = false;
            // 
            // contextMenuBar1
            // 
            this.contextMenuBar1.AntiAlias = true;
            this.contextMenuBar1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.contextMenuBar1.IsMaximized = false;
            this.contextMenuBar1.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1});
            this.contextMenuBar1.Location = new System.Drawing.Point(433, 454);
            this.contextMenuBar1.Name = "contextMenuBar1";
            this.contextMenuBar1.Size = new System.Drawing.Size(75, 25);
            this.contextMenuBar1.Stretch = true;
            this.contextMenuBar1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.contextMenuBar1.TabIndex = 18;
            this.contextMenuBar1.TabStop = false;
            this.contextMenuBar1.Text = "contextMenuBar1";
            // 
            // buttonItem1
            // 
            this.buttonItem1.AutoExpandOnClick = true;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.DeleteF});
            this.buttonItem1.Text = "buttonItem1";
            // 
            // DeleteF
            // 
            this.DeleteF.Name = "DeleteF";
            this.DeleteF.Text = "خذف فرمول";
            this.DeleteF.Click += new System.EventHandler(this.DeleteF_Click);
            // 
            // dgvProductionFormula
            // 
            this.dgvProductionFormula.AllowUserToAddRows = false;
            this.dgvProductionFormula.AllowUserToDeleteRows = false;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductionFormula.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvProductionFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductionFormula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column5,
            this.Column6});
            this.contextMenuBar1.SetContextMenuEx(this.dgvProductionFormula, this.buttonItem1);
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductionFormula.DefaultCellStyle = dataGridViewCellStyle11;
            this.dgvProductionFormula.EnableHeadersVisualStyles = false;
            this.dgvProductionFormula.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvProductionFormula.Location = new System.Drawing.Point(18, 366);
            this.dgvProductionFormula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductionFormula.Name = "dgvProductionFormula";
            this.dgvProductionFormula.ReadOnly = true;
            this.dgvProductionFormula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductionFormula.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dgvProductionFormula.Size = new System.Drawing.Size(406, 131);
            this.dgvProductionFormula.TabIndex = 17;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ID";
            this.Column5.HeaderText = "شماره";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "FormulaName";
            this.Column6.HeaderText = "نام فرمول";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 230;
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(430, 390);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(75, 78);
            this.labelX6.TabIndex = 18;
            this.labelX6.Text = "فرمول های\r\nموجود";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // txtMaterial
            // 
            // 
            // 
            // 
            this.txtMaterial.Border.Class = "TextBoxBorder";
            this.txtMaterial.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaterial.Location = new System.Drawing.Point(217, 54);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaterial.MaxLength = 50;
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMaterial.Size = new System.Drawing.Size(195, 23);
            this.txtMaterial.TabIndex = 4;
            // 
            // frmProductionFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 528);
            this.Controls.Add(this.contextMenuBar1);
            this.Controls.Add(this.dgvProductionFormula);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.grbxProductionFormula);
            this.Controls.Add(this.btnAddFormula);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtFormulaName);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmProductionFormula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرمول ساخت کالا";
            this.Load += new System.EventHandler(this.frmProductionFormula_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).EndInit();
            this.grbxProductionFormula.ResumeLayout(false);
            this.grbxProductionFormula.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contextMenuBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFormula;
        private System.Windows.Forms.ComboBox cmbxSelectStorage;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductUnitPerOne;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFormulaName;
        private DevComponents.DotNetBar.ButtonX btnAddFormula;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.ComboBox cmbxProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox grbxProductionFormula;
        private DevComponents.DotNetBar.ContextMenuBar contextMenuBar1;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem DeleteF;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvProductionFormula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaterial;
    }
}