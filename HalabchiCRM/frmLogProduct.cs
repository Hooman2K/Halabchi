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
    public partial class frmLogProduct : Office2007Form
    {
        public frmLogProduct()
        {
            InitializeComponent();
        }

        StiReport report = new StiReport();
        SaveFileDialog _save;


        private void LoadStorage()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.Storages select i.StorageName;
                cmbxStorge.DataSource = item.ToList();
                try
                {
                    if (item != null)
                        cmbxStorge.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    return;
                }
            }
        }

        private void LoadLog()
        {
            using (var db = new HalabchiDB())
            {
                dgvLog.DataSource = db.LogAddProducts.ToList();
            }
        }

        private void frmLogProduct_Load(object sender, EventArgs e)
        {
            LoadStorage();
            LoadLog();
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            report.Load(Application.StartupPath + "\\LogAddProducts.mrt");
            report.RegBusinessObject("LogAddProducts", dgvLog.DataSource);
            report.Render(false);

            _save = new SaveFileDialog();
            _save.Filter = "PDF File (.pdf)|*.pdf";

            if (_save.ShowDialog() == DialogResult.OK)
                report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var lp = db.LogAddProducts.ToList();

                report.Load(Application.StartupPath + "\\LogAddProducts.mrt");
                report.RegBusinessObject("LogAddProducts", "lp");
                report.Render(false);

                _save = new SaveFileDialog();
                _save.Filter = "PDF File (.pdf)|*.pdf";

                if (_save.ShowDialog() == DialogResult.OK)
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
            }
        }

        private void cmbxStorge_SelectedIndexChanged(object sender, EventArgs e)
        {
            //تغییر ایندکس
        }
    }
}
