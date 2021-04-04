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
            if (txtDate.Text != "")
            {
                using (var db = new HalabchiDB())
                {
                    var date = db.TolidZayeatChaps.Where(u => u.Date == txtDate.Text).ToList();

                    report.Load(Application.StartupPath + "\\TolidZayeatChaps.mrt");
                    report.RegBusinessObject("TolidZayeatChaps", date);
                    report.Render(false);

                    _save = new SaveFileDialog();
                    _save.Filter = "PDF File (.pdf)|*.pdf";

                    if (_save.ShowDialog() == DialogResult.OK)
                    {
                        report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                    }
                }
            }
            else
                FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            if (txtYear1.Text != "")
            {
                using (var db = new HalabchiDB())
                {
                    var year = db.TolidZayeatChaps.Where(u => u.Year == int.Parse(txtYear1.Text)).ToList();

                    report.Load(Application.StartupPath + "\\TolidZayeatChaps.mrt");
                    report.RegBusinessObject("TolidZayeatChaps", year);
                    report.Render(false);

                    _save = new SaveFileDialog();
                    _save.Filter = "PDF File (.pdf)|*.pdf";

                    if (_save.ShowDialog() == DialogResult.OK)
                    {
                        report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                    }
                }
            }
            else
                FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            if (txtYear2.Text != "" && txtMonth.Text !="")
            {
                using (var db = new HalabchiDB())
                {
                    var date = db.TolidZayeatChaps.Where(u => u.Year == int.Parse(txtYear2.Text) && u.Month == byte.Parse(txtMonth.Text)).ToList();

                    report.Load(Application.StartupPath + "\\TolidZayeatChaps.mrt");
                    report.RegBusinessObject("TolidZayeatChaps", date);
                    report.Render(false);

                    _save = new SaveFileDialog();
                    _save.Filter = "PDF File (.pdf)|*.pdf"; 

                    if (_save.ShowDialog() == DialogResult.OK)
                    {
                        report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                    }
                }
            }
            else
                FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
        }
    }
}
