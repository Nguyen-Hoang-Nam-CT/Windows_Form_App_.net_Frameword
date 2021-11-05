using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Bai_Tap_4._3
{
    class PhuongThuc
    {
        public static int LayGiaTri(TextBox a)
        {
            int kq;
            if (int.TryParse(a.Text, out kq) == false && a.Text != "")
            {
                a.Text = "";
                a.Focus();
                MessageBox.Show("Bạn phải nhập số ", "Thông báo");
                return int.MinValue;
            }
            return kq;
        }
        public static int UCLN(int a, int b)
        {
            int temp;
            while(b != 0)
            {
                temp = a % b;
                a = b;
                b = temp;
            }
            return a;
        }
        public static void RutGon(ref int tu, ref int mau)
        {
            int U = UCLN(tu, mau);
            tu /= U;
            mau /= U;
            ChuanHoa(ref tu, ref mau);
        }
        public static void ChuanHoa(ref int tu, ref int mau)
        {
            if(mau < 0)
            {
                tu *= -1;
                mau *= -1;
            }    
        }
    }
}
