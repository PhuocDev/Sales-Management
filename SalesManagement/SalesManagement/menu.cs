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
    public partial class menu : Form
    {
        public menu()
        {
            InitializeComponent();
        }

        private void button_SanPham_Click(object sender, EventArgs e)
        {
            sanPham sp = new sanPham();
            sp.FormClosed += new FormClosedEventHandler(SanPham_FormClose);
            sp.Show();
            this.Hide();
        }
        private void SanPham_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button_nhanVien_Click(object sender, EventArgs e)
        {
            FormNhanVien nv = new FormNhanVien();
            nv.FormClosed += new FormClosedEventHandler(NhanVien_FormClose);
            nv.Show();
            this.Hide();
        }

        private void NhanVien_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button_QLD_Click(object sender, EventArgs e)
        {
            FormHoaDon hd = new FormHoaDon();
            hd.FormClosed += new FormClosedEventHandler(HoaDon_FormClose);
            hd.Show();
            this.Hide();
        }
        private void HoaDon_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void button_TKTC_Click(object sender, EventArgs e)
        {
            ThongKe tk = new ThongKe();
            tk.FormClosed += new FormClosedEventHandler(ThongKe_FormClose);
            tk.Show();
            this.Hide();
        }
        private void ThongKe_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            button_QLD.PerformClick();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            button_SanPham.PerformClick();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            button_TKTC.PerformClick();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            button_nhanVien.PerformClick();
        }
    }
}
