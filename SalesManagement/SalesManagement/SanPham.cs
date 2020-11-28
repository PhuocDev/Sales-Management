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

namespace SalesManagement
{
    public partial class SanPham : Form
    {
        //string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        public SanPham()
        {
            InitializeComponent();
            ImportSanPham();
        }
        private void ImportSanPham()
        {
//<<<<<<< HEAD
            //string conString = @"Server=DESKTOP-IRREIHM\SQLEXPRESS;Database=SALES_MANAGEMENT;User Id=sa;Password=thanh08052001;";
            //SqlConnection connection = new SqlConnection(global.conString);
//=======
            SqlConnection connection = new SqlConnection(global.conString);
//>>>>>>> 2fc26b192b351325a0c8ac42c3c63a60997779d2
            connection.Open();
            string sqlQuery = "select * from SANPHAM";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int stt = 1;
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                dataGridView_danhSachSanPham.Rows.Add(stt, dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2),
                    dataReader.GetString(3), dataReader.GetInt32(5), dataReader.GetDateTime(6).ToString(), dataReader.GetString(7));
                stt++;
            }
            connection.Close();
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
            ChinhSuaDSSP cs = new ChinhSuaDSSP(this);
            cs.ShowDialog();
        }
    }
}
