﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.Security.Cryptography;
using System.Text;

namespace SalesManagement
{
    public partial class thongTinCaNhan : Form
    {
        public SqlConnection connection = new SqlConnection(global.conString);
        struct thongtin
        {
            public string manv;
            public string ten, ngaysinh, gioitinh, diachi, sdt;
            
        }
        List<thongtin> nguoiDung = new List<thongtin>(2);
        public thongTinCaNhan()
        {
            InitializeComponent();
            txbMaNV.Text = Login.Current_user.ID;
            UpdateNhanVien();
            txbMaNV.Text = nguoiDung[0].manv;
            txbHoTen.Text = nguoiDung[0].ten;
            dateTimePicker1.Text = nguoiDung[0].ngaysinh;
            txbGioiTinh.Text = nguoiDung[0].gioitinh;
            txbSDT.Text = nguoiDung[0].sdt;
            txbDiaChi.Text = nguoiDung[0].diachi;
            button1.Focus();
        }
        private void UpdateNhanVien()
        {
            connection.Open();
            string sqlQuery = "";
            if (Login.Current_user.ID.Substring(0, 2) == "NV")
            {
                sqlQuery = "select * from NHANVIEN where MANV = '" + Login.Current_user.ID + "'";
            }
            else
            {
                sqlQuery = "select * from QUANLY where MAQL = '" + Login.Current_user.ID + "'";
            }
            
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                thongtin t;
                t.manv = dataReader.GetString(0);
                t.ten = dataReader.GetString(2);
                t.ngaysinh = dataReader.GetDateTime(3).ToString().Substring(0, dataReader.GetDateTime(3).ToString().IndexOf(" "));
                t.gioitinh = dataReader.GetString(4);
                t.sdt = dataReader.GetString(5);
                t.diachi = dataReader.GetString(6);
                nguoiDung.Add(t);
            }
            connection.Close();
        }
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            UpdateNhanVien();
            txbMaNV.Text = nguoiDung[0].manv;
            txbHoTen.Text = nguoiDung[0].ten;
            dateTimePicker1.Text = nguoiDung[0].ngaysinh;
            txbGioiTinh.Text = nguoiDung[0].gioitinh;
            txbSDT.Text = nguoiDung[0].sdt;
            txbDiaChi.Text = nguoiDung[0].diachi;
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DoiMK doimk = new DoiMK();
            doimk.ShowDialog();
        }
        private bool changed()
        {
            if (txbMaNV.Text != nguoiDung[0].manv ||
            txbHoTen.Text != nguoiDung[0].ten ||
            dateTimePicker1.Text != nguoiDung[0].ngaysinh ||
            txbGioiTinh.Text != nguoiDung[0].gioitinh ||
            txbSDT.Text != nguoiDung[0].sdt ||
            txbDiaChi.Text != nguoiDung[0].diachi)
            {
                return true;
            }
            else return false;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            if (changed())
            {
                try
                {
                    connection.Open();
                    string sqlQuery = "update NHANVIEN set TEN = @ten, NGAYSINH = @ngaysinh, GIOITINH = @gioitinh, SDT = @sdt, DIACHI = @diachi where MANV = @manv";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@ten", txbHoTen.Text);
                    command.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.ToString());
                    command.Parameters.AddWithValue("@gioitinh", txbGioiTinh.Text);
                    command.Parameters.AddWithValue("@sdt", txbSDT.Text);
                    command.Parameters.AddWithValue("@diachi", txbDiaChi.Text);
                    command.Parameters.AddWithValue("@manv", txbMaNV.Text);

                    int rs = command.ExecuteNonQuery();
                    if (rs != 1)
                    {
                        throw new Exception("Failed Query");
                    }
                    MessageBox.Show("Đã lưu!", "Thông báo");
                    this.Close();
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
            else
            {
                MessageBox.Show("Không có gì thay đổi", "Thông báo");
                this.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thongTinCaNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control == true && e.KeyCode == Keys.S))
            {
                button2.PerformClick();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                button1.PerformClick();
            }
        }
    }
}
