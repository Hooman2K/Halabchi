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
    public partial class frmTolidChap : Office2007Form
    {
        public frmTolidChap()
        {
            InitializeComponent();
        }
        DateTime dt;
        private void LoadChap()
        {
            using (var db = new HalabchiDB())
            {
                dgvChap.DataSource = db.TolidZayeatChaps.ToList();
            }
        }
        private void Clear()
        {
            txtDate.Text = txtTedadVorodi.Text = txtTedadChapShode.Text = txtFider.Text = txtChapAval.Text = txtChapDovom.Text = txtVerni.Text = txtKore.Text = txtJamkonAKhar.Text = "";
            txtJameKol.Text = "0";
            txtDate.Focus();
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
        private void frmTolidChap_Load(object sender, EventArgs e)
        {
            LoadChap();
            this.Text = "آمار تولید و ضایعات چاپ" + " " + PersianCalenders();
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
                if (double.Parse(txtTedadVorodi.Text) == double.Parse(txtJameKol.Text))
                {
                    using (var db = new HalabchiDB())
                    {
                        TolidZayeatChap tzch = new TolidZayeatChap()
                        {
                            Year = int.Parse(PC.GetYear(dt).ToString("0000")),
                            Month = byte.Parse(PC.GetMonth(dt).ToString("00")),
                            Day = byte.Parse(PC.GetDayOfMonth(dt).ToString("00")),
                            Date = txtDate.Text,
                            TedadVorodi = float.Parse(txtTedadVorodi.Text),
                            TedadChapShode = float.Parse(txtTedadChapShode.Text),
                            Fider = float.Parse(txtFider.Text),
                            ChapAval = float.Parse(txtChapAval.Text),
                            ChapDovom = float.Parse(txtChapDovom.Text),
                            Verni = float.Parse(txtVerni.Text),
                            Kore = float.Parse(txtKore.Text),
                            JamkonAkhar = float.Parse(txtJamkonAKhar.Text),
                        };
                        db.TolidZayeatChaps.Add(tzch);
                        db.SaveChanges();
                        FarsiMessageBox.MessageBox.Show("موفقیت", "آمار چاپ با موفقیت ثبت شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                        Clear();
                    }
                }
                else
                {
                    FarsiMessageBox.MessageBox.Show("اخطار", "مقدار ورودی و خروجی کالا برابر نیست", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    return;
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Clear();
        }

        private void txtTedadVorodi_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo info = new AppInfo();
            info.JustNumber(sender, e);
        }

        private void txtDate_DoubleClick(object sender, EventArgs e)
        {
            txtDate.Text = PersianCalenders();
        }

        private void txtJamkonAKhar_Leave(object sender, EventArgs e)
        {
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
                return;
            }
            else
            {
                txtJameKol.Text = (double.Parse(txtTedadChapShode.Text) + double.Parse(txtFider.Text) + double.Parse(txtChapAval.Text) + double.Parse(txtChapDovom.Text) + double.Parse(txtVerni.Text) + double.Parse(txtKore.Text) + double.Parse(txtJamkonAKhar.Text)).ToString();
            }
        }
    }
}