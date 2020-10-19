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
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();
        SqlDataReader dr;

        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-STUS076\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True";
        }

        private string Hash_pass(string pass)
        {
            //Tạo MD5 
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
            return repass;
        }
        private bool VerifyUser(string name, string pass)
        {
            con.Open();
            if (name.Substring(0, 1) == "N")
            {
                
                string query = "select * from NHANVIEN where MANV= '" + name.Trim() + "' and PASSWORD = '" + Hash_pass(pass).Trim() + "'";
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
                }
            }
            else 
            {
                string query = "select * from QUANLY where MAQL= '" + name.Trim() + "' and PASSWORD = '" + Hash_pass(pass).Trim() + "'";
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
                }
            }
            con.Close();
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
/*            if (VerifyUser(textBox1.Text, textBox_passWord.Text))
            {
                menu mn = new menu();
                mn.FormClosed += new FormClosedEventHandler(menu_FormClose);
                MessageBox.Show("Login Successfully!");
            }
            else MessageBox.Show("ERROR!");*/

            menu mn = new menu();
            mn.FormClosed += new FormClosedEventHandler(menu_FormClose);
            mn.Show();
            this.Hide();
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
    }
}
