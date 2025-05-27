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
  internal class CustomerController
  {
    private CustomerControl viewCustomerControl;
    private CustomerDAO customerDao;
    public CustomerController(CustomerControl viewCustomerControl)
    {
      this.viewCustomerControl = viewCustomerControl;
      customerDao = new CustomerDAO();
      loadDataToGridViewCustomer();
      setupEventListeners();
    }
    private void setupEventListeners()
    {
      viewCustomerControl.setLamMoiListener(reset);
      viewCustomerControl.setLuuListener(updateCustomer);
      viewCustomerControl.setTimListener(findCustomerBySearch);
      viewCustomerControl.setCustomerCellClickListener(OnCustomerCellClick);
    }
    private void loadDataToGridViewCustomer()
    {
      try
      {
        DataTable dt = customerDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewCustomerControl.loadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }

    }
    private void OnCustomerCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var dgv = viewCustomerControl.getDataGridViewCustomer();
        var row = dgv.Rows[e.RowIndex];
        string makh = row.Cells[0].Value.ToString();
        string tenkh = row.Cells[1].Value.ToString();
        string sdt = row.Cells[2].Value.ToString();
        int diem = (int)row.Cells[3].Value;
        viewCustomerControl.setFormData(makh, tenkh, sdt, diem);
      }
    }
    private void updateCustomer(object sender, EventArgs e)
    {
      string makh = viewCustomerControl.getMaKH();
      if (string.IsNullOrWhiteSpace(makh))
      {
        MessageUtil.ShowWarning("Vui lòng chọn thông tin khách hàng muốn sửa!");
        return;
      }
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật?"))
        return;
      string sdt = ConvertUtil.convertSdtToDB(viewCustomerControl.getSDT());
      CustomerModel customer = new CustomerModel(makh, viewCustomerControl.getTenKH(), sdt, viewCustomerControl.getDiemTichLuy());

      try
      {
        if (!customerDao.update(customer))
        {
          MessageUtil.ShowError("Cập nhật không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Cập nhật thành công!");
        reset(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
      }
    }
    private void findCustomerBySearch(object sender, EventArgs e)
    {
      try
      {
        DataView dv = customerDao.findRecordsByName("tenkh", viewCustomerControl.getTextSearch());
        viewCustomerControl.getDataGridViewCustomer().DataSource = dv;
        viewCustomerControl.loadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm!!!");
      }
    }
    private void reset(object sender, EventArgs e)
    {
      viewCustomerControl.resetForm();
      loadDataToGridViewCustomer();
    }
  }
}
