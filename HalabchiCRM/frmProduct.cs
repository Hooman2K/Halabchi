using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HalabchiCRM
{
    public partial class frmProduct : Office2007Form
    {
        public frmProduct()
        {
            InitializeComponent();
        }

        private void txtProductUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo info = new AppInfo();
            info.JustNumber(sender, e);
        }

        private void brnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtProductCode.Text != "" && txtProductName.Text != "")
            {
                using (var db = new HalabchiDB())
                {
                    bool exist = db.Products.Where(u => u.ProductCode == txtProductCode.Text).Any();
                }
            }
        }
    }
}
