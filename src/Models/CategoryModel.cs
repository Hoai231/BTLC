namespace BTL_C_.src.Models
{
  internal class CategoryModel
  {
    public string matl { get; set; }
    public string tentl { get; set; }
    public CategoryModel(string matl, string tentl)
    {
      this.matl = matl;
      this.tentl = tentl;
    }
  }
}
