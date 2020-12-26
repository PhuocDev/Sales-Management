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
    public partial class DoiMK : Form
    {
        SqlConnection connection = new SqlConnection(global.conString);
        string maNV = Login.Current_user.ID;
        string name = Login.Current_user.NAME;
        public int check = 0;
        public DoiMK()
        {
            InitializeComponent();
        }

        private void button_huyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private bool fillCondition()
        {
            if (textBox_matKhau.Text == "" || textBox_mkCu.Text == "" || textBox_laiMK.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return false;
            }
            else if (textBox_matKhau.Text != textBox_laiMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return false;
            }
            else
            {
                return true;
            }
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
        private bool VerifyUser(string name, string pass)     //kiểm tra TK_MK
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

        //Update password
        private void updatePass()
        {
            try
            {
                connection.Open();
                if (Login.Current_user.ID.Substring(0, 2) == "NV")
                {
                    SqlCommand cmd = new SqlCommand("update NHANVIEN SET PASSWORD = '" + Hash_pass(textBox_matKhau.Text) + "' where MANV = '" + Login.Current_user.ID + "' and password = '" + Hash_pass(textBox_mkCu.Text) + "'", connection);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("update QUANLY SET PASSWORD = '" + Hash_pass(textBox_matKhau.Text) + "' where MAQL = '" + Login.Current_user.ID + "' and password = '" + Hash_pass(textBox_mkCu.Text) + "'", connection);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("kết nối xảy ra lỗi hoặc ghi dữ liệu bị lỗi");
            }
            finally
            {
                connection.Close();
            }
            MessageBox.Show("Đã đổi mật khẩu thành công! ", "Thông báo");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (fillCondition())
            {
                if (VerifyUser(Login.Current_user.ID, textBox_mkCu.Text))
                {
                    updatePass();
                    this.Close();
                    check = 1;
                }
                else
                {
                    MessageBox.Show("Sai mật khẩu! vui lòng nhập lại", "Thông báo");
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox_laiMK_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
