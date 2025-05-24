using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
    public partial class FrmCreateProduct : Form
    {
        public FrmCreateProduct()
        {
            InitializeComponent();
        }
        public void setTaoListener(EventHandler handler) => btnTao.Click += handler;
        public ComboBox getCmbCo()
        {
            return cmbCo;
        }
        public ComboBox getCmbChatLieu()
        {
            return cmbChatLieu;
        }
        public ComboBox getCmbTheLoai()
        {
            return cmbTheLoai;
        }
        public ComboBox getCmbMua()
        {
            return cmbMua;
        }
        public ComboBox getCmbMau()
        {
            return cmbMau;
        }
        public ComboBox getCmbDoiTuong()
        {
            return cmbDoiTuong;
        }
        public ComboBox getCmbNoiSanXuat()
        {
            return cmbNoiSanXuat;
        }
        public string getTenSanPham()
        {
            return txtTenSanPham.Text.Trim();
        }
        public string getMaTheLoai()
        {
            return cmbTheLoai.SelectedValue.ToString();
        }
        public string getMaChatLieu()
        {
            return cmbChatLieu.SelectedValue.ToString();
        }
        public string getMaMau()
        {
            return cmbMau.SelectedValue.ToString();
        }
        public string getMaMua()
        {
            return cmbMua.SelectedValue.ToString();
        }
        public string getMaCo()
        {
            return cmbCo.SelectedValue.ToString();
        }
        public string getMaDoiTuong()
        {
            return cmbDoiTuong.SelectedValue.ToString();
        }
        public string getMaNoiSanXuat()
        {
            return cmbNoiSanXuat.SelectedValue.ToString();
        }
        public string getTrangThai()
        {
            return cmbTrangThai.SelectedItem.ToString();
        }
        public int getSoLuongTonKho()
        {
            return (int)slTonKho.Value;
        }
        public float getDonGiaNhap()
        {
            return (float)donGiaNhap.Value;
        }
        public float getDonGiaBan()
        {
            return (float)donGiaBan.Value;
        }
    }
}
