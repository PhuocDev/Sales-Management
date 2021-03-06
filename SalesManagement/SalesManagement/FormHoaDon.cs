﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Microsoft.Reporting.WinForms;

namespace SalesManagement
{
    public partial class FormHoaDon : Form
    {
        List<ClassSanPham> listSanPham;
        List<string> listMaKH;
        CultureInfo cultureInfo;
        //string conString = @"Server=LAPTOP-8IL3N9B7\SQLEXPRESS;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        public FormHoaDon()
        {
            InitializeComponent();
            listSanPham = new List<ClassSanPham>();
            listMaKH = new List<string>();
            NumberFormatInfo nfi = new CultureInfo("vn-VN", false).NumberFormat;
            nfi.CurrencyPositivePattern = 3;
            nfi.CurrencyNegativePattern = 3;
            nfi.NumberDecimalSeparator = ".";
            nfi.NumberGroupSeparator = ",";
            cultureInfo = new CultureInfo("vn-VN", false);
            cultureInfo.NumberFormat = nfi;
            Thread.CurrentThread.CurrentCulture = cultureInfo;
            UpdateDanhSachSP();
            UpdateDanhSachKH();
            txbThoiGian.Text = DateTime.Now.ToString();
            txbMaHD.Text = GetMaHD();
            txbTongThanhToan.Text = string.Format(cultureInfo, "{0:C0}", 0);
            txbNhanVien.Text = Login.Current_user.NAME;
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
            try
            {
                SqlConnection connection = new SqlConnection(global.conString);
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
                    cbbMaSP.Items.Add(dataReader.GetString(0));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void UpdateDanhSachKH()
        {
            try
            {
                SqlConnection connection = new SqlConnection(global.conString);
                connection.Open();
                string sqlQuery = "SELECT * FROM KHACHHANG";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                cbbMaKH.Items.Clear();
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    listMaKH.Add(dataReader.GetString(0));
                    cbbMaKH.Items.Add(dataReader.GetString(0));
                }
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private string GetMaHD()
        {
            try
            {
                SqlConnection connection = new SqlConnection(global.conString);
                connection.Open();
                string sqlQuery = "SELECT * FROM HOADON WHERE THOIGIAN IN (SELECT MAX(THOIGIAN) FROM HOADON) ORDER BY MAHD DESC";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                string maHD;
                string[] months = { "Key months of year", "JAN", "FEB", "MAR", "APR", "MAY", "JUN", "JUL", "AUG", "SEP", "OCT", "NOV", "DEC" };
                DateTime dateTime = DateTime.Now;
                string stringYear = dateTime.Year.ToString();
                if (dataReader.HasRows == false)
                {
                    maHD = stringYear[2].ToString() + stringYear[3].ToString() + months[dateTime.Month] + "0001";
                    connection.Close();
                    return maHD;
                }
                maHD = stringYear[2].ToString() + stringYear[3].ToString() + months[dateTime.Month];
                dataReader.Read();
                string maHDTruoc = dataReader.GetString(0);
                if (maHD == maHDTruoc.Substring(0, 5))
                {
                    string soThuTuHD = "0000" + Convert.ToString(Convert.ToInt32(maHDTruoc.Substring(5)) + 1);
                    soThuTuHD = soThuTuHD.Substring(soThuTuHD.Length - 4);
                    maHD = maHD + soThuTuHD;
                    connection.Close();
                    return maHD;
                }
                else
                {
                    maHD = maHD + "0001";
                    connection.Close();
                    return maHD;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        private void UpdateTongThanhToan()
        {
            try
            {
                int tongThanhToan = 0;
                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    tongThanhToan += Convert.ToInt32(dgvHoaDon.Rows[i].Cells[6].Value);
                }
                txbTongThanhToan.Text = string.Format(cultureInfo, "{0:C0}", tongThanhToan);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool KiemTraSoLuong(string maSP, int soLuong)
        {
            foreach (var sanPham in listSanPham)
            {
                if (sanPham.maSP == maSP)
                {
                    if (soLuong <= sanPham.soLuong) return true;
                    else
                    {
                        MessageBox.Show("Số lượng sản phẩm còn lại không đủ\nSản phẩm: " + sanPham.tenSP
                            + "\nSố lượng còn lại: " + sanPham.soLuong.ToString());
                        return false;
                    }
                }
            }
            return false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            try
            {
                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    if (dgvHoaDon.Rows[i].Cells[2].Value.ToString() == cbbTenSP.Text)
                    {
                        if (KiemTraSoLuong(dgvHoaDon.Rows[i].Cells[1].Value.ToString(), Convert.ToInt32(dgvHoaDon.Rows[i].Cells[3].Value) + Convert.ToInt32(nudSoLuong.Value)) == false)
                        {
                            nudSoLuong.Focus();
                            return;
                        }
                        dgvHoaDon.Rows[i].Cells[3].Value = Convert.ToInt32(dgvHoaDon.Rows[i].Cells[3].Value) + Convert.ToInt32(nudSoLuong.Value);
                        dgvHoaDon.Rows[i].Cells[6].Value = Convert.ToInt32(Convert.ToInt32(dgvHoaDon.Rows[i].Cells[3].Value) * Convert.ToInt32(dgvHoaDon.Rows[i].Cells[5].Value));
                        dgvHoaDon.ClearSelection();
                        dgvHoaDon.Rows[i].Selected = true;
                        nudSoLuong.Value = 1;
                        cbbTenSP.Focus();
                        UpdateTongThanhToan();
                        return;
                    }
                }
                bool timThaySanPham = false;
                foreach (var sanPham in listSanPham)
                {
                    if (sanPham.tenSP == cbbTenSP.Text)
                    {
                        if (nudSoLuong.Value > sanPham.soLuong)
                        {
                            MessageBox.Show("Số lượng sản phẩm còn lại không đủ\nSản phẩm: " + sanPham.tenSP
                                + "\nSố lượng còn lại: " + sanPham.soLuong.ToString());
                            cbbTenSP.Focus();
                            return;
                        }
                        dgvHoaDon.Rows.Add(dgvHoaDon.Rows.Count, sanPham.maSP, sanPham.tenSP, Convert.ToInt32(nudSoLuong.Value), sanPham.donViTinh,
                            sanPham.giaBan, Convert.ToInt32(nudSoLuong.Value) * sanPham.giaBan);
                        timThaySanPham = true;
                        dgvHoaDon.ClearSelection();
                        dgvHoaDon.Rows[dgvHoaDon.Rows.Count - 2].Selected = true;
                        nudSoLuong.Value = 1;
                        cbbTenSP.Focus();
                        UpdateTongThanhToan();
                        break;
                    }
                }
                if (timThaySanPham == false) MessageBox.Show("Khong tim thay san pham: " + cbbTenSP.Text);
                cbbTenSP.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvHoaDon_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvHoaDon.CurrentCell;
            int index = cell.RowIndex;
            if (index == dgvHoaDon.Rows.Count - 1) return;
            dgvHoaDon.Rows[index].Selected = true;
            cbbTenSP.Text = dgvHoaDon.SelectedRows[0].Cells[2].Value.ToString();
            nudSoLuong.Value = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells[3].Value);
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            try
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
                if (timThaySanPham == false)
                {
                    MessageBox.Show("Khong tim thay san pham: " + cbbTenSP.Text);
                    cbbTenSP.Focus();
                    return;
                }
                if (dgvHoaDon.SelectedRows[0].Cells[2].Value.ToString() == cbbTenSP.Text)
                {
                    if (KiemTraSoLuong(dgvHoaDon.SelectedRows[0].Cells[1].Value.ToString(), Convert.ToInt32(nudSoLuong.Value)) == false)
                    {
                        nudSoLuong.Focus();
                        return;
                    }
                    dgvHoaDon.SelectedRows[0].Cells[3].Value = nudSoLuong.Value;
                    dgvHoaDon.SelectedRows[0].Cells[6].Value = Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells[3].Value) * Convert.ToInt32(dgvHoaDon.SelectedRows[0].Cells[5].Value);
                    UpdateTongThanhToan();
                    cbbTenSP.Focus();
                    return;
                }
                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    if (i == dgvHoaDon.SelectedRows[0].Index) continue;
                    if (dgvHoaDon.Rows[i].Cells[2].Value.ToString() == cbbTenSP.Text)
                    {
                        MessageBox.Show("Da co san pham '" + cbbTenSP.Text + "' trong danh sach");
                        cbbTenSP.Focus();
                        return;
                    }
                }
                foreach (var sanPham in listSanPham)
                {
                    if (sanPham.tenSP == cbbTenSP.Text)
                    {
                        if (nudSoLuong.Value > sanPham.soLuong)
                        {
                            MessageBox.Show("Số lượng sản phẩm còn lại không đủ\nSản phẩm: " + sanPham.tenSP
                                + "\nSố lượng còn lại: " + sanPham.soLuong.ToString());
                            nudSoLuong.Focus();
                            return;
                        }
                        dgvHoaDon.SelectedRows[0].Cells[1].Value = sanPham.maSP;
                        dgvHoaDon.SelectedRows[0].Cells[2].Value = sanPham.tenSP;
                        dgvHoaDon.SelectedRows[0].Cells[3].Value = nudSoLuong.Value;
                        dgvHoaDon.SelectedRows[0].Cells[4].Value = sanPham.donViTinh;
                        dgvHoaDon.SelectedRows[0].Cells[5].Value = sanPham.giaBan;
                        dgvHoaDon.SelectedRows[0].Cells[6].Value = Convert.ToInt32(nudSoLuong.Value) * sanPham.giaBan;
                        UpdateTongThanhToan();
                        cbbTenSP.Focus();
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
            cbbTenSP.TextChanged -= cbbTenSP_TextChanged;
            cbbMaSP.TextChanged -= cbbMaSP_TextChanged;
            cbbTenSP.Text = "";
            cbbMaSP.Text = "";
            cbbTenSP.TextChanged += cbbTenSP_TextChanged;
            cbbMaSP.TextChanged += cbbMaSP_TextChanged;
            nudSoLuong.Value = 1;
            cbbTenSP.Focus();
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
            try
            {
                if (e.KeyChar == (char)Keys.Enter)
                {
                    if (txbTienKhachDua.Text == "" || txbTienKhachDua.Text == " ₫" || txbTienKhachDua.Text == string.Format(cultureInfo, "{0:C0}", 0))
                    {
                        txbTienKhachDua.Text = string.Format(cultureInfo, "{0:C0}", 0);
                        txbTraLaiKhach.Text = "";
                        MessageBox.Show("Chưa nhập tiền khách đưa");
                        return;
                    }
                    if (int.Parse(txbTienKhachDua.Text, NumberStyles.Currency) < int.Parse(txbTongThanhToan.Text, NumberStyles.Currency))
                        MessageBox.Show("Tiền khách đưa ít hơn tổng tiền cần thanh toán");
                    else
                    {
                        int traLaiKhach = int.Parse(txbTienKhachDua.Text, NumberStyles.Currency) - int.Parse(txbTongThanhToan.Text, NumberStyles.Currency);
                        txbTraLaiKhach.Text = string.Format(cultureInfo, "{0:C0}", traLaiKhach);
                    }
                }
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnTaoHD_Click(object sender, EventArgs e)
        {
            txbMaHD.Text = GetMaHD();
            txbThoiGian.Text = DateTime.Now.ToString();
            cbbTenSP.TextChanged -= cbbTenSP_TextChanged;
            cbbMaSP.TextChanged -= cbbMaSP_TextChanged;
            cbbTenSP.Text = "";
            cbbMaSP.Text = "";
            cbbTenSP.TextChanged += cbbTenSP_TextChanged;
            cbbMaSP.TextChanged += cbbMaSP_TextChanged;
            nudSoLuong.Value = 1;
            dgvHoaDon.Rows.Clear();
            cbbMaKH.Text = "";
            txbTongThanhToan.Text = string.Format(cultureInfo, "{0:C0}", 0);
            txbTienKhachDua.TextChanged -= txbTienKhachDua_TextChanged;
            txbTienKhachDua.Text = "";
            txbTienKhachDua.TextChanged += txbTienKhachDua_TextChanged;
            txbTraLaiKhach.Text = "";
        }

        private void txbTienKhachDua_Leave(object sender, EventArgs e)
        {
            try
            {
                if (txbTienKhachDua.Text == "" || txbTienKhachDua.Text == " ₫" || txbTienKhachDua.Text == string.Format(cultureInfo, "{0:C0}", 0))
                {
                    txbTienKhachDua.Text = string.Format(cultureInfo, "{0:C0}", 0);
                    txbTraLaiKhach.Text = "";
                    MessageBox.Show("Chưa nhập tiền khách đưa");
                    return;
                }
                if (int.Parse(txbTienKhachDua.Text, NumberStyles.Currency) < int.Parse(txbTongThanhToan.Text, NumberStyles.Currency))
                    MessageBox.Show("Tiền khách đưa ít hơn tổng tiền cần thanh toán");
                else
                {
                    int traLaiKhach = int.Parse(txbTienKhachDua.Text, NumberStyles.Currency) - int.Parse(txbTongThanhToan.Text, NumberStyles.Currency);
                    txbTraLaiKhach.Text = string.Format(cultureInfo, "{0:C0}", traLaiKhach);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txbTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string stringSoTien = txbTienKhachDua.Text.Replace(".", "").Replace(",", "").Replace("₫", "").Replace(" ", "");
                if (stringSoTien == "") return;
                int soTien = int.Parse(stringSoTien);
                txbTienKhachDua.TextChanged -= txbTienKhachDua_TextChanged;
                txbTienKhachDua.Text = string.Format(cultureInfo, "{0:C0}", soTien);
                txbTienKhachDua.TextChanged += txbTienKhachDua_TextChanged;
                txbTienKhachDua.Select(txbTienKhachDua.Text.Length - 2, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbbTenSP_TextChanged(object sender, EventArgs e)
        {
            if (cbbTenSP.FindString(cbbTenSP.Text) != -1)
            {
                cbbMaSP.TextChanged -= cbbMaSP_TextChanged;
                if (cbbTenSP.Text == "") cbbMaSP.Text = "";
                else cbbMaSP.Text = cbbMaSP.Items[cbbTenSP.FindString(cbbTenSP.Text)].ToString();
                cbbMaSP.TextChanged += cbbMaSP_TextChanged;
            }
        }

        private void cbbMaSP_TextChanged(object sender, EventArgs e)
        {
            if (cbbMaSP.FindString(cbbMaSP.Text) != -1)
            {
                cbbTenSP.TextChanged -= cbbTenSP_TextChanged;
                if (cbbMaSP.Text == "") cbbTenSP.Text = "";
                else cbbTenSP.Text = cbbTenSP.Items[cbbMaSP.FindString(cbbMaSP.Text)].ToString();
                cbbTenSP.TextChanged += cbbTenSP_TextChanged;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvHoaDon.Rows.Count <= 1)
                {
                    MessageBox.Show("Chưa nhập sản phẩm");
                    return;
                }
                if (txbTienKhachDua.Text == "" || txbTienKhachDua.Text == " ₫" || txbTienKhachDua.Text == string.Format(cultureInfo, "{0:C0}", 0))
                {
                    MessageBox.Show("Chưa nhập tiền khách đưa");
                    return;
                }
                SqlConnection connection = new SqlConnection(global.conString);
                connection.Open();
                string sqlQuery = "INSERT INTO HOADON(MAHD, MANV, MAKH, THOIGIAN, TONGGIATRI) VALUES (@maHD, @maNV, @maKH, @thoiGian, @tongGiaTri)";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Parameters.AddWithValue("@maHD", txbMaHD.Text);
                command.Parameters.AddWithValue("@maNV", Login.Current_user.ID);
                if (cbbMaKH.FindString(cbbMaKH.Text) == -1 || cbbMaKH.Text == "") command.Parameters.AddWithValue("@maKH", "KH00000");
                else command.Parameters.AddWithValue("@maKH", cbbMaKH.Text);
                command.Parameters.AddWithValue("@thoiGian", Convert.ToDateTime(txbThoiGian.Text));
                command.Parameters.AddWithValue("@tongGiaTri", int.Parse(txbTongThanhToan.Text, NumberStyles.Currency));
                int check = command.ExecuteNonQuery();
                if (check != 1)
                {
                    MessageBox.Show("Failed query INSERT INTO HOADON");
                    connection.Close();
                    return;
                }
                sqlQuery = "INSERT INTO CTHD(MAHD, MASP, TEN, SOLUONG, DVT, DONGIA, TRIGIA) VALUES (@maHD, @maSP, @ten, @soLuong, @DVT, @donGia, @triGia)";
                command = new SqlCommand(sqlQuery, connection);
                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@maHD", txbMaHD.Text);
                    command.Parameters.AddWithValue("@maSP", dgvHoaDon.Rows[i].Cells[1].Value.ToString());
                    command.Parameters.AddWithValue("@ten", dgvHoaDon.Rows[i].Cells[2].Value.ToString());
                    command.Parameters.AddWithValue("@soLuong", dgvHoaDon.Rows[i].Cells[3].Value);
                    command.Parameters.AddWithValue("@DVT", dgvHoaDon.Rows[i].Cells[4].Value.ToString());
                    command.Parameters.AddWithValue("@donGia", int.Parse(dgvHoaDon.Rows[i].Cells[5].Value.ToString(), NumberStyles.Currency));
                    command.Parameters.AddWithValue("@triGia", int.Parse(dgvHoaDon.Rows[i].Cells[6].Value.ToString(), NumberStyles.Currency));
                    check = command.ExecuteNonQuery();
                    if (check != 1)
                    {
                        MessageBox.Show("Failed query INSERT INTO CTHD\nMã sản phẩm: " + dgvHoaDon.Rows[i].Cells[1].Value.ToString());
                    }
                }
                sqlQuery = "UPDATE SANPHAM SET SOLUONG = SOLUONG - @soLuong WHERE MASP = @maSP";
                command = new SqlCommand(sqlQuery, connection);
                for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@maSP", dgvHoaDon.Rows[i].Cells[1].Value.ToString());
                    command.Parameters.AddWithValue("@soLuong", dgvHoaDon.Rows[i].Cells[3].Value);
                    check = command.ExecuteNonQuery();
                    if (check != 1)
                    {
                        MessageBox.Show("Failed query UPDATE SANPHAM\nMã sản phẩm: " + dgvHoaDon.Rows[i].Cells[1].Value.ToString());
                    }
                }
                XuatPDF();
                MessageBox.Show("Thanh toán thành công");
                btnTaoHD.PerformClick();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void cbbMaKH_Leave(object sender, EventArgs e)
        {
            if (cbbMaKH.FindString(cbbMaKH.Text) == -1)
            {
                MessageBox.Show("Không tìm thấy khách hàng: " + cbbMaKH.Text);
                cbbMaKH.Text = "";
                return;
            }
        }

        private void btnLichSuHoaDon_Click(object sender, EventArgs e)
        {
            FormLichSuHoaDon formLichSuHoaDon = new FormLichSuHoaDon(change1, change2);
            formLichSuHoaDon.FormClosed += new FormClosedEventHandler(FormLichSuHoaDon_FormClose);
            formLichSuHoaDon.Show();
            this.Hide();
        }
        private void change1()
        {
            this.Show();
        }
        private void change2()
        {
            this.Close();
        }
        private void FormLichSuHoaDon_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }
        private void btnTaoKHMoi_Click(object sender, EventArgs e)
        {
            AddKhachHang addKhachHang = new AddKhachHang();
            addKhachHang.ShowDialog();
            UpdateDanhSachKH();
        }
        public List<SanPhamThanhToan> GetSanPhamThanhToan()
        {
            List<SanPhamThanhToan> list = new List<SanPhamThanhToan>();
            for (int i = 0; i < dgvHoaDon.Rows.Count - 1; i++)
            {
                list.Add(new SanPhamThanhToan { TenSP = dgvHoaDon.Rows[i].Cells[2].Value.ToString(), 
                    SoLuong = dgvHoaDon.Rows[i].Cells[3].Value.ToString(), 
                    //ThanhTien = dgvHoaDon.Rows[i].Cells[6].Value.ToString() });
                    ThanhTien = string.Format(cultureInfo, "{0:C0}", dgvHoaDon.Rows[i].Cells[6].Value)
                });
            }
            return list;
        }
        public List<Receipt> GetReceiptInfo()
        {
            return new List<Receipt>
            {
                new Receipt
                {
                    MaHD = txbMaHD.Text,
                    MaKH = GetTenKH(cbbMaKH.Text),
                    TenNV = txbNhanVien.Text,
                    StringThoiGian = txbThoiGian.Text,
                    StringTongThanhToan = txbTongThanhToan.Text,
                    StringTienKhachDua = txbTienKhachDua.Text,
                    StringTraLaiKhach = txbTraLaiKhach.Text
                }
            };
        }
        public string GetTenKH(string maKH)
        {
            try
            {
                if (maKH == "" || maKH == "KH00000") return "";
                SqlConnection connection = new SqlConnection(global.conString);
                connection.Open();
                string sqlQuery = "SELECT TEN FROM KHACHHANG WHERE MAKH = '" + cbbMaKH.Text + "'";
                SqlCommand command = new SqlCommand(sqlQuery, connection);
                SqlDataReader dataReader = command.ExecuteReader();
                string tenKH = "";
                if (dataReader.HasRows)
                {
                    if (dataReader.Read() == false)
                    {
                        connection.Close();
                        return "";
                    }
                    tenKH = dataReader.GetString(0);
                }
                connection.Close();
                return tenKH;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return "";
            }
        }
        public void XuatPDF()
        {
            /*if (dgvHoaDon.Rows.Count > 0)
            {
                try
                {
                    iTextSharp.text.Font font = FontFactory.GetFont("Arial", 14.0f, BaseColor.BLACK);
                    PdfPTable pdfTable = new PdfPTable(dgvHoaDon.Columns.Count);
                    pdfTable.DefaultCell.Padding = 3;
                    pdfTable.WidthPercentage = 100;
                    pdfTable.HorizontalAlignment = Element.ALIGN_CENTER;

                    foreach (DataGridViewColumn column in dgvHoaDon.Columns)
                    {
                        PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText, font));
                        pdfTable.AddCell(cell);
                    }

                    foreach (DataGridViewRow row in dgvHoaDon.Rows)
                    {
                        if (row.Index == dgvHoaDon.Rows.Count - 1) continue;
                        foreach (DataGridViewCell cell in row.Cells)
                        {
                            PdfPCell cellWithFont = new PdfPCell(new Phrase(cell.Value.ToString(), font));
                            pdfTable.AddCell(cellWithFont);
                        }
                    }
                    string fileName = Path.Combine(@"D:\\SalesManagement\Receipts\", txbMaHD.Text + ".pdf");
                    if (!Directory.Exists(@"D:\\SalesManagement\Receipts\")) Directory.CreateDirectory(@"D:\\SalesManagement\Receipts\");
                    using (FileStream stream = new FileStream(fileName, FileMode.Create))
                    {
                        Document pdfDoc = new Document(PageSize.A4, 10f, 20f, 20f, 10f);
                        PdfWriter.GetInstance(pdfDoc, stream);
                        pdfDoc.Open();
                        Phrase phrase = new Phrase();
                        Chunk chunk = new Chunk("Mã hóa đơn: " + txbMaHD.Text, font);
                        phrase.Add(chunk);
                        phrase.Add(Environment.NewLine);
                        chunk = new Chunk("Thời gian: " + txbThoiGian.Text, font);
                        phrase.Add(chunk);
                        phrase.Add(Environment.NewLine);
                        chunk = new Chunk("Nhân viên: " + txbNhanVien.Text, font);
                        phrase.Add(chunk);
                        phrase.Add(Environment.NewLine);
                        chunk = new Chunk("Tổng thanh toán: " + txbTongThanhToan.Text, font);
                        phrase.Add(chunk);
                        phrase.Add(Environment.NewLine);
                        chunk = new Chunk("Tiền khách đưa: " + txbTienKhachDua.Text, font);
                        phrase.Add(chunk);
                        phrase.Add(Environment.NewLine);
                        chunk = new Chunk("Trả lại khách: " + txbTraLaiKhach.Text, font);
                        phrase.Add(chunk);
                        phrase.Add(Environment.NewLine);
                        pdfDoc.Add(phrase);
                        pdfDoc.Add(pdfTable);
                        pdfDoc.Close();
                        stream.Close();

                    }

                    //MessageBox.Show("Data Exported Successfully !!!", "Info");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error :" + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Không có dữ liệu hóa đơn", "Info");
            }*/

            try
            {
                ReportViewer viewer = new ReportViewer();
                viewer.ProcessingMode = ProcessingMode.Local;
                viewer.LocalReport.ReportPath = "ReceiptReport.rdlc";
                viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet2", GetSanPhamThanhToan()));
                viewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", GetReceiptInfo()));
                viewer.RefreshReport();
                var bytes = viewer.LocalReport.Render("PDF");
                //string fileName = @".\Receipts\" + txbMaHD.Text + ".pdf";
                string fileName = Path.Combine(@"D:\\SalesManagement\Receipts\", txbMaHD.Text + ".pdf");
                if (!Directory.Exists(@"D:\\SalesManagement\Receipts\")) Directory.CreateDirectory(@"D:\\SalesManagement\Receipts\");
                if (!File.Exists(fileName)) File.Delete(fileName);
                File.WriteAllBytes(fileName, bytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
