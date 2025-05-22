using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Utils
{
    internal class HashPasswordUtil
    {
        public static String hashPassword(String password)
        {
            return BCrypt.Net.BCrypt.HashPassword(password); ;
        }
        public static bool checkPassword(String password, String hashedPassword)
        {
            return BCrypt.Net.BCrypt.Verify(password, hashedPassword);
        }
    }
}
