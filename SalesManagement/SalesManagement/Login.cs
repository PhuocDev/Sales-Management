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
namespace SalesManagement
{
    public partial class Login : Form
    {
        public static User Current_user;////////////////////// Lưu thông tin người dùng hiện tại
        //static string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        SqlConnection connection = new SqlConnection(global.conString);

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
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
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
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
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
            try
            {
                if (textBox1.Text == "" || textBox_passWord.Text == "")
                {
                    MessageBox.Show("Chưa nhập đủ thông tin", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (VerifyUser(textBox1.Text, textBox_passWord.Text))
                {
                    Current_user = new User(textBox1.Text, textBox_passWord.Text);//////// Lưu thông tin người dùng hiện tại
                    menu mn = new menu(this.SHOW);
                    mn.FormClosed += new FormClosedEventHandler(menu_FormClose);
                    mn.Show();
                    this.Hide();
                }
                else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch( Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                connection.Close();
            }
            finally
            {

            }
            
        }
        private void menu_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        public void SHOW()
        {
            this.textBox1.Text = "";
            this.ActiveControl = this.textBox1;
            this.textBox_passWord.Text = "password";
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

        private void textBox_passWord_Enter(object sender, EventArgs e)
        {
            this.textBox_passWord.isPassword = true;
        }
    }
}
