using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.DAO
{
    internal class AccountDAO : BaseDAO<AccountModel>
    {
        public bool insert(AccountModel acc)
        {
            string query = "INSERT INTO tblTaiKhoan (matk, email, tendangnhap, matkhau, vaitro, manv) " +
                           "VALUES (@ma, @email, @ten, @matkhau, @vaitro, @manv)";

            var parameters = new Dictionary<string, object>
        {
            {"@ma", acc.getMa_tai_khoan()},
            {"@email", acc.getEmail()},
            {"@ten", acc.getTen_dang_nhap()},
            {"@matkhau", acc.getMat_khau()},
            {"@vaitro", acc.getVai_tro()},
            {"@manv", acc.getMa_nhan_vien()}
        };

            return ExecuteNonQuery(query, parameters);
        }

        protected override string getKeyColumn() => "matk";

        protected override string GetKeyExist() => "email";


        protected override string GetTableName() => "tblTaiKhoan";

        protected override AccountModel MapReaderToObject(SqlDataReader reader)
        {
            return new AccountModel(
           reader["matk"].ToString(),
           reader["email"].ToString(),
           reader["tendangnhap"].ToString(),
           reader["matkhau"].ToString(),
           reader["vaitro"].ToString(),
           reader["manv"] as string
       );
        }
    }
}
