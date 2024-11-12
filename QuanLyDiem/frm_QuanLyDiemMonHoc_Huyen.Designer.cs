namespace QuanLySinhVien_Nhom2.QuanLyDiem
{
	partial class frm_QuanLyDiemMonHoc_Huyen
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
			this.dgv_ThongTinDiem_Huyen = new System.Windows.Forms.DataGridView();
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_DiemQuaTrinh_Huyen = new System.Windows.Forms.Button();
			this.btn_DiemThi_Huyen = new System.Windows.Forms.Button();
			this.btn_DiemTBHK_Huyen = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_TimKiem_Huyen = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinDiem_Huyen)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_ThongTinDiem_Huyen
			// 
			this.dgv_ThongTinDiem_Huyen.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dgv_ThongTinDiem_Huyen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_ThongTinDiem_Huyen.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14});
			this.dgv_ThongTinDiem_Huyen.Location = new System.Drawing.Point(23, 103);
			this.dgv_ThongTinDiem_Huyen.MultiSelect = false;
			this.dgv_ThongTinDiem_Huyen.Name = "dgv_ThongTinDiem_Huyen";
			this.dgv_ThongTinDiem_Huyen.RowHeadersWidth = 62;
			this.dgv_ThongTinDiem_Huyen.RowTemplate.Height = 28;
			this.dgv_ThongTinDiem_Huyen.Size = new System.Drawing.Size(1145, 502);
			this.dgv_ThongTinDiem_Huyen.TabIndex = 0;
			// 
			// Column1
			// 
			this.Column1.DataPropertyName = "MaSV";
			this.Column1.HeaderText = "Mã sinh viên";
			this.Column1.MinimumWidth = 8;
			this.Column1.Name = "Column1";
			this.Column1.Width = 150;
			// 
			// Column2
			// 
			this.Column2.DataPropertyName = "HoDem";
			this.Column2.HeaderText = "Họ đệm";
			this.Column2.MinimumWidth = 8;
			this.Column2.Name = "Column2";
			this.Column2.Width = 150;
			// 
			// Column3
			// 
			this.Column3.DataPropertyName = "Ten";
			this.Column3.HeaderText = "Tên";
			this.Column3.MinimumWidth = 8;
			this.Column3.Name = "Column3";
			this.Column3.Width = 150;
			// 
			// Column4
			// 
			this.Column4.DataPropertyName = "MaMH";
			this.Column4.HeaderText = "Mã môn học";
			this.Column4.MinimumWidth = 8;
			this.Column4.Name = "Column4";
			this.Column4.Width = 150;
			// 
			// Column5
			// 
			this.Column5.DataPropertyName = "TenMH";
			this.Column5.HeaderText = "Tên môn học";
			this.Column5.MinimumWidth = 8;
			this.Column5.Name = "Column5";
			this.Column5.Width = 150;
			// 
			// Column6
			// 
			this.Column6.DataPropertyName = "SoTC";
			this.Column6.HeaderText = "Số tín chỉ";
			this.Column6.MinimumWidth = 8;
			this.Column6.Name = "Column6";
			this.Column6.Width = 150;
			// 
			// Column7
			// 
			this.Column7.DataPropertyName = "DiemCC";
			this.Column7.HeaderText = "Điểm chuyên cần";
			this.Column7.MinimumWidth = 8;
			this.Column7.Name = "Column7";
			this.Column7.Width = 150;
			// 
			// Column8
			// 
			this.Column8.DataPropertyName = "DiemHS1";
			this.Column8.HeaderText = "Điểm hệ số 1";
			this.Column8.MinimumWidth = 8;
			this.Column8.Name = "Column8";
			this.Column8.Width = 150;
			// 
			// Column9
			// 
			this.Column9.DataPropertyName = "DiemHS2L1";
			this.Column9.HeaderText = "Điểm hệ số 2 lần 1";
			this.Column9.MinimumWidth = 8;
			this.Column9.Name = "Column9";
			this.Column9.Width = 150;
			// 
			// Column10
			// 
			this.Column10.DataPropertyName = "DiemHS2L2";
			this.Column10.HeaderText = "Điểm hệ số 2 lần 2";
			this.Column10.MinimumWidth = 8;
			this.Column10.Name = "Column10";
			this.Column10.Width = 150;
			// 
			// Column11
			// 
			this.Column11.DataPropertyName = "DiemQuaTrinh";
			this.Column11.HeaderText = "Điểm quá trình";
			this.Column11.MinimumWidth = 8;
			this.Column11.Name = "Column11";
			this.Column11.Width = 150;
			// 
			// Column12
			// 
			this.Column12.DataPropertyName = "DiemThi";
			this.Column12.HeaderText = "Điểm thi";
			this.Column12.MinimumWidth = 8;
			this.Column12.Name = "Column12";
			this.Column12.Width = 150;
			// 
			// Column13
			// 
			this.Column13.DataPropertyName = "DiemHocPhan";
			this.Column13.HeaderText = "Điểm học phần";
			this.Column13.MinimumWidth = 8;
			this.Column13.Name = "Column13";
			this.Column13.Width = 150;
			// 
			// Column14
			// 
			this.Column14.DataPropertyName = "DiemTBHK";
			this.Column14.HeaderText = "Điểm trung bình chung học kỳ";
			this.Column14.MinimumWidth = 8;
			this.Column14.Name = "Column14";
			this.Column14.Width = 150;
			// 
			// btn_DiemQuaTrinh_Huyen
			// 
			this.btn_DiemQuaTrinh_Huyen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DiemQuaTrinh_Huyen.Location = new System.Drawing.Point(23, 30);
			this.btn_DiemQuaTrinh_Huyen.Name = "btn_DiemQuaTrinh_Huyen";
			this.btn_DiemQuaTrinh_Huyen.Size = new System.Drawing.Size(253, 59);
			this.btn_DiemQuaTrinh_Huyen.TabIndex = 1;
			this.btn_DiemQuaTrinh_Huyen.Text = "Nhập điểm quá trình";
			this.btn_DiemQuaTrinh_Huyen.UseVisualStyleBackColor = true;
			// 
			// btn_DiemThi_Huyen
			// 
			this.btn_DiemThi_Huyen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DiemThi_Huyen.Location = new System.Drawing.Point(282, 30);
			this.btn_DiemThi_Huyen.Name = "btn_DiemThi_Huyen";
			this.btn_DiemThi_Huyen.Size = new System.Drawing.Size(195, 59);
			this.btn_DiemThi_Huyen.TabIndex = 2;
			this.btn_DiemThi_Huyen.Text = "Nhập điểm thi";
			this.btn_DiemThi_Huyen.UseVisualStyleBackColor = true;
			// 
			// btn_DiemTBHK_Huyen
			// 
			this.btn_DiemTBHK_Huyen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_DiemTBHK_Huyen.Location = new System.Drawing.Point(483, 30);
			this.btn_DiemTBHK_Huyen.Name = "btn_DiemTBHK_Huyen";
			this.btn_DiemTBHK_Huyen.Size = new System.Drawing.Size(353, 59);
			this.btn_DiemTBHK_Huyen.TabIndex = 3;
			this.btn_DiemTBHK_Huyen.Text = "Tính điểm trung bình học kỳ";
			this.btn_DiemTBHK_Huyen.UseVisualStyleBackColor = true;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(881, 52);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(122, 33);
			this.label1.TabIndex = 4;
			this.label1.Text = "Từ khóa :";
			// 
			// txt_TimKiem_Huyen
			// 
			this.txt_TimKiem_Huyen.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TimKiem_Huyen.Location = new System.Drawing.Point(1007, 49);
			this.txt_TimKiem_Huyen.Name = "txt_TimKiem_Huyen";
			this.txt_TimKiem_Huyen.Size = new System.Drawing.Size(150, 40);
			this.txt_TimKiem_Huyen.TabIndex = 5;
			// 
			// frm_QuanLyDiemMonHoc_Huyen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1169, 629);
			this.Controls.Add(this.txt_TimKiem_Huyen);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btn_DiemTBHK_Huyen);
			this.Controls.Add(this.btn_DiemThi_Huyen);
			this.Controls.Add(this.btn_DiemQuaTrinh_Huyen);
			this.Controls.Add(this.dgv_ThongTinDiem_Huyen);
			this.Name = "frm_QuanLyDiemMonHoc_Huyen";
			this.Text = "Quản lý Điểm các môn học của sinh viên";
			this.Load += new System.EventHandler(this.frm_QuanLyDiemMonHoc_Huyen_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_ThongTinDiem_Huyen)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_ThongTinDiem_Huyen;
		private System.Windows.Forms.Button btn_DiemQuaTrinh_Huyen;
		private System.Windows.Forms.Button btn_DiemThi_Huyen;
		private System.Windows.Forms.Button btn_DiemTBHK_Huyen;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txt_TimKiem_Huyen;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
	}
}