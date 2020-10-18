using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class SanPham : Form
    {
        public SanPham()
        {
            InitializeComponent();
        }

        private void button_xuatFile_Click(object sender, EventArgs e)
        {

        }

        private void button_timKiem_Click(object sender, EventArgs e)
        {

        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_nhapHang_Click(object sender, EventArgs e)
        {
            NhapHang nh = new NhapHang(change);
            nh.FormClosed += new FormClosedEventHandler(NhapHang_FormClose);
            nh.Show();
            this.Hide();
        }
        private void NhapHang_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void change(){// được gọi khi click button menu của form Nhập hàng
            this.Close();
        }
        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_chinhSua_Click(object sender, EventArgs e)
        {
            ChinhSuaDSSP cs = new ChinhSuaDSSP();
            cs.ShowDialog();
        }
    }
}
