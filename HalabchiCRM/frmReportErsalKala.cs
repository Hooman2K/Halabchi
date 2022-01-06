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
    public partial class frmReportErsalKala : Office2007Form
    {
        string _contractId;
        string _customerId;

        public frmReportErsalKala()
        {
            InitializeComponent();
        }

        public void LoadFactory()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.Contracts select i.FactoryName;

                if(item != null)
                {
                    cmbxFactory.DataSource = item.ToList();
                    cmbxFactory.SelectedIndex = 0;
                }
            }
        }

        public void LoadContract(string factoryName)
        {
            using (var db = new HalabchiDB())
            {

                var item = from i in db.Contracts.Where(u => u.FactoryName == factoryName) select i.ContractTitle;
                {
                    cmbxContactTitle.DataSource = item.ToList();
                    cmbxContactTitle.SelectedIndex = 0;
                }
            }
        }

        public void LoadContractItem(string contractId)
        {
            using (var db = new HalabchiDB())
            {

                var item = from i in db.Types.Where(u => u.ContractID == contractId) select i.ProductName;

                if (item != null)
                {
                    cmbxItemContract.DataSource = item.ToList();
                    cmbxItemContract.SelectedIndex = 0;
                }
            }
        }

        private void frmReportErsalKala_Load(object sender, EventArgs e)
        {
            
            LoadFactory();
            LoadContract(cmbxFactory.Text);
            //LoadContractItem();
            LoadItem();
            rbtnAll.Checked = true;
        }

        public void LoadItem(string factoryName)
        {
            using(var db=new HalabchiDB())
            {
                dgvErsal.DataSource = db.Ersalis.Where(u=>u.)ToList();
            }
        }
    }
}
