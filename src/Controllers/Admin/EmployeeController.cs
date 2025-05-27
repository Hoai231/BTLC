using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers.Admin
{
  internal class EmployeeController
  {
    private EmployeeDAO employeeDao;
    private EmployeeControl viewEmployeeControl;
    public EmployeeController(EmployeeControl viewEmployeeControl)
    {
      this.viewEmployeeControl = viewEmployeeControl;
      employeeDao = new EmployeeDAO();
      loadFormDataToGridView();
      TaskDAO.fillTaskCombo(viewEmployeeControl.getCmbCongViec());
      setupEventListeners();
    }
    private void setupEventListeners()
    {
      viewEmployeeControl.setLuuListener(updateEmployee);
      viewEmployeeControl.setEmployeeCellClickListener(OnEmployeeCellClick);
      viewEmployeeControl.setLamMoiLítener(resetForm);
      viewEmployeeControl.setTimListener(findEmployeesBySearch);
    }
    private void loadFormDataToGridView()
    {
      // Giả sử bạn đã có DataTable chứa dữ liệu tài khoản
      DataTable allAccounts = employeeDao.getAllRecord();

      // Tạo DataView từ DataTable và lọc theo vai trò
      DataView dv = new DataView(allAccounts);

      viewEmployeeControl.loadDataToGridView(dv);
    }
    private void updateEmployee(object sender, EventArgs e)
    {
      string manv = viewEmployeeControl.getMaNV();
      if (string.IsNullOrWhiteSpace(manv))
      {
        MessageUtil.ShowWarning("Vui lòng chọn thông tin nhân viên muốn sửa!");
        return;
      }
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật?"))
        return;
      string tennv = viewEmployeeControl.getTenNV();
      string gioitinh = viewEmployeeControl.getGioiTinh();
      DateTime ngaysinh = viewEmployeeControl.getNgaySinh();
      string sdt = ConvertUtil.convertSdtToDB(viewEmployeeControl.getSDT());
      string macv = viewEmployeeControl.getCongViec();
      string diachi = viewEmployeeControl.getDiaChi();
      EmployeeModel employee = new EmployeeModel(manv, tennv, ngaysinh, sdt, diachi, macv, gioitinh);
      try
      {
        if (!employeeDao.update(employee))
        {
          MessageUtil.ShowError("Cập nhật không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Cập nhật thành công!");
        resetForm(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
      }
    }
    private void OnEmployeeCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var dgv = viewEmployeeControl.GetDataGridViewEmployee();
        var row = dgv.Rows[e.RowIndex];
        string manv = row.Cells[0].Value.ToString();
        string tennv = row.Cells[1].Value.ToString();
        string gioitinh = row.Cells[2].Value.ToString();
        DateTime? ngaysinh = null;

        if (row.Cells[3].Value != null && DateTime.TryParse(row.Cells[3].Value.ToString(), out DateTime tempDate))
        {
          ngaysinh = tempDate;
        }
        else
        {
          ngaysinh = null; // hoặc dùng DateTime.MinValue nếu cần giá trị mặc định
        }
        string sdt = row.Cells[4].Value.ToString();
        string tencv = row.Cells[5].Value.ToString();
        string diachi = row.Cells[6].Value.ToString();
        viewEmployeeControl.setForm(manv, tennv, diachi, gioitinh, tencv, sdt, ngaysinh);
      }
    }
    private void findEmployeesBySearch(object sender, EventArgs e)
    {
      try
      {
        DataView dv = employeeDao.findRecordsByName("tennv", viewEmployeeControl.getTextSearch());
        viewEmployeeControl.GetDataGridViewEmployee().DataSource = dv; // Hiển thị danh sách đã lọc
        viewEmployeeControl.loadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm!!!");
      }
    }
    private void resetForm(object sender, EventArgs e)
    {
      viewEmployeeControl.resetForm();
      loadFormDataToGridView();
    }
  }
}
