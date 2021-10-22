
namespace Bai_Tap_7
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tínhToánToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tổngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.hiệuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tíchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thươngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKQ = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tínhToánToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 38);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tínhToánToolStripMenuItem
            // 
            this.tínhToánToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tổngToolStripMenuItem,
            this.hiệuToolStripMenuItem,
            this.tíchToolStripMenuItem,
            this.thươngToolStripMenuItem});
            this.tínhToánToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tínhToánToolStripMenuItem.Name = "tínhToánToolStripMenuItem";
            this.tínhToánToolStripMenuItem.Size = new System.Drawing.Size(115, 34);
            this.tínhToánToolStripMenuItem.Text = "Tính Toán";
            // 
            // tổngToolStripMenuItem
            // 
            this.tổngToolStripMenuItem.Name = "tổngToolStripMenuItem";
            this.tổngToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.tổngToolStripMenuItem.Text = "Tổng";
            this.tổngToolStripMenuItem.Click += new System.EventHandler(this.tổngToolStripMenuItem_Click);
            // 
            // hiệuToolStripMenuItem
            // 
            this.hiệuToolStripMenuItem.Name = "hiệuToolStripMenuItem";
            this.hiệuToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.hiệuToolStripMenuItem.Text = "Hiệu";
            this.hiệuToolStripMenuItem.Click += new System.EventHandler(this.hiệuToolStripMenuItem_Click);
            // 
            // tíchToolStripMenuItem
            // 
            this.tíchToolStripMenuItem.Name = "tíchToolStripMenuItem";
            this.tíchToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.tíchToolStripMenuItem.Text = "Tích";
            this.tíchToolStripMenuItem.Click += new System.EventHandler(this.tíchToolStripMenuItem_Click);
            // 
            // thươngToolStripMenuItem
            // 
            this.thươngToolStripMenuItem.Name = "thươngToolStripMenuItem";
            this.thươngToolStripMenuItem.Size = new System.Drawing.Size(180, 34);
            this.thươngToolStripMenuItem.Text = "Thương";
            this.thươngToolStripMenuItem.Click += new System.EventHandler(this.thươngToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Phép toán đơn giản";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(214, 378);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kết quả";
            // 
            // txtKQ
            // 
            this.txtKQ.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKQ.Location = new System.Drawing.Point(306, 375);
            this.txtKQ.Name = "txtKQ";
            this.txtKQ.Size = new System.Drawing.Size(275, 31);
            this.txtKQ.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtb);
            this.groupBox1.Controls.Add(this.txta);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(219, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(362, 207);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "a";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 25);
            this.label4.TabIndex = 1;
            this.label4.Text = "b";
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(47, 53);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(283, 31);
            this.txta.TabIndex = 2;
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(47, 120);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(283, 31);
            this.txtb.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKQ);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tínhToánToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tổngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem hiệuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tíchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thươngToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKQ;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
    }
}

