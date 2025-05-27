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
  internal class CustomerController : BaseController<CustomerModel>
  {
    private CustomerControl viewCustomerControl;
    private CustomerDAO customerDao;

    protected override string EntityName => "khách hàng";

    public CustomerController(CustomerControl viewCustomerControl)
    {
      this.viewCustomerControl = viewCustomerControl;
      customerDao = new CustomerDAO();
      LoadDataToGridViewCustomer();
      SetupEventListeners();
    }
    private void SetupEventListeners()
    {
      viewCustomerControl.SetLamMoiListener(Reset);
      viewCustomerControl.SetLuuListener(UpdateCustomer);
      viewCustomerControl.SetTimListener(FindCustomerBySearch);
      viewCustomerControl.SetXoaListener(Delete);
      viewCustomerControl.SetCustomerCellClickListener(OnCustomerCellClick);
    }
    private void LoadDataToGridViewCustomer()
    {
      try
      {
        DataTable dt = customerDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewCustomerControl.LoadDataToGridView(dv);
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
        var dgv = viewCustomerControl.GetDataGridViewCustomer();
        var row = dgv.Rows[e.RowIndex];
        string makh = row.Cells[0].Value.ToString();
        string tenkh = row.Cells[1].Value.ToString();
        string sdt = row.Cells[2].Value.ToString();
        int diem = (int)row.Cells[3].Value;
        viewCustomerControl.SetFormData(makh, tenkh, sdt, diem);
      }
    }
    private void UpdateCustomer(object sender, EventArgs e)
    {
      string makh = viewCustomerControl.GetMaKH();
      if (string.IsNullOrWhiteSpace(makh))
      {
        MessageUtil.ShowWarning("Vui lòng chọn thông tin khách hàng muốn sửa!");
        return;
      }
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật?"))
        return;
      string sdt = ConvertUtil.convertSdtToDB(viewCustomerControl.GetSDT());
      CustomerModel customer = new CustomerModel(makh, viewCustomerControl.GetTenKH(), sdt, viewCustomerControl.GetDiemTichLuy());

      try
      {
        if (!customerDao.update(customer))
        {
          MessageUtil.ShowError("Cập nhật không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Cập nhật thành công!");
        Reset(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
      }
    }
    private void FindCustomerBySearch(object sender, EventArgs e)
    {
      try
      {
        DataView dv = customerDao.findRecordsByName("tenkh", viewCustomerControl.GetTextSearch());
        viewCustomerControl.GetDataGridViewCustomer().DataSource = dv;
        viewCustomerControl.LoadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm!!!");
      }
    }
    private void Reset(object sender, EventArgs e)
    {
      viewCustomerControl.ResetForm();
      LoadDataToGridViewCustomer();
    }

    protected override string GetId() => viewCustomerControl.GetMaKH();

    protected override bool DeleteById(string id) => customerDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => Reset(sender, e);
  }
}
