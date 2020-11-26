using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalabchiCRM
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }
        int _time = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (_time < 5)
            {
                _time++;
                progressBar1.Value += 20;
            }
            else
            {
                timer1.Enabled = false;
                frmMain main = new frmMain();
                main.Show();
                this.Close();
            }
        }
    }
}
