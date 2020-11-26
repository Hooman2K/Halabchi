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
    }
}
