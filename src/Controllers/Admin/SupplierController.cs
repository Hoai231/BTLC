using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views.Admin;
using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers.Admin
{
  internal class SupplierController
  {
    private SupplierControl viewSupplierControl;
    private SupplierDAO supplierDao;
    public SupplierController(SupplierControl supplierControl)
    {
      this.viewSupplierControl = supplierControl;
      supplierDao = new SupplierDAO();
      loadDataToGridView();
      setupEventListeners();
    }
    private void setupEventListeners()
    {
      viewSupplierControl.setLamMoiListener(reset);
      viewSupplierControl.setTaoListener(insertSupplier);
      viewSupplierControl.setSupplierCellClickListener(OnSupplierCellClick);
      viewSupplierControl.setLuuListener(updateSupplier);
      viewSupplierControl.setXoaListener(deletedSupplier);
      viewSupplierControl.setTimListener(findSupplierBySearch);
    }
    public void insertSupplier(object sender, EventArgs e)
    {
      string mancc = GenerateIdUtil.GenerateId("SUPPLI");
      string tenncc = viewSupplierControl.getTenNCC();
      string diachi = viewSupplierControl.getDiaChi();
      string sdt = ConvertUtil.convertSdtToDB(viewSupplierControl.getSDT());//  (036) 452-1234 => 0364521234
      if (!InputValidate.inputCreaetSupplierValidate(mancc, tenncc, diachi, sdt))
        return;
      SupplierModel supplier = new SupplierModel(mancc, tenncc, diachi, sdt);
      try
      {
        if (!supplierDao.insert(supplier))
        {
          MessageUtil.ShowError("Tạo thất bại!!!");
          return;
        }
        MessageUtil.ShowInfo("Tạo thành công!");
        reset(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tạo!!!");
      }
    }
    private void updateSupplier(object sender, EventArgs e)
    {
      string mancc = viewSupplierControl.getMaNCC();
      string tenncc = viewSupplierControl.getTenNCC();
      string diachi = viewSupplierControl.getDiaChi();
      string sdt = ConvertUtil.convertSdtToDB(viewSupplierControl.getSDT());
      if (string.IsNullOrWhiteSpace(mancc))
      {
        MessageUtil.ShowWarning("Vui lòng chọn nhà cung cấp muốn sửa!");
        return;
      }
      if (!InputValidate.inputCreaetSupplierValidate(mancc, tenncc, diachi, sdt))
        return;
      SupplierModel supplier = new SupplierModel(mancc, tenncc, diachi, sdt);
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật?"))
        return;
      try
      {
        if (!supplierDao.update(supplier))
        {
          MessageUtil.ShowError("Cập nhật thất bại!!!");
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
    private void deletedSupplier(object sender, EventArgs e)
    {
      string mancc = viewSupplierControl.getMaNCC();
      if (string.IsNullOrWhiteSpace(mancc))
      {
        MessageUtil.ShowWarning("Vui lòng chọn nhà cung cấp muốn sửa!");
        return;
      }
      if (!MessageUtil.Confirm("Bạn có chắc chắn muốn xóa?"))
        return;

      try
      {
        if (!supplierDao.delete(mancc))
        {
          MessageUtil.ShowError("Xóa thất bại!!!");
          return;
        }
        MessageUtil.ShowInfo("Đã xóa thành công");
        reset(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi xóa!!!");
      }
    }
    private void loadDataToGridView()
    {// Giả sử bạn đã có DataTable chứa dữ liệu tài khoản
      DataTable allAccounts = supplierDao.getAllRecord();

      // Tạo DataView từ DataTable và lọc theo vai trò
      DataView dv = new DataView(allAccounts);

      viewSupplierControl.loadDataToGridView(dv);
    }
    private void OnSupplierCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var dgv = viewSupplierControl.GetDataGridViewSupplier();
        var row = dgv.Rows[e.RowIndex];
        string mancc = row.Cells[0].Value.ToString();
        string tenncc = row.Cells[1].Value.ToString();
        string diachi = row.Cells[2].Value.ToString();
        string sdt = row.Cells[3].Value.ToString();
        viewSupplierControl.setFormData(mancc, tenncc, diachi, sdt);
      }
    }
    private void findSupplierBySearch(object sender, EventArgs e)
    {
      try
      {
        DataView dv = supplierDao.findRecordsByName("tenncc", viewSupplierControl.getTextSearch());
        viewSupplierControl.GetDataGridViewSupplier().DataSource = dv; // Hiển thị danh sách đã lọc
        viewSupplierControl.loadDataToGridView(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm!!!");
      }
    }
    private void reset(object sender, EventArgs e)
    {
      viewSupplierControl.resetForm();
      loadDataToGridView();
    }
  }
}
