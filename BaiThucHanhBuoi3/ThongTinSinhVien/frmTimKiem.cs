using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThongTinSinhVien
{
    public partial class frmTimKiem : Form
    {
        frmThongTinSinhVien formMain;
        QLSinhVien qlsv;
        public frmTimKiem(frmThongTinSinhVien form, QLSinhVien ql)
        {
            formMain = form;
            qlsv = ql;
            InitializeComponent();
        }

        private void txtTuKhoa_TextChanged(object sender, EventArgs e)
        {
            formMain.LoadListView(qlsv.TimKiem(txtTuKhoa.Text));
        }

        private void frmTimKiem_Load(object sender, EventArgs e)
        {

        }

        private void frmTimKiem_FormClosed(object sender, FormClosedEventArgs e)
        {
            formMain.frmThongTinSinhVien_Load(this, e);
        }
    }
}
