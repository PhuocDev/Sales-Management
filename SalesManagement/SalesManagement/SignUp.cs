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
using System.Runtime.CompilerServices;
using System.Configuration;
using System.IO;

namespace SalesManagement
{
    public partial class SignUp : Form
    {
        //static string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        SqlConnection connection = new SqlConnection(global.conString);
        public FormNhanVien parent ;
        public SignUp()
        {
            InitializeComponent();
        }
        public SignUp(FormNhanVien parent)
        {
            this.parent = parent;
            InitializeComponent();
        }

        //-------------------------------------------check_used_name------------------------------------------------------------//
        private bool Check_Used_name(string name)
        {
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
            else
            {
                connection.Close();
                return false;
            }
        }

        //-----------------------------------------------------fill_condition----------------------------------------------------//
        private bool fillCondition()
        {
            if (textBox5_MaNV.Text == "" || textBox2_matKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo");
                return false;
            }
            else if(textBox5_MaNV.Text.Length < 2 || textBox5_MaNV.Text.Substring(0,2) != "NV")
            {
                MessageBox.Show("Mã nhân viên phải bắt đầu bằng \"NV\"", "Thông báo");
                return false;
            }
            else if(comboBox2.Text != "Nam" && comboBox2.Text != "Nữ")
            {
                MessageBox.Show("Giới tính không hợp lệ!", "Thông báo");
                return false;
            }
            else if (textBox2_matKhau.Text != textBox3_laiMK.Text)
            {
                MessageBox.Show("Mật khẩu không trùng khớp!");
                return false;
            }
            else if (textBox_DienThoai.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin!","Thông báo");
                return false;
            }
            else if (Check_Used_name(textBox5_MaNV.Text) == true) {
                MessageBox.Show("Mã nhân viên đã được sử dụng", "Thông báo");
                return false;
            }
            else
            {
                return true;
            }
        }

        //------------------------------------------------------------Hash_pass-----------------------------------------------------//
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
        
        //-------------------------------------------------------Đăng kí click-----------------------------------------------------------//
        
        private void button_signup_Click(object sender, EventArgs e)
        {
            if (fillCondition())
            {
                SqlConnection sqlCon = new SqlConnection(global.conString);
                try
                {
                    sqlCon.Open();
                    string commandString = "INSERT INTO NHANVIEN VALUES('" + textBox5_MaNV.Text.ToString() + "', '" + Hash_pass(textBox2_matKhau.Text).ToString() + "', N'" + textBox4_HoTen.Text.ToString() + "', '" + dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().IndexOf(" ")) + "', N'" + comboBox2.Text.ToString() + "', '" + textBox_DienThoai.Text.ToString() + "', N'" + textBox_diaChi.Text.ToString() + "', NULL)";
                    SqlCommand sqlCmd = new SqlCommand(commandString, sqlCon);
                    sqlCmd.ExecuteNonQuery();
                    updateAnh_toSQL(imgPath);
                    MessageBox.Show("Đăng kí thành công");
                    this.parent.add_datagridview(textBox5_MaNV.Text, textBox4_HoTen.Text, dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().IndexOf(" ")), comboBox2.Text.ToString(), textBox_DienThoai.Text, textBox_diaChi.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                    this.Close();
                }
            }

        }


        //---------------------------------------------------hủy_bỏ_click-------------------------------------------------------------------//

        private void button_huyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //-----------------------------------------------------confirm_password_click-------------------------------------------------------//
        private void textBox3_laiMK_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_signup.PerformClick();
            }
        }
        //------------------------------------------------------------đặt_đk_cho_sđt---------------------------------------------------------//
        private void textBox_DienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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
            //labelFileName.Text = Path.GetFileName(textBox_linkToImage.Text);
            
            
        }
        // --------------------- xử lý hình ảnh -----------------------------//
        // button chọn ảnh
        public string imgPath = "";
        public bool changePic = false;   // kiểmm tra có thay đổi ảnh hay không
        
        private void updateAnh_toSQL(string imgPath)
        {
            if (!File.Exists(imgPath)) return;
            connection.Open();
            try
            {
                string sqlQuery = "";
                sqlQuery = "update NHANVIEN set ANH = @ANH where MANV = '" + textBox5_MaNV.Text + "' ";
                
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
        //code chuyển từ byte sang hình ảnh
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
            changePic = true;

            return picbyte;
        }
    }
}
