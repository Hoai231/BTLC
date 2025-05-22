using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Controllers.Admin
{
    internal class AccountController
    {
        private FrmCreateAccount viewFrmCreateAccount;
        private AccountDAO accountDao;
        private EmployeeDAO employeeDAO;
        public AccountController(FrmCreateAccount viewFrmCreateAccount)
        {

            this.viewFrmCreateAccount = viewFrmCreateAccount;
            accountDao = new AccountDAO();
            employeeDAO = new EmployeeDAO();
            viewFrmCreateAccount.setTaoListener(insertAccount);
        }
        private void insertAccount(object sender, EventArgs e)
        {
            try
            {

                if (!ImputValidate.inputCreateAccountValidate(viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), viewFrmCreateAccount.getPassword(), viewFrmCreateAccount.getVaiTro()))
                {
                    return;
                }

                string employee_id = GenerateIdUtil.GenerateId("EMPLOYEE");
                EmployeeModel employee = new EmployeeModel(employee_id, "", "", "", "", null);
                string acc_id = GenerateIdUtil.GenerateId("ACC");
                AccountModel account = new AccountModel(acc_id, viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), HashPasswordUtil.hashPassword(viewFrmCreateAccount.getPassword()), viewFrmCreateAccount.getVaiTro(), employee_id);
                if (!employeeDAO.Insert(employee))
                {
                    MessageUtil.ShowError("Thêm không thành công!!!");
                    return;
                }
                if (!accountDao.Insert(account))
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

    }
}
