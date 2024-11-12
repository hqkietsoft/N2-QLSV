using QuanLySinhVien_Nhom2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_Nhom2.QuanLyDiem
{
	public partial class frm_QuanLyDiemMonHoc_Huyen : Form
	{
		Diem diem;
		public frm_QuanLyDiemMonHoc_Huyen()
		{
			InitializeComponent();
			diem = Diem.DIEM;
			diem.HienThiLenDataGridView(dgv_ThongTinDiem_Huyen);
		}

		private void frm_QuanLyDiemMonHoc_Huyen_Load(object sender, EventArgs e)
		{

			
		}
	}
}
