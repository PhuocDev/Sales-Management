﻿namespace SalesManagement
{
    partial class FormKhachHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormKhachHang));
            this.btnXoaKH = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThemKH = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.txbDiem = new System.Windows.Forms.TextBox();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbMaKH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button_save = new System.Windows.Forms.Button();
            this.label_warning = new System.Windows.Forms.Label();
            this.button_back = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox_gioiTinh = new System.Windows.Forms.ComboBox();
            this.button_UpdateImage = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnXoaKH
            // 
            this.btnXoaKH.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXoaKH.FlatAppearance.BorderSize = 0;
            this.btnXoaKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaKH.ForeColor = System.Drawing.Color.Black;
            this.btnXoaKH.Location = new System.Drawing.Point(992, 214);
            this.btnXoaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoaKH.Name = "btnXoaKH";
            this.btnXoaKH.Size = new System.Drawing.Size(173, 49);
            this.btnXoaKH.TabIndex = 46;
            this.btnXoaKH.TabStop = false;
            this.btnXoaKH.Text = "Xóa";
            this.btnXoaKH.UseVisualStyleBackColor = false;
            this.btnXoaKH.Click += new System.EventHandler(this.btnXoaKH_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaKH,
            this.ColHoTen,
            this.ColNgaySinh,
            this.ColGioiTinh,
            this.ColSDT,
            this.ColDiaChi,
            this.ColDiem});
            this.dataGridView1.Location = new System.Drawing.Point(61, 418);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.RowTemplate.ReadOnly = true;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.Size = new System.Drawing.Size(1160, 266);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // ColSTT
            // 
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.ReadOnly = true;
            this.ColSTT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSTT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSTT.Width = 40;
            // 
            // ColMaKH
            // 
            this.ColMaKH.HeaderText = "Mã KH";
            this.ColMaKH.MinimumWidth = 6;
            this.ColMaKH.Name = "ColMaKH";
            this.ColMaKH.ReadOnly = true;
            this.ColMaKH.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColMaKH.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColMaKH.Width = 125;
            // 
            // ColHoTen
            // 
            this.ColHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColHoTen.HeaderText = "Họ tên";
            this.ColHoTen.MinimumWidth = 6;
            this.ColHoTen.Name = "ColHoTen";
            this.ColHoTen.ReadOnly = true;
            this.ColHoTen.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColHoTen.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColNgaySinh
            // 
            this.ColNgaySinh.HeaderText = "Ngày sinh";
            this.ColNgaySinh.MinimumWidth = 6;
            this.ColNgaySinh.Name = "ColNgaySinh";
            this.ColNgaySinh.ReadOnly = true;
            this.ColNgaySinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColNgaySinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColNgaySinh.Width = 110;
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.HeaderText = "Giới tính";
            this.ColGioiTinh.MinimumWidth = 6;
            this.ColGioiTinh.Name = "ColGioiTinh";
            this.ColGioiTinh.ReadOnly = true;
            this.ColGioiTinh.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColGioiTinh.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColGioiTinh.Width = 80;
            // 
            // ColSDT
            // 
            this.ColSDT.HeaderText = "SĐT";
            this.ColSDT.MinimumWidth = 6;
            this.ColSDT.Name = "ColSDT";
            this.ColSDT.ReadOnly = true;
            this.ColSDT.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColSDT.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColSDT.Width = 110;
            // 
            // ColDiaChi
            // 
            this.ColDiaChi.HeaderText = "Địa chỉ";
            this.ColDiaChi.MinimumWidth = 6;
            this.ColDiaChi.Name = "ColDiaChi";
            this.ColDiaChi.ReadOnly = true;
            this.ColDiaChi.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColDiaChi.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDiaChi.Width = 180;
            // 
            // ColDiem
            // 
            this.ColDiem.HeaderText = "Điểm";
            this.ColDiem.MinimumWidth = 6;
            this.ColDiem.Name = "ColDiem";
            this.ColDiem.ReadOnly = true;
            this.ColDiem.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.ColDiem.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ColDiem.Width = 75;
            // 
            // btnThemKH
            // 
            this.btnThemKH.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnThemKH.FlatAppearance.BorderSize = 0;
            this.btnThemKH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThemKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemKH.ForeColor = System.Drawing.Color.Black;
            this.btnThemKH.Location = new System.Drawing.Point(992, 96);
            this.btnThemKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThemKH.Name = "btnThemKH";
            this.btnThemKH.Size = new System.Drawing.Size(173, 49);
            this.btnThemKH.TabIndex = 45;
            this.btnThemKH.TabStop = false;
            this.btnThemKH.Text = "Thêm";
            this.btnThemKH.UseVisualStyleBackColor = false;
            this.btnThemKH.Click += new System.EventHandler(this.btnThemKH_Click);
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnXuatFile.FlatAppearance.BorderSize = 0;
            this.btnXuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.ForeColor = System.Drawing.Color.Black;
            this.btnXuatFile.Location = new System.Drawing.Point(992, 281);
            this.btnXuatFile.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(173, 49);
            this.btnXuatFile.TabIndex = 44;
            this.btnXuatFile.TabStop = false;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            this.btnXuatFile.Click += new System.EventHandler(this.btnXuatFile_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnChinhSua.FlatAppearance.BorderSize = 0;
            this.btnChinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.ForeColor = System.Drawing.Color.Black;
            this.btnChinhSua.Location = new System.Drawing.Point(992, 154);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(173, 49);
            this.btnChinhSua.TabIndex = 43;
            this.btnChinhSua.TabStop = false;
            this.btnChinhSua.Text = "Sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.Color.Transparent;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKhachHang.Location = new System.Drawing.Point(944, 36);
            this.btnKhachHang.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(149, 39);
            this.btnKhachHang.TabIndex = 42;
            this.btnKhachHang.TabStop = false;
            this.btnKhachHang.Text = "KHÁCH HÀNG";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.Color.Transparent;
            this.btnNhanVien.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNhanVien.Location = new System.Drawing.Point(1084, 36);
            this.btnNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(156, 39);
            this.btnNhanVien.TabIndex = 41;
            this.btnNhanVien.TabStop = false;
            this.btnNhanVien.Text = "NHÂN VIÊN";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            this.btnNhanVien.Click += new System.EventHandler(this.btnNhanVien_Click);
            // 
            // txbDiem
            // 
            this.txbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiem.Location = new System.Drawing.Point(528, 359);
            this.txbDiem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDiem.Name = "txbDiem";
            this.txbDiem.Size = new System.Drawing.Size(344, 27);
            this.txbDiem.TabIndex = 5;
            this.txbDiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbDiem_KeyPress);
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(528, 306);
            this.txbDiaChi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(344, 27);
            this.txbDiaChi.TabIndex = 4;
            // 
            // txbSDT
            // 
            this.txbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDT.Location = new System.Drawing.Point(528, 255);
            this.txbSDT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(344, 27);
            this.txbSDT.TabIndex = 3;
            this.txbSDT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSDT_KeyPress);
            // 
            // txbHoTen
            // 
            this.txbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTen.Location = new System.Drawing.Point(528, 96);
            this.txbHoTen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(344, 27);
            this.txbHoTen.TabIndex = 1;
            // 
            // txbMaKH
            // 
            this.txbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaKH.Location = new System.Drawing.Point(528, 47);
            this.txbMaKH.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.ReadOnly = true;
            this.txbMaKH.Size = new System.Drawing.Size(344, 27);
            this.txbMaKH.TabIndex = 0;
            this.txbMaKH.Enter += new System.EventHandler(this.txbMaKH_Enter);
            this.txbMaKH.Leave += new System.EventHandler(this.txbMaKH_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 362);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Điểm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 310);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 31;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 258);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 30;
            this.label5.Text = "SDT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Mã KH:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(528, 148);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(344, 26);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // button_save
            // 
            this.button_save.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_save.FlatAppearance.BorderSize = 0;
            this.button_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_save.ForeColor = System.Drawing.Color.Black;
            this.button_save.Location = new System.Drawing.Point(992, 343);
            this.button_save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(173, 44);
            this.button_save.TabIndex = 51;
            this.button_save.TabStop = false;
            this.button_save.Text = "Lưu";
            this.button_save.UseVisualStyleBackColor = false;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label_warning
            // 
            this.label_warning.AutoSize = true;
            this.label_warning.ForeColor = System.Drawing.Color.Red;
            this.label_warning.Location = new System.Drawing.Point(528, 30);
            this.label_warning.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_warning.Name = "label_warning";
            this.label_warning.Size = new System.Drawing.Size(0, 17);
            this.label_warning.TabIndex = 52;
            // 
            // button_back
            // 
            this.button_back.BackColor = System.Drawing.Color.Transparent;
            this.button_back.BackgroundImage = global::SalesManagement.Properties.Resources.output_onlinepngtools;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Location = new System.Drawing.Point(1, 2);
            this.button_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(63, 52);
            this.button_back.TabIndex = 48;
            this.button_back.UseVisualStyleBackColor = false;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::SalesManagement.Properties.Resources.khach_hang;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(51, 30);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button_UpdateImage);
            this.groupBox1.Controls.Add(this.comboBox_gioiTinh);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(64, 30);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(856, 374);
            this.groupBox1.TabIndex = 53;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Khách hàng";
            // 
            // comboBox_gioiTinh
            // 
            this.comboBox_gioiTinh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.comboBox_gioiTinh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.comboBox_gioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox_gioiTinh.FormattingEnabled = true;
            this.comboBox_gioiTinh.Items.AddRange(new object[] {
            "Nam",
            "Nữ"});
            this.comboBox_gioiTinh.Location = new System.Drawing.Point(464, 172);
            this.comboBox_gioiTinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox_gioiTinh.Name = "comboBox_gioiTinh";
            this.comboBox_gioiTinh.Size = new System.Drawing.Size(344, 28);
            this.comboBox_gioiTinh.TabIndex = 0;
            this.comboBox_gioiTinh.Leave += new System.EventHandler(this.comboBox_gioiTinh_Leave);
            // 
            // button_UpdateImage
            // 
            this.button_UpdateImage.BackColor = System.Drawing.Color.Transparent;
            this.button_UpdateImage.FlatAppearance.BorderSize = 0;
            this.button_UpdateImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_UpdateImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_UpdateImage.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button_UpdateImage.Location = new System.Drawing.Point(108, 333);
            this.button_UpdateImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button_UpdateImage.Name = "button_UpdateImage";
            this.button_UpdateImage.Size = new System.Drawing.Size(122, 30);
            this.button_UpdateImage.TabIndex = 22;
            this.button_UpdateImage.TabStop = false;
            this.button_UpdateImage.Text = "Chọn ảnh";
            this.button_UpdateImage.UseVisualStyleBackColor = false;
            this.button_UpdateImage.Click += new System.EventHandler(this.button_UpdateImage_Click);
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1299, 721);
            this.Controls.Add(this.label_warning);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.btnXoaKH);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThemKH);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.txbDiem);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.txbMaKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Khách hàng";
            this.Load += new System.EventHandler(this.FormKhachHang_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaKH;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThemKH;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.TextBox txbDiem;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbMaKH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label_warning;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox_gioiTinh;
        private System.Windows.Forms.Button button_UpdateImage;
    }
}