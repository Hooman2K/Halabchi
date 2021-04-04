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
    public partial class frmReportTolidChap : Office2007Form
    {
        public frmReportTolidChap()
        {
            InitializeComponent();
        }

        StiReport report = new StiReport();
        SaveFileDialog _save;

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
            if (txtDate.Text != null)
            {
                using (var db = new HalabchiDB())
                {
                    var date = db.TolidZayeatChaps.Where(u => u.Date == txtDate.Text).ToList();

                    report.Load(Application.StartupPath + "\\TolidZayeatChaps.mrt");
                    report.RegBusinessObject("TolidZayeatChaps", date);
                    report.Render(false);

                    _save = new SaveFileDialog();
                    _save.Filter = "PDF File (.pdf)|*.pdf";

                    if (_save .ShowDialog() == DialogResult.OK)
                    {
                        report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                    }
                }
            }
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            //btn2
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            //btn3
        }
    }
}
