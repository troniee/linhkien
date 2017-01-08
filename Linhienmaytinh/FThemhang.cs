using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linhienmaytinh
{
    public partial class FThemhang : Form
    {
        public FThemhang()
        {
            InitializeComponent();
        }

        public int RandomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        private void cbb_chon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_chon.Text == "Thêm máy tính")
                groupBox1.Enabled = true;
            else groupBox1.Enabled = false;
        }

        private void bt_huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_them_Click(object sender, EventArgs e)
        {
            ConnectData con = new ConnectData();
            SqlConnection conn = new SqlConnection();
            conn = con._CreateConnect();

            if (cbb_chon.Text == "")
                MessageBox.Show("Chưa chọn loại chức năng thêm !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (cbb_chon.Text == "Thêm máy tính")
            {

                StringBuilder builder = new StringBuilder();
                builder.Append(RandomNumber(0, 9999));

                string sql = "insert into TBLMAYTINH(MAMAY, TENMAY, DONGIA, GHICHU, TINHTRANG) VALUES('MT" + builder.ToString() + "',N'" + txt_ten.Text + "'," + txt_dongia.Text + ",N'" + txt_ghichu.Text + "',1)";
                string sql2 = "insert into TBLCAUHINH(MAMAY, HANG,CPU ,GPU ,RAM ,HARDDISK) values('MT" + builder.ToString() + "',N'" + cbb_hang.Text + "',N'" + txt_CPU.Text + "',N'" + txt_GPU.Text + "',N'" + cbb_ram.Text + "',N'" + txt_hardisk.Text + "')";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlCommand cmd2 = new SqlCommand(sql2, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                cmd2.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm máy tính thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (cbb_chon.Text == "Thêm linh kiện")
            {
                StringBuilder builder = new StringBuilder();
                builder.Append(RandomNumber(0, 9999));

                string sql = "insert into TBLLINHKIEN(MALK, TENLK, DONGIA, GHICHU, TINHTRANG) VALUES('LK" + builder.ToString() + "',N'" + txt_ten.Text + "'," + txt_dongia.Text + ",N'" + txt_ghichu.Text + "',1)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thêm linh kiện thành công !!!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else MessageBox.Show("Chọn sai chức năng !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void FThemhang_Load(object sender, EventArgs e)
        {

        }
    }
}
