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
using System.Configuration;
using System.Security.Cryptography;
using System.Text;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Net;
using System.Net.Sockets;
namespace SalesManagement
{
    
    public partial class Login : Form
    {
        public bool isQL = false;
        // HEAD
        //static string conString = @"Server=DESKTOP-IRREIHM\SQLEXPRESS;Database=SALES_MANAGEMENT;User Id=sa;Password=thanh08052001;";
        MySql.Data.MySqlClient.MySqlConnection connection = new MySqlConnection(global.conString);

        public Login()
        {
            InitializeComponent();
        }
        //---------------------------------------------Hash_pass------------------------------------------------------//
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

        //--------------------------------------VerifyUser----------------------------------------------------------//
        private bool VerifyUser(string name, string pass)//kiểm tra TK_MK
        {
            connection.Open();
            if (name.Substring(0, 2) == "NV")
            {
                string sqlQuery = "select MANV, PASSWORD from NHANVIEN";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    if (dataReader.GetString(0) == name && dataReader.GetString(1) == Hash_pass(pass))
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
                string sqlQuery = "select MAQL, PASSWORD from QUANLY";
                MySqlCommand command = new MySqlCommand(sqlQuery, connection);
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    if (dataReader.GetString(0) == name && dataReader.GetString(1) == Hash_pass(pass))
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

        //--------------------------------------------------Dangnhap_click------------------------------------------------//
        private void button_dangNhap_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox_passWord.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            } 
            if (VerifyUser(textBox1.Text, textBox_passWord.Text))
            {
                Current_user = new User(textBox1.Text, textBox_passWord.Text);//////// Lưu thông tin người dùng hiện tại
                menu mn = new menu();
                mn.FormClosed += new FormClosedEventHandler(menu_FormClose);
                mn.Show();
                this.Hide();
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");
        }
        private void menu_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        //------------------------------------------keydown------------------------------------------------------------------//
        private void textBox_passWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                button_dangNhap.PerformClick();
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                this.ActiveControl = textBox_passWord;
                this.textBox_passWord.Focus();
                e.SuppressKeyPress = true;
            }
        }
        //---------------------------------------------------username_leave_enter--------------------------------------------------//

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                textBox1.Text = "Username";
            }
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Username"))
            {
                textBox1.Text = "";
            }
        }
    }
    public class global
    {
        public static string conString = "datasource=localhost;port=3306;Initial Catalog=SALES_MANAGEMENT;username=phuoc;password=phuoc;pooling = false; convert zero datetime=True";
            //@"Data Source=DESKTOP-VMO2INA\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True;";
    }
}
