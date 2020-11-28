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
using System.Configuration;
using System.Security.Cryptography;
using MySql.Data.MySqlClient;
using System.Net;
using System.Net.Sockets;

namespace SalesManagement
{
    public partial class ThongKe : Form
    {
        // đổi conString theo máy tui, chưa thêm class global nên dùng như vầy
        // đưa khởi tạo data1 lên đầu
        // chạy data() để gắn giá trị cho data1 trước khi sử dụng trong fillChart()
        // kiểu dữ liệu trả về từ month(THOIGIAN) là int32, không phải string, dùng lệnh dr.GetInt32 thay vì dr.GetString


        //string conString = @"Server=LAPTOP-8IL3N9B7\SQL;Database=SALES_MANAGEMENT;User Id=sa;Password=quang17102001;";
        public List<month> data1 = new List<month>(12);

        public ThongKe()
        {
            InitializeComponent();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ThongKe_Load(object sender, EventArgs e)
        {
            data();
            fillChart();
            //data();
        }
        private void fillChart()
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;     // Để hiển thị tất cả các label cột x
            for (int i = 1; i < 13; i++)
            {
                chart1.Series["Doanh Thu"].Points.AddY(0);
                chart1.Series["Doanh Thu"].Points[i - 1].AxisLabel = "T" + i.ToString();
            }
            for (int i = 0; i < data1.Count(); i++)
            {
                chart1.Series["Doanh Thu"].Points[Convert.ToInt32(data1[i].thang)].YValues = new Double[] { Convert.ToDouble(data1[i].doanhThu) };
            }
            //chart title  
            chart1.Titles.Add("Doanh Thu Chart");
        }
        protected void data()
        {

            MySqlConnection conn = new MySqlConnection(global.conString);
            MySqlCommand cmd = new MySqlCommand("SELECT month(THOIGIAN) as thang, sum(TONGGIATRI) AS doanhThu " // thử select month giùm tui với, toàn bị lỗi :(
                                            + "FROM HOADON WHERE year(THOIGIAN) = 2020 "
                                            + " GROUP BY month(THOIGIAN)", conn);

            MySqlDataReader dr;
            //int sum = 0, i = 0;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    data1.Add(new month()
                    {
                        thang = dr.GetInt32(dr.GetOrdinal("thang")).ToString(),
                        doanhThu = dr.GetInt32(dr.GetOrdinal("doanhThu"))

                    });
                }
                dr.Close();
            }
            catch (Exception exp)
            {

                MessageBox.Show("Loi ket noi");
            }
            finally
            {
                conn.Close();
            }
        }
    }
    public class month
    {
        public int doanhThu { get; set; }
        public string thang { get; set; }

    }
}