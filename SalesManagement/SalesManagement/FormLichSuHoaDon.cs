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
    public partial class FormLichSuHoaDon : Form
    {
        public changeform change1, change2;
        string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        public FormLichSuHoaDon()
        {
            InitializeComponent();
        }
        public FormLichSuHoaDon(changeform change1, changeform change2)
        {
            InitializeComponent();
            this.change1 = change1;
            this.change2 = change2;
            DateTime currentDateTime = DateTime.Now;
            dtpFromDate.Value = new DateTime(currentDateTime.Year, currentDateTime.Month, 1);
            dtpToDate.Value = dtpFromDate.Value.AddMonths(1).AddDays(-1);
            UpdateDanhSachHD();
            UpdateCTHD();
        }

        private void UpdateDanhSachHD()
        {
            dgvLichSuHD.Rows.Clear();
            SqlConnection connection = new SqlConnection(global.conString);
            connection.Open();
            string sqlQuery = "SELECT * FROM HOADON WHERE THOIGIAN >= @thoiGianBatDau AND THOIGIAN <= @thoiGianKetThuc ORDER BY MAHD DESC";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            command.Parameters.AddWithValue("@thoiGianBatDau", Convert.ToDateTime(dtpFromDate.Value.ToShortDateString()));
            command.Parameters.AddWithValue("@thoiGianKetThuc", Convert.ToDateTime(dtpToDate.Value.ToShortDateString()));
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                dgvLichSuHD.Rows.Add(0, dataReader.GetString(0), dataReader.GetInt32(4), dataReader.GetDateTime(3).ToString(),
                    dataReader.GetString(2), dataReader.GetString(1));
            }
            for (int i = 0; i < dgvLichSuHD.Rows.Count - 1; i++) dgvLichSuHD.Rows[i].Cells[0].Value = i + 1;
            dgvLichSuHD.Rows[0].Selected = true;
            connection.Close();
        }
        private void UpdateCTHD()
        {
            dgvCTHD.Rows.Clear();
            if (dgvLichSuHD.SelectedRows.Count != 1) return;
            SqlConnection connection = new SqlConnection(global.conString);
            connection.Open();
            string sqlQuery = "SELECT SANPHAM.MASP, TEN, A.SOLUONG, DVT, GIABANLE FROM SANPHAM INNER JOIN " +
                "(SELECT * FROM CTHD WHERE CTHD.MAHD = '" + dgvLichSuHD.SelectedRows[0].Cells[1].Value.ToString() + "') AS A " +
                "ON SANPHAM.MASP = A.MASP";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                dgvCTHD.Rows.Add(0, dataReader.GetString(0), dataReader.GetString(1), dataReader.GetInt32(2),
                    dataReader.GetString(3), dataReader.GetInt32(4), dataReader.GetInt32(2) * dataReader.GetInt32(4));
            }
            for (int i = 0; i < dgvCTHD.Rows.Count - 1; i++) dgvCTHD.Rows[i].Cells[0].Value = i + 1;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.change1();
            this.Hide();
        }

        private void dgvLichSuHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvLichSuHD.CurrentCell;
            int index = cell.RowIndex;
            if (index == dgvLichSuHD.Rows.Count - 1) return;
            dgvLichSuHD.ClearSelection();
            dgvLichSuHD.Rows[index].Selected = true;
            UpdateCTHD();
        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            if (dtpFromDate.Value > dtpToDate.Value)
            {
                DateTime dateTime = dtpFromDate.Value;
                dtpFromDate.Value = dtpToDate.Value;
                dtpToDate.Value = dateTime;
            }
            UpdateDanhSachHD();
            UpdateCTHD();
        }

        private void dgvLichSuHD_Sorted(object sender, EventArgs e)
        {
            for (int i = 0; i < dgvLichSuHD.Rows.Count - 1; i++)
            {
                dgvLichSuHD.Rows[i].Cells[0].Value = i + 1;
            }
            dgvLichSuHD.ClearSelection();
            dgvLichSuHD.Rows[0].Selected = true;
            UpdateCTHD();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.change2();
            this.Hide(); 
        }
    }
}
