using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
  internal class CategoryDAO : BaseDAO<CategoryModel>
  {
    public bool insert(CategoryModel category)
    {
      string sql = "Insert into tblTheLoai(matl, tentl) values (@matl, @tentl)";
      var parameters = new Dictionary<string, object>
        {
            {"@matl", category.matl},
            {"@tentl", category.tentl}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public bool update(CategoryModel category)
    {
      string sql = "Update tblTheLoai Set tentl=@tentl where matl=@matl";
      var parameters = new Dictionary<string, object>
        {
            {"@matl", category.matl},
            {"@tentl", category.tentl}
        };

      return ExecuteNonQuery(sql, parameters);
    }
    public static void fillCategoryCombo(ComboBox cmb)
    {
      fillDataToCombo(cmb, "SELECT matl, tentl FROM tblTheLoai", "matl", "tentl");
    }

    protected override string getColumns() => " matl, tentl ";
    protected override string getKeyColumn() => " matl ";

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
