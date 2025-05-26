namespace BTL_C_.src.Models
{
  internal class SupplierModel
  {
    public string mancc { get; set; }
    public string tenncc { get; set; }
    public string diachi { get; set; }
    public string sdt { get; set; }
    public SupplierModel(string mancc, string tenncc, string diachi, string sdt)
    {
      this.mancc = mancc;
      this.tenncc = tenncc;
      this.diachi = diachi;
      this.sdt = sdt;
    }
  }
}
