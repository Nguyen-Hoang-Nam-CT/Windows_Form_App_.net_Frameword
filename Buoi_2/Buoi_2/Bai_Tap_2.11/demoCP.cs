using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_2._11
{
    public partial class demoCP : Form
    {
        public demoCP()
        {
            InitializeComponent();
        }
        private void btnCV_Click(object sender, EventArgs e)
        {
            MessageBox.Show(((float.Parse(txt1.Text) + float.Parse(txt2.Text)) * 2).ToString(), "Thông báo");
        }

        private void btnDT_Click(object sender, EventArgs e)
        {
            MessageBox.Show((float.Parse(txt1.Text) * float.Parse(txt2.Text)).ToString(), "Thông báo");
        }

        private void btnDC_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Math.Sqrt(float.Parse(txt1.Text) * float.Parse(txt1.Text) + float.Parse(txt2.Text) * float.Parse(txt2.Text)).ToString(), "Thông báo");
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult traLoi = MessageBox.Show("Bạn có muốn thoát không", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(traLoi == DialogResult.Yes)
                Application.Exit();
        }

        private void demoCP_Load(object sender, EventArgs e)
        {

        }
    }
}
