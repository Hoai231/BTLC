using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
