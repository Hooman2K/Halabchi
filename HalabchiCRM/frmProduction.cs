﻿using System;
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
    public partial class frmProduction : Office2007Form
    {
        public frmProduction()
        {
            InitializeComponent();
        }

        bool _itemSelect = false;
        int _id;
        int thicknes;

        private void Clear()
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
            txtProductCode.Enabled = txtProductName.Enabled = true;
            txtProductCode.SelectAll();
            txtProductCode.Focus();
        }

        private void LoadFormula()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.ProductionFormulaNames select i.FormulaName;
                cmbxFormula.DataSource = item.ToList();
                if (item != null)
                    cmbxFormula.SelectedIndex = 0;
            }
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

        private void LoadPipeLine()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.PipeLines select i.PipeLineName;
                cmbxPipeLine.DataSource = item.ToList();
                if (item != null)
                    cmbxPipeLine.SelectedIndex = 0;
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

        private void button1_Click(object sender, EventArgs e)
        {

            //عدد تایع 885*700*030 برابر 1040 است
            //Formula form = new Formula();
            //label1.Text = form.Hefdah885030(int.Parse(textBox1.Text)).ToString() + " " + "Kg";

            //label1.Text = ((double.Parse(textBox1.Text) * 1040) / 1000).ToString() + " " + "Kg";
        }

        private void frmProduction_Load(object sender, EventArgs e)
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
            cmbxFormula.Text = dgvProduct.CurrentRow.Cells[6].Value.ToString();

            cmbxSelectStorage.Enabled = false;
            cmbxUnit.Enabled = false;
            cmbxFormula.Enabled = true;
            cmbxPipeLine.Enabled = true;

            txtProductCount.Enabled = true;
            txtProductCount.SelectAll();
            txtProductCount.Focus();

            btnAddProduct.Enabled = true;

            dgvProduct.Enabled = false;
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {

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
                lblHalab.Text = "";

                using (var db = new HalabchiDB())
                {
                    var id = db.ProductionFormulaNames.Where(u => u.FormulaName == cmbxFormula.Text).FirstOrDefault();

                    var item = db.ProductionFormulaTypes.Where(u => u.FormulaID == id.ID);
                    foreach (var i in item)
                    {
                        lblHalab.Text += i.MaterialName + " : " + (double.Parse(i.ProductUnitPerOne)*double.Parse(txtLastCount.Text)/1000) + Environment.NewLine;
                    }
                }
            }
            else
            {
                lblHalab.Text = "0";
            }
        }

        private void txtProductCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo pro = new AppInfo();
            pro.JustNumber(sender, e);
        }
    }
}
