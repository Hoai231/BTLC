using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class SeasonDAO : BaseDAO<SeasonModel>
  {
    public bool insert(SeasonModel season)
    {
      string sql = "Insert into tblMua(mamua, tenmua) values (@mamua, @tenmua)";
      var parameters = new Dictionary<string, object>
        {
            {"@mamua", season.mamua},
            {"@tenmua", season.tenmua}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(SeasonModel season)
    {
      string sql = "Update tblMua Set tenmua=@tenmua where mamua=@mamua";
      var parameters = new Dictionary<string, object>
        {
            {"@mamua", season.mamua},
            {"@tenmua", season.tenmua}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public static void fillSeasonCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT mamua, tenmua FROM tblMua", "mamua", "tenmua");
    }

    protected override string getColumns() => " mamua, tenmua ";
    protected override string getKeyColumn() => " mamua ";

    protected override string GetKeyExist()
    {
      throw new NotImplementedException();
    }

    protected override string GetTableName() => " tblMua ";

    protected override SeasonModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
