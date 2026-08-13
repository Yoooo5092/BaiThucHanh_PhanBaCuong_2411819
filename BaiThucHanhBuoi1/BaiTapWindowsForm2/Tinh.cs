using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTapWindowsForm2
{
    internal class Tinh
    {
        public static void NoiChuoi(string ho, string ten, ref string s)
        {
            s = $"{ho} {ten}";
        }

        public static long GiaiThua(int n)
        {
            long res = 1;
            for (int i = 2; i <= n; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
