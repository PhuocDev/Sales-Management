using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormKhachHang : Form
    {
        SqlConnection connection = new SqlConnection(global.conString);

        public FormKhachHang()
        {
            InitializeComponent();
            UpdateKhachHang();
        }

        //------------------------------------------Update dữ liệu khách hàng vào datagridview-------------------------------------------//
        private void UpdateKhachHang()
        {
            connection.Open();
            dataGridView1.Rows.Clear();
            string sqlQuery = "select * from KHACHHANG";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int stt = 1;
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                if (dataReader.GetString(0) == "KH00000") continue;
                dataGridView1.Rows.Add(stt, dataReader.GetString(0), dataReader.GetString(1),
                    dataReader.GetDateTime(2).ToString().Substring(0, dataReader.GetDateTime(2).ToString().IndexOf(" ")),
                    dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetInt32(6));
                stt++;
            }
            connection.Close();
            connection.Open();
            try
            {
                //load ảnh của khách hàng đầu tiên
                string sqlQuery2 = "select top(2) MaKH, ISNULL(ANH, '" + globalPic.anhKHdefault + "') AS ANH from KHACHHANG ";
                SqlCommand command2 = new SqlCommand(sqlQuery2, connection);
                SqlDataReader dataReader2 = command2.ExecuteReader();
                while (dataReader2.HasRows)
                {
                    if (dataReader2.Read() == false) break;
                    else
                        pictureBox1.Image = ByteToImg(dataReader2.GetString(1));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Lỗi load ảnh khách hàng đầu tiên");
            }
            connection.Close();

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

        //---------------------------------------------------chuyển_form-------------------------------------------------------------------------//

        private void button_back_Click(object sender, EventArgs e)
        {
            this.button_save.PerformClick();
            this.Close();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.button_save.PerformClick();
            FormNhanVien nv = new FormNhanVien(change);
            nv.FormClosed += new FormClosedEventHandler(NhanVien_FormClose);
            nv.Show();
            this.Hide();
        }
        private void change()
        {
            this.Show();
        }
        private void NhanVien_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        //------------------------------------------------------cell_click-------------------------------------------------------------------------//

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;//MessageBox.Show("" + index);///////////
            txbMaKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txbHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            comboBox_gioiTinh.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txbSDT.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txbDiaChi.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            txbDiem.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            try
            {
                pictureBox1.Image = ByteToImg(getByteDataOfImg(txbMaKH.Text));
            }
            catch
            {
                pictureBox1.Image = ByteToImg(globalPic.anhKHdefault);
            }
        }

        private string getByteDataOfImg(string id)  // id là mã khách hàng để lấy data ảnh
        {
            try
            {
                connection.Open();
                string sqlQuery = "select MAKH, ISNULL(ANH, '" + globalPic.anhKHdefault + "') from KHACHHANG WHERE MAKH = '" + id + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                string dataImg = "";
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    else dataImg = dataReader.GetString(1);
                }
                connection.Close();
                return dataImg;
            }
            catch
            {
                return globalPic.anhKHdefault;
            }
        }

        //-------------------------------------------------------Chỉnh_sửa_click-------------------------------------------------------------------//

        public List<string> id_changes = new List<string>();// danh sách khách hàng bị thay đổi thông tin
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            dataGridView1.Rows[index].Cells[2].Value = txbHoTen.Text;
            dataGridView1.Rows[index].Cells[3].Value = dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().IndexOf(" "));
            dataGridView1.Rows[index].Cells[4].Value = comboBox_gioiTinh.Text;
            dataGridView1.Rows[index].Cells[5].Value = txbSDT.Text;
            dataGridView1.Rows[index].Cells[6].Value = txbDiaChi.Text;
            dataGridView1.Rows[index].Cells[7].Value = txbDiem.Text;
            id_changes.Add(dataGridView1.Rows[index].Cells[1].Value.ToString());// thêm vào danh sách khách hàng bị thay đổi thông tin
        }

        //------------------------------------------------------------xóa_khách_hàng------------------------------------------------------------------//
      
        public List<string> id_remove = new List<string>();// danh sách khách hàng bị xóa

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            if (cell == null) return;
            DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng đã chọn?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            int index = cell.RowIndex;
            id_remove.Add(dataGridView1.Rows[index].Cells[1].Value.ToString());// thêm vào danh sách khách hàng bị xóa
            dataGridView1.Rows.RemoveAt(index);
            for (int i = index; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                row.Cells[0].Value = i + 1;
            }
            txbMaKH.Text = "";
            txbHoTen.Text = "";
            dateTimePicker1.Text = "";
            comboBox_gioiTinh.Text = "";
            txbSDT.Text = "";
            txbDiaChi.Text = "";
            txbDiem.Text = "";
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)//xóa khách hàng
            {
                e.SuppressKeyPress = true;
                this.btnXoaKH.PerformClick();
            }
        }

        //------------------------------------------------------------lưu_dữ_liệu---------------------------------------------------------------------//

        public int find(string MANV)// tìm vị trí của dữ liệu bị thay đổi trong datagidview1
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[1].Value.ToString() == MANV) return i;
            }
            return -1;
        }

        private void button_save_Click(object sender, EventArgs e)
        {

            if (id_changes.Count() == 0 && id_remove.Count() == 0) return;
            DialogResult result = MessageBox.Show("Bạn có muốn lưu thay đổi?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                id_remove.Clear();
                id_changes.Clear();
                this.dataGridView1.Rows.Clear();
                UpdateKhachHang();
            }

            try
            {
                connection.Open();
                for (int i = 0; i < id_changes.Count(); i++)
                {

                    string sqlQuery = "update KHACHHANG set TEN = @ten, NGAYSINH = @ngaysinh, GIOITINH = @gioitinh, SDT = @sdt, DIACHI = @diachi, DIEM = @diem where MAKH = @makh";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    int index = find(id_changes[i]);
                    if (index == -1) continue;
                    command.Parameters.AddWithValue("@ten", dataGridView1.Rows[index].Cells[2].Value.ToString());
                    command.Parameters.AddWithValue("@ngaysinh", dataGridView1.Rows[index].Cells[3].Value.ToString());
                    command.Parameters.AddWithValue("@gioitinh", dataGridView1.Rows[index].Cells[4].Value.ToString());
                    command.Parameters.AddWithValue("@sdt", dataGridView1.Rows[index].Cells[5].Value.ToString());
                    command.Parameters.AddWithValue("@diachi", dataGridView1.Rows[index].Cells[6].Value.ToString());
                    command.Parameters.AddWithValue("@diem", dataGridView1.Rows[index].Cells[7].Value.ToString());
                    command.Parameters.AddWithValue("@makh", dataGridView1.Rows[index].Cells[1].Value.ToString());

                    int rs = command.ExecuteNonQuery();
                    if (rs != 1)
                    {
                        throw new Exception("Failed Query");
                    }
                }

                id_changes.Clear();// xóa danh sách bị thay đổi cũ

                for (int i = 0; i < id_remove.Count(); i++)
                {
                    string sqlQuery = "delete from KHACHHANG where MAKH = '" + id_remove[i] + "'";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    int rs = command.ExecuteNonQuery();
                    if (rs < 1)
                    {
                        throw new Exception("Failed Query");
                    }
                }
                id_remove.Clear(); // xóa danh sách khách hàng đã bị xóa
            }
            catch (Exception ex)
            {
                MessageBox.Show("kết nối xảy ra lỗi hoặc ghi dữ liệu bị lỗi", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        //---------------------------------------------------------Form_load------------------------------------------------------------------------//
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            if(Login.Current_user.ID.Substring(0, 2) == "NV")
            {
                this.btnNhanVien.Visible = false;
                this.btnKhachHang.Visible = false;
            }
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            txbMaKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txbHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            comboBox_gioiTinh.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txbSDT.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txbDiaChi.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            txbDiem.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
            this.ActiveControl = dataGridView1;
        }

        //------------------------------------------------------ràng_buộc_MAKH----------------------------------------------------------//

        private void txbMaKH_Leave(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            txbMaKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            this.label_warning.Text = "";
        }

        private void txbMaKH_Enter(object sender, EventArgs e)
        {
            this.label_warning.Text = "Không thể thay đổi mã khách hàng";
        }


        //-------------------------------------------------------------thêm_nhân_viên----------------------------------------------------------//

        private void btnThemKH_Click(object sender, EventArgs e)
        {
            button_save.PerformClick();
            AddKhachHang kh = new AddKhachHang(this);
            kh.ShowDialog();
            UpdateKhachHang();
        }
        public void add_datagridview(string makh, string ten, string ngaysinh, string gioitinh, string sdt, string diachi, string diem)
        {
            this.dataGridView1.Rows.Add(this.dataGridView1.Rows.Count + 1, makh, ten, ngaysinh, gioitinh, sdt, diachi, Convert.ToInt32(diem));
        }

        //---------------------------------------------------------------xuất_file---------------------------------------------------------------//
        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Bảng dữ liệu trống", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XLSX (*.xlsx)|*.xlsx";
            sfd.FileName = "DanhSachKhachHang.xlsx";
            bool fileError = false;
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(sfd.FileName))
                {
                    try
                    {
                        File.Delete(sfd.FileName);
                    }
                    catch (IOException ex)
                    {
                        fileError = true;
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
                if (!fileError)
                {
                    try
                    {
                        Microsoft.Office.Interop.Excel.Application app = new Microsoft.Office.Interop.Excel.Application();
                        Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
                        Microsoft.Office.Interop.Excel.Worksheet worksheet = null;
                        //app.Visible = true;
                        worksheet = workbook.Sheets["Sheet1"];
                        worksheet = workbook.ActiveSheet;
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
                        }
                        for (int i = 0; i < dataGridView1.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView1.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            worksheet.Columns[i + 1].AutoFit();
                        }
                        workbook.SaveAs(sfd.FileName);
                        app.Quit();
                        MessageBox.Show("Xuất file thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------//
        private void comboBox_gioiTinh_Leave(object sender, EventArgs e)
        {
            if (comboBox_gioiTinh.Text != "Nam" && comboBox_gioiTinh.Text != "Nữ")
            {
                MessageBox.Show("Giới tính không hợp lệ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_gioiTinh.Text = "";
                this.ActiveControl = comboBox_gioiTinh;
            }
        }

        private void txbSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbDiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

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
        private string chuyenDoiAnh_Byte(string path)
        {
            if (!File.Exists(path)) return null;
            // chuỗi dùng để lưu vào database
            string byteOfImag = Convert.ToBase64String(converImgToByte(path));
            return byteOfImag;
            // Để cover đoạn chuỗi trên trở lại kiểu Byte hình ảnh thì dùng đoạn code sau:
            //Convert.FromBase64String(Đoạn_String_đã_cover);
        }
        private void updateAnh_toSQL(string imgPath)
        {
            if (!File.Exists(imgPath)) return;
            connection.Open();
            try
            {
                string sqlQuery = "";
                sqlQuery = "update KHACHHANG set ANH = @ANH where MAKH = '" + txbMaKH.Text + "'";
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
                Image tempImage = pictureBox1.Image;
                pictureBox1.Image = ByteToImg(chuyenDoiAnh_Byte(imgPath));
                DialogResult result = MessageBox.Show("Bạn có muốn lưu ảnh?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No)
                {
                    pictureBox1.Image = tempImage;
                    return;
                }
                updateAnh_toSQL(imgPath);
            }
        }
    }
}
