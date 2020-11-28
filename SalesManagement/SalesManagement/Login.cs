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
        public bool isQL = false;
        // HEAD
        //static string conString = @"Server=DESKTOP-IRREIHM\SQLEXPRESS;Database=SALES_MANAGEMENT;User Id=sa;Password=thanh08052001;";
        SqlConnection connection = new SqlConnection(global.conString);
//=======
        static string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        //SqlConnection connection = new SqlConnection(conString);
//>>>>>>> 2fc26b192b351325a0c8ac42c3c63a60997779d2
        /*SqlCommand com = new SqlCommand();
        SqlDataReader dr;*/

        public Login()
        {
            InitializeComponent();
            //con.ConnectionString = @"Data Source=DESKTOP-STUS076\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True";
        }

        private string Hash_pass(string pass)
        {
            /*//Tạo MD5 
            MD5 mh = MD5.Create();
            //Chuyển kiểu chuổi thành kiểu byte
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(pass);
            //mã hóa chuỗi đã chuyển
            byte[] hash = mh.ComputeHash(inputBytes);
            //tạo đối tượng StringBuilder (làm việc với kiểu dữ liệu lớn)
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("x2"));
            }
            string repass = Convert.ToString(sb);
            repass = repass.Substring(0, 7);
            return repass;*/
            byte[] temp = ASCIIEncoding.ASCII.GetBytes(pass);
            byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

            string hasPass = "";

            foreach (byte item in hasData)
            {
                hasPass += item;
            }
            return hasPass;
        }
        private bool VerifyUser(string name, string pass)
        {
            connection.Open();
            if (name.Substring(0, 2) == "NV")
            {
                /*string query = "select * from NHANVIEN where MANV= '" + name.Trim() + "' and PASSWORD = '" + Hash_pass(pass).Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dttb = new DataTable();
                sda.Fill(dttb);
                if (dttb.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }*/
                string sqlQuery = "select MANV, PASSWORD from NHANVIEN";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    if (dataReader.GetString(0) == name && dataReader.GetString(1) == Hash_pass(pass))
                    {
                        connection.Close();
                        isQL = false;
                        return true;
                    }
                }
                connection.Close();
                return false;
            }
            else if (name.Substring(0, 2) == "QL")
            {
                /*string query = "select * from QUANLY where MAQL= '" + name.Trim() + "' and PASSWORD = '" + Hash_pass(pass).Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, con);
                DataTable dttb = new DataTable();
                sda.Fill(dttb);
                if (dttb.Rows.Count == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }*/
                string sqlQuery = "select MAQL, PASSWORD from QUANLY";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    if (dataReader.GetString(0) == name && dataReader.GetString(1) == Hash_pass(pass))
                    {
                        connection.Close();
                        isQL = true;
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

        private void UsernamEnter(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("Username"))
            {
                textBox1.Text = "";
            }
        }

        private void UsernamLeave(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals(""))
            {
                textBox1.Text = "Username";
            }
        }

        private void button_dangNhap_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox_passWord.Text == "")
            {
                MessageBox.Show("Chưa nhập đủ thông tin");
                return;
            } 
            if (VerifyUser(textBox1.Text, textBox_passWord.Text))
            {
                menu mn = new menu();
                mn.FormClosed += new FormClosedEventHandler(menu_FormClose);
                mn.Show();
                this.Hide();
            }
            else MessageBox.Show("Tài khoản hoặc mật khẩu không đúng");

            /*menu mn = new menu();
            mn.FormClosed += new FormClosedEventHandler(menu_FormClose);
            mn.Show();
            this.Hide();*/
        }
        private void menu_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        private void textBox_passWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_dangNhap.PerformClick();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
    public class global
    {
        public static string conString = @"Data Source=DESKTOP-VMO2INA\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True;";
    }
}
