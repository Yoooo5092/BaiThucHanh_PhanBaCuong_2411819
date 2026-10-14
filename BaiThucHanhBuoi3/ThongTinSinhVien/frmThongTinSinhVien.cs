using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongTinSinhVien
{
    public partial class frmThongTinSinhVien : Form
    {
        public QLSinhVien qlsv = new QLSinhVien();
        string path = "students.json";
        public frmThongTinSinhVien()
        {
            InitializeComponent();
        }

        public void frmThongTinSinhVien_Load(object sender, EventArgs e)
        {
            qlsv = new QLSinhVien(path);
            LoadListView(qlsv);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                LoadSinhVien(listView1.SelectedItems[0]);
            }
            else
            {
                UnloadSinhVien();
            }
        }

        public void LoadListView(QLSinhVien quanlysinhvien)
        {
            listView1.Items.Clear();
            foreach (Student hocSinh in quanlysinhvien.collection)
            {
                ListViewItem item = new ListViewItem(hocSinh.MSSV);

                item.SubItems.Add(hocSinh.HoVaTenLot);
                item.SubItems.Add(hocSinh.Ten);
                item.SubItems.Add(hocSinh.NgaySinh.ToString("dd/MM/yyyy"));
                item.SubItems.Add(hocSinh.Lop);
                item.SubItems.Add(hocSinh.CMND);
                item.SubItems.Add(hocSinh.SDT);
                item.SubItems.Add(hocSinh.DiaChi);
                item.SubItems.Add(hocSinh.GioiTinh);

                listView1.Items.Add(item);
            }
        }

        private void LoadSinhVien(ListViewItem item)
        {
            txtMSSV.Text = item.SubItems[0].Text;
            txtHoTenLot.Text = item.SubItems[1].Text;
            txtCMND.Text = item.SubItems[5].Text;
            txtDiaChi.Text = item.SubItems[7].Text;
            txtTen.Text = item.SubItems[2].Text;
            txtSoDT.Text = item.SubItems[6].Text;
            dtpNgaySinh.Text = item.SubItems[3].Text;
            cbbLop.Text = item.SubItems[4].Text;

            if (item.SubItems[8].Text == "Nu")
            {
                rdNu.Checked = true;
            }
            else
            {
                rdNam.Checked = true;
            }

            string[] danhSachMon = qlsv.collection[qlsv.CheckExistMSSV(txtMSSV.Text)].MonHoc;
            for (int i = 0; i < chklbMonHocDangKy.Items.Count; i++)
            {
                string tenMon = chklbMonHocDangKy.Items[i].ToString();

                bool tonTai = danhSachMon.Any(x =>
                    string.Equals(
                        x,
                        tenMon,
                        StringComparison.OrdinalIgnoreCase
                    )
                );

                chklbMonHocDangKy.SetItemChecked(i, tonTai);
            }
        }

        private void UnloadSinhVien()
        {
            txtMSSV.Text = "";
            txtHoTenLot.Text = "";
            txtCMND.Text = "";
            txtDiaChi.Text = "";
            txtTen.Text = "";
            txtSoDT.Text = "";

            for (int i = 0; i < chklbMonHocDangKy.Items.Count; i++)
            {
                chklbMonHocDangKy.SetItemChecked(i, false);
            }
        }

        private void tsmXoa_Click(object sender, EventArgs e)
        {
            if (listView1.CheckedItems.Count > 0)
            {
                foreach (ListViewItem item in listView1.CheckedItems)
                {
                    if (qlsv.XoaSinhVien(item.SubItems[0].Text))
                    {
                        MessageBox.Show("Thanh cong");
                        LoadListView(qlsv);
                        qlsv.LuuFile(path);
                    }
                    else
                    {
                        MessageBox.Show("That Bai");
                    }
                }
            }
        }

        private void frmThongTinSinhVien_Click(object sender, EventArgs e)
        {
            UnloadSinhVien();
        }

        private Student DocSinhVienField()
        {
            string MSSV = txtMSSV.Text;
            string HoVaTenLot = txtHoTenLot.Text;
            string CMND = txtCMND.Text;
            string DiaChi = txtDiaChi.Text;
            string Ten = txtTen.Text;
            string SDT = txtSoDT.Text;
            DateTime NgaySinh = dtpNgaySinh.Value;
            string Lop = cbbLop.Text;

            string monhoc = "";
            for (int i = 0; i < chklbMonHocDangKy.Items.Count; i++)
            {
                if (chklbMonHocDangKy.GetItemChecked(i))
                {
                    monhoc += "|" + chklbMonHocDangKy.Items[i];
                }
            }
            try
            {
                return new Student(MSSV, HoVaTenLot, Ten, NgaySinh, CMND, rdNam.Checked ? "Nam" : "Nu", Lop, SDT, DiaChi, monhoc);

            }
            catch
            {
                MessageBox.Show("Kiem tra lai cac truong");

                return null;
            }
        }
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            Student sv = DocSinhVienField();
            if (sv != null)
            {
                if (qlsv.ThemSinhVien(sv))
                {
                    LoadListView(qlsv);
                    qlsv.LuuFile(path);
                    MessageBox.Show("Them thanh cong");
                }
                else
                {
                    MessageBox.Show("Them that bai, MSSV da ton tai");
                }
            }
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            Student sv = DocSinhVienField();
            if (sv != null)
            {
                if (qlsv.SuaSinhVien(sv))
                {
                    LoadListView(qlsv);
                    qlsv.LuuFile(path);
                    MessageBox.Show("Sua thanh cong");

                }
                else
                {
                    MessageBox.Show("Sua that bai, MSSV khong ton tai");

                }

            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            frmTimKiem form = new frmTimKiem(this, qlsv);
            form.Show();
        }

        private void ctmsRightClick_Opening(object sender, CancelEventArgs e)
        {

        }

        private void tsmSua_Click(object sender, EventArgs e)
        {
            btnCapNhat.PerformClick();
        }
    }
}
