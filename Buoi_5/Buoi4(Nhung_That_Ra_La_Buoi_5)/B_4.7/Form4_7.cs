using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_4._7
{
    public partial class Form4_7 : Form
    {
        public Form4_7()
        {
            InitializeComponent();
        }
        int[] a = new int[100];
        int size;
        private void btnTong_Click(object sender, EventArgs e)
        {
            int tong = 0, chan = 0, le =0;
            for(int i = 0; i < size; i++)
            {
                tong += a[i];
                if (a[i] % 2 == 0)
                    chan += a[i];
                else
                    le += a[i];
            }
            txtTongMang.Text = tong.ToString();
            txtTongLe.Text = le.ToString();
            txtTongChan.Text = chan.ToString();
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (size == 0)
                return;
            int min = a[0], max = a[0];
            for(int i = 1; i < size; i++)
            {
                if (min > a[i])
                    min = a[i];

                if (max < a[i])
                    max = a[i];
            }
            txtMin.Text = min.ToString();
            txtMax.Text = max.ToString();

        }

        public void swap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        private void btnSapXep_Click(object sender, EventArgs e)
        {
            txtKetQua.ResetText();
            if(rboSapXepTang.Checked == true)
            {
                for (int i = 0; i < size - 1; i++)
                    for (int j = i + 1; j < size; j++)
                        if (a[i] > a[j])
                            swap(ref a[i], ref a[j]);
                PhuongThuc.xuatMang(a, size, ref txtKetQua);
                txtKetQua.Text = txtKetQua.Text.Insert(0, "Tăng dần: ");
            }
            else
            {
                for (int i = 0; i < size - 1; i++)
                    for (int j = i + 1; j < size; j++)
                        if (a[i] < a[j])
                            swap(ref a[i], ref a[j]);
                PhuongThuc.xuatMang(a, size, ref txtKetQua);
                txtKetQua.Text = txtKetQua.Text.Insert(0, "Giảm dần: ");
            }
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnXuatMang_Click(object sender, EventArgs e)
        {
            txtKetQua.ResetText();
            String temp = txtNhapMang.Text;
            size = PhuongThuc.ganChuoiVaoMang(ref temp, a);
            for (int i = 0; i < size; i++)
                txtKetQua.Text += (a[i] + " ");
        }

        private void Form4_7_Load(object sender, EventArgs e)
        {
            int[] c = new int[100];
            int h = c.Length;
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtKetQua.ResetText();
            txtNhapMang.ResetText();
            txtTongChan.ResetText();
            txtTongMang.ResetText();
            txtTongLe.ResetText();
            txtMin.ResetText();
            txtMax.ResetText();
            txtViTriThayThe.ResetText();
            txtSoThayThe.ResetText();
        }

        private void btnThayThe_Click(object sender, EventArgs e)
        {
            int vt = int.Parse(txtViTriThayThe.Text),
                so = int.Parse(txtSoThayThe.Text);
            for(int i = 0; i < size; i++)
                if (i == vt)
                    a[i] = so;
            txtKetQua.ResetText();
            txtKetQua.Text = "Mảng sau khi thay thế: ";
            for (int i = 0; i < size; i++)
                txtKetQua.Text += a[i] + " ";
        }
    }
}
