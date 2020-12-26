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
        public changeform change;
        public menu(changeform change)
        {
            InitializeComponent();
            this.change = change;
        }
        //-------------------------------------------------------------------------------------------------------------------------//
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

        //---------------------------------------------------------------------------------------------------------------------------//

        private void button_nhanVien_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang();
            kh.FormClosed += new FormClosedEventHandler(KhachHang_FormClose);
            kh.Show();
            this.Hide();
        }

        private void KhachHang_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        //------------------------------------------------------------------------------------------------------------------------------//

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

        //--------------------------------------------------------------------------------------------------------------------------------//
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

        //---------------------------------------------------------------------------------------------------------------------------------//
        private void menu_Load(object sender, EventArgs e)
        {
            if(Login.Current_user.ID.Substring(0,2) == "NV")
            {
                this.label_nv_kh.Text = "Khách hàng";
                this.button_nv_kh2.Text = "Khách hàng";
            }
            this.label_tenDangNhap.Text = Login.Current_user.NAME;
        }
        //---------------------------------------------------thoát-chương-trình-------------------------------------------------------------//
        private void button_thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //---------------------------------------------------đăng-xuất -------------------------------------------------------------------------//
        public void button_dangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn đăng xuất không", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(result == DialogResult.Yes)
            {
                this.Hide();
                this.change();
               
            }
        }
        //-------------------------------------------------------button phụ click----------------------------------------------------------------//
        private void button_bh2_Click(object sender, EventArgs e)
        {
            button_QLD.PerformClick();
        }

        private void button_sp2_Click(object sender, EventArgs e)
        {
            button_SanPham.PerformClick();
        }

        private void button_nv_kh2_Click(object sender, EventArgs e)
        {
            button_nhanVien.PerformClick();
        }

        private void button_tk2_Click(object sender, EventArgs e)
        {
            button_TKTC.PerformClick();
        }

        //-----------------------------------------------------------------label-click-------------------------------------------------------------//

        private void label_bh_Click(object sender, EventArgs e)
        {
            button_QLD.PerformClick();
        }

        private void label_sp_Click(object sender, EventArgs e)
        {
            button_SanPham.PerformClick();
        }

        private void label_tk_Click(object sender, EventArgs e)
        {
            button_TKTC.PerformClick();
        }

        private void label_nv_kh_Click(object sender, EventArgs e)
        {
            button_nhanVien.PerformClick();
        }
        //----------------------------------------------------------------đổi_mật_khẩu--------------------------------------------------------------------//
        private void button_doiMK_Click(object sender, EventArgs e)
        {
            DoiMK doimk = new DoiMK();
            doimk.ShowDialog();
            if(doimk.check == 1)
            {
                button_dangXuat.PerformClick();
            }
        }
        //-----------------------------------------------------------------form_closing--------------------------------------------------------------------//
        private void menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát chương trình", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void button_taiKhoan_Click(object sender, EventArgs e)
        {
            thongTinCaNhan thongTinCaNhan = new thongTinCaNhan();
            thongTinCaNhan.Show();
        }
    }
}
