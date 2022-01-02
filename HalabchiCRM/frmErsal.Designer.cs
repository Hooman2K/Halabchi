
namespace HalabchiCRM
{
    partial class frmErsal
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvContract = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnErsal = new DevComponents.DotNetBar.ButtonX();
            this.txtErsali = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtErsalShode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtMande = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtContractDate = new System.Windows.Forms.MaskedTextBox();
            this.lblDate = new DevComponents.DotNetBar.LabelX();
            this.btnCancel = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AllowUserToDeleteRows = false;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContract.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvContract.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvContract.Location = new System.Drawing.Point(12, 12);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.ReadOnly = true;
            this.dgvContract.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvContract.Size = new System.Drawing.Size(616, 150);
            this.dgvContract.TabIndex = 0;
            this.dgvContract.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContract_CellDoubleClick);
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
            this.Column4.DataPropertyName = "FactoryName";
            this.Column4.HeaderText = "نام کارخانه";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Visible = false;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "ProductCode";
            this.Column5.HeaderText = "کد محصول";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 150;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ProductName";
            this.Column6.HeaderText = "نام محصول";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 250;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ProductUnit";
            this.Column7.HeaderText = "مقدار واحد";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 150;
            // 
            // btnErsal
            // 
            this.btnErsal.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnErsal.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnErsal.Location = new System.Drawing.Point(130, 169);
            this.btnErsal.Name = "btnErsal";
            this.btnErsal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnErsal.Size = new System.Drawing.Size(53, 23);
            this.btnErsal.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnErsal.TabIndex = 3;
            this.btnErsal.Text = "ارسال";
            this.btnErsal.Click += new System.EventHandler(this.btnErsal_Click);
            // 
            // txtErsali
            // 
            // 
            // 
            // 
            this.txtErsali.Border.Class = "TextBoxBorder";
            this.txtErsali.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtErsali.Location = new System.Drawing.Point(313, 169);
            this.txtErsali.MaxLength = 20;
            this.txtErsali.Name = "txtErsali";
            this.txtErsali.PreventEnterBeep = true;
            this.txtErsali.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtErsali.Size = new System.Drawing.Size(170, 23);
            this.txtErsali.TabIndex = 1;
            this.txtErsali.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtErsali.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtErsali_KeyPress);
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(489, 171);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(60, 18);
            this.labelX1.TabIndex = 3;
            this.labelX1.Text = "ارسالی : ";
            // 
            // txtErsalShode
            // 
            // 
            // 
            // 
            this.txtErsalShode.Border.Class = "TextBoxBorder";
            this.txtErsalShode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtErsalShode.Location = new System.Drawing.Point(313, 198);
            this.txtErsalShode.MaxLength = 20;
            this.txtErsalShode.Name = "txtErsalShode";
            this.txtErsalShode.PreventEnterBeep = true;
            this.txtErsalShode.ReadOnly = true;
            this.txtErsalShode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtErsalShode.Size = new System.Drawing.Size(170, 23);
            this.txtErsalShode.TabIndex = 4;
            this.txtErsalShode.Text = "---";
            this.txtErsalShode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(489, 200);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(82, 18);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "ارسال شده : ";
            // 
            // txtMande
            // 
            // 
            // 
            // 
            this.txtMande.Border.Class = "TextBoxBorder";
            this.txtMande.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMande.Location = new System.Drawing.Point(71, 198);
            this.txtMande.MaxLength = 20;
            this.txtMande.Name = "txtMande";
            this.txtMande.PreventEnterBeep = true;
            this.txtMande.ReadOnly = true;
            this.txtMande.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMande.Size = new System.Drawing.Size(170, 23);
            this.txtMande.TabIndex = 5;
            this.txtMande.Text = "---";
            this.txtMande.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(247, 200);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(46, 18);
            this.labelX3.TabIndex = 7;
            this.labelX3.Text = "مانده : ";
            // 
            // txtContractDate
            // 
            this.txtContractDate.Location = new System.Drawing.Point(189, 169);
            this.txtContractDate.Mask = "0000/00/00";
            this.txtContractDate.Name = "txtContractDate";
            this.txtContractDate.Size = new System.Drawing.Size(118, 23);
            this.txtContractDate.TabIndex = 2;
            this.txtContractDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContractDate.DoubleClick += new System.EventHandler(this.txtContractDate_DoubleClick);
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            // 
            // 
            // 
            this.lblDate.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.lblDate.Location = new System.Drawing.Point(574, 174);
            this.lblDate.Name = "lblDate";
            this.lblDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblDate.Size = new System.Drawing.Size(54, 18);
            this.lblDate.TabIndex = 45;
            this.lblDate.Text = "-----------";
            this.lblDate.Visible = false;
            // 
            // btnCancel
            // 
            this.btnCancel.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnCancel.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnCancel.Location = new System.Drawing.Point(71, 169);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnCancel.Size = new System.Drawing.Size(53, 23);
            this.btnCancel.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "لغو";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // frmErsal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 227);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.txtContractDate);
            this.Controls.Add(this.txtMande);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtErsalShode);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtErsali);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnErsal);
            this.Controls.Add(this.dgvContract);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmErsal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "درج ارسال";
            this.Load += new System.EventHandler(this.frmErsal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.DataGridViewX dgvContract;
        private DevComponents.DotNetBar.ButtonX btnErsal;
        private DevComponents.DotNetBar.Controls.TextBoxX txtErsali;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtErsalShode;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMande;
        private DevComponents.DotNetBar.LabelX labelX3;
        private System.Windows.Forms.MaskedTextBox txtContractDate;
        private DevComponents.DotNetBar.LabelX lblDate;
        private DevComponents.DotNetBar.ButtonX btnCancel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}