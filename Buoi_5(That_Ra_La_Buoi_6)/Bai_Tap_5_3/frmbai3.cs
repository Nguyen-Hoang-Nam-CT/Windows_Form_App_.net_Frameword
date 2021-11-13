using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_5_3
{
    public partial class frmbai3 : Form
    {
        public frmbai3()
        {
            InitializeComponent();
        }
        private void frmbai3_Load(object sender, EventArgs e)
        {
            cmbquequan.Items.Add("An Giang");
            cmbquequan.Items.Add("Cần Thơ");
            cmbquequan.Items.Add("Đồng Tháp");
            cmbquequan.Items.Add("Kiêng Giang");
            cmbquequan.Items.Add("Bạc Liêu");
            cmbquequan.Items.Add("Sóc Trăng");
            cmbquequan.Items.Add("Cà Mau");

            radnam.Checked = true;

            lsvDanhSach.Columns.Add("MSSV", 75);
            lsvDanhSach.Columns.Add("Tên", 200);
            lsvDanhSach.Columns.Add("Ngày sinh", 100);
            lsvDanhSach.Columns.Add("Phái", 50);
            lsvDanhSach.Columns.Add("SDT", 100);
            lsvDanhSach.Columns.Add("Quê Quán", 100);

            lsvDanhSach.FullRowSelect = true; // cho phép chọn nhiều dòng
            lsvDanhSach.View = View.Details;//cho phép hiện thị chi tiết bao gồm các tiêu đề
            lsvDanhSach.GridLines = true; //Giao diện listView là dạng lưới
        }

        private void btnthem_Click(object sender, EventArgs e)
        {
            if(txthoten.Text == "")
            {
                MessageBox.Show("Họ tên là thông tin bắt buộc");
                txthoten.Focus();
            }
            else
            {
                ListViewItem LI = new ListViewItem(txtmasv.Text);
                LI.SubItems.Add(txthoten.Text);
                LI.SubItems.Add(dtpngaysinh.Text);
                LI.SubItems.Add(radnam.Checked ? radnam.Text : radnu.Text);
                LI.SubItems.Add(txtsdt.Text);
                LI.SubItems.Add(cmbquequan.Text);
                lsvDanhSach.Items.Add(LI);
            }
        }

        private void lsvDanhSach_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvDanhSach.SelectedItems.Count > 0)
            {
                txtmasv.Text = lsvDanhSach.SelectedItems[0].SubItems[0].Text;
                txthoten.Text = lsvDanhSach.SelectedItems[0].SubItems[1].Text;
                dtpngaysinh.Text = lsvDanhSach.SelectedItems[0].SubItems[2].Text;
                if (lsvDanhSach.SelectedItems[0].SubItems[3].Text == "Nam")
                    radnam.Checked = true;
                else
                    radnu.Checked = true;
                txtsdt.Text = lsvDanhSach.SelectedItems[0].SubItems[4].Text;
                cmbquequan.Text = lsvDanhSach.SelectedItems[0].SubItems[5].Text;
            }
        }

        private void btnsua_Click(object sender, EventArgs e)
        {
            if(lsvDanhSach.SelectedItems.Count > 0)
            {
                lsvDanhSach.SelectedItems[0].SubItems[0].Text = txtmasv.Text;
                lsvDanhSach.SelectedItems[0].SubItems[1].Text = txthoten.Text;
                lsvDanhSach.SelectedItems[0].SubItems[2].Text = dtpngaysinh.Text;
                lsvDanhSach.SelectedItems[0].SubItems[3].Text = radnam.Checked ? "Nam" : "Nữ";
                lsvDanhSach.SelectedItems[0].SubItems[4].Text = txtsdt.Text;
                lsvDanhSach.SelectedItems[0].SubItems[0].Text = cmbquequan.SelectedItem.ToString();
            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            while(lsvDanhSach.SelectedItems.Count > 0)
                lsvDanhSach.Items.Remove(lsvDanhSach.SelectedItems[0]);
        }
    }
}
