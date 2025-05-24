using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.DAO
{
    internal class ColorDAO : BaseDAO<ColorModel>
    {
        public static void fillColorCombo(ComboBox cmb)
        {
            fillDataToCombo(cmb, "SELECT mamau, tenmau FROM tblMau", "mamau", "tenmau");
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

        protected override ColorModel MapReaderToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
