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
    public partial class frmAddProduct : Office2007Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }

        bool _itemSelect = false;
        int _id;

        private void Clear()
        {
            txtProductName.Text = txtProductCode.Text = txtProductCount.Text = txtLastCount.Text = "";
            cmbxUnit.SelectedIndex = 0;
            _itemSelect = false;
            btnAddProduct.Enabled = false;
            cmbxSelectStorage.Enabled = true;
            cmbxUnit.Enabled = true;
            dgvProduct.Enabled = true;
            txtProductCount.Enabled = false;
            txtProductCode.Enabled = txtProductName.Enabled = true;
            txtProductCode.SelectAll();
            txtProductCode.Focus();
        }

        private void LoadStorage()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.Storages select i.StorageName;
                cmbxSelectStorage.DataSource = item.ToList();
                if (item != null)
                    cmbxSelectStorage.SelectedIndex = 0;
            }
        }

        private void LoadProduct(string storage)
        {
            using (var db = new HalabchiDB())
            {
                dgvProduct.DataSource = db.StorageTypes.Where(u => u.StorageName == storage).ToList();
            }
        }
        private void FillData(string storage)
        {
            HalabchiDB db = new HalabchiDB();

            db.StorageTypes.Load();
            dgvProduct.DataSource = db.StorageTypes.Local.Where(u => u.StorageName == storage).ToList();

            var item = db.StorageTypes.AsQueryable();

            if (!string.IsNullOrEmpty(txtProductCode.Text))
                item = item.Where(u => u.ProductCode.Contains(txtProductCode.Text) && u.StorageName == storage);
            if (!string.IsNullOrEmpty(txtProductName.Text))
                item = item.Where(u => u.ProductName.Contains(txtProductName.Text) && u.StorageName == storage);
            else
                item = item.Where(u => u.StorageName == storage);

            dgvProduct.DataSource = item.ToList();
        }

        private void AutoComplit(string storage)
        {
            using (var db = new HalabchiDB())
            {
                var code = from cd in db.StorageTypes where cd.StorageName == storage select cd.ProductCode;
                var name = from na in db.StorageTypes where na.StorageName == storage select na.ProductName;

                AutoCompleteStringCollection autoCode = new AutoCompleteStringCollection();
                AutoCompleteStringCollection autoName = new AutoCompleteStringCollection();

                autoCode.AddRange(code.ToArray());
                txtProductCode.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProductCode.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProductCode.AutoCompleteCustomSource = autoCode;

                autoName.AddRange(name.ToArray());
                txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProductName.AutoCompleteCustomSource = autoName;
            }
        }

        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            LoadStorage();
            LoadProduct(cmbxSelectStorage.Text);
            cmbxUnit.SelectedIndex = 0;
            AutoComplit(cmbxSelectStorage.Text);
            btnAddProduct.Enabled = false;
            txtProductCount.Enabled = false;
        }

        private void cmbxSelectStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtProductCode.Text = txtProductName.Text = "";
            txtProductCode.SelectAll();
            txtProductCode.Focus();
            LoadProduct(cmbxSelectStorage.Text);
            AutoComplit(cmbxSelectStorage.Text);
        }

        private void txtProductCode_TextChanged(object sender, EventArgs e)
        {
            FillData(cmbxSelectStorage.Text);
        }

        private void dgvProduct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _itemSelect = true;
            txtProductCode.Enabled = txtProductName.Enabled = false;
            _id = int.Parse(dgvProduct.CurrentRow.Cells[0].Value.ToString());
            txtProductCode.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtProductName.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            cmbxUnit.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
            txtLastCount.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();

            cmbxSelectStorage.Enabled = false;
            cmbxUnit.Enabled = false;

            txtProductCount.Enabled = true;
            txtProductCount.SelectAll();
            txtProductCount.Focus();

            btnAddProduct.Enabled = true;

            dgvProduct.Enabled = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (_itemSelect == true && txtProductCount.Text != "")
            {
                using (var db = new HalabchiDB())
                {
                    var pro = db.StorageTypes.Where(u => u.ID == _id).FirstOrDefault();
                    pro.ProductUnit = txtLastCount.Text;

                    db.SaveChanges();
                    FarsiMessageBox.MessageBox.Show("موفقیت", "مقدار محصول با موفقیت اضافه شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    Clear();
                    LoadProduct(cmbxSelectStorage.Text);
                    cmbxUnit.SelectedIndex = 0;
                    AutoComplit(cmbxSelectStorage.Text);
                    FillData(cmbxSelectStorage.Text);
                }
            }
            else
            {
                FarsiMessageBox.MessageBox.Show("اخطار", "مقدار جدید محصول وارد نشده است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                Clear();
            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtProductCount_Leave(object sender, EventArgs e)
        {
            if (txtProductCount.Text != "")
            {
                double lastCount = double.Parse(txtLastCount.Text);
                double count = double.Parse(txtProductCount.Text);

                txtLastCount.Text = (lastCount + count).ToString();

                count = 0;
                lastCount = 0;
            }
        }

        private void txtProductCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo pro = new AppInfo();
            pro.JustNumber(sender, e);
        }
    }
}
