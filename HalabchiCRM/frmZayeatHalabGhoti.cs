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

namespace HalabchiCRM
{
    public partial class frmZayeatHalabGhoti : Office2007Form
    {
        public frmZayeatHalabGhoti()
        {
            InitializeComponent();
        }
        DateTime dt;
        private void Clear()
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = c as TextBox;
                    if (!string.IsNullOrEmpty(txt.Text))
                        txt.ResetText();
                }
            }
            //txtJamekol.Text = "0";
            txtDate.ResetText();
            cmbxPipeLine.SelectedIndex = 0;
            chbxAmarKhat.Checked = false;
            txtDate.Focus();
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
        private void LoadZayeat()
        {
            using (var db = new HalabchiDB())
            {
                dgvZayeat.DataSource = db.ZayeatHalabGhotis.ToList();
            }
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
        private void AmareKhat(string pipeLineName)
        {
            using (var db = new HalabchiDB())
            {
                dgvZayeat.DataSource = db.ZayeatHalabGhotis.Where(u => u.PipeLineName == pipeLineName).ToList();
            }
        }
        private void txtKerling_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo info = new AppInfo();
            info.JustNumber(sender, e);
        }

        private void txtDate_DoubleClick(object sender, EventArgs e)
        {
            txtDate.Text = PersianCalenders();
        }

        private void frmZayeatHalabGhoti_Load(object sender, EventArgs e)
        {
            this.Text = "آمار ضایعات قوطی و حلب" + " " + PersianCalenders();
            LoadPipeLine();
            LoadZayeat();
            chbxAmarKhat.Checked = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void chbxAmarKhat_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxAmarKhat.Checked == true)
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox txt = c as TextBox;
                        txt.Enabled = false;
                        txt.ResetText();
                    }
                }
                txtDate.ResetText();
                txtDate.Enabled = false;
                cmbxPipeLine.SelectedIndex = 0;
                txtDate.Focus();
                AmareKhat(cmbxPipeLine.Text);
            }
            else
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        TextBox txt = c as TextBox;
                        txt.Enabled = true;
                        txt.ResetText();
                    }
                    txtDate.ResetText();
                    txtDate.Enabled = true;
                    cmbxPipeLine.SelectedIndex = 0;
                    txtDate.Focus();
                    LoadZayeat();
                }
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            lblDate.Text = dt.Year + "/" + dt.Month + "/" + dt.Day;
            PersianCalendar PC = new PersianCalendar();
            dt = DateTime.Parse(lblDate.Text);
            lblDate.Text = PC.GetYear(dt).ToString("0000") + "/" + PC.GetMonth(dt).ToString("00") + "/" + PC.GetDayOfMonth(dt).ToString("00");

            int count = 0;
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    TextBox txt = c as TextBox;
                    if (string.IsNullOrEmpty(txt.Text))
                        count++;
                }
            }
            if (count > 0)
            {
                FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تمام مقادیر الزامی است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                return;
            }
            else
            {
                using (var db = new HalabchiDB())
                {
                    ZayeatHalabGhoti zgh = new ZayeatHalabGhoti()
                    {
                        Year = int.Parse(PC.GetYear(dt).ToString("0000")),
                        Month = byte.Parse(PC.GetMonth(dt).ToString("00")),
                        Day = byte.Parse(PC.GetDayOfMonth(dt).ToString("00")),
                        Date = txtDate.Text,
                        PipeLineName = cmbxPipeLine.Text,
                        Gheychi = float.Parse(txtGheychi.Text),
                        Josh = float.Parse(txtJosh.Text),
                        ChaharGosh = float.Parse(txtChargosh.Text),
                        Neyker = float.Parse(txtNeyker.Text),
                        KhatAndaz = float.Parse(txtKhatAndaz.Text),
                        LakPash = float.Parse(txtLakPash.Text),
                        FelanchSar = float.Parse(txtFelanchSar.Text),
                        FelachKaf = float.Parse(txtFelanchKaf.Text),
                        SimerSar = float.Parse(txtSimerSar.Text),
                        SimerKaf = float.Parse(txtSimerKaf.Text),
                        Fider = float.Parse(txtFider.Text),
                        Ghaleb = float.Parse(txtGhaleb.Text),
                        Kerling = float.Parse(txtKerling.Text),
                        LastikZan = float.Parse(txtLastikZani.Text),
                        Kore = float.Parse(txtKore.Text),
                    };
                    db.ZayeatHalabGhotis.Add(zgh);
                    db.SaveChanges();
                    FarsiMessageBox.MessageBox.Show("موفقیت", "ثبت آمار ضایعات با موفقیت انجام شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    LoadZayeat();
                    Clear();
                }
            }
        }

        private void cmbxPipeLine_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (chbxAmarKhat.Checked == true)
                AmareKhat(cmbxPipeLine.Text);
            else
                return;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            //خروجی از جدول
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {
            //PDF
        }
    }
}
