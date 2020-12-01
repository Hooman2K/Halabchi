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
                //وارد کردن کدها
            }
        }
    }
}
