using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThongTinSinhVien
{
    public partial class frmTuyChon : Form
    {

        private frmSinhVien frmSinhVien;
        public frmTuyChon(frmSinhVien frmSinhVien)
        {
            InitializeComponent();
            this.frmSinhVien = frmSinhVien; 
        }

        private void frmTuyChon_Load(object sender, EventArgs e)
        {



        }

        private void btnSapXep_Click(object sender, EventArgs e)
        {
            if (frmSinhVien != null)
            {
                if (rdMaSinhVien.Checked)
                    frmSinhVien.SapXep(KieuSapXep.theoMa);
                else if (rdHoTen.Checked)
                    frmSinhVien.SapXep(KieuSapXep.theoTen);
                else
                {
                    frmSinhVien.SapXep(KieuSapXep.theoNgaySinh);
                }
                frmSinhVien.LoadListView();
            }
            else
            {
                MessageBox.Show("Lỗi");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
            SinhVien sv = frmSinhVien.qlsv.Tim(txtTuyChon.Text, frmSinhVien.SoSanhTheoMa);

            frmTim form = new frmTim();
            form.ShowDialog();

            form.HienThongTin(sv.Xuat());
        }

        private void txtTuyChon_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
