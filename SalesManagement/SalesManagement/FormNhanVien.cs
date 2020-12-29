using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{ 
    public delegate void changeform();
    public partial class FormNhanVien : Form
    {
        public changeform change;
        public FormNhanVien()
        {
            InitializeComponent();
        }
        public FormNhanVien(changeform change)
        {
            InitializeComponent();
            this.change = change;
        }
        //public static string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        public SqlConnection connection = new SqlConnection(global.conString);

        //------------------------------------------------update_Nhân viên----------------------------------------//
        private void UpdateNhanVien()
        {
            connection.Open();
            string sqlQuery = "select * from NHANVIEN";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int stt = 1;
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                dataGridView1.Rows.Add(stt, dataReader.GetString(0), dataReader.GetString(2), dataReader.GetDateTime(3).ToString().Substring(0, dataReader.GetDateTime(3).ToString().IndexOf(" ")),
                    dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6));
                stt++;
                //pictureBox1.Image = ByteToImg(dataReader.GetString(8));
            }
            connection.Close();
        }

        //-------------------------------------------------chuyển-form----------------------------------------------------------//

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            this.button_save.PerformClick();
            this.change();
            this.Hide();
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            this.button_save.PerformClick();
            this.Close();
        }

        //--------------------------------------thêm-nhân-viên---------------------------------------------------------------------//
        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if(Login.Current_user.ID.Substring(0, 2) == "QL")
            {
                SignUp sn = new SignUp(this);
                sn.ShowDialog();
            }
            else
            {
                MessageBox.Show("Tài khoản không được cấp quyền thêm nhân viên ");
            }
        }
        public void add_datagridview(string manv, string ten, string ngaysinh, string gioitinh, string sdt, string diachi)
        {
            this.dataGridView1.Rows.Add(this.dataGridView1.Rows.Count + 1, manv, ten, ngaysinh, gioitinh, sdt, diachi);
        }

        //-----------------------------------------------cell_click---------------------------------------------------------//

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)//xem thông tin từng người
        {
            this.label_warning.Text = "";
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            txbMaNV.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txbHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            comboBox_gioiTinh.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txbSDT.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txbDiaChi.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            pictureBox1.Image = ByteToImg(getByteDataOfImg(txbMaNV.Text));
        }
        // hình ảnh mặc định
        public string defaultPicture = @"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ZoBgBDNAMIIZIBjBDBCMYAYIRjADBCOYAYIRzADBCGaAYAQzQDCCGSAYwQwQjGAGCEYwAwQjmAGCEcwAwQhmgGAEM0AwghkgGMEMEIxgBghGMAMEI5gBghHMAMEIZoBgBDNAMIIZIBjBDBCMYAYIRjADBCOYAYIRzADBCGaAYAQzQDCCGSAYwQwQjGAGCEYwAwQjmAGCEcwAwQhmgGAEM0AwghkgGMEMEIxgBghGMAMEI5gBghHMAMEIZoBgBDNAMIIZIBjBDBCMYAYIRjADBCOYAYIRzADBCGaAYAQzQDCCGSAYwQwQjGAGCEYwAwQjmAGCEcwAwQhmgGAEM0AwghkgGMEMEIxgBghGMAMEI5gBghHMAMEIZoBgBDNAMIIZIBjBDBCMYAYIRjADBCOYAYIRzADBCGaAYAQzQDCCGSAYwQwQjGAGCEYwAwQjmAGCEcwAwQhmgGAEM0AwghkgGMEMEIxgBghGMAMEI5gBghHMAMEIZoBgBDNAMIIZIBjBDBCMYAYIRjADBCOYAYIRzADBCGaAYAQzQDCCGSAYwQwQjGAGCEYwAwQjmAGCEcwAwQhmgGAEM0AwghkgGMEMEIxgBghGMAMEI5gBghHMAMEIZoBgBDNAMIIZIBjBDBCMYAYIRjADBCOYAYIRzADBCGaAYAQzQDCCGSAYwQwQjGAGCEYwAwQjmAGCEcwAwQhmgGAEM0AwghkgGMEMEIxgBghGMAMEI5gBghHMAMEIZoBgBDNAMIIZIBjBDBCMYAYIRjADBCOYAYIRzADBCGaAYAQzQDCCGSAYwQwQjGAGCEYwAwQjmAGCEcwAwQhmgGAEM0AwghkgGMEMEIxgBghGMAMEI5gBghHMAMEIZoBgBDNAMIIZIBjBDBCMYAYIRjADBCOYAYIRzADBCGaAYAQzQDCCGSAYwQwQjGAGCEYwAwQjmAGCEcwAwQhmgGAEM0AwghkgGMEMEIxgBghGMAMEI5gBghHMAMEIZoBgBDNAMIIZIBjBDBCMYAYIRjADBCOYAYIRzADBCGaAYAQzQDCCGSAYwQwQSkr/BwI8fkMYaB8KAAAAAElFTkSuQmCC";
        private string getByteDataOfImg(string id)  // id là mã nhân viên để lấy data ảnh
         {
            connection.Open();
            string sqlQuery = "select MANV, ISNULL(ANH, '" + defaultPicture + "') from NHANVIEN WHERE MANV = '" + id + "'";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            string dataImg = "";
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
            
                    dataImg = dataReader.GetString(1);
            }
            connection.Close();
            return dataImg;
        }
        //-----------------------------------------------------chỉnh sửa_click-------------------------------------------------//

        public List<string> id_changes = new List<string>();// danh sách nhân viên bị thay đổi thông tin
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (Login.Current_user.ID.Substring(0, 2) == "QL")
            {
                if(txbHoTen.Text == "" || comboBox_gioiTinh.Text == "" || txbSDT.Text == "" || txbDiaChi.Text == "")
                {
                    MessageBox.Show("Bạn cần nhập đủ thông tin");
                    return;
                }
                DataGridViewCell cell = dataGridView1.CurrentCell;
                int index = cell.RowIndex;
                dataGridView1.Rows[index].Cells[2].Value = txbHoTen.Text;
                dataGridView1.Rows[index].Cells[3].Value = dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().IndexOf(" "));
                dataGridView1.Rows[index].Cells[4].Value = comboBox_gioiTinh.Text;
                dataGridView1.Rows[index].Cells[5].Value = txbSDT.Text;
                dataGridView1.Rows[index].Cells[6].Value = txbDiaChi.Text;
                id_changes.Add(dataGridView1.Rows[index].Cells[1].Value.ToString());// thêm vào danh sách nhân viên bị thay đổi thông tin
            }
            else
            {
                MessageBox.Show("Tài khoản không được cấp quyền chỉnh sửa");
            }
           
        }

        //-------------------------------xóa nhân viên--------------------------------------------------------------//

        public List<string> id_remove = new List<string>();// danh sách nhân viên bị xóa
        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if(Login.Current_user.ID.Substring(0, 2) == "QL")
            {
                DialogResult result = MessageBox.Show("Bạn có muốn xóa nhân viên đã chọn?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;

                DataGridViewCell cell = dataGridView1.CurrentCell;
                if (cell == null) return;
                int index = cell.RowIndex;
                id_remove.Add(dataGridView1.Rows[index].Cells[1].Value.ToString());// thêm vào danh sách nhân viên bị xóa
                dataGridView1.Rows.RemoveAt(index);
                for (int i = index; i < dataGridView1.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView1.Rows[i];
                    row.Cells[0].Value = i + 1;
                }
                txbMaNV.Text = "";
                txbHoTen.Text = "";
                dateTimePicker1.Text = "";
                comboBox_gioiTinh.Text = "";
                txbSDT.Text = "";
                txbDiaChi.Text = "";
            }
            else
            {
                MessageBox.Show("Tài khoản không được cấp quyền xóa nhân viên");
            }
        }
        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)//xóa nhân viên
            {
                e.SuppressKeyPress = true;
                this.btnXoaNV.PerformClick();
            }
        }
        //-----------------------------------------lưu thông tin thay đổi----------------------------------------------------//

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
                id_changes.Clear();
                id_remove.Clear();
                this.dataGridView1.Rows.Clear();
                UpdateNhanVien();
            }

            try
            {
                connection.Open();
                for (int i = 0; i < id_changes.Count(); i++)
                {

                    string sqlQuery = "update NHANVIEN set TEN = @ten, NGAYSINH = @ngaysinh, GIOITINH = @gioitinh, SDT = @sdt, DIACHI = @diachi, ANH = @anh where MANV = @manv";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    int index = find(id_changes[i]);
                    command.Parameters.AddWithValue("@ten", dataGridView1.Rows[index].Cells[2].Value.ToString());
                    command.Parameters.AddWithValue("@ngaysinh", dataGridView1.Rows[index].Cells[3].Value.ToString());
                    command.Parameters.AddWithValue("@gioitinh", dataGridView1.Rows[index].Cells[4].Value.ToString());
                    command.Parameters.AddWithValue("@sdt", dataGridView1.Rows[index].Cells[5].Value.ToString());
                    command.Parameters.AddWithValue("@diachi", dataGridView1.Rows[index].Cells[6].Value.ToString());
                    command.Parameters.AddWithValue("@manv", dataGridView1.Rows[index].Cells[1].Value.ToString());
                    command.Parameters.AddWithValue("@anh", chuyenDoiAnh_Byte(imgPath));

                    int rs = command.ExecuteNonQuery();
                    if (rs != 1)
                    {
                        throw new Exception("Failed Query");
                    }
                }

                id_changes.Clear();// xóa danh sách bị thay đổi cũ

                for(int i = 0; i < id_remove.Count(); i++)
                {
                    string sqlQuery = "delete from NHANVIEN where MANV = '" + id_remove[i] + "'";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    int rs = command.ExecuteNonQuery();
                    if (rs != 1)
                    {
                        throw new Exception("Failed Query");
                    }
                }
                id_remove.Clear(); // xóa danh sách nhân viên đã bị xóa
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connection.Close();
            }
        }

        //-----------------------------------------------------------form_load----------------------------------------------------------//

        private void FormNhanVien_Load(object sender, EventArgs e)
        {
            UpdateNhanVien();
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            txbMaNV.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txbHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            comboBox_gioiTinh.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txbSDT.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txbDiaChi.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            this.ActiveControl = dataGridView1;
        }

        private void txbMaNV_Leave(object sender, EventArgs e)// tránh việc MANV bị thay đổi
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            txbMaNV.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            this.label_warning.Text = "";
        }

        private void txbMaNV_Enter(object sender, EventArgs e)// thông báo nhân viên thay đổi
        {
            label_warning.Text = "*Không thể thay đổi mã nhân viên";
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------//
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnXuatFile_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count == 0)
            {
                MessageBox.Show("Bảng dữ liệu trống");
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XLSX (*.xlsx)|*.xlsx";
            sfd.FileName = "DanhSachNhanVien.xlsx";
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
                        MessageBox.Show("Error: " + ex.Message , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
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



        // ----------------------------------- phần code dành cho việc xử lý hình ảnh ------------------------------------//
        // code chuyển từ ảnh sang byte
        private byte[] converImgToByte(string path)
        {
            FileStream fs;
            // lưu ý đã mở ra là phải chọn, nếu không chọn ấn Cancel sẽ bị lỗi
            fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            byte[] picbyte = new byte[fs.Length];
            fs.Read(picbyte, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return picbyte;
        }
        //code chuyển từ byte sang hình ảnh
        private Image ByteToImg(string byteString)    // chứa đoạn string byte của images
        {
            byte[] imgBytes = Convert.FromBase64String(byteString);
            MemoryStream ms = new MemoryStream(imgBytes, 0, imgBytes.Length);
            ms.Write(imgBytes, 0, imgBytes.Length);
            Image image = Image.FromStream(ms, true);
            return image;
        }

        private string chuyenDoiAnh_Byte(string path)
        {
            // chuỗi dùng để lưu vào database
            string byteOfImag = Convert.ToBase64String(converImgToByte(path));
            return byteOfImag;
            // Để cover đoạn chuỗi trên trở lại kiểu Byte hình ảnh thì dùng đoạn code sau:
            //Convert.FromBase64String(Đoạn_String_đã_cover);
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
                imgPath = openFile.FileName;
            }
            //labelFileName.Text = Path.GetFileName(textBox_linkToImage.Text);
            pictureBox1.Image = ByteToImg(chuyenDoiAnh_Byte(imgPath));
            
        }
    }
}
