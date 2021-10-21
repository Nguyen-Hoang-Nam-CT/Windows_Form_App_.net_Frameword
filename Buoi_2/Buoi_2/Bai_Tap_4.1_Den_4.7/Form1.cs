using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_4._1_Den_4._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);
            int sum = 0;
            for(int i = 1; i <= n; i++)
                sum += i;
            txt2.Text = sum.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);
            long sum = 0;
            for (int i = 1; i <= n; i++)
                sum += i * i;
            txt2.Text = sum.ToString();
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum += 1 / (double)i;
            txt2.Text = sum.ToString();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);
            long sum = 0;
            for (int i = 1; i <= n; i++)
                sum += 2 * i - 1;
            txt2.Text = sum.ToString();
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);
            long sum = 0;
            for (int i = 1; i <= n; i++)
                sum += 2 * i - 2;
            txt2.Text = sum.ToString();
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);
            double sum = 0;
            for (int i = 1; i <= n; i++)
                sum += 1 / (double)(2 * i - 1);
            txt2.Text = sum.ToString();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txt1.Text);
            long sum = 1;
            for (int i = 2; i <= n; i++)
                sum *= i;
            txt2.Text = sum.ToString();
        }
    }
}
