using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_2
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a;
        private void btnIn_Click(object sender, EventArgs e)
        {
            if (a.Length == 0)
            {
                txtKQ.Text = "Mảng rỗng";
                return;
            }
            txtKQ.Text = "Các phần tử trong mảng là.\n";
            for(int i = 0; i < a.Length; i++)
                txtKQ.Text += a[i] + "  ";
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        public int random_(int min, int max)
        {
            return (new Random().Next(min, max));
        }
        private void btnRandom_Click(object sender, EventArgs e)
        {
            if(txtNhap.Text == "")
            {
                MessageBox.Show("Bạn phải nhập số lượng phần tử");
                txtNhap.Focus();
                return;
            }    
            if(int.Parse(txtNhap.Text) <= 0)
            {
                MessageBox.Show("Vui lòng nhập số lượng phần tử lớn hơn 0");
                txtNhap.Focus();
                return;
            }
            a = new int[int.Parse(txtNhap.Text)];
            for(int i = 0; i < a.Length; i++)
                a[i] = random_(-10, 100);
            btnIn.Enabled = true;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            btnIn.Enabled = false;
        }
    }
}
