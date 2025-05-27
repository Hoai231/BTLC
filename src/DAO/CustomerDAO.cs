using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace BTL_C_.src.DAO
{
  internal class CustomerDAO : BaseDAO<CustomerModel>
  {
    public bool update(CustomerModel customer)
    {
      string sql = "Update tblKhachHang SET tenkh = @tenkh, sdt = @sdt, point = @point where makh = @makh";
      var parameters = new Dictionary<string, object>
      {
        {"@tenkh", customer.tenkh },
        {"@sdt", customer.sdt },
        {"@point", customer.diem },
        {"@makh", customer.makh }
      };
      return ExecuteNonQuery(sql, parameters);
    }
    protected override string getColumns() => " makh, tenkh, sdt, point ";

    protected override string getKeyColumn() => " makh ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblKhachHang ";

    protected override CustomerModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
