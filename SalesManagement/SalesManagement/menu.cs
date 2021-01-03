using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Runtime.InteropServices.WindowsRuntime;


namespace SalesManagement
{
    public partial class menu : Form
    {
        SqlConnection connection = new SqlConnection(global.conString);
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
            Update_Ten(Login.Current_user.ID);
            loadImg(Login.Current_user.ID);
        }
        //------------------ code cập nhật ảnh ----------------//
        private void loadImg(string id)
        {
            connection.Open();
            try
            {
                if (id.Substring(0, 2) == "NV")
                {
                    //load ảnh của nhân viên 
                    string sqlQuery2 = "select MANV, ISNULL(ANH, '" + globalPic.anhNVdefault + "') from NHANVIEN WHERE MANV = '" + id + "'";
                    SqlCommand command2 = new SqlCommand(sqlQuery2, connection);
                    SqlDataReader dataReader2 = command2.ExecuteReader();
                    while (dataReader2.HasRows)
                    {
                        if (dataReader2.Read() == false) break;
                        else
                            pictureBox_AnhNV.Image = ByteToImg(dataReader2.GetString(1));
                    }
                }
                else
                {
                    //load ảnh của quản lý
                    string sqlQuery2 = "select MAQL, ISNULL(ANH, '" + globalPic.anhQLdefault + "') from QUANLY WHERE MAQL = '" + id + "'";
                    SqlCommand command2 = new SqlCommand(sqlQuery2, connection);
                    SqlDataReader dataReader2 = command2.ExecuteReader();
                    while (dataReader2.HasRows)
                    {
                        if (dataReader2.Read() == false) break;
                        else
                            pictureBox_AnhNV.Image = ByteToImg(dataReader2.GetString(1));
                    }

                }
            }
            catch (Exception loi)
            {
                // khối này thực thi khi bắt được lỗi
                MessageBox.Show("Lỗi khi kết nối với hình ảnh của người dùng: " + loi.Message);
            }

            connection.Close();
        }
        
        //code chuyển từ byte sang hình ảnh
        private Image ByteToImg(string byteString)    // chứa đoạn string byte của images
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }
        //Cập nhật tên nhân viên trên label
        private void Update_Ten(string id)
        {
            connection.Open();
            if (id.Substring(0, 2) == "NV")
            {
                string sqlQuery = "select * from NHANVIEN where MANV = '" + id + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    else
                    {
                        this.label_tenDangNhap.Text = dataReader.GetString(2);
                    }
                }
            } else
            {
                string sqlQuery = "select * from QUANLY where MAQL = '" + id + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    else
                    {
                        this.label_tenDangNhap.Text = dataReader.GetString(2);
                    }
                }
            }
            connection.Close();
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
            thongTinCaNhan.ShowDialog();
            Update_Ten(Login.Current_user.ID);
            loadImg(Login.Current_user.ID);
        }

        private void button_info_ungDung_Click(object sender, EventArgs e)
        {
            ThongTinUngDung info = new ThongTinUngDung();
            info.ShowDialog();
        }
    }
}
