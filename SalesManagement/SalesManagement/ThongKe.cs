using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class ThongKe : Form
    {
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
        // tham khảo link : https://www.c-sharpcorner.com/UploadFile/1e050f/chart-control-in-windows-form-ap
        private void ThongKe_Load(object sender, EventArgs e)
        {
            fillChart();
        }
        
        private void fillChart()
        {
            //AddXY value in chart1 in series named as Salary  
            chart1.Series["Doanh Thu"].Points.AddXY("T1", "1000000");
            chart1.Series["Doanh Thu"].Points.AddXY("T2", "8000000");
            chart1.Series["Doanh Thu"].Points.AddXY("T3", "7000000");
            chart1.Series["Doanh Thu"].Points.AddXY("T4", "1000000");
            chart1.Series["Doanh Thu"].Points.AddXY("T5", "8500000");
            //chart title  
            chart1.Titles.Add("Doanh Thu Chart");
        }
    }
}
