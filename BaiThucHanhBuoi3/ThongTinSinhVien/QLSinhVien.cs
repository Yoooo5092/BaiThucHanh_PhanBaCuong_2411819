using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlTypes;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Globalization;
using System.Collections.ObjectModel;

namespace ThongTinSinhVien
{
    public class QLSinhVien
    {
        public List<Student> collection { get; set; }

        public QLSinhVien()
        {
            collection = new List<Student>();
        }

        public QLSinhVien(List<Student> list) { collection = list; }

        public QLSinhVien(string path)
        {
            collection = new List<Student>();

            switch (Path.GetExtension(path)) {
                case ".txt":
                    LoadTxt(path);
                    break;

		        case ".json":
		            LoadJson(path);
		            break;

                    }
            
        }

        public void LoadTxt(string path)
        {
            StreamReader sr = new StreamReader(path);

            string raw;

            while ((raw = sr.ReadLine()) != null)
            {
                string[] line = raw.Split(',');

                Student hocSinh = new Student(line[0], line[1], line[2], DateTime.Parse(line[3]), line[4], line[5], line[6], line[7], line[8], line[9]);

                collection.Add(hocSinh);
            }

            sr.Close();

        }

        public void LoadJson(string path)
        {
		StreamReader sr = new StreamReader(path);

		string json = sr.ReadToEnd();
        sr.Close();
		var jsonObject = (JObject)JsonConvert.DeserializeObject(json);
		var hs = jsonObject["sinhvien"].Children();

		foreach (var item in hs) {
		    string monHoc = "";
            var temp = item["MonHoc"] as JArray;
            if (temp != null)

                collection.Add(new Student(
                    item["MSSV"].Value<string>(),

                    item["HoVaTenLot"].Value<string>(),
                    item["Ten"].Value<string>(),
                    DateTime.ParseExact(item["NgaySinh"].Value<string>(), "dd/MM/yyyy", CultureInfo.InvariantCulture),
                    item["CMND"].Value<string>(),
                    item["GioiTinh"].Value<string>(),
                    item["Lop"].Value<string>(),
                    item["SDT"].Value<string>(),
                    item["DiaChi"].Value<string>(),
                    monHoc
                    ));
		    }
        }
        public int CheckExistMSSV(string mssv)
        {
            int index = collection.FindIndex(x => string.Equals(mssv, x.MSSV, StringComparison.OrdinalIgnoreCase));

            return index;
        }
        public bool SuaSinhVien(Student svMoi)
        {

            int index = CheckExistMSSV(svMoi.MSSV);
            if (index == -1)
            {
                return false;
            }
            collection[index] = svMoi;
            return true;
        }

        public bool XoaSinhVien(string mssv)
        {
            int index = CheckExistMSSV(mssv);
            if (index == -1)
            {
                return false;
            }
            collection.RemoveAt(index);
            return true;
        }
        public bool ThemSinhVien(Student sv)
        {
            if (CheckExistMSSV(sv.MSSV) != -1)
            {
                return false;
            }

            collection.Add(sv);
            return true;
        }


        public QLSinhVien TimKiem(string tuKhoa)
        {
            string trimTuKhoa = tuKhoa.Trim();
            return new QLSinhVien(collection.Where(x => x.Ten.IndexOf(trimTuKhoa, StringComparison.OrdinalIgnoreCase) >= 0 || 
                                                        x.MSSV.IndexOf(trimTuKhoa, StringComparison.OrdinalIgnoreCase) >= 0 ||
                                                        x.HoVaTenLot.IndexOf(trimTuKhoa, StringComparison.OrdinalIgnoreCase) >= 0).ToList());
        }

        public void LuuFile(string path)
        {
            switch (Path.GetExtension(path)) {
                case ".txt":
                    LuuFileTxt(path);
                    break;

                case ".json": 
                    LuuFileJson(path);
                    break;
            }
        }

        public void LuuFileTxt(string path)
        {
            StreamWriter sw = new StreamWriter(path);

            foreach (Student sv in collection)
            {
                sw.WriteLine(sv);
            }

            sw.Close();
        }

        public void LuuFileJson(string path)
        {
            var data = new
            {
                sinhvien = collection
            };

            string json = JsonConvert.SerializeObject(
                data,
                new JsonSerializerSettings { Formatting = Formatting.Indented , DateFormatString = "dd/MM/yyyy"}
            );

            File.WriteAllText(path, json);
        }
    }
}
