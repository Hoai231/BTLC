using BTL_C_.src.Utils;
using System.Drawing;

namespace BTL_C_.src.Views.Admin
{
  partial class SidebarControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnTrangChu = new System.Windows.Forms.Button();
      this.btnTaiKhoan = new System.Windows.Forms.Button();
      this.btnSanPham = new System.Windows.Forms.Button();
      this.btnDangXuat = new System.Windows.Forms.Button();
      this.btnNhaCungCap = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnTrangChu
      // 
      this.btnTrangChu.Location = new System.Drawing.Point(0, 34);
      this.btnTrangChu.Name = "btnTrangChu";
      this.btnTrangChu.Size = new System.Drawing.Size(243, 48);
      this.btnTrangChu.TabIndex = 0;
      this.btnTrangChu.Text = "Trang Chủ";
      this.btnTrangChu.UseVisualStyleBackColor = true;
      // 
      // btnTaiKhoan
      // 
      this.btnTaiKhoan.Location = new System.Drawing.Point(0, 81);
      this.btnTaiKhoan.Name = "btnTaiKhoan";
      this.btnTaiKhoan.Size = new System.Drawing.Size(243, 48);
      this.btnTaiKhoan.TabIndex = 1;
      this.btnTaiKhoan.Text = "Tài Khoản";
      this.btnTaiKhoan.UseVisualStyleBackColor = true;
      // 
      // btnSanPham
      // 
      this.btnSanPham.Location = new System.Drawing.Point(0, 128);
      this.btnSanPham.Name = "btnSanPham";
      this.btnSanPham.Size = new System.Drawing.Size(243, 50);
      this.btnSanPham.TabIndex = 2;
      this.btnSanPham.Text = "Sản Phẩm";
      this.btnSanPham.UseVisualStyleBackColor = true;
      // 
      // btnDangXuat
      // 
      this.btnDangXuat.Location = new System.Drawing.Point(0, 495);
      this.btnDangXuat.Name = "btnDangXuat";
      this.btnDangXuat.Size = new System.Drawing.Size(243, 51);
      this.btnDangXuat.TabIndex = 3;
      this.btnDangXuat.Text = "Đăng Xuất";
      this.btnDangXuat.UseVisualStyleBackColor = true;
      // 
      // btnNhaCungCap
      // 
      this.btnNhaCungCap.Location = new System.Drawing.Point(0, 177);
      this.btnNhaCungCap.Name = "btnNhaCungCap";
      this.btnNhaCungCap.Size = new System.Drawing.Size(243, 50);
      this.btnNhaCungCap.TabIndex = 4;
      this.btnNhaCungCap.Text = "Nhà cung cấp";
      this.btnNhaCungCap.UseVisualStyleBackColor = true;
      // 
      // SidebarControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.GreenYellow;
      this.Controls.Add(this.btnNhaCungCap);
      this.Controls.Add(this.btnDangXuat);
      this.Controls.Add(this.btnSanPham);
      this.Controls.Add(this.btnTaiKhoan);
      this.Controls.Add(this.btnTrangChu);
      this.Name = "SidebarControl";
      this.Size = new System.Drawing.Size(243, 546);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button btnTrangChu;
    private System.Windows.Forms.Button btnTaiKhoan;
    private System.Windows.Forms.Button btnSanPham;
    private System.Windows.Forms.Button btnDangXuat;
    private System.Windows.Forms.Button btnNhaCungCap;
  }
}
