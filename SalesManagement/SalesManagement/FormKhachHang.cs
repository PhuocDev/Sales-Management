using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormKhachHang : Form
    {
        //public static string conString = @"Server=DESKTOP-IRREIHM\SQLEXPRESS;Database=SALES_MANAGEMENT;User Id=sa;Password=thanh08052001;";
        SqlConnection connection = new SqlConnection(global.conString);
        public changeform change;
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
                dataGridView1.Rows.Add(stt, dataReader.GetString(0), dataReader.GetString(1),
                    dataReader.GetDateTime(2).ToString().Substring(0, dataReader.GetDateTime(2).ToString().IndexOf(" ")),
                    dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetInt32(6));
                stt++;
            }
            connection.Close();
        }

        //---------------------------------------------------chuyển_form-------------------------------------------------------------------------//
        public FormKhachHang(changeform change)
        {
            InitializeComponent();
            UpdateKhachHang();
            this.change = change;
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.button_save.PerformClick();
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.button_save.PerformClick();
            this.change();
            this.Hide();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.button_save.PerformClick();
            this.change();
            this.Hide();
        }

        //------------------------------------------------------cell_click-------------------------------------------------------------------------//

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;//MessageBox.Show("" + index);///////////
            txbMaKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txbHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txbGioiTinh.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txbSDT.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txbDiaChi.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            txbDiem.Text = dataGridView1.Rows[index].Cells[7].Value.ToString();
        }

        //-------------------------------------------------------Chỉnh_sửa_click-------------------------------------------------------------------//

        public List<string> id_changes = new List<string>();// danh sách khách hàng bị thay đổi thông tin
        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            dataGridView1.Rows[index].Cells[2].Value = txbHoTen.Text;
            dataGridView1.Rows[index].Cells[3].Value = dateTimePicker1.Value.ToString().Substring(0, dateTimePicker1.Value.ToString().IndexOf(" "));
            dataGridView1.Rows[index].Cells[4].Value = txbGioiTinh.Text;
            dataGridView1.Rows[index].Cells[5].Value = txbSDT.Text;
            dataGridView1.Rows[index].Cells[6].Value = txbDiaChi.Text;
            dataGridView1.Rows[index].Cells[6].Value = txbDiem.Text;
            id_changes.Add(dataGridView1.Rows[index].Cells[1].Value.ToString());// thêm vào danh sách khách hàng bị thay đổi thông tin
        }

        //------------------------------------------------------------xóa_khách_hàng------------------------------------------------------------------//
      
        public List<string> id_remove = new List<string>();// danh sách khách hàng bị xóa

        private void btnXoaKH_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn xóa khách hàng đã chọn?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;

            DataGridViewCell cell = dataGridView1.CurrentCell;
            if (cell == null) return;
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
            txbGioiTinh.Text = "";
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
                    if (rs != 1)
                    {
                        throw new Exception("Failed Query");
                    }
                }
                id_remove.Clear(); // xóa danh sách khách hàng đã bị xóa
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

        //---------------------------------------------------------Form_load------------------------------------------------------------------------//
        private void FormKhachHang_Load(object sender, EventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            txbMaKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txbHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txbGioiTinh.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
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
            AddKhachHang kh = new AddKhachHang(this);
            kh.ShowDialog();
            UpdateKhachHang();
        }
        public void add_datagridview(string makh, string ten, string ngaysinh, string gioitinh, string sdt, string diachi, string diem)
        {
            this.dataGridView1.Rows.Add(this.dataGridView1.Rows.Count + 1, makh, ten, ngaysinh, gioitinh, sdt, diachi, Convert.ToInt32(diem));
        }
    }
}
