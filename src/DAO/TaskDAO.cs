using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.DAO
{
  internal class TaskDAO : BaseDAO<TaskModel>
  {
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
