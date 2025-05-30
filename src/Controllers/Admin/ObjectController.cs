using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
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
  internal class ObjectController : BaseController<ObjectModel>
  {
    private FrmObject viewFrmObject;
    private ObjectDAO objectDao;

    protected override string EntityName => "đối tượng";

    public ObjectController(FrmObject viewFrmObject)
    {
      this.viewFrmObject = viewFrmObject;
      objectDao = new ObjectDAO();
      LoadDataToGridViewObject();
      SetupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void SetupEventListeners()
    {
      viewFrmObject.SetTaoListener(InsertObject);
      viewFrmObject.SetLamMoiListener(ResetForm);
      viewFrmObject.SetLuuListener(UpdateObject);
      viewFrmObject.SetXoaListener(Delete);
      viewFrmObject.SetObjectCellClickListener(OnAccountCellClick);

    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void LoadDataToGridViewObject()
    {
      try
      {
        DataTable dt = objectDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewFrmObject.LoadDataToGridViewObject(dv);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi!!!");
      }
    }
    /// <summary>
    /// Sử lý sự kiện cellclick vào datagridview
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void OnAccountCellClick(object sender, DataGridViewCellEventArgs e)
    {
      if (e.RowIndex >= 0)
      {
        var dgv = viewFrmObject.GetDataGridViewObject();
        var row = dgv.Rows[e.RowIndex];
        string madt = row.Cells[0].Value.ToString();
        string tendt = row.Cells[1].Value.ToString();
        viewFrmObject.SetFormData(madt, tendt);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void InsertObject(object sender, EventArgs e)
    {

      if (!InputValidate.inputObjectValidate(viewFrmObject.GetTenDoiTuong()))
        return;
      try
      {
        string madt = GenerateIdUtil.GenerateId("OBJECT");
        ObjectModel obj = new ObjectModel(madt, viewFrmObject.GetTenDoiTuong());
        if (!objectDao.insert(obj))
        {
          MessageUtil.ShowError("Tạo không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Tạo thành công!");
        ResetForm(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tạo!!!");
      }
    }
    private void UpdateObject(object sender, EventArgs e)
    {
      string madt = viewFrmObject.GetMaDoiTuong();
      string tendt = viewFrmObject.GetTenDoiTuong();
      if (string.IsNullOrWhiteSpace(madt))
      {
        MessageUtil.ShowWarning("Vui lòng chọn đối tượng muốn sửa!");
        return;
      }
      if (!InputValidate.inputObjectValidate(tendt))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        ObjectModel obj = new ObjectModel(madt, tendt);
        if (!objectDao.update(obj))
        {
          MessageUtil.ShowError("Cập nhật không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Cập nhật thành công!");
        ResetForm(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
      }
    }

    /// <summary>
    /// Reset form
    /// </summary>
    private void ResetForm(object sender, EventArgs e)
    {
      viewFrmObject.ResetForm();
      LoadDataToGridViewObject();
    }

    protected override string GetId() => viewFrmObject.GetMaDoiTuong();

    protected override bool DeleteById(string id) => objectDao.delete(id);

    protected override void ResetView(object sender, EventArgs e) => ResetForm(sender, e);
  }
}
