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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnAdd = new DevComponents.DotNetBar.ButtonX();
            this.dgvFormula = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvProductionFormula = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.cmbxSelectStorage = new System.Windows.Forms.ComboBox();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtMaterialName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtProductUnitPerOne = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.btnSave = new DevComponents.DotNetBar.ButtonX();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtFormulaName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnAddFormula = new DevComponents.DotNetBar.ButtonX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionFormula)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnAdd.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnAdd.Location = new System.Drawing.Point(12, 107);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAdd.Size = new System.Drawing.Size(124, 28);
            this.btnAdd.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "اضافه کردن";
            // 
            // dgvFormula
            // 
            this.dgvFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFormula.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvFormula.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvFormula.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvFormula.Location = new System.Drawing.Point(12, 148);
            this.dgvFormula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvFormula.Name = "dgvFormula";
            this.dgvFormula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvFormula.Size = new System.Drawing.Size(406, 141);
            this.dgvFormula.TabIndex = 8;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "شماره";
            this.Column1.Name = "Column1";
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "شماره فرمول";
            this.Column2.Name = "Column2";
            this.Column2.Visible = false;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "نام محصول";
            this.Column3.Name = "Column3";
            this.Column3.Visible = false;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "مواد اولیه";
            this.Column4.Name = "Column4";
            this.Column4.Width = 200;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "مقدار مورد نیاز";
            this.Column5.Name = "Column5";
            this.Column5.Width = 140;
            // 
            // dgvProductionFormula
            // 
            this.dgvProductionFormula.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductionFormula.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProductionFormula.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvProductionFormula.Location = new System.Drawing.Point(12, 313);
            this.dgvProductionFormula.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvProductionFormula.Name = "dgvProductionFormula";
            this.dgvProductionFormula.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvProductionFormula.Size = new System.Drawing.Size(406, 131);
            this.dgvProductionFormula.TabIndex = 9;
            // 
            // cmbxSelectStorage
            // 
            this.cmbxSelectStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxSelectStorage.FormattingEnabled = true;
            this.cmbxSelectStorage.Location = new System.Drawing.Point(278, 44);
            this.cmbxSelectStorage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cmbxSelectStorage.Name = "cmbxSelectStorage";
            this.cmbxSelectStorage.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxSelectStorage.Size = new System.Drawing.Size(140, 24);
            this.cmbxSelectStorage.TabIndex = 2;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(424, 46);
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
            this.labelX4.Location = new System.Drawing.Point(424, 77);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(69, 18);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "مواد اولیه : ";
            // 
            // txtMaterialName
            // 
            // 
            // 
            // 
            this.txtMaterialName.Border.Class = "TextBoxBorder";
            this.txtMaterialName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMaterialName.Location = new System.Drawing.Point(223, 76);
            this.txtMaterialName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaterialName.MaxLength = 50;
            this.txtMaterialName.Name = "txtMaterialName";
            this.txtMaterialName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMaterialName.Size = new System.Drawing.Size(195, 23);
            this.txtMaterialName.TabIndex = 4;
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(142, 75);
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
            this.txtProductUnitPerOne.Location = new System.Drawing.Point(12, 76);
            this.txtProductUnitPerOne.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductUnitPerOne.MaxLength = 20;
            this.txtProductUnitPerOne.Name = "txtProductUnitPerOne";
            this.txtProductUnitPerOne.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductUnitPerOne.Size = new System.Drawing.Size(124, 23);
            this.txtProductUnitPerOne.TabIndex = 5;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(424, 204);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(84, 18);
            this.labelX3.TabIndex = 12;
            this.labelX3.Text = "جدول فرمول : ";
            // 
            // labelX6
            // 
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(424, 337);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(75, 78);
            this.labelX6.TabIndex = 13;
            this.labelX6.Text = "فرمول های\r\nموجود";
            this.labelX6.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // btnSave
            // 
            this.btnSave.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSave.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSave.Location = new System.Drawing.Point(12, 452);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(124, 28);
            this.btnSave.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "ذخیره";
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.Border.Class = "TextBoxBorder";
            this.txtProductName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductName.Location = new System.Drawing.Point(12, 45);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductName.Size = new System.Drawing.Size(168, 23);
            this.txtProductName.TabIndex = 3;
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(186, 44);
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
            // 
            // labelX8
            // 
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.ForeColor = System.Drawing.Color.Red;
            this.labelX8.Location = new System.Drawing.Point(142, 107);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(366, 28);
            this.labelX8.TabIndex = 17;
            this.labelX8.Text = "توجه : مقدار مورد نیاز برای ساخت 1 واحد و به گرم میباشد!!";
            this.labelX8.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // frmProductionFormula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 493);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.btnAddFormula);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtFormulaName);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtMaterialName);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtProductUnitPerOne);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.cmbxSelectStorage);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.dgvProductionFormula);
            this.Controls.Add(this.dgvFormula);
            this.Controls.Add(this.btnAdd);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmProductionFormula";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فرمول ساخت کالا";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFormula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductionFormula)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.ButtonX btnAdd;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvFormula;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvProductionFormula;
        private System.Windows.Forms.ComboBox cmbxSelectStorage;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMaterialName;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductUnitPerOne;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.ButtonX btnSave;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFormulaName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private DevComponents.DotNetBar.ButtonX btnAddFormula;
        private DevComponents.DotNetBar.LabelX labelX8;
    }
}