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
using iTextSharp.text;
using itextsharp.pdfa;
using System.IO;

using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using System.Windows.Forms.DataVisualization.Charting;
using System.Web;
namespace SalesManagement
{
    public partial class ThongKe : Form
    {
        // đổi conString theo máy tui, chưa thêm class global nên dùng như vầy
        // đưa khởi tạo dataMonth lên đầu
        // chạy data() để gắn giá trị cho dataMonth trước khi sử dụng trong fillChart()
        // kiểu dữ liệu trả về từ month(THOIGIAN) là int32, không phải string, dùng lệnh dr.GetInt32 thay vì dr.GetString

        public List<month> dataMonth;
        public List<year> dataYear;
        public List<day> dataDay;
        public ThongKe()
        {
            InitializeComponent();
            chart1.Titles.Add("Doanh Thu Chart");
            checkBox_tKTheoThang.Checked = true;
            checkBox_tKTheoNam.Checked = false;
            dateTimePicker1.Value = DateTime.Now;
            data(DateTime.Now.Year.ToString());
            fillChart();
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
            data(DateTime.Now.Year.ToString());
            fillChart();
        }
        private void fillChart()
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;     // Để hiển thị tất cả các label cột x

            for (int i = 1; i < 13; i++)
            {
                chart1.Series["Doanh Thu"].Points.AddY(0);
                chart1.Series["Doanh Thu"].Points[i - 1].AxisLabel = "T" + i.ToString();
            }
            for (int i = 0; i < dataMonth.Count(); i++)
            {
                chart1.Series["Doanh Thu"].Points[Convert.ToInt32(dataMonth[i].thang) - 1].YValues = new Double[] { Convert.ToDouble(dataMonth[i].doanhThu) };
            }

        }
        private void fillChartNam()
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;     // Để hiển thị tất cả các label cột x

            for (int i = 1; i < 12; i++)
            {
                chart1.Series["Doanh Thu"].Points.AddY(0);
                chart1.Series["Doanh Thu"].Points[i - 1].AxisLabel = (i + dateTimePicker1.Value.Year - 6).ToString();
            }
            //MessageBox.Show(dataYear.Count().ToString());
            for (int i = 0; i < dataYear.Count(); i++)
            {
                if (Convert.ToInt32(dataYear[i].nam) >= dateTimePicker1.Value.Year - 5 && Convert.ToInt32(dataYear[i].nam) <= dateTimePicker1.Value.Year + 5) 
                    chart1.Series["Doanh Thu"].Points[Convert.ToInt32(dataYear[i].nam) - (dateTimePicker1.Value.Year - 6) - 1].YValues = new Double[] { Convert.ToDouble(dataYear[i].doanhThu) };
            } 
        }
        private void fillChartNgay()
        {
            chart1.ChartAreas["ChartArea1"].AxisX.Interval = 1;     // Để hiển thị tất cả các label cột x
            // thống kê 30 ngày trong khoảng hiện tại
            int songay = 31;

            for (int i = 1; i < songay; i++)
            {
                chart1.Series["Doanh Thu"].Points.AddY(0);
                chart1.Series["Doanh Thu"].Points[i - 1].AxisLabel = "" + i.ToString();
            }
            for (int i = 0; i < dataDay.Count(); i++)
            {
                chart1.Series["Doanh Thu"].Points[Convert.ToInt32(dataDay[i].ngay) -1 ].YValues = new Double[] { Convert.ToDouble(dataDay[i].doanhThu) };
            }
        }
        protected void data(string year)
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Series["Doanh Thu"].Points.Clear();
            dataMonth = new List<month>(12);
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(global.conString);


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

                    dataMonth.Add(new month()
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

            //MessageBox.Show(Convert.ToString(dataMonth.Count()));
        }
        protected void dataNgay()
        {
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Series["Doanh Thu"].Points.Clear();
            dataDay = new List<day>(31);

            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(global.conString);


            cmd = new SqlCommand("SELECT day(THOIGIAN) as ngay, sum(TONGGIATRI) AS doanhThu " // thử select month giùm tui với, toàn bị lỗi :(
                                            + "FROM HOADON WHERE month(THOIGIAN) =" + dateTimePicker1.Value.Month.ToString() + "and year(THOIGIAN) = " + dateTimePicker1.Value.Year.ToString()
                                            + " GROUP BY day(THOIGIAN)", conn) ;
            SqlDataReader dr;
            //int sum = 0, i = 0;
            try
            {
                conn.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    //MessageBox.Show(dr.GetOrdinal("thang").GetType().ToString());

                    dataDay.Add(new day()
                    {
                        ngay = dr.GetInt32(dr.GetOrdinal("ngay")).ToString(),
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
        public void dataNam()
        {
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(global.conString);
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            chart1.Series["Doanh Thu"].Points.Clear();
            dataYear = new List<year>(12);
            string year = dateTimePicker1.Value.Year.ToString();
            cmd = new SqlCommand("SELECT year(THOIGIAN) as year, sum(TONGGIATRI) AS doanhThu"
                                  + " FROM HOADON \n"
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

                    dataYear.Add(new year()
                    {
                        nam = dr.GetInt32(dr.GetOrdinal("year")).ToString(),
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

        private void button_thongKe_Click(object sender, EventArgs e)
        {
            if (checkBox_tKTheoNam.Checked == false && (checkBox_tKTheoThang.Checked == true))
            {
                string year = dateTimePicker1.Value.Year.ToString();
                data(year);
                fillChart();
            }
            else if (checkBox_tKTheoNam.Checked == true && checkBox_tKTheoThang.Checked == false)
            {
                dataNam();
                fillChartNam();
            }
            else if (checkBox_Ngay.Checked == true  && checkBox_tKTheoNam.Checked == false && checkBox_tKTheoThang.Checked == false)
            {
                string day = dateTimePicker1.Value.Day.ToString();
                dataNgay();
                fillChartNgay();
            }    
            else
            {
                MessageBox.Show("Vui lòng xem lại ô checkbox!");
            }
        }

        private void checkBox_tKTheoNam_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_tKTheoThang.Checked == true)
            {
                checkBox_tKTheoThang.Checked = !checkBox_tKTheoThang.Checked;
            }
            if (checkBox_Ngay.Checked == true)
            {
                checkBox_Ngay.Checked = !checkBox_Ngay.Checked;
            }

        }

        private void checkBox_tKTheoThang_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_Ngay.Checked == true)
            {
                checkBox_Ngay.Checked = !checkBox_Ngay.Checked;
            }
            if (checkBox_tKTheoNam.Checked == true)
            {
                checkBox_tKTheoNam.Checked = !checkBox_tKTheoNam.Checked;
            }
        }

        private void checkBox_Ngay_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkBox_tKTheoThang.Checked == true)
            {
                checkBox_tKTheoThang.Checked = !checkBox_tKTheoThang.Checked;
            }
            if (checkBox_tKTheoNam.Checked == true) 
            {
                checkBox_tKTheoNam.Checked = !checkBox_tKTheoNam.Checked;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {

            // button in ra màn hình
            Document Doc = new Document(PageSize.A4, 10f, 10f, 10f, 0f);
            
            PdfWriter.GetInstance(Doc, HttpContext.Current.Response.OutputStream);
            string status = "";
            try
            {
                Doc.Open();
                using (MemoryStream memoryStream = new MemoryStream())
                {
                    var chartImage = new MemoryStream();
                    chart1.SaveImage(chartImage, ChartImageFormat.Png);
                    iTextSharp.text.Image chart_image = iTextSharp.text.Image.GetInstance(chartImage.GetBuffer());
                    chart_image.ScalePercent(200f);
                    Doc.Add(chart_image);
                    Doc.Close();
                    String fileName = DateTime.Now.ToString() + "Report.pdf";
                    HttpContext.Current.Response.ContentType = "application/pdf";
                    HttpContext.Current.Response.AddHeader("content-disposition", "attachment;filename= " + fileName);

                    HttpContext.Current.Response.Cache.SetCacheability(HttpCacheability.NoCache);
                    HttpContext.Current.Response.WriteFile(@"D://");  // file path
                    HttpContext.Current.Response.Write(Doc);
                    HttpContext.Current.Response.End();
                }
            }
            catch (DocumentException de)
            {
                System.Web.HttpContext.Current.Response.Write(de.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi!");
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
    public class day
    {
        public int doanhThu { get; set; }
        public string ngay { get; set; }
    }
        
}