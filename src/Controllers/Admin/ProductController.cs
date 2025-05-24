using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTL_C_.src.Controllers.Admin
{
    internal class ProductController
    {
        private FrmCreateProduct viewFrmCreateProduct;
        private ProductControl viewProductControl;
        private ProductDAO productDao;
        public ProductController(FrmCreateProduct viewFrmCreateProduct)
        {
            this.viewFrmCreateProduct = viewFrmCreateProduct;
            productDao = new ProductDAO();
            CategoryDAO.fillCategoryCombo(viewFrmCreateProduct.getCmbTheLoai());
            SizeDAO.fillSizeCombo(viewFrmCreateProduct.getCmbCo());
            MadeInDAO.fillMadeInCombo(viewFrmCreateProduct.getCmbNoiSanXuat());
            MaterialDAO.fillMaterialCombo(viewFrmCreateProduct.getCmbChatLieu());
            SeasonDAO.fillSeasonCombo(viewFrmCreateProduct.getCmbMua());
            ColorDAO.fillColorCombo(viewFrmCreateProduct.getCmbMau());
            DemographicDAO.fillDemographicCombo(viewFrmCreateProduct.getCmbDoiTuong());
            viewFrmCreateProduct.setTaoListener(insertProduct);
        }
        public ProductController(ProductControl viewProductControl)
        {
            this.viewProductControl = viewProductControl;
            productDao = new ProductDAO();
            loadDataToGridView();
        }
        private void insertProduct(object sender, EventArgs e)
        {
            string maquanao = GenerateIdUtil.GenerateId("PRODUCT");
            if (!ImputValidate.inputCreateProductValidate(maquanao, viewFrmCreateProduct.getTenSanPham()))
            {
                return;
            }
            ProductModel product = new ProductModel(
                maquanao,
                viewFrmCreateProduct.getTenSanPham(),
                viewFrmCreateProduct.getMaCo(),
                viewFrmCreateProduct.getMaMau(),
                viewFrmCreateProduct.getMaMua(),
                viewFrmCreateProduct.getMaDoiTuong(),
                viewFrmCreateProduct.getMaNoiSanXuat(),
                viewFrmCreateProduct.getMaTheLoai(),
                viewFrmCreateProduct.getMaChatLieu(),
                viewFrmCreateProduct.getSoLuongTonKho(),
                "", // đường dẫn ảnh để trống
                viewFrmCreateProduct.getDonGiaNhap(),
                viewFrmCreateProduct.getDonGiaBan(),
                viewFrmCreateProduct.getTrangThai()
            );
            try
            {
                if (!productDao.insert(product))
                {
                    MessageUtil.ShowError("Tạo thất bại!!!");
                    return;
                }
                MessageUtil.ShowInfo("Tạo thành công!");

            }
            catch (Exception ex)
            {
                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tạo!!!");
            }

        }
        private void loadDataToGridView()
        {// Giả sử bạn đã có DataTable chứa dữ liệu tài khoản
            DataTable allAccounts = productDao.getAllRecord();

            // Tạo DataView từ DataTable và lọc theo vai trò
            DataView dv = new DataView(allAccounts);
            viewProductControl.loadDataToGridView(dv);

        }
    }
}
