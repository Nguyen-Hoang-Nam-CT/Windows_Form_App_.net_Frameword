using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_5_2
{
    public partial class frm5_2 : Form
    {
        public frm5_2()
        {
            InitializeComponent();
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frm5_2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Câu hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (radLopA.Checked == true)
                lstLopA.Items.Add(txtTen.Text);
            else if (radLopB.Checked == true)
                lstLopB.Items.Add(txtTen.Text);
            else
                MessageBox.Show("Bản phải chọn lớp");
            txtTen.ResetText();
            txtTen.Focus();
        }

        private void frm5_2_Load(object sender, EventArgs e)
        {
             
        }

        private void btnphai_Click(object sender, EventArgs e)
        {
            while(lstLopA.SelectedIndex != -1)//nếu người ta chọn nhiều dòng thì làm nhiều lần
            {
                lstLopB.Items.Add(lstLopA.SelectedItem);
                lstLopA.Items.Remove(lstLopA.SelectedItem);
            }
        }

        private void btntrai_Click(object sender, EventArgs e)
        {
            while(lstLopB.SelectedIndex != -1)//nếu người ta chọn nhiều dòng thì làm nhiều lần
            {
                lstLopA.Items.Add(lstLopB.SelectedItem);
                lstLopB.Items.Remove(lstLopB.SelectedItem);
            }
        }

        private void btnnhieuphai_Click(object sender, EventArgs e)
        {
            while(lstLopA.Items.Count > 0)
            {
                lstLopB.Items.Add(lstLopA.Items[0]);
                lstLopA.Items.Remove(lstLopA.Items[0]);
            }
        }

        private void btnnhieutrai_Click(object sender, EventArgs e)
        {
            while (lstLopB.Items.Count > 0)
            {
                lstLopA.Items.Add(lstLopB.Items[0]);
                lstLopB.Items.Remove(lstLopB.Items[0]);
            }
        }

        private void btnTongSo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tổng số sinh viên là: " + (lstLopA.Items.Count + lstLopB.Items.Count), "Thông báo");
        }
    }
}
