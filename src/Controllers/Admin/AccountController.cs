using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTL_C_.src.Controllers.Admin
{
    internal class AccountController
    {
        private FrmCreateAccount viewFrmCreateAccount;
        private AccountControl viewAccounts;
        private AccountDAO accountDao;
        private EmployeeDAO employeeDAO;
        public AccountController(FrmCreateAccount viewFrmCreateAccount)
        {

            this.viewFrmCreateAccount = viewFrmCreateAccount;
            accountDao = new AccountDAO();
            employeeDAO = new EmployeeDAO();
            viewFrmCreateAccount.setTaoListener(insertAccount);
        }
        public AccountController(AccountControl accountControl)
        {
            viewAccounts = accountControl;
            accountDao = new AccountDAO();
            loadDataToGridView();
        }
        private void insertAccount(object sender, EventArgs e)
        {
            try
            {

                if (!ImputValidate.inputCreateAccountValidate(viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), viewFrmCreateAccount.getPassword(), viewFrmCreateAccount.getVaiTro()))
                {
                    return;
                }


                if (accountDao.checkExist(viewFrmCreateAccount.getEmail()))
                {

                    MessageUtil.ShowWarning("Email đã tồn tại!!!");
                    return;
                }
                string acc_id = GenerateIdUtil.GenerateId("ACC");
                AccountModel account = null;
                if (viewFrmCreateAccount.getVaiTro() == "Admin")
                {
                    account = new AccountModel(acc_id, viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), HashPasswordUtil.hashPassword(viewFrmCreateAccount.getPassword()), viewFrmCreateAccount.getVaiTro(), null);
                }
                else
                {
                    string employee_id = GenerateIdUtil.GenerateId("EMPLOYEE");
                    EmployeeModel employee = new EmployeeModel(employee_id, "", "", "", "", null);
                    account = new AccountModel(acc_id, viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), HashPasswordUtil.hashPassword(viewFrmCreateAccount.getPassword()), viewFrmCreateAccount.getVaiTro(), employee_id);
                    if (!employeeDAO.insert(employee))
                    {
                        MessageUtil.ShowError("Thêm không thành công!!!");
                        return;
                    }
                }

                if (!accountDao.insert(account))
                {
                    MessageUtil.ShowError("Thêm không thành công!!!");
                    return;
                }
                MessageUtil.ShowInfo("Đã tạo thành công!");
            }
            catch (Exception ex) // Renamed the variable to 'ex' to avoid conflict with the parameter 'e'  
            {
                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi thêm tài khoản!!!");
            }
        }
        private void loadDataToGridView()
        {// Giả sử bạn đã có DataTable chứa dữ liệu tài khoản
            DataTable allAccounts = accountDao.getAllRecord();

            // Tạo DataView từ DataTable và lọc theo vai trò
            DataView dv = new DataView(allAccounts);
            dv.RowFilter = "vaitro = 'Nhân Viên'";

            viewAccounts.loadDataToGridView(dv);

        }

    }
}
