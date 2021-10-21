using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_2._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(txta.Text) + int.Parse(txtb.Text)).ToString() + "", "Thông báo");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(txta.Text) - int.Parse(txtb.Text)).ToString() + "", "Thông báo");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show((int.Parse(txta.Text) * int.Parse(txtb.Text)).ToString() + "", "Thông báo");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (int.Parse(txtb.Text) == 0)
                MessageBox.Show("Bạn phải nhập mẫu khác 0", "Thông báo");
            else
                MessageBox.Show((float.Parse(txta.Text) / int.Parse(txtb.Text)).ToString() + "", "Thông báo");
        }
    }
}
