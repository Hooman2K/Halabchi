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
    public partial class frmCustomer : Office2007Form
    {
        public frmCustomer()
        {
            InitializeComponent();
        }

        public bool _isNew = true;
        public int _id;

        private void Clear()
        {
            txtAddress.Text = txtBrand.Text = txtCusromerID.Text = txtEconomyCode.Text = txtEmail.Text = txtFactoryName.Text = txtFax.Text = txtManagerName.Text = txtMobile.Text = txtOther.Text = txtPostCode.Text = txtTell.Text = txtWebSite.Text = null;
            txtCusromerID.Focus();
        }

        public void JustNumber(object sender,KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (_isNew)
            {
                errorProvider1.Clear();
                if (string.IsNullOrEmpty(txtCusromerID.Text))
                {
                    errorProvider1.SetError(txtCusromerID, "شماره مشتری را وارد کنید");
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
                    bool exist = db.Customers.Where(u => u.CustomerID == txtCusromerID.Text).Any();
                    if(exist == false)
                    {
                        Customer cus = new Customer()
                        {
                            CustomerID = txtCusromerID.Text,
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
                            Other = txtOther.Text,
                            Address = txtAddress.Text
                        };
                        db.Customers.Add(cus);
                        db.SaveChanges();
                        FarsiMessageBox.MessageBox.Show("موفقیت", "مشتری جدید با موفقیت ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        Clear();
                    }
                    else
                    {
                        FarsiMessageBox.MessageBox.Show("خطا", "مشتری تکراری است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    }
                }
            }
            else
            {

            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
