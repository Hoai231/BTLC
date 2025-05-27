namespace BTL_C_.src.Views.Admin
{
  partial class EmployeeControl
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
      this.panel1 = new System.Windows.Forms.Panel();
      this.label9 = new System.Windows.Forms.Label();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.btnTim = new System.Windows.Forms.Button();
      this.btnLuu = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
      this.txtMaNhanVien = new System.Windows.Forms.TextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.txtTenNhanVien = new System.Windows.Forms.TextBox();
      this.mskSDT = new System.Windows.Forms.MaskedTextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.cmbGioiTinh = new System.Windows.Forms.ComboBox();
      this.label5 = new System.Windows.Forms.Label();
      this.dateNgaySinh = new System.Windows.Forms.DateTimePicker();
      this.label6 = new System.Windows.Forms.Label();
      this.label7 = new System.Windows.Forms.Label();
      this.txtDiaChi = new System.Windows.Forms.TextBox();
      this.label8 = new System.Windows.Forms.Label();
      this.cmbCongViec = new System.Windows.Forms.ComboBox();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label9);
      this.panel1.Controls.Add(this.txtSearch);
      this.panel1.Controls.Add(this.btnTim);
      this.panel1.Controls.Add(this.btnLuu);
      this.panel1.Controls.Add(this.btnLamMoi);
      this.panel1.Location = new System.Drawing.Point(3, 480);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(966, 53);
      this.panel1.TabIndex = 0;
      // 
      // label9
      // 
      this.label9.AutoSize = true;
      this.label9.Location = new System.Drawing.Point(494, 21);
      this.label9.Name = "label9";
      this.label9.Size = new System.Drawing.Size(125, 16);
      this.label9.TabIndex = 4;
      this.label9.Text = "Tìm kiếm nhân viên:";
      // 
      // txtSearch
      // 
      this.txtSearch.Location = new System.Drawing.Point(625, 15);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(272, 22);
      this.txtSearch.TabIndex = 3;
      // 
      // btnTim
      // 
      this.btnTim.Location = new System.Drawing.Point(903, 13);
      this.btnTim.Name = "btnTim";
      this.btnTim.Size = new System.Drawing.Size(46, 27);
      this.btnTim.TabIndex = 2;
      this.btnTim.Text = "Tìm";
      this.btnTim.UseVisualStyleBackColor = true;
      // 
      // btnLuu
      // 
      this.btnLuu.Location = new System.Drawing.Point(297, 11);
      this.btnLuu.Name = "btnLuu";
      this.btnLuu.Size = new System.Drawing.Size(156, 31);
      this.btnLuu.TabIndex = 1;
      this.btnLuu.Text = "Lưu";
      this.btnLuu.UseVisualStyleBackColor = true;
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.Location = new System.Drawing.Point(61, 11);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(166, 31);
      this.btnLamMoi.TabIndex = 0;
      this.btnLamMoi.Text = "Làm mới";
      this.btnLamMoi.UseVisualStyleBackColor = true;
      // 
      // dataGridViewEmployee
      // 
      this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewEmployee.Location = new System.Drawing.Point(3, 346);
      this.dataGridViewEmployee.Name = "dataGridViewEmployee";
      this.dataGridViewEmployee.RowHeadersWidth = 51;
      this.dataGridViewEmployee.RowTemplate.Height = 24;
      this.dataGridViewEmployee.Size = new System.Drawing.Size(966, 128);
      this.dataGridViewEmployee.TabIndex = 1;
      // 
      // txtMaNhanVien
      // 
      this.txtMaNhanVien.Location = new System.Drawing.Point(64, 117);
      this.txtMaNhanVien.Name = "txtMaNhanVien";
      this.txtMaNhanVien.ReadOnly = true;
      this.txtMaNhanVien.Size = new System.Drawing.Size(120, 22);
      this.txtMaNhanVien.TabIndex = 2;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(84, 82);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(86, 16);
      this.label1.TabIndex = 3;
      this.label1.Text = "Mã nhân viên";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(339, 82);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(91, 16);
      this.label2.TabIndex = 4;
      this.label2.Text = "Tên nhân viên";
      // 
      // txtTenNhanVien
      // 
      this.txtTenNhanVien.Location = new System.Drawing.Point(263, 117);
      this.txtTenNhanVien.Name = "txtTenNhanVien";
      this.txtTenNhanVien.Size = new System.Drawing.Size(231, 22);
      this.txtTenNhanVien.TabIndex = 5;
      // 
      // mskSDT
      // 
      this.mskSDT.Location = new System.Drawing.Point(585, 117);
      this.mskSDT.Mask = "(999) 000-0000";
      this.mskSDT.Name = "mskSDT";
      this.mskSDT.Size = new System.Drawing.Size(118, 22);
      this.mskSDT.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(604, 84);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(85, 16);
      this.label3.TabIndex = 7;
      this.label3.Text = "Số điện thoại";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.Location = new System.Drawing.Point(816, 84);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(54, 16);
      this.label4.TabIndex = 8;
      this.label4.Text = "Giới tính";
      // 
      // cmbGioiTinh
      // 
      this.cmbGioiTinh.FormattingEnabled = true;
      this.cmbGioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
      this.cmbGioiTinh.Location = new System.Drawing.Point(779, 115);
      this.cmbGioiTinh.Name = "cmbGioiTinh";
      this.cmbGioiTinh.Size = new System.Drawing.Size(121, 24);
      this.cmbGioiTinh.TabIndex = 9;
      // 
      // label5
      // 
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.Red;
      this.label5.Location = new System.Drawing.Point(334, 12);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(311, 36);
      this.label5.TabIndex = 10;
      this.label5.Text = "Danh Sách Nhân Viên";
      // 
      // dateNgaySinh
      // 
      this.dateNgaySinh.Location = new System.Drawing.Point(64, 212);
      this.dateNgaySinh.Name = "dateNgaySinh";
      this.dateNgaySinh.Size = new System.Drawing.Size(200, 22);
      this.dateNgaySinh.TabIndex = 11;
      // 
      // label6
      // 
      this.label6.AutoSize = true;
      this.label6.Location = new System.Drawing.Point(135, 178);
      this.label6.Name = "label6";
      this.label6.Size = new System.Drawing.Size(63, 16);
      this.label6.TabIndex = 12;
      this.label6.Text = "Năm sinh";
      // 
      // label7
      // 
      this.label7.AutoSize = true;
      this.label7.Location = new System.Drawing.Point(427, 178);
      this.label7.Name = "label7";
      this.label7.Size = new System.Drawing.Size(47, 16);
      this.label7.TabIndex = 13;
      this.label7.Text = "Địa chỉ";
      // 
      // txtDiaChi
      // 
      this.txtDiaChi.Location = new System.Drawing.Point(340, 212);
      this.txtDiaChi.Name = "txtDiaChi";
      this.txtDiaChi.Size = new System.Drawing.Size(213, 22);
      this.txtDiaChi.TabIndex = 14;
      // 
      // label8
      // 
      this.label8.AutoSize = true;
      this.label8.Location = new System.Drawing.Point(720, 178);
      this.label8.Name = "label8";
      this.label8.Size = new System.Drawing.Size(67, 16);
      this.label8.TabIndex = 15;
      this.label8.Text = "Công việc";
      // 
      // cmbCongViec
      // 
      this.cmbCongViec.FormattingEnabled = true;
      this.cmbCongViec.Location = new System.Drawing.Point(667, 214);
      this.cmbCongViec.Name = "cmbCongViec";
      this.cmbCongViec.Size = new System.Drawing.Size(176, 24);
      this.cmbCongViec.TabIndex = 16;
      // 
      // EmployeeControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.Controls.Add(this.cmbCongViec);
      this.Controls.Add(this.label8);
      this.Controls.Add(this.txtDiaChi);
      this.Controls.Add(this.label7);
      this.Controls.Add(this.label6);
      this.Controls.Add(this.dateNgaySinh);
      this.Controls.Add(this.label5);
      this.Controls.Add(this.cmbGioiTinh);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.mskSDT);
      this.Controls.Add(this.txtTenNhanVien);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.txtMaNhanVien);
      this.Controls.Add(this.dataGridViewEmployee);
      this.Controls.Add(this.panel1);
      this.Name = "EmployeeControl";
      this.Size = new System.Drawing.Size(972, 536);
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.DataGridView dataGridViewEmployee;
    private System.Windows.Forms.TextBox txtMaNhanVien;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.TextBox txtTenNhanVien;
    private System.Windows.Forms.MaskedTextBox mskSDT;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.ComboBox cmbGioiTinh;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.DateTimePicker dateNgaySinh;
    private System.Windows.Forms.Label label6;
    private System.Windows.Forms.Label label7;
    private System.Windows.Forms.TextBox txtDiaChi;
    private System.Windows.Forms.Label label8;
    private System.Windows.Forms.ComboBox cmbCongViec;
    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.TextBox txtSearch;
    private System.Windows.Forms.Button btnTim;
    private System.Windows.Forms.Label label9;
  }
}
