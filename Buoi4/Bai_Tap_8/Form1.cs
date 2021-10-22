using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbHoTen.Items.Add("Nguyễn Hoàng Nam");
            cbHoTen.Items.Add("Nguyễn Hoàng Hậu");
            cbHoTen.Items.Add("Nguyễn Hoàng Pro Yasuo");
        }

        private void btnChao_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Xin chào bạn: " + cbHoTen.SelectedItem, "Lời chào");
        }
    }
}
