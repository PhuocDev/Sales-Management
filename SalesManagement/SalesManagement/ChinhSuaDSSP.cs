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
    public partial class ChinhSuaDSSP : Form
    {
        SanPham parent;
        public ChinhSuaDSSP(SanPham parent)
        {
            this.parent = parent;
            InitializeComponent();
            DataGridViewCell cell = parent.dataGridView_danhSachSanPham.CurrentCell;
            textBox_msp.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[1].Value.ToString();
            textBox_tenSP.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[2].Value.ToString();
            textBox_soLuong.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[3].Value.ToString();
            textBox_donViTinh.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[4].Value.ToString();
            textBox_giaBanLe.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[5].Value.ToString();
            textBox_hsd.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[6].Value.ToString();
            textBox_nhaCungCap.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[7].Value.ToString();
        }
        public ChinhSuaDSSP()
        {
            InitializeComponent();
        }

        private void button_huyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            DataGridViewCell cell = parent.dataGridView_danhSachSanPham.CurrentCell;
            parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[1].Value = textBox_msp.Text;
            parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[2].Value = textBox_tenSP.Text;
            parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[3].Value = textBox_soLuong.Text;
            parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[4].Value = textBox_donViTinh.Text;
            parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[5].Value = textBox_giaBanLe.Text;
            parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[6].Value = textBox_hsd.Text;
            parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[7].Value = textBox_nhaCungCap.Text;
            this.Close();
        }
    }
}
