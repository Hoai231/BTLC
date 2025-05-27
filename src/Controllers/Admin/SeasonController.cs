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
  internal class SeasonController
  {
    private FrmSeason viewFrmSeason;
    private SeasonDAO seasonDao;
    public SeasonController(FrmSeason viewFrmSeason)
    {
      this.viewFrmSeason = viewFrmSeason;
      seasonDao = new SeasonDAO();
      loadDataToGridViewSeason();
      setupEventListeners();
    }

    /// <summary>
    /// Setup sự kiện
    /// </summary>
    private void setupEventListeners()
    {
      viewFrmSeason.setTaoListener(insertSeason);
      viewFrmSeason.setLamMoiListener(resetForm);
      viewFrmSeason.setLuuListener(updateSeason);
      viewFrmSeason.setXoaListener(deleteSeason);
      viewFrmSeason.setSeasonCellClickListener(OnAccountCellClick);

    }
    /// <summary>
    ///  Load data ra bảng
    /// </summary>
    private void loadDataToGridViewSeason()
    {
      try
      {
        DataTable dt = seasonDao.getAllRecord();
        DataView dv = new DataView(dt);
        viewFrmSeason.loadDataToGridViewSeaSon(dv);
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
        var dgv = viewFrmSeason.getDataGridViewSeason();
        var row = dgv.Rows[e.RowIndex];
        string mamua = row.Cells[0].Value.ToString();
        string tenmua = row.Cells[1].Value.ToString();
        viewFrmSeason.setFormData(mamua, tenmua);
      }
    }
    /// <summary>
    /// Thêm dữ liệu vào db
    /// </summary>
    private void insertSeason(object sender, EventArgs e)
    {

      if (!InputValidate.inputSeasonValidate(viewFrmSeason.getTenMua()))
        return;
      try
      {
        string mamua = GenerateIdUtil.GenerateId("SEASON");
        SeasonModel season = new SeasonModel(mamua, viewFrmSeason.getTenMua());
        if (!seasonDao.insert(season))
        {
          MessageUtil.ShowError("Tạo không thành công!!!");
          return;
        }
        MessageUtil.ShowInfo("Tạo thành công!");
        resetForm(sender, e);
      }
      catch (Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tạo!!!");
      }
    }
    private void updateSeason(object sender, EventArgs e)
    {
      string mamua = viewFrmSeason.getMaMua();
      string tenmua = viewFrmSeason.getTenMua();
      if (string.IsNullOrWhiteSpace(mamua))
      {
        MessageUtil.ShowWarning("Vui lòng chọn mùa muốn sửa!");
        return;
      }
      if (!InputValidate.inputSeasonValidate(tenmua))
        return;
      if (!MessageUtil.Confirm("Bạn có muốn cập nhật!"))
        return;
      try
      {
        SeasonModel season = new SeasonModel(mamua, tenmua);
        if (!seasonDao.update(season))
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
    private void deleteSeason(object sender, EventArgs e)
    {
      string mamua = viewFrmSeason.getMaMua();
      if (string.IsNullOrWhiteSpace(mamua))
      {
        MessageUtil.ShowWarning("Vui lòng chọn mùa muốn xóa!");
        return;
      }
      if (!MessageUtil.Confirm("Bạn có chắc chắn xóa?"))
        return;
      try
      {
        if (!seasonDao.delete(mamua))
        {
          MessageUtil.ShowWarning("Xóa thất bại!!!");
          return;
        }
        MessageUtil.ShowInfo("Đã xóa thành công!");
        resetForm(sender, e);
      }catch(Exception ex)
      {
        ErrorUtil.handle(ex, "Đã xảy ra lỗi khi xóa");
      }
    }
    /// <summary>
    /// Reset form
    /// </summary>
    private void resetForm(object sender, EventArgs e)
    {
      viewFrmSeason.resetForm();
      loadDataToGridViewSeason();
    }
  }
}
