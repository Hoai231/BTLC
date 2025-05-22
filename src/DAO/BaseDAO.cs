using BTL_C_.Configs;
using BTL_C_.src.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
    internal abstract class BaseDAO<T>
    {
        protected abstract string GetTableName();
        protected abstract string GetKeyExist();
        protected abstract string getKeyColumn();
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
        public bool checkExist(String value)
        {
            string query = "Select Count(*) from " + GetTableName() + " where " + GetKeyExist() + " = @value";
            using (SqlConnection conn = ConfigDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@value", value);

                conn.Open();
                int count = (int)cmd.ExecuteScalar(); // lấy số lượng dòng

                return count > 0; // nếu > 0 thì tồn tại
            }
        }
    }
}
