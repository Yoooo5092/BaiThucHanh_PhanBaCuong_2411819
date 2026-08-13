using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm
{
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }

        private void frmBai1_Load(object sender, EventArgs e)
        {
            HangHoa hangHoa = new HangHoa();
            hangHoa.MaHang = "HH01";
            hangHoa.TenHang = "Chuột";
            hangHoa.DVT = "Cái";
            hangHoa.SoLuong = 4;
            hangHoa.DonGia = 200000;

            lblThongTinHangHoa.Text = hangHoa.HienThi();
        }
    }
}
