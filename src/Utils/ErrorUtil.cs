using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Utils
{
    internal class ErrorUtil
    {
        public static void handle(Exception e, String userMessage)
        {
            Console.WriteLine(e); // In lỗi ra console
            MessageBox.Show(userMessage, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
