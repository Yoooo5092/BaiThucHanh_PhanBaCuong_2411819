using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThongTinGiangVien
{
    public class QuanLyGiangVien
    {
        public List<GiangVien> dsgv;
        public QuanLyGiangVien()
        {
            dsgv = new List<GiangVien>();
        }
        public GiangVien this[int index]
        {
            get { return this.dsgv[index]; }
            set { dsgv[index] = value; }
        }

        public void Them(GiangVien gv)
        {
            dsgv.Add(gv);
        }

        public void DocFile(string filename)
        {
            string t;
            string[] s;
            GiangVien gv;
            using (StreamReader sr = new StreamReader(filename))
            {
                while ((t = sr.ReadLine()) != null)
                {
                    s = t.Split('\t');
                    gv = new GiangVien();
                    gv.MaSo = s[0];
                    gv.HoTen = s[1];
                    gv.NgaySinh = gv.NgaySinh = DateTime.ParseExact(s[2], "dd/MM/yyyy", null);
                    gv.GioiTinh = s[3];
                    gv.SoDT = s[4];
                    gv.Mail = s[5];
                    if (!string.IsNullOrEmpty(s[6]))
                    {
                        string[] ngoaingu = s[6].Split(';');
                        int i = 0;
                        foreach (string nn in ngoaingu)
                        {
                            if (!string.IsNullOrEmpty(nn) && i < gv.NgoaiNgu.Length)
                            {
                                gv.NgoaiNgu[i] = nn;
                                i++;
                            }
                        }
                    }
                    if (!string.IsNullOrEmpty(s[7]))
                    {
                        string[] hocphan = s[7].Split(';');
                        foreach (string hp in hocphan)
                        {
                            if (!string.IsNullOrEmpty(hp))
                            {
                                HocPhan hphan = new HocPhan(hp);
                                gv.dsHocPhan.Them(hphan);
                            }
                        }
                    }
                    dsgv.Add(gv);
                }
            }
        }


        public void GhiFile(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                foreach (GiangVien gv in dsgv)
                {
                    string ngoaiNgu = "";
                    foreach (string nn in gv.NgoaiNgu)
                    {
                        if (!string.IsNullOrEmpty(nn))
                            ngoaiNgu += nn + ";";
                    }

                    string hocphan = "";
                    foreach (HocPhan hp in gv.dsHocPhan.ds)
                    {
                        hocphan += hp.TenHP + ";";
                    }

                    sw.WriteLine
                    (
                        gv.MaSo + "\t" +
                        gv.HoTen + "\t" +
                        gv.NgaySinh.ToString("dd/MM/yyyy") + "\t" +
                        gv.GioiTinh + "\t" +
                        gv.SoDT + "\t" +
                        gv.Mail + "\t" +
                        ngoaiNgu + "\t" +
                        hocphan
                    );
                }
            }
        }
    }
}
