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

namespace SalesManagement
{
    public partial class Login : Form
    {
        SqlConnection con = new SqlConnection();
        SqlCommand com = new SqlCommand();


        public Login()
        {
            InitializeComponent();
            con.ConnectionString = @"Data Source=DESKTOP-STUS076\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            con.Open();
            com.Connection = con;
            if (textBox1.Text.Substring(0, 1) == "Q")
            {
                com.CommandText = "select MAQL, PASSWORD from QUANLY";
                SqlDataReader quanLy = com.ExecuteReader();
                if (quanLy.Read())
                {
                    if (textBox1.Text.Equals(quanLy["MAQL"].ToString()) && textBox2.Text.Equals(quanLy["PASSWORD"].ToString()))
                    {
                        MessageBox.Show("Login successfully, welcom Manager");
                    }
                    else MessageBox.Show("No manager");
                }
            }
            else
            {
                com.CommandText = "select MANV, PASSWORD from NHANVIEN";
                SqlDataReader nhanvien = com.ExecuteReader();
                if (nhanvien.Read())
                {
                    if (textBox1.Text.Equals(nhanvien["MANV"].ToString()) && textBox2.Text.Equals(nhanvien["PASSWORD"].ToString()))
                    {
                        MessageBox.Show("Login successfully, welcom Staff");
                    }
                    else MessageBox.Show("No staff");
                }

            }
            con.Close();
        }
    }
}
