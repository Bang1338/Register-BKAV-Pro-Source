namespace regedit
{
	// Token: 0x02000005 RID: 5
	public partial class Bkav : global::System.Windows.Forms.Form
	{
		// Token: 0x0600000D RID: 13 RVA: 0x000020D5 File Offset: 0x000002D5
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002BDC File Offset: 0x00000DDC
		private void InitializeComponent()
		{
			this.components = new global::System.ComponentModel.Container();
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::regedit.Bkav));
			this.button1 = new global::System.Windows.Forms.Button();
			this.lamlai = new global::System.Windows.Forms.Button();
			this.tbdiachi = new global::System.Windows.Forms.TextBox();
			this.tbten = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tbemail = new global::System.Windows.Forms.TextBox();
			this.tbdt = new global::System.Windows.Forms.TextBox();
			this.tbmaxn = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.groupBox1 = new global::System.Windows.Forms.GroupBox();
			this.lbdd = new global::System.Windows.Forms.Label();
			this.progressBar1 = new global::System.Windows.Forms.ProgressBar();
			this.groupBox3 = new global::System.Windows.Forms.GroupBox();
			this.richTextBox1 = new global::System.Windows.Forms.RichTextBox();
			this.checkBox1 = new global::System.Windows.Forms.CheckBox();
			this.m1 = new global::System.Windows.Forms.TextBox();
			this.lbtb = new global::System.Windows.Forms.Label();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.label7 = new global::System.Windows.Forms.Label();
			this.m3 = new global::System.Windows.Forms.TextBox();
			this.m2 = new global::System.Windows.Forms.TextBox();
			this.date_ngaydh = new global::System.Windows.Forms.DateTimePicker();
			this.label6 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.groupBox2 = new global::System.Windows.Forms.GroupBox();
			this.button3 = new global::System.Windows.Forms.Button();
			this.loi = new global::System.Windows.Forms.ErrorProvider(this.components);
			this.toolTip1 = new global::System.Windows.Forms.ToolTip(this.components);
			this.qltg = new global::System.Windows.Forms.Timer(this.components);
			this.timer1 = new global::System.Windows.Forms.Timer(this.components);
			this.groupBox1.SuspendLayout();
			this.groupBox3.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			this.groupBox2.SuspendLayout();
			((global::System.ComponentModel.ISupportInitialize)this.loi).BeginInit();
			base.SuspendLayout();
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.button1.ForeColor = global::System.Drawing.Color.Blue;
			this.button1.Location = new global::System.Drawing.Point(16, 16);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(124, 36);
			this.button1.TabIndex = 0;
			this.button1.Text = "Đăng Ký";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.lamlai.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.lamlai.ForeColor = global::System.Drawing.Color.Blue;
			this.lamlai.Location = new global::System.Drawing.Point(164, 16);
			this.lamlai.Name = "lamlai";
			this.lamlai.Size = new global::System.Drawing.Size(116, 36);
			this.lamlai.TabIndex = 5;
			this.lamlai.Text = "Làm lại";
			this.lamlai.UseVisualStyleBackColor = true;
			this.lamlai.Click += new global::System.EventHandler(this.lamlai_Click);
			this.tbdiachi.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f);
			this.tbdiachi.Location = new global::System.Drawing.Point(117, 72);
			this.tbdiachi.Multiline = true;
			this.tbdiachi.Name = "tbdiachi";
			this.tbdiachi.Size = new global::System.Drawing.Size(300, 29);
			this.tbdiachi.TabIndex = 2;
			this.tbdiachi.Validated += new global::System.EventHandler(this.tbdiachi_Validated);
			this.tbten.Location = new global::System.Drawing.Point(117, 30);
			this.tbten.Multiline = true;
			this.tbten.Name = "tbten";
			this.tbten.Size = new global::System.Drawing.Size(300, 27);
			this.tbten.TabIndex = 1;
			this.tbten.Validated += new global::System.EventHandler(this.tbten_Validated);
			this.tbten.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tbten_KeyPress);
			this.label2.AutoSize = true;
			this.label2.ForeColor = global::System.Drawing.Color.Blue;
			this.label2.Location = new global::System.Drawing.Point(16, 33);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(95, 17);
			this.label2.TabIndex = 4;
			this.label2.Text = "Tên Của Bạn:";
			this.label1.AutoSize = true;
			this.label1.ForeColor = global::System.Drawing.Color.Blue;
			this.label1.Location = new global::System.Drawing.Point(16, 84);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(59, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Địa chỉ :";
			this.tbemail.Location = new global::System.Drawing.Point(117, 169);
			this.tbemail.Multiline = true;
			this.tbemail.Name = "tbemail";
			this.tbemail.Size = new global::System.Drawing.Size(300, 31);
			this.tbemail.TabIndex = 7;
			this.tbemail.Validated += new global::System.EventHandler(this.tbemail_Validated);
			this.tbdt.Location = new global::System.Drawing.Point(117, 125);
			this.tbdt.Multiline = true;
			this.tbdt.Name = "tbdt";
			this.tbdt.Size = new global::System.Drawing.Size(300, 27);
			this.tbdt.TabIndex = 6;
			this.tbdt.Validated += new global::System.EventHandler(this.tbdt_Validated);
			this.tbdt.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.tbdt_KeyPress);
			this.tbmaxn.Location = new global::System.Drawing.Point(113, 280);
			this.tbmaxn.Multiline = true;
			this.tbmaxn.Name = "tbmaxn";
			this.tbmaxn.Size = new global::System.Drawing.Size(134, 30);
			this.tbmaxn.TabIndex = 8;
			this.tbmaxn.Validated += new global::System.EventHandler(this.tbmaxn_Validated);
			this.label3.AutoSize = true;
			this.label3.ForeColor = global::System.Drawing.Color.Blue;
			this.label3.Location = new global::System.Drawing.Point(16, 135);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(99, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "Số điện thoại :";
			this.label4.AutoSize = true;
			this.label4.ForeColor = global::System.Drawing.Color.Blue;
			this.label4.Location = new global::System.Drawing.Point(16, 169);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(98, 17);
			this.label4.TabIndex = 10;
			this.label4.Text = "Emai của bạn:";
			this.groupBox1.BackColor = global::System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.lbdd);
			this.groupBox1.Controls.Add(this.progressBar1);
			this.groupBox1.Controls.Add(this.groupBox3);
			this.groupBox1.Controls.Add(this.checkBox1);
			this.groupBox1.Controls.Add(this.m1);
			this.groupBox1.Controls.Add(this.lbtb);
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.label8);
			this.groupBox1.Controls.Add(this.label7);
			this.groupBox1.Controls.Add(this.m3);
			this.groupBox1.Controls.Add(this.m2);
			this.groupBox1.Controls.Add(this.date_ngaydh);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.pictureBox1);
			this.groupBox1.Controls.Add(this.label5);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.tbmaxn);
			this.groupBox1.Controls.Add(this.tbdt);
			this.groupBox1.Controls.Add(this.tbemail);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.tbten);
			this.groupBox1.Controls.Add(this.tbdiachi);
			this.groupBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f);
			this.groupBox1.ForeColor = global::System.Drawing.Color.Red;
			this.groupBox1.Location = new global::System.Drawing.Point(2, 2);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new global::System.Drawing.Size(445, 504);
			this.groupBox1.TabIndex = 8;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Đăng Ký Sử dụng Bkav Pro";
			this.lbdd.AutoSize = true;
			this.lbdd.Location = new global::System.Drawing.Point(211, 480);
			this.lbdd.Name = "lbdd";
			this.lbdd.Size = new global::System.Drawing.Size(0, 17);
			this.lbdd.TabIndex = 31;
			this.progressBar1.Location = new global::System.Drawing.Point(275, 452);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new global::System.Drawing.Size(157, 21);
			this.progressBar1.TabIndex = 29;
			this.groupBox3.BackColor = global::System.Drawing.Color.White;
			this.groupBox3.Controls.Add(this.richTextBox1);
			this.groupBox3.ForeColor = global::System.Drawing.Color.Red;
			this.groupBox3.Location = new global::System.Drawing.Point(6, 316);
			this.groupBox3.Name = "groupBox3";
			this.groupBox3.Size = new global::System.Drawing.Size(426, 130);
			this.groupBox3.TabIndex = 28;
			this.groupBox3.TabStop = false;
			this.groupBox3.Text = "Điều Khoản";
			this.richTextBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.richTextBox1.ForeColor = global::System.Drawing.Color.FromArgb(255, 128, 0);
			this.richTextBox1.Location = new global::System.Drawing.Point(4, 19);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new global::System.Drawing.Size(414, 105);
			this.richTextBox1.TabIndex = 27;
			this.richTextBox1.Text = componentResourceManager.GetString("richTextBox1.Text");
			this.checkBox1.AutoSize = true;
			this.checkBox1.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			this.checkBox1.Location = new global::System.Drawing.Point(19, 452);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new global::System.Drawing.Size(251, 21);
			this.checkBox1.TabIndex = 25;
			this.checkBox1.Text = "Tôi đồng ý với các điều khoản trên!!";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.m1.Location = new global::System.Drawing.Point(117, 209);
			this.m1.Name = "m1";
			this.m1.Size = new global::System.Drawing.Size(93, 23);
			this.m1.TabIndex = 22;
			this.m1.Validated += new global::System.EventHandler(this.m1_Validated_1);
			this.m1.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.m1_KeyPress);
			this.lbtb.AutoSize = true;
			this.lbtb.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f);
			this.lbtb.Location = new global::System.Drawing.Point(9, 479);
			this.lbtb.Name = "lbtb";
			this.lbtb.Size = new global::System.Drawing.Size(0, 18);
			this.lbtb.TabIndex = 21;
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.Blue;
			this.label9.Location = new global::System.Drawing.Point(309, 209);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(15, 20);
			this.label9.TabIndex = 20;
			this.label9.Text = "-";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.Blue;
			this.label8.Location = new global::System.Drawing.Point(210, 209);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(15, 20);
			this.label8.TabIndex = 19;
			this.label8.Text = "-";
			this.label7.AutoSize = true;
			this.label7.ForeColor = global::System.Drawing.Color.Blue;
			this.label7.Location = new global::System.Drawing.Point(18, 209);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(89, 17);
			this.label7.TabIndex = 18;
			this.label7.Text = "Mã đăng ký :";
			this.m3.Location = new global::System.Drawing.Point(324, 209);
			this.m3.Name = "m3";
			this.m3.Size = new global::System.Drawing.Size(93, 23);
			this.m3.TabIndex = 17;
			this.m3.Validated += new global::System.EventHandler(this.m3_Validated);
			this.m3.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.m3_KeyPress);
			this.m2.Location = new global::System.Drawing.Point(225, 209);
			this.m2.Name = "m2";
			this.m2.Size = new global::System.Drawing.Size(93, 23);
			this.m2.TabIndex = 16;
			this.m2.Validated += new global::System.EventHandler(this.m2_Validated);
			this.m2.KeyPress += new global::System.Windows.Forms.KeyPressEventHandler(this.m2_KeyPress);
			this.date_ngaydh.CustomFormat = "MM/dd/yyyy";
			this.date_ngaydh.Format = global::System.Windows.Forms.DateTimePickerFormat.Custom;
			this.date_ngaydh.Location = new global::System.Drawing.Point(117, 251);
			this.date_ngaydh.Name = "date_ngaydh";
			this.date_ngaydh.Size = new global::System.Drawing.Size(130, 23);
			this.date_ngaydh.TabIndex = 14;
			this.date_ngaydh.Value = new global::System.DateTime(2013, 1, 12, 0, 0, 0, 0);
			this.date_ngaydh.Validated += new global::System.EventHandler(this.date_ngaydh_Validated);
			this.label6.AutoSize = true;
			this.label6.ForeColor = global::System.Drawing.Color.Blue;
			this.label6.Location = new global::System.Drawing.Point(15, 251);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(97, 17);
			this.label6.TabIndex = 13;
			this.label6.Text = "Hạn sử dụng :";
			this.pictureBox1.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.BackgroundImage");
			this.pictureBox1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.pictureBox1.BorderStyle = global::System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox1.Location = new global::System.Drawing.Point(253, 268);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(164, 42);
			this.pictureBox1.TabIndex = 9;
			this.pictureBox1.TabStop = false;
			this.label5.AutoSize = true;
			this.label5.ForeColor = global::System.Drawing.Color.Blue;
			this.label5.Location = new global::System.Drawing.Point(11, 291);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(96, 17);
			this.label5.TabIndex = 11;
			this.label5.Text = "Mã xác nhập :";
			this.groupBox2.BackColor = global::System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.button1);
			this.groupBox2.Controls.Add(this.button3);
			this.groupBox2.Controls.Add(this.lamlai);
			this.groupBox2.Location = new global::System.Drawing.Point(2, 506);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new global::System.Drawing.Size(445, 61);
			this.groupBox2.TabIndex = 9;
			this.groupBox2.TabStop = false;
			this.button3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f);
			this.button3.ForeColor = global::System.Drawing.Color.Blue;
			this.button3.Location = new global::System.Drawing.Point(308, 15);
			this.button3.Name = "button3";
			this.button3.Size = new global::System.Drawing.Size(124, 36);
			this.button3.TabIndex = 7;
			this.button3.Text = "Thoát";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new global::System.EventHandler(this.button3_Click);
			this.loi.ContainerControl = this;
			this.toolTip1.ToolTipTitle = "Vui lòng nhập vào thông tin!";
			this.qltg.Interval = 1000;
			this.qltg.Tick += new global::System.EventHandler(this.qltg_Tick);
			this.timer1.Interval = 1000;
			this.timer1.Tick += new global::System.EventHandler(this.timer1_Tick);
			base.AcceptButton = this.button1;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = (global::System.Drawing.Image)componentResourceManager.GetObject("$this.BackgroundImage");
			base.ClientSize = new global::System.Drawing.Size(449, 569);
			base.Controls.Add(this.groupBox2);
			base.Controls.Add(this.groupBox1);
			this.ForeColor = global::System.Drawing.Color.FromArgb(0, 0, 192);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.Fixed3D;
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Bkav";
			this.Text = "Đăng ký bản quyền  cho Bkav Pro 2012";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox3.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			this.groupBox2.ResumeLayout(false);
			((global::System.ComponentModel.ISupportInitialize)this.loi).EndInit();
			base.ResumeLayout(false);
		}

		// Token: 0x0400000F RID: 15
		private global::System.ComponentModel.IContainer components;

		// Token: 0x04000010 RID: 16
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000011 RID: 17
		private global::System.Windows.Forms.Button lamlai;

		// Token: 0x04000012 RID: 18
		private global::System.Windows.Forms.TextBox tbdiachi;

		// Token: 0x04000013 RID: 19
		private global::System.Windows.Forms.TextBox tbten;

		// Token: 0x04000014 RID: 20
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000015 RID: 21
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000016 RID: 22
		private global::System.Windows.Forms.TextBox tbemail;

		// Token: 0x04000017 RID: 23
		private global::System.Windows.Forms.TextBox tbdt;

		// Token: 0x04000018 RID: 24
		private global::System.Windows.Forms.TextBox tbmaxn;

		// Token: 0x04000019 RID: 25
		private global::System.Windows.Forms.Label label3;

		// Token: 0x0400001A RID: 26
		private global::System.Windows.Forms.Label label4;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.GroupBox groupBox1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.Label label5;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.GroupBox groupBox2;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ErrorProvider loi;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.DateTimePicker date_ngaydh;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.TextBox m3;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.TextBox m2;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.Label lbtb;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.ToolTip toolTip1;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.TextBox m1;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.CheckBox checkBox1;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.RichTextBox richTextBox1;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.GroupBox groupBox3;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.ProgressBar progressBar1;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.Timer qltg;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Timer timer1;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Button button3;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.Label lbdd;
	}
}
