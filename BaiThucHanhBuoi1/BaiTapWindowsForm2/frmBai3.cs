using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiTapWindowsForm2
{
    public partial class frmBai3 : Form
    {
        public frmBai3()
        {
            InitializeComponent();
        }

        private void btnGhepChuoi_Click(object sender, EventArgs e)
        {
            try
            {
                string kqua = "";
                Tinh.NoiChuoi(txtHo.Text, txtTen.Text, ref kqua);

                lblKetQua.Text = kqua;
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }

        private void btnTinhGiaiThua_Click(object sender, EventArgs e)
        {
            try
            {
                lblKetQua.Text = Tinh.GiaiThua(int.Parse(txtN.Text)).ToString();
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }
    }
}
