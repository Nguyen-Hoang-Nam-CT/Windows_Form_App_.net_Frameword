namespace Bai_Tap_5_2
{
    partial class frm5_2
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
            this.txtTen = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radLopB = new System.Windows.Forms.RadioButton();
            this.radLopA = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lstLopA = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lstLopB = new System.Windows.Forms.ListBox();
            this.btnTongSo = new System.Windows.Forms.Button();
            this.btnnhieutrai = new System.Windows.Forms.Button();
            this.btnnhieuphai = new System.Windows.Forms.Button();
            this.btntrai = new System.Windows.Forms.Button();
            this.btnphai = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Họ tên";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(78, 31);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(299, 20);
            this.txtTen.TabIndex = 1;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(394, 29);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(97, 23);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radLopB);
            this.groupBox1.Controls.Add(this.radLopA);
            this.groupBox1.Location = new System.Drawing.Point(133, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 64);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Chọn lớp";
            // 
            // radLopB
            // 
            this.radLopB.AutoSize = true;
            this.radLopB.Location = new System.Drawing.Point(115, 23);
            this.radLopB.Name = "radLopB";
            this.radLopB.Size = new System.Drawing.Size(53, 17);
            this.radLopB.TabIndex = 0;
            this.radLopB.TabStop = true;
            this.radLopB.Text = "Lớp B";
            this.radLopB.UseVisualStyleBackColor = true;
            // 
            // radLopA
            // 
            this.radLopA.AutoSize = true;
            this.radLopA.Location = new System.Drawing.Point(16, 24);
            this.radLopA.Name = "radLopA";
            this.radLopA.Size = new System.Drawing.Size(53, 17);
            this.radLopA.TabIndex = 0;
            this.radLopA.TabStop = true;
            this.radLopA.Text = "Lớp A";
            this.radLopA.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lstLopA);
            this.groupBox2.Location = new System.Drawing.Point(8, 154);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 159);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Lớp A";
            // 
            // lstLopA
            // 
            this.lstLopA.FormattingEnabled = true;
            this.lstLopA.Location = new System.Drawing.Point(10, 17);
            this.lstLopA.Name = "lstLopA";
            this.lstLopA.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lstLopA.Size = new System.Drawing.Size(184, 134);
            this.lstLopA.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lstLopB);
            this.groupBox3.Location = new System.Drawing.Point(321, 154);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 159);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Lớp B";
            // 
            // lstLopB
            // 
            this.lstLopB.FormattingEnabled = true;
            this.lstLopB.Location = new System.Drawing.Point(8, 17);
            this.lstLopB.Name = "lstLopB";
            this.lstLopB.Size = new System.Drawing.Size(184, 134);
            this.lstLopB.TabIndex = 0;
            // 
            // btnTongSo
            // 
            this.btnTongSo.Location = new System.Drawing.Point(55, 335);
            this.btnTongSo.Name = "btnTongSo";
            this.btnTongSo.Size = new System.Drawing.Size(115, 23);
            this.btnTongSo.TabIndex = 2;
            this.btnTongSo.Text = "Tổng số sinh viên";
            this.btnTongSo.UseVisualStyleBackColor = true;
            this.btnTongSo.Click += new System.EventHandler(this.btnTongSo_Click);
            // 
            // btnnhieutrai
            // 
            this.btnnhieutrai.Location = new System.Drawing.Point(227, 280);
            this.btnnhieutrai.Name = "btnnhieutrai";
            this.btnnhieutrai.Size = new System.Drawing.Size(75, 23);
            this.btnnhieutrai.TabIndex = 2;
            this.btnnhieutrai.Text = "<<";
            this.btnnhieutrai.UseVisualStyleBackColor = true;
            this.btnnhieutrai.Click += new System.EventHandler(this.btnnhieutrai_Click);
            // 
            // btnnhieuphai
            // 
            this.btnnhieuphai.Location = new System.Drawing.Point(227, 244);
            this.btnnhieuphai.Name = "btnnhieuphai";
            this.btnnhieuphai.Size = new System.Drawing.Size(75, 23);
            this.btnnhieuphai.TabIndex = 2;
            this.btnnhieuphai.Text = ">>";
            this.btnnhieuphai.UseVisualStyleBackColor = true;
            this.btnnhieuphai.Click += new System.EventHandler(this.btnnhieuphai_Click);
            // 
            // btntrai
            // 
            this.btntrai.Location = new System.Drawing.Point(227, 208);
            this.btntrai.Name = "btntrai";
            this.btntrai.Size = new System.Drawing.Size(75, 23);
            this.btntrai.TabIndex = 2;
            this.btntrai.Text = "<";
            this.btntrai.UseVisualStyleBackColor = true;
            this.btntrai.Click += new System.EventHandler(this.btntrai_Click);
            // 
            // btnphai
            // 
            this.btnphai.Location = new System.Drawing.Point(227, 172);
            this.btnphai.Name = "btnphai";
            this.btnphai.Size = new System.Drawing.Size(75, 23);
            this.btnphai.TabIndex = 2;
            this.btnphai.Text = ">";
            this.btnphai.UseVisualStyleBackColor = true;
            this.btnphai.Click += new System.EventHandler(this.btnphai_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(321, 335);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(115, 23);
            this.btnthoat.TabIndex = 4;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // frm5_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 387);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnphai);
            this.Controls.Add(this.btntrai);
            this.Controls.Add(this.btnnhieuphai);
            this.Controls.Add(this.btnnhieutrai);
            this.Controls.Add(this.btnTongSo);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label1);
            this.Name = "frm5_2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Danh sách sanh diên nghèo lười học";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frm5_2_FormClosing);
            this.Load += new System.EventHandler(this.frm5_2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radLopB;
        private System.Windows.Forms.RadioButton radLopA;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTongSo;
        private System.Windows.Forms.Button btnnhieutrai;
        private System.Windows.Forms.Button btnnhieuphai;
        private System.Windows.Forms.Button btntrai;
        private System.Windows.Forms.Button btnphai;
        private System.Windows.Forms.ListBox lstLopA;
        private System.Windows.Forms.ListBox lstLopB;
        private System.Windows.Forms.Button btnthoat;
    }
}