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
    public partial class frmUser : Office2007Form
    {
        public frmUser()
        {
            InitializeComponent();
        }
        frmCustomer cu = new frmCustomer();
        public string _userName = "";
        public bool _isNew = true;

        AESAlgorithm aes = new AESAlgorithm();
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            int count = 0;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = c as TextBox;
                    if (string.IsNullOrEmpty(txt.Text))
                        count++;
                }
            }
            if (count > 0)
            {
                FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تمام مقادیر الزامی است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                return;
            }
            else
            {
                if (txtPassword.Text != txtRePassword.Text)
                {
                    FarsiMessageBox.MessageBox.Show("اخطار", "کلمه عبور و تکرار آن برابر نیست", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    return;
                }
                else
                {
                    using (var db = new HalabchiDB())
                    {
                        User us = new User()
                        {
                            UserName = txtUserName.Text.ToLower(),
                            Password = aes.EncryptText(txtPassword.Text, txtUserName.Text.ToLower(), txtMobile.Text),
                            FName = txtFName.Text,
                            LName = txtLName.Text,
                            Mobile = txtMobile.Text,
                            SecurityQAnswer = aes.EncryptText("null", txtUserName.Text.ToLower(), txtMobile.Text),
                            IsAdmin = false
                        };
                        db.Users.Add(us);
                        db.SaveChanges();
                        FarsiMessageBox.MessageBox.Show("موفقیت", "کاربر جدید با موفقیت ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        frmMain main = new frmMain();
                        main.LoadUser();
                        this.Close();
                    }
                }
            }
        }

        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            cu.JustNumber(sender,e);
        }
    }
}
