using System;
using System.Data;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class ProductControl : UserControl
  {
    public ProductControl()
    {
      InitializeComponent();
    }
    public void SetLamMoiListener(EventHandler handler) => btnLamMoi.Click += handler;
    public void SetLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void SetXoaListener(EventHandler handler) => btnXoa.Click += handler;
    public void SetTaoListener(EventHandler handler) => btnTao.Click += handler;
    public void SetTimListener(EventHandler handler) => btnTim.Click += handler;
    public void SetProductCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewProduct.CellClick += handler;

    public void LoadDataToGridView(DataView dv)
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
    public void ResetForm()
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
    public void SetForm(string masanpham, string tensanpham, string theloai, string chatlieu, string mau, string dt, string mua, string nsx, string co, int sltonkho, float dongianhap, float dongiaban, string anh, string trangthai)
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
    public ComboBox GetCmbCo()
    {
      return cmbCo;
    }
    public ComboBox GetCmbChatLieu()
    {
      return cmbChatLieu;
    }
    public ComboBox GetCmbTheLoai()
    {
      return cmbTheLoai;
    }
    public ComboBox GetCmbMua()
    {
      return cmbMua;
    }
    public ComboBox GetCmbMau()
    {
      return cmbMau;
    }
    public ComboBox GetCmbDoiTuong()
    {
      return cmbDoiTuong;
    }
    public ComboBox GetCmbNoiSanXuat()
    {
      return cmbNoiSanXuat;
    }
    public string GetTenSanPham()
    {
      return txtTenSanPham.Text.Trim();
    }
    public string GetMaSanPham()
    {
      return txtMaSanPham.Text.Trim();
    }
    public string GetMaTheLoai()
    {
      return cmbTheLoai.SelectedValue.ToString();
    }
    public string GetMaChatLieu()
    {
      return cmbChatLieu.SelectedValue.ToString();
    }
    public string GetMaMau()
    {
      return cmbMau.SelectedValue.ToString();
    }
    public string GetMaMua()
    {
      return cmbMua.SelectedValue.ToString();
    }
    public string GetMaCo()
    {
      return cmbCo.SelectedValue.ToString();
    }
    public string GetMaDoiTuong()
    {
      return cmbDoiTuong.SelectedValue.ToString();
    }
    public string GetMaNoiSanXuat()
    {
      return cmbNoiSanXuat.SelectedValue.ToString();
    }
    public string GetTrangThai()
    {
      return cmbTrangThai.SelectedItem.ToString();
    }
    public int GetSoLuongTonKho()
    {
      return (int)slTonKho.Value;
    }
    public float GetDonGiaNhap()
    {
      return (float)donGiaNhap.Value;
    }
    public float GetDonGiaBan()
    {
      return (float)donGiaBan.Value;
    }
    public string GetAnh()
    {
      return txtAnh.Text.Trim();
    }
    public Form GetForm()
    {
      return this.FindForm();
    }
    public string GetTextSearch()
    {
      return txtSearch.Text.Trim();
    }


  }
}
