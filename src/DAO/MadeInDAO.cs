using BTL_C_.src.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class MadeInDAO : BaseDAO<MadeInModel>
  {
    public static void fillMadeInCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT mansx, tennsx FROM tblNoiSanXuat ", "mansx", "tennsx");
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

    protected override MadeInModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
