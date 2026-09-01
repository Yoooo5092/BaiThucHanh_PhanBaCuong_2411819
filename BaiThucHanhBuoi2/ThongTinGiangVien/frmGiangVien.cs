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
    public partial class frmGiangVien : Form
    {
        QuanLyGiangVien qlgv = new QuanLyGiangVien();
        public frmGiangVien()
        {
            InitializeComponent();
            qlgv.DocFile("DSGV.txt");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string maso = cboMaSo.Text;
            foreach (GiangVien gvien in qlgv.dsgv)
            {
                if (gvien.MaSo == maso)
                {
                    MessageBox.Show("Mã giảng viên đã tồn tại !", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            string[] ngoaingu = new string[30];
            int i = 0;
            foreach (object item in chklbNgoaiNgu.CheckedItems)
            {
                ngoaingu[i] = item.ToString();
                i++;
            }

            DanhMucHocPhan dshp = new DanhMucHocPhan();
            foreach (object item in lbHocPhanDay.Items)
            {
                HocPhan hp = new HocPhan(item.ToString());
                dshp.Them(hp);
            }

            GiangVien gv = new GiangVien
                (
                maso,
                mtxtSoDT.Text,
                txtMail.Text,
                txtHoTen.Text,
                dtpNgaySinh.Value,
                dshp,
                rdNam.Checked ? "Nam" : "Nữ",
                ngoaingu
                );
            qlgv.Them(gv);
            qlgv.GhiFile("DSGV.txt");
            MessageBox.Show("Thêm giảng viên thành công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void frmGiangVien_Load(object sender, EventArgs e)
        {
            string lienHe = "https://cntt.dlu.edu.vn";
            this.linklblLienHe.Links.Add(0, lienHe.Length, lienHe);
            this.cboMaSo.SelectedItem = this.cboMaSo.Items[0];
        }
        public GiangVien GetGiangVien()
        {
            string gt = "Nam";
            if (rdNu.Checked)
                gt = "Nữ";
            GiangVien gv = new GiangVien();
            gv.MaSo = this.cboMaSo.Text;
            gv.GioiTinh = gt;
            gv.HoTen = this.txtHoTen.Text;
            gv.NgaySinh = this.dtpNgaySinh.Value;
            gv.Mail = this.txtMail.Text;
            gv.SoDT = this.mtxtSoDT.Text;

            string ngoaingu = "";
            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
            {
                if (chklbNgoaiNgu.GetItemChecked(i))
                    ngoaingu += chklbNgoaiNgu.Items[i] + ";";
            }
            gv.NgoaiNgu = ngoaingu.Split(';');
            DanhMucHocPhan dshp = new DanhMucHocPhan();
            foreach (object hp in lbDanhSachHP.Items)
            {
                dshp.Them(new HocPhan(hp.ToString()));
            }
            gv.dsHocPhan = dshp;
            return gv;
        }

        private void btnThongBao_Click(object sender, EventArgs e)
        {
            frmTBGiangVien frm = new frmTBGiangVien();
            frm.SetText(GetGiangVien().ToString());
            frm.ShowDialog();
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            int i = this.lbDanhSachHP.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbHocPhanDay.Items.Add(lbDanhSachHP.SelectedItems[i]);
                this.lbDanhSachHP.Items.Remove(lbDanhSachHP.SelectedItems[i]);
                i--;
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            int i = this.lbHocPhanDay.SelectedItems.Count - 1;
            while (i >= 0)
            {
                this.lbDanhSachHP.Items.Add(lbHocPhanDay.SelectedItems[i]);
                this.lbHocPhanDay.Items.Remove(lbHocPhanDay.SelectedItems[i]);
                i--;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Reset();
        }

        public void Reset()
        {
            this.cboMaSo.Text = "";
            this.txtHoTen.Text = "";
            this.txtMail.Text = "";
            this.mtxtSoDT.Text = "";
            this.rdNam.Checked = true;

            for (int i = 0; i < chklbNgoaiNgu.Items.Count - 1; i++)
                chklbNgoaiNgu.SetItemChecked(i, false);
            foreach (object ob in this.lbHocPhanDay.Items)
                this.lbDanhSachHP.Items.Add(ob);
            this.lbHocPhanDay.Items.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            frmTimGV form = new frmTimGV(qlgv);
            form.ShowDialog();
        }
    }
}
