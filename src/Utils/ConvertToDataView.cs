using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Utils
{
    internal class ConvertToDataView
    {
        public static DataView ObjectToDataView<T>(T obj)
        {
            DataTable table = new DataTable();
            var props = typeof(T).GetProperties();

            foreach (var prop in props)
            {
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            DataRow row = table.NewRow();
            foreach (var prop in props)
            {
                row[prop.Name] = prop.GetValue(obj) ?? DBNull.Value;
            }
            table.Rows.Add(row);
            return table.DefaultView;
        }

    }
}
