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
namespace SalesManagement
{
    public partial class SignUp : Form
    {
//<<<<<<< HEAD
        //static string conString = @"Server=DESKTOP-IRREIHM\SQLEXPRESS;Database=SALES_MANAGEMENT;User Id=sa;Password=thanh08052001;";
       // SqlConnection connection = new SqlConnection(global.conString);
//=======
        //static string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        SqlConnection connection = new SqlConnection(global.conString);
//>>>>>>> 2fc26b192b351325a0c8ac42c3c63a60997779d2
        public SignUp()
        {
            InitializeComponent();

        }
        private bool Check_Used_name(string name)
        {
            /*SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=DESKTOP-STUS076\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True";
            con.Open();
            if (name.Substring(0, 1) == "N")
            {
                string query = "select * from NHANVIEN where MANV= '" + name.Trim() + "'";
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
            else return false;
            con.Close();*/
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
            else if (name.Substring(0, 2) == "QL")
            {
                string sqlQuery = "select MAQL from QUANLY";
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
                    /*sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@MANV", textBox5_MaNV.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PASSWORD", Hash_pass(textBox2_matKhau.Text).Trim());  // hashed password
                    sqlCmd.Parameters.AddWithValue("@TEN", textBox4_HoTen.Text.Trim());
                    string date = textBox_nam.Text + "-" + textBox_thang.Text + "-" + textBox_ngay.Text;
                    sqlCmd.Parameters.AddWithValue("@NGAYSINH ", date.Trim());
                    sqlCmd.Parameters.AddWithValue("@GIOITINH", this.comboBox2.SelectedItem.ToString().Trim());
                    sqlCmd.Parameters.AddWithValue("@SDT", textBox_DienThoai.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DIACHI", textBox_diaChi.Text.Trim());*/
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
