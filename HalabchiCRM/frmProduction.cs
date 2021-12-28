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
using EntityFramework.Utilities;

using Stimulsoft.Report;

namespace HalabchiCRM
{
    public partial class frmProduction : Office2007Form
    {
        public frmProduction()
        {
            InitializeComponent();
        }

        bool _itemSelect = false;
        int _id;
        int thicknes;
        int _error = 0;
        StiReport report = new StiReport();
        SaveFileDialog _save;

        private void Clear()
        {
            try
            {
                txtProductName.Text = txtProductCode.Text = txtProductCount.Text = txtLastCount.Text = "";
                lblHalab.Text = "-----";
                cmbxUnit.SelectedIndex = 0;
                cmbxFormula.SelectedIndex = 0;
                _itemSelect = false;
                btnAddProduct.Enabled = false;
                cmbxSelectStorage.Enabled = true;
                cmbxUnit.Enabled = true;
                dgvProduct.Enabled = true;
                cmbxFormula.Enabled = false;
                cmbxPipeLine.Enabled = false;
                txtProductCount.Enabled = false;
                btnAdds.Enabled = false;
                txtProductCode.Enabled = txtProductName.Enabled = true;
                txtProductCode.SelectAll();
                txtProductCode.Focus();
                _error = 0;
            }
            catch
            {
                
            }
        }

        private void LoadFormula()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.ProductionFormulaNames select i.FormulaName;
                cmbxFormula.DataSource = item.ToList();
                try
                {
                    if (item != null)
                        cmbxFormula.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    return;
                }
            }
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

        private void LoadPipeLine()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.PipeLines select i.PipeLineName;
                cmbxPipeLine.DataSource = item.ToList();
                try
                {
                    if (item != null)
                        cmbxPipeLine.SelectedIndex = 0;
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

        private int Formula(string thickness)
        {
            switch (thickness)
            {
                case "030": thicknes = 1040; break;
            }
            return thicknes;
        }

        private void frmProduction_Load(object sender, EventArgs e)
        {
            try
            {
                LoadFormula();
                LoadStorage();
                LoadPipeLine();
                LoadProduct(cmbxSelectStorage.Text);
                cmbxUnit.SelectedIndex = 0;
                cmbxFormula.SelectedIndex = 0;
                AutoComplit(cmbxSelectStorage.Text);
                btnAddProduct.Enabled = false;
                cmbxFormula.Enabled = false;
                cmbxPipeLine.Enabled = false;
                txtProductCount.Enabled = false;
                btnAdds.Enabled = false;
            }
            catch
            {
                
            }
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
            cmbxFormula.Enabled = true;
            _id = int.Parse(dgvProduct.CurrentRow.Cells[0].Value.ToString());
            txtProductCode.Text = dgvProduct.CurrentRow.Cells[2].Value.ToString();
            txtProductName.Text = dgvProduct.CurrentRow.Cells[3].Value.ToString();
            txtLastCount.Text = dgvProduct.CurrentRow.Cells[4].Value.ToString();
            cmbxUnit.Text = dgvProduct.CurrentRow.Cells[5].Value.ToString();
            cmbxPipeLine.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();

            cmbxSelectStorage.Enabled = false;
            cmbxUnit.Enabled = false;
            cmbxFormula.Enabled = true;
            cmbxPipeLine.Enabled = true;

            txtProductCount.Enabled = true;
            txtProductCount.SelectAll();
            txtProductCount.Focus();

            btnAddProduct.Enabled = true;
            btnAdds.Enabled = true;

            dgvProduct.Enabled = false;
        }
        List<StorageType> list = new List<StorageType>();
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                list.Clear();
                double mat1 = 0;
                double mat2 = 0;
                double result = 0;

                var id = db.ProductionFormulaNames.Where(u => u.FormulaName == cmbxFormula.Text).FirstOrDefault();

                var item = db.ProductionFormulaTypes.Where(u => u.FormulaID == id.ID);

                foreach (var i in item)
                {
                    var mat = db.StorageTypes.Where(u => u.ProductName == i.MaterialName).FirstOrDefault();

                    mat1 = (double.Parse(i.ProductUnitPerOne) * double.Parse(txtProductCount.Text) / 1000);
                    mat2 = double.Parse(mat.ProductUnit);

                    //if (mat2 < mat1)
                    //{
                    //    FarsiMessageBox.MessageBox.Show("اخطار", "مقدار مواد اولیه انبار از سفارش شما کمتر است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    //    _error++;
                    //    break;
                    //}
                    //else
                    //{
                    result = mat2 - mat1;

                    list.Add(new StorageType
                    {
                        ID = mat.ID,
                        //StorageName = mat.StorageName,
                        //ProductCode = mat.ProductCode,
                        ProductName = mat.ProductName,
                        ProductUnit = result.ToString(),
                        //ProductType = mat.ProductType,
                        //PipeLineName = mat.PipeLineName
                    });
                    mat1 = 0;
                    mat2 = 0;
                    result = 0;
                    //}
                }
                //if (_error > 0)
                //{
                //    Clear();
                //}
                //else
                //{
                EFBatchOperation.For(db, db.StorageTypes).UpdateAll(list, u => u.ColumnsToUpdate(z => z.ProductUnit));
                var pro = db.StorageTypes.Where(u => u.ProductName == txtProductName.Text).FirstOrDefault();
                pro.ProductUnit = txtLastCount.Text;
                pro.PipeLineName = cmbxPipeLine.Text;
                db.SaveChanges();
                FarsiMessageBox.MessageBox.Show("موفقیت", "کالای مورد نظر با موفقیت ساخته و ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                Clear();
                //}

            }
        }

        private void btnCancell_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtProductCount_Leave(object sender, EventArgs e)
        {

        }

        private void txtProductCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo pro = new AppInfo();
            pro.JustNumber(sender, e);
        }

        private void cmbxFormula_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtProductCount.Text != "")
            {
                double mat1 = 0;

                lblHalab.Text = "";

                using (var db = new HalabchiDB())
                {
                    var id = db.ProductionFormulaNames.Where(u => u.FormulaName == cmbxFormula.Text).FirstOrDefault();

                    var item = db.ProductionFormulaTypes.Where(u => u.FormulaID == id.ID);
                    foreach (var i in item)
                    {
                        mat1 = (double.Parse(i.ProductUnitPerOne) * double.Parse(txtProductCount.Text) / 1000);
                        lblHalab.Text += i.MaterialName + " : " + mat1 + Environment.NewLine;
                    }
                }
            }
            else
            {
                lblHalab.Text = "-----";
            }
        }

        private void btnAdds_Click(object sender, EventArgs e)
        {
            double mat1 = 0;

            if (txtProductCount.Text != "")
            {
                lblHalab.Text = "";

                using (var db = new HalabchiDB())
                {
                    var id = db.ProductionFormulaNames.Where(u => u.FormulaName == cmbxFormula.Text).FirstOrDefault();

                    var item = db.ProductionFormulaTypes.Where(u => u.FormulaID == id.ID);
                    foreach (var i in item)
                    {
                        mat1 = (double.Parse(i.ProductUnitPerOne) * double.Parse(txtProductCount.Text) / 1000);
                        lblHalab.Text += i.MaterialName + " : " + mat1 + " Kg " +Environment.NewLine;
                    }
                }
                btnAdds.Enabled = false;
            }
            else
            {
                lblHalab.Text = "-----";
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            report.Load(Application.StartupPath + "\\StorageTypes2.mrt");
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
                var st2 = db.StorageTypes.Where(u => u.StorageName == cmbxSelectStorage.Text).ToList();
                report.Load(Application.StartupPath + "\\StorageTypes2.mrt");
                report.RegBusinessObject("StorageTypes", st2);
                report.Render(false);

                _save = new SaveFileDialog();
                _save.Filter = "PDF File (.pdf)|*.pdf";

                if (_save.ShowDialog() == DialogResult.OK)
                {
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                }
            }
        }
    }
}
