
namespace HalabchiCRM
{
    partial class frmReportErsalKala
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
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.checkBoxX1 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.cmbxFactory = new System.Windows.Forms.ComboBox();
            this.dgvErsal = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.chbxItemContract = new System.Windows.Forms.ComboBox();
            this.checkBoxX2 = new DevComponents.DotNetBar.Controls.CheckBoxX();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.cExport = new DevComponents.DotNetBar.ContextMenuBar();
            this.btnExportContext = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvErsal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(506, 15);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(70, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "نام شرکت : ";
            // 
            // checkBoxX1
            // 
            this.checkBoxX1.AutoSize = true;
            // 
            // 
            // 
            this.checkBoxX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX1.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX1.Location = new System.Drawing.Point(401, 42);
            this.checkBoxX1.Name = "checkBoxX1";
            this.checkBoxX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxX1.Size = new System.Drawing.Size(175, 18);
            this.checkBoxX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX1.TabIndex = 2;
            this.checkBoxX1.Text = "بر اساس تمامی مفاد قرارداد";
            // 
            // cmbxFactory
            // 
            this.cmbxFactory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxFactory.FormattingEnabled = true;
            this.cmbxFactory.Location = new System.Drawing.Point(320, 12);
            this.cmbxFactory.Name = "cmbxFactory";
            this.cmbxFactory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxFactory.Size = new System.Drawing.Size(180, 24);
            this.cmbxFactory.TabIndex = 0;
            // 
            // dgvErsal
            // 
            this.dgvErsal.AllowUserToAddRows = false;
            this.dgvErsal.AllowUserToDeleteRows = false;
            this.dgvErsal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvErsal.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.cExport.SetContextMenuEx(this.dgvErsal, this.btnExportContext);
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvErsal.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvErsal.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvErsal.Location = new System.Drawing.Point(12, 67);
            this.dgvErsal.Name = "dgvErsal";
            this.dgvErsal.ReadOnly = true;
            this.dgvErsal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvErsal.Size = new System.Drawing.Size(616, 169);
            this.dgvErsal.TabIndex = 3;
            // 
            // chbxItemContract
            // 
            this.chbxItemContract.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.chbxItemContract.FormattingEnabled = true;
            this.chbxItemContract.Location = new System.Drawing.Point(51, 39);
            this.chbxItemContract.Name = "chbxItemContract";
            this.chbxItemContract.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chbxItemContract.Size = new System.Drawing.Size(181, 24);
            this.chbxItemContract.TabIndex = 4;
            // 
            // checkBoxX2
            // 
            this.checkBoxX2.AutoSize = true;
            // 
            // 
            // 
            this.checkBoxX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.checkBoxX2.CheckBoxStyle = DevComponents.DotNetBar.eCheckBoxStyle.RadioButton;
            this.checkBoxX2.Location = new System.Drawing.Point(234, 42);
            this.checkBoxX2.Name = "checkBoxX2";
            this.checkBoxX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBoxX2.Size = new System.Drawing.Size(155, 18);
            this.checkBoxX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.checkBoxX2.TabIndex = 3;
            this.checkBoxX2.Text = "بر اساس ریز اقلام موجود";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(51, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comboBox1.Size = new System.Drawing.Size(181, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(234, 15);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(80, 18);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "عنوان قرارداد : ";
            // 
            // cExport
            // 
            this.cExport.AntiAlias = true;
            this.cExport.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cExport.IsMaximized = false;
            this.cExport.Items.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnExportContext});
            this.cExport.Location = new System.Drawing.Point(23, 102);
            this.cExport.Name = "cExport";
            this.cExport.Size = new System.Drawing.Size(75, 25);
            this.cExport.Stretch = true;
            this.cExport.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cExport.TabIndex = 66;
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
            this.buttonItem1});
            this.buttonItem3.Text = "خروجی";
            // 
            // buttonItem1
            // 
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "از جدول";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "شماره";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn2.HeaderText = "شماره مشتری";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ContractID";
            this.dataGridViewTextBoxColumn3.HeaderText = "شماره قرارداد";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ProductCode";
            this.dataGridViewTextBoxColumn4.HeaderText = "کد محصول";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "ProductName";
            this.dataGridViewTextBoxColumn5.HeaderText = "نام محصول";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "TarikhErsal";
            this.dataGridViewTextBoxColumn6.HeaderText = "تاریخ ارسال";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "MeghdareErsal";
            this.dataGridViewTextBoxColumn7.HeaderText = "بار ارسالی";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Mandeh";
            this.dataGridViewTextBoxColumn8.HeaderText = "مانده";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
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
            this.Column2.DataPropertyName = "CustomerID";
            this.Column2.HeaderText = "شماره مشتری";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "ContractID";
            this.Column3.HeaderText = "شماره قرارداد";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ProductCode";
            this.Column4.HeaderText = "کد محصول";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProductName";
            this.Column5.HeaderText = "نام محصول";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TarikhErsal";
            this.Column6.HeaderText = "تاریخ ارسال";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "MeghdareErsal";
            this.Column7.HeaderText = "بار ارسالی";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Mandeh";
            this.Column8.HeaderText = "مانده";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // frmReportErsalKala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 237);
            this.Controls.Add(this.cExport);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.chbxItemContract);
            this.Controls.Add(this.checkBoxX2);
            this.Controls.Add(this.dgvErsal);
            this.Controls.Add(this.cmbxFactory);
            this.Controls.Add(this.checkBoxX1);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmReportErsalKala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش ارسال کالا";
            ((System.ComponentModel.ISupportInitialize)(this.dgvErsal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cExport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX1;
        private System.Windows.Forms.ComboBox cmbxFactory;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvErsal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.ComboBox chbxItemContract;
        private DevComponents.DotNetBar.Controls.CheckBoxX checkBoxX2;
        private System.Windows.Forms.ComboBox comboBox1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.ContextMenuBar cExport;
        private DevComponents.DotNetBar.ButtonItem btnExportContext;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}