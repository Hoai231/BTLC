using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Controllers.Admin
{
    internal class HomeController
    {
        private Home viewHome;
        public HomeController(Home viewHome)
        {
            this.viewHome = viewHome;
            setupEventListeners();
        }
        private void setupEventListeners()
        {
            viewHome.getSidebar().setTaiKhoanListener(initViewWithControllerAccount);
        }
        private void initViewWithControllerAccount(object sender, EventArgs e)
        {
            AccountControl accountControl = new AccountControl();
            AccountController accountController = new AccountController(accountControl);
            viewHome.LoadControl(accountControl);
        }
    }
}
