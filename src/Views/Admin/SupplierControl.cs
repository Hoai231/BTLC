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
    public partial class SupplierControl : UserControl
    {
        public SupplierControl()
        {
            InitializeComponent();
        }

        public void setLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
        public void setTaoListener(EventHandler handler) => btnTao.Click += handler;
        public void setLuuListener(EventHandler handler) => btnLuu.Click += handler;
        public void setXoaListener(EventHandler handler) => btnXoa.Click += handler;
        public void setSupplierCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewNhaCungCap.CellClick += handler;
        public string getMaNCC() => txtMaNCC.Text.Trim();
        public string getTenNCC() => txtTenNCC.Text.Trim();
        public string getSDT() => txtDienThoai.Text.Trim();
        public string getDiaChi() => txtDiaChi.Text.Trim();

        public void loadDataToGridView(DataView dv)
        {
            dataGridViewNhaCungCap.DataSource = dv;
            dataGridViewNhaCungCap.Columns[0].HeaderText = "Mã nhà cung cấp";
            dataGridViewNhaCungCap.Columns[0].Width = 147;

            dataGridViewNhaCungCap.Columns[1].HeaderText = "Tên nhà cung cấp";
            dataGridViewNhaCungCap.Columns[1].Width = 167;

            dataGridViewNhaCungCap.Columns[2].HeaderText = "Địa chỉ";
            dataGridViewNhaCungCap.Columns[2].Width = 187;
            dataGridViewNhaCungCap.Columns[3].HeaderText = "Số điện thoại";
            dataGridViewNhaCungCap.Columns[3].Width = 157;

            dataGridViewNhaCungCap.ReadOnly = true;
            dataGridViewNhaCungCap.AllowUserToAddRows = false;
        }
        public void setFormData(string mancc, string tenncc, string diachi, string sdt)
        {
            txtMaNCC.Text = mancc;
            txtTenNCC.Text = tenncc;
            txtDiaChi.Text = diachi;
            txtDienThoai.Text = sdt;
        }
        public void resetForm()
        {
            txtMaNCC.Text = "";
            txtTenNCC.Text = "";
            txtDienThoai.Text = "";
            txtDiaChi.Text = "";
        }
        public DataGridView GetDataGridViewSupplier()
        {
            return dataGridViewNhaCungCap;
        }
    }
}
