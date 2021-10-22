using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtNhap.Text == "")
                MessageBox.Show("Bạn phải nhập vào ô nhập chuổi trước khi bấm thêm", "Thông báo");
            else
            {
                lst1.Items.Add(txtNhap.Text);
                txtNhap.Clear();
                txtNhap.Focus();
            }    

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtNhap.Focus();
        }

        private void btnMauChu_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if(cld.ShowDialog() == DialogResult.OK)
                txtKQ.ForeColor = cld.Color;
            txtKQ.Text = lst1.SelectedItem.ToString();
        }

        private void btnMauNen_Click(object sender, EventArgs e)
        {
            ColorDialog cld = new ColorDialog();
            if (cld.ShowDialog() == DialogResult.OK)
                txtKQ.BackColor = cld.Color;
        }

        private void btnChonFont_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            if (fd.ShowDialog() == DialogResult.OK)
                txtKQ.Font = fd.Font;
        }
    }
}
