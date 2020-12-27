namespace SalesManagement
{
    partial class sanPham
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button_nhapHang = new System.Windows.Forms.Button();
            this.dataGridView_danhSachSanPham = new System.Windows.Forms.DataGridView();
            this.Column_stt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_maSanPham = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_ten = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_soLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_dvt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_giaBanLe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_hsd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_nhaCungCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label_boLoc = new System.Windows.Forms.Label();
            this.label_tenSanPham = new System.Windows.Forms.Label();
            this.label_maSanPham = new System.Windows.Forms.Label();
            this.comboBox_boLoc = new System.Windows.Forms.ComboBox();
            this.button_chinhSua = new System.Windows.Forms.Button();
            this.button_timKiem = new System.Windows.Forms.Button();
            this.button_xuatFile = new System.Windows.Forms.Button();
            this.button_luu = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.textBox_ten = new System.Windows.Forms.TextBox();
            this.textBox_masp = new System.Windows.Forms.TextBox();
            this.button_fullsp = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // button_nhapHang
            // 
            this.button_nhapHang.BackColor = System.Drawing.Color.Transparent;
            this.button_nhapHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_nhapHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_nhapHang.ForeColor = System.Drawing.Color.Navy;
            this.button_nhapHang.Location = new System.Drawing.Point(821, 12);
            this.button_nhapHang.Name = "button_nhapHang";
            this.button_nhapHang.Size = new System.Drawing.Size(140, 40);
            this.button_nhapHang.TabIndex = 52;
            this.button_nhapHang.TabStop = false;
            this.button_nhapHang.Text = "Nhập Hàng";
            this.button_nhapHang.UseVisualStyleBackColor = false;
            this.button_nhapHang.Click += new System.EventHandler(this.button_nhapHang_Click);
            // 
            // dataGridView_danhSachSanPham
            // 
            this.dataGridView_danhSachSanPham.AllowUserToAddRows = false;
            this.dataGridView_danhSachSanPham.AllowUserToDeleteRows = false;
            this.dataGridView_danhSachSanPham.BackgroundColor = System.Drawing.Color.White;
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
            this.dataGridView_danhSachSanPham.Location = new System.Drawing.Point(28, 161);
            this.dataGridView_danhSachSanPham.Name = "dataGridView_danhSachSanPham";
            this.dataGridView_danhSachSanPham.ReadOnly = true;
            this.dataGridView_danhSachSanPham.RowHeadersWidth = 51;
            this.dataGridView_danhSachSanPham.Size = new System.Drawing.Size(773, 358);
            this.dataGridView_danhSachSanPham.TabIndex = 51;
            // 
            // Column_stt
            // 
            this.Column_stt.FillWeight = 19.36658F;
            this.Column_stt.HeaderText = "Stt";
            this.Column_stt.MinimumWidth = 6;
            this.Column_stt.Name = "Column_stt";
            this.Column_stt.ReadOnly = true;
            this.Column_stt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_stt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_stt.Width = 50;
            // 
            // Column_maSanPham
            // 
            this.Column_maSanPham.FillWeight = 61.19238F;
            this.Column_maSanPham.HeaderText = "Mã SP";
            this.Column_maSanPham.MinimumWidth = 6;
            this.Column_maSanPham.Name = "Column_maSanPham";
            this.Column_maSanPham.ReadOnly = true;
            this.Column_maSanPham.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_maSanPham.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_maSanPham.Width = 150;
            // 
            // Column_ten
            // 
            this.Column_ten.FillWeight = 406.0914F;
            this.Column_ten.HeaderText = "Tên";
            this.Column_ten.MinimumWidth = 6;
            this.Column_ten.Name = "Column_ten";
            this.Column_ten.ReadOnly = true;
            this.Column_ten.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_ten.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_ten.Width = 200;
            // 
            // Column_soLuong
            // 
            this.Column_soLuong.FillWeight = 112.7079F;
            this.Column_soLuong.HeaderText = "Số lượng";
            this.Column_soLuong.MinimumWidth = 6;
            this.Column_soLuong.Name = "Column_soLuong";
            this.Column_soLuong.ReadOnly = true;
            this.Column_soLuong.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_soLuong.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_soLuong.Width = 125;
            // 
            // Column_dvt
            // 
            this.Column_dvt.FillWeight = 50.16045F;
            this.Column_dvt.HeaderText = "Đ.V.Tính";
            this.Column_dvt.MinimumWidth = 6;
            this.Column_dvt.Name = "Column_dvt";
            this.Column_dvt.ReadOnly = true;
            this.Column_dvt.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_dvt.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_dvt.Width = 125;
            // 
            // Column_giaBanLe
            // 
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column_giaBanLe.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_giaBanLe.FillWeight = 50.16045F;
            this.Column_giaBanLe.HeaderText = "Giá Bán Lẻ";
            this.Column_giaBanLe.MinimumWidth = 6;
            this.Column_giaBanLe.Name = "Column_giaBanLe";
            this.Column_giaBanLe.ReadOnly = true;
            this.Column_giaBanLe.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_giaBanLe.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_giaBanLe.Width = 125;
            // 
            // Column_hsd
            // 
            this.Column_hsd.FillWeight = 50.16045F;
            this.Column_hsd.HeaderText = "HSD";
            this.Column_hsd.MinimumWidth = 6;
            this.Column_hsd.Name = "Column_hsd";
            this.Column_hsd.ReadOnly = true;
            this.Column_hsd.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_hsd.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_hsd.Width = 125;
            // 
            // Column_nhaCungCap
            // 
            this.Column_nhaCungCap.FillWeight = 50.16045F;
            this.Column_nhaCungCap.HeaderText = "Nhà cung cấp";
            this.Column_nhaCungCap.MinimumWidth = 6;
            this.Column_nhaCungCap.Name = "Column_nhaCungCap";
            this.Column_nhaCungCap.ReadOnly = true;
            this.Column_nhaCungCap.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column_nhaCungCap.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Column_nhaCungCap.Width = 175;
            // 
            // label_boLoc
            // 
            this.label_boLoc.AutoSize = true;
            this.label_boLoc.BackColor = System.Drawing.Color.Transparent;
            this.label_boLoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_boLoc.Location = new System.Drawing.Point(356, 70);
            this.label_boLoc.Name = "label_boLoc";
            this.label_boLoc.Size = new System.Drawing.Size(46, 16);
            this.label_boLoc.TabIndex = 50;
            this.label_boLoc.Text = "Bộ lọc";
            // 
            // label_tenSanPham
            // 
            this.label_tenSanPham.AutoSize = true;
            this.label_tenSanPham.BackColor = System.Drawing.Color.Transparent;
            this.label_tenSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tenSanPham.Location = new System.Drawing.Point(25, 106);
            this.label_tenSanPham.Name = "label_tenSanPham";
            this.label_tenSanPham.Size = new System.Drawing.Size(94, 16);
            this.label_tenSanPham.TabIndex = 49;
            this.label_tenSanPham.Text = "Tên sản phẩm";
            // 
            // label_maSanPham
            // 
            this.label_maSanPham.AutoSize = true;
            this.label_maSanPham.BackColor = System.Drawing.Color.Transparent;
            this.label_maSanPham.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_maSanPham.Location = new System.Drawing.Point(27, 72);
            this.label_maSanPham.Name = "label_maSanPham";
            this.label_maSanPham.Size = new System.Drawing.Size(89, 16);
            this.label_maSanPham.TabIndex = 48;
            this.label_maSanPham.Text = "Mã sản phẩm";
            // 
            // comboBox_boLoc
            // 
            this.comboBox_boLoc.FormattingEnabled = true;
            this.comboBox_boLoc.Items.AddRange(new object[] {
            "Giá  dưới 100.000đ",
            "Giá từ 100.000đ đến 1.000.000đ",
            "Giá từ 1.000.000đ đến 10.000.000đ",
            "Giá trên 10.000.000đ",
            "Hết HSD"});
            this.comboBox_boLoc.Location = new System.Drawing.Point(421, 68);
            this.comboBox_boLoc.Name = "comboBox_boLoc";
            this.comboBox_boLoc.Size = new System.Drawing.Size(199, 21);
            this.comboBox_boLoc.TabIndex = 2;
            // 
            // button_chinhSua
            // 
            this.button_chinhSua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_chinhSua.FlatAppearance.BorderSize = 0;
            this.button_chinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chinhSua.Location = new System.Drawing.Point(821, 218);
            this.button_chinhSua.Name = "button_chinhSua";
            this.button_chinhSua.Size = new System.Drawing.Size(140, 37);
            this.button_chinhSua.TabIndex = 44;
            this.button_chinhSua.TabStop = false;
            this.button_chinhSua.Text = "Sửa";
            this.button_chinhSua.UseVisualStyleBackColor = false;
            this.button_chinhSua.Click += new System.EventHandler(this.button_chinhSua_Click);
            // 
            // button_timKiem
            // 
            this.button_timKiem.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_timKiem.FlatAppearance.BorderSize = 0;
            this.button_timKiem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_timKiem.Location = new System.Drawing.Point(666, 72);
            this.button_timKiem.Name = "button_timKiem";
            this.button_timKiem.Size = new System.Drawing.Size(85, 50);
            this.button_timKiem.TabIndex = 3;
            this.button_timKiem.Text = "Tìm kiếm";
            this.button_timKiem.UseVisualStyleBackColor = false;
            this.button_timKiem.Click += new System.EventHandler(this.button_timKiem_Click);
            // 
            // button_xuatFile
            // 
            this.button_xuatFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_xuatFile.FlatAppearance.BorderSize = 0;
            this.button_xuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xuatFile.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_xuatFile.Location = new System.Drawing.Point(821, 274);
            this.button_xuatFile.Name = "button_xuatFile";
            this.button_xuatFile.Size = new System.Drawing.Size(140, 40);
            this.button_xuatFile.TabIndex = 42;
            this.button_xuatFile.TabStop = false;
            this.button_xuatFile.Text = "Xuất file";
            this.button_xuatFile.UseVisualStyleBackColor = false;
            this.button_xuatFile.Click += new System.EventHandler(this.button_xuatFile_Click);
            // 
            // button_luu
            // 
            this.button_luu.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_luu.FlatAppearance.BorderSize = 0;
            this.button_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luu.Location = new System.Drawing.Point(821, 482);
            this.button_luu.Name = "button_luu";
            this.button_luu.Size = new System.Drawing.Size(140, 37);
            this.button_luu.TabIndex = 54;
            this.button_luu.TabStop = false;
            this.button_luu.Text = "Lưu";
            this.button_luu.UseVisualStyleBackColor = false;
            this.button_luu.Click += new System.EventHandler(this.button_luu_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_xoa.FlatAppearance.BorderSize = 0;
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(821, 161);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(140, 37);
            this.button_xoa.TabIndex = 58;
            this.button_xoa.TabStop = false;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // textBox_ten
            // 
            this.textBox_ten.Location = new System.Drawing.Point(134, 106);
            this.textBox_ten.Name = "textBox_ten";
            this.textBox_ten.Size = new System.Drawing.Size(486, 20);
            this.textBox_ten.TabIndex = 1;
            // 
            // textBox_masp
            // 
            this.textBox_masp.Location = new System.Drawing.Point(134, 68);
            this.textBox_masp.Name = "textBox_masp";
            this.textBox_masp.Size = new System.Drawing.Size(206, 20);
            this.textBox_masp.TabIndex = 0;
            // 
            // button_fullsp
            // 
            this.button_fullsp.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_fullsp.FlatAppearance.BorderSize = 0;
            this.button_fullsp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_fullsp.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_fullsp.Location = new System.Drawing.Point(821, 104);
            this.button_fullsp.Name = "button_fullsp";
            this.button_fullsp.Size = new System.Drawing.Size(140, 37);
            this.button_fullsp.TabIndex = 61;
            this.button_fullsp.TabStop = false;
            this.button_fullsp.Text = "Toàn bộ sản phẩm";
            this.button_fullsp.UseVisualStyleBackColor = false;
            this.button_fullsp.Click += new System.EventHandler(this.button_fullsp_Click);
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Transparent;
            this.button_back.BackgroundImage = global::SalesManagement.Properties.Resources.output_onlinepngtools;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Location = new System.Drawing.Point(44, 2);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(42, 40);
            this.button_back.TabIndex = 55;
            this.button_back.TabStop = false;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // button_menu
            // 
            this.button_menu.BackgroundImage = global::SalesManagement.Properties.Resources.home2;
            this.button_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_menu.FlatAppearance.BorderSize = 0;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Location = new System.Drawing.Point(2, 2);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(42, 40);
            this.button_menu.TabIndex = 41;
            this.button_menu.TabStop = false;
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 25);
            this.label1.TabIndex = 75;
            this.label1.Text = "Sản Phẩm";
            // 
            // sanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(990, 565);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_fullsp);
            this.Controls.Add(this.textBox_masp);
            this.Controls.Add(this.textBox_ten);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_luu);
            this.Controls.Add(this.button_nhapHang);
            this.Controls.Add(this.dataGridView_danhSachSanPham);
            this.Controls.Add(this.label_boLoc);
            this.Controls.Add(this.label_tenSanPham);
            this.Controls.Add(this.label_maSanPham);
            this.Controls.Add(this.comboBox_boLoc);
            this.Controls.Add(this.button_chinhSua);
            this.Controls.Add(this.button_timKiem);
            this.Controls.Add(this.button_xuatFile);
            this.Controls.Add(this.button_menu);
            this.Name = "sanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.sanPham_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_nhapHang;
        public System.Windows.Forms.DataGridView dataGridView_danhSachSanPham;
        private System.Windows.Forms.Label label_boLoc;
        private System.Windows.Forms.Label label_tenSanPham;
        private System.Windows.Forms.Label label_maSanPham;
        private System.Windows.Forms.ComboBox comboBox_boLoc;
        private System.Windows.Forms.Button button_chinhSua;
        private System.Windows.Forms.Button button_timKiem;
        private System.Windows.Forms.Button button_xuatFile;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_luu;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.TextBox textBox_ten;
        private System.Windows.Forms.TextBox textBox_masp;
        private System.Windows.Forms.Button button_fullsp;
        private System.Windows.Forms.Label label1;
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