using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace B_4._7
{
    class PhuongThuc
    {
        public static bool laSo(char a)
        {
            if (a <= '9' && a >= '0')
                return true;
            return false;
        }
        public static bool khacSo(char a)
        {
            if (a > '9' || a < '0')
                return true;
            return false;
        }
        public static int ganChuoiVaoMang(ref String s,int[] a)
        {
            int temp = 0,
                count = 0;
            for (int i = 1; i < s.Length; i++)
            {
                if(laSo(s[i-1]) && i == 1)//nếu ký tự đầu tiên là số
                    temp = int.Parse(s[i-1].ToString());
                
                if (khacSo(s[i-1]) && laSo(s[i]))// nếu s[i - 1] khác số và s[i] là số
                {
                    temp = int.Parse(s[i].ToString());
                    if(i == s.Length - 1)
                        a[count++] = temp;
                }
                else if (laSo(s[i - 1]) && laSo(s[i]))// nếu s[i - 1] là số và s[i] là số
                {
                    temp = temp * 10 + int.Parse(s[i].ToString());
                    if (i == s.Length - 1)
                        a[count++] = temp;
                }
                else if (laSo(s[i - 1]) && khacSo(s[i]))//nếu s[i -1] là số và s[i] khác số
                    a[count++] = temp;
            }
            return count;
        }
        public static void xuatMang(int[] a, int size, ref TextBox temp)
        {
            for (int i = 0; i < size; i++)
                temp.Text += (a[i] + " ");
        }
    }
}
