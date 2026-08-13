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
    public partial class frmBai4 : Form
    {
        List<int> listNum = new List<int>();
        public frmBai4()
        {
            InitializeComponent();
        }

        private void frmBai4_Load(object sender, EventArgs e)
        {
            Random rnd = new Random();

            for (int _ = 0; _ < 10; _++) {
                listNum.Add(rnd.Next(1, 101));
                lstSoNguyen.Items.Add(listNum.LastOrDefault());
            }
        }

        private void txtSoCanTim_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTimSo_Click(object sender, EventArgs e)
        {
            try
            {
                int num = int.Parse(txtSoCanTim.Text);
                if (listNum.Contains(num)) {
                    lblKetQua.Text = "Tìm thấy";
                }
                else
                {
                    lblKetQua.Text = "Không tìm thấy";
                }
            }

            catch {
                MessageBox.Show("Vui lòng nhập số", "Lỗi");
            }   
        }
        
    }
}
