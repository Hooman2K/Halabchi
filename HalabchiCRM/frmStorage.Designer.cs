namespace HalabchiCRM
{
    partial class frmStorage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvStorage = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.txtStorageName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSaveStorage = new DevComponents.DotNetBar.ButtonX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).BeginInit();
            this.SuspendLayout();
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(217, 4);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(58, 18);
            this.labelX1.TabIndex = 0;
            this.labelX1.Text = "نام انبار : ";
            // 
            // dgvStorage
            // 
            this.dgvStorage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStorage.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStorage.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvStorage.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvStorage.Location = new System.Drawing.Point(2, 61);
            this.dgvStorage.Name = "dgvStorage";
            this.dgvStorage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvStorage.Size = new System.Drawing.Size(273, 193);
            this.dgvStorage.TabIndex = 2;
            // 
            // txtStorageName
            // 
            // 
            // 
            // 
            this.txtStorageName.Border.Class = "TextBoxBorder";
            this.txtStorageName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtStorageName.Location = new System.Drawing.Point(2, 3);
            this.txtStorageName.MaxLength = 150;
            this.txtStorageName.Name = "txtStorageName";
            this.txtStorageName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtStorageName.Size = new System.Drawing.Size(209, 23);
            this.txtStorageName.TabIndex = 0;
            // 
            // btnSaveStorage
            // 
            this.btnSaveStorage.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveStorage.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveStorage.Location = new System.Drawing.Point(2, 32);
            this.btnSaveStorage.Name = "btnSaveStorage";
            this.btnSaveStorage.Size = new System.Drawing.Size(273, 23);
            this.btnSaveStorage.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveStorage.TabIndex = 1;
            this.btnSaveStorage.Text = "ثبت انبار جدید";
            this.btnSaveStorage.Click += new System.EventHandler(this.btnSaveStorage_Click);
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "ID";
            this.Column1.HeaderText = "شماره";
            this.Column1.Name = "Column1";
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "StorageName";
            this.Column2.HeaderText = "نام انبار";
            this.Column2.Name = "Column2";
            this.Column2.Width = 150;
            // 
            // frmStorage
            // 
            this.AcceptButton = this.btnSaveStorage;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 266);
            this.Controls.Add(this.btnSaveStorage);
            this.Controls.Add(this.txtStorageName);
            this.Controls.Add(this.dgvStorage);
            this.Controls.Add(this.labelX1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmStorage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "انبار";
            this.Load += new System.EventHandler(this.frmStorage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStorage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvStorage;
        private DevComponents.DotNetBar.Controls.TextBoxX txtStorageName;
        private DevComponents.DotNetBar.ButtonX btnSaveStorage;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
    }
}