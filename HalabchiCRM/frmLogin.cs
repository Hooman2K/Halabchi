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
    public partial class frmLogin : Office2007Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        AESAlgorithm aes = new AESAlgorithm();

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "" && txtPassword.Text != "")
            {
                using (var db = new HalabchiDB())
                {
                    try
                    {
                        var pas = db.Users.Where(u => u.UserName == txtUserName.Text).FirstOrDefault();
                        string enPas = aes.EncryptText(txtPassword.Text, txtUserName.Text.ToLower(), pas.Mobile);

                        bool exist = db.Users.Where(u => u.UserName == txtUserName.Text && u.Password == enPas).Any();

                        if (exist)
                        {
                            frmMain main = new frmMain();

                            AppInfo.Username = pas.UserName;
                            AppInfo.FName = pas.FName;
                            AppInfo.LName = pas.LName;
                            AppInfo.Mobile = pas.Mobile;
                            AppInfo.IsAdmin = pas.IsAdmin;

                            main.Show();
                            this.Close();
                        }
                        else
                        {
                            FarsiMessageBox.MessageBox.Show("خطا", "نام کاربری یا کلمه عبور صحیح نیست", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                            txtUserName.Text = txtPassword.Text = string.Empty;
                            txtUserName.SelectAll();
                            txtUserName.Focus();
                        }
                    }
                    catch
                    {
                        FarsiMessageBox.MessageBox.Show("خطا", "نام کاربری یا کلمه عبور صحیح نیست", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                        txtUserName.Text = txtPassword.Text = string.Empty;
                        txtUserName.SelectAll();
                        txtUserName.Focus();
                    }
                }
            }
            else
            {
                FarsiMessageBox.MessageBox.Show("خطا", "وارد کردن تمامی موارد الزامی است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
        }

        private void btnForgetPassword_Click(object sender, EventArgs e)
        {
            frmForgetPassword forgetPas = new frmForgetPassword();
            forgetPas.ShowDialog();
        }

        private void chbxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (txtPassword.Text != "")
            {
                txtPassword.UseSystemPasswordChar = !chbxShowPass.Checked;
            }
        }
    }
}
