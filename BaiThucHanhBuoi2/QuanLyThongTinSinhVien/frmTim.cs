using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThongTinSinhVien
{
    public partial class frmTim : Form
    {
        public frmTim()
        {
            InitializeComponent();
        }

        private void lblThongTin_Click(object sender, EventArgs e)
        {

        }

        public void HienThongTin(string info)
        {
            lblThongTin.Text = info;
        }
    }
}
