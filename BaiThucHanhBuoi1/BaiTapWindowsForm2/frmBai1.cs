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
    public partial class frmBai1 : Form
    {
        public frmBai1()
        {
            InitializeComponent();
        }
        ThietBi thietBi = new ThietBi("TB001", "Máy in 3d", "Việt Nam", 100000000, 10);


        private void frmBai1_Load(object sender, EventArgs e)
        {
            lblThongTin.Text = thietBi.HienThi();
        }

        private void btnThanhTien_Click(object sender, EventArgs e)
        {
            lblThanhTien.Text = $"Thành tiền: {thietBi.ThanhTien()}";
        }
    }
}
