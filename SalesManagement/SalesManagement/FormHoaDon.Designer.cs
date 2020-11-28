namespace SalesManagement
{
    partial class FormHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvHoaDon = new System.Windows.Forms.DataGridView();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCheckbox = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.txbTraLaiKhach = new System.Windows.Forms.TextBox();
            this.txbTienKhachDua = new System.Windows.Forms.TextBox();
            this.txbTongThanhToan = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnThanhToan = new System.Windows.Forms.Button();
            this.btnTaoKHMoi = new System.Windows.Forms.Button();
            this.txbNhanVien = new System.Windows.Forms.TextBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nudSoLuong = new System.Windows.Forms.NumericUpDown();
            this.cbbTenSP = new System.Windows.Forms.ComboBox();
            this.txbThoiGian = new System.Windows.Forms.TextBox();
            this.txbMaHD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.btnTaoHD = new System.Windows.Forms.Button();
            this.cbbMaKH = new System.Windows.Forms.ComboBox();
            this.btnLichSuHoaDon = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.cbbMaSP = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHoaDon
            // 
            this.dgvHoaDon.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvHoaDon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHoaDon.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaSP,
            this.ColTenSP,
            this.ColSoLuong,
            this.ColDVT,
            this.ColDonGia,
            this.ColThanhTien,
            this.ColCheckbox});
            this.dgvHoaDon.Location = new System.Drawing.Point(56, 340);
            this.dgvHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvHoaDon.Name = "dgvHoaDon";
            this.dgvHoaDon.ReadOnly = true;
            this.dgvHoaDon.RowHeadersVisible = false;
            this.dgvHoaDon.RowHeadersWidth = 51;
            this.dgvHoaDon.RowTemplate.Height = 24;
            this.dgvHoaDon.Size = new System.Drawing.Size(869, 334);
            this.dgvHoaDon.TabIndex = 31;
            this.dgvHoaDon.TabStop = false;
            this.dgvHoaDon.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvHoaDon_CellClick);
            // 
            // ColSTT
            // 
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.ReadOnly = true;
            this.ColSTT.Width = 35;
            // 
            // ColMaSP
            // 
            this.ColMaSP.HeaderText = "Mã sản phẩm";
            this.ColMaSP.MinimumWidth = 6;
            this.ColMaSP.Name = "ColMaSP";
            this.ColMaSP.ReadOnly = true;
            this.ColMaSP.Width = 125;
            // 
            // ColTenSP
            // 
            this.ColTenSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColTenSP.FillWeight = 200F;
            this.ColTenSP.HeaderText = "Tên sản phẩm";
            this.ColTenSP.MinimumWidth = 6;
            this.ColTenSP.Name = "ColTenSP";
            this.ColTenSP.ReadOnly = true;
            // 
            // ColSoLuong
            // 
            this.ColSoLuong.FillWeight = 75F;
            this.ColSoLuong.HeaderText = "Số lượng";
            this.ColSoLuong.MinimumWidth = 6;
            this.ColSoLuong.Name = "ColSoLuong";
            this.ColSoLuong.ReadOnly = true;
            this.ColSoLuong.Width = 75;
            // 
            // ColDVT
            // 
            this.ColDVT.FillWeight = 75F;
            this.ColDVT.HeaderText = "Đ.V.Tính";
            this.ColDVT.MinimumWidth = 6;
            this.ColDVT.Name = "ColDVT";
            this.ColDVT.ReadOnly = true;
            this.ColDVT.Width = 75;
            // 
            // ColDonGia
            // 
            dataGridViewCellStyle7.Format = "C0";
            dataGridViewCellStyle7.NullValue = null;
            this.ColDonGia.DefaultCellStyle = dataGridViewCellStyle7;
            this.ColDonGia.FillWeight = 75F;
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.MinimumWidth = 6;
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.ReadOnly = true;
            this.ColDonGia.Width = 75;
            // 
            // ColThanhTien
            // 
            dataGridViewCellStyle8.Format = "C0";
            dataGridViewCellStyle8.NullValue = null;
            this.ColThanhTien.DefaultCellStyle = dataGridViewCellStyle8;
            this.ColThanhTien.FillWeight = 90F;
            this.ColThanhTien.HeaderText = "Thành tiền";
            this.ColThanhTien.MinimumWidth = 6;
            this.ColThanhTien.Name = "ColThanhTien";
            this.ColThanhTien.ReadOnly = true;
            this.ColThanhTien.Width = 90;
            // 
            // ColCheckbox
            // 
            this.ColCheckbox.HeaderText = "";
            this.ColCheckbox.MinimumWidth = 6;
            this.ColCheckbox.Name = "ColCheckbox";
            this.ColCheckbox.ReadOnly = true;
            this.ColCheckbox.Width = 35;
            // 
            // txbTraLaiKhach
            // 
            this.txbTraLaiKhach.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTraLaiKhach.Location = new System.Drawing.Point(1107, 481);
            this.txbTraLaiKhach.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTraLaiKhach.Name = "txbTraLaiKhach";
            this.txbTraLaiKhach.ReadOnly = true;
            this.txbTraLaiKhach.Size = new System.Drawing.Size(181, 27);
            this.txbTraLaiKhach.TabIndex = 37;
            this.txbTraLaiKhach.TabStop = false;
            this.txbTraLaiKhach.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txbTienKhachDua
            // 
            this.txbTienKhachDua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTienKhachDua.Location = new System.Drawing.Point(1107, 422);
            this.txbTienKhachDua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTienKhachDua.Name = "txbTienKhachDua";
            this.txbTienKhachDua.Size = new System.Drawing.Size(181, 27);
            this.txbTienKhachDua.TabIndex = 7;
            this.txbTienKhachDua.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txbTienKhachDua.TextChanged += new System.EventHandler(this.txbTienKhachDua_TextChanged);
            this.txbTienKhachDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbTienKhachDua_KeyPress);
            this.txbTienKhachDua.Leave += new System.EventHandler(this.txbTienKhachDua_Leave);
            // 
            // txbTongThanhToan
            // 
            this.txbTongThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTongThanhToan.Location = new System.Drawing.Point(1107, 363);
            this.txbTongThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbTongThanhToan.Name = "txbTongThanhToan";
            this.txbTongThanhToan.ReadOnly = true;
            this.txbTongThanhToan.Size = new System.Drawing.Size(181, 27);
            this.txbTongThanhToan.TabIndex = 35;
            this.txbTongThanhToan.TabStop = false;
            this.txbTongThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(956, 484);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(110, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Trả lại khách:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(952, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(127, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Tiền khách đưa:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(952, 366);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(134, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Tổng thanh toán:";
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThanhToan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Location = new System.Drawing.Point(1022, 561);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(230, 66);
            this.btnThanhToan.TabIndex = 8;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.UseVisualStyleBackColor = false;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnTaoKHMoi
            // 
            this.btnTaoKHMoi.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTaoKHMoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoKHMoi.Location = new System.Drawing.Point(985, 263);
            this.btnTaoKHMoi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoKHMoi.Name = "btnTaoKHMoi";
            this.btnTaoKHMoi.Size = new System.Drawing.Size(267, 46);
            this.btnTaoKHMoi.TabIndex = 29;
            this.btnTaoKHMoi.TabStop = false;
            this.btnTaoKHMoi.Text = "Tạo khách hàng mới";
            this.btnTaoKHMoi.UseVisualStyleBackColor = false;
            // 
            // txbNhanVien
            // 
            this.txbNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNhanVien.Location = new System.Drawing.Point(1056, 97);
            this.txbNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbNhanVien.Name = "txbNhanVien";
            this.txbNhanVien.ReadOnly = true;
            this.txbNhanVien.Size = new System.Drawing.Size(232, 27);
            this.txbNhanVien.TabIndex = 27;
            this.txbNhanVien.TabStop = false;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(672, 242);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(132, 55);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(400, 242);
            this.btnChinhSua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(216, 55);
            this.btnChinhSua.TabIndex = 4;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            this.btnChinhSua.Click += new System.EventHandler(this.btnChinhSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Location = new System.Drawing.Point(128, 242);
            this.btnThem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(216, 55);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(940, 100);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Nhân viên:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(940, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 21;
            this.label5.Text = "Khách hàng:";
            // 
            // nudSoLuong
            // 
            this.nudSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudSoLuong.Location = new System.Drawing.Point(267, 176);
            this.nudSoLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nudSoLuong.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudSoLuong.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.Name = "nudSoLuong";
            this.nudSoLuong.Size = new System.Drawing.Size(108, 27);
            this.nudSoLuong.TabIndex = 1;
            this.nudSoLuong.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudSoLuong.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nudSoLuong_KeyDown);
            // 
            // cbbTenSP
            // 
            this.cbbTenSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbTenSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbTenSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbTenSP.FormattingEnabled = true;
            this.cbbTenSP.Location = new System.Drawing.Point(267, 113);
            this.cbbTenSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbTenSP.Name = "cbbTenSP";
            this.cbbTenSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbTenSP.Size = new System.Drawing.Size(565, 28);
            this.cbbTenSP.TabIndex = 0;
            this.cbbTenSP.TextChanged += new System.EventHandler(this.cbbTenSP_TextChanged);
            // 
            // txbThoiGian
            // 
            this.txbThoiGian.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbThoiGian.Location = new System.Drawing.Point(581, 48);
            this.txbThoiGian.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbThoiGian.Name = "txbThoiGian";
            this.txbThoiGian.ReadOnly = true;
            this.txbThoiGian.Size = new System.Drawing.Size(249, 27);
            this.txbThoiGian.TabIndex = 18;
            this.txbThoiGian.TabStop = false;
            // 
            // txbMaHD
            // 
            this.txbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaHD.Location = new System.Drawing.Point(267, 48);
            this.txbMaHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbMaHD.Name = "txbMaHD";
            this.txbMaHD.ReadOnly = true;
            this.txbMaHD.Size = new System.Drawing.Size(153, 27);
            this.txbMaHD.TabIndex = 0;
            this.txbMaHD.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(124, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 15;
            this.label3.Text = "Số lượng:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(124, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên sản phẩm:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(459, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Thời gian:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(124, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Mã hóa đơn:";
            // 
            // button_menu
            // 
            this.button_menu.BackgroundImage = global::SalesManagement.Properties.Resources.home;
            this.button_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_menu.Location = new System.Drawing.Point(-1, -1);
            this.button_menu.Margin = new System.Windows.Forms.Padding(4);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(61, 52);
            this.button_menu.TabIndex = 0;
            this.button_menu.TabStop = false;
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::SalesManagement.Properties.Resources.back1;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.Location = new System.Drawing.Point(59, -1);
            this.button_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(63, 52);
            this.button_back.TabIndex = 50;
            this.button_back.TabStop = false;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // btnTaoHD
            // 
            this.btnTaoHD.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnTaoHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaoHD.Location = new System.Drawing.Point(985, 154);
            this.btnTaoHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnTaoHD.Name = "btnTaoHD";
            this.btnTaoHD.Size = new System.Drawing.Size(267, 46);
            this.btnTaoHD.TabIndex = 29;
            this.btnTaoHD.TabStop = false;
            this.btnTaoHD.Text = "Tạo hóa đơn mới";
            this.btnTaoHD.UseVisualStyleBackColor = false;
            this.btnTaoHD.Click += new System.EventHandler(this.btnTaoHD_Click);
            // 
            // cbbMaKH
            // 
            this.cbbMaKH.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaKH.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaKH.FormattingEnabled = true;
            this.cbbMaKH.Location = new System.Drawing.Point(1056, 48);
            this.cbbMaKH.Name = "cbbMaKH";
            this.cbbMaKH.Size = new System.Drawing.Size(232, 28);
            this.cbbMaKH.TabIndex = 6;
            this.cbbMaKH.Leave += new System.EventHandler(this.cbbMaKH_Leave);
            // 
            // btnLichSuHoaDon
            // 
            this.btnLichSuHoaDon.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnLichSuHoaDon.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLichSuHoaDon.Location = new System.Drawing.Point(985, 208);
            this.btnLichSuHoaDon.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLichSuHoaDon.Name = "btnLichSuHoaDon";
            this.btnLichSuHoaDon.Size = new System.Drawing.Size(267, 46);
            this.btnLichSuHoaDon.TabIndex = 29;
            this.btnLichSuHoaDon.TabStop = false;
            this.btnLichSuHoaDon.Text = "Lịch sử hóa đơn";
            this.btnLichSuHoaDon.UseVisualStyleBackColor = false;
            this.btnLichSuHoaDon.Click += new System.EventHandler(this.btnLichSuHoaDon_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(426, 179);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 20);
            this.label10.TabIndex = 14;
            this.label10.Text = "Mã sản phẩm:";
            // 
            // cbbMaSP
            // 
            this.cbbMaSP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbbMaSP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbbMaSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbMaSP.FormattingEnabled = true;
            this.cbbMaSP.Location = new System.Drawing.Point(581, 176);
            this.cbbMaSP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbbMaSP.Name = "cbbMaSP";
            this.cbbMaSP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cbbMaSP.Size = new System.Drawing.Size(249, 28);
            this.cbbMaSP.TabIndex = 2;
            this.cbbMaSP.TextChanged += new System.EventHandler(this.cbbMaSP_TextChanged);
            // 
            // FormHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesManagement.Properties.Resources.background2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1341, 721);
            this.Controls.Add(this.cbbMaKH);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dgvHoaDon);
            this.Controls.Add(this.txbTraLaiKhach);
            this.Controls.Add(this.txbTienKhachDua);
            this.Controls.Add(this.txbTongThanhToan);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.btnLichSuHoaDon);
            this.Controls.Add(this.btnTaoHD);
            this.Controls.Add(this.btnTaoKHMoi);
            this.Controls.Add(this.txbNhanVien);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudSoLuong);
            this.Controls.Add(this.cbbMaSP);
            this.Controls.Add(this.cbbTenSP);
            this.Controls.Add(this.txbThoiGian);
            this.Controls.Add(this.txbMaHD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hóa đơn";
            ((System.ComponentModel.ISupportInitialize)(this.dgvHoaDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSoLuong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvHoaDon;
        private System.Windows.Forms.TextBox txbTraLaiKhach;
        private System.Windows.Forms.TextBox txbTienKhachDua;
        private System.Windows.Forms.TextBox txbTongThanhToan;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnThanhToan;
        private System.Windows.Forms.Button btnTaoKHMoi;
        private System.Windows.Forms.TextBox txbNhanVien;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudSoLuong;
        private System.Windows.Forms.ComboBox cbbTenSP;
        private System.Windows.Forms.TextBox txbThoiGian;
        private System.Windows.Forms.TextBox txbMaHD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.Button btnTaoHD;
        private System.Windows.Forms.ComboBox cbbMaKH;
        private System.Windows.Forms.Button btnLichSuHoaDon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThanhTien;
        private System.Windows.Forms.DataGridViewCheckBoxColumn ColCheckbox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbbMaSP;
    }
}