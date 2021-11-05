using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_Tap_4._2
{
    class PhuongThuc
    {
        public static bool KiemTraSHH(int n)
        {
            int temp = 0;
            for (int i = 1; i <= n / 2; i++)
                if (n % i == 0)
                    temp += i;
            if(temp == n)
                return true;
            return false;
        }
    }
}
