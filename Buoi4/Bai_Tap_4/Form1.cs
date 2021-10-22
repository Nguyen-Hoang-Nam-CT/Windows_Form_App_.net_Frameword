using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtNhap.Clear();    //txtNhap.ResetText();
            txtKQ.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnKQ_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
                MessageBox.Show("Vui lòng nhập họ tên trước khi bấm kết quả", "Thông báo");
            else if (rdbInThuong.Checked == true)
                txtKQ.Text = txtNhap.Text.ToLower();
            else
                txtKQ.Text = txtNhap.Text.ToUpper();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdbInThuong.Checked = true; // rdbInThuong.Select();
        }
    }
}
