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
using System.IO;


namespace SalesManagement
{
    public partial class thongTinCaNhan : Form
    {
        public SqlConnection connection = new SqlConnection(global.conString);
        struct thongtin
        {
            public string manv;
            public string ten, ngaysinh, gioitinh, diachi, sdt;
            
        }
        List<thongtin> nguoiDung = new List<thongtin>(2);
        public thongTinCaNhan()
        {
            InitializeComponent();
            txbMaNV.Text = Login.Current_user.ID;
            UpdateNhanVien();
            txbMaNV.Text = nguoiDung[0].manv;
            txbHoTen.Text = nguoiDung[0].ten;
            dateTimePicker1.Text = nguoiDung[0].ngaysinh;
            comboBox_gioiTinh.Text = nguoiDung[0].gioitinh;
            txbSDT.Text = nguoiDung[0].sdt;
            txbDiaChi.Text = nguoiDung[0].diachi;
            button1.Focus();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------//
        
        private void UpdateNhanVien()
        {
            connection.Open();
            string sqlQuery = "";
            if (Login.Current_user.ID.Substring(0, 2) == "NV")
            {
                sqlQuery = "select * from NHANVIEN where MANV = '" + Login.Current_user.ID + "'";
            }
            else
            {
                sqlQuery = "select * from QUANLY where MAQL = '" + Login.Current_user.ID + "'";
            }
            
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                thongtin t;
                t.manv = dataReader.GetString(0);
                t.ten = dataReader.GetString(2);
                t.ngaysinh = dataReader.GetDateTime(3).ToString().Substring(0, dataReader.GetDateTime(3).ToString().IndexOf(" "));
                t.gioitinh = dataReader.GetString(4);
                t.sdt = dataReader.GetString(5);
                t.diachi = dataReader.GetString(6);
                nguoiDung.Add(t);

            }
            connection.Close();
            loadImg(Login.Current_user.ID);
        }

        private void loadImg(string id)
        {
            //load ảnh của nhân viên 
            connection.Open();
            string sqlQuery2;
            try
            {
                if (id.Substring(0, 2) == "NV")
                {
                    sqlQuery2 = "select MANV, ISNULL(ANH, '" + globalPic.anhYeuCau + "') AS ANH from NHANVIEN WHERE MANV = '" + id + "'";
                }
                else
                {
                    sqlQuery2 = "select MAQL, ISNULL(ANH, '" + globalPic.anhYeuCau + "') AS ANH from QUANLY WHERE MAQL = '" + id + "'";
                }
                SqlCommand command2 = new SqlCommand(sqlQuery2, connection);
                SqlDataReader dataReader2 = command2.ExecuteReader();
                while (dataReader2.HasRows)
                {
                    if (dataReader2.Read() == false) break;
                    else
                        pictureBox_AnhNV.Image = ByteToImg(dataReader2.GetString(1));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi cập nhật ảnh");
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------//
        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            UpdateNhanVien();
            txbMaNV.Text = nguoiDung[0].manv;
            txbHoTen.Text = nguoiDung[0].ten;
            dateTimePicker1.Text = nguoiDung[0].ngaysinh;
            comboBox_gioiTinh.Text = nguoiDung[0].gioitinh;
            txbSDT.Text = nguoiDung[0].sdt;
            txbDiaChi.Text = nguoiDung[0].diachi;
            
        }

        //------------------------------------------------------------------------------------------------------------------------------------------//

        private void button_DoiMK_Click(object sender, EventArgs e)
        {
            DoiMK doimk = new DoiMK();
            doimk.ShowDialog();
        }
 
        //------------------------------------------------------------------------------------------------------------------------------------------//
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thongTinCaNhan_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.Control == true && e.KeyCode == Keys.S))
            {
                button_save.PerformClick();

            }
            else if (e.KeyCode == Keys.Escape)
            {
                button1.PerformClick();
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------//

        private bool changed()
        {
            if (txbHoTen.Text != nguoiDung[0].ten ||
            dateTimePicker1.Text != nguoiDung[0].ngaysinh ||
            comboBox_gioiTinh.Text != nguoiDung[0].gioitinh ||
            txbSDT.Text != nguoiDung[0].sdt ||
            txbDiaChi.Text != nguoiDung[0].diachi)
            {
                return true;
            }
            else return false;
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (changed())
            {
                if (txbHoTen.Text == "" || comboBox_gioiTinh.Text == "" || txbSDT.Text == "" || txbDiaChi.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập đủ thông tin");
                    return;
                }
                try
                {
                    connection.Open();
                    string sqlQuery = "";
                    if (Login.Current_user.ID.ToString().Substring(0,2) == "QL")
                    {
                        sqlQuery = "update QUANLY set TEN = @ten, NGAYSINH = @ngaysinh, GIOITINH = @gioitinh, SDT = @sdt, DIACHI = @diachi where MAQL = @manv";
                    }
                    else
                    {
                        sqlQuery = "update NHANVIEN set TEN = @ten, NGAYSINH = @ngaysinh, GIOITINH = @gioitinh, SDT = @sdt, DIACHI = @diachi where MANV = @manv";
                    }
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Parameters.AddWithValue("@ten", txbHoTen.Text);
                    command.Parameters.AddWithValue("@ngaysinh", dateTimePicker1.Value.ToString());
                    command.Parameters.AddWithValue("@gioitinh", comboBox_gioiTinh.Text);
                    command.Parameters.AddWithValue("@sdt", txbSDT.Text);
                    command.Parameters.AddWithValue("@diachi", txbDiaChi.Text);
                    command.Parameters.AddWithValue("@manv", txbMaNV.Text);
                    try
                    {
                        if(changePic == true)
                        command.Parameters.AddWithValue("@ANH", chuyenDoiAnh_Byte(imgPath));
                    } catch (Exception)
                    {
                        MessageBox.Show("Lỗi cập nhật ảnh", "error");
                    }
                    int rs = command.ExecuteNonQuery();
                    if (rs != 1)
                    {
                        throw new Exception("Failed Query");
                    }
                    MessageBox.Show("Đã lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error:" + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Đã lưu. Không có gì thay đổi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------//
        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void comboBox_gioiTinh_Leave(object sender, EventArgs e)
        {
            if(comboBox_gioiTinh.Text != "Nam" && comboBox_gioiTinh.Text != "Nữ")
            {
                MessageBox.Show("Giới tính không hợp lệ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_gioiTinh.Text = "";
                this.ActiveControl = comboBox_gioiTinh;
            }
        }

        // --------------------- xử lý hình ảnh -----------------------------//
        // button chọn ảnh
        public string imgPath = "";
        public bool changePic = false;   // kiểmm tra có thay đổi ảnh hay không
        private void button_UpdateImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Pictures files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png)|*.jpg; *.jpeg; *.jpe; *.jfif; *.png|All files (*.*)|*.*";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                imgPath = openFile.FileName;
            }
            //labelFileName.Text = Path.GetFileName(textBox_linkToImage.Text);
            pictureBox_AnhNV.Image = ByteToImg(chuyenDoiAnh_Byte(imgPath));
            updateAnh_toSQL(imgPath);
        }
        private void updateAnh_toSQL(string imgPath)
        {
            connection.Open();
            try
            {
                string sqlQuery = "";
                if (Login.Current_user.ID.ToString().Substring(0, 2) == "QL")
                {
                    sqlQuery = "update QUANLY set ANH = @ANH where MAQL = '" + Login.Current_user.ID + "' ";
                }
                else
                {
                    sqlQuery = "update NHANVIEN set ANH = @ANH where MANV = '" + Login.Current_user.ID + "' ";
                }
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
