
namespace HalabchiCRM
{
    partial class frmErsaleKala
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
            this.cmbxCustomer = new System.Windows.Forms.ComboBox();
            this.dgvContract = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(406, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(99, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "انتخاب مشتری : ";
            // 
            // cmbxCustomer
            // 
            this.cmbxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxCustomer.FormattingEnabled = true;
            this.cmbxCustomer.Location = new System.Drawing.Point(206, 10);
            this.cmbxCustomer.Name = "cmbxCustomer";
            this.cmbxCustomer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxCustomer.Size = new System.Drawing.Size(194, 24);
            this.cmbxCustomer.TabIndex = 1;
            this.cmbxCustomer.SelectedIndexChanged += new System.EventHandler(this.cmbxCustomer_SelectedIndexChanged);
            // 
            // dgvContract
            // 
            this.dgvContract.AllowUserToAddRows = false;
            this.dgvContract.AllowUserToDeleteRows = false;
            this.dgvContract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvContract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column24,
            this.Column25,
            this.Column29,
            this.Column26,
            this.Column27,
            this.Column28});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvContract.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvContract.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvContract.Location = new System.Drawing.Point(12, 40);
            this.dgvContract.Name = "dgvContract";
            this.dgvContract.ReadOnly = true;
            this.dgvContract.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvContract.Size = new System.Drawing.Size(493, 195);
            this.dgvContract.TabIndex = 12;
            this.dgvContract.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvContract_CellDoubleClick);
            // 
            // Column24
            // 
            this.Column24.DataPropertyName = "ID";
            this.Column24.HeaderText = "شماره";
            this.Column24.Name = "Column24";
            this.Column24.ReadOnly = true;
            this.Column24.Visible = false;
            // 
            // Column25
            // 
            this.Column25.DataPropertyName = "ContractID";
            this.Column25.HeaderText = "شماره قرارداد";
            this.Column25.Name = "Column25";
            this.Column25.ReadOnly = true;
            this.Column25.Width = 120;
            // 
            // Column29
            // 
            this.Column29.DataPropertyName = "FactoryName";
            this.Column29.HeaderText = "نام کارخانه";
            this.Column29.Name = "Column29";
            this.Column29.ReadOnly = true;
            this.Column29.Visible = false;
            this.Column29.Width = 120;
            // 
            // Column26
            // 
            this.Column26.DataPropertyName = "CustomerID";
            this.Column26.HeaderText = "شماره مشتری";
            this.Column26.Name = "Column26";
            this.Column26.ReadOnly = true;
            this.Column26.Visible = false;
            this.Column26.Width = 120;
            // 
            // Column27
            // 
            this.Column27.DataPropertyName = "ContractDate";
            this.Column27.HeaderText = "تاریخ قرارداد";
            this.Column27.Name = "Column27";
            this.Column27.ReadOnly = true;
            this.Column27.Width = 120;
            // 
            // Column28
            // 
            this.Column28.DataPropertyName = "ContractTitle";
            this.Column28.HeaderText = "عنوان قرارداد";
            this.Column28.Name = "Column28";
            this.Column28.ReadOnly = true;
            this.Column28.Width = 180;
            // 
            // frmErsaleKala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 247);
            this.Controls.Add(this.dgvContract);
            this.Controls.Add(this.cmbxCustomer);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmErsaleKala";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ارسال کالا مشتری";
            this.Load += new System.EventHandler(this.frmErsaleKala_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvContract)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private System.Windows.Forms.ComboBox cmbxCustomer;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvContract;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column24;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column25;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column29;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column26;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column27;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column28;
    }
}