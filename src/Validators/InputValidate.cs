using BTL_C_.src.Utils;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Validators
{
    internal class InputValidate
    {
        public static bool inputLoginValidate(string email, string password)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(password))
            {
                MessageUtil.ShowWarning(MessageConstants.INPUT_WARN);
                return false;
            }
            return true;
        }
        public static bool inputCreateAccountValidate(string email, string name, string password, string role)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(role))
            {
                MessageUtil.ShowWarning(MessageConstants.INPUT_WARN);
                return false;
            }
            return true;
        }
        public static bool inputUpdateAccountValidate(string email, string name, string vaitro, string status)
        {
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(vaitro) || string.IsNullOrWhiteSpace(status))
            {
                MessageUtil.ShowWarning(MessageConstants.INPUT_WARN);
                return false;
            }
            return true;
        }
        public static bool inputCreateProductValidate(string maquanao, string tenquanao)
        {
            if (string.IsNullOrWhiteSpace(maquanao) || string.IsNullOrWhiteSpace(tenquanao))
            {
                MessageUtil.ShowWarning(MessageConstants.INPUT_WARN);
                return false;
            }
            return true;
        }
        public static bool inputCreaetSupplierValidate(string mancc, string tenncc, string diachi, string sdt)
        {
            if (string.IsNullOrWhiteSpace(mancc) || string.IsNullOrWhiteSpace(tenncc) || string.IsNullOrWhiteSpace(diachi) || string.IsNullOrWhiteSpace(sdt))
            {
                MessageUtil.ShowWarning(MessageConstants.INPUT_WARN);
                return false;
            }
            return true;
        }
    }
}
