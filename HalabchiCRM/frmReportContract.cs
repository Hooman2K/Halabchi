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
    public partial class frmReportContract : Office2007Form
    {
        public frmReportContract()
        {
            InitializeComponent();
        }
        private void LoadContract()
        {
            using (var db = new HalabchiDB())
            {
                var shgharardad = from i in db.Contracts select i.ContractID;
                if (shgharardad != null)
                    cmbxContractNumber.DataSource = shgharardad.ToList();

                var shmoshtari = from i in db.Contracts select i.CustomerID;
                if (shmoshtari != null)
                    cmbxCustomerNumber.DataSource = shmoshtari.ToList();

                var nsherkat = from i in db.Contracts select i.FactoryName;
                if (nsherkat != null)
                    cmbxCustomerFactory.DataSource = nsherkat.ToList();
            }
        }

        private void frmReportContract_Load(object sender, EventArgs e)
        {
            LoadContract();
        }

        private void cmbxContractNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new HalabchiDB())
                {
                    var data = db.Contracts.Where(u => u.ContractID == cmbxContractNumber.Text).FirstOrDefault();
                    lblContractFactory.Text = data.FactoryName.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbxCustomerNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new HalabchiDB())
                {
                    var data = from i in db.Contracts where i.CustomerID == cmbxCustomerNumber.Text select i.ContractID;
                    if(data != null)
                        cmbxContractNumber1.DataSource = data.ToList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cmbxCustomerFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                using (var db = new HalabchiDB())
                {
                    var data = from i in db.Contracts where i.FactoryName == cmbxCustomerFactory.Text select i.ContractTitle;
                    if (data != null)
                    {
                        cmbxContractNumber2.DataSource = data.ToList();
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSingleReport1_Click(object sender, EventArgs e)
        {
            //report 1
        }

        private void btnSingleReport2_Click(object sender, EventArgs e)
        {
            //report 2
        }

        private void btnSingleReport3_Click(object sender, EventArgs e)
        {
            //report 3
        }
    }
}
