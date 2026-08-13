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
    public partial class frmBai2 : Form
    {
        public frmBai2()
        {
            InitializeComponent();
        }

        private void btnXemKetQua_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdCong.Checked)
                {
                    lblKetQua.Text = (int.Parse(txtSoThuHai.Text) + int.Parse(txtSoThuNhat.Text)).ToString();
                }
                else if (rdTru.Checked)
                {
                    lblKetQua.Text = (int.Parse(txtSoThuNhat.Text) - int.Parse(txtSoThuHai.Text)).ToString();
                }
                else if (rdNhan.Checked)
                {
                    lblKetQua.Text = (int.Parse(txtSoThuHai.Text) * int.Parse(txtSoThuNhat.Text)).ToString();
                }
                else if (rdChia.Checked)
                {
                    lblKetQua.Text = (int.Parse(txtSoThuNhat.Text) / int.Parse(txtSoThuHai.Text)).ToString();
                }
            }
            catch
            {
                MessageBox.Show("Lỗi", "Thông báo");
            }
        }
    }
}
