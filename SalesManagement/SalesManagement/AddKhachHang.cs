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
using System.IO;

namespace SalesManagement
{
    public partial class AddKhachHang : Form
    {
        //public static string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        SqlConnection connection = new SqlConnection(global.conString);
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
                if ( j != i)
                {
                    connection.Close();
                    this.MAKH += ("0000" + (i).ToString()).Substring(("0000" + (i).ToString()).Length -5);
                    return true;
                }
                i++;
            }
            if (i == 99999) return false;
            this.MAKH += ("0000" + (i).ToString()).Substring(("0000" + (i).ToString()).Length - 5);
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
                    string commandString = "INSERT INTO KHACHHANG VALUES('" + textBox5_MaKH.Text.ToString() + "', N'" + textBox4_HoTen.Text.ToString() + "', '" + dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().IndexOf(" ")) + "', N'" + comboBox_gioiTinh.Text.ToString() + "', '" + textBox_DienThoai.Text.ToString() + "', N'" + textBox_diaChi.Text.ToString() + "','" + textBox_diem.Text.ToString() + "', NULL)";
                    SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    updateAnh_toSQL(imgPath);
                    MessageBox.Show("Đăng ký thành công");
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

        public string imgPath = "";
        private void button_UpdateImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                if (!File.Exists(openFile.FileName)) return;
                imgPath = openFile.FileName;
                pictureBox_AnhNV.Image = ByteToImg(chuyenDoiAnh_Byte(imgPath));
            }
        }
        private void updateAnh_toSQL(string imgPath)
        {
            if (!File.Exists(imgPath)) return;
            connection.Open();
            try
            {
                string sqlQuery = "";
                sqlQuery = "update KHACHHANG set ANH = @ANH where MAKH = '" + textBox5_MaKH.Text + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@ANH", chuyenDoiAnh_Byte(imgPath));
                int rs = command.ExecuteNonQuery();
                if (rs != 1)
                {
                    throw new Exception("Failed Query");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            connection.Close();
        }
        private string chuyenDoiAnh_Byte(string path)
        {
            if (!File.Exists(path)) return null;
            // chuỗi dùng để lưu vào database
            string byteOfImag = Convert.ToBase64String(converImgToByte(path));
            return byteOfImag;
            // Để cover đoạn chuỗi trên trở lại kiểu Byte hình ảnh thì dùng đoạn code sau:
            //Convert.FromBase64String(Đoạn_String_đã_cover);
        }
        private Image ByteToImg(string byteString)    // chứa đoạn string byte của images
        {
            Image image1 = null;
            try
            {
                byte[] imgBytes = Convert.FromBase64String(byteString);
                MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
                ms.Write(imgBytes, 0, imgBytes.Length);
                image1 = Image.FromStream(ms, true);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return image1;
        }
        // code chuyển từ ảnh sang byte
        private byte[] converImgToByte(string path)
        {

            FileStream fs = null;
            byte[] picbyte = { 1, 2 };
            try
            {
                fs = new FileStream(path, FileMode.Open, FileAccess.Read);
                picbyte = new byte[fs.Length];
                fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
                fs.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Vui lòng chọn hình ảnh", "Error");
            }
            return picbyte;
        }
    }
}
