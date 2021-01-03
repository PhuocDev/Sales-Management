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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhapHang));
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
            this.Column_ghiChu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button_chinhSua = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_xuatFile = new System.Windows.Forms.Button();
            this.button_luuKho = new System.Windows.Forms.Button();
            this.textBox_masp = new System.Windows.Forms.TextBox();
            this.textBox_tensp = new System.Windows.Forms.TextBox();
            this.textBox_giaBan = new System.Windows.Forms.TextBox();
            this.textBox_giaNhap = new System.Windows.Forms.TextBox();
            this.textBox_sluong = new System.Windows.Forms.TextBox();
            this.textBox_nhacc = new System.Windows.Forms.TextBox();
            this.textBox_ghiChu = new System.Windows.Forms.TextBox();
            this.textBox_dvt = new System.Windows.Forms.TextBox();
            this.label_ghiChu = new System.Windows.Forms.Label();
            this.label_giaNhap = new System.Windows.Forms.Label();
            this.label_nhaCungCap = new System.Windows.Forms.Label();
            this.label_dvt = new System.Windows.Forms.Label();
            this.label_soLuog = new System.Windows.Forms.Label();
            this.label_tensp = new System.Windows.Forms.Label();
            this.label_msp = new System.Windows.Forms.Label();
            this.label_HSD = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker1_hsd = new System.Windows.Forms.DateTimePicker();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button_taoMoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_danhSachSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // button_them
            // 
            this.button_them.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_them.FlatAppearance.BorderSize = 0;
            this.button_them.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Location = new System.Drawing.Point(1193, 240);
            this.button_them.Margin = new System.Windows.Forms.Padding(4);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(207, 49);
            this.button_them.TabIndex = 9;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // dataGridView_danhSachSanPham
            // 
            this.dataGridView_danhSachSanPham.AllowUserToAddRows = false;
            this.dataGridView_danhSachSanPham.AllowUserToDeleteRows = false;
            this.dataGridView_danhSachSanPham.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView_danhSachSanPham.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_danhSachSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
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
            this.Column_ghiChu});
            this.dataGridView_danhSachSanPham.Location = new System.Drawing.Point(16, 240);
            this.dataGridView_danhSachSanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_danhSachSanPham.Name = "dataGridView_danhSachSanPham";
            this.dataGridView_danhSachSanPham.ReadOnly = true;
            this.dataGridView_danhSachSanPham.RowHeadersWidth = 51;
            this.dataGridView_danhSachSanPham.Size = new System.Drawing.Size(1139, 441);
            this.dataGridView_danhSachSanPham.TabIndex = 53;
            this.dataGridView_danhSachSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_danhSachSanPham_CellClick);
            // 
            // Column_stt
            // 
            this.Column_stt.FillWeight = 167.5127F;
            this.Column_stt.HeaderText = "Stt";
            this.Column_stt.MinimumWidth = 6;
            this.Column_stt.Name = "Column_stt";
            this.Column_stt.ReadOnly = true;
            this.Column_stt.Width = 50;
            // 
            // Column_maSanPham
            // 
            this.Column_maSanPham.FillWeight = 93.24873F;
            this.Column_maSanPham.HeaderText = "Mã SP";
            this.Column_maSanPham.MinimumWidth = 6;
            this.Column_maSanPham.Name = "Column_maSanPham";
            this.Column_maSanPham.ReadOnly = true;
            this.Column_maSanPham.Width = 110;
            // 
            // Column_ten
            // 
            this.Column_ten.FillWeight = 93.24873F;
            this.Column_ten.HeaderText = "Tên";
            this.Column_ten.MinimumWidth = 6;
            this.Column_ten.Name = "Column_ten";
            this.Column_ten.ReadOnly = true;
            this.Column_ten.Width = 110;
            // 
            // Column_soLuong
            // 
            this.Column_soLuong.FillWeight = 93.24873F;
            this.Column_soLuong.HeaderText = "Số lượng";
            this.Column_soLuong.MinimumWidth = 6;
            this.Column_soLuong.Name = "Column_soLuong";
            this.Column_soLuong.ReadOnly = true;
            this.Column_soLuong.Width = 110;
            // 
            // Column_dvt
            // 
            this.Column_dvt.FillWeight = 93.24873F;
            this.Column_dvt.HeaderText = "Đ.V.Tính";
            this.Column_dvt.MinimumWidth = 6;
            this.Column_dvt.Name = "Column_dvt";
            this.Column_dvt.ReadOnly = true;
            this.Column_dvt.Width = 110;
            // 
            // Column_giaNhap
            // 
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.Column_giaNhap.DefaultCellStyle = dataGridViewCellStyle1;
            this.Column_giaNhap.FillWeight = 93.24873F;
            this.Column_giaNhap.HeaderText = "Giá Nhập";
            this.Column_giaNhap.MinimumWidth = 6;
            this.Column_giaNhap.Name = "Column_giaNhap";
            this.Column_giaNhap.ReadOnly = true;
            this.Column_giaNhap.Width = 111;
            // 
            // Column_giaBanLe
            // 
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.Column_giaBanLe.DefaultCellStyle = dataGridViewCellStyle2;
            this.Column_giaBanLe.FillWeight = 93.24873F;
            this.Column_giaBanLe.HeaderText = "Giá Bán Lẻ";
            this.Column_giaBanLe.MinimumWidth = 6;
            this.Column_giaBanLe.Name = "Column_giaBanLe";
            this.Column_giaBanLe.ReadOnly = true;
            this.Column_giaBanLe.Width = 110;
            // 
            // Column_hsd
            // 
            this.Column_hsd.FillWeight = 93.24873F;
            this.Column_hsd.HeaderText = "HSD";
            this.Column_hsd.MinimumWidth = 6;
            this.Column_hsd.Name = "Column_hsd";
            this.Column_hsd.ReadOnly = true;
            this.Column_hsd.Width = 110;
            // 
            // Column_nhaCungCap
            // 
            this.Column_nhaCungCap.FillWeight = 93.24873F;
            this.Column_nhaCungCap.HeaderText = "Nhà cung cấp";
            this.Column_nhaCungCap.MinimumWidth = 6;
            this.Column_nhaCungCap.Name = "Column_nhaCungCap";
            this.Column_nhaCungCap.ReadOnly = true;
            this.Column_nhaCungCap.Width = 110;
            // 
            // Column_ghiChu
            // 
            this.Column_ghiChu.FillWeight = 93.24873F;
            this.Column_ghiChu.HeaderText = "Ghi chú";
            this.Column_ghiChu.MinimumWidth = 6;
            this.Column_ghiChu.Name = "Column_ghiChu";
            this.Column_ghiChu.ReadOnly = true;
            this.Column_ghiChu.Width = 110;
            // 
            // button_chinhSua
            // 
            this.button_chinhSua.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_chinhSua.FlatAppearance.BorderSize = 0;
            this.button_chinhSua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_chinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_chinhSua.Location = new System.Drawing.Point(1193, 313);
            this.button_chinhSua.Margin = new System.Windows.Forms.Padding(4);
            this.button_chinhSua.Name = "button_chinhSua";
            this.button_chinhSua.Size = new System.Drawing.Size(207, 49);
            this.button_chinhSua.TabIndex = 46;
            this.button_chinhSua.TabStop = false;
            this.button_chinhSua.Text = "Sửa";
            this.button_chinhSua.UseVisualStyleBackColor = false;
            this.button_chinhSua.Click += new System.EventHandler(this.button_chinhSua_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_xoa.FlatAppearance.BorderSize = 0;
            this.button_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Location = new System.Drawing.Point(1193, 385);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(207, 49);
            this.button_xoa.TabIndex = 45;
            this.button_xoa.TabStop = false;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_xuatFile
            // 
            this.button_xuatFile.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_xuatFile.FlatAppearance.BorderSize = 0;
            this.button_xuatFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_xuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xuatFile.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_xuatFile.Location = new System.Drawing.Point(1193, 532);
            this.button_xuatFile.Margin = new System.Windows.Forms.Padding(4);
            this.button_xuatFile.Name = "button_xuatFile";
            this.button_xuatFile.Size = new System.Drawing.Size(207, 49);
            this.button_xuatFile.TabIndex = 44;
            this.button_xuatFile.TabStop = false;
            this.button_xuatFile.Text = "Xuất file";
            this.button_xuatFile.UseVisualStyleBackColor = false;
            this.button_xuatFile.Click += new System.EventHandler(this.button_xuatFile_Click);
            // 
            // button_luuKho
            // 
            this.button_luuKho.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_luuKho.FlatAppearance.BorderSize = 0;
            this.button_luuKho.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_luuKho.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_luuKho.Location = new System.Drawing.Point(1193, 631);
            this.button_luuKho.Margin = new System.Windows.Forms.Padding(4);
            this.button_luuKho.Name = "button_luuKho";
            this.button_luuKho.Size = new System.Drawing.Size(207, 49);
            this.button_luuKho.TabIndex = 55;
            this.button_luuKho.TabStop = false;
            this.button_luuKho.Text = "Nhập kho";
            this.button_luuKho.UseVisualStyleBackColor = false;
            this.button_luuKho.Click += new System.EventHandler(this.button_luuKho_Click);
            // 
            // textBox_masp
            // 
            this.textBox_masp.Location = new System.Drawing.Point(128, 135);
            this.textBox_masp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_masp.Name = "textBox_masp";
            this.textBox_masp.Size = new System.Drawing.Size(272, 22);
            this.textBox_masp.TabIndex = 1;
            // 
            // textBox_tensp
            // 
            this.textBox_tensp.Location = new System.Drawing.Point(128, 81);
            this.textBox_tensp.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_tensp.Name = "textBox_tensp";
            this.textBox_tensp.Size = new System.Drawing.Size(603, 22);
            this.textBox_tensp.TabIndex = 0;
            // 
            // textBox_giaBan
            // 
            this.textBox_giaBan.Location = new System.Drawing.Point(867, 180);
            this.textBox_giaBan.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_giaBan.Name = "textBox_giaBan";
            this.textBox_giaBan.Size = new System.Drawing.Size(216, 22);
            this.textBox_giaBan.TabIndex = 7;
            this.textBox_giaBan.TextChanged += new System.EventHandler(this.textBox_giaBan_TextChanged);
            this.textBox_giaBan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_giaBan_KeyPress);
            // 
            // textBox_giaNhap
            // 
            this.textBox_giaNhap.Location = new System.Drawing.Point(867, 135);
            this.textBox_giaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_giaNhap.Name = "textBox_giaNhap";
            this.textBox_giaNhap.Size = new System.Drawing.Size(216, 22);
            this.textBox_giaNhap.TabIndex = 6;
            this.textBox_giaNhap.TextChanged += new System.EventHandler(this.textBox_giaNhap_TextChanged);
            this.textBox_giaNhap.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_giaNhap_KeyPress);
            // 
            // textBox_sluong
            // 
            this.textBox_sluong.Location = new System.Drawing.Point(515, 135);
            this.textBox_sluong.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_sluong.Name = "textBox_sluong";
            this.textBox_sluong.Size = new System.Drawing.Size(216, 22);
            this.textBox_sluong.TabIndex = 2;
            this.textBox_sluong.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox_sluong_KeyPress);
            // 
            // textBox_nhacc
            // 
            this.textBox_nhacc.Location = new System.Drawing.Point(867, 78);
            this.textBox_nhacc.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_nhacc.Name = "textBox_nhacc";
            this.textBox_nhacc.Size = new System.Drawing.Size(551, 22);
            this.textBox_nhacc.TabIndex = 5;
            // 
            // textBox_ghiChu
            // 
            this.textBox_ghiChu.Location = new System.Drawing.Point(1140, 135);
            this.textBox_ghiChu.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_ghiChu.Multiline = true;
            this.textBox_ghiChu.Name = "textBox_ghiChu";
            this.textBox_ghiChu.Size = new System.Drawing.Size(277, 73);
            this.textBox_ghiChu.TabIndex = 8;
            // 
            // textBox_dvt
            // 
            this.textBox_dvt.Location = new System.Drawing.Point(515, 185);
            this.textBox_dvt.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_dvt.Name = "textBox_dvt";
            this.textBox_dvt.Size = new System.Drawing.Size(216, 22);
            this.textBox_dvt.TabIndex = 4;
            // 
            // label_ghiChu
            // 
            this.label_ghiChu.AutoSize = true;
            this.label_ghiChu.BackColor = System.Drawing.Color.Transparent;
            this.label_ghiChu.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ghiChu.Location = new System.Drawing.Point(1136, 116);
            this.label_ghiChu.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_ghiChu.Name = "label_ghiChu";
            this.label_ghiChu.Size = new System.Drawing.Size(62, 18);
            this.label_ghiChu.TabIndex = 71;
            this.label_ghiChu.Text = "Ghi Chú";
            // 
            // label_giaNhap
            // 
            this.label_giaNhap.AutoSize = true;
            this.label_giaNhap.BackColor = System.Drawing.Color.Transparent;
            this.label_giaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_giaNhap.Location = new System.Drawing.Point(771, 140);
            this.label_giaNhap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_giaNhap.Name = "label_giaNhap";
            this.label_giaNhap.Size = new System.Drawing.Size(70, 18);
            this.label_giaNhap.TabIndex = 70;
            this.label_giaNhap.Text = "Giá Nhập";
            // 
            // label_nhaCungCap
            // 
            this.label_nhaCungCap.AutoSize = true;
            this.label_nhaCungCap.BackColor = System.Drawing.Color.Transparent;
            this.label_nhaCungCap.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nhaCungCap.Location = new System.Drawing.Point(749, 81);
            this.label_nhaCungCap.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_nhaCungCap.Name = "label_nhaCungCap";
            this.label_nhaCungCap.Size = new System.Drawing.Size(105, 18);
            this.label_nhaCungCap.TabIndex = 69;
            this.label_nhaCungCap.Text = "Nhà Cung Cấp";
            // 
            // label_dvt
            // 
            this.label_dvt.AutoSize = true;
            this.label_dvt.BackColor = System.Drawing.Color.Transparent;
            this.label_dvt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_dvt.Location = new System.Drawing.Point(427, 192);
            this.label_dvt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_dvt.Name = "label_dvt";
            this.label_dvt.Size = new System.Drawing.Size(77, 18);
            this.label_dvt.TabIndex = 68;
            this.label_dvt.Text = "Đơn vị tính";
            // 
            // label_soLuog
            // 
            this.label_soLuog.AutoSize = true;
            this.label_soLuog.BackColor = System.Drawing.Color.Transparent;
            this.label_soLuog.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soLuog.Location = new System.Drawing.Point(427, 140);
            this.label_soLuog.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_soLuog.Name = "label_soLuog";
            this.label_soLuog.Size = new System.Drawing.Size(67, 18);
            this.label_soLuog.TabIndex = 67;
            this.label_soLuog.Text = "Số lượng";
            // 
            // label_tensp
            // 
            this.label_tensp.AutoSize = true;
            this.label_tensp.BackColor = System.Drawing.Color.Transparent;
            this.label_tensp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tensp.Location = new System.Drawing.Point(19, 86);
            this.label_tensp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_tensp.Name = "label_tensp";
            this.label_tensp.Size = new System.Drawing.Size(57, 18);
            this.label_tensp.TabIndex = 66;
            this.label_tensp.Text = "Tên SP";
            // 
            // label_msp
            // 
            this.label_msp.AutoSize = true;
            this.label_msp.BackColor = System.Drawing.Color.Transparent;
            this.label_msp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_msp.Location = new System.Drawing.Point(17, 139);
            this.label_msp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_msp.Name = "label_msp";
            this.label_msp.Size = new System.Drawing.Size(98, 18);
            this.label_msp.TabIndex = 65;
            this.label_msp.Text = "Mã sản phẩm";
            // 
            // label_HSD
            // 
            this.label_HSD.AutoSize = true;
            this.label_HSD.BackColor = System.Drawing.Color.Transparent;
            this.label_HSD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_HSD.Location = new System.Drawing.Point(19, 192);
            this.label_HSD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_HSD.Name = "label_HSD";
            this.label_HSD.Size = new System.Drawing.Size(40, 18);
            this.label_HSD.TabIndex = 73;
            this.label_HSD.Text = "HSD";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(767, 186);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 18);
            this.label4.TabIndex = 72;
            this.label4.Text = "Giá bán lẻ";
            // 
            // dateTimePicker1_hsd
            // 
            this.dateTimePicker1_hsd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1_hsd.Location = new System.Drawing.Point(128, 187);
            this.dateTimePicker1_hsd.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1_hsd.Name = "dateTimePicker1_hsd";
            this.dateTimePicker1_hsd.Size = new System.Drawing.Size(272, 22);
            this.dateTimePicker1_hsd.TabIndex = 3;
            // 
            // button_menu
            // 
            this.button_menu.BackgroundImage = global::SalesManagement.Properties.Resources.home2;
            this.button_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_menu.FlatAppearance.BorderSize = 0;
            this.button_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_menu.Location = new System.Drawing.Point(3, 2);
            this.button_menu.Margin = new System.Windows.Forms.Padding(4);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(55, 49);
            this.button_menu.TabIndex = 43;
            this.button_menu.TabStop = false;
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::SalesManagement.Properties.Resources.output_onlinepngtools;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.FlatAppearance.BorderSize = 0;
            this.button_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_back.Location = new System.Drawing.Point(60, 2);
            this.button_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(56, 49);
            this.button_back.TabIndex = 42;
            this.button_back.TabStop = false;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 31);
            this.label1.TabIndex = 74;
            this.label1.Text = "Nhập Hàng";
            // 
            // button_taoMoi
            // 
            this.button_taoMoi.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button_taoMoi.FlatAppearance.BorderSize = 0;
            this.button_taoMoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_taoMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_taoMoi.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button_taoMoi.Location = new System.Drawing.Point(1193, 458);
            this.button_taoMoi.Margin = new System.Windows.Forms.Padding(4);
            this.button_taoMoi.Name = "button_taoMoi";
            this.button_taoMoi.Size = new System.Drawing.Size(207, 49);
            this.button_taoMoi.TabIndex = 75;
            this.button_taoMoi.TabStop = false;
            this.button_taoMoi.Text = "Tạo mới";
            this.button_taoMoi.UseVisualStyleBackColor = false;
            this.button_taoMoi.Click += new System.EventHandler(this.button_taoMoi_Click);
            // 
            // NhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1435, 695);
            this.Controls.Add(this.button_taoMoi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1_hsd);
            this.Controls.Add(this.label_HSD);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label_ghiChu);
            this.Controls.Add(this.label_giaNhap);
            this.Controls.Add(this.label_nhaCungCap);
            this.Controls.Add(this.label_dvt);
            this.Controls.Add(this.label_soLuog);
            this.Controls.Add(this.label_tensp);
            this.Controls.Add(this.label_msp);
            this.Controls.Add(this.textBox_dvt);
            this.Controls.Add(this.textBox_ghiChu);
            this.Controls.Add(this.textBox_nhacc);
            this.Controls.Add(this.textBox_sluong);
            this.Controls.Add(this.textBox_giaNhap);
            this.Controls.Add(this.textBox_giaBan);
            this.Controls.Add(this.textBox_tensp);
            this.Controls.Add(this.textBox_masp);
            this.Controls.Add(this.button_luuKho);
            this.Controls.Add(this.button_them);
            this.Controls.Add(this.dataGridView_danhSachSanPham);
            this.Controls.Add(this.button_chinhSua);
            this.Controls.Add(this.button_xoa);
            this.Controls.Add(this.button_xuatFile);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_back);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.Button button_chinhSua;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_xuatFile;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button button_luuKho;
        private System.Windows.Forms.TextBox textBox_masp;
        private System.Windows.Forms.TextBox textBox_tensp;
        private System.Windows.Forms.TextBox textBox_giaBan;
        private System.Windows.Forms.TextBox textBox_giaNhap;
        private System.Windows.Forms.TextBox textBox_sluong;
        private System.Windows.Forms.TextBox textBox_nhacc;
        private System.Windows.Forms.TextBox textBox_ghiChu;
        private System.Windows.Forms.TextBox textBox_dvt;
        private System.Windows.Forms.Label label_ghiChu;
        private System.Windows.Forms.Label label_giaNhap;
        private System.Windows.Forms.Label label_nhaCungCap;
        private System.Windows.Forms.Label label_dvt;
        private System.Windows.Forms.Label label_soLuog;
        private System.Windows.Forms.Label label_tensp;
        private System.Windows.Forms.Label label_msp;
        private System.Windows.Forms.Label label_HSD;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateTimePicker1_hsd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_stt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_maSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ten;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_soLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_dvt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_giaNhap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_giaBanLe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_hsd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_nhaCungCap;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_ghiChu;
        private System.Windows.Forms.Button button_taoMoi;
    }
}