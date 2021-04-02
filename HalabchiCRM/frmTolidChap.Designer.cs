namespace HalabchiCRM
{
    partial class frmTolidChap
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
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.txtDate = new System.Windows.Forms.MaskedTextBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtTedadVorodi = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtTedadChapShode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtChapAval = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtFider = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtVerni = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtChapDovom = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtJamkonAKhar = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtKore = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.dgvChap = new DevComponents.DotNetBar.Controls.DataGridViewX();
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
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            this.btnRegister = new DevComponents.DotNetBar.ButtonX();
            this.txtJameKol = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.cExport = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnExportContext = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExport)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate.Location = new System.Drawing.Point(7, 43);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(54, 18);
            this.lblDate.TabIndex = 46;
            this.lblDate.Text = "-----------";
            this.lblDate.Visible = false;
            // 
            // txtDate
            // 
            this.txtDate.Location = new System.Drawing.Point(711, 12);
            this.txtDate.Mask = "0000/00/00";
            this.txtDate.Name = "txtDate";
            this.txtDate.Size = new System.Drawing.Size(167, 23);
            this.txtDate.TabIndex = 0;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDate.DoubleClick += new System.EventHandler(this.txtDate_DoubleClick);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(884, 14);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(44, 18);
            this.labelX1.TabIndex = 45;
            this.labelX1.Text = "تاریخ : ";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(545, 14);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(160, 18);
            this.labelX2.TabIndex = 47;
            this.labelX2.Text = "تعداد بندل ورودی (به برگ) : ";
            // 
            // txtTedadVorodi
            // 
            // 
            // 
            // 
            this.txtTedadVorodi.Border.Class = "TextBoxBorder";
            this.txtTedadVorodi.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTedadVorodi.Location = new System.Drawing.Point(372, 12);
            this.txtTedadVorodi.MaxLength = 20;
            this.txtTedadVorodi.Name = "txtTedadVorodi";
            this.txtTedadVorodi.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTedadVorodi.Size = new System.Drawing.Size(167, 23);
            this.txtTedadVorodi.TabIndex = 1;
            this.txtTedadVorodi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTedadVorodi.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTedadVorodi_KeyPress);
            // 
            // txtTedadChapShode
            // 
            // 
            // 
            // 
            this.txtTedadChapShode.Border.Class = "TextBoxBorder";
            this.txtTedadChapShode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTedadChapShode.Location = new System.Drawing.Point(12, 12);
            this.txtTedadChapShode.MaxLength = 20;
            this.txtTedadChapShode.Name = "txtTedadChapShode";
            this.txtTedadChapShode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTedadChapShode.Size = new System.Drawing.Size(167, 23);
            this.txtTedadChapShode.TabIndex = 2;
            this.txtTedadChapShode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTedadChapShode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTedadVorodi_KeyPress);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(185, 14);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(180, 18);
            this.labelX3.TabIndex = 49;
            this.labelX3.Text = "تعداد بندل چاپ شده (به برگ) : ";
            // 
            // txtChapAval
            // 
            // 
            // 
            // 
            this.txtChapAval.Border.Class = "TextBoxBorder";
            this.txtChapAval.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChapAval.Location = new System.Drawing.Point(348, 41);
            this.txtChapAval.MaxLength = 20;
            this.txtChapAval.Name = "txtChapAval";
            this.txtChapAval.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChapAval.Size = new System.Drawing.Size(167, 23);
            this.txtChapAval.TabIndex = 4;
            this.txtChapAval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChapAval.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTedadVorodi_KeyPress);
            this.txtChapAval.Leave += new System.EventHandler(this.txtJamkonAKhar_Leave);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(521, 43);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(100, 18);
            this.labelX4.TabIndex = 53;
            this.labelX4.Text = "چاپ مرحله اول : ";
            // 
            // txtFider
            // 
            // 
            // 
            // 
            this.txtFider.Border.Class = "TextBoxBorder";
            this.txtFider.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFider.Location = new System.Drawing.Point(627, 41);
            this.txtFider.MaxLength = 20;
            this.txtFider.Name = "txtFider";
            this.txtFider.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFider.Size = new System.Drawing.Size(167, 23);
            this.txtFider.TabIndex = 3;
            this.txtFider.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFider.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTedadVorodi_KeyPress);
            this.txtFider.Leave += new System.EventHandler(this.txtJamkonAKhar_Leave);
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(800, 43);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(41, 18);
            this.labelX5.TabIndex = 51;
            this.labelX5.Text = "فیدر : ";
            // 
            // txtVerni
            // 
            // 
            // 
            // 
            this.txtVerni.Border.Class = "TextBoxBorder";
            this.txtVerni.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtVerni.Location = new System.Drawing.Point(627, 70);
            this.txtVerni.MaxLength = 20;
            this.txtVerni.Name = "txtVerni";
            this.txtVerni.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtVerni.Size = new System.Drawing.Size(167, 23);
            this.txtVerni.TabIndex = 6;
            this.txtVerni.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVerni.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTedadVorodi_KeyPress);
            this.txtVerni.Leave += new System.EventHandler(this.txtJamkonAKhar_Leave);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(800, 72);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(71, 18);
            this.labelX6.TabIndex = 57;
            this.labelX6.Text = "ورنی زنی : ";
            // 
            // txtChapDovom
            // 
            // 
            // 
            // 
            this.txtChapDovom.Border.Class = "TextBoxBorder";
            this.txtChapDovom.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtChapDovom.Location = new System.Drawing.Point(67, 41);
            this.txtChapDovom.MaxLength = 20;
            this.txtChapDovom.Name = "txtChapDovom";
            this.txtChapDovom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtChapDovom.Size = new System.Drawing.Size(167, 23);
            this.txtChapDovom.TabIndex = 5;
            this.txtChapDovom.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtChapDovom.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTedadVorodi_KeyPress);
            this.txtChapDovom.Leave += new System.EventHandler(this.txtJamkonAKhar_Leave);
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(240, 43);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(102, 18);
            this.labelX7.TabIndex = 55;
            this.labelX7.Text = "چاپ مرحله دوم : ";
            // 
            // txtJamkonAKhar
            // 
            // 
            // 
            // 
            this.txtJamkonAKhar.Border.Class = "TextBoxBorder";
            this.txtJamkonAKhar.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJamkonAKhar.Location = new System.Drawing.Point(67, 71);
            this.txtJamkonAKhar.MaxLength = 20;
            this.txtJamkonAKhar.Name = "txtJamkonAKhar";
            this.txtJamkonAKhar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJamkonAKhar.Size = new System.Drawing.Size(167, 23);
            this.txtJamkonAKhar.TabIndex = 8;
            this.txtJamkonAKhar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtJamkonAKhar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTedadVorodi_KeyPress);
            this.txtJamkonAKhar.Leave += new System.EventHandler(this.txtJamkonAKhar_Leave);
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(240, 73);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(85, 18);
            this.labelX8.TabIndex = 61;
            this.labelX8.Text = "جمع کن آخر : ";
            // 
            // txtKore
            // 
            // 
            // 
            // 
            this.txtKore.Border.Class = "TextBoxBorder";
            this.txtKore.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtKore.Location = new System.Drawing.Point(348, 70);
            this.txtKore.MaxLength = 20;
            this.txtKore.Name = "txtKore";
            this.txtKore.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtKore.Size = new System.Drawing.Size(167, 23);
            this.txtKore.TabIndex = 7;
            this.txtKore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtKore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTedadVorodi_KeyPress);
            this.txtKore.Leave += new System.EventHandler(this.txtJamkonAKhar_Leave);
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(521, 72);
            this.labelX9.Name = "labelX9";
            this.labelX9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX9.Size = new System.Drawing.Size(42, 18);
            this.labelX9.TabIndex = 59;
            this.labelX9.Text = "کوره : ";
            // 
            // dgvChap
            // 
            this.dgvChap.AllowUserToAddRows = false;
            this.dgvChap.AllowUserToDeleteRows = false;
            this.dgvChap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.Column11,
            this.Column12,
            this.Column13});
            this.cExport.SetContextMenuEx(this.dgvChap, this.btnExportContext);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvChap.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvChap.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvChap.Location = new System.Drawing.Point(12, 129);
            this.dgvChap.Name = "dgvChap";
            this.dgvChap.ReadOnly = true;
            this.dgvChap.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvChap.Size = new System.Drawing.Size(916, 227);
            this.dgvChap.TabIndex = 11;
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
            this.Column6.DataPropertyName = "TedadVorodi";
            this.Column6.HeaderText = "تعداد بندل ورودی";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "TedadChapShode";
            this.Column7.HeaderText = "تعداد بندل چاپ شده";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Fider";
            this.Column8.HeaderText = "فیدر";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 90;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "ChapAval";
            this.Column9.HeaderText = "چاپ اول";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 95;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "ChapDovom";
            this.Column10.HeaderText = "چاپ دوم";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            this.Column10.Width = 95;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Verni";
            this.Column11.HeaderText = "ورنی";
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            this.Column11.Width = 95;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "Kore";
            this.Column12.HeaderText = "کوره";
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            this.Column12.Width = 95;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "JamkonAkhar";
            this.Column13.HeaderText = "جمع کن";
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Width = 90;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(67, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "لغو";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegister.Location = new System.Drawing.Point(152, 100);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(82, 23);
            this.btnRegister.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegister.TabIndex = 9;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtJameKol
            // 
            // 
            // 
            // 
            this.txtJameKol.Border.Class = "TextBoxBorder";
            this.txtJameKol.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtJameKol.Location = new System.Drawing.Point(627, 100);
            this.txtJameKol.MaxLength = 20;
            this.txtJameKol.Name = "txtJameKol";
            this.txtJameKol.ReadOnly = true;
            this.txtJameKol.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtJameKol.Size = new System.Drawing.Size(167, 23);
            this.txtJameKol.TabIndex = 62;
            this.txtJameKol.Text = "0";
            this.txtJameKol.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(800, 102);
            this.labelX10.Name = "labelX10";
            this.labelX10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX10.Size = new System.Drawing.Size(63, 18);
            this.labelX10.TabIndex = 63;
            this.labelX10.Text = "جمع کل : ";
            // 
            // cExport
            // 
            this.cExport.AntiAlias = true;
            this.cExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cExport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExportContext});
            this.cExport.Location = new System.Drawing.Point(853, 41);
            this.cExport.Name = "cExport";
            this.cExport.Size = new System.Drawing.Size(75, 25);
            this.cExport.Stretch = true;
            this.cExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cExport.TabIndex = 64;
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
            // 
            // buttonItem2
            // 
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "PDF";
            // 
            // frmTolidChap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(937, 362);
            this.Controls.Add(this.cExport);
            this.Controls.Add(this.txtJameKol);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dgvChap);
            this.Controls.Add(this.txtJamkonAKhar);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtKore);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtVerni);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtChapDovom);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtChapAval);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtFider);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtTedadChapShode);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtTedadVorodi);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmTolidChap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "آمار تولید و ضایعات چاپ";
            this.Load += new System.EventHandler(this.frmTolidChap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvChap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX lblDate;
        private System.Windows.Forms.MaskedTextBox txtDate;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTedadVorodi;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTedadChapShode;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChapAval;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFider;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtVerni;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtChapDovom;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtJamkonAKhar;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.Controls.TextBoxX txtKore;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvChap;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private DevComponents.DotNetBar.ButtonX btnRegister;
        private DevComponents.DotNetBar.Controls.TextBoxX txtJameKol;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.ContextMenuBar cExport;
        private DevComponents.DotNetBar.ButtonItem btnExportContext;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
    }
}