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
using Stimulsoft.Report;

namespace HalabchiCRM
{
    public partial class frmReportErsalKala : Office2007Form
    {
        string _contractId;
        string _customerId;
        SaveFileDialog _save;
        StiReport report = new StiReport();

        public frmReportErsalKala()
        {
            InitializeComponent();
        }

        public void LoadFactory()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.Customers select i.FactoryName;

                if (item != null)
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

        public void LoadDataGridItem(string contractID, string customerID)
        {
            using (var db = new HalabchiDB())
            {
                dgvErsal.DataSource = db.Ersalis.Where(u => u.ContractID == contractID && u.CustomerID == customerID).ToList();
            }
        }

        public void LoadInit(string factoryName, string contractTitle)
        {
            using (var db = new HalabchiDB())
            {
                var item = db.Contracts.Where(u => u.FactoryName == factoryName && u.ContractTitle == contractTitle).FirstOrDefault();
                _contractId = item.ContractID;
                _customerId = item.CustomerID;
            }
        }

        private void frmReportErsalKala_Load(object sender, EventArgs e)
        {
            LoadFactory();
            LoadContract(cmbxFactory.Text);
            LoadInit(cmbxFactory.Text, cmbxContactTitle.Text);
            LoadContractItem(_contractId);
            LoadDataGridItem(_contractId, _customerId);
            rbtnAll.Checked = true;
        }

        private void rbtnAll_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnAll.Checked == true)
            {
                cmbxItemContract.Enabled = false;
            }
        }

        private void rbtnItem_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnItem.Checked == true)
            {
                cmbxItemContract.Enabled = true;
            }
        }

        private void cmbxFactory_SelectedIndexChanged(object sender, EventArgs e)
        {
            frmReportErsalKala_Load(null, null);
        }

        private void cmbxContactTitle_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInit(cmbxFactory.Text, cmbxContactTitle.Text);
            LoadContractItem(_contractId);
            LoadDataGridItem(_contractId, _customerId);
        }

        private void cmbxItemContract_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadInit(cmbxFactory.Text, cmbxContactTitle.Text);
            using (var db = new HalabchiDB())
            {
                dgvErsal.DataSource = db.Ersalis.Where(u => u.ContractID == _contractId && u.CustomerID == _customerId && u.ProductName == cmbxItemContract.Text).ToList();
            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            ADO db = new ADO();

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            dt1 = db.Select("select * from Customers where CustomerID = " + _customerId);
            dt2 = db.Select("select * from Types where CustomerID = " + _customerId + " and ContractID = " + _contractId);
            dt3 = db.Select("select * from Ersalis where CustomerID = " + _customerId + " and ContractID = " + _contractId);

            DataSet ds = new DataSet();
            ds.Merge(dt1);
            ds.Tables[0].TableName = "ReportContract";
            ds.Merge(dt2);
            ds.Tables[1].TableName = "ReportType";
            ds.Merge(dt3);
            ds.Tables[2].TableName = "ReportCustomer";

            report.Load(Application.StartupPath + "\\Ersal.mrt");
            report.RegData(ds);
            report.Render(false);

            _save = new SaveFileDialog();
            _save.Filter = "pdf file (.pdf) | *.pdf";

            if (_save.ShowDialog() == DialogResult.OK)
            {
                report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
            }
        }
    }
}