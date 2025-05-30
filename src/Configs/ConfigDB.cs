using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.Configs
{
  internal class ConfigDB
  {
    private static SqlConnection con;
    private static string connectionString = "Data Source=DESKTOP-SPCD7J6\\SQLEXPRESS;Initial Catalog=QuanLyCuaHangQuanAo;Integrated Security=True;Encrypt=False";

    // Tạo kết nối nếu chưa có
    public static void Connect()
    {
      try
      {
        if (con == null)
        {
          con = new SqlConnection(connectionString);
        }

        if (con.State == ConnectionState.Closed)
        {
          con.Open();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Không thể kết nối CSDL: " + ex.Message);
      }
    }

    public static void Close()
    {
      try
      {
        if (con != null && con.State == ConnectionState.Open)
        {
          con.Close();
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show("Lỗi khi đóng kết nối: " + ex.Message);
      }
    }

    public static SqlConnection GetConnection()
    {
      return new SqlConnection(connectionString); // Luôn tạo mới
    }



    public static string getSQLdateFromText(string dateDDMMYYYY)
    {
      string[] elemets = dateDDMMYYYY.Split('/');
      return elemets[2] + '/' + elemets[1] + '/' + elemets[0];

    }

  }
}
