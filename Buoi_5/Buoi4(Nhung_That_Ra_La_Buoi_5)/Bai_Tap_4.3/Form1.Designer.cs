
namespace Bai_Tap_4._3
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtMau1 = new System.Windows.Forms.TextBox();
            this.txtTu1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnChia = new System.Windows.Forms.Button();
            this.btnNhan = new System.Windows.Forms.Button();
            this.btnTru = new System.Windows.Forms.Button();
            this.btnCong = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMau2 = new System.Windows.Forms.TextBox();
            this.txtTu2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtMauKq = new System.Windows.Forms.TextBox();
            this.txtTuKQ = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(307, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phép tính phân số";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtMau1);
            this.groupBox1.Controls.Add(this.txtTu1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(65, 74);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(294, 136);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phân số 1";
            // 
            // txtMau1
            // 
            this.txtMau1.Location = new System.Drawing.Point(74, 89);
            this.txtMau1.Name = "txtMau1";
            this.txtMau1.Size = new System.Drawing.Size(188, 20);
            this.txtMau1.TabIndex = 3;
            this.txtMau1.TextChanged += new System.EventHandler(this.txtMau1_TextChanged);
            // 
            // txtTu1
            // 
            this.txtTu1.Location = new System.Drawing.Point(74, 27);
            this.txtTu1.Name = "txtTu1";
            this.txtTu1.Size = new System.Drawing.Size(188, 20);
            this.txtTu1.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Mẫu số";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tử số";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnChia);
            this.groupBox4.Controls.Add(this.btnNhan);
            this.groupBox4.Controls.Add(this.btnTru);
            this.groupBox4.Controls.Add(this.btnCong);
            this.groupBox4.Location = new System.Drawing.Point(65, 287);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(294, 136);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Phép tính";
            // 
            // btnChia
            // 
            this.btnChia.Location = new System.Drawing.Point(165, 80);
            this.btnChia.Name = "btnChia";
            this.btnChia.Size = new System.Drawing.Size(91, 35);
            this.btnChia.TabIndex = 3;
            this.btnChia.Text = "Chia";
            this.btnChia.UseVisualStyleBackColor = true;
            this.btnChia.Click += new System.EventHandler(this.btnChia_Click);
            // 
            // btnNhan
            // 
            this.btnNhan.Location = new System.Drawing.Point(39, 80);
            this.btnNhan.Name = "btnNhan";
            this.btnNhan.Size = new System.Drawing.Size(91, 35);
            this.btnNhan.TabIndex = 2;
            this.btnNhan.Text = "Nhân";
            this.btnNhan.UseVisualStyleBackColor = true;
            this.btnNhan.Click += new System.EventHandler(this.btnNhan_Click);
            // 
            // btnTru
            // 
            this.btnTru.Location = new System.Drawing.Point(165, 22);
            this.btnTru.Name = "btnTru";
            this.btnTru.Size = new System.Drawing.Size(91, 35);
            this.btnTru.TabIndex = 1;
            this.btnTru.Text = "Trừ";
            this.btnTru.UseVisualStyleBackColor = true;
            this.btnTru.Click += new System.EventHandler(this.btnTru_Click);
            // 
            // btnCong
            // 
            this.btnCong.Location = new System.Drawing.Point(39, 22);
            this.btnCong.Name = "btnCong";
            this.btnCong.Size = new System.Drawing.Size(91, 35);
            this.btnCong.TabIndex = 0;
            this.btnCong.Text = "Cộng";
            this.btnCong.UseVisualStyleBackColor = true;
            this.btnCong.Click += new System.EventHandler(this.btnCong_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMau2);
            this.groupBox2.Controls.Add(this.txtTu2);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(442, 74);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(294, 136);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Phân số 2";
            // 
            // txtMau2
            // 
            this.txtMau2.Location = new System.Drawing.Point(74, 89);
            this.txtMau2.Name = "txtMau2";
            this.txtMau2.Size = new System.Drawing.Size(188, 20);
            this.txtMau2.TabIndex = 3;
            this.txtMau2.TextChanged += new System.EventHandler(this.txtMau2_TextChanged);
            // 
            // txtTu2
            // 
            this.txtTu2.Location = new System.Drawing.Point(74, 27);
            this.txtTu2.Name = "txtTu2";
            this.txtTu2.Size = new System.Drawing.Size(188, 20);
            this.txtTu2.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Mẫu số";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tử số";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtMauKq);
            this.groupBox3.Controls.Add(this.txtTuKQ);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(442, 287);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(294, 136);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Phân số kết quả";
            // 
            // txtMauKq
            // 
            this.txtMauKq.Location = new System.Drawing.Point(74, 89);
            this.txtMauKq.Name = "txtMauKq";
            this.txtMauKq.Size = new System.Drawing.Size(188, 20);
            this.txtMauKq.TabIndex = 3;
            // 
            // txtTuKQ
            // 
            this.txtTuKQ.Location = new System.Drawing.Point(74, 27);
            this.txtTuKQ.Name = "txtTuKQ";
            this.txtTuKQ.Size = new System.Drawing.Size(188, 20);
            this.txtTuKQ.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Mẫu số";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Tử số";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtMau1;
        private System.Windows.Forms.TextBox txtTu1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnChia;
        private System.Windows.Forms.Button btnNhan;
        private System.Windows.Forms.Button btnTru;
        private System.Windows.Forms.Button btnCong;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMau2;
        private System.Windows.Forms.TextBox txtTu2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtMauKq;
        private System.Windows.Forms.TextBox txtTuKQ;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

