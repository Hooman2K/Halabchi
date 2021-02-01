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
using System.Data.Entity;

namespace HalabchiCRM
{
    public partial class frmProduction : Office2007Form
    {
        public frmProduction()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //عدد تایع 885*700*030 برابر 1040 است
            //Formula form = new Formula();
            //label1.Text = form.Hefdah885030(int.Parse(textBox1.Text)).ToString() + " " + "Kg";

            //label1.Text = ((double.Parse(textBox1.Text) * 1040) / 1000).ToString() + " " + "Kg";
        }
    }
}
