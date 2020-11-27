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
using System.Security.Cryptography;
using System.Text;
using System.Runtime.CompilerServices;

namespace SalesManagement
{
    public partial class SignUp : Form
    {
        static string conString = @"Server=DESKTOP-IRREIHM\SQLEXPRESS;Database=SALES_MANAGEMENT;User Id=sa;Password=thanh08052001;";
        SqlConnection connection = new SqlConnection(conString);
        public FormNhanVien parent ;
        public SignUp()
        {
            InitializeComponent();
        }
        public SignUp(FormNhanVien parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        //-------------------------------------------check_used_name------------------------------------------------------------//
        private bool Check_Used_name(string name)
        {
            connection.Open();
            if (name.Substring(0, 2) == "NV")
            {
                string sqlQuery = "select MANV from NHANVIEN";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
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

        //-----------------------------------------------------fill_condition----------------------------------------------------//
        private bool fillCondition()
        {
            if (textBox5_MaNV.Text == "" || textBox2_matKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return false;
            }
            else if(textBox5_MaNV.Text.Length < 2 || textBox5_MaNV.Text.Substring(0,2) != "NV")
            {
                MessageBox.Show("Mã nhân viên phải bắt đầu bằng \"NV\"", "Thông báo");
                return false;
            }
            else if(comboBox2.Text != "Nam" && comboBox2.Text != "Nu")
            {
                MessageBox.Show("Giới tính không hợp lệ!", "Thông báo");
                return false;
            }
            else if (textBox2_matKhau.Text != textBox3_laiMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return false;
            }
            else if (textBox_DienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!","Thông báo");
                return false;
            }
            else if (Check_Used_name(textBox5_MaNV.Text) == true) {
                MessageBox.Show("Mã nhân viên đã được sử dụng", "Thông báo");
                return false;
            }
            else
            {
                return true;
            }
        }

        //------------------------------------------------------------Hash_pass-----------------------------------------------------//
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
        
        //-------------------------------------------------------Đăng kí click-----------------------------------------------------------//
        
        private void button_signup_Click(object sender, EventArgs e)
        {
            if (fillCondition())
            {
                SqlConnection sqlCon = new SqlConnection(conString);
                try
                {
                    sqlCon.Open();
                    string commandString = "INSERT INTO NHANVIEN VALUES('" + textBox5_MaNV.Text.ToString() + "', '" + Hash_pass(textBox2_matKhau.Text).ToString() + "', N'" + textBox4_HoTen.Text.ToString() + "', '" + dateTimePicker1.Value.ToString() + "', N'" + comboBox2.Text.ToString() + "', '" + textBox_DienThoai.Text.ToString() + "', N'" + textBox_diaChi.Text.ToString() + "')";
                    SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Dang ki thanh cong");
                    this.parent.add_datagridview(textBox5_MaNV.Text, textBox4_HoTen.Text, dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().IndexOf(" ")), comboBox2.Text.ToString(), textBox_DienThoai.Text, textBox_diaChi.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("kết nối xảy ra lỗi hoặc ghi dữ liệu bị lỗi");
                }
                finally
                {
                    connection.Close();
                    this.Close();
                }
            }
        }


        //---------------------------------------------------hủy bỏ click-------------------------------------------------------------------//

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox3_laiMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_signup.PerformClick();
            }
        }
    }
}
