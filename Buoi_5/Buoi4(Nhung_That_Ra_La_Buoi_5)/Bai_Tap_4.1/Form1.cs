using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_4._1
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
                if (PhuongThuc.KiemTraSNT(n))
                    txtKT.Text = n + " là số nguyên tố";
                else
                    txtKT.Text = n + "không phải số nguyên tố";

                if (n < 2)
                    txtLK.Text = "Không có số nguyên tốt nào bé hơn n";
                else
                {
                    txtLK.Text = "Các số nguyên tố bé hơn n là: ";
                    string kq = null;
                    for(int i = 2; i < n; i++)
                    {
                        if (PhuongThuc.KiemTraSNT(i))
                            kq = kq + (" " + i);
                    }
                    txtLK.Text += kq; 
                }    
            }
            else if(txtN.Text != "")
            {
                MessageBox.Show("Bạn phải nhập n và nhập n là số", "Thông báo");
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
            txtLK.Text = "";
            txtKT.Text = "";
        }
    }
}
