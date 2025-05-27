using BTL_C_.src.Models;
using System;
using System.Data.SqlClient;

namespace BTL_C_.src.DAO
{
  internal class PurchaseInvoiceDAO : BaseDAO<PurchaseInvoiceModel>
  {
    protected override string getColumns()
    {
      throw new NotImplementedException();
    }

    protected override string getKeyColumn() => " sohdn ";
    protected override string GetAlias() => " hdn";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblHoaDonNhap hdn Left join tblNhaCungCap ncc On hdn.mancc=ncc.mancc ";

    protected override PurchaseInvoiceModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
