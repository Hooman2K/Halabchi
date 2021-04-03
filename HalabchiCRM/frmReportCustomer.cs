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
    public partial class frmReportCustomer : Office2007Form
    {
        public frmReportCustomer()
        {
            InitializeComponent();
        }
        HalabchiDB db = new HalabchiDB();
        AppInfo app = new AppInfo();

        private void frmReportCustomer_Load(object sender, EventArgs e)
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
                cu = cu.Where(u => u.CustomerID.Contains(txtCusromerID.Text));
            if (!string.IsNullOrEmpty(txtMobile.Text))
                cu = cu.Where(u => u.Mobile.Contains(txtMobile.Text));
            if (!string.IsNullOrEmpty(txtFactoryName.Text))
                cu = cu.Where(u => u.FactoryName.Contains(txtFactoryName.Text));
            if (!string.IsNullOrEmpty(txtManagerName.Text))
                cu = cu.Where(u => u.ManagerName.Contains(txtManagerName.Text));
            if (!string.IsNullOrEmpty(txtTell.Text))
                cu = cu.Where(u => u.Tell.Contains(txtTell.Text));
            if (!string.IsNullOrEmpty(txtBrand.Text))
                cu = cu.Where(u => u.Brand.Contains(txtBrand.Text));

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

        private void dgvCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCustomer fc = new frmCustomer();
            fc.txtCusromerID.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            fc.txtPostCode.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            fc.txtEconomyCode.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            fc.txtManagerName.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            fc.txtMobile.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            fc.txtFactoryName.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
            fc.txtBrand.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
            fc.txtTell.Text = dgvCustomer.CurrentRow.Cells[8].Value.ToString();
            fc.txtFax.Text = dgvCustomer.CurrentRow.Cells[9].Value.ToString();
            fc.txtEmail.Text = dgvCustomer.CurrentRow.Cells[10].Value.ToString();
            fc.txtWebSite.Text = dgvCustomer.CurrentRow.Cells[11].Value.ToString();
            fc.txtOther.Text = dgvCustomer.CurrentRow.Cells[12].Value.ToString();
            fc.txtAddress.Text = dgvCustomer.CurrentRow.Cells[13].Value.ToString();
            fc.btnRegister.Enabled = false;
            fc.btnClear.Enabled = false;
            fc.ShowDialog();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            //از جدول
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            //PDF
        }
    }
}
