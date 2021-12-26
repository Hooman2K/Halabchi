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
    public partial class frmProductionFormula : Office2007Form
    {
        public frmProductionFormula()
        {
            InitializeComponent();
        }
        bool _isNew = true;
        int _id;
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
                var item = from i in db.StorageTypes where i.StorageName == storage select i.ProductName;
                cmbxProductName.DataSource = item.ToList();
                try
                {
                    if (item != null)
                        cmbxProductName.SelectedIndex = 0;
                }
                catch
                {
                    return;
                }
            }
        }
        private void AutoCom()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.StorageTypes where i.StorageName == "مواد اولیه" select i.ProductName;

                AutoCompleteStringCollection autoCom = new AutoCompleteStringCollection();

                autoCom.AddRange(item.ToArray());

                txtMaterial.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtMaterial.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtMaterial.AutoCompleteCustomSource = autoCom;
            }
        }
        private void Clear()
        {
            txtFormulaName.Enabled = true;
            txtFormulaName.Text = "";
            dgvFormula.Rows.Clear();
            _isNew = true;
            txtFormulaName.SelectAll();
            txtFormulaName.Focus();
            grbxProductionFormula.Enabled = false;
        }

        private void LoadFormula()
        {
            using (var db = new HalabchiDB())
            {
                dgvProductionFormula.DataSource = db.ProductionFormulaNames.ToList();
            }
        }

        public class TypeOf
        {
            public int FormulaID { get; set; }
            public string ProductName { get; set; }
            public string MaterialName { get; set; }
            public string ProductUnitPerOne { get; set; }
        }

        private void txtProductUnitPerOne_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (ch == 46 && txtProductUnitPerOne.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void btnAddFormula_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                if (txtFormulaName.Text != "")
                {
                    using (var db = new HalabchiDB())
                    {
                        bool exist = db.ProductionFormulaNames.Where(u => u.FormulaName == txtFormulaName.Text).Any();
                        if (exist)
                        {
                            FarsiMessageBox.MessageBox.Show("اخطار", "نام فرمول تکراری است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                            txtFormulaName.SelectAll();
                            txtFormulaName.Focus();
                            return;
                        }
                        else
                        {
                            ProductionFormulaName fname = new ProductionFormulaName()
                            {
                                FormulaName = txtFormulaName.Text
                            };
                            db.ProductionFormulaNames.Add(fname);
                            db.SaveChanges();
                            FarsiMessageBox.MessageBox.Show("موفقیت", "نام فرمول با موفقیت ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                            txtFormulaName.Enabled = false;
                            grbxProductionFormula.Enabled = true;
                            LoadFormula();
                        }
                    }
                }
            }
            else
            {
                //کدهای آپدیت
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                if (txtFormulaName.Text != "" && txtProductUnitPerOne.Text != "")
                {
                    var id = db.ProductionFormulaNames.Where(u => u.FormulaName == txtFormulaName.Text).FirstOrDefault();
                    var data = new TypeOf
                    {
                        FormulaID = id.ID,
                        ProductName = cmbxProductName.Text,
                        MaterialName = txtMaterial.Text,
                        ProductUnitPerOne = txtProductUnitPerOne.Text
                    };
                    dgvFormula.Rows.Add(data.FormulaID, data.ProductName, data.MaterialName, data.ProductUnitPerOne);
                    txtMaterial.Text = "";
                    txtProductUnitPerOne.Text = "";
                    txtMaterial.Select();
                    txtMaterial.Focus();
                }
            }
        }
        List<ProductionFormulaType> list = new List<ProductionFormulaType>();
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                list.Clear();
                for (int i = 0; i < dgvFormula.Rows.Count; i++)
                {
                    list.Add(new ProductionFormulaType
                    {
                        FormulaID = int.Parse(dgvFormula.Rows[i].Cells[0].Value.ToString()),
                        ProductName = dgvFormula.Rows[i].Cells[1].Value.ToString(),
                        MaterialName = dgvFormula.Rows[i].Cells[2].Value.ToString(),
                        ProductUnitPerOne = dgvFormula.Rows[i].Cells[3].Value.ToString()
                    });
                }
                db.ProductionFormulaTypes.AddRange(list);
                db.SaveChanges();
                FarsiMessageBox.MessageBox.Show("موفقیت", "فرمول ساخت با موفقیت ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                Clear();
            }
        }

        private void frmProductionFormula_Load(object sender, EventArgs e)
        {
            LoadStorage();
            LoadFormula();
            AutoCom();
            LoadProduct(cmbxSelectStorage.Text);
            grbxProductionFormula.Enabled = false;
        }

        private void cmbxSelectStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadProduct(cmbxSelectStorage.Text);
        }

        private void dgvProductionFormula_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                //_isNew = false;
                //_id = int.Parse(dgvProductionFormula.CurrentRow.Cells[0].Value.ToString());
                //txtFormulaName.Text = dgvProductionFormula.CurrentRow.Cells[1].Value.ToString();
                //var data = db.ProductionFormulaTypes.Where(u => u.FormulaID == _id).ToList();
                //dgvFormula.DataSource = data;
                //txtProductName.Text = dgvFormula.CurrentRow.Cells[2].Value.ToString();
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void DeleteF_Click(object sender, EventArgs e)
        {
            DialogResult dr = FarsiMessageBox.MessageBox.Show("هشدار", "آیا مایل به حذف این فرمول میباشید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (dr == DialogResult.Yes)
            {
                if (dgvProductionFormula.SelectedCells.Count > 0)
                {
                    _id = int.Parse(dgvProductionFormula.CurrentRow.Cells[0].Value.ToString());

                    using (var db = new HalabchiDB())
                    {
                        var name = db.ProductionFormulaNames.Where(u => u.ID == _id).FirstOrDefault();
                        var type = db.ProductionFormulaTypes.Where(u => u.FormulaID == _id).ToList();

                        if (name != null)
                        {
                            db.ProductionFormulaNames.Remove(name);
                            db.SaveChanges();
                            LoadFormula();
                        }
                        else
                            return;
                        if (type != null)
                        {
                            db.ProductionFormulaTypes.RemoveRange(type);
                            db.SaveChanges();
                            LoadFormula();
                        }
                        else
                            return;
                    }
                }
                else
                {
                    FarsiMessageBox.MessageBox.Show("هشدار", "هیچ آیتمی انتخاب نشده است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    LoadFormula();
                }
            }
        }
    }
}
