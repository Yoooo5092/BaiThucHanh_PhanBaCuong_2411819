using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapThietKeForm
{
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnChonHang_Click(object sender, EventArgs e)
        {
            var item = lstDanhSachHangHoa.SelectedItem;
            lstDanhSachDaMua.Items.Add(item);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var item = lstDanhSachDaMua.SelectedItem;
            lstDanhSachDaMua.Items.Remove(item);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int tongTien = 0;

            foreach(var item in lstDanhSachDaMua.Items)
            {
                switch(item)
                {
                    case "Chuột":
                        tongTien += 100000;
                        break;

                    case "Bàn phím":
                        tongTien += 150000;
                        break;

                    case "Máy in":
                        tongTien += 2000000;
                        break;

                    case "USB Kingmax":
                        tongTien += 200000;
                        break;

                    default:
                        tongTien += 0;
                        break;

                }
            }

            lblTongTien.Text = tongTien.ToString() + " đồng";
        }
    }
}
