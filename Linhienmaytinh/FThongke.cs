using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Linhienmaytinh
{
    public partial class FThongke : Form
    {
        public FThongke()
        {
            InitializeComponent();
        }

        private void bt_lk_Click(object sender, EventArgs e)
        {
            ConnectData con = new ConnectData();
            dataGridView1.DataSource = con.Getdatatable("select TENLK as [Tên linh kiện], SUM(soluong) as [Tổng số lượng mua]  from TBL_CTHD ct, TBLLINHKIEN lk where ct.MAHNANG = lk.MALK group by TENLK having sum(soluong) >10");
        }

        private void bt_mt_Click(object sender, EventArgs e)
        {
            ConnectData con = new ConnectData();
            dataGridView1.DataSource = con.Getdatatable("select TENMAY as [Tên máy tính], SUM(soluong) as [Tổng số lượng mua]  from TBL_CTHD ct, TBLMAYTINH mt where ct.MAHNANG = mt.MAMAY group by TENMAY having sum(soluong) >5");
        }

        private void bt_hd_Click(object sender, EventArgs e)
        {

            ConnectData con = new ConnectData();
            dataGridView1.DataSource = con.Getdatatable("select SOHD, sum(thanhtien) as [Số tiền mua] from TBLHOADON  group by SOHD having sum(THANHTIEN) >100000");
        }

        private void FThongke_Load(object sender, EventArgs e)
        {

        }
    }
}
