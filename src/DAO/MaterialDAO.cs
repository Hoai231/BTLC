using BTL_C_.src.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class MaterialDAO : BaseDAO<MaterialModel>
  {
    public static void fillMaterialCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT macl, tencl FROM tblChatLieu ", "macl", "tencl");
    }

    protected override string getColumns()
    {
      throw new NotImplementedException();
    }

    protected override string getKeyColumn()
    {
      throw new NotImplementedException();
    }

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName()
    {
      throw new NotImplementedException();
    }

    protected override MaterialModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
