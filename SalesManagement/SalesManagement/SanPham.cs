﻿using System;
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
    public partial class sanPham : Form
    {
        public static string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        SqlConnection connection = new SqlConnection(conString);
        public sanPham()
        {
            InitializeComponent();
            ImportSanPham();
        }
        private void ImportSanPham()
        {
            connection.Open();
            string sqlQuery = "select * from SANPHAM";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int stt = 1;
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                dataGridView_danhSachSanPham.Rows.Add(stt, dataReader.GetString(0), 
                    dataReader.GetString(1),dataReader.GetInt32(2), dataReader.GetString(3), dataReader.GetInt32(5),
                    dataReader.GetDateTime(6).ToString().Substring(0, dataReader.GetDateTime(6).ToString().IndexOf(" ")), dataReader.GetString(7));
                stt++;
            }
            connection.Close();
        }

        //-----------------------------------------------------------chuyển_form--------------------------------------------------------------------//

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
        //---------------------------------------------------------chỉnh_sửa-------------------------------------------------------------------//
        public static List<string[]> list_changes = new List<string[]>();
        private void button_chinhSua_Click(object sender, EventArgs e)
        {
            if (Login.Current_user.ID.Substring(0, 2) == "QL")
            {
                DataGridViewCell cell = dataGridView_danhSachSanPham.CurrentCell;
                int index = cell.RowIndex;
                ChinhSuaDSSP cs = new ChinhSuaDSSP(this);
                cs.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản không được cấp quyền chỉnh sửa sản phẩm");
            }
        }

        //----------------------------------------------------------Tìm_kiếm------------------------------------------------------------------------------//

        private void button_timKiem_Click(object sender, EventArgs e)
        {
            dataGridView_danhSachSanPham.Rows.Clear();
            connection.Open();
            string name = textBox_ten.Text;
            string masp = textBox_masp.Text;
            string dkloc = comboBox_boLoc.Text;

            string sqlQuery = boloc(dkloc, name, masp);
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
        public string boloc(string dkloc, string name, string masp) { 
            string sqlQuery = "";
            switch (dkloc)
            {
                case "Giá dưới 100.000đ":
                    {
                        sqlQuery = string.Format("SELECT * FROM SANPHAM WHERE dbo.fuConvertToUnsign1(TEN) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND MASP LIKE '%{1}%' AND GIABANLE < 100000", name, masp);
                        break;
                    }
                case "Giá từ 100.000đ đến 1.000.000đ":
                    {
                        sqlQuery = string.Format("SELECT * FROM SANPHAM WHERE dbo.fuConvertToUnsign1(TEN) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND MASP LIKE '%{1}%' AND GIABANLE >= 100000 AND GIABANLE <= 1000000", name, masp);
                        break;
                    }
                case "Giá từ 1.000.000đ đến 10.000.000đ":
                    {
                        sqlQuery = string.Format("SELECT * FROM SANPHAM WHERE dbo.fuConvertToUnsign1(TEN) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND MASP LIKE '%{1}%' AND GIABANLE >= 1000000 AND GIABANLE <= 10000000", name, masp);
                        break;
                    }
                case "Giá trên 10.000.000đ":
                    {
                        sqlQuery = string.Format("SELECT * FROM SANPHAM WHERE dbo.fuConvertToUnsign1(TEN) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND MASP LIKE '%{1}%' AND GIABANLE > 10000000", name, masp);
                        break;
                    }
                default:
                    {
                        sqlQuery = string.Format("SELECT * FROM SANPHAM WHERE dbo.fuConvertToUnsign1(TEN) LIKE N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%' AND MASP LIKE '%{1}%'", name, masp);
                        break;
                    }
            }
            return sqlQuery;
        }
        //--------------------------------------------------------xóa_sp---------------------------------------------------------------//

        List<string> id_remove = new List<string>();
        private void button_xoa_Click(object sender, EventArgs e)
        {
            if (Login.Current_user.ID.Substring(0, 2) == "QL")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa sản phẩm đã chọn?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;

                DataGridViewCell cell = dataGridView_danhSachSanPham.CurrentCell;
                if (cell == null) return;
                int index = cell.RowIndex;
                id_remove.Add(dataGridView_danhSachSanPham.Rows[index].Cells[1].Value.ToString());// thêm vào danh sách sản phẩm bị xóa
                dataGridView_danhSachSanPham.Rows.RemoveAt(index);
                for (int i = index; i < dataGridView_danhSachSanPham.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView_danhSachSanPham.Rows[i];
                    row.Cells[0].Value = i + 1;
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không được cấp quyền xóa nhân viên");
            }
        }

        //---------------------------------------------------------------lưu_thay_đổi-------------------------------------------------------//

        private void button_luu_Click(object sender, EventArgs e)
        {
            if (list_changes.Count() == 0 && id_remove.Count() == 0) return;
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                list_changes.Clear();
                list_changes.Clear();
                this.dataGridView_danhSachSanPham.Rows.Clear();
                ImportSanPham();
            }

            try
            {
                connection.Open();
                for (int i = 0; i < list_changes.Count(); i++)
                {

                    string sqlQuery = "update SANPHAM set TEN = @ten, SOLUONG = @sl, DVT = @dvt, GIABANLE = @gia, HSD = @hsd, NHACUNGCAP = @nhacc where MASP = @masp";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    command.Parameters.AddWithValue("@ten", list_changes[i][1]);
                    command.Parameters.AddWithValue("@sl", list_changes[i][2]);
                    command.Parameters.AddWithValue("@dvt", list_changes[i][3]);
                    command.Parameters.AddWithValue("@gia", list_changes[i][4]);
                    command.Parameters.AddWithValue("@hsd", list_changes[i][5]);
                    command.Parameters.AddWithValue("@nhacc", list_changes[i][6]);
                    command.Parameters.AddWithValue("@masp", list_changes[i][0]);
                    
                    int rs = command.ExecuteNonQuery();
                    if (rs != 1)
                    {
                        throw new Exception("Failed Query");
                    }
                }

                list_changes.Clear();// xóa danh sách bị thay đổi cũ

                for (int i = 0; i < id_remove.Count(); i++)
                {
                    string sqlQuery = "delete from SANPHAM where MASP = '" + id_remove[i] + "'";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    int rs = command.ExecuteNonQuery();
                    if (rs != 1)
                    {
                        throw new Exception("Failed Query");
                    }
                }
                id_remove.Clear(); // xóa danh sách sản phẩm đã bị xóa
            }
            catch (Exception ex)
            {
                MessageBox.Show("kết nối xảy ra lỗi hoặc ghi dữ liệu bị lỗi");
            }
            finally
            {
                connection.Close();
            }
        }
    //----------------------------------------------------button_show_toàn_bộ_sp---------------------------------------------------------------//
        private void button_fullsp_Click(object sender, EventArgs e)
        {
            dataGridView_danhSachSanPham.Rows.Clear();
            ImportSanPham();
        }
    }
}
