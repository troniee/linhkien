namespace Linhienmaytinh
{
    partial class FThongke
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_lk = new System.Windows.Forms.Button();
            this.bt_mt = new System.Windows.Forms.Button();
            this.bt_hd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(131, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(261, 242);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_lk
            // 
            this.bt_lk.Location = new System.Drawing.Point(12, 37);
            this.bt_lk.Name = "bt_lk";
            this.bt_lk.Size = new System.Drawing.Size(113, 37);
            this.bt_lk.TabIndex = 1;
            this.bt_lk.Text = "Linh kiện bán nhiều";
            this.bt_lk.UseVisualStyleBackColor = true;
            this.bt_lk.Click += new System.EventHandler(this.bt_lk_Click);
            // 
            // bt_mt
            // 
            this.bt_mt.Location = new System.Drawing.Point(12, 92);
            this.bt_mt.Name = "bt_mt";
            this.bt_mt.Size = new System.Drawing.Size(113, 37);
            this.bt_mt.TabIndex = 2;
            this.bt_mt.Text = "Máy tính bán nhiều";
            this.bt_mt.UseVisualStyleBackColor = true;
            this.bt_mt.Click += new System.EventHandler(this.bt_mt_Click);
            // 
            // bt_hd
            // 
            this.bt_hd.Location = new System.Drawing.Point(12, 151);
            this.bt_hd.Name = "bt_hd";
            this.bt_hd.Size = new System.Drawing.Size(113, 37);
            this.bt_hd.TabIndex = 3;
            this.bt_hd.Text = "Hóa đơn giá trị cao";
            this.bt_hd.UseVisualStyleBackColor = true;
            this.bt_hd.Click += new System.EventHandler(this.bt_hd_Click);
            // 
            // FThongke
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 266);
            this.Controls.Add(this.bt_hd);
            this.Controls.Add(this.bt_mt);
            this.Controls.Add(this.bt_lk);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FThongke";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.FThongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_lk;
        private System.Windows.Forms.Button bt_mt;
        private System.Windows.Forms.Button bt_hd;
    }
}