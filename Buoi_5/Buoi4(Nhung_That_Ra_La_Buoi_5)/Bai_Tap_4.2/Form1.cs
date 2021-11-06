using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_4._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtN_TextChanged(object sender, EventArgs e)
        {
            int n;
            if (int.TryParse(txtN.Text, out n) == true)
            {
                if (PhuongThuc.KiemTraSHH(n))
                    MessageBox.Show(n + " là số hoàn hảo");
                else
                    MessageBox.Show(n + " không phải số hoàn hảo");
            }
            else if(txtN.Text != "")
            {
                MessageBox.Show("Bạn không được để trống n và nhập n là số", "Thông báo");
                txtN.Text = "";
                txtN.Focus();
            }    
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtN.Text = "";
        }
    }
}
