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
    public partial class frmMain : Office2007Form
    {
        public frmMain()
        {
            InitializeComponent();

            using (var db = new HalabchiDB())
            {
                var set = db.Settings.Where(u => u.ID == 1).FirstOrDefault();
                switch (set.Theme)
                {
                    case "Black": styleManager1.ManagerStyle = eStyle.Office2010Black; break;
                    case "Silver": styleManager1.ManagerStyle = eStyle.Office2010Silver; break;
                    case "Blue": styleManager1.ManagerStyle = eStyle.Office2010Blue; break;
                }
            }
        }

        private void buttonItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
