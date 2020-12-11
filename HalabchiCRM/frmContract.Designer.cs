﻿namespace HalabchiCRM
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txtContractID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnSetProduct = new DevComponents.DotNetBar.ButtonX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dgvProduct = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtFactoryName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtContractTitle = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtContractDate = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtProductID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtProductUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtContractID
            // 
            // 
            // 
            // 
            this.txtContractID.Border.Class = "TextBoxBorder";
            this.txtContractID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContractID.Location = new System.Drawing.Point(255, 12);
            this.txtContractID.MaxLength = 10;
            this.txtContractID.Name = "txtContractID";
            this.txtContractID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractID.Size = new System.Drawing.Size(143, 23);
            this.txtContractID.TabIndex = 0;
            this.txtContractID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSetProduct
            // 
            this.btnSetProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSetProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSetProduct.Location = new System.Drawing.Point(12, 147);
            this.btnSetProduct.Name = "btnSetProduct";
            this.btnSetProduct.Size = new System.Drawing.Size(75, 23);
            this.btnSetProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSetProduct.TabIndex = 1;
            this.btnSetProduct.Text = "اضافه کردن";
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(404, 13);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(92, 18);
            this.labelX1.TabIndex = 2;
            this.labelX1.Text = "شماره قرارداد : ";
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProduct.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvProduct.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvProduct.Location = new System.Drawing.Point(12, 175);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.Size = new System.Drawing.Size(484, 168);
            this.dgvProduct.TabIndex = 3;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(161, 13);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(77, 18);
            this.labelX2.TabIndex = 5;
            this.labelX2.Text = "نام کارخانه : ";
            // 
            // txtFactoryName
            // 
            // 
            // 
            // 
            this.txtFactoryName.Border.Class = "TextBoxBorder";
            this.txtFactoryName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFactoryName.Location = new System.Drawing.Point(12, 12);
            this.txtFactoryName.MaxLength = 50;
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFactoryName.Size = new System.Drawing.Size(143, 23);
            this.txtFactoryName.TabIndex = 1;
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(161, 42);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(87, 18);
            this.labelX3.TabIndex = 9;
            this.labelX3.Text = "عنوان قرارداد : ";
            // 
            // txtContractTitle
            // 
            // 
            // 
            // 
            this.txtContractTitle.Border.Class = "TextBoxBorder";
            this.txtContractTitle.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContractTitle.Location = new System.Drawing.Point(12, 41);
            this.txtContractTitle.MaxLength = 100;
            this.txtContractTitle.Name = "txtContractTitle";
            this.txtContractTitle.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractTitle.Size = new System.Drawing.Size(143, 23);
            this.txtContractTitle.TabIndex = 3;
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(404, 42);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(82, 18);
            this.labelX4.TabIndex = 7;
            this.labelX4.Text = "تاریخ قرارداد : ";
            // 
            // txtContractDate
            // 
            // 
            // 
            // 
            this.txtContractDate.Border.Class = "TextBoxBorder";
            this.txtContractDate.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtContractDate.Location = new System.Drawing.Point(255, 41);
            this.txtContractDate.MaxLength = 11;
            this.txtContractDate.Name = "txtContractDate";
            this.txtContractDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtContractDate.Size = new System.Drawing.Size(143, 23);
            this.txtContractDate.TabIndex = 2;
            this.txtContractDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtContractDate.WatermarkText = "__/__/____";
            // 
            // labelX5
            // 
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(12, 70);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(484, 71);
            this.labelX5.TabIndex = 10;
            this.labelX5.Text = "مشخصات مشتری";
            this.labelX5.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(441, 147);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(55, 18);
            this.labelX6.TabIndex = 12;
            this.labelX6.Text = "کد کالا : ";
            // 
            // txtProductID
            // 
            // 
            // 
            // 
            this.txtProductID.Border.Class = "TextBoxBorder";
            this.txtProductID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductID.Location = new System.Drawing.Point(292, 146);
            this.txtProductID.MaxLength = 10;
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductID.Size = new System.Drawing.Size(143, 23);
            this.txtProductID.TabIndex = 11;
            this.txtProductID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(239, 147);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(47, 18);
            this.labelX7.TabIndex = 14;
            this.labelX7.Text = "مقدار : ";
            // 
            // txtProductUnit
            // 
            // 
            // 
            // 
            this.txtProductUnit.Border.Class = "TextBoxBorder";
            this.txtProductUnit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductUnit.Location = new System.Drawing.Point(90, 146);
            this.txtProductUnit.MaxLength = 10;
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductUnit.Size = new System.Drawing.Size(143, 23);
            this.txtProductUnit.TabIndex = 13;
            this.txtProductUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmContract
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 353);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtProductUnit);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtProductID);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtContractTitle);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtContractDate);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtFactoryName);
            this.Controls.Add(this.dgvProduct);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.btnSetProduct);
            this.Controls.Add(this.txtContractID);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmContract";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "قرارداد ها";
            this.Load += new System.EventHandler(this.frmContract_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX txtContractID;
        private DevComponents.DotNetBar.ButtonX btnSetProduct;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvProduct;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFactoryName;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContractTitle;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.Controls.TextBoxX txtContractDate;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductID;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductUnit;
    }
}