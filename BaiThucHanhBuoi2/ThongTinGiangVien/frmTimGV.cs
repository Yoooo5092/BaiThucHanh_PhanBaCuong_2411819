using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongTinGiangVien
{
    public partial class frmTimGV : Form
    {
        public delegate int SoSanh(object obj1, object obj2);
        QuanLyGiangVien qlgv;
        public frmTimGV(QuanLyGiangVien qlgv)
        {
            InitializeComponent();
            this.qlgv = qlgv;
            qlgv.DocFile("DSGV.txt");
        }

        private void btnTimGV_Click(object sender, EventArgs e)
        {
            SoSanh ss = SoSanhChuoi;
            bool tim = false;

            foreach (GiangVien gv in qlgv.dsgv)
            {
                bool timThay = false;
                if (rdMaSo.Checked == true && (ss(txtTimGV.Text, gv.MaSo) == 0))
                    timThay = true;

                else if (rdTen.Checked == true && (ss(txtTimGV.Text, gv.HoTen) == 0))
                    timThay = true;

                else if (rdSoDT.Checked == true && (ss(txtTimGV.Text, gv.SoDT) == 0))
                    timThay = true;

                if (timThay)
                {
                    tim = true;
                    frmTBGiangVien frm = new frmTBGiangVien();
                    frm.SetText(gv.ToString());
                    frm.ShowDialog();
                    txtTimGV.Clear();
                    break;
                }
            }
            if (!tim)
                MessageBox.Show("Không tìm thấy giảng viên !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private int SoSanhChuoi(object obj1, object obj2)
        {
            return obj1.ToString().CompareTo(obj2.ToString());
        }

    }
}
