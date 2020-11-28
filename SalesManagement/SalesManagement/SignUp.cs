using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Sockets;
namespace SalesManagement
{
    public partial class SignUp : Form
    {
        MySqlConnection connection = new MySqlConnection(global.conString);
        public SignUp()
        {
            InitializeComponent();

        }
        private bool Check_Used_name(string name)
        {
            connection.Open();
            if (name.Substring(0, 2) == "NV")
            {
                string sqlQuery = "select MANV from NHANVIEN";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    if (dataReader.GetString(0) == name)
                    {
                        connection.Close();
                        return true;
                    }
                }
                connection.Close();
                return false;
            }
            else if (name.Substring(0, 2) == "QL")
            {
                string sqlQuery = "select MAQL from QUANLY";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    if (dataReader.GetString(0) == name)
                    {
                        connection.Close();
                        return true;
                    }
                }
                connection.Close();
                return false;
            }
            else
            {
                connection.Close();
                return false;
            }
        }
        private bool fillCondition()
        {
            if (textBox5_MaNV.Text == "" || textBox2_matKhau.Text == "")
            {
                MessageBox.Show("Vui long nhap du thong tin!","Thong bao");
                return false;
            }
            else if (textBox2_matKhau.Text != textBox3_laiMK.Text)
            {
                MessageBox.Show("Mat khau khong khop!");
                return false;
            }
            else if (textBox_ngay.Text == "" || textBox_thang.Text =="" || textBox_nam.Text == "")
            {
                MessageBox.Show("Vui long nhap du thong tin!","Thong bao");
                return false;
            }
            else if (textBox_DienThoai.Text == "")
            {
                MessageBox.Show("Vui long nhap du thong tin!","Thong bao");
                return false;
            }
            else if (Check_Used_name(textBox5_MaNV.Text) == true) {
                MessageBox.Show("Ma nhan vien da duoc su dung", "Thong bao");
                return false;
            }
            else
            {
                return true;
            }
        }
        private string Hash_pass(string pass)
        {
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            /*if (isQL == false)
            {
                MessageBox.Show("Không có quyền thêm nhân viên");
            }*/
            using (SqlConnection sqlCon = new SqlConnection(global.conString))
            {
                if (fillCondition())
                {
                    sqlCon.Open();
                    string commandString = "INSERT INTO NHANVIEN VALUES('" + textBox5_MaNV.Text + "', '" + Hash_pass(textBox2_matKhau.Text) + "', N'" + textBox4_HoTen.Text + "', '" + textBox_nam.Text + "-" + textBox_thang.Text + "-" + textBox_ngay.Text + "', N'" + comboBox2.SelectedItem.ToString() + "', '" + textBox_DienThoai.Text + "', N'" + textBox_diaChi.Text + "')";
                    SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Dang ki thanh cong");
                    sqlCon.Close();
                    Login test = new Login();
                    this.Hide();
                    //test.Show();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_laiMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBox4_HoTen_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
