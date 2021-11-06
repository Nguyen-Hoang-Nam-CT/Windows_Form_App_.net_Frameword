using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_4._5
{
    public partial class Form1 : Form
    {
        private int[] a = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXuatMangNgauNhien_Click(object sender, EventArgs e)
        {
            Array_.Random_Arr(ref a);
            txtKetQua.Text = "Mảng nhận được: ";
            Array_.GanGiaTriMang(ref txtKetQua, a);
            txtMangGoc.Text = "Mảng ban đầu: ";

            txtMangGoc.Text = txtKetQua.Text;
        }

        private void btnTimPhanTuNhoNhat_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Min = " + Array_.TimMin(a);
        }

        private void btnTinhTongGiaTriMang_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Tổng giá trị mảng là: " + Array_.TongMang(a);
        }

        private void btnTangMoiPhanTuMangLen2_Click(object sender, EventArgs e)
        {
            Array_.Tang2(a,ref txtKetQua);
        }

        private void btnDemSoPhanTuLe_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Sô lượng số lẻ: ";
            txtKetQua.Text += Array_.demPhanTuLe(a).ToString();
        }

        private void btnTongGiaTriPhanTuLe_Click(object sender, EventArgs e)
        {
            txtKetQua.Text = "Tổng giá trị lẻ: ";
            txtKetQua.Text += Array_.TongGiaTriLeTrongMang(a).ToString();
        }

        private void btnSapXepMangTang_Click(object sender, EventArgs e)
        {
            Array_.Quick_Sort_Tang(a, 0, a.Length - 1);
            txtKetQua.Text = "Mảng sau khi sắp xếp: ";
            Array_.GanGiaTriMang(ref txtKetQua, a);
        }

        private void btnSapXepMangGiam_Click(object sender, EventArgs e)
        {
            Array_.Quick_Sort_Giam(a, 0, a.Length - 1);
            txtKetQua.Text = "Mảng sau khi sắp xếp: ";
            Array_.GanGiaTriMang(ref txtKetQua, a);
        }
    }
}
