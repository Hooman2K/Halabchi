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
        public bool _isNew = true;
        public int _id;
        private void Clear()
        {
            txtProductName.Text = txtProductCode.Text = "";
            cmbxUnit.SelectedIndex = 0;
            txtProductCode.SelectAll();
            txtProductCode.Focus();
            _isNew = true;
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

        private void txtProductUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo info = new AppInfo();
            info.JustNumber(sender, e);
        }

        private void brnAddProduct_Click(object sender, EventArgs e)
        {

        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            LoadStorage();
            LoadProduct(cmbxSelectStorage.Text);
            cmbxUnit.SelectedIndex = 0;
        }

        private void cmbxSelectStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProduct(cmbxSelectStorage.Text);
        }

        private void dgvProduct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAddProduct.Text = "ویرایش";
            _isNew = false;
            _id = int.Parse(dgvProduct.CurrentRow.Cells[0].Value.ToString());

            txtProductCode.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtProductName.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            cmbxSelectStorage.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            cmbxUnit.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
        }
        private void Cancel(object sender,KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                btnAddProduct.Text = "اضافه کردن";
                Clear();
            }
        }

        private void txtProductCode_KeyDown(object sender, KeyEventArgs e)
        {
            Cancel(sender, e);
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                if (txtProductCode.Text != "" && txtProductName.Text != "")
                {
                    using (var db = new HalabchiDB())
                    {
                        bool exist = db.StorageTypes.Where(u => u.ProductCode == txtProductCode.Text).Any();
                        if (!exist)
                        {
                            StorageType st = new StorageType()
                            {
                                StorageName = cmbxSelectStorage.Text,
                                ProductCode = txtProductCode.Text,
                                ProductName = txtProductName.Text,
                                ProductUnit = "0",
                                ProductType = cmbxUnit.Text
                            };
                            db.StorageTypes.Add(st);
                            db.SaveChanges();
                            FarsiMessageBox.MessageBox.Show("موفقیت", "محصول جدید با موفقیت اضافه شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                            Clear();
                            LoadProduct(cmbxSelectStorage.Text);
                        }
                        else
                        {
                            FarsiMessageBox.MessageBox.Show("خطا", "کد محصول تکراری است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                            Clear();
                        }
                    }
                }
                else
                {
                    FarsiMessageBox.MessageBox.Show("خطا", "وارد کردن کد محصول و نام محصول اجباری است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    txtProductCode.SelectAll();
                    txtProductCode.Focus();
                }
            }
            else
            {
                using (var db = new HalabchiDB())
                {
                    var product = db.StorageTypes.Where(u => u.ID == _id).FirstOrDefault();
                    product.StorageName = cmbxSelectStorage.Text;
                    product.ProductCode = txtProductCode.Text;
                    product.ProductName = txtProductName.Text;
                    product.ProductType = cmbxUnit.Text;
                    db.SaveChanges();
                    FarsiMessageBox.MessageBox.Show("موفقیت", "محصول با موفقیت ویرایش شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    LoadProduct(cmbxSelectStorage.Text);
                    btnAddProduct.Text = "اضافه کردن";
                    Clear();
                    _isNew = true;
                }
            }
        }
    }
}
