using BTL_C_.src.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            {"@ma", acc.ma_tai_khoan},
            {"@email", acc.email},
            {"@ten", acc.ten_dang_nhap},
            {"@matkhau", acc.mat_khau},
            {"@vaitro", acc.vai_tro},
            {"@manv", acc.ma_nhan_vien}
        };

            return ExecuteNonQuery(query, parameters);
        }
        public bool update(AccountModel acc)
        {
            string query = "UPDATE tblTaiKhoan SET email = @email, tendangnhap = @ten, vaitro = @vaitro, status = @status where matk = @matk ";
            var parameters = new Dictionary<string, object>
            {
                {"@email", acc.email },
                {"@ten", acc.ten_dang_nhap },
                {"@vaitro", acc.vai_tro },
                {"@status", acc.status },
                {"@matk", acc.ma_tai_khoan }
            };
            return ExecuteNonQuery(query, parameters);

        }
        public bool changeStatus(string status, string keyvalue)
        {
            string sql = "UPDATE tblTaiKhoan SET status = @value where matk = @keyvalue";
            var parameters = new Dictionary<string, object>
            {
                {"@value",status },
                {"@keyvalue",keyvalue }

            };
            return ExecuteNonQuery(sql, parameters);

        }



        protected override string getKeyColumn() => "matk";

        protected override string GetKeyExist() => "email";


        protected override string GetTableName() => "tblTaiKhoan";

        protected override string getColumns() => " matk, email, tendangnhap, matkhau, vaitro, manv, status ";
        protected override AccountModel MapReaderToObject(SqlDataReader reader)
        {
            return new AccountModel(
           reader["matk"].ToString(),
           reader["email"].ToString(),
           reader["tendangnhap"].ToString(),
           reader["matkhau"].ToString(),
           reader["vaitro"].ToString(),
           reader["manv"] as string,
           reader["status"].ToString()

       );
        }


    }
}
