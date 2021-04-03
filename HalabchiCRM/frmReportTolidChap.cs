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
    public partial class frmReportTolidChap : Office2007Form
    {
        public frmReportTolidChap()
        {
            InitializeComponent();
        }

        private void txtYear1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo info = new AppInfo();
            info.JustNumber(sender, e);
        }
        private void Clear()
        {
            txtDate.Text = txtMonth.Text = txtYear1.Text = txtYear2.Text = "";
            txtDate.Focus();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
