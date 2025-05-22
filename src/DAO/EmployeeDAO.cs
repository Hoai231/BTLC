using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.DAO
{
    internal class EmployeeDAO : BaseDAO<EmployeeModel>
    {
        public bool Insert(EmployeeModel employee)
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
    }
}
