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
            setupEventListener();
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
                    account = new AccountModel(acc_id, viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), HashPasswordUtil.hashPassword(viewFrmCreateAccount.getPassword()), viewFrmCreateAccount.getVaiTro(), null, null);
                }
                else
                {
                    string employee_id = GenerateIdUtil.GenerateId("EMPLOYEE");
                    EmployeeModel employee = new EmployeeModel(employee_id, "", "", "", "", null);
                    account = new AccountModel(acc_id, viewFrmCreateAccount.getEmail(), viewFrmCreateAccount.getTenDangNhap(), HashPasswordUtil.hashPassword(viewFrmCreateAccount.getPassword()), viewFrmCreateAccount.getVaiTro(), employee_id, null);
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
        private void setupEventListener()
        {
            viewAccounts.setAccountCellClickListener(OnAccountCellClick);
            viewAccounts.setLamMoiListener(reset);
            viewAccounts.setLuuListener(updateAccount);
            viewAccounts.setXoaListener(deleteAccount);
            viewAccounts.setTrangThaiListener(changeStatus);
            viewAccounts.setTimListener(findAccountBySearch);
        }
        private void OnAccountCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dgv = viewAccounts.GetDataGridView();
                var row = dgv.Rows[e.RowIndex];
                string matk = row.Cells[0].Value.ToString();
                string email = row.Cells[1].Value.ToString();
                string tendangnhap = row.Cells[2].Value.ToString();
                string vaitro = row.Cells[4].Value.ToString();
                string manv = row.Cells[5].Value.ToString();
                string status = row.Cells[6].Value.ToString();
                viewAccounts.setFormData(matk, email, tendangnhap, vaitro, status, manv);
            }
        }
        private void reset(object sender, EventArgs e)
        {
            viewAccounts.resetForm();
            loadDataToGridView();
        }

        private void updateAccount(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(viewAccounts.getMatk()))
                {
                    MessageUtil.ShowWarning("Vui lòng chọn tài khoản muốn sửa!");
                    return;
                }
                if (!ImputValidate.inputUpdateAccountValidate(viewAccounts.getEmail(), viewAccounts.getTenDangNhap(), viewAccounts.getStatus(), viewAccounts.getVaiTro()))
                {
                    return;
                }
                AccountModel account = new AccountModel(viewAccounts.getMatk(), viewAccounts.getEmail(), viewAccounts.getTenDangNhap(), "", viewAccounts.getVaiTro(), "", viewAccounts.getStatus());
                if (!accountDao.update(account))
                {
                    MessageUtil.ShowError("Cập nhật không thành công!!!");
                    return;
                }
                MessageUtil.ShowInfo("Cập nhật thành công!");
                loadDataToGridView();
            }
            catch (Exception ex)
            {
                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
            }
        }
        private void deleteAccount(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(viewAccounts.getMatk()))
            {
                MessageUtil.ShowWarning("Vui lòng chọn tài khoản muốn xóa!");
                return;
            }
            try
            {
                if (!accountDao.delete(viewAccounts.getMatk()))
                {
                    MessageUtil.ShowWarning("Xóa thất bại!");
                    return;
                }
                MessageUtil.ShowInfo("Đã xóa thành công!");
                loadDataToGridView();
            }
            catch (Exception ex)
            {

                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi xóa!!!");
            }
        }
        private void changeStatus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(viewAccounts.getMatk()))
            {
                MessageUtil.ShowWarning("Vui lòng chọn tài khoản muốn sửa!");
                return;
            }
            String newStatus = viewAccounts.getStatus().Equals("hoạt động") ? "ngừng hoạt động" : "hoạt động";
            viewAccounts.setStatus(newStatus);

            try
            {
                if (!accountDao.changeStatus(viewAccounts.getStatus(), viewAccounts.getMatk()))
                {
                    MessageUtil.ShowWarning("Cập nhật thất bại!");
                    return;
                }

                loadDataToGridView();
            }
            catch (Exception ex)
            {
                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi thay đổi trạng thái!!!");
            }
        }
        private void findAccountBySearch(object sender, EventArgs e)
        {
            AccountModel account = accountDao.findRecordByField("email", viewAccounts.getSearchText());
            if (account == null)
            {
                MessageUtil.ShowInfo("Tài khoản không tồn tại!");
                return;
            }
            DataView dv = ConvertToDataView.ObjectToDataView(account);
            foreach (DataColumn col in dv.Table.Columns)
            {
                Console.WriteLine(col.ColumnName);
            }

            dv.RowFilter = "vai_tro = 'Nhân Viên'";
            viewAccounts.loadDataToGridView(dv);
        }
    }
}
