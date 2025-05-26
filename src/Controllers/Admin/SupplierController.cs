using BTL_C_.src.DAO;
using BTL_C_.src.Models;
using BTL_C_.src.Utils;
using BTL_C_.src.Validators;
using BTL_C_.src.Views.Admin;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTL_C_.src.Controllers.Admin
{
    internal class SupplierController
    {
        private SupplierControl supplierControl;
        private SupplierDAO supplierDAO;
        public SupplierController(SupplierControl supplierControl)
        {
            this.supplierControl = supplierControl;
            supplierDAO = new SupplierDAO();
            loadDataToGridView();
            setupEventListeners();
        }
        private void setupEventListeners()
        {
            supplierControl.setLamMoiListener(reset);
            supplierControl.setTaoListener(insertSupplier);
            supplierControl.setSupplierCellClickListener(OnSupplierCellClick);
            supplierControl.setLuuListener(updateSupplier);
            supplierControl.setXoaListener(deletedSupplier);
        }
        public void insertSupplier(object sender, EventArgs e)
        {
            string mancc = GenerateIdUtil.GenerateId("SUPPLI");
            string tenncc = supplierControl.getTenNCC();
            string diachi = supplierControl.getDiaChi();
            string sdt = ConvertUtil.convertSdtToDB(supplierControl.getSDT());//  (036) 452-1234 => 0364521234
            if (!InputValidate.inputCreaetSupplierValidate(mancc, tenncc, diachi, sdt))
                return;
            SupplierModel supplier = new SupplierModel(mancc, tenncc, diachi, sdt);
            try
            {
                if (!supplierDAO.insert(supplier))
                {
                    MessageUtil.ShowError("Tạo thất bại!!!");
                    return;
                }
                MessageUtil.ShowInfo("Tạo thành công!");
                reset(sender, e);
            }
            catch (Exception ex)
            {
                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi tạo!!!");
            }
        }
        private void updateSupplier(object sender, EventArgs e)
        {
            string mancc = supplierControl.getMaNCC();
            string tenncc = supplierControl.getTenNCC();
            string diachi = supplierControl.getDiaChi();
            string sdt = ConvertUtil.convertSdtToDB(supplierControl.getSDT());
            if (string.IsNullOrWhiteSpace(mancc))
            {
                MessageUtil.ShowWarning("Vui lòng chọn nhà cung cấp muốn sửa!");
                return;
            }
            if (!InputValidate.inputCreaetSupplierValidate(mancc, tenncc, diachi, sdt))
                return;
            SupplierModel supplier = new SupplierModel(mancc, tenncc, diachi, sdt);
            if (!MessageUtil.Confirm("Bạn có muốn cập nhật?"))
                return;
            try
            {
                if (!supplierDAO.update(supplier))
                {
                    MessageUtil.ShowError("Cập nhật thất bại!!!");
                    return;
                }
                MessageUtil.ShowInfo("Cập nhật thành công!");
                reset(sender, e);
            }
            catch (Exception ex)
            {
                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi cập nhật!!!");
            }
        }
        private void deletedSupplier(object sender, EventArgs e)
        {
            string mancc = supplierControl.getMaNCC();
            if (string.IsNullOrWhiteSpace(mancc))
            {
                MessageUtil.ShowWarning("Vui lòng chọn nhà cung cấp muốn sửa!");
                return;
            }
            if (!MessageUtil.Confirm("Bạn có chắc chắn muốn xóa?"))
                return;

            try
            {
                if (!supplierDAO.delete(mancc))
                {
                    MessageUtil.ShowError("Xóa thất bại!!!");
                    return;
                }
                MessageUtil.ShowInfo("Đã xóa thành công");
                reset(sender, e);
            }
            catch (Exception ex)
            {
                ErrorUtil.handle(ex, "Đã xảy ra lỗi khi xóa!!!");
            }
        }
        private void loadDataToGridView()
        {// Giả sử bạn đã có DataTable chứa dữ liệu tài khoản
            DataTable allAccounts = supplierDAO.getAllRecord();

            // Tạo DataView từ DataTable và lọc theo vai trò
            DataView dv = new DataView(allAccounts);

            supplierControl.loadDataToGridView(dv);
        }
        private void OnSupplierCellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var dgv = supplierControl.GetDataGridViewSupplier();
                var row = dgv.Rows[e.RowIndex];
                string mancc = row.Cells[0].Value.ToString();
                string tenncc = row.Cells[1].Value.ToString();
                string diachi = row.Cells[2].Value.ToString();
                string sdt = row.Cells[3].Value.ToString();
                supplierControl.setFormData(mancc, tenncc, diachi, sdt);
            }
        }
        private void reset(object sender, EventArgs e)
        {
            supplierControl.resetForm();
            loadDataToGridView();
        }
    }
}
