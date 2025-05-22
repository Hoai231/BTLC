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
    public partial class AccountControl : UserControl
    {
        public AccountControl()
        {
            InitializeComponent();
        }
        public void loadDataToGridView(DataView dv)
        {
            dataGridViewAccount.DataSource = dv;
            dataGridViewAccount.Columns[0].HeaderText = "Mã tài khoản";
            dataGridViewAccount.Columns[1].HeaderText = "Tên đăng nhập";
            dataGridViewAccount.Columns[2].HeaderText = "Email";
            dataGridViewAccount.Columns[3].HeaderText = "Mật khẩu";
            dataGridViewAccount.Columns[4].HeaderText = "Vai trò";
            dataGridViewAccount.Columns[5].HeaderText = "Mã nhân viên";
            dataGridViewAccount.Columns[6].HeaderText = "Trạng thái";

            dataGridViewAccount.AllowUserToAddRows = false;
        }



    }
}
