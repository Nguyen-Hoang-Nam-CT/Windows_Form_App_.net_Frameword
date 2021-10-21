using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int maxSize = 20;
        public int[] a = new int[20];
        public int size = 0;

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
                return;
            if (size >= 20)
            {
                txtKQ.Text = "Mảng đã đầy không thể nhập nữa";
                return;
            }
            a[size] = int.Parse(txtNhap.Text);
            size++;
            txtNhap.Text = "";
        }
        
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (size == 0)
            {
                txtKQ.Text = "Mảng rỗng";
                return;
            }
            txtKQ.Text = "Các phần tử trong mảng là.\n";
            for(int i = 0; i < size; i++)
                txtKQ.Text += a[i] + "  ";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            size = 0;
            txtKQ.Text = "";
            txtNhap.Text = "";
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        public int temp;
        private void button4_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < size - 1; i++)
                for(int j = i + 1; j < size; j++)
                    if(a[i] > a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < size - 1; i++)
                for (int j = i + 1; j < size; j++)
                    if (a[i] < a[j])
                    {
                        temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                    }
        }

        private void btnChan_Click(object sender, EventArgs e)
        {
            int count = 0;
            for(int i = 0; i < size; i++)
                if (a[i] % 2 == 0)
                    count++;
            txtKQ.Text = "Số lượng số chẵn có trong mảng là: " + count.ToString();
        }

        private void btnLe_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < size; i++)
                if (a[i] % 2 != 0)
                    count++;
            txtKQ.Text = "Số lượng số lẻ có trong mảng là: " + count.ToString();
        }

        public static Boolean kiemTraSNT(int x)
        {
            if (x < 2)
                return false;
            for (int i = 2; i <= x / 2; i++)
                if (x % i == 0)
                    return false;
            return true;
        }
        private void btnSNT_Click(object sender, EventArgs e)
        {
            int count = 0;
            txtKQ.Text = "Số lượng số nguyên tố có trong mảng là: ";
            for(int i = 0; i < size; i++)
                if(kiemTraSNT(a[i]))
                    count++;
            txtKQ.Text += count;
        }

        public Boolean checkSHH(int x)
        {
            if (x < 5)
                return false;
            int count = 0;
            for(int i = 1; i <= x/2; i++)
                if (x % i == 0)
                    count += i;
            if (count % x == 0)
                return true;
            return false;
        }
        private void btnSHH_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < size; i++)
                if (checkSHH(a[i]))
                    count++;
            txtKQ.Text = "Số lượng số hoàn hảo có trong mảng la: " + count;
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int count = 0;
            for (int i = 0; i < size; i++)
                    count += a[i];
            txtKQ.Text = "Tổng mảng là: " + count;
        }

        public int UCLN(int a, int b)
        {
            int temp;
            Math.Abs(a);
            Math.Abs(b);
            // Nếu a = 0 => ucln(a,b) = b
            // Nếu b = 0 => ucln(a,b) = a
            if (a == 0 || b == 0)
                return a + b;
            while (a != b)
            {
                if (a > b)
                    a -= b;
                else if (a < b)
                    b -= a;
            }    
            return a;
        }
        private void btnUCLN_Click(object sender, EventArgs e)
        {
            if(size < 2)
            {
                txtKQ.Text = "Mảng không có đủ 2 phần tử để tìm";
                return;
            }
            txtKQ.Text = "ước chung lớn nhất của 2 số đầu tiên là: " + UCLN(a[0], a[1]).ToString();
        }

        private void btnTB_Click(object sender, EventArgs e)
        {
            if(size == 0)
            {
                txtKQ.Text = "Tổng mảng là: 0";
                return;
            }
            int sum = 0;
            for (int i = 0; i < size; i++)
                sum += a[i];
            txtKQ.Text = "Tổng mảng là: " + sum/(double)size;
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            int min = a[0];
            for (int i = 1; i < size; i++)
                if (a[i] < min)
                    min = a[i];
            txtKQ.Text = "Min is: " + min;
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            int max = a[0];
            for (int i = 1; i < size; i++)
                if (a[i] > max)
                    max = a[i];
            txtKQ.Text = "Max is: " + max;
        }
    }
}
