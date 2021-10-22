using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_3
{
    public partial class Form1 : Form
    {                                  //Tại sao hàm random không ra giá trị theo thời gian thực
        ArrayInt arr = new ArrayInt(); //tại sao chỗ này để public và protected báo lỗi
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi = MessageBox.Show("Do you want to exit?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(traLoi == DialogResult.Yes)
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
            arr.createArray(int.Parse(txtNhap.Text));
            for(int i = 0; i < arr.a.Length; i++)
                arr.a[i] = random_(-10, 100);
            MessageBox.Show("Mảng vừa nhập có +" + (arr.a.Length) + " phần tử phát sinh ngẫu nhiên: " + arr.displayArray(), "Thông báo");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            DialogResult traLoi = MessageBox.Show("Các phần tử trong mảng là: " + arr.displayArray() + "\n Do you want to Tính tổng :))?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.Yes)
                MessageBox.Show("Tổng các phần tử có trong mảng là: " + arr.TongMang());
        }
        private void btnMax_Click(object sender, EventArgs e)
        {
            DialogResult traLoi = MessageBox.Show("Các phần tử trong mảng là: " + arr.displayArray() + "\n Do you want to find max?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (traLoi == DialogResult.Yes)
                MessageBox.Show("Giá trị lớn nhất mảng là: " + arr.FindMax());
        }
    }
}
