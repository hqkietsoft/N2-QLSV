namespace Nhom2_QuanLySinhVien.QuanLyMonHoc
{
	partial class frm_QuanLyMonHoc_Bac
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
			this.dgv_DSMonHoc_Bac = new System.Windows.Forms.DataGridView();
			this.MaMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenMH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoTC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_addNew_Bac = new System.Windows.Forms.Button();
			this.btn_SuaMH_Bac = new System.Windows.Forms.Button();
			this.btn_XoaMH_Bac = new System.Windows.Forms.Button();
			this.txt_TimKiem_Bac = new System.Windows.Forms.TextBox();
			this.lb_TimKiem_Bac = new System.Windows.Forms.Label();
			this.cbo_SapxepMonHoc_Bac = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSMonHoc_Bac)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_DSMonHoc_Bac
			// 
			this.dgv_DSMonHoc_Bac.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_DSMonHoc_Bac.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_DSMonHoc_Bac.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaMH,
            this.TenMH,
            this.SoTC});
			this.dgv_DSMonHoc_Bac.Location = new System.Drawing.Point(2, 105);
			this.dgv_DSMonHoc_Bac.Name = "dgv_DSMonHoc_Bac";
			this.dgv_DSMonHoc_Bac.ReadOnly = true;
			this.dgv_DSMonHoc_Bac.RowHeadersWidth = 62;
			this.dgv_DSMonHoc_Bac.RowTemplate.Height = 28;
			this.dgv_DSMonHoc_Bac.Size = new System.Drawing.Size(1125, 494);
			this.dgv_DSMonHoc_Bac.TabIndex = 0;
			this.dgv_DSMonHoc_Bac.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_DSMonHoc_Bac_CellClick);
			// 
			// MaMH
			// 
			this.MaMH.DataPropertyName = "MaMH";
			this.MaMH.HeaderText = "Mã môn học";
			this.MaMH.MinimumWidth = 8;
			this.MaMH.Name = "MaMH";
			this.MaMH.ReadOnly = true;
			this.MaMH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// TenMH
			// 
			this.TenMH.DataPropertyName = "TenMH";
			this.TenMH.HeaderText = "Tên môn học";
			this.TenMH.MinimumWidth = 8;
			this.TenMH.Name = "TenMH";
			this.TenMH.ReadOnly = true;
			this.TenMH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// SoTC
			// 
			this.SoTC.DataPropertyName = "SoTC";
			this.SoTC.HeaderText = "Số tín chỉ";
			this.SoTC.MinimumWidth = 8;
			this.SoTC.Name = "SoTC";
			this.SoTC.ReadOnly = true;
			this.SoTC.Resizable = System.Windows.Forms.DataGridViewTriState.False;
			// 
			// btn_addNew_Bac
			// 
			this.btn_addNew_Bac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_addNew_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_addNew_Bac.Location = new System.Drawing.Point(7, 3);
			this.btn_addNew_Bac.Name = "btn_addNew_Bac";
			this.btn_addNew_Bac.Size = new System.Drawing.Size(141, 87);
			this.btn_addNew_Bac.TabIndex = 1;
			this.btn_addNew_Bac.Text = "Thêm mới";
			this.btn_addNew_Bac.UseVisualStyleBackColor = true;
			this.btn_addNew_Bac.Click += new System.EventHandler(this.btn_addNew_Bac_Click);
			// 
			// btn_SuaMH_Bac
			// 
			this.btn_SuaMH_Bac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_SuaMH_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_SuaMH_Bac.Location = new System.Drawing.Point(155, 3);
			this.btn_SuaMH_Bac.Name = "btn_SuaMH_Bac";
			this.btn_SuaMH_Bac.Size = new System.Drawing.Size(141, 87);
			this.btn_SuaMH_Bac.TabIndex = 2;
			this.btn_SuaMH_Bac.Text = "Cập nhật";
			this.btn_SuaMH_Bac.UseVisualStyleBackColor = true;
			this.btn_SuaMH_Bac.Click += new System.EventHandler(this.btn_SuaMH_Bac_Click);
			// 
			// btn_XoaMH_Bac
			// 
			this.btn_XoaMH_Bac.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btn_XoaMH_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_XoaMH_Bac.Location = new System.Drawing.Point(303, 2);
			this.btn_XoaMH_Bac.Name = "btn_XoaMH_Bac";
			this.btn_XoaMH_Bac.Size = new System.Drawing.Size(141, 87);
			this.btn_XoaMH_Bac.TabIndex = 3;
			this.btn_XoaMH_Bac.Text = "Xóa";
			this.btn_XoaMH_Bac.UseVisualStyleBackColor = true;
			this.btn_XoaMH_Bac.Click += new System.EventHandler(this.btn_XoaMH_Bac_Click);
			// 
			// txt_TimKiem_Bac
			// 
			this.txt_TimKiem_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_TimKiem_Bac.Location = new System.Drawing.Point(891, 7);
			this.txt_TimKiem_Bac.Name = "txt_TimKiem_Bac";
			this.txt_TimKiem_Bac.Size = new System.Drawing.Size(225, 40);
			this.txt_TimKiem_Bac.TabIndex = 6;
			this.txt_TimKiem_Bac.TextChanged += new System.EventHandler(this.txt_TimKiem_Bac_TextChanged);
			// 
			// lb_TimKiem_Bac
			// 
			this.lb_TimKiem_Bac.AutoSize = true;
			this.lb_TimKiem_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_TimKiem_Bac.Location = new System.Drawing.Point(751, 9);
			this.lb_TimKiem_Bac.Name = "lb_TimKiem_Bac";
			this.lb_TimKiem_Bac.Size = new System.Drawing.Size(131, 32);
			this.lb_TimKiem_Bac.TabIndex = 7;
			this.lb_TimKiem_Bac.Text = "Từ khóa :";
			// 
			// cbo_SapxepMonHoc_Bac
			// 
			this.cbo_SapxepMonHoc_Bac.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbo_SapxepMonHoc_Bac.FormattingEnabled = true;
			this.cbo_SapxepMonHoc_Bac.Items.AddRange(new object[] {
            "Theo mã môn học",
            "Theo tên môn học ",
            "Theo số tín chỉ "});
			this.cbo_SapxepMonHoc_Bac.Location = new System.Drawing.Point(757, 53);
			this.cbo_SapxepMonHoc_Bac.Name = "cbo_SapxepMonHoc_Bac";
			this.cbo_SapxepMonHoc_Bac.Size = new System.Drawing.Size(359, 41);
			this.cbo_SapxepMonHoc_Bac.TabIndex = 8;
			this.cbo_SapxepMonHoc_Bac.SelectedIndexChanged += new System.EventHandler(this.cbo_SapxepMonHoc_Bac_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(561, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(190, 32);
			this.label1.TabIndex = 9;
			this.label1.Text = "Sắp xếp theo : ";
			// 
			// frm_QuanLyMonHoc_Bac
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1128, 600);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbo_SapxepMonHoc_Bac);
			this.Controls.Add(this.lb_TimKiem_Bac);
			this.Controls.Add(this.txt_TimKiem_Bac);
			this.Controls.Add(this.btn_XoaMH_Bac);
			this.Controls.Add(this.btn_SuaMH_Bac);
			this.Controls.Add(this.btn_addNew_Bac);
			this.Controls.Add(this.dgv_DSMonHoc_Bac);
			this.MinimumSize = new System.Drawing.Size(900, 600);
			this.Name = "frm_QuanLyMonHoc_Bac";
			this.Text = "frm_XemThongTinMonHoc_Bac";
			this.Load += new System.EventHandler(this.frm_XemThongTinMonHoc_Bac_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_DSMonHoc_Bac)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_DSMonHoc_Bac;
		private System.Windows.Forms.Button btn_addNew_Bac;
		private System.Windows.Forms.Button btn_SuaMH_Bac;
		private System.Windows.Forms.Button btn_XoaMH_Bac;
		private System.Windows.Forms.TextBox txt_TimKiem_Bac;
		private System.Windows.Forms.Label lb_TimKiem_Bac;
		private System.Windows.Forms.ComboBox cbo_SapxepMonHoc_Bac;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenMH;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoTC;
		private System.Windows.Forms.Label label1;
	}
}