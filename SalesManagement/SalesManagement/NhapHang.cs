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
    public partial class NhapHang : Form
    {
        public changeform change;
        public NhapHang()
        {
            InitializeComponent();
        }
        public NhapHang(changeform change)
        {
            InitializeComponent();
            this.change = change;
        }

        private void button_them_Click(object sender, EventArgs e)
        {
            AddSP ad = new AddSP();
            ad.ShowDialog();
        }

        private void button_xuatFile_Click(object sender, EventArgs e)
        {

        }

        private void button_chinhSua_Click(object sender, EventArgs e)
        {
            ChinhSuaDSNH cs = new ChinhSuaDSNH();
            cs.ShowDialog();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.change();
        }
    }
}
