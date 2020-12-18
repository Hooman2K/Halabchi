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
using System.IO;

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
        int _time=0;
        DateTime dt;

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
            }
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
            try
            {
                FolderBrowserDialog selectPath = new FolderBrowserDialog();
                if (selectPath.ShowDialog() == DialogResult.OK)
                {
                    if (selectPath.SelectedPath.Length == 3)
                        txtPath.Text = selectPath.SelectedPath + "Backupfile" + "_" + DateTime.Now.Date.Year + DateTime.Now.Date.Month.ToString("00") + DateTime.Now.Date.Day.ToString("00") + "_" + DateTime.Now.TimeOfDay.Hours.ToString("00") + DateTime.Now.TimeOfDay.Minutes.ToString("00") + DateTime.Now.TimeOfDay.Seconds.ToString("00") + ".BAK";
                    else
                        txtPath.Text = selectPath.SelectedPath + "\\Backupfile" + "_" + DateTime.Now.Date.Year + DateTime.Now.Date.Month.ToString("00") + DateTime.Now.Date.Day.ToString("00") + "_" + DateTime.Now.TimeOfDay.Hours.ToString("00") + DateTime.Now.TimeOfDay.Minutes.ToString("00") + DateTime.Now.TimeOfDay.Seconds.ToString("00") + ".BAK";
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
    }
}
