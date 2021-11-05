using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_4._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCong_Click(object sender, EventArgs e)
        {
            int t2 = PhuongThuc.LayGiaTri(txtTu2),
                m2 = PhuongThuc.LayGiaTri(txtMau2),
                m1 = PhuongThuc.LayGiaTri(txtMau1),
                t1 = PhuongThuc.LayGiaTri(txtTu1);
            if (t1 == int.MinValue || m1 == int.MinValue || t2 == int.MinValue || m2 == int.MinValue)
                return;
            //if (m1 == 0 || m2 == 0)
            //{
            //    if (m2 == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mẫu số khác 0");
            //        txtMau2.Text = "";
            //        txtMau2.Focus();
            //    }
            //    if (m1 == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mẫu số khác 0");
            //        txtMau1.Text = "";
            //        txtMau1.Focus();
            //    }
            //    return;
            //}
            int kqTu = t1 * m2 + t2 * m1,
                kqMau = m1 * m2;
            PhuongThuc.RutGon(ref kqTu,ref kqMau);
            txtTuKQ.Text = kqTu.ToString();
            txtMauKq.Text = kqMau.ToString();
        }

        private void btnTru_Click(object sender, EventArgs e)
        {
            int t2 = PhuongThuc.LayGiaTri(txtTu2),
                m2 = PhuongThuc.LayGiaTri(txtMau2),
                m1 = PhuongThuc.LayGiaTri(txtMau1),
                t1 = PhuongThuc.LayGiaTri(txtTu1);
            if (t1 == int.MinValue || m1 == int.MinValue || t2 == int.MinValue || m2 == int.MinValue)
                return;
            //if(m1 == 0 || m2 == 0)
            //{
            //    if (m2 == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mẫu số khác 0");
            //        txtMau2.Text = "";
            //        txtMau2.Focus();
            //    }
            //    if (m1 == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mẫu số khác 0");
            //        txtMau1.Text = "";
            //        txtMau1.Focus();
            //    }
            //    return;
            //}    
            int kqTu = t1 * m2 - t2 * m1,
                kqMau = m1 * m2;
            PhuongThuc.RutGon(ref kqTu, ref kqMau);
            txtTuKQ.Text = kqTu.ToString();
            txtMauKq.Text = kqMau.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            int t2 = PhuongThuc.LayGiaTri(txtTu2),
                m2 = PhuongThuc.LayGiaTri(txtMau2),
                m1 = PhuongThuc.LayGiaTri(txtMau1),
                t1 = PhuongThuc.LayGiaTri(txtTu1);
            if (t1 == int.MinValue || m1 == int.MinValue || t2 == int.MinValue || m2 == int.MinValue)
                return;
            //if (m1 == 0 || m2 == 0)
            //{
            //    if (m2 == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mẫu số khác 0");
            //        txtMau2.Text = "";
            //        txtMau2.Focus();
            //    }
            //    if (m1 == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mẫu số khác 0");
            //        txtMau1.Text = "";
            //        txtMau1.Focus();
            //    }
            //    return;
            //}
            int kqTu = t1 * t2,
                kqMau = m1 * m2;
            PhuongThuc.RutGon(ref kqTu, ref kqMau);
            txtTuKQ.Text = kqTu.ToString();
            txtMauKq.Text = kqMau.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            int t2 = PhuongThuc.LayGiaTri(txtTu2),
                m2 = PhuongThuc.LayGiaTri(txtMau2),
                m1 = PhuongThuc.LayGiaTri(txtMau1),
                t1 = PhuongThuc.LayGiaTri(txtTu1);
            if (t1 == int.MinValue || m1 == int.MinValue || t2 == int.MinValue || m2 == int.MinValue)
                return;
            //if (m1 == 0 || m2 == 0)
            //{
            //    if (m2 == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mẫu số khác 0");
            //        txtMau2.Text = "";
            //        txtMau2.Focus();
            //    }
            //    if (m1 == 0)
            //    {
            //        MessageBox.Show("Bạn phải nhập mẫu số khác 0");
            //        txtMau1.Text = "";
            //        txtMau1.Focus();
            //    }
            //    return;
            //}
            int kqTu = t1 * m2,
                kqMau = m1 * t2;
            PhuongThuc.RutGon(ref kqTu, ref kqMau);
            txtTuKQ.Text = kqTu.ToString();
            txtMauKq.Text = kqMau.ToString();
        }

        private void txtMau1_TextChanged(object sender, EventArgs e)
        {
            int mau1;
            if (txtMau1.Text != "")
                mau1 = int.Parse(txtMau1.Text);
            else
                return;
            if(mau1 == 0 && txtMau1.Text != "")
            {
                MessageBox.Show("Bạn phải nhập mẫu của phân số 1 khác 0");
                txtMau1.Text = "";
                txtMau1.Focus();
            }    
        }

        private void txtMau2_TextChanged(object sender, EventArgs e)
        {
            int mau2;
            if (txtMau2.Text != "")
                mau2 = Convert.ToInt32(txtMau1.Text);
            else
                return;
            if (int.Parse(txtMau2.Text) == 0 && txtMau2.Text != "")
            {
                MessageBox.Show("Bạn phải nhập mẫu của phân số 2 khác 0");
                txtMau2.Text = "";
                txtMau2.Focus();
            }
        }
    }
}
