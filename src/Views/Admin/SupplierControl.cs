using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class SupplierControl : UserControl
  {
    public SupplierControl()
    {
      InitializeComponent();
    }

    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetTimListener(EventHandler handler) => btnTim.Click += handler;
    public void SetSupplierCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewNhaCungCap.CellClick += handler;
    public string GetMaNCC() => txtMaNCC.Text.Trim();
    public string GetTenNCC() => txtTenNCC.Text.Trim();
    public string GetSDT() => txtDienThoai.Text.Trim();
    public string GetDiaChi() => txtDiaChi.Text.Trim();
    public string GetTextSearch() => txtSearch.Text.Trim();

    public void LoadDataToGridView(DataView dv)
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
    public void SetFormData(string mancc, string tenncc, string diachi, string sdt)
    {
      txtMaNCC.Text = mancc;
      txtTenNCC.Text = tenncc;
      txtDiaChi.Text = diachi;
      txtDienThoai.Text = sdt;
    }
    public void ResetForm()
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
