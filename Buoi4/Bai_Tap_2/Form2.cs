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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if((this.txtUser.Text == "") || (this.txtPass.Text == ""))
                MessageBox.Show("Vui lòng nhập tên người dùng hoặc mật khẩu");
            else
            {
                if ((this.txtUser.Text == "admin") && (this.txtPass.Text == "P@ssword"))
                {
                    MessageBox.Show("Đăng nhập thành công", "Thông báo");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên và mật khẩu không đúng, hãy nhập lại", "Thông báo");
                    this.txtUser.Clear();
                    this.txtPass.Clear(); this.txtUser.Focus();
                }
            }
        }
    }
}
