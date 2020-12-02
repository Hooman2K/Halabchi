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
    public partial class frmForgetPassword : Office2007Form
    {
        public frmForgetPassword()
        {
            InitializeComponent();
        }
        string _pass = "";
        string _answerQuastion;
        AESAlgorithm aes = new AESAlgorithm();
        private void btnInvest_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text != "")
            {
                using (var db = new HalabchiDB())
                {
                    bool exist = db.Users.Where(u => u.UserName == txtUserName.Text).Any();
                    if(exist)
                    {
                        txtUserName.BackColor = Color.YellowGreen;
                        var us = db.Users.Where(u => u.UserName == txtUserName.Text).FirstOrDefault();
                        _pass = aes.DecryptText(us.Password, txtUserName.Text.ToLower(), us.Mobile);
                        _answerQuastion = aes.DecryptText(us.SecurityQAnswer, txtUserName.Text.ToLower(), us.Mobile);
                        cmbxSecurityQuestion.SelectedIndex = us.SecurityQuestion;
                        txtSecurityAnswer.SelectAll();
                        txtSecurityAnswer.Focus();
                    }
                    else
                    {
                        txtUserName.BackColor = Color.Red;
                        FarsiMessageBox.MessageBox.Show("اخطار", "نام کاربری وارد شده صحیح نمی باشد ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                        txtUserName.SelectAll();
                        txtUserName.ResetText();
                        txtUserName.Focus();
                        txtUserName.BackColor = Color.White;
                    }
                }
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (txtSecurityAnswer.Text == _answerQuastion)
                txtPassword.Text = _pass;
            else
            {
                FarsiMessageBox.MessageBox.Show("اخطار", "پاسخ سوال امنیتی صحیح نمی باشد ", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                txtSecurityAnswer.ResetText();
                txtSecurityAnswer.SelectAll();
                txtSecurityAnswer.Focus();
            }
        }
    }
}
