using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class FormHoaDon : Form
    {
        List<ClassSanPham> listSanPham;
        List<string> listMaKH;
        string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        public FormHoaDon()
        {
            InitializeComponent();
            listSanPham = new List<ClassSanPham>();
            listMaKH = new List<string>();
            UpdateDanhSachSP();
            UpdateDanhSachKH();
            txbThoiGian.Text = DateTime.Now.ToString();
            txbMaHD.Text = GetMaHD();
            //txbNhanVien.Text == GetUser();    //Them function GetUser() tra ve string ten User
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateDanhSachSP()
        {
            //string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string sqlQuery = "SELECT * FROM SANPHAM";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                ClassSanPham sanPham = new ClassSanPham(dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2),
                    dataReader.GetString(3), dataReader.GetInt32(4), dataReader.GetInt32(5), dataReader.GetDateTime(6),
                    dataReader.GetString(7), dataReader.GetString(8));
                listSanPham.Add(sanPham);
                cbbTenSP.Items.Add(dataReader.GetString(1));
            }
            connection.Close();
        }
        private void UpdateDanhSachKH()
        {
            //string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string sqlQuery = "SELECT * FROM KHACHHANG";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                listMaKH.Add(dataReader.GetString(0));
                cbbKH.Items.Add(dataReader.GetString(0));
            }
            connection.Close();
        }
        private string GetMaHD()
        {
            //string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string sqlQuery = "SELECT * FROM HOADON WHERE THOIGIAN IN (SELECT MAX(THOIGIAN) FROM HOADON)";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            string maHD;
            string[] months = { "Key months of year", "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
            DateTime dateTime = DateTime.Now;
            string stringYear = dateTime.Year.ToString();
            if (dataReader.HasRows == false)
            {
                maHD = stringYear[2].ToString() + stringYear[3].ToString() + months[dateTime.Month] + "0001";
                return maHD;
            }
            maHD = stringYear[2].ToString() + stringYear[3].ToString() + months[dateTime.Month];
            dataReader.Read();
            string maHDTruoc = dataReader.GetString(0);
            if (maHD == maHDTruoc.Substring(0, 5)) {
                string soThuTuHD = "0000" + Convert.ToString(Convert.ToInt32(maHDTruoc.Substring(5)) + 1);
                soThuTuHD = soThuTuHD.Substring(soThuTuHD.Length - 4);
                maHD = maHD + soThuTuHD;
                return maHD;
            }
            else
            {
                maHD = maHD + "0001";
                return maHD;
            }
        }
        private void UpdateTongThanhToan()
        {
            int tongThanhToan = 0;
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {
                tongThanhToan += Convert.ToInt32(dgvHoaDon.Rows[i].Cells[6].Value);
            }
            //txbTongThanhToan.Text = tongThanhToan.ToString();
            txbTongThanhToan.Text = string.Format(CultureInfo.CreateSpecificCulture("vi-VN"), "{0:C0}", tongThanhToan);
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {
                if (dgvHoaDon.Rows[i].Cells[2].Value.ToString() == cbbTenSP.Text)
                {
                    dgvHoaDon.Rows[i].Cells[3].Value = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[3].Value) + Convert.ToInt32(nudSoLuong.Value);
                    dgvHoaDon.Rows[i].Cells[6].Value = Convert.ToInt32(Convert.ToInt32(dgvHoaDon.Rows[i].Cells[3].Value) * Convert.ToInt32(dgvHoaDon.Rows[i].Cells[5].Value));
                    dgvHoaDon.ClearSelection();
                    dgvHoaDon.Rows[i].Selected = true;
                    UpdateTongThanhToan();
                    return;
                }
            }
            bool timThaySanPham = false;
            foreach (var sanPham in listSanPham)
            {
                if (sanPham.tenSP == cbbTenSP.Text)
                {
                    dgvHoaDon.Rows.Add(dgvHoaDon.Rows.Count, sanPham.maSP, sanPham.tenSP, Convert.ToInt32(nudSoLuong.Value), sanPham.donViTinh,
                        sanPham.giaBan, Convert.ToInt32(nudSoLuong.Value) * sanPham.giaBan);
                    timThaySanPham = true;
                    dgvHoaDon.ClearSelection();
                    dgvHoaDon.Rows[dgvHoaDon.Rows.Count - 2].Selected = true;
                    UpdateTongThanhToan();
                    break;
                }
            }
            if (timThaySanPham == false) MessageBox.Show("Khong tim thay san pham: " + cbbTenSP.Text);
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvHoaDon.CurrentCell;
            int index = cell.RowIndex;
            dgvHoaDon.Rows[index].Selected = true;
            cbbTenSP.Text = dgvHoaDon.SelectedRows[0].Cells[2].Value.ToString();
            nudSoLuong.Value = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells[3].Value);
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count != 1) return;
            bool timThaySanPham = false;
            foreach (var sanPham in listSanPham)
            {
                if (sanPham.tenSP == cbbTenSP.Text)
                {
                    timThaySanPham = true;
                    break;
                }
            }
            if (timThaySanPham == false) MessageBox.Show("Khong tim thay san pham: " + cbbTenSP.Text);
            if (dgvHoaDon.SelectedRows[0].Cells[2].Value.ToString() == cbbTenSP.Text)
            {
                dgvHoaDon.SelectedRows[0].Cells[3].Value = nudSoLuong.Value;
                dgvHoaDon.SelectedRows[0].Cells[6].Value = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells[3].Value) * Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells[5].Value);
                UpdateTongThanhToan();
                return;
            }
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {
                if (i == dgvHoaDon.SelectedRows[0].Index) continue;
                if (dgvHoaDon.Rows[i].Cells[2].Value.ToString() == cbbTenSP.Text)
                {
                    MessageBox.Show("Da co san pham '" + cbbTenSP.Text + "' trong danh sach");
                    return;
                }
            }
            foreach (var sanPham in listSanPham)
            {
                if (sanPham.tenSP == cbbTenSP.Text)
                {
                    dgvHoaDon.SelectedRows[0].Cells[1].Value = sanPham.maSP;
                    dgvHoaDon.SelectedRows[0].Cells[2].Value = sanPham.tenSP;
                    dgvHoaDon.SelectedRows[0].Cells[3].Value = nudSoLuong.Value;
                    dgvHoaDon.SelectedRows[0].Cells[4].Value = sanPham.donViTinh;
                    dgvHoaDon.SelectedRows[0].Cells[5].Value = sanPham.giaBan;
                    dgvHoaDon.SelectedRows[0].Cells[6].Value = Convert.ToInt32(nudSoLuong.Value) * sanPham.giaBan;
                    UpdateTongThanhToan();
                    return;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (dgvHoaDon.SelectedRows.Count == 0) return;
            List<int> rowIndexToRemove = new List<int>();
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {
                if (dgvHoaDon.Rows[i].Selected == true) rowIndexToRemove.Add(i);
            }
            rowIndexToRemove.Reverse();
            foreach (var index in rowIndexToRemove) dgvHoaDon.Rows.RemoveAt(index);
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++) dgvHoaDon.Rows[i].Cells[0].Value = i + 1;
            cbbTenSP.Text = "";
            nudSoLuong.Value = 1;
            UpdateTongThanhToan();
        }

        private void nudSoLuong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                btnThem.PerformClick();
            }
        }

        private void txbTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txbTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            //if (txbTienKhachDua.Text == "") return;
            txbTienKhachDua.Text = string.Format(CultureInfo.CreateSpecificCulture("vi-VN"), "{0:C0}", int.Parse(txbTienKhachDua.Text, NumberStyles.Currency));
            if (txbTongThanhToan.Text == "") return;
            int traLaiKhach = int.Parse(txbTienKhachDua.Text, NumberStyles.Currency) - int.Parse(txbTongThanhToan.Text, NumberStyles.Currency);
            txbTraLaiKhach.Text = string.Format(CultureInfo.CreateSpecificCulture("vi-VN"), "{0:C0}", traLaiKhach);
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            txbThoiGian.Text = DateTime.Now.ToString();
            cbbTenSP.Text = "";
            nudSoLuong.Value = 1;
            dgvHoaDon.Rows.Clear();
            cbbKH.Text = "";
            txbTongThanhToan.Text = "";
            txbTienKhachDua.Text = "";
            txbTraLaiKhach.Text = "";
        }
    }
}
