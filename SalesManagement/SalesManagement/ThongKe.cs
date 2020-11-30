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
    public partial class ThongKe : Form
    {
        // đổi conString theo máy tui, chưa thêm class global nên dùng như vầy
        // đưa khởi tạo data1 lên đầu
        // chạy data() để gắn giá trị cho data1 trước khi sử dụng trong fillChart()
        // kiểu dữ liệu trả về từ month(THOIGIAN) là int32, không phải string, dùng lệnh dr.GetInt32 thay vì dr.GetString


        string conString = @"Data Source=DESKTOP-VMO2INA\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True";
        public List<month> data1 = new List<month>(12);
        public List<year> data2 = new List<year>(10);
        public ThongKe()
        {
            InitializeComponent();
            chart1.Titles.Add("Doanh Thu Chart");
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

        }
        private void fillChartNam()
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;     // Để hiển thị tất cả các label cột x

            for (int i = 1; i < 11; i++)
            {
                chart1.Series["Doanh Thu"].Points.AddY(0);
                chart1.Series["Doanh Thu"].Points[i - 1].AxisLabel = "Nam " + (i).ToString();
            }
            for (int i = 1; i < data2.Count(); i++)
            {
                chart1.Series["Doanh Thu"].Points[Convert.ToInt32(data2[i].nam)].YValues = new Double[] { Convert.ToDouble(data2[i].doanhThu) };
            }
            //chart title  
            chart1.Titles.Add("Doanh Thu Chart");
        }
        protected void data(string year)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Series["Doanh Thu"].Points.Clear();
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(conString);


            cmd = new SqlCommand("SELECT month(THOIGIAN) as thang, sum(TONGGIATRI) AS doanhThu " // thử select month giùm tui với, toàn bị lỗi :(
                                            + "FROM HOADON WHERE year(THOIGIAN) =" + year
                                            + " GROUP BY month(THOIGIAN)", conn);
            SqlDataReader dr;
            //int sum = 0, i = 0;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //MessageBox.Show(dr.GetOrdinal("thang").GetType().ToString());

                    data1.Add(new month()
                    {
                        thang = dr.GetInt32(dr.GetOrdinal("thang")).ToString(),
                        doanhThu = dr.GetInt32(dr.GetOrdinal("doanhThu"))

                    });
                }
                //MessageBox.Show(sum.ToString());

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

            //MessageBox.Show(Convert.ToString(data1.Count()));
        }
        public void dataNam()
        {
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(conString);

            string year = dateTimePicker1.Value.Year.ToString();
            cmd = new SqlCommand("SELECT year(THOIGIAN) as year, sum(TONGGIATRI) AS doanhThu"
                                  + " FROM HOADON"
                                   + " GROUP BY year(THOIGIAN)", conn);
            SqlDataReader dr;
            //int sum = 0, i = 0;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //MessageBox.Show(dr.GetOrdinal("thang").GetType().ToString());

                    data2.Add(new year()
                    {
                        nam = dr.GetInt32(dr.GetOrdinal("year")).ToString(),
                        doanhThu = dr.GetInt32(dr.GetOrdinal("doanhThu"))

                    });
                }
                //MessageBox.Show(sum.ToString());

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

        private void button_thongKe_Click(object sender, EventArgs e)
        {
            //chart1.Series["Doanh Thu"].Points.Clear();

            if (checkBox_tKTheoNam.Checked == false && (checkBox_tKTheoThang.Checked == true))
            {
                string year = dateTimePicker1.Value.Year.ToString();
                data(year);
                fillChart();
            }
            else if (checkBox_tKTheoNam.Checked == true && checkBox_tKTheoThang.Checked == false)
            {
                MessageBox.Show("Tính năng chưa hoàn thiện");
            }
            else
            {
                MessageBox.Show("Vui lòng xem lại ô checkbox!");
            }
        }
    }
    public class month
    {
        public int doanhThu { get; set; }
        public string thang { get; set; }
    }
    public class year
    {
        public int doanhThu { get; set; }
        public string nam { get; set; }
    }
}