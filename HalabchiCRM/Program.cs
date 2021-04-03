using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HalabchiCRM
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmProduction());
        }
    }

    public class AppContext : ApplicationContext
    {
        public AppContext()
        {
            Application.Idle += new EventHandler(Application_Idle);
            frmSplashScreen splash = new frmSplashScreen();
            splash.Show();
            //frmLogin login = new frmLogin();
            //login.Show();
        }
        void Application_Idle(object sender, EventArgs e)
        {
            if (Application.OpenForms.Count == 0)
                Application.Exit();
        }
    }

}
