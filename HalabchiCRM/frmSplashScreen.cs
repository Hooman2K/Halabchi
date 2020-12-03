using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;

namespace HalabchiCRM
{
    public partial class frmSplashScreen : Office2007Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            using (var db = new HalabchiDB())
            {
                var set = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
                switch (set.Theme)
                {
                    case "مشکی": styleManager1.ManagerStyle = eStyle.Office2010Black; break;
                    case "خاکستری": styleManager1.ManagerStyle = eStyle.Office2010Silver; break;
                    case "آبی": styleManager1.ManagerStyle = eStyle.Office2007Blue; break;
                }
            }
        }
        int _time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_time < 5)
            {
                _time++;
                progressBar1.Value += 20;
                switch (_time)
                {
                    case 1: lblStatus.Text = "برسی نرم افزار"; break;
                    case 2: lblStatus.Text = "ایجاد فضا در رم"; break;
                    case 3: lblStatus.Text = "ایجاد رشته اتصال"; break;
                    case 4: lblStatus.Text = "برسی رشته اتصال"; break;
                    case 5: lblStatus.Text = "آماده سازی اجرا"; break;
                }
            }
            else
            {
                timer1.Enabled = false;
                using (var db = new HalabchiDB())
                {
                    var set = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
                    if (set.AdminRegister == false)
                    {
                        frmRegisterAdmin adminReg = new frmRegisterAdmin();
                        adminReg.Show();
                        this.Close();
                    }
                    else
                    {
                        frmLogin login = new frmLogin();
                        login.Show();
                        this.Close();
                    }
                }
            }
        }
    }
}
