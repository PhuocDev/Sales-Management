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

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
        private bool VerifyUser(string name, string pass)
        {
            con.Open();
            if (name.Substring(0, 1) == "N")
            {
                
                string query = "select * from NHANVIEN where MANV= '" + name.Trim() + "' and PASSWORD = '" + pass.Trim() + "'";
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
                string query = "select * from QUANLY where MAQL= '" + name.Trim() + "' and PASSWORD = '" + pass.Trim() + "'";
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
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (VerifyUser(textBox1.Text, textBox2.Text))
            {
                MessageBox.Show("Login Successfully!");
            }
            else MessageBox.Show("ERROR!");
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

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
