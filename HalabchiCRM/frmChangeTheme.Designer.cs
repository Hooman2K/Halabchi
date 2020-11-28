namespace HalabchiCRM
{
    partial class frmChangeTheme
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
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.cmbxTheme = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.Blue = new DevComponents.Editors.ComboItem();
            this.Silver = new DevComponents.Editors.ComboItem();
            this.Black = new DevComponents.Editors.ComboItem();
            this.btnSaveTheme = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.cmbxTheme);
            this.groupPanel1.Controls.Add(this.btnSaveTheme);
            this.groupPanel1.Location = new System.Drawing.Point(10, 5);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(490, 76);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 1;
            this.groupPanel1.Text = "پوسته نرم افزار";
            // 
            // labelX1
            // 
            this.labelX1.BackColor = System.Drawing.Color.Transparent;
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(340, 11);
            this.labelX1.Name = "labelX1";
            this.labelX1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.labelX1.Size = new System.Drawing.Size(75, 23);
            this.labelX1.TabIndex = 5;
            this.labelX1.Text = "تغییر پوسته : ";
            // 
            // cmbxTheme
            // 
            this.cmbxTheme.DisplayMember = "Text";
            this.cmbxTheme.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbxTheme.FormattingEnabled = true;
            this.cmbxTheme.ItemHeight = 17;
            this.cmbxTheme.Items.AddRange(new object[] {
            this.Blue,
            this.Silver,
            this.Black});
            this.cmbxTheme.Location = new System.Drawing.Point(172, 11);
            this.cmbxTheme.Name = "cmbxTheme";
            this.cmbxTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbxTheme.Size = new System.Drawing.Size(162, 23);
            this.cmbxTheme.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cmbxTheme.TabIndex = 4;
            // 
            // Blue
            // 
            this.Blue.Text = "آبی";
            // 
            // Silver
            // 
            this.Silver.Text = "خاکستری";
            // 
            // Black
            // 
            this.Black.Text = "مشکی";
            // 
            // btnSaveTheme
            // 
            this.btnSaveTheme.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveTheme.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnSaveTheme.Location = new System.Drawing.Point(79, 11);
            this.btnSaveTheme.Name = "btnSaveTheme";
            this.btnSaveTheme.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSaveTheme.Size = new System.Drawing.Size(75, 23);
            this.btnSaveTheme.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnSaveTheme.TabIndex = 3;
            this.btnSaveTheme.Text = "ذخیره";
            this.btnSaveTheme.Click += new System.EventHandler(this.btnSaveTheme_Click);
            // 
            // frmChangeTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 94);
            this.Controls.Add(this.groupPanel1);
            this.DoubleBuffered = true;
            this.EnableGlass = false;
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChangeTheme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تغییر پوسته";
            this.Load += new System.EventHandler(this.frmChangeTheme_Load);
            this.groupPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cmbxTheme;
        private DevComponents.Editors.ComboItem Blue;
        private DevComponents.Editors.ComboItem Silver;
        private DevComponents.Editors.ComboItem Black;
        private DevComponents.DotNetBar.ButtonX btnSaveTheme;
    }
}