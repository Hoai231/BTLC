using BTL_C_.src.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class DemographicDAO : BaseDAO<DemographicModel>
  {
    public static void fillDemographicCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT madt, tendt FROM tblDoiTuong ", "madt", "tendt");
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

    protected override DemographicModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
