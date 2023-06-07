using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace regedit
{
	// Token: 0x02000004 RID: 4
	public partial class DangNhap : Form
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002096 File Offset: 0x00000296
		public DangNhap()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020A4 File Offset: 0x000002A4
		private void DangNhap_Load(object sender, EventArgs e)
		{
			this.txtTenDangNhap.Text = "Bkav";
			base.AcceptButton = this.btnDangNhap;
			this.checkBox1.Checked = true;
		}

		// Token: 0x06000009 RID: 9 RVA: 0x00002A54 File Offset: 0x00000C54
		private void btnDangNhap_Click(object sender, EventArgs e)
		{
			Bkav bkav = new Bkav();
			if (this.txtMatKhau.Text != "" && this.txtTenDangNhap.Text != "" && this.txtMatKhau.Text.Trim() == "nhatcntt" && this.txtTenDangNhap.Text.Trim() == "Bkav")
			{
				bkav.Show();
				base.Hide();
				return;
			}
			MessageBox.Show("Đăng nhập thất bại!! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			this.baoloi.SetError(this.txtMatKhau, "Sai mật khẩu");
		}

		// Token: 0x0600000A RID: 10 RVA: 0x000020CE File Offset: 0x000002CE
		private void btnThoat_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002B04 File Offset: 0x00000D04
		private void txtTenDangNhap_Validated(object sender, EventArgs e)
		{
			if (this.txtTenDangNhap.Text == "")
			{
				this.baoloi.SetError(this.txtTenDangNhap, "Bạn chưa nhập tên kìa!");
				return;
			}
			if (this.txtTenDangNhap.Text.Trim() == "Bkav")
			{
				this.baoloi.SetError(this.txtTenDangNhap, "");
				return;
			}
			this.baoloi.SetError(this.txtTenDangNhap, "Sai Tên đăng nhập");
		}

		// Token: 0x0600000C RID: 12 RVA: 0x00002B88 File Offset: 0x00000D88
		private void txtMatKhau_Validated(object sender, EventArgs e)
		{
			if (this.txtMatKhau.Text == "")
			{
				this.baoloi.SetError(this.txtMatKhau, "Bạn chưa nhập mật khẩu!");
				return;
			}
			this.baoloi.SetError(this.txtMatKhau, "");
		}
	}
}
