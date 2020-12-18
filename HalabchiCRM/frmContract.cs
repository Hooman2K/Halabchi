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
    public partial class frmContract : Office2007Form
    {
        public frmContract()
        {
            InitializeComponent();
        }
        string _customerID = "";
        string _factoryName = "";
        public class TypeOf
        {
            //کلاس جهت مقدار دهی دیتا گرید
            public string CustomerID { get; set; }
            public string ContractID { get; set; }
            public string FactoryName { get; set; }
            public string ProductCode { get; set; }
            public string ProductName { get; set; }
            public string ProductUnit { get; set; }
        }
        private void AutoComplit()
        {
            using (var db = new HalabchiDB())
            {
                var cu = from n in db.Customers select n.FactoryName;
                var pu = from m in db.Products select m.ProductName;

                AutoCompleteStringCollection autoCu = new AutoCompleteStringCollection();
                AutoCompleteStringCollection autoPu = new AutoCompleteStringCollection();

                autoCu.AddRange(cu.ToArray());
                txtFactoryName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtFactoryName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtFactoryName.AutoCompleteCustomSource = autoCu;

                autoPu.AddRange(pu.ToArray());
                txtProductName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtProductName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtProductName.AutoCompleteCustomSource = autoPu;
            }
        }
        private void frmContract_Load(object sender, EventArgs e)
        {
            AutoComplit();
            grbxType.Enabled = false;
            btnConfirm.Enabled = false;
        }

        private void txtFactoryName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtFactoryName.Text != "")
                {
                    using (var db = new HalabchiDB())
                    {
                        var info = db.Customers.Where(u => u.FactoryName == txtFactoryName.Text).FirstOrDefault();
                        lblInfo.Text = "شرکت : " + info.FactoryName + Environment.NewLine + "شماره مشتری : " + info.CustomerID + Environment.NewLine + "نام مدیر عامل : " + info.ManagerName;
                        _customerID = info.CustomerID;
                        _factoryName = info.FactoryName;
                    }
                }
                else
                    lblInfo.Text = "مشخصات مشتری";
            }
            catch (Exception ex)
            {
                lblInfo.Text = "شرکتی با نام فوق یافت نشد";
            }
        }

        private void txtProductName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtProductName.Text != "")
                {
                    using (var db = new HalabchiDB())
                    {
                        var info = db.Products.Where(u => u.ProductName == txtProductName.Text).FirstOrDefault();
                        lblProductCode.Text = "کد کالا : " + info.ProductCode;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        private void btnSetProduct_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var product = db.Products.Where(u => u.ProductName == txtProductName.Text).FirstOrDefault();
                var info = db.Customers.Where(u => u.FactoryName == txtFactoryName.Text).FirstOrDefault();
                if (product != null)
                {
                    var data = new TypeOf
                    {
                        ContractID = txtContractID.Text,
                        CustomerID = info.CustomerID,
                        FactoryName = info.FactoryName,
                        ProductCode = product.ProductCode,
                        ProductName = product.ProductName,
                        ProductUnit = txtProductUnit.Text
                    };
                    dgvProduct.Rows.Add(data.ContractID, data.CustomerID, data.FactoryName, data.ProductCode, data.ProductName, data.ProductUnit);
                    txtProductName.Text = txtProductUnit.Text = "";
                    txtProductName.SelectAll();
                    txtProductName.Focus();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtContractID.Text != "" && txtFactoryName.Text != "" && txtContractDate.Text != "" && txtContractTitle.Text != "")
            {
                using (var db = new HalabchiDB())
                {
                    bool exist = db.Contracts.Where(u => u.ContractID == txtContractID.Text).Any();
                    if (!exist)
                    {
                        grbxContractInfo.Enabled = false;
                        btnRegister.Enabled = false;
                        grbxType.Enabled = true;
                        btnConfirm.Enabled = true;
                        txtProductName.SelectAll();
                        txtProductName.Focus();
                    }
                    else
                        FarsiMessageBox.MessageBox.Show("اخطار", "شماره قرارداد تکراری است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                }
            }
            else
            {
                FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تمامی مشخصات الزامی است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                txtContractID.SelectAll();
                txtContractID.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            grbxContractInfo.Enabled = true;
            btnRegister.Enabled = true;
            grbxType.Enabled = false;
            btnConfirm.Enabled = false;
            dgvProduct.Rows.Clear();
            txtContractID.Text = txtFactoryName.Text = txtContractDate.Text = txtContractTitle.Text = "";
            txtProductName.Text = txtProductUnit.Text = "";
            lblProductCode.Text = "کد کالا : ";
            lblInfo.Text = "مشخصات مشتری";
            txtContractID.SelectAll();
            txtContractID.Focus();
        }

        List<Type> list = new List<Type>();
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DialogResult dr = FarsiMessageBox.MessageBox.Show("تایید نهایی", "در صورت ثبت نهایی قرارداد غیر قابل ویرایش میشود" + Environment.NewLine + "آیا از ادامه کار اطمینان دارید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (dr == DialogResult.Yes)
            {
                using (var db = new HalabchiDB())
                {
                    Contract contract = new Contract()
                    {
                        ContractID = txtContractID.Text,
                        CustomerID = _customerID,
                        FactoryName = _factoryName,
                        ContractDate = txtContractDate.Text,
                        ContractTitle = txtContractTitle.Text
                    };
                    db.Contracts.Add(contract);
                    db.SaveChanges();

                    list.Clear();

                    for (int i = 0; i < dgvProduct.Rows.Count; i++)
                    {
                        list.Add(new Type
                        {
                            ContractID = dgvProduct.Rows[i].Cells[0].Value.ToString(),
                            CustomerID = dgvProduct.Rows[i].Cells[1].Value.ToString(),
                            FactoryName = dgvProduct.Rows[i].Cells[2].Value.ToString(),
                            ProductCode = dgvProduct.Rows[i].Cells[3].Value.ToString(),
                            ProductName = dgvProduct.Rows[i].Cells[4].Value.ToString(),
                            ProductUnit = dgvProduct.Rows[i].Cells[5].Value.ToString()
                        });
                    }
                    db.Types.AddRange(list);
                    db.SaveChanges();
                    FarsiMessageBox.MessageBox.Show("موفقیت", "قرارداد فوق با موفقیت ذخیره شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    btnCancel_Click(null, null);
                    _factoryName = _customerID = "";
                }
            }
        }

        private void txtProductUnit_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo app = new AppInfo();
            app.JustNumber(sender, e);
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            DialogResult dr = FarsiMessageBox.MessageBox.Show("هشدار", "آیا مایل به حذف این سطر میباشید؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
            if (dr == DialogResult.Yes)
            {
                try
                {
                    int index = dgvProduct.CurrentCell.RowIndex;
                    dgvProduct.Rows.RemoveAt(index);
                }
                catch (Exception ex)
                {
                    FarsiMessageBox.MessageBox.Show("اخطار", "سطری انتخاب نشده است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                }
            }
        }
    }
}
