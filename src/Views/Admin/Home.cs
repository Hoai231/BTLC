using System.Windows.Forms;

namespace BTL_C_.src.Views.Admin
{
  public partial class Home : Form
  {
    private Panel panelMain;
    private SidebarControl sidebar;
    public Home()
    {
      InitializeComponent();
      InitLayout();
    }

    // Use the 'new' keyword to explicitly hide the inherited member
    private new void InitLayout()
    {
      sidebar = new SidebarControl();
      sidebar.Dock = DockStyle.Left;
      this.Controls.Add(sidebar);
      panelMain = new Panel();
      panelMain.Dock = DockStyle.Fill;
      panelMain.Name = "panelMain"; // có thể đặt tên nếu cần dùng lại
      this.Controls.Add(panelMain);
      panelMain.BringToFront(); // Đảm bảo panelMain không che sidebar
    }

    public void loadControl(UserControl uc)
    {
      panelMain.Controls.Clear();
      uc.Dock = DockStyle.Fill;
      panelMain.Controls.Add(uc);
    }
    public SidebarControl getSidebar()
    {
      return sidebar;
    }
    public Form getForm()
    {
      return this;
    }


  }
}
