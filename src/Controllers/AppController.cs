using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers
{
    internal class AppController
    {
        public static void startDashBoard(Form previousForm)
        {
            Home home = new Home();
            home.Show();
            previousForm.Dispose();
        }
    }
}
