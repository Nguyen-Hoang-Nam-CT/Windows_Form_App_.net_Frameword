using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace B_4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }
        private void btnThucHien_Click(object sender, EventArgs e)
        {
            if (rbVuong.Checked == false && rbCN.Checked == false && rbTG.Checked == false && rbTron.Checked == false)
                MessageBox.Show("Hãy chọn hình muốn tính", "Thông báo");
            else if (rbVuong.Checked == true)
            {
                txtDTHinhVuong.Text = (double.Parse(txtCanhHinhVuong.Text) * double.Parse(txtCanhHinhVuong.Text)).ToString();
                txtCVHinhVuong.Text = ((double.Parse(txtCanhHinhVuong.Text) * 4)).ToString();
            }
            else if (rbCN.Checked == true)
            {
                txtDTChuNhat.Text = (double.Parse(txtDai.Text) * double.Parse(txtRong.Text)).ToString();
                txtCVChuNhat.Text = ((double.Parse(txtDai.Text) + double.Parse(txtRong.Text)) * 2).ToString();
            }
            else if (rbTG.Checked == true)
            {
                double a = double.Parse(txtCanh1.Text),
                       b = double.Parse(txtCanh2.Text),
                       c = double.Parse(txtCanh3.Text);

                if (a < b + c && b < a + c && c < a + b)
                {
                    if (a * a == b * b + c * c || b * b == a * a + c * c || c * c == a * a + b * b)
                        txtLoai.Text = "Tam giác vuông";
                    else if (a == b && b == c)
                        txtLoai.Text = "Tam giác đều";
                    else if (a == b || a == c || b == c)
                        txtLoai.Text = "Tam giác cân";
                    else if (a * a > b * b + c * c || b * b > a * a + c * c || c * c > a * a + b * b)
                        txtLoai.Text = "Tam giác tù";
                    else
                        txtLoai.Text = "Tam giác thường";

                    // chu vi tam giác = tổng 3 cạnh
                    txtCVTamGiac.Text = (a + b + c).ToString();

                    //diện tích tam giác = căn(p * (p-cạnh 1) * (p - cạnh 2) * (p - cạnh 3))
                    double p = double.Parse(txtCVTamGiac.Text) / 2.0; //(p là nữa chu vi) 
                    txtDTTamGiac.Text = (Math.Sqrt(p * (p - a) * (p - b) * (p - c))).ToString();

                }
                else
                    txtLoai.Text = "Ba canh 1, 2, 3 khong tao thanh tam giac";
            }
            else if (rbTron.Checked == true)
            {
                double R = double.Parse(txtBanKinh.Text);
                txtDTTron.Text = (3.14 * R * R).ToString();//pi r * r
                txtCVTron.Text = (2 * 3.14 * R).ToString();//2 pi r
            }
        }
        private void rbTron_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTron.Checked == true)
            {
                groupBox5.Visible = true;
                groupBox6.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
            }    
        }
        private void rbTG_CheckedChanged(object sender, EventArgs e)
        {
            if(rbTG.Checked == true)
            {
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox3.Visible = false;
                groupBox4.Visible = true;
            }    
        }
        private void rbVuong_CheckedChanged(object sender, EventArgs e)
        {
            if(rbVuong.Checked == true)
            {
                groupBox5.Visible = false;
                groupBox6.Visible = true;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
            }    
        }
        private void rbCN_CheckedChanged(object sender, EventArgs e)
        {
            if(rbCN.Checked == true)
            {
                groupBox5.Visible = false;
                groupBox6.Visible = false;
                groupBox3.Visible = true;
                groupBox4.Visible = false;
            }    
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //tron
            txtBanKinh.ResetText();
            txtCVTron.ResetText();
            txtDTTron.ResetText();
            //tam giac
            txtCVTamGiac.ResetText();
            txtDTTamGiac.ResetText();
            txtCanh1.ResetText();
            txtCanh2.ResetText();
            txtCanh3.ResetText();
            //vuong
            txtCVHinhVuong.ResetText();
            txtDTHinhVuong.ResetText();
            txtCanhHinhVuong.ResetText();
            //chu nhat
            txtDai.ResetText();
            txtRong.ResetText();
            txtCVChuNhat.ResetText();
            txtDTChuNhat.ResetText();

        }
    }
}