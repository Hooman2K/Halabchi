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
    public partial class frmSupply : Office2007Form
    {
        public frmSupply()
        {
            InitializeComponent();
        }

        public bool _isNew = true;
        public int _id;

        private void Clear()
        {
            txtAddress.Text = txtBrand.Text = txtSupplyID.Text = txtEconomyCode.Text = txtEmail.Text = txtFactoryName.Text = txtFax.Text = txtManagerName.Text = txtMobile.Text = txtSupply.Text = txtPostCode.Text = txtTell.Text = txtWebSite.Text = null;
            txtSupplyID.Focus();
        }

        public void JustNumber(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(txtSupplyID.Text))
                {
                    errorProvider1.SetError(txtSupplyID, "شماره تامین کننده را وارد کنید");
                    return;
                }
                else if (string.IsNullOrEmpty(txtManagerName.Text))
                {
                    errorProvider1.SetError(txtManagerName, "نام مدیرعامل را وارد کنید");
                    return;
                }
                else if (string.IsNullOrEmpty(txtMobile.Text))
                {
                    errorProvider1.SetError(txtMobile, "شماره موبایل را وارد کنید");
                    return;
                }
                else if (string.IsNullOrEmpty(txtFactoryName.Text))
                {
                    errorProvider1.SetError(txtFactoryName, "نام کارخانه را وارد کنید");
                    return;
                }
                else if (string.IsNullOrEmpty(txtBrand.Text))
                {
                    errorProvider1.SetError(txtBrand, "نام برند را وارد کنید");
                    return;
                }
                else if (string.IsNullOrEmpty(txtTell.Text))
                {
                    errorProvider1.SetError(txtTell, "شماره تلفن را وارد کنید");
                    return;
                }
                else if (string.IsNullOrEmpty(txtAddress.Text))
                {
                    errorProvider1.SetError(txtAddress, "آدرس را وارد کنید");
                    return;
                }

                using (var db = new HalabchiDB())
                {
                    bool exist = db.Supplys.Where(u => u.SupplyID == txtSupplyID.Text).Any();
                    if (exist == false)
                    {
                        Supply sup = new Supply()
                        {
                            SupplyID = txtSupplyID.Text,
                            PostCode = txtPostCode.Text,
                            EconomyCode = txtEconomyCode.Text,
                            ManagerName = txtManagerName.Text,
                            Mobile = txtMobile.Text,
                            FactoryName = txtFactoryName.Text,
                            Brand = txtBrand.Text,
                            Tell = txtTell.Text,
                            Fax = txtFax.Text,
                            Email = txtEmail.Text,
                            WebSite = txtWebSite.Text,
                            SupplyList = txtSupply.Text,
                            Address = txtAddress.Text
                        };
                        db.Supplys.Add(sup);
                        db.SaveChanges();
                        FarsiMessageBox.MessageBox.Show("موفقیت", "تامین کننده جدید با موفقیت ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        Clear();
                    }
                    else
                    {
                        FarsiMessageBox.MessageBox.Show("خطا", "تامین کننده تکراری است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    }
                }
            }
            else
            {
                using (var db = new HalabchiDB())
                {
                    var cus = db.Supplys.Where(u => u.ID == _id).FirstOrDefault();
                    cus.PostCode = txtPostCode.Text;
                    cus.EconomyCode = txtEconomyCode.Text;
                    cus.ManagerName = txtManagerName.Text;
                    cus.Mobile = txtMobile.Text;
                    cus.FactoryName = txtFactoryName.Text;
                    cus.Brand = txtBrand.Text;
                    cus.Tell = txtTell.Text;
                    cus.Fax = txtFax.Text;
                    cus.Email = txtEmail.Text;
                    cus.WebSite = txtWebSite.Text;
                    cus.SupplyList = txtSupply.Text;
                    cus.Address = txtAddress.Text;

                    db.SaveChanges();
                    FarsiMessageBox.MessageBox.Show("موفقیت", "تامین کننده با موفقیت ویرایش شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    _isNew = true;
                    Clear();
                    this.Close();
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void frmSupply_Load(object sender, EventArgs e)
        {
            txtSupplyID.Enabled = _isNew;
        }
    }
}
