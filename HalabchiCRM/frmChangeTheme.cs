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

namespace HalabchiCRM
{
    public partial class frmChangeTheme : Office2007Form
    {
        public frmChangeTheme()
        {
            InitializeComponent();
        }

        public void SetTheme()
        {
            using (var db = new HalabchiDB())
            {
                var theme = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
                switch (theme.Theme)
                {
                    case "Blue": cmbxTheme.SelectedIndex = 0; break;
                    case "Silver": cmbxTheme.SelectedIndex = 1; break;
                    case "Black": cmbxTheme.SelectedIndex = 2; break;
                }
            }
        }

        private void frmChangeTheme_Load(object sender, EventArgs e)
        {
            SetTheme();
        }

        private void btnSaveTheme_Click(object sender, EventArgs e)
        {
            using (var db = new HalabchiDB())
            {
                var theme = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
                switch (cmbxTheme.SelectedIndex)
                {
                    case 0: theme.Theme = "Blue"; break;
                    case 1: theme.Theme = "Silver"; break;
                    case 2: theme.Theme = "Black"; break;
                }
                db.SaveChanges();
                FarsiMessageBox.MessageBox.Show("نیاز به راه اندازی", "برای اعمال تغییرات نیاز به راه اندازی مجدد است", FarsiMessageBox.MessageBox.Buttons.OK, FarsiMessageBox.MessageBox.Icons.Information);
                Application.Restart();
            }
        }
    }
}
