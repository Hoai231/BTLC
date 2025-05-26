using System.Linq;

namespace BTL_C_.src.Utils
{
  internal class ConvertUtil
  {
    public static string convertSdtToDB(string sdt)
    {
      return new string(sdt.Where(char.IsDigit).ToArray());
    }
  }
}
