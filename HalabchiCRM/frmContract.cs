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
                var cu = from n in db.Customers select n.FactoryName;
                AutoCompleteStringCollection auto = new AutoCompleteStringCollection();
                auto.AddRange(cu.ToArray());
                txtFactoryName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                txtFactoryName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtFactoryName.AutoCompleteCustomSource = auto;
            }
        }

        private void txtFactoryName_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txtFactoryName.Text != "")
                {
                    using (var db = new HalabchiDB())
                    {
                        var info = db.Customers.Where(u => u.FactoryName == txtFactoryName.Text).FirstOrDefault();
                        lblInfo.Text = "شرکت : " + info.FactoryName + Environment.NewLine + "شماره مشتری : " + info.CustomerID + Environment.NewLine + "نام مدیر عامل : " + info.ManagerName;
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
