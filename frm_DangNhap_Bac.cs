using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	public partial class frm_DangNhap_Bac : Form
	{
		LoginController login;
		public frm_DangNhap_Bac()
		{
			InitializeComponent();
			login = new LoginController();
		}
		private String GenerateKey()
		{
			string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";

			char[] alToArray = alphabet.ToCharArray();
			Random rand = new Random();

			for (int i = alphabet.Length - 1; i > 0; i--)
			{
				int j = rand.Next(0, i + 1);
				char temp = alToArray[i];
				alToArray[i] = alToArray[j];
				alToArray[j] = temp;
			}

			string result = "";
			for (int i = 0; i < alToArray.Length; i++)
			{
				if (i < 4)
					result += alToArray[i] + " ";
			}
			return result;
		}

		private void frm_DangNhap_Bac_Load(object sender, EventArgs e)
		{

			txt_HienThiMaBV_Bac.Text = GenerateKey();
		}

		private void btn_RandomMa_Bac_Click(object sender, EventArgs e)
		{
			txt_HienThiMaBV_Bac.Text = GenerateKey();
		}

		private void btn_DangNhap_Bac_Click(object sender, EventArgs e)
		{
			
			if (string.IsNullOrEmpty(txt_TenDangNhap_Bac.Text))
				MessageBox.Show("Bạn chưa nhập tên đăng nhập!");
			else if (string.IsNullOrEmpty(txt_MatKhau_Bac.Text))
				MessageBox.Show("Bạn chưa nhập mật khẩu!");
			else if (string.IsNullOrEmpty(txt_MaBaoVe_Bac.Text))
				MessageBox.Show("Bạn chưa mã bảo vệ!");
			else if (login.checkLogin(txt_TenDangNhap_Bac.Text, txt_MatKhau_Bac.Text) == 0)
				MessageBox.Show("Đăng nhập thất bại. Vui lòng kiểm tra lại thông tin");
			else
			{

				MessageBox.Show("Đăng nhập thành công");
				frm_TrangChu_Bac f = new frm_TrangChu_Bac();
				f.ShowDialog();
			}
		}
	}
}
