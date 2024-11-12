namespace Nhom2_QuanLySinhVien.QuanLyMonHoc
{
	partial class frm_SuaMonHoc_Bac
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
			this.components = new System.ComponentModel.Container();
			this.btn_SuaMonHoc_Bac = new System.Windows.Forms.Button();
			this.gp_ThongTinMonHoc_Bac = new System.Windows.Forms.GroupBox();
			this.cbo_MaMH_Bac = new System.Windows.Forms.ComboBox();
			this.txt_TenMH_Bac = new System.Windows.Forms.TextBox();
			this.txt_SoTC_Bac = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.monHocBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.gp_ThongTinMonHoc_Bac.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_SuaMonHoc_Bac
			// 
			this.btn_SuaMonHoc_Bac.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_SuaMonHoc_Bac.Location = new System.Drawing.Point(175, 257);
			this.btn_SuaMonHoc_Bac.Name = "btn_SuaMonHoc_Bac";
			this.btn_SuaMonHoc_Bac.Size = new System.Drawing.Size(275, 54);
			this.btn_SuaMonHoc_Bac.TabIndex = 6;
			this.btn_SuaMonHoc_Bac.Text = "Lưu thông tin";
			this.btn_SuaMonHoc_Bac.UseVisualStyleBackColor = true;
			this.btn_SuaMonHoc_Bac.Click += new System.EventHandler(this.btn_SuaMonHoc_Bac_Click);
			// 
			// gp_ThongTinMonHoc_Bac
			// 
			this.gp_ThongTinMonHoc_Bac.Controls.Add(this.cbo_MaMH_Bac);
			this.gp_ThongTinMonHoc_Bac.Controls.Add(this.txt_TenMH_Bac);
			this.gp_ThongTinMonHoc_Bac.Controls.Add(this.txt_SoTC_Bac);
			this.gp_ThongTinMonHoc_Bac.Controls.Add(this.label1);
			this.gp_ThongTinMonHoc_Bac.Controls.Add(this.label3);
			this.gp_ThongTinMonHoc_Bac.Controls.Add(this.label2);
			this.gp_ThongTinMonHoc_Bac.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gp_ThongTinMonHoc_Bac.Location = new System.Drawing.Point(48, 21);
			this.gp_ThongTinMonHoc_Bac.Name = "gp_ThongTinMonHoc_Bac";
			this.gp_ThongTinMonHoc_Bac.Size = new System.Drawing.Size(523, 213);
			this.gp_ThongTinMonHoc_Bac.TabIndex = 5;
			this.gp_ThongTinMonHoc_Bac.TabStop = false;
			this.gp_ThongTinMonHoc_Bac.Text = "Thông tin môn học";
			// 
			// cbo_MaMH_Bac
			// 
			this.cbo_MaMH_Bac.FormattingEnabled = true;
			this.cbo_MaMH_Bac.Location = new System.Drawing.Point(189, 39);
			this.cbo_MaMH_Bac.Name = "cbo_MaMH_Bac";
			this.cbo_MaMH_Bac.Size = new System.Drawing.Size(310, 40);
			this.cbo_MaMH_Bac.TabIndex = 10;
			this.cbo_MaMH_Bac.SelectedIndexChanged += new System.EventHandler(this.cbo_MaMH_Bac_SelectedIndexChanged);
			// 
			// txt_TenMH_Bac
			// 
			this.txt_TenMH_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TenMH_Bac.Location = new System.Drawing.Point(189, 92);
			this.txt_TenMH_Bac.Name = "txt_TenMH_Bac";
			this.txt_TenMH_Bac.Size = new System.Drawing.Size(310, 40);
			this.txt_TenMH_Bac.TabIndex = 9;
			// 
			// txt_SoTC_Bac
			// 
			this.txt_SoTC_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_SoTC_Bac.Location = new System.Drawing.Point(189, 150);
			this.txt_SoTC_Bac.Name = "txt_SoTC_Bac";
			this.txt_SoTC_Bac.Size = new System.Drawing.Size(310, 40);
			this.txt_SoTC_Bac.TabIndex = 5;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 45);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(176, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "Mã môn học : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(15, 153);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 33);
			this.label3.TabIndex = 8;
			this.label3.Text = "Số tín chỉ : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(15, 99);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(181, 33);
			this.label2.TabIndex = 6;
			this.label2.Text = "Tên môn học : ";
			
			// 
			// monHocBindingSource
			// 
			this.monHocBindingSource.DataMember = "MonHoc";
			// monHocTableAdapter
			// 
			
			// 
			// frm_SuaMonHoc_Bac
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(619, 343);
			this.Controls.Add(this.btn_SuaMonHoc_Bac);
			this.Controls.Add(this.gp_ThongTinMonHoc_Bac);
			this.Name = "frm_SuaMonHoc_Bac";
			this.Text = "Sửa thông tin môn học";
			this.Load += new System.EventHandler(this.frm_SuaMonHoc_Bac_Load);
			this.gp_ThongTinMonHoc_Bac.ResumeLayout(false);
			this.gp_ThongTinMonHoc_Bac.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.monHocBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Button btn_SuaMonHoc_Bac;
		private System.Windows.Forms.GroupBox gp_ThongTinMonHoc_Bac;
		private System.Windows.Forms.TextBox txt_SoTC_Bac;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_TenMH_Bac;
		private System.Windows.Forms.ComboBox cbo_MaMH_Bac;
		private System.Windows.Forms.BindingSource monHocBindingSource;
	}
}