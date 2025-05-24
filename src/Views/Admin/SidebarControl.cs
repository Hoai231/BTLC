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
    public partial class SidebarControl : UserControl
    {
        public SidebarControl()
        {
            InitializeComponent();
        }
        public void setTaiKhoanListener(EventHandler handler) => btnTaiKhoan.Click += handler;
        public void setSanPhamListener(EventHandler handler) => btnSanPham.Click += handler;
    }
}
