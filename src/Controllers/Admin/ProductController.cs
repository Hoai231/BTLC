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
using System.Windows.Forms;

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
            findDataToCmbCreateProduct();
            viewFrmCreateProduct.setTaoListener(insertProduct);
        }
        public ProductController(ProductControl viewProductControl)
        {
            this.viewProductControl = viewProductControl;
            productDao = new ProductDAO();
            loadDataToGridView();
            findDataToCmbProductControl();
            setupEventListeners();
        }
        private void setupEventListeners()
        {
            viewProductControl.setProductCellClickListener(OnProductCellClick);
            viewProductControl.setLamMoiListener(reset);
            viewProductControl.setLuuListener(updateProduct);
            viewProductControl.setXoaListener(deleteProduct);
            viewProductControl.setTaoListener(redirectFrmCreateProduct);
            viewProductControl.setTimListener(findRecordsBySearch);
        }
        private void findDataToCmbCreateProduct()
        {
            CategoryDAO.fillCategoryCombo(viewFrmCreateProduct.getCmbTheLoai());
            SizeDAO.fillSizeCombo(viewFrmCreateProduct.getCmbCo());
            MadeInDAO.fillMadeInCombo(viewFrmCreateProduct.getCmbNoiSanXuat());
            MaterialDAO.fillMaterialCombo(viewFrmCreateProduct.getCmbChatLieu());
            SeasonDAO.fillSeasonCombo(viewFrmCreateProduct.getCmbMua());
            ColorDAO.fillColorCombo(viewFrmCreateProduct.getCmbMau());
            DemographicDAO.fillDemographicCombo(viewFrmCreateProduct.getCmbDoiTuong());
        }

        private void findDataToCmbProductControl()
        {
            CategoryDAO.fillCategoryCombo(viewProductControl.getCmbTheLoai());
            SizeDAO.fillSizeCombo(viewProductControl.getCmbCo());
            MadeInDAO.fillMadeInCombo(viewProductControl.getCmbNoiSanXuat());
            MaterialDAO.fillMaterialCombo(viewProductControl.getCmbChatLieu());
            SeasonDAO.fillSeasonCombo(viewProductControl.getCmbMua());
            ColorDAO.fillColorCombo(viewProductControl.getCmbMau());
            DemographicDAO.fillDemographicCombo(viewProductControl.getCmbDoiTuong());
        }
        private void insertProduct(object sender, EventArgs e)
        {
            string maquanao = GenerateIdUtil.GenerateId("PRODUCT");
            if (!InputValidate.inputCreateProductValidate(maquanao, viewFrmCreateProduct.getTenSanPham()))
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
        private void OnProductCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dgv = viewProductControl.GetDataGridViewProduct();
                var row = dgv.Rows[e.RowIndex];
                string masanpham = row.Cells[0].Value?.ToString() ?? "";
                string tensanpham = row.Cells[1].Value?.ToString() ?? "";
                string theloai = row.Cells[2].Value?.ToString() ?? "";
                string mau = row.Cells[3].Value?.ToString() ?? "";
                string nsx = row.Cells[4].Value?.ToString() ?? "";
                string dt = row.Cells[5].Value?.ToString() ?? "";
                string mua = row.Cells[6].Value?.ToString() ?? "";
                string cl = row.Cells[7].Value?.ToString() ?? "";
                string co = row.Cells[8].Value?.ToString() ?? "";
                int sltonkho = 1; // Default value
                if (row.Cells[9].Value != null && int.TryParse(row.Cells[10].Value.ToString(), out int result))
                {
                    sltonkho = result;
                }
                string anh = row.Cells[10].Value?.ToString() ?? "";
                float dongianhap;
                if (!float.TryParse(row.Cells[11].Value?.ToString(), out dongianhap))
                {
                    dongianhap = 1f; // giá trị mặc định nếu lỗi
                }
                float dongiaban;
                if (!float.TryParse(row.Cells[12].Value?.ToString(), out dongiaban))
                {
                    dongiaban = 1f;
                }


                string trangthai = row.Cells[13].Value?.ToString() ?? "";
                viewProductControl.setForm(masanpham, tensanpham, theloai, cl, mau, dt, mua, nsx, co, sltonkho, dongianhap, dongiaban, anh, trangthai);
            }
        }
        private void loadDataToGridView()
        {// Giả sử bạn đã có DataTable chứa dữ liệu tài khoản
            DataTable allAccounts = productDao.getAllRecord();

            // Tạo DataView từ DataTable và lọc theo vai trò
            DataView dv = new DataView(allAccounts);
            viewProductControl.loadDataToGridView(dv);

        }
        private void reset(object sender, EventArgs e)
        {
            viewProductControl.resetForm();
            loadDataToGridView();
        }
        private void updateProduct(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(viewProductControl.getMaSanPham()))
            {
                MessageUtil.ShowWarning("Vui lòng chọn sản phẩm muốn sửa!");
                return;
            }
            if (!InputValidate.inputCreateProductValidate(viewProductControl.getMaSanPham(), viewProductControl.getTenSanPham()))
            {
                return;
            }

            try
            {
                ProductModel product = new ProductModel(viewProductControl.getMaSanPham(), viewProductControl.getTenSanPham(), viewProductControl.getMaCo(), viewProductControl.getMaMau(), viewProductControl.getMaMua(), viewProductControl.getMaDoiTuong(), viewProductControl.getMaNoiSanXuat(), viewProductControl.getMaTheLoai(), viewProductControl.getMaChatLieu(), viewProductControl.getSoLuongTonKho(), viewProductControl.getAnh(), viewProductControl.getDonGiaNhap(), viewProductControl.getDonGiaBan(), viewProductControl.getTrangThai());
                if (!productDao.update(product))
                {
                    MessageUtil.ShowError("Cập nhật không thành công!!!");
                    return;
                }
                MessageUtil.ShowInfo("Cập nhật thành công!");
                loadDataToGridView();
            }
            catch (Exception ex)
            {
                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
            }
        }
        private void deleteProduct(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(viewProductControl.getMaSanPham()))
                {
                    MessageUtil.ShowWarning("Vui lòng chọn sản phẩm cần xóa!");
                    return;
                }
                if (!productDao.delete(viewProductControl.getMaSanPham()))
                {
                    MessageUtil.ShowError("Xóa không thành công!!!");
                    return;
                }
                MessageUtil.ShowInfo("Xóa thành công!");
                reset(sender, e);
            }
            catch (Exception ex)
            {
                ErrorUtil.handle(ex, "Đã xảy ra khi xóa!!!");
            }
        }
        private void findRecordsBySearch(object sender, EventArgs e)
        {
            try
            {
                DataView dv = productDao.findRecordsByName("tenquanao", viewProductControl.getTextSearch());
                viewProductControl.GetDataGridViewProduct().DataSource = dv; // Hiển thị danh sách đã lọc
                viewProductControl.loadDataToGridView(dv);
            }
            catch (Exception ex)
            {
                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tìm kiếm!!!");
            }
        }
        private void redirectFrmCreateProduct(object sender, EventArgs e)
        {
            AppController.startFrmCreateProduct(viewProductControl.getForm());
        }
    }
}
