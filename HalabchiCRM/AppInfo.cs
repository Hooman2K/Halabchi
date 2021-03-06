using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalabchiCRM
{
    class AppInfo
    {
        public static string Username = "";
        public static string FName = "";
        public static string LName = "";
        public static string Mobile = "";
        public static bool IsAdmin = false;

        public void JustNumber(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
                e.Handled = true;
        }

        //public void JustFloatNumber(object sender,KeyPressEventArgs e)
        //{
        //    if (e.KeyChar == '.' && e.Length > 0 && !e.Contains("."))
        //    {
        //        e.Handled = false;
        //        return;
        //    }
        //}
    }
}
