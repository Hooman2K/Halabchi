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

        private void frmContract_Load(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var cu = db.Customers.FirstOrDefault();
                txtFactoryName.AutoCompleteCustomSource.Add(cu.FactoryName);
                txtFactoryName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            }
        }
    }
}
