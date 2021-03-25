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
    public partial class frmTolidHalabGhoti : Office2007Form
    {
        public frmTolidHalabGhoti()
        {
            InitializeComponent();
        }
        DateTime dt;
        StiReport report = new StiReport();
        SaveFileDialog _save;

        int _id;
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
        private void LoadTolid()
        {
            using (var db = new HalabchiDB())
            {
                dgvTolid.DataSource = db.TolidHalabGhotis.ToList();
            }
        }
        private void Clear()
        {
            txtDate.Text = txtMojodiAval.Text = txtTolid.Text = txtTahvilAnbar.Text = "";
            txtJamKol.Text = txtMandeAkhar.Text = "0";
            cmbxPipeLine.SelectedIndex = 0;
            chbxAmarKhat.Checked = false;
            txtDate.Focus();
        }
        private void AmareKhat(string pipeLineName)
        {
            using (var db = new HalabchiDB())
            {
                dgvTolid.DataSource = db.TolidHalabGhotis.Where(u => u.PipeLineName == pipeLineName).ToList();
            }
        }
        private void frmTolidHalabGhoti_Load(object sender, EventArgs e)
        {
            LoadPipeLine();
            LoadTolid();
            this.Text = "آمار تولیدات" + " " + PersianCalenders();
        }
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
        private void btnRegister_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            lblDate.Text = dt.Year + "/" + dt.Month + "/" + dt.Day;
            PersianCalendar PC = new PersianCalendar();
            dt = DateTime.Parse(lblDate.Text);
            lblDate.Text = PC.GetYear(dt).ToString("0000") + "/" + PC.GetMonth(dt).ToString("00") + "/" + PC.GetDayOfMonth(dt).ToString("00");
            if (string.IsNullOrWhiteSpace(txtMojodiAval.Text) && string.IsNullOrWhiteSpace(txtTolid.Text) && string.IsNullOrWhiteSpace(txtTahvilAnbar.Text))
            {
                FarsiMessageBox.MessageBox.Show("اخطار", "تمامی مقادیر باید پر شوند", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                return;
            }
            else
            {
                using (var db = new HalabchiDB())
                {
                    TolidHalabGhoti tgh = new TolidHalabGhoti()
                    {
                        Year = int.Parse(PC.GetYear(dt).ToString("0000")),
                        Month = byte.Parse(PC.GetMonth(dt).ToString("00")),
                        Day = byte.Parse(PC.GetDayOfMonth(dt).ToString("00")),
                        Date = txtDate.Text,
                        PipeLineName = cmbxPipeLine.Text,
                        MojodiAval = float.Parse(txtMojodiAval.Text),
                        Tolid = float.Parse(txtTolid.Text),
                        JamKol = float.Parse(txtJamKol.Text),
                        TahvilAnbar = float.Parse(txtTahvilAnbar.Text),
                        MandeAkhar = float.Parse(txtMandeAkhar.Text)
                    };
                    db.TolidHalabGhotis.Add(tgh);
                    db.SaveChanges();
                    TahvilAnabr ta = new TahvilAnabr()
                    {
                        Year = int.Parse(PC.GetYear(dt).ToString("0000")),
                        Month = byte.Parse(PC.GetMonth(dt).ToString("00")),
                        Day = byte.Parse(PC.GetDayOfMonth(dt).ToString("00")),
                        Date = txtDate.Text,
                        PipeLineName = cmbxPipeLine.Text,
                        TahvilAnbar = float.Parse(txtTahvilAnbar.Text)
                    };
                    db.TahvilAnabrs.Add(ta);
                    db.SaveChanges();
                    FarsiMessageBox.MessageBox.Show("موفقیت", "آمار با موفقیت ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    Clear();
                    LoadTolid();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtMojodiAval_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo info = new AppInfo();
            info.JustNumber(sender, e);
        }

        private void txtTahvilAnbar_Leave(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtMojodiAval.Text) && !string.IsNullOrWhiteSpace(txtTolid.Text) && !string.IsNullOrWhiteSpace(txtTahvilAnbar.Text))
            {
                txtJamKol.Text = (double.Parse(txtMojodiAval.Text) + double.Parse(txtTolid.Text)).ToString();
                txtMandeAkhar.Text = (double.Parse(txtJamKol.Text) - double.Parse(txtTahvilAnbar.Text)).ToString();
            }
        }

        private void chbxAmarKhat_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAmarKhat.Checked == true)
            {
                txtDate.Enabled = txtMojodiAval.Enabled = txtTolid.Enabled = txtJamKol.Enabled = txtTahvilAnbar.Enabled = txtMandeAkhar.Enabled = false;
                AmareKhat(cmbxPipeLine.Text);
            }
            else
            {
                txtDate.Enabled = txtMojodiAval.Enabled = txtTolid.Enabled = txtJamKol.Enabled = txtTahvilAnbar.Enabled = txtMandeAkhar.Enabled = true;
                Clear();
                LoadTolid();
            }
        }

        private void cmbxPipeLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chbxAmarKhat.Checked == true)
                AmareKhat(cmbxPipeLine.Text);
            else
                return;
        }

        private void txtDate_DoubleClick(object sender, EventArgs e)
        {
            txtDate.Text = PersianCalenders();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var data = db.TolidHalabGhotis.ToList();
                report.Load(Application.StartupPath + "\\Tolid.mrt");
                report.RegBusinessObject("TolidGhoti", data);
                report.Render(false);

                if (_save.ShowDialog() == DialogResult.OK)
                {
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                }

            }
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            report.Load(Application.StartupPath + "\\Tolid.mrt");
            report.RegBusinessObject("TolidGhoti", dgvTolid.DataSource);
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