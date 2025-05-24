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
    }
}
