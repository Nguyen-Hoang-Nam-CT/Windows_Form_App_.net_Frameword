using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_3._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            int ngay = int.Parse(txt1.Text), thang = int.Parse(txt2.Text), nam = int.Parse(txt3.Text);
            if (ngay > 0 && ngay < 32 && thang > 0 && thang < 13 && nam > 0)
                MessageBox.Show("Hợp lệ", "Thông báo");
            else
                MessageBox.Show("Không hợp lệ", "Thông báo");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
