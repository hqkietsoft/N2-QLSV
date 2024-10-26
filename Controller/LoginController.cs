using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Nhom2_QuanLySinhVien.Model;
namespace WindowsFormsApp1
{
	internal class LoginController
	{
		SqlCommand command;
		SqlDataReader reader;
		KetnoiModel kn = new KetnoiModel();
		
		public int checkLogin(string tendn, string matkhau)
		{
			try
			{
				string queryToNguoiDung = "select LoaiND from NguoiDung where TenDN = @user and MatKhau = @pass";
				command = new SqlCommand(queryToNguoiDung, kn.openConnect());
				command.Parameters.AddWithValue("@user", tendn);
				command.Parameters.AddWithValue("@pass", matkhau);
				reader = command.ExecuteReader();
				if (reader.Read())
					Program.loaiND = int.Parse(reader["LoaiND"].ToString());
				kn.closeConnect();
			}
			catch (Exception ex) {
				MessageBox.Show("Lỗi : " + ex.Message, " Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			return Program.loaiND;
		}
		
	}
}
