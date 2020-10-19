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
        string connectionString = @"Data Source=DESKTOP-STUS076\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True";
        public SignUp()
        {
            InitializeComponent();

        }
        private bool Check_Used_name(string name)
        {
            SqlConnection con = new SqlConnection();
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
            con.Close();
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
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (fillCondition())
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("NHANVIEN_ADD", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@MANV", textBox5_MaNV.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PASSWORD", Hash_pass(textBox2_matKhau.Text).Trim());  // hashed password
                    sqlCmd.Parameters.AddWithValue("@TEN", textBox4_HoTen.Text.Trim());
                    string date = textBox_nam.Text + "-" + textBox_thang.Text + "-" + textBox_ngay.Text;
                    sqlCmd.Parameters.AddWithValue("@NGAYSINH ", date.Trim());
                    sqlCmd.Parameters.AddWithValue("@GIOITINH", this.comboBox2.SelectedItem.ToString().Trim());
                    sqlCmd.Parameters.AddWithValue("@SDT", textBox_DienThoai.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DIACHI", textBox_diaChi.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Dang ki thanh cong");
                    sqlCon.Close();
                    Login test = new Login();
                    this.Hide();
                    test.Show();
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
