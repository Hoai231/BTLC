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
  public partial class DashBoardControl : UserControl
  {
    public DashBoardControl()
    {
      InitializeComponent();
    }
    public void loadFormData(int slsp, int slncc, int slkh, int slnv, int slcl, int sll, int slcv, int slhdn, int slhdb)
    {
      lblSLSP.Text = slsp.ToString();
      lblSLNCC.Text = slncc.ToString();
      lblSLKH.Text = slkh.ToString();
      lblSLNV.Text = slnv.ToString();
      lblSLCL.Text = slcl.ToString();
      lblSLL.Text = sll.ToString();
      lblSLCV.Text = slcv.ToString();
      lblSLHDN.Text = slhdn.ToString();
      lblSLHDB.Text = slhdb.ToString();
    }
  }
}
