using BTL_C_.src.Controllers.Admin;
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
            FrmCreateAccount view = new FrmCreateAccount();
            new AccountController(view);
            Application.Run(view);
        }
    }
}
