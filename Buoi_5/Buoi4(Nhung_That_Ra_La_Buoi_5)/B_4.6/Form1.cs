using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_4._6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int[] a = null;
        private void rbXuatMangNgauNhien_CheckedChanged(object sender, EventArgs e)
        {
            if(rbXuatMangNgauNhien.Checked == true)
            {
                Array_.Random_Arr(ref a);
                txtKetQua.Text = "Mảng nhận được: ";
                Array_.GanGiaTriMang(ref txtKetQua, a);
                txtMangGoc.Text = "Mảng ban đầu: ";

                txtMangGoc.Text = txtKetQua.Text;
            }    
        }

        private void rbTimGiaTriNhoNhatCuaMang_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTimGiaTriNhoNhatCuaMang.Checked == true)
                txtKetQua.Text = "Min = " + Array_.TimMin(a);  
        }

        private void rbTinhTongCacGiaTriChanTrongMang_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTinhTongCacGiaTriChanTrongMang.Checked == true)
                txtKetQua.Text = "Tổng chẵn trong mảng là: " + Array_.tongChan(a);
        }

        private void rbLietKeCacGiaTriChanTrongMang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLietKeCacGiaTriChanTrongMang.Checked)
                Array_.lietKeChan(a, txtKetQua);
        }

        private void rbDemSoLuongCacGiaTriChanTrongMang_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDemSoLuongCacGiaTriChanTrongMang.Checked)
                txtKetQua.Text = txtKetQua.Text = "Số lượng số chẵn: " + Array_.demChan(a);
        }

        private void rbTimSoChanCuoiCungTrongMang_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTimSoChanCuoiCungTrongMang.Checked)
            {
                int viTri = Array_.viTriChanCuoi(a);
                if (viTri == -1)
                    txtKetQua.Text = "Mảng không có số chẵn";
                else
                    txtKetQua.Text = "Số chẵn cuối cùng trong mảng là: " + a[viTri]; 
            }    
        }

        private void rbTinhTongCacGiaTriLeTrongMang_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTinhTongCacGiaTriLeTrongMang.Checked)
                txtKetQua.Text = "Tổng giá trị lẻ: " + Array_.TongGiaTriLeTrongMang(a);  
        }
    }
}