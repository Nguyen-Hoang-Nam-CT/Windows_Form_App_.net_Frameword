using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rbNam.Checked = true;
            chkDangDiHoc.Checked = true;
        }
        private void btnHienThongTin_Click(object sender, EventArgs e)
        {

            String gioiTinh, tinhTrang;
            if (rbNam.Checked == true)
                gioiTinh = "Nam";
            else
                gioiTinh = "Nữ";
            if (chkDangDiHoc.Checked == true && chkDangDiLam.Checked == true)
                tinhTrang = "Vừa học vừa làm";
            else if (chkDangDiHoc.Checked == true)
                tinhTrang = "Đang đi học";
            else
                tinhTrang = "Đang đi làm";
            MessageBox.Show("Họ tên: " + txtHoTen.Text + "\nGiới Tính: " + gioiTinh
                                       + "\nNgày sinh: " + dateTimePicker.Value.ToString("dd/MM/yyyy")
                                       + "\nĐịa chỉ: " + txtDiaChi.Text + "\nĐiện thoại: " + txtDienThoai.Text
                                       + "\nEmail: " + txtEmail.Text + "\nTình trạng: " + tinhTrang);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }
    }
}
