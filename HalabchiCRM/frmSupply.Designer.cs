namespace HalabchiCRM
{
    partial class frmSupply
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
            this.components = new System.ComponentModel.Container();
            this.btnRegister = new DevComponents.DotNetBar.ButtonX();
            this.txtSupplyID = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.txtPostCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.txtEconomyCode = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX4 = new DevComponents.DotNetBar.LabelX();
            this.txtFactoryName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX5 = new DevComponents.DotNetBar.LabelX();
            this.txtMobile = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX6 = new DevComponents.DotNetBar.LabelX();
            this.txtManagerName = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX7 = new DevComponents.DotNetBar.LabelX();
            this.txtFax = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX8 = new DevComponents.DotNetBar.LabelX();
            this.txtTell = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX9 = new DevComponents.DotNetBar.LabelX();
            this.txtBrand = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.txtAddress = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX12 = new DevComponents.DotNetBar.LabelX();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labelX10 = new DevComponents.DotNetBar.LabelX();
            this.txtSupply = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX11 = new DevComponents.DotNetBar.LabelX();
            this.txtWebSite = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX13 = new DevComponents.DotNetBar.LabelX();
            this.txtEmail = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.btnClear = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegister
            // 
            this.btnRegister.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnRegister.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnRegister.Location = new System.Drawing.Point(598, 242);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(113, 39);
            this.btnRegister.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnRegister.TabIndex = 13;
            this.btnRegister.Text = "ثبت";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtSupplyID
            // 
            // 
            // 
            // 
            this.txtSupplyID.Border.Class = "TextBoxBorder";
            this.txtSupplyID.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSupplyID.Location = new System.Drawing.Point(556, 11);
            this.txtSupplyID.MaxLength = 10;
            this.txtSupplyID.Name = "txtSupplyID";
            this.txtSupplyID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSupplyID.Size = new System.Drawing.Size(155, 23);
            this.txtSupplyID.TabIndex = 0;
            this.txtSupplyID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labelX1
            // 
            this.labelX1.AutoSize = true;
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(717, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(120, 18);
            this.labelX1.TabIndex = 1;
            this.labelX1.Text = "شماره تامین کننده : ";
            // 
            // labelX2
            // 
            this.labelX2.AutoSize = true;
            this.labelX2.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(450, 12);
            this.labelX2.Name = "labelX2";
            this.labelX2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX2.Size = new System.Drawing.Size(72, 18);
            this.labelX2.TabIndex = 3;
            this.labelX2.Text = "کد پستی : ";
            // 
            // txtPostCode
            // 
            // 
            // 
            // 
            this.txtPostCode.Border.Class = "TextBoxBorder";
            this.txtPostCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtPostCode.Location = new System.Drawing.Point(289, 11);
            this.txtPostCode.MaxLength = 10;
            this.txtPostCode.Name = "txtPostCode";
            this.txtPostCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPostCode.Size = new System.Drawing.Size(155, 23);
            this.txtPostCode.TabIndex = 1;
            this.txtPostCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPostCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // labelX3
            // 
            this.labelX3.AutoSize = true;
            this.labelX3.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(183, 12);
            this.labelX3.Name = "labelX3";
            this.labelX3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX3.Size = new System.Drawing.Size(81, 18);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "کد اقتصادی : ";
            // 
            // txtEconomyCode
            // 
            // 
            // 
            // 
            this.txtEconomyCode.Border.Class = "TextBoxBorder";
            this.txtEconomyCode.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEconomyCode.Location = new System.Drawing.Point(22, 11);
            this.txtEconomyCode.MaxLength = 12;
            this.txtEconomyCode.Name = "txtEconomyCode";
            this.txtEconomyCode.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEconomyCode.Size = new System.Drawing.Size(155, 23);
            this.txtEconomyCode.TabIndex = 2;
            this.txtEconomyCode.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtEconomyCode.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // labelX4
            // 
            this.labelX4.AutoSize = true;
            this.labelX4.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX4.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX4.Location = new System.Drawing.Point(183, 41);
            this.labelX4.Name = "labelX4";
            this.labelX4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX4.Size = new System.Drawing.Size(77, 18);
            this.labelX4.TabIndex = 11;
            this.labelX4.Text = "نام کارخانه : ";
            // 
            // txtFactoryName
            // 
            // 
            // 
            // 
            this.txtFactoryName.Border.Class = "TextBoxBorder";
            this.txtFactoryName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFactoryName.Location = new System.Drawing.Point(22, 40);
            this.txtFactoryName.MaxLength = 50;
            this.txtFactoryName.Name = "txtFactoryName";
            this.txtFactoryName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFactoryName.Size = new System.Drawing.Size(155, 23);
            this.txtFactoryName.TabIndex = 5;
            // 
            // labelX5
            // 
            this.labelX5.AutoSize = true;
            this.labelX5.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX5.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX5.Location = new System.Drawing.Point(450, 41);
            this.labelX5.Name = "labelX5";
            this.labelX5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX5.Size = new System.Drawing.Size(91, 18);
            this.labelX5.TabIndex = 9;
            this.labelX5.Text = "شماره موبایل : ";
            // 
            // txtMobile
            // 
            // 
            // 
            // 
            this.txtMobile.Border.Class = "TextBoxBorder";
            this.txtMobile.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtMobile.Location = new System.Drawing.Point(289, 40);
            this.txtMobile.MaxLength = 11;
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMobile.Size = new System.Drawing.Size(155, 23);
            this.txtMobile.TabIndex = 4;
            this.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMobile.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // labelX6
            // 
            this.labelX6.AutoSize = true;
            this.labelX6.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX6.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX6.Location = new System.Drawing.Point(717, 41);
            this.labelX6.Name = "labelX6";
            this.labelX6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX6.Size = new System.Drawing.Size(93, 18);
            this.labelX6.TabIndex = 7;
            this.labelX6.Text = "نام مدیر عامل : ";
            // 
            // txtManagerName
            // 
            // 
            // 
            // 
            this.txtManagerName.Border.Class = "TextBoxBorder";
            this.txtManagerName.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtManagerName.Location = new System.Drawing.Point(556, 40);
            this.txtManagerName.MaxLength = 50;
            this.txtManagerName.Name = "txtManagerName";
            this.txtManagerName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtManagerName.Size = new System.Drawing.Size(155, 23);
            this.txtManagerName.TabIndex = 3;
            // 
            // labelX7
            // 
            this.labelX7.AutoSize = true;
            this.labelX7.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX7.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX7.Location = new System.Drawing.Point(183, 70);
            this.labelX7.Name = "labelX7";
            this.labelX7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX7.Size = new System.Drawing.Size(88, 18);
            this.labelX7.TabIndex = 17;
            this.labelX7.Text = "شماره فکس : ";
            // 
            // txtFax
            // 
            // 
            // 
            // 
            this.txtFax.Border.Class = "TextBoxBorder";
            this.txtFax.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtFax.Location = new System.Drawing.Point(22, 69);
            this.txtFax.MaxLength = 11;
            this.txtFax.Name = "txtFax";
            this.txtFax.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFax.Size = new System.Drawing.Size(155, 23);
            this.txtFax.TabIndex = 8;
            this.txtFax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtFax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // labelX8
            // 
            this.labelX8.AutoSize = true;
            this.labelX8.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX8.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX8.Location = new System.Drawing.Point(450, 70);
            this.labelX8.Name = "labelX8";
            this.labelX8.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX8.Size = new System.Drawing.Size(83, 18);
            this.labelX8.TabIndex = 15;
            this.labelX8.Text = "شماره تلفن : ";
            // 
            // txtTell
            // 
            // 
            // 
            // 
            this.txtTell.Border.Class = "TextBoxBorder";
            this.txtTell.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtTell.Location = new System.Drawing.Point(289, 69);
            this.txtTell.MaxLength = 11;
            this.txtTell.Name = "txtTell";
            this.txtTell.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtTell.Size = new System.Drawing.Size(155, 23);
            this.txtTell.TabIndex = 7;
            this.txtTell.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTell.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.JustNumber);
            // 
            // labelX9
            // 
            this.labelX9.AutoSize = true;
            this.labelX9.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX9.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX9.Location = new System.Drawing.Point(717, 70);
            this.labelX9.Name = "labelX9";
            this.labelX9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX9.Size = new System.Drawing.Size(39, 18);
            this.labelX9.TabIndex = 13;
            this.labelX9.Text = "برند : ";
            // 
            // txtBrand
            // 
            // 
            // 
            // 
            this.txtBrand.Border.Class = "TextBoxBorder";
            this.txtBrand.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtBrand.Location = new System.Drawing.Point(556, 69);
            this.txtBrand.MaxLength = 50;
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtBrand.Size = new System.Drawing.Size(155, 23);
            this.txtBrand.TabIndex = 6;
            // 
            // txtAddress
            // 
            // 
            // 
            // 
            this.txtAddress.Border.Class = "TextBoxBorder";
            this.txtAddress.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtAddress.Location = new System.Drawing.Point(22, 127);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAddress.Size = new System.Drawing.Size(689, 109);
            this.txtAddress.TabIndex = 12;
            // 
            // labelX12
            // 
            this.labelX12.AutoSize = true;
            this.labelX12.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX12.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX12.Location = new System.Drawing.Point(717, 128);
            this.labelX12.Name = "labelX12";
            this.labelX12.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX12.Size = new System.Drawing.Size(49, 18);
            this.labelX12.TabIndex = 25;
            this.labelX12.Text = "آدرس : ";
            // 
            // errorProvider1
            // 
            this.errorProvider1.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.RightToLeft = true;
            // 
            // labelX10
            // 
            this.labelX10.AutoSize = true;
            this.labelX10.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX10.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX10.Location = new System.Drawing.Point(183, 99);
            this.labelX10.Name = "labelX10";
            this.labelX10.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX10.Size = new System.Drawing.Size(80, 18);
            this.labelX10.TabIndex = 31;
            this.labelX10.Text = "تامین کننده : ";
            // 
            // txtSupply
            // 
            // 
            // 
            // 
            this.txtSupply.Border.Class = "TextBoxBorder";
            this.txtSupply.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtSupply.Location = new System.Drawing.Point(22, 98);
            this.txtSupply.MaxLength = 150;
            this.txtSupply.Multiline = true;
            this.txtSupply.Name = "txtSupply";
            this.txtSupply.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSupply.Size = new System.Drawing.Size(155, 23);
            this.txtSupply.TabIndex = 11;
            this.txtSupply.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX11
            // 
            this.labelX11.AutoSize = true;
            this.labelX11.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX11.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX11.Location = new System.Drawing.Point(450, 99);
            this.labelX11.Name = "labelX11";
            this.labelX11.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX11.Size = new System.Drawing.Size(51, 18);
            this.labelX11.TabIndex = 29;
            this.labelX11.Text = "تار نما : ";
            // 
            // txtWebSite
            // 
            // 
            // 
            // 
            this.txtWebSite.Border.Class = "TextBoxBorder";
            this.txtWebSite.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtWebSite.Location = new System.Drawing.Point(289, 98);
            this.txtWebSite.MaxLength = 100;
            this.txtWebSite.Name = "txtWebSite";
            this.txtWebSite.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtWebSite.Size = new System.Drawing.Size(155, 23);
            this.txtWebSite.TabIndex = 10;
            this.txtWebSite.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // labelX13
            // 
            this.labelX13.AutoSize = true;
            this.labelX13.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX13.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX13.Location = new System.Drawing.Point(717, 99);
            this.labelX13.Name = "labelX13";
            this.labelX13.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX13.Size = new System.Drawing.Size(110, 18);
            this.labelX13.TabIndex = 27;
            this.labelX13.Text = "پست الکترونیکی : ";
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.Border.Class = "TextBoxBorder";
            this.txtEmail.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txtEmail.Location = new System.Drawing.Point(556, 98);
            this.txtEmail.MaxLength = 100;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.Size = new System.Drawing.Size(155, 23);
            this.txtEmail.TabIndex = 9;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnClear
            // 
            this.btnClear.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnClear.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnClear.Location = new System.Drawing.Point(468, 242);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 39);
            this.btnClear.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "خالی کردن";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // frmSupply
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 293);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.labelX10);
            this.Controls.Add(this.txtSupply);
            this.Controls.Add(this.labelX11);
            this.Controls.Add(this.txtWebSite);
            this.Controls.Add(this.labelX13);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelX12);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.labelX7);
            this.Controls.Add(this.txtFax);
            this.Controls.Add(this.labelX8);
            this.Controls.Add(this.txtTell);
            this.Controls.Add(this.labelX9);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.labelX4);
            this.Controls.Add(this.txtFactoryName);
            this.Controls.Add(this.labelX5);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.labelX6);
            this.Controls.Add(this.txtManagerName);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.txtEconomyCode);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.txtPostCode);
            this.Controls.Add(this.labelX1);
            this.Controls.Add(this.txtSupplyID);
            this.Controls.Add(this.btnRegister);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimizeBox = false;
            this.Name = "frmSupply";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تامین کننده";
            this.Load += new System.EventHandler(this.frmSupply_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX4;
        private DevComponents.DotNetBar.LabelX labelX5;
        private DevComponents.DotNetBar.LabelX labelX6;
        private DevComponents.DotNetBar.LabelX labelX7;
        private DevComponents.DotNetBar.LabelX labelX8;
        private DevComponents.DotNetBar.LabelX labelX9;
        private DevComponents.DotNetBar.LabelX labelX12;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private DevComponents.DotNetBar.LabelX labelX10;
        private DevComponents.DotNetBar.LabelX labelX11;
        private DevComponents.DotNetBar.LabelX labelX13;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSupplyID;
        private DevComponents.DotNetBar.Controls.TextBoxX txtPostCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEconomyCode;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFactoryName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtMobile;
        private DevComponents.DotNetBar.Controls.TextBoxX txtManagerName;
        private DevComponents.DotNetBar.Controls.TextBoxX txtFax;
        private DevComponents.DotNetBar.Controls.TextBoxX txtTell;
        private DevComponents.DotNetBar.Controls.TextBoxX txtBrand;
        private DevComponents.DotNetBar.Controls.TextBoxX txtAddress;
        private DevComponents.DotNetBar.Controls.TextBoxX txtSupply;
        private DevComponents.DotNetBar.Controls.TextBoxX txtWebSite;
        private DevComponents.DotNetBar.Controls.TextBoxX txtEmail;
        private DevComponents.DotNetBar.ButtonX btnRegister;
        private DevComponents.DotNetBar.ButtonX btnClear;
    }
}