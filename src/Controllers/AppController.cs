using BTL_C_.src.Controllers.Admin;
using BTL_C_.src.Views;
using BTL_C_.src.Views.Admin;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers
{
  internal class AppController
  {
    public static void startDashBoard(Form previousForm)
    {
      Home home = new Home();
      home.Show();
      previousForm.Hide();
    }
    public static void startFrmCreateAccount(Form previousForm)
    {
      FrmCreateAccount frmCreateAccount = new FrmCreateAccount();
      AccountController accountController = new AccountController(frmCreateAccount);
      frmCreateAccount.Show();
      previousForm.Hide();
    }
    public static void startFrmCreateProduct(Form previousForm)
    {
      FrmCreateProduct frmCreateProduct = new FrmCreateProduct();
      ProductController productController = new ProductController(frmCreateProduct);
      frmCreateProduct.Show();
      previousForm.Hide();
    }
    public static void startFrmLogin(Form previousForm)
    {
      FrmLogin frmLogin = new FrmLogin();
      LoginController loginController = new LoginController(frmLogin);
      frmLogin.Show();
      previousForm.Hide();
    }
  }
}
