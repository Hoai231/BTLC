using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Models
{
    internal class AccountModel
    {
        private string ma_tai_khoan;
        private string email;
        private string ten_dang_nhap;
        private string mat_khau;
        private string vai_tro;
        private string ma_nhan_vien;
        private string status;
        // Constructor không tham số
        public AccountModel()
        {
        }

        // Constructor đầy đủ
        public AccountModel(string ma_tai_khoan, string email, string ten_dang_nhap,
                       string mat_khau, string vai_tro, string ma_nhan_vien, string status)
        {
            this.ma_tai_khoan = ma_tai_khoan;
            this.email = email;
            this.ten_dang_nhap = ten_dang_nhap;
            this.mat_khau = mat_khau;
            this.vai_tro = vai_tro;
            this.ma_nhan_vien = ma_nhan_vien;
            this.status = status;
        }

        // Getters and Setters
        public string getMa_tai_khoan()
        {
            return ma_tai_khoan;
        }

        public void setMa_tai_khoan(string ma_tai_khoan)
        {
            this.ma_tai_khoan = ma_tai_khoan;
        }

        public string getEmail()
        {
            return email;
        }

        public void setEmail(string email)
        {
            this.email = email;
        }

        public string getTen_dang_nhap()
        {
            return ten_dang_nhap;
        }

        public void setTen_dang_nhap(string ten_dang_nhap)
        {
            this.ten_dang_nhap = ten_dang_nhap;
        }

        public string getMat_khau()
        {
            return mat_khau;
        }

        public void setMat_khau(string mat_khau)
        {
            this.mat_khau = mat_khau;
        }

        public string getVai_tro()
        {
            return vai_tro;
        }

        public void setVai_tro(string vai_tro)
        {
            this.vai_tro = vai_tro;
        }

        public string getMa_nhan_vien()
        {
            return ma_nhan_vien;
        }

        public void setMa_nhan_vien(string ma_nhan_vien)
        {
            this.ma_nhan_vien = ma_nhan_vien;
        }
        public string getStatus()
        {
            return status;
        }
        public void setStatus(string status)
        {
            this.status = status;
        }
    }
}
