using BTL_C_.src.Controllers;
using BTL_C_.src.Controllers.Admin;
using BTL_C_.src.Views;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //FrmCreateAccount view = new FrmCreateAccount();
            //new AccountController(view);
            //FrmLogin view = new FrmLogin();
            Home view = new Home();
            //new LoginController(view);
            //new HomeController(view);
            view.Load += (s, e) =>
            {
                new HomeController(view);
            };
            Application.Run(view);
        }
    }
}
