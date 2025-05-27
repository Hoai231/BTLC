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
  public partial class EmployeeControl : UserControl
  {
    public EmployeeControl()
    {
      InitializeComponent();
    }
    public void setLamMoiLítener(EventHandler handler) => btnLamMoi.Click += handler;
    public void setLuuListener(EventHandler handler) => btnLuu.Click += handler;
    public void setTimListener(EventHandler handler) => btnTim.Click += handler;
    public void setEmployeeCellClickListener(DataGridViewCellEventHandler handler) => dataGridViewEmployee.CellClick += handler;
    public void loadDataToGridView(DataView dv)
    {
      dataGridViewEmployee.DataSource = dv;
      dataGridViewEmployee.Columns[0].HeaderText = "Mã nhân viên";

      dataGridViewEmployee.Columns[1].HeaderText = "Tên nhân viên";
      dataGridViewEmployee.Columns[1].Width = 157;

      dataGridViewEmployee.Columns[2].HeaderText = "Giới tính";
      dataGridViewEmployee.Columns[3].HeaderText = "Ngày sinh";
      dataGridViewEmployee.Columns[4].HeaderText = "Số điện thoại";
      dataGridViewEmployee.Columns[5].HeaderText = "Công việc";
      dataGridViewEmployee.Columns[6].HeaderText = "Địa chỉ";
      dataGridViewEmployee.Columns[6].Width = 113;

      dataGridViewEmployee.ReadOnly = true;
      dataGridViewEmployee.AllowUserToAddRows = false;
    }
    public void setForm(string manv, string tennv, string diachi, string gt, string congviec, string sdt, DateTime? ngaysinh)
    {
      txtMaNhanVien.Text = manv;
      txtTenNhanVien.Text = tennv;
      txtDiaChi.Text = diachi;
      if (cmbGioiTinh.Items.Contains(gt))
        cmbGioiTinh.SelectedItem = gt;

      if (cmbCongViec.Items.Contains(congviec))
        cmbCongViec.SelectedItem = congviec;
      mskSDT.Text = sdt;
      dateNgaySinh.Value = ngaysinh ?? DateTime.Today;
    }
    public void resetForm()
    {
      txtMaNhanVien.Text = "";
      txtTenNhanVien.Text = "";
      txtDiaChi.Text = "";
      cmbCongViec.SelectedItem = "";
      cmbGioiTinh.SelectedItem = "";
      mskSDT.Text = "";
      dateNgaySinh.Value = DateTime.Today;
    }
    public ComboBox getCmbCongViec()
    {
      return cmbCongViec;
    }
    public string getMaNV() => txtMaNhanVien.Text.Trim();

    public string getTenNV() => txtTenNhanVien.Text.Trim();

    public string getDiaChi() => txtDiaChi.Text.Trim();
    public string getCongViec() => cmbCongViec.SelectedValue.ToString();
    public string getGioiTinh() => (string)cmbGioiTinh.SelectedItem;
    public DateTime getNgaySinh() => dateNgaySinh.Value;
    public string getSDT() => mskSDT.Text.Trim();
    public string getTextSearch() => txtSearch.Text.Trim();
    public DataGridView GetDataGridViewEmployee() => dataGridViewEmployee;
  }
}
