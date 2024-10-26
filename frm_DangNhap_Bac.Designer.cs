namespace WindowsFormsApp1
{
	partial class frm_DangNhap_Bac
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_DangNhap_Bac));
			this.btn_RandomMa_Bac = new System.Windows.Forms.Button();
			this.txt_HienThiMaBV_Bac = new System.Windows.Forms.TextBox();
			this.btn_DangNhap_Bac = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_TenDangNhap_Bac = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_MatKhau_Bac = new Guna.UI2.WinForms.Guna2TextBox();
			this.txt_MaBaoVe_Bac = new Guna.UI2.WinForms.Guna2TextBox();
			this.lb_DangNhap_Bac = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btn_RandomMa_Bac
			// 
			this.btn_RandomMa_Bac.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_RandomMa_Bac.BackgroundImage")));
			this.btn_RandomMa_Bac.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btn_RandomMa_Bac.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_RandomMa_Bac.Location = new System.Drawing.Point(258, 276);
			this.btn_RandomMa_Bac.Name = "btn_RandomMa_Bac";
			this.btn_RandomMa_Bac.Size = new System.Drawing.Size(48, 49);
			this.btn_RandomMa_Bac.TabIndex = 4;
			this.btn_RandomMa_Bac.UseVisualStyleBackColor = true;
			this.btn_RandomMa_Bac.Click += new System.EventHandler(this.btn_RandomMa_Bac_Click);
			// 
			// txt_HienThiMaBV_Bac
			// 
			this.txt_HienThiMaBV_Bac.Enabled = false;
			this.txt_HienThiMaBV_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_HienThiMaBV_Bac.Location = new System.Drawing.Point(320, 278);
			this.txt_HienThiMaBV_Bac.Name = "txt_HienThiMaBV_Bac";
			this.txt_HienThiMaBV_Bac.Size = new System.Drawing.Size(125, 44);
			this.txt_HienThiMaBV_Bac.TabIndex = 7;
			// 
			// btn_DangNhap_Bac
			// 
			this.btn_DangNhap_Bac.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btn_DangNhap_Bac.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DangNhap_Bac.Location = new System.Drawing.Point(153, 393);
			this.btn_DangNhap_Bac.Name = "btn_DangNhap_Bac";
			this.btn_DangNhap_Bac.Size = new System.Drawing.Size(271, 67);
			this.btn_DangNhap_Bac.TabIndex = 3;
			this.btn_DangNhap_Bac.Text = "ĐĂNG NHẬP";
			this.btn_DangNhap_Bac.UseVisualStyleBackColor = true;
			this.btn_DangNhap_Bac.Click += new System.EventHandler(this.btn_DangNhap_Bac_Click);
			// 
			// label2
			// 
			this.label2.BackColor = System.Drawing.Color.DodgerBlue;
			this.label2.Dock = System.Windows.Forms.DockStyle.Top;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
			this.label2.Location = new System.Drawing.Point(0, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(575, 82);
			this.label2.TabIndex = 9;
			this.label2.Text = "Đăng nhập hệ thống";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// txt_TenDangNhap_Bac
			// 
			this.txt_TenDangNhap_Bac.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_TenDangNhap_Bac.DefaultText = "";
			this.txt_TenDangNhap_Bac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_TenDangNhap_Bac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_TenDangNhap_Bac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenDangNhap_Bac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_TenDangNhap_Bac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenDangNhap_Bac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenDangNhap_Bac.ForeColor = System.Drawing.Color.Black;
			this.txt_TenDangNhap_Bac.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_TenDangNhap_Bac.Location = new System.Drawing.Point(93, 119);
			this.txt_TenDangNhap_Bac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_TenDangNhap_Bac.Name = "txt_TenDangNhap_Bac";
			this.txt_TenDangNhap_Bac.PasswordChar = '\0';
			this.txt_TenDangNhap_Bac.PlaceholderText = "Nhập tên đăng nhập";
			this.txt_TenDangNhap_Bac.SelectedText = "";
			this.txt_TenDangNhap_Bac.Size = new System.Drawing.Size(382, 60);
			this.txt_TenDangNhap_Bac.TabIndex = 0;
			// 
			// txt_MatKhau_Bac
			// 
			this.txt_MatKhau_Bac.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MatKhau_Bac.DefaultText = "";
			this.txt_MatKhau_Bac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MatKhau_Bac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MatKhau_Bac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MatKhau_Bac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MatKhau_Bac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MatKhau_Bac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_MatKhau_Bac.ForeColor = System.Drawing.Color.Black;
			this.txt_MatKhau_Bac.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MatKhau_Bac.Location = new System.Drawing.Point(93, 198);
			this.txt_MatKhau_Bac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_MatKhau_Bac.Name = "txt_MatKhau_Bac";
			this.txt_MatKhau_Bac.PasswordChar = '●';
			this.txt_MatKhau_Bac.PlaceholderText = "Nhập mật khẩu";
			this.txt_MatKhau_Bac.SelectedText = "";
			this.txt_MatKhau_Bac.Size = new System.Drawing.Size(382, 60);
			this.txt_MatKhau_Bac.TabIndex = 1;
			this.txt_MatKhau_Bac.UseSystemPasswordChar = true;
			// 
			// txt_MaBaoVe_Bac
			// 
			this.txt_MaBaoVe_Bac.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txt_MaBaoVe_Bac.DefaultText = "";
			this.txt_MaBaoVe_Bac.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txt_MaBaoVe_Bac.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txt_MaBaoVe_Bac.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaBaoVe_Bac.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txt_MaBaoVe_Bac.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaBaoVe_Bac.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txt_MaBaoVe_Bac.ForeColor = System.Drawing.Color.Black;
			this.txt_MaBaoVe_Bac.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txt_MaBaoVe_Bac.Location = new System.Drawing.Point(121, 277);
			this.txt_MaBaoVe_Bac.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.txt_MaBaoVe_Bac.Name = "txt_MaBaoVe_Bac";
			this.txt_MaBaoVe_Bac.PasswordChar = '\0';
			this.txt_MaBaoVe_Bac.PlaceholderText = "Nhập mã";
			this.txt_MaBaoVe_Bac.SelectedText = "";
			this.txt_MaBaoVe_Bac.Size = new System.Drawing.Size(124, 48);
			this.txt_MaBaoVe_Bac.TabIndex = 2;
			// 
			// lb_DangNhap_Bac
			// 
			this.lb_DangNhap_Bac.AutoSize = true;
			this.lb_DangNhap_Bac.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_DangNhap_Bac.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
			this.lb_DangNhap_Bac.Location = new System.Drawing.Point(87, 340);
			this.lb_DangNhap_Bac.Name = "lb_DangNhap_Bac";
			this.lb_DangNhap_Bac.Size = new System.Drawing.Size(403, 32);
			this.lb_DangNhap_Bac.TabIndex = 10;
			this.lb_DangNhap_Bac.Text = "Thông tin đăng nhập sẽ hiện ở đây";
			// 
			// frm_DangNhap_Bac
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(575, 513);
			this.Controls.Add(this.lb_DangNhap_Bac);
			this.Controls.Add(this.txt_MaBaoVe_Bac);
			this.Controls.Add(this.txt_MatKhau_Bac);
			this.Controls.Add(this.txt_TenDangNhap_Bac);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.btn_DangNhap_Bac);
			this.Controls.Add(this.txt_HienThiMaBV_Bac);
			this.Controls.Add(this.btn_RandomMa_Bac);
			this.Name = "frm_DangNhap_Bac";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "----- ĐĂNG NHẬP HỆ THỐNG -----";
			this.Load += new System.EventHandler(this.frm_DangNhap_Bac_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_RandomMa_Bac;
		private System.Windows.Forms.TextBox txt_HienThiMaBV_Bac;
		private System.Windows.Forms.Button btn_DangNhap_Bac;
		private System.Windows.Forms.Label label2;
		private Guna.UI2.WinForms.Guna2TextBox txt_TenDangNhap_Bac;
		private Guna.UI2.WinForms.Guna2TextBox txt_MatKhau_Bac;
		private Guna.UI2.WinForms.Guna2TextBox txt_MaBaoVe_Bac;
		private System.Windows.Forms.Label lb_DangNhap_Bac;
	}
}