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
using System.Globalization;

using Stimulsoft.Report;

namespace HalabchiCRM
{
    public partial class frmAnbar : Office2007Form
    {
        public frmAnbar()
        {
            InitializeComponent();
        }
        DateTime dt;

        StiReport report = new StiReport();
        SaveFileDialog _save;
        private string PersianCalenders()
        {
            string date = "";
            dt = DateTime.Now;
            lblDate.Text = dt.Year + "/" + dt.Month + "/" + dt.Day;
            PersianCalendar PC = new PersianCalendar();
            dt = DateTime.Parse(lblDate.Text);
            lblDate.Text = PC.GetYear(dt).ToString("0000") + "/" + PC.GetMonth(dt).ToString("00") + "/" + PC.GetDayOfMonth(dt).ToString("00");
            date = lblDate.Text;
            return date;
        }
        private void LoadAnbar()
        {
            using (var db = new HalabchiDB())
            {
                dgvAnbar.DataSource = db.TahvilAnabrs.ToList();
            }
        }
        private void LoadPipeLine()
        {
            using (var db = new HalabchiDB())
            {
                var item = from i in db.PipeLines select i.PipeLineName;
                cmbxPipeLine.DataSource = item.ToList();
                try
                {
                    if (item != null)
                        cmbxPipeLine.SelectedIndex = 0;
                }
                catch (Exception)
                {
                    return;
                }
            }
        }
        private void Mojodi(string pipeLineName)
        {
            using (var db = new HalabchiDB())
            {
                dgvAnbar.DataSource = db.TahvilAnabrs.Where(u => u.PipeLineName == pipeLineName).ToList();
            }
        }
        private void frmAnbar_Load(object sender, EventArgs e)
        {
            LoadAnbar();
            LoadPipeLine();
            this.Text = "نمایش انبار" + " " + PersianCalenders();
        }

        private void cmbxPipeLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbxPipeLine.SelectedIndex == 0)
            {
                LoadAnbar();
            }
            else
            {
                Mojodi(cmbxPipeLine.Text);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var anbar = db.TahvilAnabrs.ToList();
                report.Load(Application.StartupPath + "\\TahvilAnbar.mrt");
                report.RegBusinessObject("TahvilAnbar", dgvAnbar.DataSource);
                report.Render(false);

                _save = new SaveFileDialog();
                _save.Filter = "PDF File (.pdf)|*.pdf";
                if (_save.ShowDialog() == DialogResult.OK)
                {
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                }
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var anbar = db.TahvilAnabrs.ToList();
                report.Load(Application.StartupPath + "\\TahvilAnbar.mrt");
                report.RegBusinessObject("TahvilAnbar", anbar);
                report.Render(false);

                _save = new SaveFileDialog();
                _save.Filter = "PDF File (.pdf)|*.pdf";
                if (_save.ShowDialog() == DialogResult.OK)
                {
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                }
            }
        }
    }
}
