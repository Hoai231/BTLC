namespace BTL_C_.src.Models
{
  internal class ObjectModel
  {
    public string madt { get; set; }
    public string tendt { get; set; }
    public ObjectModel(string madt, string tendt)
    {
      this.madt = madt;
      this.tendt = tendt;
    }
  }
}
