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
    public partial class NhapHang : Form
    {
        public changeform change;
        public NhapHang()
        {
            InitializeComponent();
        }
        public NhapHang(changeform change)
        {
            InitializeComponent();
            this.change = change;
        }
        SqlConnection connection = new SqlConnection(global.conString);

        //-------------------------------------------------------------thêm----------------------------------------------------------------------------//

        private void button_them_Click(object sender, EventArgs e)
        {
            if (textBox_tensp.Text == "" || textBox_masp.Text == "" || textBox_sluong.Text == "" || textBox_giaNhap.Text == "" || textBox_giaBan.Text == "" || textBox_dvt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dủ thông tin cần thiết");
                return;
            }
            for (int i = 0; i < dataGridView_danhSachSanPham.Rows.Count; i++)
            {
                if(textBox_masp.Text == dataGridView_danhSachSanPham.Rows[i].Cells[1].Value.ToString())
                {
                    DialogResult result =  MessageBox.Show("Sản phẩm đã có trong danh sách, bạn có muốn thay thế", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (result == DialogResult.No) return;
                    else
                    {
                        dataGridView_danhSachSanPham.Rows.RemoveAt(i);
                        break;
                    }
                }
            }

            dataGridView_danhSachSanPham.Rows.Add(dataGridView_danhSachSanPham.Rows.Count + 1, textBox_masp.Text, 
                textBox_tensp.Text, textBox_sluong.Text, textBox_dvt.Text, textBox_giaNhap.Text, textBox_giaBan.Text, 
                dateTimePicker1_hsd.Value.ToString().Substring(0, dateTimePicker1_hsd.Value.ToString().IndexOf(" ")), textBox_nhacc.Text, textBox_ghiChu.Text);
        }
        //--------------------------------------------------------------------chỉnh_sửa----------------------------------------------------------------------//
        private void button_chinhSua_Click(object sender, EventArgs e)
        {
            if (textBox_tensp.Text == "" || textBox_masp.Text == "" || textBox_sluong.Text == "" || textBox_giaNhap.Text == "" || textBox_giaBan.Text == "" || textBox_dvt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dủ thông tin cần thiết");
                return;
            }
            for (int i = 0; i < dataGridView_danhSachSanPham.Rows.Count; i++)
            {
                if (textBox_masp.Text == dataGridView_danhSachSanPham.Rows[i].Cells[1].Value.ToString())
                {
                    dataGridView_danhSachSanPham.Rows[i].Cells[1].Value = textBox_masp.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[2].Value = textBox_tensp.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[3].Value = textBox_sluong.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[4].Value = textBox_dvt.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[5].Value = textBox_giaNhap.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[6].Value = textBox_giaBan.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[7].Value = dateTimePicker1_hsd.Value.ToString().Substring(0, dateTimePicker1_hsd.Value.ToString().IndexOf(" "));
                    dataGridView_danhSachSanPham.Rows[i].Cells[8].Value = textBox_nhacc.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[9].Value = textBox_ghiChu.Text;
                    return;
                }
            }
        }
        //-----------------------------------------------------------------xóa------------------------------------------------------------------------//
        private void button_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Bạn có chắc muốn xóa sản phẩm đã chọn", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                DataGridViewCell cell = dataGridView_danhSachSanPham.CurrentCell;
                if (cell == null) return;
                int index = cell.RowIndex;
                dataGridView_danhSachSanPham.Rows.RemoveAt(index);
                for(int i = dataGridView_danhSachSanPham.CurrentCell.RowIndex; i< dataGridView_danhSachSanPham.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView_danhSachSanPham.Rows[i];
                    row.Cells[0].Value = i + 1;
                }
                textBox_masp.Text = "";
                textBox_tensp.Text = "";
                textBox_sluong.Text = "";
                textBox_dvt.Text = "";
                textBox_giaNhap.Text = "";
                textBox_giaBan.Text = "";
                dateTimePicker1_hsd.Text = "";
                textBox_nhacc.Text = "";
                textBox_ghiChu.Text = "";
            }
        }
        //----------------------------------------------------------------chuyển_forrm----------------------------------------------------------------//
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.change();
        }

        //---------------------------------------------------------------cell_click--------------------------------------------------------------------//
        private void dataGridView_danhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView_danhSachSanPham.CurrentCell;
            int index = cell.RowIndex;
            textBox_masp.Text = dataGridView_danhSachSanPham.Rows[index].Cells[1].Value.ToString();
            textBox_tensp.Text = dataGridView_danhSachSanPham.Rows[index].Cells[2].Value.ToString();
            textBox_sluong.Text = dataGridView_danhSachSanPham.Rows[index].Cells[3].Value.ToString();
            textBox_dvt.Text = dataGridView_danhSachSanPham.Rows[index].Cells[4].Value.ToString();
            textBox_giaNhap.Text = dataGridView_danhSachSanPham.Rows[index].Cells[5].Value.ToString();
            textBox_giaBan.Text = dataGridView_danhSachSanPham.Rows[index].Cells[6].Value.ToString();
            dateTimePicker1_hsd.Text = dataGridView_danhSachSanPham.Rows[index].Cells[7].Value.ToString();
            textBox_nhacc.Text = dataGridView_danhSachSanPham.Rows[index].Cells[8].Value.ToString();
            textBox_ghiChu.Text = dataGridView_danhSachSanPham.Rows[index].Cells[9].Value.ToString();
        }
        //-------------------------------------------------------điều_kiện_nhập------------------------------------------------------------------------------//
        private void textBox_sluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_giaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_giaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //-------------------------------------------------------------------lưu_kho---------------------------------------------------------------------------//
        private void button_luuKho_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn lưu dữ liệu?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No) return;


            try
            {
                for(int i = 0; i< dataGridView_danhSachSanPham.Rows.Count; i++)
                {
                    if (Check_MaSP(dataGridView_danhSachSanPham.Rows[i].Cells[1].Value.ToString()))
                    {
                        update_list.Add(dataGridView_danhSachSanPham.Rows[i].Cells[1].Value.ToString());
                    }
                }
            }
            catch (Exception ex)
            {

            }
            finally
            {

            }

            try
            {
                connection.Open();
                for (int i = 0; i < dataGridView_danhSachSanPham.Rows.Count; i++)
                {
                    string sqlQuery;
                    if (update_list.Contains(dataGridView_danhSachSanPham.Rows[i].Cells[1].Value.ToString()))
                    {
                        sqlQuery = "update SANPHAM set SOLUONG = SOLUONG + @sl where MASP = @masp";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);
                        command.Parameters.AddWithValue("@masp", dataGridView_danhSachSanPham.Rows[i].Cells[1].Value.ToString());
                        command.Parameters.AddWithValue("@sl", Convert.ToInt32(dataGridView_danhSachSanPham.Rows[i].Cells[3].Value));
                        int rs1 = command.ExecuteNonQuery();
                        if (rs1 != 1)
                        {
                           throw new Exception("Failed Query");
                        }
                    }
                    else
                    {
                        sqlQuery = "INSERT INTO SANPHAM VALUES( @masp, @ten, @sl, @dvt , @giaNhap, @giaBanLe, @hsd, @nhacc, @ghichu)";
                        SqlCommand command = new SqlCommand(sqlQuery, connection);

                        command.Parameters.Add("@masp", SqlDbType.NVarChar).Value = dataGridView_danhSachSanPham.Rows[i].Cells[1].Value.ToString();
                        command.Parameters.Add("@ten", SqlDbType.NVarChar).Value = dataGridView_danhSachSanPham.Rows[i].Cells[2].Value.ToString();
                        command.Parameters.AddWithValue("@sl", SqlDbType.NVarChar).Value = Convert.ToInt32(dataGridView_danhSachSanPham.Rows[i].Cells[3].Value);
                        command.Parameters.AddWithValue("@dvt", SqlDbType.NVarChar).Value = dataGridView_danhSachSanPham.Rows[i].Cells[4].Value.ToString();
                        command.Parameters.AddWithValue("@giaNhap", SqlDbType.NVarChar).Value = Convert.ToInt32(dataGridView_danhSachSanPham.Rows[i].Cells[5].Value);
                        command.Parameters.AddWithValue("@giaBanLe", SqlDbType.NVarChar).Value = Convert.ToInt32(dataGridView_danhSachSanPham.Rows[i].Cells[6].Value);
                        command.Parameters.AddWithValue("@hsd", SqlDbType.NVarChar).Value = dataGridView_danhSachSanPham.Rows[i].Cells[7].Value.ToString();
                        command.Parameters.AddWithValue("@nhacc", SqlDbType.NVarChar).Value = dataGridView_danhSachSanPham.Rows[i].Cells[8].Value.ToString();
                        command.Parameters.AddWithValue("@ghichu", SqlDbType.NVarChar).Value = dataGridView_danhSachSanPham.Rows[i].Cells[9].Value.ToString();

                        int rs = command.ExecuteNonQuery();
                        if (rs != 1)
                        {
                            throw new Exception("Failed Query");
                        }
                    } 
                }
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

        List<string> update_list = new List<string>();
        private bool Check_MaSP(string masp)
        {
            connection.Open();
            string sqlQuery = "select MASP from SANPHAM";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                if (dataReader.GetString(0) == masp)
                {
                    connection.Close();
                    return true;
                }
            }
            connection.Close();
            return false;
        }

        private void button_xuatFile_Click(object sender, EventArgs e)
        {
            if (dataGridView_danhSachSanPham.Rows.Count == 0)
            {
                MessageBox.Show("Bảng dữ liệu trống", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "XLSX (*.xlsx)|*.xlsx";
            sfd.FileName = "DanhSachNhapHang.xlsx";
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
                        for (int i = 0; i < dataGridView_danhSachSanPham.Columns.Count; i++)
                        {
                            worksheet.Cells[1, i + 1] = dataGridView_danhSachSanPham.Columns[i].HeaderText;
                        }
                        worksheet.Columns[2].NumberFormat = "0";
                        for (int i = 0; i < dataGridView_danhSachSanPham.Rows.Count; i++)
                        {
                            for (int j = 0; j < dataGridView_danhSachSanPham.Columns.Count; j++)
                            {
                                worksheet.Cells[i + 2, j + 1] = dataGridView_danhSachSanPham.Rows[i].Cells[j].Value.ToString();
                            }
                        }
                        for (int i = 0; i < dataGridView_danhSachSanPham.Columns.Count; i++)
                        {
                            worksheet.Columns[i + 1].AutoFit();
                        }
                        workbook.SaveAs(sfd.FileName);
                        app.Quit();
                        MessageBox.Show("Xuất file excel thành công");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
