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
    public partial class frmBai3 : Form
    {
        List<string> listNghia = new List<string>();
        public frmBai3()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lstDanhSachTuMoi_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = lstDanhSachTuMoi.SelectedIndex;
            txtNghiaTuMoi.Text = listNghia[index];
        }

        private void btnThemTuMoi_Click(object sender, EventArgs e)
        {
            var tuMoi = txtTuMoi.Text;
            lstDanhSachTuMoi.Items.Add(tuMoi);
            listNghia.Add(txtNghiaCuaTu.Text);
        }
    }
}
