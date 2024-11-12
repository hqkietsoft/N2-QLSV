using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySinhVien_Nhom2.BCTK
{
	public partial class BaoCaoThongKe : Form
	{
		public BaoCaoThongKe()
		{
			InitializeComponent();
		}

		private void BaoCaoThongKe_Load(object sender, EventArgs e)
		{

            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
        }
    }
}
