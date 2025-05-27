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
  public partial class CustomerControl : UserControl
  {
    public CustomerControl()
    {
      InitializeComponent();
    }
    public void setLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void setLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void setXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void setTimListener(EventHandler handler) => btnTim.Click += handler;
    public void setCustomerCellClickListener(DataGridViewCellEventHandler handler) => dgvKhachHang.CellClick += handler;
    public void setFormData(string makh, string tenkh, string sdt, int point)
    {
      txtMaKH.Text = makh;
      txtTenKH.Text = tenkh;
      mskSDT.Text = sdt;
      numDiem.Value = point;
    }
    public void resetForm()
    {
      txtMaKH.Text = "";
      txtTenKH.Text = "";
      mskSDT.Text = "";
      numDiem.Value = 1;
    }
    public void loadDataToGridView(DataView dv)
    {
      dgvKhachHang.DataSource = dv;
      dgvKhachHang.Columns[0].HeaderText = "Mã khách hàng";
      dgvKhachHang.Columns[0].Width = 150;
      dgvKhachHang.Columns[1].HeaderText = "Tên khách hàng";
      dgvKhachHang.Columns[1].Width = 180;
      dgvKhachHang.Columns[2].HeaderText = "Số điện thoại";
      dgvKhachHang.Columns[2].Width = 130;
      dgvKhachHang.Columns[3].HeaderText = "Điểm tích lũy";
      dgvKhachHang.Columns[3].Width = 124;
      dgvKhachHang.ReadOnly = true;
      dgvKhachHang.AllowUserToAddRows = false;

    }
    public DataGridView getDataGridViewCustomer() => dgvKhachHang;
    public string getMaKH() => txtMaKH.Text.Trim();
    public string getTenKH() => txtTenKH.Text.Trim();
    public string getSDT() => mskSDT.Text.Trim();
    public int getDiemTichLuy() => (int)numDiem.Value;
    public string getTextSearch() => txtSearch.Text.Trim();

  }
}
