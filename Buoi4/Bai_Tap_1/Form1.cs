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

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn xóa ô tên đăng nhập và mật khẩu không?", "Câu hỏi",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                txtUser.Clear();
                txtPass.Clear();
                txtUser.Focus();
                //this.txtUser.ResetText();
                //this.txtPass.ResetText();
                //this.txtUser.Focus();
            }    
        }

        private void btnDung_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string thongbao;
            thongbao = "Tên đăng nhập là: ";
            thongbao += this.txtUser.Text;
            thongbao += "\n\rMật khẩu là:";
            thongbao += this.txtPass.Text;
            if (this.chkNho.Checked == true)
                thongbao += "\n\rBạn có ghi nhớ.";
            MessageBox.Show(thongbao, "Thông báo");
        }
    }
}
