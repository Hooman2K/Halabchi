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
    public partial class frmAddProduct : Office2007Form
    {
        public frmAddProduct()
        {
            InitializeComponent();
        }
        public bool _isNew = true;
        public int _id;

        private void Clear()
        {
            txtProductName.Text = txtProductCode.Text = txtProductCount.Text = null;
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

        private void LoadAddProduct(string storage)
        {
            using (var db = new HalabchiDB())
            {
                dgvProduct.DataSource = db.StorageTypes.Where(u => u.StorageName == storage).ToList();
            }
        }



        private void frmAddProduct_Load(object sender, EventArgs e)
        {
            LoadStorage();
            LoadAddProduct(cmbxSelectStorage.Text);
            cmbxUnit.SelectedIndex = 0;
        }

        private void cmbxSelectStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAddProduct(cmbxSelectStorage.Text);
        }

        private void dgvProduct_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Cancel(object sender, KeyEventArgs e)
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
                if (txtProductCode.Text != "" && txtProductName.Text != "" && txtProductCount.Text != "")
                {
                    using (var db = new HalabchiDB())
                    {
                        bool exist = db.StorageTypes.Where(u => u.ProductCode == txtProductCode.Text).Any();
                        if(!exist )
                        {
                            StorageType st = new StorageType()
                            {
                                StorageName = cmbxSelectStorage.Text,
                                ProductCode = txtProductCode.Text,
                                ProductName = txtProductName.Text,
                                ProductUnit = txtProductCount.Text,
                                ProductType = cmbxUnit.Text
                            };

                        }
                    }
                }
                else
                {

                }
            }
            else
            {

            }
        }
    }
}
