using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Nhom2_QuanLySinhVien.Model
{
	public class KetnoiModel
	{
		SqlConnection conDB;
		
		public SqlConnection openConnect()
		{
			string connectString = @"Data Source=DESKTOP-TEOF11\SQLEXPRESS;Initial Catalog=QUANLYSINHVIEN;Integrated Security=True";
			try
			{

				conDB = new SqlConnection(connectString);
				conDB.Open();
			//if (conDB.State == ConnectionState.Open) {
			//	MessageBox.Show("The connection was Successful");
			//}
			//else
			//	MessageBox.Show("The connection was failed");
			}catch(Exception ex)
			{
				MessageBox.Show("Lỗi kết nối : " + ex.Message);
			}
			return conDB;
		}
		public void closeConnect()
		{
			conDB.Close();
			conDB.Dispose();
		}
		
	}
}
