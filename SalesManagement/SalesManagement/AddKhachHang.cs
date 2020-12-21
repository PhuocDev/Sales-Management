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
    public partial class AddKhachHang : Form
    {
        public static string conString = @"Server=DESKTOP-IRREIHM\SQLEXPRESS;Database=SALES_MANAGEMENT;User Id=sa;Password=thanh08052001;";
        SqlConnection connection = new SqlConnection(conString);
        public FormKhachHang parent;
        private string MAKH = "KH";
        public AddKhachHang()
        {
            InitializeComponent();
        }
        public AddKhachHang(FormKhachHang pa)
        {
            this.parent = pa;
            InitializeComponent();
        }
        //-----------------------------------------------------------------------------------------------------------------------------------//
        private bool get_MAKH()
        {
            connection.Open();
            string sqlQuery = "select MAKH from KHACHHANG";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int i = 0;
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                int j = Convert.ToInt32(dataReader.GetString(0).Substring(2));
                if ( j != i+1)
                {
                    connection.Close();
                    this.MAKH += ("0000" + (i+1).ToString()).Substring(("0000" + (i + 1).ToString()).Length -5);
                    return true;
                }
                i++;
            }
            if (i == 99999) return false;
            this.MAKH += ("0000" + (i + 1).ToString()).Substring(("0000" + (i + 1).ToString()).Length - 5);
            connection.Close();
            return true;
        }

        //--------------------------------------------------------fill_condition-------------------------------------------------------------------------//
        private bool fillCondition()
        {
            if (textBox_DienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return false;
            }
            else if (textBox5_MaKH.Text.Length < 2 || textBox5_MaKH.Text.Substring(0, 2) != "KH")
            {
                MessageBox.Show("Mã khách hàng phải bắt đầu bằng \"KH\"", "Thông báo");
                return false;
            }
            else if (comboBox_gioiTinh.Text != "Nam" && comboBox_gioiTinh.Text != "Nữ")
            {
                MessageBox.Show("Giới tính không hợp lệ!", "Thông báo");
                return false;
            }
            else
            {
                return true;
            }
        }

        //-------------------------------------------------sign_up_click---------------------------------------------------------------------------//

        private void button_signup_Click(object sender, EventArgs e)
        {
            if (fillCondition())
            {
                SqlConnection sqlCon = new SqlConnection(global.conString);
                try
                {
                    sqlCon.Open();
                    string commandString = "INSERT INTO KHACHHANG VALUES('" + textBox5_MaKH.Text.ToString() + "', N'" + textBox4_HoTen.Text.ToString() + "', '" + dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().IndexOf(" ")) + "', N'" + comboBox_gioiTinh.Text.ToString() + "', '" + textBox_DienThoai.Text.ToString() + "', N'" + textBox_diaChi.Text.ToString() + "','" + textBox_diem.Text.ToString() + "')";
                    SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Dang ki thanh cong");
                   // this.parent.add_datagridview(textBox5_MaKH.Text, textBox4_HoTen.Text, dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().IndexOf(" ")), comboBox_gioiTinh.Text.ToString(), textBox_DienThoai.Text, textBox_diaChi.Text, textBox_diem.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("kết nối xảy ra lỗi hoặc ghi dữ liệu bị lỗi");
                }
                finally
                {
                    connection.Close();
                    this.Close();
                }
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------//
        private void button_huyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddKhachHang_Load(object sender, EventArgs e)
        {
            if (get_MAKH())
            {
                textBox5_MaKH.Text = MAKH;
                MAKH = "KH";
            }
            else
            {
                MessageBox.Show("Số lượng khách hàng quá lớn không thể tạo thêm","", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBox_diem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_DienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
