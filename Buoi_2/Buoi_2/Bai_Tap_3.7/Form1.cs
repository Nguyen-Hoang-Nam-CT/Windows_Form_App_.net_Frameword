using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_3._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTong_Click(object sender, EventArgs e)
        {
            double a = double.Parse(txt1.Text), b = double.Parse(txt2.Text), c = double.Parse(txt3.Text);
            double denta = b*b - 4*a*c;
            if (denta < 0)
                txt4.Text = "Phương trình vô nghiệm";
            else if(denta == 0)
            {
                txt4.Text = "x1 = x2 = " + (-b / 2 * a).ToString();
            }    
            else
            {
                double x1 = (-b + Math.Sqrt(denta)) / (2 * a),
                    x2 = (-b - Math.Sqrt(denta)) / (2 * a);
                txt4.Text = "x1 = " + x1.ToString() + ", x2 = " + x2.ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
