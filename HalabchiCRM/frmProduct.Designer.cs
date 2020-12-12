namespace HalabchiCRM
{
    partial class frmProduct
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
            this.brnAddProduct = new DevComponents.DotNetBar.ButtonX();
            this.txtProductCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.txtProductName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtProductUnit = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // brnAddProduct
            // 
            this.brnAddProduct.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.brnAddProduct.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.brnAddProduct.Location = new System.Drawing.Point(28, 49);
            this.brnAddProduct.Name = "brnAddProduct";
            this.brnAddProduct.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.brnAddProduct.Size = new System.Drawing.Size(116, 23);
            this.brnAddProduct.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.brnAddProduct.TabIndex = 3;
            this.brnAddProduct.Text = "اضافه کردن";
            this.brnAddProduct.Click += new System.EventHandler(this.brnAddProduct_Click);
            // 
            // txtProductCode
            // 
            // 
            // 
            // 
            this.txtProductCode.Border.Class = "TextBoxBorder";
            this.txtProductCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductCode.Location = new System.Drawing.Point(524, 11);
            this.txtProductCode.MaxLength = 10;
            this.txtProductCode.Name = "txtProductCode";
            this.txtProductCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductCode.Size = new System.Drawing.Size(124, 23);
            this.txtProductCode.TabIndex = 0;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(654, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(76, 18);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "کد محصول : ";
            // 
            // txtProductName
            // 
            // 
            // 
            // 
            this.txtProductName.Border.Class = "TextBoxBorder";
            this.txtProductName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductName.Location = new System.Drawing.Point(234, 11);
            this.txtProductName.MaxLength = 50;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductName.Size = new System.Drawing.Size(200, 23);
            this.txtProductName.TabIndex = 1;
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(440, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(78, 18);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "نام محصول : ";
            // 
            // txtProductUnit
            // 
            // 
            // 
            // 
            this.txtProductUnit.Border.Class = "TextBoxBorder";
            this.txtProductUnit.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtProductUnit.Location = new System.Drawing.Point(28, 10);
            this.txtProductUnit.MaxLength = 50;
            this.txtProductUnit.Name = "txtProductUnit";
            this.txtProductUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtProductUnit.Size = new System.Drawing.Size(116, 23);
            this.txtProductUnit.TabIndex = 2;
            this.txtProductUnit.Text = "0";
            this.txtProductUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtProductUnit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtProductUnit_KeyPress);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(150, 11);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(76, 18);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "مقدار اولیه : ";
            // 
            // frmProduct
            // 
            this.AcceptButton = this.brnAddProduct;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 81);
            this.Controls.Add(this.txtProductUnit);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtProductCode);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.brnAddProduct);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "محصول";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevComponents.DotNetBar.ButtonX brnAddProduct;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductCode;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductName;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.Controls.TextBoxX txtProductUnit;
        private DevComponents.DotNetBar.LabelX labelX3;
    }
}