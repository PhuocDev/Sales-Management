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
    public partial class SignUp : Form
    {
        string connectionString = @"Data Source=DESKTOP-STUS076\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True";
        public SignUp()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                if (textBox5_MaNV.Text == "" || textBox2_matKhau.Text == "")
                {
                    MessageBox.Show("Vui long nhap du thong tin!");
                }
                else if (textBox2_matKhau.Text != textBox3_laiMK.Text)
                {
                    MessageBox.Show("Mat khau khong khop!");
                }
                else
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("NHANVIEN_ADD", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@MANV", textBox5_MaNV.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@PASSWORD", textBox2_matKhau.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@TEN", textBox4_HoTen.Text.Trim());
                    string date = textBox_nam.Text + "-" + textBox_thang.Text + "-" + textBox_ngay.Text;
                    sqlCmd.Parameters.AddWithValue("@NGAYSINH ", date.Trim());
                    sqlCmd.Parameters.AddWithValue("@GIOITINH", this.comboBox2.SelectedItem.ToString().Trim());
                    sqlCmd.Parameters.AddWithValue("@SDT", textBox_DienThoai.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@DIACHI", textBox_diaChi.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Dang ki thanh cong");
                    sqlCon.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void textBox3_laiMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }
    }
}
