namespace SalesManagement
{
    partial class NhapHang
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
            this.button_them = new System.Windows.Forms.Button();
            this.dataGridView_danhSachSanPham = new System.Windows.Forms.DataGridView();
            this.Column_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_giaNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_giaBanLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ngayNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_boLoc = new System.Windows.Forms.Label();
            this.label_maSanPham = new System.Windows.Forms.Label();
            this.comboBox_boLoc = new System.Windows.Forms.ComboBox();
            this.textBox_tenSanPham = new System.Windows.Forms.TextBox();
            this.textBox_maSanPham = new System.Windows.Forms.TextBox();
            this.button_chinhSua = new System.Windows.Forms.Button();
            this.button_timKiem = new System.Windows.Forms.Button();
            this.button_xuatFile = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label_tenSanPham = new System.Windows.Forms.Label();
            this.button_luuKho = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(825, 508);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(125, 35);
            this.button_them.TabIndex = 54;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
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
            this.Column_giaNhap,
            this.Column_giaBanLe,
            this.Column_hsd,
            this.Column_nhaCungCap,
            this.Column_ngayNhap,
            this.Column_ghiChu});
            this.dataGridView_danhSachSanPham.Location = new System.Drawing.Point(27, 141);
            this.dataGridView_danhSachSanPham.Name = "dataGridView_danhSachSanPham";
            this.dataGridView_danhSachSanPham.Size = new System.Drawing.Size(1054, 347);
            this.dataGridView_danhSachSanPham.TabIndex = 53;
            // 
            // Column_stt
            // 
            this.Column_stt.FillWeight = 167.5127F;
            this.Column_stt.HeaderText = "Stt";
            this.Column_stt.Name = "Column_stt";
            this.Column_stt.Width = 50;
            // 
            // Column_maSanPham
            // 
            this.Column_maSanPham.FillWeight = 93.24873F;
            this.Column_maSanPham.HeaderText = "Mã SP";
            this.Column_maSanPham.Name = "Column_maSanPham";
            this.Column_maSanPham.Width = 110;
            // 
            // Column_ten
            // 
            this.Column_ten.FillWeight = 93.24873F;
            this.Column_ten.HeaderText = "Tên";
            this.Column_ten.Name = "Column_ten";
            this.Column_ten.Width = 110;
            // 
            // Column_soLuong
            // 
            this.Column_soLuong.FillWeight = 93.24873F;
            this.Column_soLuong.HeaderText = "Số lượng";
            this.Column_soLuong.Name = "Column_soLuong";
            this.Column_soLuong.Width = 110;
            // 
            // Column_dvt
            // 
            this.Column_dvt.FillWeight = 93.24873F;
            this.Column_dvt.HeaderText = "Đ.V.Tính";
            this.Column_dvt.Name = "Column_dvt";
            this.Column_dvt.Width = 110;
            // 
            // Column_giaNhap
            // 
            this.Column_giaNhap.FillWeight = 93.24873F;
            this.Column_giaNhap.HeaderText = "Giá Nhập";
            this.Column_giaNhap.Name = "Column_giaNhap";
            this.Column_giaNhap.Width = 111;
            // 
            // Column_giaBanLe
            // 
            this.Column_giaBanLe.FillWeight = 93.24873F;
            this.Column_giaBanLe.HeaderText = "Giá Bán Lẻ";
            this.Column_giaBanLe.Name = "Column_giaBanLe";
            this.Column_giaBanLe.Width = 110;
            // 
            // Column_hsd
            // 
            this.Column_hsd.FillWeight = 93.24873F;
            this.Column_hsd.HeaderText = "HSD";
            this.Column_hsd.Name = "Column_hsd";
            this.Column_hsd.Width = 110;
            // 
            // Column_nhaCungCap
            // 
            this.Column_nhaCungCap.FillWeight = 93.24873F;
            this.Column_nhaCungCap.HeaderText = "Nhà cung cấp";
            this.Column_nhaCungCap.Name = "Column_nhaCungCap";
            this.Column_nhaCungCap.Width = 110;
            // 
            // Column_ngayNhap
            // 
            this.Column_ngayNhap.FillWeight = 93.24873F;
            this.Column_ngayNhap.HeaderText = "Ngày nhập";
            this.Column_ngayNhap.Name = "Column_ngayNhap";
            this.Column_ngayNhap.Width = 110;
            // 
            // Column_ghiChu
            // 
            this.Column_ghiChu.FillWeight = 93.24873F;
            this.Column_ghiChu.HeaderText = "Ghi chú";
            this.Column_ghiChu.Name = "Column_ghiChu";
            this.Column_ghiChu.Width = 110;
            // 
            // label_boLoc
            // 
            this.label_boLoc.AutoSize = true;
            this.label_boLoc.BackColor = System.Drawing.Color.Transparent;
            this.label_boLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_boLoc.Location = new System.Drawing.Point(686, 77);
            this.label_boLoc.Name = "label_boLoc";
            this.label_boLoc.Size = new System.Drawing.Size(46, 16);
            this.label_boLoc.TabIndex = 52;
            this.label_boLoc.Text = "Bộ lọc";
            // 
            // label_maSanPham
            // 
            this.label_maSanPham.AutoSize = true;
            this.label_maSanPham.BackColor = System.Drawing.Color.Transparent;
            this.label_maSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maSanPham.Location = new System.Drawing.Point(29, 77);
            this.label_maSanPham.Name = "label_maSanPham";
            this.label_maSanPham.Size = new System.Drawing.Size(89, 16);
            this.label_maSanPham.TabIndex = 50;
            this.label_maSanPham.Text = "Mã sản phẩm";
            // 
            // comboBox_boLoc
            // 
            this.comboBox_boLoc.FormattingEnabled = true;
            this.comboBox_boLoc.Location = new System.Drawing.Point(686, 94);
            this.comboBox_boLoc.Name = "comboBox_boLoc";
            this.comboBox_boLoc.Size = new System.Drawing.Size(199, 21);
            this.comboBox_boLoc.TabIndex = 49;
            // 
            // textBox_tenSanPham
            // 
            this.textBox_tenSanPham.Location = new System.Drawing.Point(240, 95);
            this.textBox_tenSanPham.Name = "textBox_tenSanPham";
            this.textBox_tenSanPham.Size = new System.Drawing.Size(432, 20);
            this.textBox_tenSanPham.TabIndex = 48;
            // 
            // textBox_maSanPham
            // 
            this.textBox_maSanPham.Location = new System.Drawing.Point(28, 95);
            this.textBox_maSanPham.Name = "textBox_maSanPham";
            this.textBox_maSanPham.Size = new System.Drawing.Size(200, 20);
            this.textBox_maSanPham.TabIndex = 47;
            // 
            // button_chinhSua
            // 
            this.button_chinhSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_chinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chinhSua.Location = new System.Drawing.Point(956, 508);
            this.button_chinhSua.Name = "button_chinhSua";
            this.button_chinhSua.Size = new System.Drawing.Size(125, 35);
            this.button_chinhSua.TabIndex = 46;
            this.button_chinhSua.Text = "Chỉnh sửa";
            this.button_chinhSua.UseVisualStyleBackColor = false;
            this.button_chinhSua.Click += new System.EventHandler(this.button_chinhSua_Click);
            // 
            // button_timKiem
            // 
            this.button_timKiem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timKiem.Location = new System.Drawing.Point(956, 77);
            this.button_timKiem.Name = "button_timKiem";
            this.button_timKiem.Size = new System.Drawing.Size(125, 38);
            this.button_timKiem.TabIndex = 45;
            this.button_timKiem.Text = "Tìm kiếm";
            this.button_timKiem.UseVisualStyleBackColor = false;
            // 
            // button_xuatFile
            // 
            this.button_xuatFile.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_xuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xuatFile.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_xuatFile.Location = new System.Drawing.Point(956, 25);
            this.button_xuatFile.Name = "button_xuatFile";
            this.button_xuatFile.Size = new System.Drawing.Size(125, 39);
            this.button_xuatFile.TabIndex = 44;
            this.button_xuatFile.Text = "Xuất file";
            this.button_xuatFile.UseVisualStyleBackColor = false;
            this.button_xuatFile.Click += new System.EventHandler(this.button_xuatFile_Click);
            // 
            // button_menu
            // 
            this.button_menu.BackgroundImage = global::SalesManagement.Properties.Resources.home;
            this.button_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_menu.Location = new System.Drawing.Point(0, 0);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(46, 42);
            this.button_menu.TabIndex = 43;
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::SalesManagement.Properties.Resources.back1;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.Location = new System.Drawing.Point(44, 0);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(47, 42);
            this.button_back.TabIndex = 42;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label_tenSanPham
            // 
            this.label_tenSanPham.AutoSize = true;
            this.label_tenSanPham.BackColor = System.Drawing.Color.Transparent;
            this.label_tenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenSanPham.Location = new System.Drawing.Point(241, 77);
            this.label_tenSanPham.Name = "label_tenSanPham";
            this.label_tenSanPham.Size = new System.Drawing.Size(94, 16);
            this.label_tenSanPham.TabIndex = 51;
            this.label_tenSanPham.Text = "Tên sản phẩm";
            // 
            // button_luuKho
            // 
            this.button_luuKho.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_luuKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luuKho.Location = new System.Drawing.Point(677, 508);
            this.button_luuKho.Name = "button_luuKho";
            this.button_luuKho.Size = new System.Drawing.Size(140, 35);
            this.button_luuKho.TabIndex = 55;
            this.button_luuKho.Text = "Lưu kho";
            this.button_luuKho.UseVisualStyleBackColor = false;
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesManagement.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1106, 565);
            this.Controls.Add(this.button_luuKho);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.dataGridView_danhSachSanPham);
            this.Controls.Add(this.label_boLoc);
            this.Controls.Add(this.label_maSanPham);
            this.Controls.Add(this.comboBox_boLoc);
            this.Controls.Add(this.textBox_tenSanPham);
            this.Controls.Add(this.textBox_maSanPham);
            this.Controls.Add(this.button_chinhSua);
            this.Controls.Add(this.button_timKiem);
            this.Controls.Add(this.button_xuatFile);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.label_tenSanPham);
            this.Name = "NhapHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nhập hàng";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.DataGridView dataGridView_danhSachSanPham;
        private System.Windows.Forms.Label label_boLoc;
        private System.Windows.Forms.Label label_maSanPham;
        private System.Windows.Forms.ComboBox comboBox_boLoc;
        private System.Windows.Forms.TextBox textBox_tenSanPham;
        private System.Windows.Forms.TextBox textBox_maSanPham;
        private System.Windows.Forms.Button button_chinhSua;
        private System.Windows.Forms.Button button_timKiem;
        private System.Windows.Forms.Button button_xuatFile;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Label label_tenSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_giaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_giaBanLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ngayNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ghiChu;
        private System.Windows.Forms.Button button_luuKho;
    }
}