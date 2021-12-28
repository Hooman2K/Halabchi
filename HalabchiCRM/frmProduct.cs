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

using Stimulsoft.Report;

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
        StiReport report = new StiReport();
        SaveFileDialog _save;

        private void Clear()
        {
            txtProductName.Text = txtProductCode.Text = "";
            //cmbxUnit.SelectedIndex = 0;
            txtProductCode.Enabled = true;
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
                try
                {
                    if (item != null)
                        cmbxSelectStorage.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
        private void LoadProduct(string storage)
        {
            using (var db = new HalabchiDB())
            {
                dgvProduct.DataSource = db.StorageTypes.Where(u => u.StorageName == storage).ToList();
            }
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
            txtProductCode.Enabled = false;
            txtProductName.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            cmbxSelectStorage.Text = dgvProduct.CurrentRow.Cells[1].Value.ToString();
            cmbxUnit.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
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
                                ProductType = cmbxUnit.Text,
                                PipeLineName = "بدون خط تولید"
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

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            report.Load(Application.StartupPath + "\\StorageTypes.mrt");
            report.RegBusinessObject("StorageTypes", dgvProduct.DataSource);
            report.Render(false);

            _save = new SaveFileDialog();
            _save.Filter = "PDF File (.pdf)|*.pdf";

            if (_save.ShowDialog() == DialogResult.OK)
            {
                report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var st = db.StorageTypes.Where(u => u.StorageName == cmbxSelectStorage.Text).ToList();
                report.Load(Application.StartupPath + "\\StorageTypes.mrt");
                report.RegBusinessObject("StorageTypes", st);
                report.Render(false);

                _save = new SaveFileDialog();
                _save.Filter = "PDF File (.pdf)|*.pdf";

                if (_save.ShowDialog() == DialogResult.OK)
                {
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _isNew = true;
            txtProductCode.Enabled = true;
            txtProductName.Text = txtProductCode.Text = "";
            txtProductCode.Select();
            txtProductCode.Focus();
            btnAddProduct.Text = "اضافه کردن";
            cmbxSelectStorage.SelectedIndex = 0;
            cmbxUnit.SelectedIndex = 0;
        }
    }
}
