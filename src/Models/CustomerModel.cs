namespace BTL_C_.src.Models
{
  internal class CustomerModel
  {
    public string makh { get; set; }
    public string tenkh { get; set; }
    public string sdt { get; set; }
    public int diem { get; set; }
    public CustomerModel(string makh, string tenkh, string sdt, int diem)
    {
      this.makh = makh;
      this.tenkh = tenkh;
      this.sdt = sdt;
      this.diem = diem;

    }
  }
}
