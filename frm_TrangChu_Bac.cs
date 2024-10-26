using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class frm_TrangChu_Bac : Form
	{
		LoginController login;
		public frm_TrangChu_Bac()
		{
			InitializeComponent();
			login = new LoginController();
		}

		private void frm_TrangChu_Bac_Load(object sender, EventArgs e)
		{
			if (Program.loaiND == 1)// admin
			{
				txt_LoaiND_Bac.Text = "Admin";
			}
			else if (Program.loaiND == 2) // phongdaotao
			{
				txt_LoaiND_Bac.Text = "PDT";
				menuitem_QuanLyHoSoSinhVien.Enabled = true;
				
			}
			else if (Program.loaiND == 3) // giaovien
			{
				txt_LoaiND_Bac.Text = "GiaoVien";
			}
			else if (Program.loaiND == 4) // sinh vien
			{
				txt_LoaiND_Bac.Text = "SinhVien";
			}
		}
	}
}
