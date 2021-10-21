using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_3._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(textBox1.Text);
            if (x >= 1 && x <= 3)
                MessageBox.Show("Mùa xuân", "Thông báo");
            else if (x >= 4 && x <= 6)
                MessageBox.Show("Mùa hè", "Thông báo");
            else if (x >= 7 && x <= 9)
                MessageBox.Show("Mùa thu", "Thông báo");
            else if (x >= 10 && x <= 12)
                MessageBox.Show("Mùa đông", "Thông báo");
            else
                MessageBox.Show("Bạn đã nhập sai vui lòng nhập lại", "Thông báo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
