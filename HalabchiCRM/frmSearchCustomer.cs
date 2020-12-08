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
using System.Data.Entity;

namespace HalabchiCRM
{
    public partial class frmSearchCustomer : Office2007Form
    {
        public frmSearchCustomer()
        {
            InitializeComponent();
        }
        HalabchiDB db = new HalabchiDB();
        AppInfo app = new AppInfo();

        private void frmSearchCustomer_Load(object sender, EventArgs e)
        {
            db.Customers.Load();
            dgvCustomer.DataSource = db.Customers.Local.ToBindingList();
            txtCusromerID.SelectAll();
            txtCusromerID.Focus();
        }
        private void FillData()
        {
            var cu = db.Customers.AsQueryable();

            if (!string.IsNullOrEmpty(txtCusromerID.Text))
                cu = cu.Where(u => u.CustomerID == txtCusromerID.Text);
            if (!string.IsNullOrEmpty(txtMobile.Text))
                cu = cu.Where(u => u.Mobile == txtMobile.Text);
            if (!string.IsNullOrEmpty(txtFactoryName.Text))
                cu = cu.Where(u => u.FactoryName == txtFactoryName.Text);
            if (!string.IsNullOrEmpty(txtManagerName.Text))
                cu = cu.Where(u => u.ManagerName == txtManagerName.Text);
            if (!string.IsNullOrEmpty(txtTell.Text))
                cu = cu.Where(u => u.Tell == txtTell.Text);
            if (!string.IsNullOrEmpty(txtBrand.Text))
                cu = cu.Where(u => u.Brand == txtBrand.Text);

            dgvCustomer.DataSource = cu.ToList();
        }

        private void txtCusromerID_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void txtMobile_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void txtFactoryName_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void txtManagerName_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void txtTell_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void txtBrand_TextChanged(object sender, EventArgs e)
        {
            FillData();
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            app.JustNumber(sender, e);
        }
    }
}
