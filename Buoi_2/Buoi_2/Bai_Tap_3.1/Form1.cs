using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai_Tap_3._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            if (x >= 2)
            {
                textBox2.Text = (-8*x*x*x - 12*x - 1).ToString();
            }
            else if(x > 1 && x <2)
            {
                textBox2.Text = (x*x - 6*x - 19).ToString();
            }   
            else
            {
                textBox2.Text = (7*x).ToString();
            }    
        }
    }
}
