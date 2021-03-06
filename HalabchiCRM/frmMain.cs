﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;
using System.IO;
using System.Globalization;

using Stimulsoft.Report;

namespace HalabchiCRM
{
    public partial class frmMain : Office2007Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        bool _isBackup = false;
        string _timeLength = string.Empty;
        int _time = 0;
        DateTime dt;

        StiReport report = new StiReport();
        SaveFileDialog _save;

        public class BackupLength
        {
            public DateTime start_time { get; set; }
            public Single percent_complete { get; set; }
            public Int64 estimated_completion_time { get; set; }
        }

        AESAlgorithm aes = new AESAlgorithm();
        private void ChangeTheme(string theme)
        {
            try
            {
                switch (theme)
                {
                    case "آبی": styleManager1.ManagerStyle = eStyle.Office2007Blue; cmbxTheme.SelectedIndex = 0; break;
                    case "خاکستری": styleManager1.ManagerStyle = eStyle.Office2010Silver; cmbxTheme.SelectedIndex = 1; break;
                    case "مشکی": styleManager1.ManagerStyle = eStyle.Office2010Black; cmbxTheme.SelectedIndex = 2; break;
                }
            }
            catch
            {
                return;
            }
        }
        public void LoadCustomer()
        {
            using (var db = new HalabchiDB())
            {
                dgvCustomer.DataSource = db.Customers.ToList();
            }
        }
        public void LoadUser()
        {
            using (var db = new HalabchiDB())
            {
                dgvUser.DataSource = db.Users.ToList();
            }
        }
        public void LoadContract()
        {
            using (var db = new HalabchiDB())
            {
                dgvContract.DataSource = db.Contracts.ToList();
            }
        }
        private void DayOfWeek()
        {
            if (lblDay.Text == "Saturday")
                lblDay.Text = "شنبه";

            else if (lblDay.Text == "Sunday")
                lblDay.Text = "یک شنبه";

            else if (lblDay.Text == "Monday")
                lblDay.Text = "دو شنبه";

            else if (lblDay.Text == "Tuesday")
                lblDay.Text = "سه شنبه";

            else if (lblDay.Text == "Wednesday")
                lblDay.Text = "چهار شنبه";

            else if (lblDate.Text == "Thursday")
                lblDay.Text = "پنج شنبه";

            else if (lblDay.Text == "Friday")
            {
                lblDay.Text = "جمعه";
                lblDay.ForeColor = Color.Red;
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            lblTime.Text = dt.ToString("hh:mm:ss tt");
            lblDate.Text = dt.Year + "/" + dt.Month + "/" + dt.Day;
            System.Globalization.PersianCalendar PC = new System.Globalization.PersianCalendar();
            dt = DateTime.Parse(lblDate.Text);
            lblDate.Text = PC.GetYear(dt).ToString("0000") + "/" + PC.GetMonth(dt).ToString("00") + "/" + PC.GetDayOfMonth(dt).ToString("00");
            lblDay.Text = dt.DayOfWeek.ToString();
            DayOfWeek();

            if (!File.Exists(Path.GetTempPath() + "\\" + "BackupLength.txt"))
            {
                using (FileStream s = File.Open(Path.GetTempPath() + "\\" + "BackupLength.txt", FileMode.CreateNew))
                {
                    using (StreamWriter st = new StreamWriter(s))
                    {
                        st.WriteLine("00:00:00");
                    }
                }
            }

            grbxEditUser.Text = AppInfo.Username + " " + "ویرایش مشخصات";
            lblFullName.Text = AppInfo.FName + " " + AppInfo.LName;
            using (var db = new HalabchiDB())
            {
                //لود کردن پوسته نرم افزار
                var set = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
                ChangeTheme(set.Theme);

                //لود کردن مشخصات کاربر جاری
                var us = db.Users.Where(u => u.UserName == AppInfo.Username).FirstOrDefault();
                txtUserName.Text = AppInfo.Username;
                txtPassword.Text = aes.DecryptText(us.Password, AppInfo.Username, AppInfo.Mobile);
                txtFName.Text = AppInfo.FName;
                txtLName.Text = AppInfo.LName;
                txtMobile.Text = AppInfo.Mobile;
                txtEMail.Text = us.Email;
                cmbxSecurityQuestion.SelectedIndex = us.SecurityQuestion;
                txtSecurityAnswer.Text = aes.DecryptText(us.SecurityQAnswer, AppInfo.Username, AppInfo.Mobile);

                //مخفی کردن لیست مشتری ها در ابتدا
                dgvCustomer.Visible = false;
                btnAddCostomer.Visible = false;
                btnSearchCostomer.Visible = false;

                //لود کردن لیست مشتری ها
                LoadCustomer();

                //لود کردن لیست کاربران
                LoadUser();
                ribbonTabItem7.Enabled = AppInfo.IsAdmin;

                //لود کردن قرارداد ها
                LoadContract();

                LoadSupply();
            }
            grbxAdminTool.Enabled = AppInfo.IsAdmin;
        }

        private void btnSaveTheme_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var theme = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
                theme.Theme = cmbxTheme.Text;
                db.SaveChanges();
                FarsiMessageBox.MessageBox.Show("موفقیت", "پوسته با موفقیت تغییر یافت", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
            }
        }

        private void cmbxTheme_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChangeTheme(cmbxTheme.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_time < 10)
                _time++;
            else
            {
                timer1.Enabled = false;
                lblWelCome.Visible = false;
                dgvCustomer.Visible = true;
                btnAddCostomer.Visible = true;
                btnSearchCostomer.Visible = true;
            }
        }

        private void btnEditCostomer_Click(object sender, EventArgs e)
        {

        }

        private void btnAddCostomer_Click(object sender, EventArgs e)
        {
            frmCustomer customer = new frmCustomer();
            this.Hide();
            customer.ShowDialog();
            this.Show();
            LoadCustomer();
        }

        private void btnNewUser_Click(object sender, EventArgs e)
        {
            frmUser users = new frmUser();
            this.Hide();
            users.ShowDialog();
            this.Show();
            LoadUser();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var us = db.Users.Where(u => u.UserName == txtUserName.Text).FirstOrDefault();
                us.Password = aes.EncryptText(txtPassword.Text, txtUserName.Text.ToLower(), txtMobile.Text);
                us.FName = txtFName.Text;
                us.LName = txtLName.Text;
                us.Email = txtEMail.Text;
                us.SecurityQuestion = byte.Parse(cmbxSecurityQuestion.SelectedIndex.ToString());
                us.SecurityQAnswer = aes.EncryptText(txtSecurityAnswer.Text, txtUserName.Text, txtMobile.Text);
                db.SaveChanges();
                FarsiMessageBox.MessageBox.Show("موفقیت", "کاربر با موفقیت ویرایش شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
            }
        }

        private void btnBrowsBackUp_Click(object sender, EventArgs e)
        {
            PersianCalendar PC = new PersianCalendar();
            try
            {
                FolderBrowserDialog selectPath = new FolderBrowserDialog();
                if (selectPath.ShowDialog() == DialogResult.OK)
                {
                    if (selectPath.SelectedPath.Length == 3)
                        txtPath.Text = selectPath.SelectedPath + "HalabchiBackup" + "_" + PC.GetYear(DateTime.Now).ToString("0000") + "_" + PC.GetMonth(DateTime.Now).ToString("00") + "_" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "_" + DateTime.Now.Hour + DateTime.Now.Minute + ".BAK";
                    else
                        txtPath.Text = selectPath.SelectedPath + "\\HalabchiBackup" + "_" + PC.GetYear(DateTime.Now).ToString("0000") + "_" + PC.GetMonth(DateTime.Now).ToString("00") + "_" + PC.GetDayOfMonth(DateTime.Now).ToString("00") + "_" + DateTime.Now.Hour + DateTime.Now.Minute + ".Bak";
                }
            }
            catch (PathTooLongException)
            {
                FarsiMessageBox.MessageBox.Show("اخطار", "مسیر انتخاب شده طولانی است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
        }

        private void btnStartBackUp_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPath.Text))
                FarsiMessageBox.MessageBox.Show("اخطار", "فایل پشتیبان انتخاب نشده است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            else
            {
                grbxBackup.Enabled = false;
                _isBackup = true;
                if (!backgroundWorker1.IsBusy)
                    backgroundWorker1.RunWorkerAsync();
                timer2.Enabled = true;
            }
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                string command = @"BACKUP DATABASE HalabchiDB TO DISK='" + txtPath.Text + "'WITH INIT";
                db.Database.CommandTimeout = 360;
                db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, command);
            }
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error == null)
            {
                timer2.Enabled = false;
                progressBar1.Value = 100;
                FarsiMessageBox.MessageBox.Show("موفقیت", "از بانک اطلاعاتی با موفقیت پشتیبان گرفته شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);

                //ذخیره مدت زمان طول کشیده بکاپ در فایل
                var lines2 = File.ReadAllLines(Path.GetTempPath() + "\\" + "BackupLength.txt");
                lines2[0] = _timeLength;
                File.WriteAllLines(Path.GetTempPath() + "\\" + "BackupLength.txt", lines2);
            }

            else
                FarsiMessageBox.MessageBox.Show("اخطار", "عملیات پشتیبان گیری متوقف شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);

            timer1.Enabled = false;
            _isBackup = false;
            grbxBackup.Enabled = true;
            progressBar1.Value = 0;
            txtPath.Text = string.Empty;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var list = db.Database.SqlQuery<BackupLength>(@"select top 2 start_time,
 percent_complete, estimated_completion_time
 from sys.dm_exec_requests
order by start_time desc");

                foreach (var p in list)
                {
                    decimal percent = decimal.Parse(p.percent_complete.ToString());
                    int Roundpercent = Int32.Parse(Math.Round(percent).ToString());
                    if (Roundpercent < 98 && Roundpercent != 0)
                        progressBar1.Value = Roundpercent;

                    //گرفتن مدت زمان طول کشیدن برای ریستور
                    if (_timeLength == string.Empty && p.estimated_completion_time != 0)
                    {
                        TimeSpan t = TimeSpan.FromMilliseconds(Int64.Parse(p.estimated_completion_time.ToString()));
                        string formatedTime = string.Format("{0:D2}:{1:D2}:{2:D2}",
                                                t.Hours,
                                                t.Minutes,
                                                t.Seconds);
                        _timeLength = formatedTime;
                    }
                }
            }
        }

        private void btnBrowsRestore_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openBakup = new OpenFileDialog();
                string strfilename = string.Empty;
                openBakup.Filter = @"SQL Backup files files(*.BAK)|*.BAK";
                openBakup.Title = "Select Backup files";
                if (openBakup.ShowDialog() == DialogResult.OK)
                    txtSelectBackupFile.Text = openBakup.FileName;
            }
            catch (PathTooLongException)
            {
                FarsiMessageBox.MessageBox.Show("اخطار", "مسیر انتخاب شده طولانی است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            }
        }

        private void btnStartRestore_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSelectBackupFile.Text))
                FarsiMessageBox.MessageBox.Show("اخطار", "فایل پشتیبان را انتخاب کنید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
            else
            {
                DialogResult dr = FarsiMessageBox.MessageBox.Show("هشدار", "آیا میخواهید فایل پشتیبان، جایگزین بانک فعلی برنامه شود؟(! توجه: بانک فعلی کامل از بین میرود !)؟", FarsiMessageBox.MessageBox.Buttons.YesNo, FarsiMessageBox.MessageBox.Icons.Question);
                if (dr == DialogResult.Yes)
                {
                    grbxRestore.Enabled = false;
                    _isBackup = true;

                    //گرفتن مدت زمان طول کشیدن عمل ریستور از فایل
                    var lines = File.ReadAllLines(Path.GetTempPath() + "\\" + "BackupLength.txt");
                    lblTimeLength.Text = "مدت زمان : " + lines[0];

                    if (!backgroundWorker2.IsBusy)
                        backgroundWorker2.RunWorkerAsync();
                }
            }
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                string command = "ALTER DATABASE HalabchiDB SET OFFLINE WITH ROLLBACK IMMEDIATE " +
    " RESTORE DATABASE HalabchiDB FROM DISK='" + txtSelectBackupFile.Text + "'WITH REPLACE " +
    "ALTER DATABASE HalabchiDB SET ONLINE";

                //می توان اگر پیش بینی میکنید حجم دیتابیس بالاست و بیشتر از 360 ثانیه طول میکشد تغییر دهید و یا از فایلی که مدت زمان طول کشیدن بکاپ ذخیره شده تنظیم کنید
                db.Database.CommandTimeout = 360;
                db.Database.ExecuteSqlCommand(System.Data.Entity.TransactionalBehavior.DoNotEnsureTransaction, command);
            }
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            {
                if (e.Error == null)
                {
                    FarsiMessageBox.MessageBox.Show("موفقیت", "بازیابی با موفقیت انجام شد لازم است نرم افزار مجددا راه اندازی شود", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                    _isBackup = false;
                    Application.Restart();
                }
                else
                {
                    FarsiMessageBox.MessageBox.Show("اخطار", "مشکل در بازیابی،مسیر یا فایل پشتیبان یا دیتابیس را بررسی کنید", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Warning);
                    _isBackup = false;
                }
            }
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            dt = DateTime.Now;
            lblTime.Text = dt.ToString("hh:mm:ss tt");
        }

        private void dgvCustomer_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmCustomer fc = new frmCustomer();
            fc._isNew = false;
            fc._id = int.Parse(dgvCustomer.CurrentRow.Cells[0].Value.ToString());

            fc.txtCusromerID.Text = dgvCustomer.CurrentRow.Cells[1].Value.ToString();
            fc.txtPostCode.Text = dgvCustomer.CurrentRow.Cells[2].Value.ToString();
            fc.txtEconomyCode.Text = dgvCustomer.CurrentRow.Cells[3].Value.ToString();
            fc.txtManagerName.Text = dgvCustomer.CurrentRow.Cells[4].Value.ToString();
            fc.txtMobile.Text = dgvCustomer.CurrentRow.Cells[5].Value.ToString();
            fc.txtFactoryName.Text = dgvCustomer.CurrentRow.Cells[6].Value.ToString();
            fc.txtBrand.Text = dgvCustomer.CurrentRow.Cells[7].Value.ToString();
            fc.txtTell.Text = dgvCustomer.CurrentRow.Cells[8].Value.ToString();
            fc.txtFax.Text = dgvCustomer.CurrentRow.Cells[9].Value.ToString();
            fc.txtEmail.Text = dgvCustomer.CurrentRow.Cells[10].Value.ToString();
            fc.txtWebSite.Text = dgvCustomer.CurrentRow.Cells[11].Value.ToString();
            fc.txtOther.Text = dgvCustomer.CurrentRow.Cells[12].Value.ToString();
            fc.txtAddress.Text = dgvCustomer.CurrentRow.Cells[13].Value.ToString();
            fc.ShowDialog();
            LoadCustomer();
        }

        private void btnEditCustomer_Click(object sender, EventArgs e)
        {
            dgvCustomer_CellContentDoubleClick(null, null);
        }

        private void dgvUser_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmUser us = new frmUser();
            us._isNew = false;
            us._userName = dgvUser.CurrentRow.Cells[0].Value.ToString();

            us.txtUserName.Text = dgvUser.CurrentRow.Cells[0].Value.ToString();
            us.txtPassword.Text = aes.DecryptText(dgvUser.CurrentRow.Cells[1].Value.ToString(), us._userName, dgvUser.CurrentRow.Cells[4].Value.ToString());
            us.txtFName.Text = dgvUser.CurrentRow.Cells[2].Value.ToString();
            us.txtLName.Text = dgvUser.CurrentRow.Cells[3].Value.ToString();
            us.txtMobile.Text = dgvUser.CurrentRow.Cells[4].Value.ToString();
            us.ShowDialog();
            LoadUser();
        }

        private void btnEditUser_Click(object sender, EventArgs e)
        {
            dgvUser_CellContentDoubleClick(null, null);
        }

        private void btnSearchCostomer_Click(object sender, EventArgs e)
        {
            frmSearchCustomer searchCustomer = new frmSearchCustomer();
            searchCustomer.ShowDialog();
        }

        private void btnNewContract_Click(object sender, EventArgs e)
        {
            frmContract fc = new frmContract();
            fc.ShowDialog();
            LoadContract();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            frmProduct product = new frmProduct();
            this.Hide();
            product.ShowDialog();
            this.Show();

        }

        private void btnStorage_Click(object sender, EventArgs e)
        {
            frmStorage stor = new frmStorage();
            this.Hide();
            stor.ShowDialog();
            this.Show();
        }

        private void btnEdit_Click_1(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var user = db.Users.Where(u => u.UserName == AppInfo.Username).FirstOrDefault();
                user.Password = aes.EncryptText(txtPassword.Text, txtUserName.Text, txtMobile.Text);
                user.FName = txtFName.Text;
                user.LName = txtLName.Text;
                user.Email = txtEMail.Text;
                user.SecurityQuestion = byte.Parse(cmbxSecurityQuestion.SelectedIndex.ToString());
                user.SecurityQAnswer = aes.EncryptText(txtSecurityAnswer.Text, txtUserName.Text, txtMobile.Text);
                db.SaveChanges();
                FarsiMessageBox.MessageBox.Show("موفقیت", "اطلاعات شما با موفقیت ویرایش شد", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
            }
        }

        private void btnPipeLine_Click(object sender, EventArgs e)
        {
            frmPipeLine pipeline = new frmPipeLine();
            this.Hide();
            pipeline.ShowDialog();
            this.Show();
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmAddProduct addProduct = new frmAddProduct();
            this.Hide();
            addProduct.ShowDialog();
            this.Show();
        }

        private void btnProduction_Click(object sender, EventArgs e)
        {
            frmProduction production = new frmProduction();
            this.Hide();
            production.ShowDialog();
            this.Show();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            frmProductionFormula pf = new frmProductionFormula();
            this.Hide();
            pf.ShowDialog();
            this.Show();
        }

        private void btnTolidHalabGhoti_Click(object sender, EventArgs e)
        {
            frmTolidHalabGhoti thg = new frmTolidHalabGhoti();
            this.Hide();
            thg.ShowDialog();
            this.Show();
        }

        private void btnChap_Click(object sender, EventArgs e)
        {
            frmTolidChap tch = new frmTolidChap();
            this.Hide();
            tch.ShowDialog();
            this.Show();
        }

        private void btnAnbar_Click(object sender, EventArgs e)
        {
            frmAnbar anbar = new frmAnbar();
            this.Hide();
            anbar.ShowDialog();
            this.Show();
        }

        private void btnZayeat_Click(object sender, EventArgs e)
        {
            frmZayeatHalabGhoti zgh = new frmZayeatHalabGhoti();
            this.Hide();
            zgh.ShowDialog();
            this.Show();
        }

        private void btnReportCustomer_Click(object sender, EventArgs e)
        {
            frmReportCustomer rcustomer = new frmReportCustomer();
            this.Hide();
            rcustomer.ShowDialog();
            this.Show();
        }

        private void btnReportContract_Click(object sender, EventArgs e)
        {
            frmReportContract rcontract = new frmReportContract();
            this.Hide();
            rcontract.ShowDialog();
            this.Show();
        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            frmReportTolidChap rtolidChap = new frmReportTolidChap();
            this.Hide();
            rtolidChap.ShowDialog();
            this.Show();
        }

        private void buttonItem5_Click(object sender, EventArgs e)
        {
            //از جدول
        }

        private void buttonItem6_Click(object sender, EventArgs e)
        {
            //PDF
        }

        private void dgvContract_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = dgvContract.CurrentRow.Cells[2].Value.ToString();
            string id2 = dgvContract.CurrentRow.Cells[1].Value.ToString();

            ADO db = new ADO();

            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();

            dt1 = db.Select("select * from Contracts where CustomerID = " + id2.ToString() + " and ContractID = " + id.ToString());
            dt2 = db.Select("select * from Types where CustomerID = " + id2.ToString() + " and ContractID = " + id.ToString());
            dt3 = db.Select("select * from Customers where CustomerID = " + id2.ToString());

            DataSet ds = new DataSet();
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
            {
                report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
            }
        }

        private void btnReportTolidGhotiHalab_Click(object sender, EventArgs e)
        {
            frmReportTolidChap rtolidChap = new frmReportTolidChap();
            this.Hide();
            rtolidChap.Text = btnReportTolidGhotiHalab.Text;
            rtolidChap.ShowDialog();
            this.Show();
        }

        private void btnReportAmarTolidat_Click(object sender, EventArgs e)
        {
            frmReportTolidChap rtolidChap = new frmReportTolidChap();
            this.Hide();
            rtolidChap.Text = btnReportAmarTolidat.Text;
            rtolidChap.ShowDialog();
            this.Show();
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            frmLogProduct lp = new frmLogProduct();
            this.Hide();
            lp.ShowDialog();
            this.Show();
        }

        private void btnAddSupply_Click(object sender, EventArgs e)
        {
            frmSupply supply = new frmSupply();
            this.Hide();
            supply.ShowDialog();
            this.Show();
            LoadSupply();
        }

        private void buttonItem5_Click_1(object sender, EventArgs e)
        {
            report.Load(Application.StartupPath + "\\Supplys.mrt");
            report.RegBusinessObject("Supplys", dgvSupply.DataSource);
            report.Render(false);

            _save = new SaveFileDialog();
            _save.Filter = "PDF File (.pdf)|*.pdf";

            if (_save.ShowDialog() == DialogResult.OK)
            {
                report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
            }
        }

        private void buttonItem6_Click_1(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var sup = db.Supplys.ToList();
                report.Load(Application.StartupPath + "\\Supplys.mrt");
                report.RegBusinessObject("Supplys", sup);
                report.Render(false);

                _save = new SaveFileDialog();
                _save.Filter = "PDF File (.pdf)|*.pdf";

                if (_save .ShowDialog()==DialogResult.OK)
                {
                    report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
                }
            }
        }
        private void LoadSupply()
        {
            using (var db = new HalabchiDB())
            {
                dgvSupply.DataSource = db.Supplys.ToList();
            }
        }
    }
}