namespace Linhienmaytinh
{
    partial class FThemhang
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
            this.bt_huy = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.txt_dongia = new System.Windows.Forms.TextBox();
            this.txt_ten = new System.Windows.Forms.TextBox();
            this.cbb_chon = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_hardisk = new System.Windows.Forms.TextBox();
            this.cbb_ram = new System.Windows.Forms.ComboBox();
            this.txt_GPU = new System.Windows.Forms.TextBox();
            this.txt_CPU = new System.Windows.Forms.TextBox();
            this.cbb_hang = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_ghichu = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt_huy
            // 
            this.bt_huy.Location = new System.Drawing.Point(227, 444);
            this.bt_huy.Name = "bt_huy";
            this.bt_huy.Size = new System.Drawing.Size(78, 36);
            this.bt_huy.TabIndex = 23;
            this.bt_huy.Text = "Hủy";
            this.bt_huy.UseVisualStyleBackColor = true;
            this.bt_huy.Click += new System.EventHandler(this.bt_huy_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(74, 443);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(75, 37);
            this.bt_them.TabIndex = 22;
            this.bt_them.Text = "Thêm";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_them_Click);
            // 
            // txt_dongia
            // 
            this.txt_dongia.Location = new System.Drawing.Point(88, 64);
            this.txt_dongia.Name = "txt_dongia";
            this.txt_dongia.Size = new System.Drawing.Size(155, 20);
            this.txt_dongia.TabIndex = 19;
            // 
            // txt_ten
            // 
            this.txt_ten.Location = new System.Drawing.Point(88, 37);
            this.txt_ten.Name = "txt_ten";
            this.txt_ten.Size = new System.Drawing.Size(155, 20);
            this.txt_ten.TabIndex = 18;
            // 
            // cbb_chon
            // 
            this.cbb_chon.FormattingEnabled = true;
            this.cbb_chon.Items.AddRange(new object[] {
            "Thêm máy tính",
            "Thêm linh kiện"});
            this.cbb_chon.Location = new System.Drawing.Point(88, 8);
            this.cbb_chon.Name = "cbb_chon";
            this.cbb_chon.Size = new System.Drawing.Size(198, 21);
            this.cbb_chon.TabIndex = 17;
            this.cbb_chon.SelectedIndexChanged += new System.EventHandler(this.cbb_chon_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_hardisk);
            this.groupBox1.Controls.Add(this.cbb_ram);
            this.groupBox1.Controls.Add(this.txt_GPU);
            this.groupBox1.Controls.Add(this.txt_CPU);
            this.groupBox1.Controls.Add(this.cbb_hang);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(13, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 154);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông số máy tính";
            // 
            // txt_hardisk
            // 
            this.txt_hardisk.Location = new System.Drawing.Point(75, 123);
            this.txt_hardisk.Name = "txt_hardisk";
            this.txt_hardisk.Size = new System.Drawing.Size(146, 20);
            this.txt_hardisk.TabIndex = 9;
            // 
            // cbb_ram
            // 
            this.cbb_ram.FormattingEnabled = true;
            this.cbb_ram.Items.AddRange(new object[] {
            "2 Gb",
            "4 Gb",
            "8 Gb",
            "16 Gb",
            "32 Gb"});
            this.cbb_ram.Location = new System.Drawing.Point(75, 97);
            this.cbb_ram.Name = "cbb_ram";
            this.cbb_ram.Size = new System.Drawing.Size(121, 21);
            this.cbb_ram.TabIndex = 8;
            // 
            // txt_GPU
            // 
            this.txt_GPU.Location = new System.Drawing.Point(75, 70);
            this.txt_GPU.Name = "txt_GPU";
            this.txt_GPU.Size = new System.Drawing.Size(146, 20);
            this.txt_GPU.TabIndex = 7;
            // 
            // txt_CPU
            // 
            this.txt_CPU.Location = new System.Drawing.Point(75, 43);
            this.txt_CPU.Name = "txt_CPU";
            this.txt_CPU.Size = new System.Drawing.Size(103, 20);
            this.txt_CPU.TabIndex = 6;
            // 
            // cbb_hang
            // 
            this.cbb_hang.FormattingEnabled = true;
            this.cbb_hang.Items.AddRange(new object[] {
            "ASUS",
            "HP",
            "MAC",
            "DELL"});
            this.cbb_hang.Location = new System.Drawing.Point(75, 17);
            this.cbb_hang.Name = "cbb_hang";
            this.cbb_hang.Size = new System.Drawing.Size(75, 21);
            this.cbb_hang.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 126);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Ổ cứng: ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 100);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "RAM: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "GPU: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "CPU: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Hãng: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ghi chú: ";
            // 
            // txt_ghichu
            // 
            this.txt_ghichu.Location = new System.Drawing.Point(74, 121);
            this.txt_ghichu.Multiline = true;
            this.txt_ghichu.Name = "txt_ghichu";
            this.txt_ghichu.Size = new System.Drawing.Size(317, 146);
            this.txt_ghichu.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tên hàng: ";
            // 
            // FThemhang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 486);
            this.Controls.Add(this.bt_huy);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.txt_dongia);
            this.Controls.Add(this.txt_ten);
            this.Controls.Add(this.cbb_chon);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_ghichu);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "FThemhang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FThemhang";
            this.Load += new System.EventHandler(this.FThemhang_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_huy;
        private System.Windows.Forms.Button bt_them;
        private System.Windows.Forms.TextBox txt_dongia;
        private System.Windows.Forms.TextBox txt_ten;
        private System.Windows.Forms.ComboBox cbb_chon;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_hardisk;
        private System.Windows.Forms.ComboBox cbb_ram;
        private System.Windows.Forms.TextBox txt_GPU;
        private System.Windows.Forms.TextBox txt_CPU;
        private System.Windows.Forms.ComboBox cbb_hang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_ghichu;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}