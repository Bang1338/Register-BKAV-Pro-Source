namespace regedit
{
	// Token: 0x02000004 RID: 4
	public partial class DangNhap : global::System.Windows.Forms.Form
	{
		// Token: 0x06000005 RID: 5 RVA: 0x00002077 File Offset: 0x00000277
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000021E0 File Offset: 0x000003E0
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::regedit.DangNhap));
			this.btnThoat = new global::System.Windows.Forms.Button();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.txtMatKhau = new global::System.Windows.Forms.TextBox();
			this.txtTenDangNhap = new global::System.Windows.Forms.TextBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.btnDangNhap = new global::System.Windows.Forms.Button();
			this.baoloi = new global::System.Windows.Forms.ErrorProvider(this.components);
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.groupBox1.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.baoloi).BeginInit();
			this.groupBox2.SuspendLayout();
			base.SuspendLayout();
			this.btnThoat.BackColor = global::System.Drawing.Color.FromArgb(192, 192, 255);
			this.btnThoat.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("btnThoat.BackgroundImage");
			this.btnThoat.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnThoat.ForeColor = global::System.Drawing.Color.White;
			this.btnThoat.Location = new global::System.Drawing.Point(190, 11);
			this.btnThoat.Name = "btnThoat";
			this.btnThoat.Size = new global::System.Drawing.Size(88, 35);
			this.btnThoat.TabIndex = 11;
			this.btnThoat.Text = "Thoát";
			this.btnThoat.UseVisualStyleBackColor = false;
			this.btnThoat.Click += new global::System.EventHandler(this.btnThoat_Click);
			this.groupBox1.AutoSizeMode = global::System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.groupBox1.BackColor = global::System.Drawing.Color.FromArgb(192, 255, 255);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.txtMatKhau);
			this.groupBox1.Controls.Add(this.txtTenDangNhap);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Blue;
			this.groupBox1.Location = new global::System.Drawing.Point(9, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(313, 185);
			this.groupBox1.TabIndex = 10;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Login";
			this.label3.BackColor = global::System.Drawing.Color.Transparent;
			this.label3.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label3.Font = new global::System.Drawing.Font("Arial", 15f, global::System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = global::System.Drawing.Color.MediumBlue;
			this.label3.Location = new global::System.Drawing.Point(46, 21);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(213, 35);
			this.label3.TabIndex = 15;
			this.label3.Text = "Bảng Đăng Nhập";
			this.txtMatKhau.Location = new global::System.Drawing.Point(112, 99);
			this.txtMatKhau.Multiline = true;
			this.txtMatKhau.Name = "txtMatKhau";
			this.txtMatKhau.PasswordChar = '*';
			this.txtMatKhau.Size = new global::System.Drawing.Size(166, 31);
			this.txtMatKhau.TabIndex = 1;
			this.txtMatKhau.Validated += new global::System.EventHandler(this.txtMatKhau_Validated);
			this.txtTenDangNhap.Location = new global::System.Drawing.Point(112, 57);
			this.txtTenDangNhap.Multiline = true;
			this.txtTenDangNhap.Name = "txtTenDangNhap";
			this.txtTenDangNhap.Size = new global::System.Drawing.Size(166, 32);
			this.txtTenDangNhap.TabIndex = 0;
			this.txtTenDangNhap.Validated += new global::System.EventHandler(this.txtTenDangNhap_Validated);
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new global::System.Drawing.Font("Times New Roman", 12f, global::System.Drawing.FontStyle.Italic);
			this.baoloi.SetIconAlignment(this.checkBox1, global::System.Windows.Forms.ErrorIconAlignment.BottomLeft);
			this.checkBox1.Location = new global::System.Drawing.Point(28, 136);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(150, 23);
			this.checkBox1.TabIndex = 6;
			this.checkBox1.Text = "Lưu tên đăng nhập";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.label2.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Red;
			this.label2.Location = new global::System.Drawing.Point(25, 103);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(81, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Mật Khẩu :";
			this.label1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.label1.Font = new global::System.Drawing.Font("Arial", 9.75f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Red;
			this.label1.Location = new global::System.Drawing.Point(25, 61);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(81, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "Tài Khoản:";
			this.btnDangNhap.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("btnDangNhap.BackgroundImage");
			this.btnDangNhap.Font = new global::System.Drawing.Font("Arial", 9f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.btnDangNhap.ForeColor = global::System.Drawing.Color.Transparent;
			this.btnDangNhap.Location = new global::System.Drawing.Point(40, 12);
			this.btnDangNhap.Name = "btnDangNhap";
			this.btnDangNhap.Size = new global::System.Drawing.Size(91, 35);
			this.btnDangNhap.TabIndex = 12;
			this.btnDangNhap.Text = "Đăng Nhập";
			this.btnDangNhap.UseVisualStyleBackColor = true;
			this.btnDangNhap.Click += new global::System.EventHandler(this.btnDangNhap_Click);
			this.baoloi.ContainerControl = this;
			this.groupBox2.BackColor = global::System.Drawing.Color.Ivory;
			this.groupBox2.Controls.Add(this.btnThoat);
			this.groupBox2.Controls.Add(this.btnDangNhap);
			this.groupBox2.Location = new global::System.Drawing.Point(9, 182);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(313, 53);
			this.groupBox2.TabIndex = 14;
			this.groupBox2.TabStop = false;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(9f, 18f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			base.ClientSize = new global::System.Drawing.Size(328, 240);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			this.Font = new global::System.Drawing.Font("Monotype Corsiva", 12f, global::System.Drawing.FontStyle.Bold | global::System.Drawing.FontStyle.Italic, global::System.Drawing.GraphicsUnit.Point, 0);
			this.ForeColor = global::System.Drawing.Color.Blue;
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.Name = "DangNhap";
			this.Text = "Bảng Đăng Nhập";
			base.Load += new global::System.EventHandler(this.DangNhap_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((global::System.ComponentModel.ISupportInitialize)this.baoloi).EndInit();
			this.groupBox2.ResumeLayout(false);
			base.ResumeLayout(false);
		}

		// Token: 0x04000003 RID: 3
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000004 RID: 4
		private global::System.Windows.Forms.Button btnThoat;

		// Token: 0x04000005 RID: 5
		private global::System.Windows.Forms.TextBox txtTenDangNhap;

		// Token: 0x04000006 RID: 6
		private global::System.Windows.Forms.TextBox txtMatKhau;

		// Token: 0x04000007 RID: 7
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000008 RID: 8
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000009 RID: 9
		private global::System.Windows.Forms.Button btnDangNhap;

		// Token: 0x0400000A RID: 10
		private global::System.Windows.Forms.ErrorProvider baoloi;

		// Token: 0x0400000B RID: 11
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400000C RID: 12
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400000D RID: 13
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400000E RID: 14
		private global::System.Windows.Forms.GroupBox groupBox1;
	}
}
