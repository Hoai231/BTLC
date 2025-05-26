using System;
using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class SidebarControl : UserControl
  {
    public SidebarControl()
    {
      InitializeComponent();
    }
    public void setTaiKhoanListener(EventHandler handler) => btnTaiKhoan.Click += handler;
    public void setSanPhamListener(EventHandler handler) => btnSanPham.Click += handler;
    public void setDangXuatListener(EventHandler handler) => btnDangXuat.Click += handler;
    public void setNhaCungCapListener(EventHandler handler) => btnNhaCungCap.Click += handler;
  }
}
