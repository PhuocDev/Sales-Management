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
    public partial class FormKhachHang : Form
    {
        public changeform change;
        public FormKhachHang()
        {
            InitializeComponent();
        }
        public FormKhachHang(changeform change)
        {
            InitializeComponent();
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
    }
}
