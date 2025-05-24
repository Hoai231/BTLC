using BTL_C_.Configs;
using BTL_C_.src.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
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
        protected abstract string getColumns();
        protected virtual string getName() => null;
        protected virtual string GetAlias() => null;
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
                throw new Exception("Đã xảy ra lỗi!!!", ex);
            }
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
        public T findRecordByField(string field, string value)
        {
            string query = "Select " + getColumns() + " from " + GetTableName() + " where " + field + " = @value  and deleted=0";

            try
            {
                using (SqlConnection conn = ConfigDB.GetConnection())
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@value", value);
                    conn.Open();

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return MapReaderToObject(reader);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Log lỗi, hoặc xử lý tùy app (throw lại, hoặc trả null, hoặc báo lỗi)
                throw new Exception("Đã xảy ra lỗi khi truy vấn!!!", ex);
                // Có thể throw lại để bên trên bắt hoặc trả mặc định
            }

            return default(T);
        }

        protected abstract T MapReaderToObject(SqlDataReader reader);
        public DataTable getAllRecord()
        {
            string query = "SELECT" + getColumns() + "FROM " + GetTableName() + " where deleted=0";

            using (SqlConnection conn = ConfigDB.GetConnection())
            {
                try
                {
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Đã xảy ra lỗi khi truy vấn!!!", ex);
                }

            }

        }
        public DataTable findRecordsByName(string value)
        {
            string query = "Select " + getColumns() + " From " + GetTableName() + " where deleted=0 and " + getName() + " Like @value  ";
            using (SqlConnection conn = ConfigDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@value", "%" + value + "%");
                    conn.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                catch (Exception ex)
                {
                    throw new Exception("Đã xảy ra lỗi khi truy vấn!!!", ex);
                }

            }
        }

        public bool delete(string value)
        {
            string sql;
            if (!string.IsNullOrWhiteSpace(GetAlias()))
            {
                sql = $"UPDATE {GetAlias()} SET deleted = 1 FROM {GetTableName()} WHERE {getKeyColumn()} = @value";
            }
            else
            {
                sql = $"UPDATE {GetTableName()} SET deleted = 1 WHERE {getKeyColumn()} = @value";
            }

            using (SqlConnection conn = ConfigDB.GetConnection())
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                try
                {
                    cmd.Parameters.AddWithValue("@value", value);
                    conn.Open();
                    return cmd.ExecuteNonQuery() > 0;
                }
                catch (Exception ex)
                {
                    throw new Exception("Đã xảy ra lỗi khi xóa!!!", ex);
                }
            }
        }
        public static void fillDataToCombo(ComboBox cmb, string sql, string value, string display)
        {
            using (SqlConnection conn = ConfigDB.GetConnection())
            {
                conn.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                cmb.DataSource = dt;
                cmb.ValueMember = value;
                cmb.DisplayMember = display;
            }

        }

    }
}
