namespace BTL_C_.src.Models
{
  internal class SeasonModel
  {
    public string mamua { get; set; }
    public string tenmua { get; set; }
    public SeasonModel(string mamua, string tenmua)
    {
      this.mamua = mamua;
      this.tenmua = tenmua;
    }
  }
}
