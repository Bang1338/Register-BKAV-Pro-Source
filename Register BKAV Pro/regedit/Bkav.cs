using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Microsoft.Win32;

namespace regedit
{
	// Token: 0x02000005 RID: 5
	public partial class Bkav : Form
	{
		// Token: 0x0600000F RID: 15 RVA: 0x000020F4 File Offset: 0x000002F4
		public Bkav()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00004090 File Offset: 0x00002290
		private void thoigian()
		{
			this.timer1.Enabled = true;
			this.progressBar1.Maximum = this.n;
			if (this.i < this.n)
			{
				this.i++;
				int num = this.i * 10;
				this.lbdd.Text = num.ToString() + " %";
				this.lbtb.Text = "Vui lòng chờ vài giây : ";
				this.progressBar1.Value = this.i;
				return;
			}
			this.timer1.Enabled = false;
			MessageBox.Show("Nếu là lần đầu tiên đăng ký thì bạn chờ vài giây '15s' ngoài Bkav sẽ báo bản quyền không đúng!Nếu có bạn chọn Đồng Ý là được!Nếu không thì thôi.", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.qltg.Enabled = true;
		}

		// Token: 0x06000011 RID: 17 RVA: 0x0000414C File Offset: 0x0000234C
		private void thoigian2()
		{
			this.progressBar1.Maximum = this.tg;
			if (this.j > 0)
			{
				this.j--;
				this.lbdd.Text = this.j.ToString() + " S Còn lại";
				this.lbtb.Text = "Vui lòng chờ xử lý: ";
				this.progressBar1.Value = this.j;
				return;
			}
			this.qltg.Enabled = false;
			this.dangkybangquyen();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000041D8 File Offset: 0x000023D8
		private void nhatcntt()
		{
			string fileName = "http://www.nhatcntt.forumvi.com";
			Process process = new Process();
			ProcessStartInfo startInfo = new ProcessStartInfo(fileName);
			process.StartInfo = startInfo;
			process.Start();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00004208 File Offset: 0x00002408
		private void lammoi()
		{
			this.lamlai.Enabled = true;
			this.tbdiachi.Clear();
			this.tbdt.Clear();
			this.tbemail.Clear();
			this.tbmaxn.Clear();
			this.tbten.Clear();
			this.m1.Clear();
			this.m2.Clear();
			this.m3.Clear();
			this.qltg.Enabled = false;
			this.progressBar1.Value = 0;
			this.checkBox1.Checked = false;
			this.lbtb.Text = "";
			this.lbdd.Text = "";
		}

		// Token: 0x06000014 RID: 20 RVA: 0x000042C0 File Offset: 0x000024C0
		private void xuat()
		{
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Bkav");
			registryKey.SetValue("nhatcntt", "NHATCNTT.FORUMVI.COM Forum On Information Technology!");
			registryKey.Close();
			this.kn.WriteRegKey("szCustomerName", "testbkav");
			this.kn.WriteRegKey("szCustomerEmail", "bkav@gmail.com");
			this.kn.WriteRegKey("szCustomerPhone", "123456789");
			this.kn.WriteRegKey("szCustomerAddress", "bkav.com");
			this.kn.WriteRegKey("szExpireDate", "1/1/2013");
			this.kn.WriteRegKey("szCardNumber", "1111-2222-3333");
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Bkav", "fTuDongDownload", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Bkav", "fTuDongKiemTraPhienBanMoi", 0);
			this.thoigian();
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000043A8 File Offset: 0x000025A8
		private void dangkybangquyen()
		{
			this.kn.WriteRegKey("szCustomerName", this.tbten.Text.ToString().Trim());
			this.kn.WriteRegKey("szCustomerEmail", this.tbemail.Text.ToString().Trim());
			this.kn.WriteRegKey("szCustomerPhone", this.tbdt.Text.ToString().Trim());
			this.kn.WriteRegKey("szCustomerAddress", this.tbdiachi.Text.ToString().Trim());
			this.kn.WriteRegKey("szExpireDate", this.date_ngaydh.Text);
			this.kn.WriteRegKey("szCardNumber", string.Concat(new string[]
			{
				this.m1.Text.ToString().Trim(),
				"-",
				this.m2.Text.ToString().Trim(),
				"-",
				this.m3.Text.ToString().Trim()
			}));
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Bkav", "fTuDongDownload", 0);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\Software\\Bkav", "fTuDongKiemTraPhienBanMoi", 0);
			MessageBox.Show("Chúc mừng bạn đã đăng ký thành công !", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
			this.lammoi();
			this.nhatcntt();
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00004528 File Offset: 0x00002728
		private void thuchien()
		{
			if (!(this.tbdiachi.Text != "") || !(this.tbdt.Text != "") || !(this.tbemail.Text != "") || !(this.tbmaxn.Text != "") || !(this.tbten.Text != "") || !(this.m1.Text != "") || !(this.m2.Text != "") || !(this.m3.Text != ""))
			{
				MessageBox.Show("Bạn vui lòng điền đầy đủ thông tin trên! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.lbtb.Text = "Thông Báo : Bạn vui lòng nhập đầy đủ thông tin trên";
				return;
			}
			if (this.checkBox1.Checked)
			{
				if (this.dk != 1)
				{
					this.xuat();
					this.lamlai.Enabled = false;
					return;
				}
			}
			if (this.dk == 1)
			{
				MessageBox.Show("Địa chỉ Email không hợp lại!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
				this.lbtb.Text = "Thông Báo : Email không hợp lệ!!";
				return;
			}
			MessageBox.Show("Bạn chưa đồng ý với các điều khoản trên!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			this.lbtb.Text = "Thông Báo : Bạn vui lòng check vào ô đồng ý các điều khoản trên !!";
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000046A4 File Offset: 0x000028A4
		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				this.thuchien();
			}
			catch
			{
				MessageBox.Show("Đăng Ký Không Thành Công .Đã Có Lỗi Xảy ra! Xin vui lòng kiểm tra lại bạn chưa tắt tính năng bảo vệ hệ thống Bkav đó ! Hoặc bạn chưa tắt tính năng bảo vệ của Windows đó nếu chưa tắ thì bạn hãy tắt đi! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x000046E0 File Offset: 0x000028E0
		private void tbten_Validated(object sender, EventArgs e)
		{
			if (this.tbten.Text == "")
			{
				this.loi.SetError(this.tbten, "Bạn chưa nhập tên kìa!");
				return;
			}
			this.loi.SetError(this.tbten, "");
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00004734 File Offset: 0x00002934
		private void tbdiachi_Validated(object sender, EventArgs e)
		{
			if (this.tbdiachi.Text == "")
			{
				this.loi.SetError(this.tbdiachi, "Bạn chưa nhập địa chỉ kìa!");
				return;
			}
			this.loi.SetError(this.tbdiachi, "");
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00004788 File Offset: 0x00002988
		private void tbdt_Validated(object sender, EventArgs e)
		{
			if (this.tbdt.Text == "")
			{
				this.loi.SetError(this.tbdt, "Bạn chưa nhập số điện thoại!");
				this.toolTip1.ToolTipTitle.ToString();
				return;
			}
			this.loi.SetError(this.tbdt, "");
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000047EC File Offset: 0x000029EC
		private void tbemail_Validated(object sender, EventArgs e)
		{
			Regex regex = new Regex(this.match);
			if (this.tbemail.Text == "")
			{
				this.loi.SetError(this.tbemail, "Bạn chưa nhập email");
				return;
			}
			if (!regex.IsMatch(this.tbemail.Text))
			{
				this.loi.SetError(this.tbemail, "Email khong hop le. Vui long kiem tra lai");
				this.dk = 1;
				return;
			}
			this.dk = 0;
			this.loi.SetError(this.tbemail, "");
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00004884 File Offset: 0x00002A84
		private void tbmaxn_Validated(object sender, EventArgs e)
		{
			if (this.tbmaxn.Text == "")
			{
				this.loi.SetError(this.tbmaxn, "Bạn chưa nhập mã bảo vệ!");
				return;
			}
			if (this.tbmaxn.Text != "" && this.tbmaxn.Text == "nhatcntt")
			{
				this.loi.SetError(this.tbmaxn, "");
				return;
			}
			this.loi.SetError(this.tbmaxn, "Vui lòng nhập lại!");
			MessageBox.Show("Bạn nhập sai mã bảo vệ", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x0000212E File Offset: 0x0000032E
		private void date_ngaydh_Validated(object sender, EventArgs e)
		{
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00004930 File Offset: 0x00002B30
		private void m2_Validated(object sender, EventArgs e)
		{
			if (this.m2.Text == "")
			{
				this.loi.SetError(this.m2, "Chưa nhập Key");
				return;
			}
			if (this.m2.Text != "" && this.m2.Text.Trim().Length == 4)
			{
				this.m3.Focus();
			}
			this.loi.SetError(this.m2, "");
		}

		// Token: 0x0600001F RID: 31 RVA: 0x000049BC File Offset: 0x00002BBC
		private void m1_Validated_1(object sender, EventArgs e)
		{
			if (this.m1.Text == "")
			{
				this.loi.SetError(this.m1, "Chưa nhập Key");
				return;
			}
			if (this.m1.Text != "" && this.m1.Text.Trim().Length == 4)
			{
				this.m2.Focus();
			}
			this.loi.SetError(this.m1, "");
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00004A48 File Offset: 0x00002C48
		private void tbdt_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
			if (this.tbdt.Text.Trim().Length <= 0 || this.tbdt.Text.Trim().Length > 10)
			{
				this.loi.SetError(this.tbdt, "Đây không phải là số điện thoại");
			}
			if (this.tbdt.Text.Trim().Length == 10)
			{
				this.tbemail.Focus();
			}
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00004AE4 File Offset: 0x00002CE4
		private void m1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (this.m1.Text.Trim().Length == 3)
			{
				this.m2.Focus();
			}
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00004B38 File Offset: 0x00002D38
		private void m2_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
			if (this.m2.Text.Trim().Length == 3)
			{
				this.m3.Focus();
			}
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00004B8C File Offset: 0x00002D8C
		private void m3_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
			{
				e.Handled = true;
			}
			if (this.m3.Text.Trim().Length == 3)
			{
				this.tbmaxn.Focus();
			}
		}

		// Token: 0x06000024 RID: 36 RVA: 0x0000212E File Offset: 0x0000032E
		private void sideBar1_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000025 RID: 37 RVA: 0x0000212E File Offset: 0x0000032E
		private void tbten_KeyPress(object sender, KeyPressEventArgs e)
		{
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00004BE0 File Offset: 0x00002DE0
		private void m3_Validated(object sender, EventArgs e)
		{
			if (this.m3.Text == "")
			{
				this.loi.SetError(this.m3, "Chưa nhập Key");
				return;
			}
			if (this.m3.Text != "" && this.m3.Text.Trim().Length == 4)
			{
				this.tbmaxn.Focus();
			}
			this.loi.SetError(this.m3, "");
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00002130 File Offset: 0x00000330
		private void qltg_Tick(object sender, EventArgs e)
		{
			this.thoigian2();
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002138 File Offset: 0x00000338
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.thoigian();
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00002140 File Offset: 0x00000340
		private void button3_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có chắc là muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				Application.Exit();
			}
		}

		// Token: 0x0600002A RID: 42 RVA: 0x0000215C File Offset: 0x0000035C
		private void lamlai_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Bạn có muốn hủy bỏ làm lại ha?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
			{
				this.lammoi();
			}
		}

		// Token: 0x04000032 RID: 50
		private dkbkav kn = new dkbkav();

		// Token: 0x04000033 RID: 51
		private int dk;

		// Token: 0x04000034 RID: 52
		private int i;

		// Token: 0x04000035 RID: 53
		private int n = 10;

		// Token: 0x04000036 RID: 54
		private int j = 5;

		// Token: 0x04000037 RID: 55
		private int tg = 5;

		// Token: 0x04000038 RID: 56
		private string match = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
	}
}
