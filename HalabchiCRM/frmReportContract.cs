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
    public partial class frmReportContract : Office2007Form
    {
        public frmReportContract()
        {
            InitializeComponent();
        }

        StiReport report = new StiReport();
        SaveFileDialog _save;

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
            using (var db = new HalabchiDB())
            {
                var data = db.Contracts.Where(u => u.ContractID == cmbxContractNumber.Text).FirstOrDefault();
                string cunumber = data.CustomerID.ToString();
                string connumber = data.ContractID.ToString();

                ADO ad = new HalabchiCRM.ADO();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataSet ds = new DataSet();

                dt1 = ad.Select("select * from Contracts where CustomerID = " + cunumber.ToString() + " and ContractID = " + connumber.ToString());
                dt2 = ad.Select("select * from Types where CustomerID = " + cunumber.ToString() + " and ContractID = " + connumber.ToString());
                dt3 = ad.Select("select * from Customers where CustomerID = " + cunumber.ToString());

                ds.Merge(dt1);
                ds.Tables[0].TableName = "ReportContract";
                ds.Merge(dt2);
                ds.Tables[1].TableName = "ReportType";
                ds.Merge(dt3);
                ds.Tables[2].TableName = "ReportCustomer";

                report.Load(Application.StartupPath + "\\Contracts.mrt");
                report.RegData(ds);
                report.Render(false);

                _save = new SaveFileDialog();
                if (_save.ShowDialog() == DialogResult.OK)
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
            }

        }

        private void btnSingleReport2_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var data = db.Contracts.Where(u => u.ContractID == cmbxContractNumber1.Text && u.CustomerID ==cmbxCustomerNumber.Text ).FirstOrDefault();
                string cunumber = data.CustomerID.ToString();
                string connumber = data.ContractID.ToString();

                ADO ad = new HalabchiCRM.ADO();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataSet ds = new DataSet();

                dt1 = ad.Select("select * from Contracts where CustomerID = " + cunumber.ToString() + " and ContractID = " + connumber.ToString());
                dt2 = ad.Select("select * from Types where CustomerID = " + cunumber.ToString() + " and ContractID = " + connumber.ToString());
                dt3 = ad.Select("select * from Customers where CustomerID = " + cunumber.ToString());

                ds.Merge(dt1);
                ds.Tables[0].TableName = "ReportContract";
                ds.Merge(dt2);
                ds.Tables[1].TableName = "ReportType";
                ds.Merge(dt3);
                ds.Tables[2].TableName = "ReportCustomer";

                report.Load(Application.StartupPath + "\\Contracts.mrt");
                report.RegData(ds);
                report.Render(false);

                _save = new SaveFileDialog();
                if (_save.ShowDialog() == DialogResult.OK)
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
            }
        }

        private void btnSingleReport3_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var data = db.Contracts.Where(u => u.FactoryName == cmbxCustomerFactory.Text && u.ContractTitle ==cmbxContractNumber2.Text  ).FirstOrDefault();
                string cunumber = data.CustomerID.ToString();
                string connumber = data.ContractID.ToString();

                ADO ad = new HalabchiCRM.ADO();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();
                DataSet ds = new DataSet();

                dt1 = ad.Select("select * from Contracts where CustomerID = " + cunumber.ToString() + " and ContractID = " + connumber.ToString());
                dt2 = ad.Select("select * from Types where CustomerID = " + cunumber.ToString() + " and ContractID = " + connumber.ToString());
                dt3 = ad.Select("select * from Customers where CustomerID = " + cunumber.ToString());

                ds.Merge(dt1);
                ds.Tables[0].TableName = "ReportContract";
                ds.Merge(dt2);
                ds.Tables[1].TableName = "ReportType";
                ds.Merge(dt3);
                ds.Tables[2].TableName = "ReportCustomer";

                report.Load(Application.StartupPath + "\\Contracts.mrt");
                report.RegData(ds);
                report.Render(false);

                _save = new SaveFileDialog();
                if (_save.ShowDialog() == DialogResult.OK)
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
            }
        }
    }
}
