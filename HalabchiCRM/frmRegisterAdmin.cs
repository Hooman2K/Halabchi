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
    public partial class frmRegisterAdmin : Office2007Form
    {
        public frmRegisterAdmin()
        {
            InitializeComponent();
        }
        AESAlgorithm aes = new AESAlgorithm();
        private void frmRegisterAdmin_Load(object sender, EventArgs e)
        {
            cmbxSecurityQuestion.SelectedIndex = 0;
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
                if(txtPassword.Text != txtRePassword.Text)
                {
                    FarsiMessageBox.MessageBox.Show("اخطار", "کلمه عبور و تکرار آن برابر نیست", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    return;
                }
                else
                {
                    using (var db = new HalabchiDB())
                    {
                        User us = new HalabchiCRM.User()
                        {
                            UserName = txtUserName.Text,
                            Password = aes.EncryptText(txtPassword.Text, txtUserName.Text, txtMobile.Text),
                            FName = txtFName.Text,
                            LName = txtLName.Text,
                            Mobile = txtMobile.Text,
                            Email = txtEMail.Text,
                            SecurityQuestion = byte.Parse(cmbxSecurityQuestion.SelectedIndex.ToString()),
                            SecurityQAnswer = aes.EncryptText(txtSecurityAnswer.Text, txtUserName.Text, txtMobile.Text),
                            IsAdmin = true 
                        };
                        db.Users.Add(us);

                        var set = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
                        set.AdminRegister = true;

                        db.SaveChanges();
                        FarsiMessageBox.MessageBox.Show("موفقیت", "مدیر سیستم با موفقیت ثبت نام شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        Application.Restart();
                    }
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
