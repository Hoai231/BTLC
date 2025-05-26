using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.DAO
{
  internal class CustomerDAO : BaseDAO<CustomerModel>
  {
    protected override string getColumns() => " makh, tenkh, diachi, sdt ";

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
