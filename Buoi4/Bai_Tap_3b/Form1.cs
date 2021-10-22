using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_3b
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String temp = lstWeb.SelectedItem.ToString();
            txtKQ.Text = "Bạn đã chọn trang báo: " + temp;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lstWeb.Items.Add("Nhân dân");
            lstWeb.Items.Add("Tuổi trẻ");
            lstWeb.Items.Add("Thanh niên");
            lstWeb.Items.Add("VNExpress");
            lstWeb.Items.Add("Dân trí");
            lstWeb.Items.Add("Công an");

            lstWeb.SelectedItem = "Nhân dân";
            txtKQ.Enabled = false;
        }
    }
}
