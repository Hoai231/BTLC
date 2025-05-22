using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BTL_C_.Configs;

namespace BTL_C_.src.DAO
{
    internal abstract class BaseDAO<T>
    {
        protected bool ExecuteNonQuery(string query, Dictionary<string, object> parameters)
        {
            try
            {
                using (SqlConnection conn = ConfigDB.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }

                    conn.Open(); // Mỗi lần mở một kết nối riêng
                    return cmd.ExecuteNonQuery() > 0;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Thêm tài khoản không thành công!!!", ex);
            }
        }


        // Hàm này bạn có thể mở rộng cho SELECT, GetAll...
        protected DataTable ExecuteQuery(string query, Dictionary<string, object> parameters = null)
        {
            DataTable dt = new DataTable();
            using (SqlConnection conn = ConfigDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                if (parameters != null)
                {
                    foreach (var param in parameters)
                    {
                        cmd.Parameters.AddWithValue(param.Key, param.Value ?? DBNull.Value);
                    }
                }

                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    adapter.Fill(dt);
                }
            }
            return dt;
        }
    }
}
