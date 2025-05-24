using BTL_C_.src.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.DAO
{
    internal class ProductDAO : BaseDAO<ProductModel>
    {
        public bool insert(ProductModel product)
        {
            string query = "INSERT INTO tblSanPham (maquanao, matheloai, tenquanao, mamau, mansx, madt, mamua, sltonkho, anh, dongianhap, dongiaban, trangthai, macl, maco) " +
                         "VALUES (@maquanao, @matheloai, @tenquanao, @mamau, @mansx, @madt, @mamua, @sltonkho, @anh, @dongianhap, @dongiaban, @trangthai, @macl, @maco)";

            var parameters = new Dictionary<string, object>
        {
            {"@maquanao", product.maquanao },
            {"@matheloai", product.matheloai},
            {"@tenquanao", product.tenquanao},
            {"@mamau", product.mamau},
            {"@mansx", product.mansx},
            {"@madt", product.madt},
            {"@mamua",product.mamua },
            {"@sltonkho", product.sltonkho },
            {"@anh", product.anh },
            {"@dongianhap", product.dongianhap },
            {"@dongiaban", product.dongiaban },
            {"@trangthai", product.trangthai },
            {"@macl", product.macl },
            {"@maco", product.maco }
        };

            return ExecuteNonQuery(query, parameters);
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

        protected override ProductModel MapReaderToObject(SqlDataReader reader)
        {
            throw new NotImplementedException();
        }
    }
}
