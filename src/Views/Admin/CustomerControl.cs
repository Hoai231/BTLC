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
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetTimListener(EventHandler handler) => btnTim.Click += handler;
    public void SetCustomerCellClickListener(DataGridViewCellEventHandler handler) => dgvKhachHang.CellClick += handler;
    public void SetFormData(string makh, string tenkh, string sdt, int point)
    {
      txtMaKH.Text = makh;
      txtTenKH.Text = tenkh;
      mskSDT.Text = sdt;
      numDiem.Value = point;
    }
    public void ResetForm()
    {
      txtMaKH.Text = "";
      txtTenKH.Text = "";
      mskSDT.Text = "";
      numDiem.Value = 1;
    }
    public void LoadDataToGridView(DataView dv)
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
    public DataGridView GetDataGridViewCustomer() => dgvKhachHang;
    public string GetMaKH() => txtMaKH.Text.Trim();
    public string GetTenKH() => txtTenKH.Text.Trim();
    public string GetSDT() => mskSDT.Text.Trim();
    public int GetDiemTichLuy() => (int)numDiem.Value;
    public string GetTextSearch() => txtSearch.Text.Trim();

  }
}
