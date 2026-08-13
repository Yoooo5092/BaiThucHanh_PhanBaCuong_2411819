using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm
{
    internal class TinhToan
    {
        public static void CongHaiSo(int a, int b, ref int s)
        {
            s = a + b;
        }

        public static int TongDaySo(int n)
        {
            int ketQua = (n + 1) * (n / 2);

            return ketQua;
        }
    }
}
