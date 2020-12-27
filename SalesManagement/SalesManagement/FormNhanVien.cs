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

                    string sqlQuery = "update NHANVIEN set TEN = @ten, NGAYSINH = @ngaysinh, GIOITINH = @gioitinh, SDT = @sdt, DIACHI = @diachi where MANV = @manv";
                    SqlCommand command = new SqlCommand(sqlQuery, connection);

                    int index = find(id_changes[i]);
                    command.Parameters.AddWithValue("@ten", dataGridView1.Rows[index].Cells[2].Value.ToString());
                    command.Parameters.AddWithValue("@ngaysinh", dataGridView1.Rows[index].Cells[3].Value.ToString());
                    command.Parameters.AddWithValue("@gioitinh", dataGridView1.Rows[index].Cells[4].Value.ToString());
                    command.Parameters.AddWithValue("@sdt", dataGridView1.Rows[index].Cells[5].Value.ToString());
                    command.Parameters.AddWithValue("@diachi", dataGridView1.Rows[index].Cells[6].Value.ToString());
                    command.Parameters.AddWithValue("@manv", dataGridView1.Rows[index].Cells[1].Value.ToString());

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
                MessageBox.Show("kết nối xảy ra lỗi hoặc ghi dữ liệu bị lỗi");
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
                        MessageBox.Show("Xuất file excel thành công", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message , "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void comboBox_gioiTinh_Leave(object sender, EventArgs e)
        {
            if (comboBox_gioiTinh.Text != "Nam" && comboBox_gioiTinh.Text != "Nữ")
            {
                MessageBox.Show("Giới tính không hợp lệ", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBox_gioiTinh.Text = "";
                this.ActiveControl = comboBox_gioiTinh;
            }
        }
    }
}
