using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesManagement
{
    public partial class ChinhSuaDSSP : Form
    {
        sanPham parent;
        CultureInfo cultureInfo;
        public ChinhSuaDSSP(sanPham parent)
        {
            this.parent = parent;
            InitializeComponent();
            SetCulture();
            DataGridViewCell cell = parent.dataGridView_danhSachSanPham.CurrentCell;
            textBox_msp.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[1].Value.ToString();
            textBox_tenSP.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[2].Value.ToString();
            textBox_soLuong.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[3].Value.ToString();
            textBox_donViTinh.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[4].Value.ToString();
            //textBox_giaBanLe.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[5].Value.ToString();

            //textBox_giaBanLe.Text = string.Format(cultureInfo, "{0:C0}", Convert.ToInt32(parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[5].Value));
            textBox_giaBanLe.Text = string.Format(cultureInfo, "{0:C0}", int.Parse(parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[5].Value.ToString(), NumberStyles.Currency));

            dateTimePicker1_hsd.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[6].Value.ToString();
            textBox_nhaCungCap.Text = parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[7].Value.ToString();
        }
        public ChinhSuaDSSP()
        {
            InitializeComponent();
        }
        private void SetCulture()
        {
            NumberFormatInfo nfi = new CultureInfo("vn-VN", false).NumberFormat;
            nfi.CurrencyPositivePattern = 3;
            nfi.CurrencyNegativePattern = 3;
            nfi.NumberDecimalSeparator = ".";
            nfi.NumberGroupSeparator = ",";
            cultureInfo = new CultureInfo("vn-VN", false);
            cultureInfo.NumberFormat = nfi;
            Thread.CurrentThread.CurrentCulture = cultureInfo;
        }

        private void button_huyBo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewCell cell = parent.dataGridView_danhSachSanPham.CurrentCell;
                parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[2].Value = textBox_tenSP.Text;
                parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[3].Value = textBox_soLuong.Text;
                parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[4].Value = textBox_donViTinh.Text;
                parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[5].Value = textBox_giaBanLe.Text;
                parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[6].Value = dateTimePicker1_hsd.Value.ToString().Substring(0, dateTimePicker1_hsd.Value.ToString().IndexOf(" "));
                parent.dataGridView_danhSachSanPham.Rows[cell.RowIndex].Cells[7].Value = textBox_nhaCungCap.Text;

                string[] info_sp = new string[7];
                info_sp[0] = textBox_msp.Text;//masp
                info_sp[1] = textBox_tenSP.Text;//tensp
                info_sp[2] = textBox_soLuong.Text; //số lượng
                info_sp[3] = textBox_donViTinh.Text;//dvt
                info_sp[4] = int.Parse(textBox_giaBanLe.Text, NumberStyles.Currency).ToString();//giá bán lẻ
                info_sp[5] = dateTimePicker1_hsd.Value.ToString().Substring(0, dateTimePicker1_hsd.Value.ToString().IndexOf(" "));//hsd
                info_sp[6] = textBox_nhaCungCap.Text;//nhà cung cấp
                sanPham.list_changes.Add(info_sp);// thêm vào danh sách sản phẩm bị thay đổi thông tin
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox_giaBanLe_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string stringSoTien = textBox_giaBanLe.Text.Replace(".", "").Replace(",", "").Replace("₫", "").Replace(" ", "");
                if (stringSoTien == "") stringSoTien = "0";
                int soTien = int.Parse(stringSoTien);
                textBox_giaBanLe.TextChanged -= textBox_giaBanLe_TextChanged;
                textBox_giaBanLe.Text = string.Format(cultureInfo, "{0:C0}", soTien);
                textBox_giaBanLe.TextChanged += textBox_giaBanLe_TextChanged;
                textBox_giaBanLe.Select(textBox_giaBanLe.Text.Length - 2, 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void textBox_soLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox_giaBanLe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
