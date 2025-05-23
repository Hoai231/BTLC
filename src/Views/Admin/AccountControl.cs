using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
    public partial class AccountControl : UserControl
    {
        public AccountControl()
        {
            InitializeComponent();
        }
        public void loadDataToGridView(DataView dv)
        {
            dataGridViewAccount.DataSource = dv;
            dataGridViewAccount.Columns[0].HeaderText = "Mã tài khoản";

            dataGridViewAccount.Columns[1].HeaderText = "Email";
            dataGridViewAccount.Columns[1].Width = 147; // Email rộng 147px

            dataGridViewAccount.Columns[2].HeaderText = "Tên đăng nhập";
            dataGridViewAccount.Columns[3].HeaderText = "Mật khẩu";
            dataGridViewAccount.Columns[3].Visible = false;
            dataGridViewAccount.Columns[4].HeaderText = "Vai trò";
            dataGridViewAccount.Columns[5].HeaderText = "Mã nhân viên";
            dataGridViewAccount.Columns[6].HeaderText = "Trạng thái";

            dataGridViewAccount.ReadOnly = true;
            dataGridViewAccount.AllowUserToAddRows = false;
        }
        public void setFormData(string matk, string email, string tendangnhap, string vaitro, string status, string manv)
        {
            txtMaTaiKhoan.Text = matk;
            txtEmail.Text = email;
            txtTenDangNhap.Text = tendangnhap;
            cmbVaiTro.SelectedItem = vaitro;
            btnTrangThai.Text = status;
            txtMaNV.Text = manv;
        }
        public void setAccountCellClickListener(DataGridViewCellEventHandler handler)
     => dataGridViewAccount.CellClick += handler;
        public void setLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
        public void setLuuListener(EventHandler handler) => btnLuu.Click += handler;
        public void setXoaListener(EventHandler handler) => btnXoa.Click += handler;
        public void setTrangThaiListener(EventHandler handler) => btnTrangThai.Click += handler;
        public void setTimListener(EventHandler handler) => btnTim.Click += handler;
        public void setTaoListener(EventHandler handler) => btnTao.Click += handler;
        public DataGridView GetDataGridView() => dataGridViewAccount;
        public void resetForm()
        {
            txtEmail.Text = "";
            txtMaNV.Text = "";
            txtMaTaiKhoan.Text = "";
            txtMatKhau.Text = "";
            txtTenDangNhap.Text = "";
            btnTrangThai.Text = "";
            cmbVaiTro.SelectedItem = "";
            dataGridViewAccount.ClearSelection();
        }
        public string getMatk()
        {
            return txtMaTaiKhoan.Text.Trim();
        }
        public string getEmail()
        {
            return txtEmail.Text.Trim();
        }
        public string getTenDangNhap()
        {
            return txtTenDangNhap.Text.Trim();
        }
        public string getVaiTro()
        {
            return (string)cmbVaiTro.SelectedItem;
        }
        public string getStatus()
        {
            return btnTrangThai.Text.Trim();
        }
        public string getMaNV()
        {
            return txtMaNV.Text.Trim();
        }
        public string getSearchText()
        {
            return txtSearch.Text.Trim();
        }
        public void setStatus(string status)
        {
            btnTrangThai.Text = status;
        }
        public Form getForm()
        {
            return this.FindForm();
        }
    }

}
