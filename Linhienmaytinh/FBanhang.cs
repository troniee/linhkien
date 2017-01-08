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
    public partial class FBanhang : Form
    {
        public FBanhang()
        {
            InitializeComponent();
        }

        ConnectData con = new ConnectData();
        SqlConnection conn = new SqlConnection();
        public int tienmay = 0;
        public int tienlk = 0;


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


        private void FBanhang_Load(object sender, EventArgs e)
        {
            bt_xoa.Hide();
            bt_tinh.Hide();
            conn = con._CreateConnect();
            lb_ngay.Text = DateTime.Now.ToString("MM/dd/yyyy");
        }

        private void bt_tao_Click(object sender, EventArgs e)
        {
            StringBuilder builder = new StringBuilder();
            builder.Append(RandomNumber(0, 9999));
            txt_sohd.Text = builder.ToString();
            groupBox1.Enabled = true;
            bt_xoa.Show();
            bt_xoa.Enabled = true;
            bt_tao.Hide();
            bt_tinh.Show();

            string sql = "insert into TBLHOADON (SOHD, NGAYMUA) values (" + txt_sohd.Text + ",'"+lb_ngay.Text+"')";
            SqlCommand cmd = new SqlCommand(sql,conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();

        }

        private void ct_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bt_xoa_Click(object sender, EventArgs e)
        {
            string sql = "delete from TBLHOADON where SOHD = "+txt_sohd.Text+"";
            SqlCommand cmd = new SqlCommand(sql,conn);

            string sql2 = "delete from TBL_CTHD where SOHD = "+txt_sohd.Text+"";
            SqlCommand cmd2 = new SqlCommand(sql2,conn);

            conn.Open();
            cmd.ExecuteNonQuery();
            cmd2.ExecuteNonQuery();
            conn.Close();
            bt_tao.Show();
            bt_xoa.Hide();
        }

        private void bt_tinh_Click(object sender, EventArgs e)
        {
            ConnectData con = new ConnectData();
            String kt = "select MAHNANG from TBL_CTHD where sohd = "+txt_sohd.Text+" and MAHNANG like 'lk%'";
            DataTable dt = con.Getdatatable(kt);

            String kt2 = "select MAHNANG from TBL_CTHD where sohd = " + txt_sohd.Text + " and MAHNANG like 'mt%'";
            DataTable dt2 = con.Getdatatable(kt2);
            if (dt.Rows.Count > 0)
            {
                string sql2 = "select sum((SOLUONG*lk.DONGIA)) as tienlk " +
                               " from TBL_CTHD ct, TBLLINHKIEN lk, TBLHOADON hd " +
                               " where ct.MAHNANG = lk.MALK and ct.SOHD = hd.SOHD and ct.SOHD =  " + txt_sohd.Text;
                tienlk = con.GetScalar(sql2);

            }
            if(dt2.Rows.Count >0)
            {
                string sql = "select sum((SOLUONG*mt.DONGIA)) as tienmay " +
                               " from TBL_CTHD ct, TBLMAYTINH mt, TBLHOADON hd " +
                               " where ct.MAHNANG = mt.MAMAY and ct.SOHD = hd.SOHD and ct.SOHD = " + txt_sohd.Text;
                tienmay = con.GetScalar(sql);
            }






            txt_thanhtien.Text = (tienlk + tienmay).ToString();
            string sql3 = "select MAHNANG as [Mã mặt hàng], SOLUONG as [Số lượng mua]  from TBL_CTHD where sohd=" + txt_sohd.Text;
            dataGridView1.DataSource = con.Getdatatable(sql3);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sql = "insert into TBL_CTHD(SOHD, MAHNANG,SOLUONG) values("+txt_sohd.Text+",'"+cbb_masp.Text+"',"+cbb_sl.Text+")";
            SqlCommand cmd = new SqlCommand(sql, conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Thêm thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbb_chon_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_chon.Text == "Mua linh kiện")
            {
                DataTable dt = new DataTable();
                string sql = "select MALK, TENLK from TBLLINHKIEN ";
                ConnectData con = new ConnectData();
                dt = con.Getdatatable(sql);

                cbb_masp.DataSource = dt;
                cbb_masp.DisplayMember = "MALK";
                cbb_masp.ValueMember = "MALK";

                cbb_tensp.DataSource = dt;
                cbb_tensp.DisplayMember = "TENLK";
                cbb_tensp.ValueMember = "MALK";
            }
            else
            {
                DataTable dt = new DataTable();
                string sql = "select MAMAY, TENMAY from TBLMAYTINH ";
                ConnectData con = new ConnectData();
                dt = con.Getdatatable(sql);

                cbb_masp.DataSource = dt;
                cbb_masp.DisplayMember = "MAMAY";
                cbb_masp.ValueMember = "MAMAY";

                cbb_tensp.DataSource = dt;
                cbb_tensp.DisplayMember = "TENMAY";
                cbb_tensp.ValueMember = "MAMAY";
            }
        }

        private void bt_thanhtoan_Click(object sender, EventArgs e)
        {
            if (txt_ten.Text == "" || txt_diachi.Text == "" || txt_sdt.Text == "")
            {
                MessageBox.Show("Nhập thông tin chưa đầy đủ !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string sql = "update TBLHOADON set TENKHACH = '"+txt_ten.Text+"', DIACHI = '"+txt_diachi.Text+"', SDT = "+txt_sdt.Text+" , THANHTIEN = " + txt_thanhtien.Text + " where SOHD = " + txt_sohd.Text;
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thanh toán thành công !!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
