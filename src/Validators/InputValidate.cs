using BTL_C_.src.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Validators
{
    internal class ImputValidate
    {
        public static bool inputLoginValidate(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageUtil.ShowWarning("Thông tin không được để trống!");
                return false;
            }
            return true;
        }
        public static bool inputCreateAccountValidate(string email, string name, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageUtil.ShowWarning("Thông tin không được để trống!");
                return false;
            }
            return true;
        }
    }
}
