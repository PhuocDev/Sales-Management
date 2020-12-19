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
        
        //-------------------------------------------------------------thêm----------------------------------------------------------------------------//

        private void button_them_Click(object sender, EventArgs e)
        {
            if (textBox_tensp.Text == "" || textBox_masp.Text == "" || textBox_sluong.Text == "" || textBox_giaNhap.Text == "" || textBox_giaBan.Text == "" || textBox_dvt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dủ thông tin cần thiết");
                return;
            }
            for (int i = 0; i < dataGridView_danhSachSanPham.Rows.Count; i++)
            {
                if(textBox_masp.Text == dataGridView_danhSachSanPham.Rows[i].Cells[1].Value.ToString())
                {
                    DialogResult result =  MessageBox.Show("Sản phẩm đã có trong danh sách, bạn có muốn thay thế", "Thông báo", MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                    if (result == DialogResult.No) return;
                    else
                    {
                        dataGridView_danhSachSanPham.Rows.RemoveAt(i);
                        break;
                    }
                }
            }

            dataGridView_danhSachSanPham.Rows.Add(dataGridView_danhSachSanPham.Rows.Count + 1, textBox_masp.Text, 
                textBox_tensp.Text, textBox_sluong.Text, textBox_dvt.Text, textBox_giaNhap.Text, textBox_giaBan.Text, 
                dateTimePicker1_hsd.Value.ToString().Substring(0, dateTimePicker1_hsd.Value.ToString().IndexOf(" ")), textBox_nhacc.Text, textBox_ghiChu.Text);
        }
        //--------------------------------------------------------------------chỉnh_sửa----------------------------------------------------------------------//
        private void button_chinhSua_Click(object sender, EventArgs e)
        {
            if (textBox_tensp.Text == "" || textBox_masp.Text == "" || textBox_sluong.Text == "" || textBox_giaNhap.Text == "" || textBox_giaBan.Text == "" || textBox_dvt.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập dủ thông tin cần thiết");
                return;
            }
            for (int i = 0; i < dataGridView_danhSachSanPham.Rows.Count; i++)
            {
                if (textBox_masp.Text == dataGridView_danhSachSanPham.Rows[i].Cells[1].Value.ToString())
                {
                    dataGridView_danhSachSanPham.Rows[i].Cells[1].Value = textBox_masp.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[2].Value = textBox_tensp.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[3].Value = textBox_sluong.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[4].Value = textBox_dvt.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[5].Value = textBox_giaNhap.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[6].Value = textBox_giaBan.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[7].Value = dateTimePicker1_hsd.Value.ToString().Substring(0, dateTimePicker1_hsd.Value.ToString().IndexOf(" "));
                    dataGridView_danhSachSanPham.Rows[i].Cells[8].Value = textBox_nhacc.Text;
                    dataGridView_danhSachSanPham.Rows[i].Cells[9].Value = textBox_ghiChu.Text;
                    return;
                }
            }
        }
        //-----------------------------------------------------------------xóa------------------------------------------------------------------------//
        private void button_xoa_Click(object sender, EventArgs e)
        {
            DialogResult result =  MessageBox.Show("Bạn có chắc muốn xóa sản phẩm đã chọn", "", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if(result == DialogResult.Yes)
            {
                DataGridViewCell cell = dataGridView_danhSachSanPham.CurrentCell;
                if (cell == null) return;
                int index = cell.RowIndex;
                dataGridView_danhSachSanPham.Rows.RemoveAt(index);
                for(int i = dataGridView_danhSachSanPham.CurrentCell.RowIndex; i< dataGridView_danhSachSanPham.Rows.Count; i++)
                {
                    DataGridViewRow row = dataGridView_danhSachSanPham.Rows[i];
                    row.Cells[0].Value = i + 1;
                }
                textBox_masp.Text = "";
                textBox_tensp.Text = "";
                textBox_sluong.Text = "";
                textBox_dvt.Text = "";
                textBox_giaNhap.Text = "";
                textBox_giaBan.Text = "";
                dateTimePicker1_hsd.Text = "";
                textBox_nhacc.Text = "";
                textBox_ghiChu.Text = "";
            }
        }
        //----------------------------------------------------------------chuyển_forrm----------------------------------------------------------------//
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_menu_Click(object sender, EventArgs e)
        {
            this.Close();
            this.change();
        }

        //---------------------------------------------------------------cell_click--------------------------------------------------------------------//
        private void dataGridView_danhSachSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dataGridView_danhSachSanPham.CurrentCell;
            int index = cell.RowIndex;
            textBox_masp.Text = dataGridView_danhSachSanPham.Rows[index].Cells[1].Value.ToString();
            textBox_tensp.Text = dataGridView_danhSachSanPham.Rows[index].Cells[2].Value.ToString();
            textBox_sluong.Text = dataGridView_danhSachSanPham.Rows[index].Cells[3].Value.ToString();
            textBox_dvt.Text = dataGridView_danhSachSanPham.Rows[index].Cells[4].Value.ToString();
            textBox_giaNhap.Text = dataGridView_danhSachSanPham.Rows[index].Cells[5].Value.ToString();
            textBox_giaBan.Text = dataGridView_danhSachSanPham.Rows[index].Cells[6].Value.ToString();
            dateTimePicker1_hsd.Text = dataGridView_danhSachSanPham.Rows[index].Cells[7].Value.ToString();
            textBox_nhacc.Text = dataGridView_danhSachSanPham.Rows[index].Cells[8].Value.ToString();
            textBox_ghiChu.Text = dataGridView_danhSachSanPham.Rows[index].Cells[9].Value.ToString();
        }
        //-------------------------------------------------------điều_kiện_nhập------------------------------------------------------------------------------//
        private void textBox_sluong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_giaNhap_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_giaBan_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //-------------------------------------------------------------------lưu_kho---------------------------------------------------------------------------//
        private void button_luuKho_Click(object sender, EventArgs e)
        {

        }
    }
}
