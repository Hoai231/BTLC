namespace BTL_C_.src.Views.Admin
{
  partial class FrmSeason
  {
    private System.ComponentModel.IContainer components = null;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblTenMua;
    private System.Windows.Forms.TextBox txtTenMua;
    private System.Windows.Forms.DataGridView dataGridViewMua;
    private System.Windows.Forms.Button btnXoa;
    private System.Windows.Forms.Button btnLuu;
    private System.Windows.Forms.Button btnThoat;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblTenMua = new System.Windows.Forms.Label();
      this.txtTenMua = new System.Windows.Forms.TextBox();
      this.dataGridViewMua = new System.Windows.Forms.DataGridView();
      this.btnXoa = new System.Windows.Forms.Button();
      this.btnLuu = new System.Windows.Forms.Button();
      this.btnThoat = new System.Windows.Forms.Button();
      this.btnLamMoi = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.txtMaMua = new System.Windows.Forms.TextBox();
      this.btnTao = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMua)).BeginInit();
      this.SuspendLayout();
      // 
      // lblTitle
      // 
      this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.Green;
      this.lblTitle.Location = new System.Drawing.Point(113, 23);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(400, 40);
      this.lblTitle.TabIndex = 0;
      this.lblTitle.Text = "DANH MỤC MÙA";
      this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblTenMua
      // 
      this.lblTenMua.AutoSize = true;
      this.lblTenMua.Location = new System.Drawing.Point(151, 116);
      this.lblTenMua.Name = "lblTenMua";
      this.lblTenMua.Size = new System.Drawing.Size(63, 16);
      this.lblTenMua.TabIndex = 2;
      this.lblTenMua.Text = "Tên Mùa:";
      // 
      // txtTenMua
      // 
      this.txtTenMua.Location = new System.Drawing.Point(262, 113);
      this.txtTenMua.Name = "txtTenMua";
      this.txtTenMua.Size = new System.Drawing.Size(180, 22);
      this.txtTenMua.TabIndex = 4;
      // 
      // dataGridViewMua
      // 
      this.dataGridViewMua.BackgroundColor = System.Drawing.SystemColors.ControlDark;
      this.dataGridViewMua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridViewMua.Location = new System.Drawing.Point(154, 173);
      this.dataGridViewMua.Name = "dataGridViewMua";
      this.dataGridViewMua.RowHeadersWidth = 51;
      this.dataGridViewMua.Size = new System.Drawing.Size(373, 130);
      this.dataGridViewMua.TabIndex = 5;
      // 
      // btnXoa
      // 
      this.btnXoa.Location = new System.Drawing.Point(152, 323);
      this.btnXoa.Name = "btnXoa";
      this.btnXoa.Size = new System.Drawing.Size(70, 30);
      this.btnXoa.TabIndex = 7;
      this.btnXoa.Text = "Xoá";
      this.btnXoa.UseVisualStyleBackColor = true;
      // 
      // btnLuu
      // 
      this.btnLuu.Location = new System.Drawing.Point(307, 323);
      this.btnLuu.Name = "btnLuu";
      this.btnLuu.Size = new System.Drawing.Size(70, 30);
      this.btnLuu.TabIndex = 9;
      this.btnLuu.Text = "Lưu";
      this.btnLuu.UseVisualStyleBackColor = true;
      // 
      // btnThoat
      // 
      this.btnThoat.Location = new System.Drawing.Point(457, 323);
      this.btnThoat.Name = "btnThoat";
      this.btnThoat.Size = new System.Drawing.Size(70, 30);
      this.btnThoat.TabIndex = 11;
      this.btnThoat.Text = "Thoát";
      this.btnThoat.UseVisualStyleBackColor = true;
      // 
      // btnLamMoi
      // 
      this.btnLamMoi.Location = new System.Drawing.Point(228, 323);
      this.btnLamMoi.Name = "btnLamMoi";
      this.btnLamMoi.Size = new System.Drawing.Size(73, 30);
      this.btnLamMoi.TabIndex = 12;
      this.btnLamMoi.Text = "Làm mới";
      this.btnLamMoi.UseVisualStyleBackColor = true;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(151, 87);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(55, 16);
      this.label1.TabIndex = 13;
      this.label1.Text = "Mã mùa";
      // 
      // txtMaMua
      // 
      this.txtMaMua.Location = new System.Drawing.Point(261, 84);
      this.txtMaMua.Name = "txtMaMua";
      this.txtMaMua.ReadOnly = true;
      this.txtMaMua.Size = new System.Drawing.Size(181, 22);
      this.txtMaMua.TabIndex = 14;
      // 
      // btnTao
      // 
      this.btnTao.Location = new System.Drawing.Point(383, 323);
      this.btnTao.Name = "btnTao";
      this.btnTao.Size = new System.Drawing.Size(68, 30);
      this.btnTao.TabIndex = 15;
      this.btnTao.Text = "Tạo";
      this.btnTao.UseVisualStyleBackColor = true;
      // 
      // FrmSeason
      // 
      this.ClientSize = new System.Drawing.Size(638, 380);
      this.Controls.Add(this.btnTao);
      this.Controls.Add(this.txtMaMua);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.btnLamMoi);
      this.Controls.Add(this.btnThoat);
      this.Controls.Add(this.btnLuu);
      this.Controls.Add(this.btnXoa);
      this.Controls.Add(this.dataGridViewMua);
      this.Controls.Add(this.txtTenMua);
      this.Controls.Add(this.lblTenMua);
      this.Controls.Add(this.lblTitle);
      this.Name = "FrmSeason";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Danh mục Mùa";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMua)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    private System.Windows.Forms.Button btnLamMoi;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.TextBox txtMaMua;
    private System.Windows.Forms.Button btnTao;
  }
}