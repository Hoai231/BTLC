using BTL_C_.src.Utils;
using BTL_C_.src.Views.Admin;
using System;

namespace BTL_C_.src.Controllers.Admin
{
  internal class HomeController
  {
    private Home viewHome;
    public HomeController(Home viewHome)
    {
      this.viewHome = viewHome;
      setupEventListeners();
      DashBoardControl viewDashBoardControl = new DashBoardControl();
      viewHome.loadControl(viewDashBoardControl);
      new DashBoardController(viewDashBoardControl);
    }
    private void setupEventListeners()
    {
      viewHome.getSidebar().setTaiKhoanListener(initViewWithControllerAccount);
      viewHome.getSidebar().setSanPhamListener(initViewWithControllerProduct);
      viewHome.getSidebar().setNhaCungCapListener(initViewWithControllerSupplier);
      viewHome.getSidebar().setTrangChuListener(initViewWithControllerDashBoard);
      viewHome.getSidebar().setNhanVienListener(initViewWithControllerEmployee);
      viewHome.getSidebar().setDangXuatListener(logout);

    }
    private void initViewWithControllerAccount(object sender, EventArgs e)
    {
      AccountControl accountControl = new AccountControl();
      AccountController accountController = new AccountController(accountControl);
      viewHome.loadControl(accountControl);
    }
    private void initViewWithControllerProduct(object sender, EventArgs e)
    {
      ProductControl productControl = new ProductControl();
      ProductController productController = new ProductController(productControl);
      viewHome.loadControl(productControl);
    }
    private void initViewWithControllerSupplier(object sender, EventArgs e)
    {
      SupplierControl supplierControl = new SupplierControl();
      SupplierController supplierController = new SupplierController(supplierControl);
      viewHome.loadControl(supplierControl);
    }
    private void initViewWithControllerDashBoard(object sender, EventArgs e)
    {
      DashBoardControl dashBoardControl = new DashBoardControl();
      new DashBoardController(dashBoardControl);
      viewHome.loadControl(dashBoardControl);

    }
    private void initViewWithControllerEmployee(object sender, EventArgs e)
    {
      EmployeeControl employeeControl = new EmployeeControl();
      new EmployeeController(employeeControl);
      viewHome.loadControl(employeeControl);
    }
    private void logout(object sender, EventArgs e)
    {
      if (!MessageUtil.Confirm("Bạn có muốn đăng xuất?"))
        return;
      AppController.startFrmLogin(viewHome.getForm());
    }
  }
}
