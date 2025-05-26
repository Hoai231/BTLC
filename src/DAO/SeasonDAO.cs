using BTL_C_.src.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class SeasonDAO : BaseDAO<SeasonModel>
  {
    public static void fillSeasonCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT mamua, tenmua FROM tblMua", "mamua", "tenmua");
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

    protected override SeasonModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
