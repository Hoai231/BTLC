using BTL_C_.src.Models;
using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class CategoryDAO : BaseDAO<CategoryModel>
  {
    public static void fillCategoryCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT matheloai, tentl FROM tblTheLoai", "matheloai", "tentl");
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

    protected override string GetTableName() => " tblTheLoai ";

    protected override CategoryModel MapReaderToObject(SqlDataReader reader)
    {
      throw new NotImplementedException();
    }
  }
}
