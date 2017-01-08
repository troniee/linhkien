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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*10.    Viết chương trình quản lý bán máy tính và linh kiện, chương trình có các chức năng sau:
                     a.    Nhập vào danh sách những món hàng: máy tính và các linh kiện…với các thông tin chi tiết và giá tiền tương ứng.
                     b.    Bán hàng: tính tiền cho một hóa đơn bán hàng…
                     c.    Thống kê các mặt hàng được bán nhiều, hóa đơn có giá trị cao…
             */
        }


        private void bt_themlk_Click(object sender, EventArgs e)
        {
            FThemhang fth = new FThemhang();
            fth.Show();
        }

        private void bt_banhang_Click(object sender, EventArgs e)
        {
            FBanhang fbh = new FBanhang();
            fbh.Show();
        }

        private void bt_thongke_Click(object sender, EventArgs e)
        {
            FThongke ftk = new FThongke();
            ftk.Show();
        }
    }
}
