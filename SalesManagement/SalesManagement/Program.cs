using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
    static class global
    {
        public static string conString = @"Data Source=DESKTOP-VMO2INA\SQLEXPRESS;Initial Catalog=SALES_MANAGEMENT;Integrated Security=True";
    }
}

