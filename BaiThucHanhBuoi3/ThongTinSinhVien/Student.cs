using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongTinSinhVien
{
    public class Student
    {
	public string MSSV {get; set;}
	public string HoVaTenLot{get; set;}
	public string Ten{get; set;}
	public DateTime NgaySinh{get; set;}
	public string CMND{get; set;}
	public string GioiTinh{get; set;}
	public string Lop{get; set;}
	public string SDT{get; set;}
	public string DiaChi{get; set;}
	public string[] MonHoc{get; set;}

	public Student () {}
	public Student (string mssv, string hotenlot, string ten, DateTime ngaysinh, string cmnd, string gioitinh, string lop, string sdt, string diachi, string monhoc) {
	    if (!CheckStringLen(mssv, 7) || !CheckStringLen(cmnd, 9) || !CheckStringLen(sdt, 10) || mssv == "" || hotenlot == "" || ten == "" || lop == "" || diachi == "") {
		throw new ArgumentException("Vui long kiem tra lai cac truong");
	    }
	    MSSV = mssv.Trim();
	    HoVaTenLot = hotenlot.Trim();
	    Ten = ten.Trim();
	    NgaySinh = ngaysinh;
	    CMND = cmnd.Trim();
	    GioiTinh = gioitinh.Trim();
	    Lop = lop.Trim();
	    SDT = sdt.Trim();
	    DiaChi = diachi.Trim();
	    MonHoc = ExtractMonHoc(monhoc);
	}


	string[] ExtractMonHoc (string str) {
	    string[] monHoc = str.Split('|');

	    return monHoc;
	}

	bool CheckStringLen(string str, int n) {
	    if (str.Length != n) {
			return false;
	    }
	    return true;
	}

	public override string ToString() {
			return $"{MSSV},{HoVaTenLot},{Ten},{NgaySinh},{CMND},{GioiTinh},{Lop},{SDT},{DiaChi},{string.Join("|", MonHoc)}";
	}
    }
}


