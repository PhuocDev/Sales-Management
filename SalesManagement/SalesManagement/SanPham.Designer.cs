﻿namespace SalesManagement
{
    partial class SanPham
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button_nhapHang = new System.Windows.Forms.Button();
            this.dataGridView_danhSachSanPham = new System.Windows.Forms.DataGridView();
            this.label_boLoc = new System.Windows.Forms.Label();
            this.label_tenSanPham = new System.Windows.Forms.Label();
            this.label_maSanPham = new System.Windows.Forms.Label();
            this.comboBox_boLoc = new System.Windows.Forms.ComboBox();
            this.textBox_tenSanPham = new System.Windows.Forms.TextBox();
            this.textBox_maSanPham = new System.Windows.Forms.TextBox();
            this.button_chinhSua = new System.Windows.Forms.Button();
            this.button_timKiem = new System.Windows.Forms.Button();
            this.button_xuatFile = new System.Windows.Forms.Button();
            this.label_danhSachSanPham = new System.Windows.Forms.Label();
            this.Column_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_giaBanLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // button_nhapHang
            // 
            this.button_nhapHang.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_nhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nhapHang.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_nhapHang.Location = new System.Drawing.Point(1096, 33);
            this.button_nhapHang.Name = "button_nhapHang";
            this.button_nhapHang.Size = new System.Drawing.Size(160, 40);
            this.button_nhapHang.TabIndex = 52;
            this.button_nhapHang.Text = "Nhập Hàng";
            this.button_nhapHang.UseVisualStyleBackColor = false;
            // 
            // dataGridView_danhSachSanPham
            // 
            this.dataGridView_danhSachSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_danhSachSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_stt,
            this.Column_maSanPham,
            this.Column_ten,
            this.Column_soLuong,
            this.Column_dvt,
            this.Column_giaBanLe,
            this.Column_hsd,
            this.Column_nhaCungCap});
            this.dataGridView_danhSachSanPham.Location = new System.Drawing.Point(62, 166);
            this.dataGridView_danhSachSanPham.Name = "dataGridView_danhSachSanPham";
            this.dataGridView_danhSachSanPham.Size = new System.Drawing.Size(1194, 446);
            this.dataGridView_danhSachSanPham.TabIndex = 51;
            // 
            // label_boLoc
            // 
            this.label_boLoc.AutoSize = true;
            this.label_boLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_boLoc.Location = new System.Drawing.Point(712, 83);
            this.label_boLoc.Name = "label_boLoc";
            this.label_boLoc.Size = new System.Drawing.Size(46, 16);
            this.label_boLoc.TabIndex = 50;
            this.label_boLoc.Text = "Bộ lọc";
            // 
            // label_tenSanPham
            // 
            this.label_tenSanPham.AutoSize = true;
            this.label_tenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenSanPham.Location = new System.Drawing.Point(271, 81);
            this.label_tenSanPham.Name = "label_tenSanPham";
            this.label_tenSanPham.Size = new System.Drawing.Size(94, 16);
            this.label_tenSanPham.TabIndex = 49;
            this.label_tenSanPham.Text = "Tên sản phẩm";
            // 
            // label_maSanPham
            // 
            this.label_maSanPham.AutoSize = true;
            this.label_maSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maSanPham.Location = new System.Drawing.Point(60, 81);
            this.label_maSanPham.Name = "label_maSanPham";
            this.label_maSanPham.Size = new System.Drawing.Size(89, 16);
            this.label_maSanPham.TabIndex = 48;
            this.label_maSanPham.Text = "Mã sản phẩm";
            // 
            // comboBox_boLoc
            // 
            this.comboBox_boLoc.FormattingEnabled = true;
            this.comboBox_boLoc.Location = new System.Drawing.Point(714, 99);
            this.comboBox_boLoc.Name = "comboBox_boLoc";
            this.comboBox_boLoc.Size = new System.Drawing.Size(199, 21);
            this.comboBox_boLoc.TabIndex = 47;
            // 
            // textBox_tenSanPham
            // 
            this.textBox_tenSanPham.Location = new System.Drawing.Point(270, 99);
            this.textBox_tenSanPham.Name = "textBox_tenSanPham";
            this.textBox_tenSanPham.Size = new System.Drawing.Size(432, 20);
            this.textBox_tenSanPham.TabIndex = 46;
            // 
            // textBox_maSanPham
            // 
            this.textBox_maSanPham.Location = new System.Drawing.Point(60, 99);
            this.textBox_maSanPham.Name = "textBox_maSanPham";
            this.textBox_maSanPham.Size = new System.Drawing.Size(196, 20);
            this.textBox_maSanPham.TabIndex = 45;
            // 
            // button_chinhSua
            // 
            this.button_chinhSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_chinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chinhSua.Location = new System.Drawing.Point(1096, 642);
            this.button_chinhSua.Name = "button_chinhSua";
            this.button_chinhSua.Size = new System.Drawing.Size(160, 40);
            this.button_chinhSua.TabIndex = 44;
            this.button_chinhSua.Text = "Chỉnh sửa";
            this.button_chinhSua.UseVisualStyleBackColor = false;
            // 
            // button_timKiem
            // 
            this.button_timKiem.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_timKiem.Enabled = false;
            this.button_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timKiem.Location = new System.Drawing.Point(944, 82);
            this.button_timKiem.Name = "button_timKiem";
            this.button_timKiem.Size = new System.Drawing.Size(91, 40);
            this.button_timKiem.TabIndex = 43;
            this.button_timKiem.Text = "Tìm kiếm";
            this.button_timKiem.UseVisualStyleBackColor = false;
            // 
            // button_xuatFile
            // 
            this.button_xuatFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button_xuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xuatFile.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_xuatFile.Location = new System.Drawing.Point(1096, 79);
            this.button_xuatFile.Name = "button_xuatFile";
            this.button_xuatFile.Size = new System.Drawing.Size(160, 40);
            this.button_xuatFile.TabIndex = 42;
            this.button_xuatFile.Text = "Xuất file";
            this.button_xuatFile.UseVisualStyleBackColor = false;
            this.button_xuatFile.Click += new System.EventHandler(this.button_xuatFile_Click);
            // 
            // label_danhSachSanPham
            // 
            this.label_danhSachSanPham.AutoSize = true;
            this.label_danhSachSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_danhSachSanPham.Location = new System.Drawing.Point(417, 18);
            this.label_danhSachSanPham.Name = "label_danhSachSanPham";
            this.label_danhSachSanPham.Size = new System.Drawing.Size(195, 24);
            this.label_danhSachSanPham.TabIndex = 53;
            this.label_danhSachSanPham.Text = "Danh Sách Sản Phẩm";
            // 
            // Column_stt
            // 
            this.Column_stt.HeaderText = "Stt";
            this.Column_stt.Name = "Column_stt";
            this.Column_stt.Width = 50;
            // 
            // Column_maSanPham
            // 
            this.Column_maSanPham.HeaderText = "Mã SP";
            this.Column_maSanPham.Name = "Column_maSanPham";
            this.Column_maSanPham.Width = 157;
            // 
            // Column_ten
            // 
            this.Column_ten.HeaderText = "Tên";
            this.Column_ten.Name = "Column_ten";
            this.Column_ten.Width = 158;
            // 
            // Column_soLuong
            // 
            this.Column_soLuong.HeaderText = "Số lượng";
            this.Column_soLuong.Name = "Column_soLuong";
            this.Column_soLuong.Width = 157;
            // 
            // Column_dvt
            // 
            this.Column_dvt.HeaderText = "Đ.V.Tính";
            this.Column_dvt.Name = "Column_dvt";
            this.Column_dvt.Width = 157;
            // 
            // Column_giaBanLe
            // 
            this.Column_giaBanLe.HeaderText = "Giá Bán Lẻ";
            this.Column_giaBanLe.Name = "Column_giaBanLe";
            this.Column_giaBanLe.Width = 157;
            // 
            // Column_hsd
            // 
            this.Column_hsd.HeaderText = "HSD";
            this.Column_hsd.Name = "Column_hsd";
            this.Column_hsd.Width = 158;
            // 
            // Column_nhaCungCap
            // 
            this.Column_nhaCungCap.HeaderText = "Nhà cung cấp";
            this.Column_nhaCungCap.Name = "Column_nhaCungCap";
            this.Column_nhaCungCap.Width = 157;
            // 
            // button_menu
            // 
            this.button_menu.Location = new System.Drawing.Point(0, 0);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(46, 42);
            this.button_menu.TabIndex = 41;
            this.button_menu.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            this.button_back.Location = new System.Drawing.Point(45, 0);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(47, 42);
            this.button_back.TabIndex = 40;
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 729);
            this.Controls.Add(this.label_danhSachSanPham);
            this.Controls.Add(this.button_nhapHang);
            this.Controls.Add(this.dataGridView_danhSachSanPham);
            this.Controls.Add(this.label_boLoc);
            this.Controls.Add(this.label_tenSanPham);
            this.Controls.Add(this.label_maSanPham);
            this.Controls.Add(this.comboBox_boLoc);
            this.Controls.Add(this.textBox_tenSanPham);
            this.Controls.Add(this.textBox_maSanPham);
            this.Controls.Add(this.button_chinhSua);
            this.Controls.Add(this.button_timKiem);
            this.Controls.Add(this.button_xuatFile);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_back);
            this.Name = "SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sản phẩm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_nhapHang;
        private System.Windows.Forms.DataGridView dataGridView_danhSachSanPham;
        private System.Windows.Forms.Label label_boLoc;
        private System.Windows.Forms.Label label_tenSanPham;
        private System.Windows.Forms.Label label_maSanPham;
        private System.Windows.Forms.ComboBox comboBox_boLoc;
        private System.Windows.Forms.TextBox textBox_tenSanPham;
        private System.Windows.Forms.TextBox textBox_maSanPham;
        private System.Windows.Forms.Button button_chinhSua;
        private System.Windows.Forms.Button button_timKiem;
        private System.Windows.Forms.Button button_xuatFile;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_danhSachSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_giaBanLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nhaCungCap;
    }
}