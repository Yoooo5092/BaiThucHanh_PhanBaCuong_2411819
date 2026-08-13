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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var hangDaChon = cbbTenHang.SelectedItem;
            
            switch(hangDaChon)
            {
                case "Chuột":
                    txtDonGia.Text = 100000.ToString();
                    break;

                case "Máy in":
                    txtDonGia.Text = 2000000.ToString();
                    break;

                case "Bàn phím":
                    txtDonGia.Text = 150000.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                int tongTien = (int.Parse(txtSoLuong.Text) * int.Parse(txtDonGia.Text));
                if (radChuyenKhoan.Checked)
                {
                    tongTien -= tongTien / 100 * 5;
                }
                lblTongTien.Text = tongTien.ToString();
            }

            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }
    }
}
