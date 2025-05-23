using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.DAO
{
    internal class EmployeeDAO : BaseDAO<EmployeeModel>
    {
        public bool insert(EmployeeModel employee)
        {
            string query = "INSERT INTO tblNhanVien (manv, tennv, gioitinh,ngaysinh, sdt, diachi,macv) " +
                           "VALUES (@ma, @ten, @gioitinh, @ngaysinh, @sdt, @diachi,@macv)";

            var parameters = new Dictionary<string, object>
        {
            {"@ma", employee.MaNhanVien},
            {"@ten", employee.TenNhanVien},
            {"@gioitinh", employee.GioiTinh},
            {"@ngaysinh", employee.NgaySinh},
            {"@sdt", employee.SoDienThoai},
            {"@diachi", employee.DiaChi},
            {"@macv",employee.MaCV }
        };

            return ExecuteNonQuery(query, parameters);
        }

        protected override string getColumns()
        {
            throw new NotImplementedException();
        }

        protected override string getKeyColumn()
        {
            throw new NotImplementedException();
        }

        protected override string GetKeyExist()
        {
            throw new NotImplementedException();
        }

        protected override string GetTableName()
        {
            throw new NotImplementedException();
        }

        protected override EmployeeModel MapReaderToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
