using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace Bai_Tap_5_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDoiFont_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            DialogResult temp = fontDialog.ShowDialog();
            if(temp == DialogResult.OK)
                txtnhap.Font = fontDialog.Font;
        }

        private void btnDoiMau_Click(object sender, EventArgs e)
        {
            ColorDialog colorDiaLog = new ColorDialog();
            if (colorDiaLog.ShowDialog() == DialogResult.OK)
                txtnhap.ForeColor = colorDiaLog.Color;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*
            để coi lại nè
            DialogResult a = MessageBox.Show("Do you want to exit?", "Câu hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(a == DialogResult.Cancel)
                e.Cancel = true;
             */
            //Nếu chọn cancel thì không thực hiện sự kiện này
            if (MessageBox.Show("Do you want to exit?", "Câu hỏi", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel)
                e.Cancel = true;
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Title = "Mở file";
            o.Filter = "File word(*.doc)|*.doc|File text(*.txt)|*.txt";
            if(o.ShowDialog() == DialogResult.OK)
            {
                StreamReader file = new StreamReader(o.FileName);
                txtnhap.Text = file.ReadToEnd();
                file.Close();
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            OpenFileDialog f = new OpenFileDialog();
            f.Filter = "File word(*.doc)|*.doc|File word dạng XML(*.docx)|*.docx|file text(*.txt)|*.txt|File PDF(*.PDF)|*.PDF";
            if (f.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(f.FileName); FileName là được link tới file
                StreamWriter file = new StreamWriter(f.FileName);
                file.Write(txtnhap.Text);
                file.Close();
            }
        }
    }
}