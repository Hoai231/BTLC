using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Views
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            this.InitializeComponent(); // Explicitly qualify the method call to resolve ambiguity  
        }

        public String getEmail()
        {
            return txtEmail.Text.Trim();
        }

        public String getPassword()
        {
            return txtMatKhau.Text.Trim();
        }

        public void setDangNhapListener(EventHandler handler) => btnDangNhap.Click += handler;

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
        public Form getForm()
        {
            return this;
        }
    }
}
