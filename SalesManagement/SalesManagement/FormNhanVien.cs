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
    public delegate void changeform();
    public partial class FormNhanVien : Form
    {
        public FormNhanVien()
        {
            InitializeComponent();
            UpdateNhanVien();
        }
        private void UpdateNhanVien()
        {
            string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string sqlQuery = "select * from NHANVIEN";
            SqlCommand command = new SqlCommand(sqlQuery, connection);
            SqlDataReader dataReader = command.ExecuteReader();
            int stt = 1;
            while (dataReader.HasRows)
            {
                if (dataReader.Read() == false) break;
                dataGridView1.Rows.Add(stt, dataReader.GetString(0), dataReader.GetString(2), dataReader.GetDateTime(3).ToString(),
                    dataReader.GetString(4), dataReader.GetString(5), dataReader.GetString(6));
                stt++;
            }
            connection.Close();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            FormKhachHang kh = new FormKhachHang(change);
            kh.FormClosed += new FormClosedEventHandler(KhachHang_FormClose);
            kh.Show();
            this.Hide();
        }

        private void change()
        {
            this.Show();
        }
        private void KhachHang_FormClose(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            SignUp sn = new SignUp();
            sn.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView1.CurrentCell;
            int index = cell.RowIndex;
            if (index == -1) return;
            txbMaNV.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
            txbHoTen.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();
            txbNgaySinh.Text = dataGridView1.Rows[index].Cells[3].Value.ToString();
            txbGioiTinh.Text = dataGridView1.Rows[index].Cells[4].Value.ToString();
            txbSDT.Text = dataGridView1.Rows[index].Cells[5].Value.ToString();
            txbDiaChi.Text = dataGridView1.Rows[index].Cells[6].Value.ToString();
        }
    }
}
