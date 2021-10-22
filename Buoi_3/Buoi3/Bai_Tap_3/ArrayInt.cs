using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_3
{
    class ArrayInt
    {
        public int[] a;
        public void createArray(int size)
        {
            a = new int[size];
        }
        public String displayArray()
        {
            String temp = "";
            for (int i = 0; i < a.Length; i++)
                temp += a[i] + "  ";
            return temp;
        }
        public String TongMang()
        {
            double sum = 0;
            for(int i = 0; i < a.Length; i++)
                sum += a[i];
            return sum.ToString();
        }
        public string FindMax()
        {
            if (a.Length == 0)
                return "Mãng rỗng mà tìm gì giờ :D";
            double max = a[0];
            for(int i = 0; i < a.Length; i++)
                if (max < a[i])
                    max = a[i];
            return max.ToString();
        }
        public long size()
        {
            return a.Length;
        }    
    }
}
