using BTL_C_.src.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class TaskDAO : BaseDAO<TaskModel>
  {
    public static void fillTaskCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT macv, tencv FROM tblCongViec", "macv", "tencv");
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

    protected override string GetTableName() => " tblCongViec ";

    protected override TaskModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
