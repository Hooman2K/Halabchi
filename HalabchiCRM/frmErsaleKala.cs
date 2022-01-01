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
    public partial class frmErsaleKala : Office2007Form
    {
        public frmErsaleKala()
        {
            InitializeComponent();
        }

        public void LoadCustomer()
        {
            try
            {
                using (var db = new HalabchiDB())
                {
                    var item = from i in db.Customers select i.FactoryName;

                    if (item != null)
                    {
                        cmbxCustomer.DataSource = item.ToList();
                        cmbxCustomer.SelectedIndex = 0;
                    }
                }
            }
            catch
            {
                return;
            }
        }

        public void LoadContract(string factoryName)
        {
            using (var db = new HalabchiDB())
            {
                var customer = db.Customers.Where(u => u.FactoryName == factoryName).FirstOrDefault();

                var contract = db.Contracts.Where(u => u.CustomerID == customer.CustomerID).ToList();

                dgvContract.DataSource = contract;
            }
        }

        private void frmErsaleKala_Load(object sender, EventArgs e)
        {
            LoadCustomer();
            LoadContract(cmbxCustomer.Text);
        }

        private void cmbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadContract(cmbxCustomer.Text);
        }

        private void dgvContract_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
