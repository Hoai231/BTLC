namespace BTL_C_.src.Models
{
  internal class AccountModel
  {
    public string ma_tai_khoan { get; set; }
    public string email { get; set; }
    public string ten_dang_nhap { get; set; }
    public string mat_khau { get; set; }
    public string vai_tro { get; set; }
    public string ma_nhan_vien { get; set; }
    public string status { get; set; }
    // Constructor không tham số
    public AccountModel()
    {
    }

    // Constructor đầy đủ
    public AccountModel(string ma_tai_khoan, string email, string ten_dang_nhap,
                   string mat_khau, string vai_tro, string ma_nhan_vien, string status)
    {
      this.ma_tai_khoan = ma_tai_khoan;
      this.email = email;
      this.ten_dang_nhap = ten_dang_nhap;
      this.mat_khau = mat_khau;
      this.vai_tro = vai_tro;
      this.ma_nhan_vien = ma_nhan_vien;
      this.status = status;
    }

    // Getters and Setters

  }
}
