using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtKQ.Enabled = false;
        }
        private void tổngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ 2 số a và b", "Thông báo");
                txta.Focus();
            }
            else if (txtb.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ 2 số a và b", "Thông báo");
                txtb.Focus();
            }
            else if (double.Parse(txtb.Text) == 0)
            {
                MessageBox.Show("Không thể chia cho 0", "Thông báo");
                txtb.Focus();
            }
            else
            {
                double a = double.Parse(txta.Text),
                       b = double.Parse(txtb.Text);
                txtKQ.Text = (a + b).ToString();
            }    
        }
        private void hiệuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ 2 số a và b", "Thông báo");
                txta.Focus();
            }
            else if (txtb.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ 2 số a và b", "Thông báo");
                txtb.Focus();
            }
            else if (double.Parse(txtb.Text) == 0)
            {
                MessageBox.Show("Không thể chia cho 0", "Thông báo");
                txtb.Focus();
            }
            else
            {
                double a = double.Parse(txta.Text),
                       b = double.Parse(txtb.Text);
                txtKQ.Text = (a - b).ToString();
            }
        }

        private void tíchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ 2 số a và b", "Thông báo");
                txta.Focus();
            }
            else if (txtb.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ 2 số a và b", "Thông báo");
                txtb.Focus();
            }
            else if (double.Parse(txtb.Text) == 0)
            {
                MessageBox.Show("Không thể chia cho 0", "Thông báo");
                txtb.Focus();
            }
            else
            {
                double a = double.Parse(txta.Text),
                       b = double.Parse(txtb.Text);
                txtKQ.Text = (a * b).ToString();
            }
        }

        private void thươngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txta.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ 2 số a và b", "Thông báo");
                txta.Focus();
            }    
            else if(txtb.Text == "")
            {
                MessageBox.Show("Bạn phải nhập đầy đủ 2 số a và b", "Thông báo");
                txtb.Focus();
            }    
            else if (double.Parse(txtb.Text) == 0)
            {
                MessageBox.Show("Không thể chia cho 0", "Thông báo");
                txtb.Focus();
            }
            else
            {
                double a = double.Parse(txta.Text),
                       b = double.Parse(txtb.Text);
                txtKQ.Text = (a / b).ToString();
            }
        }
    }
}
