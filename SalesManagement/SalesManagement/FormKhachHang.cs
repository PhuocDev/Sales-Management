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
        public changeform change;
        public FormKhachHang()
        {
            InitializeComponent();
            UpdateKhachHang();
        }
        private void UpdateKhachHang()
        {
            string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string sqlQuery = "select * from KHACHHANG";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int stt = 1;
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                dataGridView1.Rows.Add(stt, dataReader.GetString(0), dataReader.GetString(1), dataReader.GetDateTime(2).ToString(),
                    dataReader.GetString(3), dataReader.GetString(4), dataReader.GetString(5), dataReader.GetInt32(6));
                stt++;
            }
            connection.Close();
        }
        public FormKhachHang(changeform change)
        {
            InitializeComponent();
            UpdateKhachHang();
            this.change = change;
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.change();
            this.Hide();
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            this.change();
            this.Hide();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            if (index == -1) return;
            txbMaKH.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txbHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txbNgaySinh.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txbGioiTinh.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txbSDT.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txbDiaChi.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
            txbDiem.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
        }
    }
}
