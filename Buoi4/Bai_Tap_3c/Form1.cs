using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_3c
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            String temp = cmbWeb.SelectedItem.ToString();
            txtKQ.Text = "Bạn đã chọn trang báo: " + temp;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtKQ.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cmbWeb.Items.Add("Nhân dân");
            cmbWeb.Items.Add("Tuổi trẻ");
            cmbWeb.Items.Add("Thanh niên");
            cmbWeb.Items.Add("VNExpress");
            cmbWeb.Items.Add("Dân trí");
            cmbWeb.Items.Add("Công an");

            txtKQ.Enabled = false;
        }
    }
}
