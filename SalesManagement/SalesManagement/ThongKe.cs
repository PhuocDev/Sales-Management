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
using System.IO;
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
            dataThang(DateTime.Now.Year.ToString());
            fillChartThang();
        }
        private void ThongKe_Load(object sender, EventArgs e)
        {
            dataThang(DateTime.Now.Year.ToString());
            fillChartThang();
        }


        //----------- Load dữ liệu theo ngày tháng năm  ------------//
        private void fillChartThang()
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
            int songay = soNgayTrongThang(dateTimePicker1.Value.Month, dateTimePicker1.Value.Year);
            for (int i = 1; i <= songay; i++)
            {
                chart1.Series["Doanh Thu"].Points.AddY(0);
                chart1.Series["Doanh Thu"].Points[i - 1].AxisLabel = "" + i.ToString();
            }
            for (int i = 0; i < dataDay.Count(); i++)
            {
                chart1.Series["Doanh Thu"].Points[Convert.ToInt32(dataDay[i].ngay) - 1].YValues = new Double[] { Convert.ToDouble(dataDay[i].doanhThu) };
            }
        }


        //----------- Lưu dữ liệu theo ngày tháng năm   ------------//
        protected void dataThang(string year)
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

                MessageBox.Show("Error: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }

            //MessageBox.Show(Convert.ToString(dataMonth.Count()));
        }
        
        private string getDataThang(int thang, string year)
        {
            thang = 0;
            string temp = "";
            SqlCommand cmd;
            SqlConnection conn = new SqlConnection(global.conString);


            cmd = new SqlCommand("SELECT ISNULL(sum(TONGGIATRI), '0') AS doanhThu "
                                            + "FROM HOADON WHERE year(THOIGIAN) =" + year
                                            + " and month(thoigian) = " + thang.ToString(), conn);

            SqlDataReader dr;
            //int sum = 0, i = 0;
            try
            {
                conn.Open();
                SqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.HasRows)
                {
                    if (dataReader.Read() == false) break;
                    else
                    {
                        temp = dataReader.GetString(0);
                    }
                }
                //MessageBox.Show(sum.ToString());

                dataReader.Close();
            }
            catch (Exception exp)
            {

                MessageBox.Show("Error: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
                
            }
            return (temp);
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
                                            + " GROUP BY day(THOIGIAN)", conn);
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

                MessageBox.Show("Error:" + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

                MessageBox.Show("Error: " + exp.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                conn.Close();
            }
        }

        


        // ------ in biểu đồ dạng BMP  ------------------------//
        private void screenPanel()
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "BMP (*.bmp)|*.bmp";
            sfd.FileName = "BieuDoDoanhThu.bmp";
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
                        using (var bmp = new Bitmap(panel1.Width, panel1.Height))
                        {
                            panel1.DrawToBitmap(bmp, new Rectangle(0, 0, bmp.Width, bmp.Height));
                            bmp.Save(sfd.FileName);
                            MessageBox.Show("In biểu đồ thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }


        //------------ điều kiện checkbox --------------------//
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


        //---------------- các sự kiện ----------------------//
        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private int soNgayTrongThang(int month, int year)
        {
            int[] soNgayTrongThang = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if (month != 2) return soNgayTrongThang[month - 1];
            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0)) return 29;
            else return 28;
        }
        private void button_thongKe_Click(object sender, EventArgs e)
        {
            if (checkBox_tKTheoNam.Checked == false && (checkBox_tKTheoThang.Checked == true))
            {
                dataThang(dateTimePicker1.Value.Year.ToString());
                fillChartThang();
            }
            else if (checkBox_tKTheoNam.Checked == true && checkBox_tKTheoThang.Checked == false)
            {
                dataNam();
                fillChartNam();
            }
            else if (checkBox_Ngay.Checked == true && checkBox_tKTheoNam.Checked == false && checkBox_tKTheoThang.Checked == false)
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



        private void button1_Click(object sender, EventArgs e)
        {
            screenPanel();
        }
        private void button_thongKe_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button_thongKe.PerformClick();
            }

        }

        //private void button_test_Click(object sender, EventArgs e)
        //{
        //    if (dateTimePicker1.Value >= dateTimePicker2.Value)
        //    {
        //        MessageBox.Show("Sai điều kiện");
        //    }
        //    else
        //    {
        //        DateTime FirstDate = dateTimePicker1.Value;
        //        DateTime SecondDate = dateTimePicker2.Value;

        //        // Difference in days, hours, and minutes.
        //        TimeSpan ts = SecondDate - FirstDate;
        //        // Difference in days.
        //        int TotalDays = ts.Days;
        //        int month1 = dateTimePicker1.Value.Month;
        //        int month2 = dateTimePicker2.Value.Month;
        //        int year1 = dateTimePicker2.Value.Year;
        //        int year2 = dateTimePicker2.Value.Year;

        //        //------- llại
        //        if (year1 == year2)
        //        {
        //            if (TotalDays < 32)
        //            {
        //                if (month1 == month2)
        //                {
        //                    MessageBox.Show("Thống kê tháng " + dateTimePicker1.Value.Month.ToString() + " theo ngày. Tổng là " + TotalDays.ToString());
        //                } else if (month2 - month1 == 1)
        //                {
        //                    MessageBox.Show("2 tháng liền nhau từ tháng" + dateTimePicker1.Value.Month.ToString());
        //                }
        //            }
        //            else
        //            {
        //                MessageBox.Show("Thống kê năm " + year1.ToString() + " theo tháng. Số tháng là  " + (month2 - month1).ToString());
        //            }
        //        }
        //        else if ((year2 - year1 == 1) && (TotalDays < 365))
        //        {
        //            MessageBox.Show(" 2 năm liền nhau, thống kê theo tháng ");
        //        }
        //        else
        //        {
        //            MessageBox.Show("thống kê 10 năm ");
        //        }
        //    }
        //}
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