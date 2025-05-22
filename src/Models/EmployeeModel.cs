using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Models
{
    internal class EmployeeModel
    {
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string NgaySinh { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string MaCV { get; set; }
        public bool GioiTinh { get; set; }


        // Constructor không tham số
        public EmployeeModel() { }

        // Constructor đầy đủ tham số
        public EmployeeModel(string maNhanVien, string tenNhanVien, string ngaySinh,
                        string soDienThoai, string diaChi, string maCV)
        {
            MaNhanVien = maNhanVien;
            TenNhanVien = tenNhanVien;
            NgaySinh = ngaySinh;
            SoDienThoai = soDienThoai;
            DiaChi = diaChi;
            MaCV = maCV;
        }
    }
}
