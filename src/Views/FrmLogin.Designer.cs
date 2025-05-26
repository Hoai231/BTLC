namespace BTL_C_.src.Views
{
  partial class FrmLogin
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

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.txtEmail = new System.Windows.Forms.TextBox();
      this.txtMatKhau = new System.Windows.Forms.TextBox();
      this.btnDangNhap = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 16F);
      this.label1.Location = new System.Drawing.Point(300, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(262, 37);
      this.label1.TabIndex = 0;
      this.label1.Text = "Đăng nhập hệ thống";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(200, 100);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(44, 16);
      this.label2.TabIndex = 1;
      this.label2.Text = "Email:";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(200, 150);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(64, 16);
      this.label3.TabIndex = 2;
      this.label3.Text = "Mật khẩu:";
      // 
      // txtEmail
      // 
      this.txtEmail.Location = new System.Drawing.Point(300, 100);
      this.txtEmail.Name = "txtEmail";
      this.txtEmail.Size = new System.Drawing.Size(200, 22);
      this.txtEmail.TabIndex = 3;
      // 
      // txtMatKhau
      // 
      this.txtMatKhau.Location = new System.Drawing.Point(300, 150);
      this.txtMatKhau.Name = "txtMatKhau";
      this.txtMatKhau.PasswordChar = '*';
      this.txtMatKhau.Size = new System.Drawing.Size(200, 22);
      this.txtMatKhau.TabIndex = 4;
      // 
      // btnDangNhap
      // 
      this.btnDangNhap.Location = new System.Drawing.Point(350, 204);
      this.btnDangNhap.Name = "btnDangNhap";
      this.btnDangNhap.Size = new System.Drawing.Size(100, 30);
      this.btnDangNhap.TabIndex = 5;
      this.btnDangNhap.Text = "Đăng nhập";
      // 
      // LoginForm
      // 
      this.ClientSize = new System.Drawing.Size(800, 300);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.txtEmail);
      this.Controls.Add(this.txtMatKhau);
      this.Controls.Add(this.btnDangNhap);
      this.Name = "LoginForm";
      this.Text = "Đăng nhập";
      this.Load += new System.EventHandler(this.LoginForm_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtMatKhau;
    private System.Windows.Forms.Button btnDangNhap;
  }
}