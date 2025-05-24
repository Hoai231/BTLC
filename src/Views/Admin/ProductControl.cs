using BTL_C_.src.Utils;
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
    public partial class ProductControl : UserControl
    {
        public ProductControl()
        {
            InitializeComponent();
        }
        public void setLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
        public void setLuuListener(EventHandler handler) => btnLuu.Click += handler;
        public void setXoaListener(EventHandler handler) => btnXoa.Click += handler;
        public void setTaoListener(EventHandler handler) => btnTao.Click += handler;
        public void setProductCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewProduct.CellClick += handler;

        public void loadDataToGridView(DataView dv)
        {
            dataGridViewProduct.DataSource = dv;
            dataGridViewProduct.Columns[0].HeaderText = "Mã sản phẩm";

            dataGridViewProduct.Columns[1].HeaderText = "Tên sản phẩm";
            dataGridViewProduct.Columns[1].Width = 147; // Email rộng 147px

            dataGridViewProduct.Columns[2].HeaderText = "Thể loại";
            dataGridViewProduct.Columns[3].HeaderText = "Màu";
            dataGridViewProduct.Columns[4].HeaderText = "Nơi sản xuất";
            dataGridViewProduct.Columns[5].HeaderText = "Đối tượng";
            dataGridViewProduct.Columns[6].HeaderText = "Mùa";
            dataGridViewProduct.Columns[7].HeaderText = "Chất liệu";
            dataGridViewProduct.Columns[8].HeaderText = "Cỡ";
            dataGridViewProduct.Columns[9].HeaderText = "Số lượng tồn kho";
            dataGridViewProduct.Columns[10].HeaderText = "Ảnh";
            dataGridViewProduct.Columns[11].HeaderText = "Đơn giá nhập";
            dataGridViewProduct.Columns[12].HeaderText = "Đơn giá bán";
            dataGridViewProduct.Columns[13].HeaderText = "Trạng thái";

            dataGridViewProduct.ReadOnly = true;
            dataGridViewProduct.AllowUserToAddRows = false;
        }
        public void resetForm()
        {
            txtMaSanPham.Text = "";
            txtTenSanPham.Text = "";
            txtAnh.Text = "";
            txtSearch.Text = "";
            cmbChatLieu.SelectedItem = "";
            cmbCo.SelectedItem = "";
            cmbDoiTuong.SelectedItem = "";
            cmbMau.SelectedItem = "";
            cmbMua.SelectedItem = "";
            cmbNoiSanXuat.SelectedItem = "";
            cmbTheLoai.SelectedItem = "";
            cmbTrangThai.SelectedItem = "";
            donGiaNhap.Value = 1;
            donGiaBan.Value = 1;
            slTonKho.Value = 1;
        }
        public void setForm(string masanpham, string tensanpham, string theloai, string chatlieu, string mau, string dt, string mua, string nsx, string co, int sltonkho, float dongianhap, float dongiaban, string anh, string trangthai)
        {
            txtMaSanPham.Text = masanpham ?? "";
            txtTenSanPham.Text = tensanpham ?? "";
            txtAnh.Text = anh ?? "";
            slTonKho.Value = sltonkho;
            donGiaNhap.Value = (decimal)dongianhap;
            donGiaBan.Value = (decimal)dongiaban;
            cmbChatLieu.SelectedItem = chatlieu ?? "";
            cmbCo.SelectedItem = co ?? "";
            cmbDoiTuong.SelectedItem = dt ?? "";
            cmbMau.SelectedItem = mau ?? "";
            cmbMua.SelectedItem = mua ?? "";
            cmbNoiSanXuat.SelectedItem = nsx ?? "";
            cmbTheLoai.SelectedItem = theloai ?? "";
            cmbTrangThai.SelectedItem = trangthai ?? "";

            dataGridViewProduct.ClearSelection();

        }
        public DataGridView GetDataGridViewProduct()
        {
            return dataGridViewProduct;
        }
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
        public string getMaSanPham()
        {
            return txtMaSanPham.Text.Trim();
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
        public string getAnh()
        {
            return txtAnh.Text.Trim();
        }
        public Form getForm()
        {
            return this.FindForm();
        }
    }
}
