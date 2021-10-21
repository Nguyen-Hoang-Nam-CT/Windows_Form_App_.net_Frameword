using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_2._8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = (float.Parse(textBox2.Text) + float.Parse(textBox3.Text)).ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = (float.Parse(textBox2.Text) - float.Parse(textBox3.Text)).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = (float.Parse(textBox2.Text) * float.Parse(textBox3.Text)).ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (float.Parse(textBox3.Text) == 0)
                MessageBox.Show("Bạn phải nhập mẫu khác 0", "Thông báo");
            else
                textBox1.Text = (float.Parse(textBox2.Text) / float.Parse(textBox3.Text)).ToString();
        }
    }
}
