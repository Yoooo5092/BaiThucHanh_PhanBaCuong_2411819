using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Xml;

namespace BaiThucHanhBuoi3
{
    public partial class frmReadJsonFile : Form
    {
        public frmReadJsonFile()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            string Str = "";
            string Path = "students.json";
            List<StudentInfo> List = LoadJSON(Path);
            for (int i = 0; i < List.Count; i++)
            {
                StudentInfo info = List[i];
                Str += string.Format("Sinh vien {0} co MSSV {1}, ho ten {2}, diem TB {3}\n", (i + 1), List[i].MSSV, List[i].HoTen, List[i].Diem);
            }
            MessageBox.Show(Str);

        }


        private List<StudentInfo> LoadJSON(string path)
        {
            List<StudentInfo> List = new List<StudentInfo>();
            StreamReader r = new StreamReader(path);

            string json = r.ReadToEnd();

            var array = (JObject)JsonConvert.DeserializeObject(json);
            var students = array["sinhvien"].Children();

            foreach (var item in students)
            {
                string mssv = item["MSSV"].Value<string>();
                string hoten = item["HoTen"].Value<string>();
                int tuoi = item["Tuoi"].Value<int>();
                float diem = item["Diem"].Value<float>();
                bool tonGiao = item["TonGiao"].Value<bool>();

                StudentInfo hocSinhMoi = new StudentInfo(mssv, hoten, tuoi, diem, tonGiao);

                List.Add(hocSinhMoi);
            }
            return List;
        }

        private void btnDocFIleXML_Click(object sender, EventArgs e)
        {
            var path = "books.xml";
            ReadXML(path);

        }

        private void ReadXML(string path)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            var nodeList = xmlDoc.DocumentElement.SelectNodes("/catalog/book");

            foreach (XmlNode node in nodeList)
            {
                var isbn = node.Attributes["ISBN"].Value;

                var title = node.SelectSingleNode("title").InnerText;

                var price = node.SelectSingleNode("price").InnerText;

                var firstName = node.SelectSingleNode("author/first-name").InnerText;

                var lastName = node.SelectSingleNode("author/last-name").InnerText;
                Console.WriteLine("{0,-15}, {1,-50},{2,-15},{3,-15},{4, 6}   ", isbn, title, price, firstName, lastName);
            }
        }
    }
}
