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
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int kq = 0;
            TinhToan.CongHaiSo(int.Parse(txtA.Text), int.Parse(txtB.Text), ref kq);
            lblKetQua.Text = kq.ToString();
        }

        private void btnTinhTongDay_Click(object sender, EventArgs e)
        {
            int kq = 0;
            kq = TinhToan.TongDaySo(int.Parse(txtN.Text));
            lblKetQua.Text = kq.ToString();
        }
    }
}
