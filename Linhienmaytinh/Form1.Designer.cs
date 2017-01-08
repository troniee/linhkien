namespace Linhienmaytinh
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
            this.bt_banhang = new System.Windows.Forms.Button();
            this.bt_thongke = new System.Windows.Forms.Button();
            this.bt_them = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_banhang
            // 
            this.bt_banhang.Location = new System.Drawing.Point(133, 12);
            this.bt_banhang.Name = "bt_banhang";
            this.bt_banhang.Size = new System.Drawing.Size(87, 42);
            this.bt_banhang.TabIndex = 1;
            this.bt_banhang.Text = "Bán hàng";
            this.bt_banhang.UseVisualStyleBackColor = true;
            this.bt_banhang.Click += new System.EventHandler(this.bt_banhang_Click);
            // 
            // bt_thongke
            // 
            this.bt_thongke.Location = new System.Drawing.Point(254, 12);
            this.bt_thongke.Name = "bt_thongke";
            this.bt_thongke.Size = new System.Drawing.Size(87, 42);
            this.bt_thongke.TabIndex = 2;
            this.bt_thongke.Text = "Thống kê";
            this.bt_thongke.UseVisualStyleBackColor = true;
            this.bt_thongke.Click += new System.EventHandler(this.bt_thongke_Click);
            // 
            // bt_them
            // 
            this.bt_them.Location = new System.Drawing.Point(12, 12);
            this.bt_them.Name = "bt_them";
            this.bt_them.Size = new System.Drawing.Size(87, 42);
            this.bt_them.TabIndex = 3;
            this.bt_them.Text = "Thêm hàng";
            this.bt_them.UseVisualStyleBackColor = true;
            this.bt_them.Click += new System.EventHandler(this.bt_themlk_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 64);
            this.Controls.Add(this.bt_them);
            this.Controls.Add(this.bt_thongke);
            this.Controls.Add(this.bt_banhang);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu chính";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_banhang;
        private System.Windows.Forms.Button bt_thongke;
        private System.Windows.Forms.Button bt_them;
    }
}

