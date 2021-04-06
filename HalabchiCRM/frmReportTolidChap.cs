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

        string _name;
        private void txtYear1_KeyPress(object sender, KeyPressEventArgs e)
        {
            AppInfo info = new AppInfo();
            info.JustNumber(sender, e);
        }
        private void Clear()
        {
            txtDate.Text = txtMonth.Text = txtYear1.Text = txtYear2.Text = txtStartDate.Text = txtEndDate.Text = "";
            txtDate.Focus();
        }

        private void btnReport1_Click(object sender, EventArgs e)
        {
            if (_name == "گزارش تولید و ضایعات چاپ")
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
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
            else if (_name == "گزارش ضایعات قوطی و حلب")
            {
                if (txtDate.Text != "")
                {
                    using (var db = new HalabchiDB())
                    {
                        var date = db.ZayeatHalabGhotis.Where(u => u.Date == txtDate.Text).ToList();

                        report.Load(Application.StartupPath + "\\ZayeatHalabGhotis.mrt");
                        report.RegBusinessObject("ZayeatHalabGhotis", date);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
            else if (_name == "گزارش تولیدات")
            {
                if (txtDate.Text != "")
                {
                    using (var db = new HalabchiDB())
                    {
                        var date = db.TolidHalabGhotis.Where(u => u.Date == txtDate.Text).ToList();

                        report.Load(Application.StartupPath + "\\Tolid.mrt");
                        report.RegBusinessObject("TolidGhoti", date);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
        }

        private void btnReport2_Click(object sender, EventArgs e)
        {
            if (_name == "گزارش تولید و ضایعات چاپ")
            {
                if (txtYear1.Text != "")
                {
                    int year1 = int.Parse(txtYear1.Text);

                    using (var db = new HalabchiDB())
                    {
                        var year = db.TolidZayeatChaps.Where(u => u.Year == year1).ToList();

                        report.Load(Application.StartupPath + "\\TolidZayeatChaps.mrt");
                        report.RegBusinessObject("TolidZayeatChaps", year);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
            else if (_name == "گزارش ضایعات قوطی و حلب")
            {
                if (txtYear1.Text != "")
                {
                    int year1 = int.Parse(txtYear1.Text);

                    using (var db = new HalabchiDB())
                    {
                        var year = db.ZayeatHalabGhotis.Where(u => u.Year == year1).ToList();

                        report.Load(Application.StartupPath + "\\ZayeatHalabGhotis.mrt");
                        report.RegBusinessObject("ZayeatHalabGhotis", year);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
            else if (_name == "گزارش تولیدات")
            {
                if (txtYear1.Text != "")
                {
                    int year1 = int.Parse(txtYear1.Text);

                    using (var db = new HalabchiDB())
                    {
                        var year = db.TolidHalabGhotis.Where(u => u.Year == year1).ToList();

                        report.Load(Application.StartupPath + "\\Tolid.mrt");
                        report.RegBusinessObject("TolidGhoti", year);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
        }

        private void btnReport3_Click(object sender, EventArgs e)
        {
            if (_name == "گزارش تولید و ضایعات چاپ")
            {
                if (txtYear2.Text != "" && txtMonth.Text != "")
                {
                    int year2 = int.Parse(txtYear2.Text);
                    byte month = byte.Parse(txtMonth.Text);

                    using (var db = new HalabchiDB())
                    {
                        var date = db.TolidZayeatChaps.Where(u => u.Year == year2 && u.Month == month).ToList();

                        report.Load(Application.StartupPath + "\\TolidZayeatChaps.mrt");
                        report.RegBusinessObject("TolidZayeatChaps", date);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
            else if (_name == "گزارش ضایعات قوطی و حلب")
            {
                if (txtYear2.Text != "" && txtMonth.Text != "")
                {
                    int year2 = int.Parse(txtYear2.Text);
                    byte month = byte.Parse(txtMonth.Text);

                    using (var db = new HalabchiDB())
                    {
                        var date = db.ZayeatHalabGhotis.Where(u => u.Year == year2 && u.Month == month).ToList();

                        report.Load(Application.StartupPath + "\\ZayeatHalabGhotis.mrt");
                        report.RegBusinessObject("ZayeatHalabGhotis", date);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
            else if (_name == "گزارش تولیدات")
            {
                if (txtYear2.Text != "" && txtMonth.Text != "")
                {
                    int year2 = int.Parse(txtYear2.Text);
                    byte month = byte.Parse(txtMonth.Text);

                    using (var db = new HalabchiDB())
                    {
                        var date = db.TolidHalabGhotis.Where(u => u.Year == year2 && u.Month == month).ToList();

                        report.Load(Application.StartupPath + "\\Tolid.mrt");
                        report.RegBusinessObject("TolidGhoti", date);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
        }

        private void frmReportTolidChap_Load(object sender, EventArgs e)
        {
            _name = this.Text;
        }

        private void btnReport4_Click(object sender, EventArgs e)
        {
            if (_name == "گزارش تولید و ضایعات چاپ")
            {
                if (txtStartDate.Text != "" && txtEndDate.Text != "")
                {
                    string start = txtStartDate.Text;
                    string end = txtEndDate.Text;

                    using (var db = new HalabchiDB())
                    {
                        var date = db.TolidZayeatChaps.Where(u => string.Compare(u.Date, start) >= 0 && string.Compare(u.Date, end) <= 0).ToList();

                        report.Load(Application.StartupPath + "\\TolidZayeatChaps.mrt");
                        report.RegBusinessObject("TolidZayeatChaps", date);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
            else if (_name == "گزارش ضایعات قوطی و حلب")
            {
                if (txtStartDate.Text != "" && txtEndDate.Text != "")
                {
                    string start = txtStartDate.Text;
                    string end = txtEndDate.Text;

                    using (var db = new HalabchiDB())
                    {
                        var date = db.ZayeatHalabGhotis.Where(u => string.Compare(u.Date, start) >= 0 && string.Compare(u.Date, end) <= 0).ToList();

                        report.Load(Application.StartupPath + "\\ZayeatHalabGhotis.mrt");
                        report.RegBusinessObject("ZayeatHalabGhotis", date);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
            else if (_name == "گزارش تولیدات")
            {
                if (txtStartDate.Text != "" && txtEndDate.Text != "")
                {
                    string start = txtStartDate.Text;
                    string end = txtEndDate.Text;

                    using (var db = new HalabchiDB())
                    {
                        var date = db.TolidHalabGhotis.Where(u => string.Compare(u.Date, start) >= 0 && string.Compare(u.Date, end) <= 0).ToList();

                        report.Load(Application.StartupPath + "\\Tolid.mrt");
                        report.RegBusinessObject("TolidGhoti", date);
                        report.Render(false);

                        _save = new SaveFileDialog();
                        _save.Filter = "PDF File (.pdf)|*.pdf";

                        if (_save.ShowDialog() == DialogResult.OK)
                        {
                            report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                            Clear();
                        }
                    }
                }
                else
                    FarsiMessageBox.MessageBox.Show("اخطار", "وارد کردن تاریخ الزامی می باشد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
        }
    }
}
