using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            txtn.Clear();    //txtNhap.ResetText();
            txtm.Clear();
            txtKQ.Clear();
            txtn.Focus();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit", "Câu hỏi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rdb1.Checked = true; // rdbInThuong.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(txtn.Text), b = int.Parse(txtm.Text);
            int max = a > b ? a : b;
            String kq = "";
            if(rdb1.Checked == true)
            {
                int count = 0;
                for(int i = 1; i <= max/2; i++)
                    if (a % i == 0 && b % i == 0)
                    {
                        count++;
                        if(count == 1)
                            kq += i;
                        else
                            kq += ", " + i;
                    }
                if (count == 0)
                    txtKQ.Text = "KHông tìm được ước chung của 2 số";
                else
                    txtKQ.Text = kq;
            }
            else 
            {
                int du;
                while(b != 0)
                {
                    du = a % b;
                    a = b;
                    b = du;
                }
                txtKQ.Text = a.ToString();
            }
        }
    }
}
