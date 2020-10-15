namespace SalesManagement
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
            this.btnXoaNV = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnThemNV = new System.Windows.Forms.Button();
            this.btnXuatFile = new System.Windows.Forms.Button();
            this.btnChinhSua = new System.Windows.Forms.Button();
            this.btnKhachHang = new System.Windows.Forms.Button();
            this.btnNhanVien = new System.Windows.Forms.Button();
            this.txbDiaChi = new System.Windows.Forms.TextBox();
            this.txbSDT = new System.Windows.Forms.TextBox();
            this.txbGioiTinh = new System.Windows.Forms.TextBox();
            this.txbNgaySinh = new System.Windows.Forms.TextBox();
            this.txbHoTen = new System.Windows.Forms.TextBox();
            this.txbMaKH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txbDiem = new System.Windows.Forms.TextBox();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColHoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColGioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSDT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnXoaNV
            // 
            this.btnXoaNV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXoaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoaNV.Location = new System.Drawing.Point(1022, 274);
            this.btnXoaNV.Name = "btnXoaNV";
            this.btnXoaNV.Size = new System.Drawing.Size(222, 49);
            this.btnXoaNV.TabIndex = 24;
            this.btnXoaNV.Text = "Xóa nhân viên";
            this.btnXoaNV.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
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
            this.dataGridView1.Location = new System.Drawing.Point(58, 431);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1226, 248);
            this.dataGridView1.TabIndex = 25;
            // 
            // btnThemNV
            // 
            this.btnThemNV.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnThemNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemNV.Location = new System.Drawing.Point(1022, 214);
            this.btnThemNV.Name = "btnThemNV";
            this.btnThemNV.Size = new System.Drawing.Size(222, 49);
            this.btnThemNV.TabIndex = 23;
            this.btnThemNV.Text = "Thêm nhân viên";
            this.btnThemNV.UseVisualStyleBackColor = false;
            // 
            // btnXuatFile
            // 
            this.btnXuatFile.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnXuatFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatFile.Location = new System.Drawing.Point(1022, 154);
            this.btnXuatFile.Name = "btnXuatFile";
            this.btnXuatFile.Size = new System.Drawing.Size(222, 49);
            this.btnXuatFile.TabIndex = 22;
            this.btnXuatFile.Text = "Xuất File";
            this.btnXuatFile.UseVisualStyleBackColor = false;
            // 
            // btnChinhSua
            // 
            this.btnChinhSua.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnChinhSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChinhSua.Location = new System.Drawing.Point(1022, 94);
            this.btnChinhSua.Name = "btnChinhSua";
            this.btnChinhSua.Size = new System.Drawing.Size(222, 49);
            this.btnChinhSua.TabIndex = 21;
            this.btnChinhSua.Text = "Chỉnh sửa";
            this.btnChinhSua.UseVisualStyleBackColor = false;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.BackColor = System.Drawing.SystemColors.Control;
            this.btnKhachHang.FlatAppearance.BorderSize = 0;
            this.btnKhachHang.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKhachHang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btnKhachHang.Location = new System.Drawing.Point(1128, 43);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(142, 39);
            this.btnKhachHang.TabIndex = 20;
            this.btnKhachHang.Text = "Khách hàng";
            this.btnKhachHang.UseVisualStyleBackColor = false;
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.BackColor = System.Drawing.SystemColors.Control;
            this.btnNhanVien.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnNhanVien.FlatAppearance.BorderSize = 0;
            this.btnNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanVien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnNhanVien.Location = new System.Drawing.Point(989, 43);
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.Size = new System.Drawing.Size(142, 39);
            this.btnNhanVien.TabIndex = 19;
            this.btnNhanVien.Text = "Nhân viên";
            this.btnNhanVien.UseVisualStyleBackColor = false;
            // 
            // txbDiaChi
            // 
            this.txbDiaChi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiaChi.Location = new System.Drawing.Point(528, 308);
            this.txbDiaChi.Name = "txbDiaChi";
            this.txbDiaChi.Size = new System.Drawing.Size(344, 27);
            this.txbDiaChi.TabIndex = 17;
            // 
            // txbSDT
            // 
            this.txbSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbSDT.Location = new System.Drawing.Point(528, 256);
            this.txbSDT.Name = "txbSDT";
            this.txbSDT.Size = new System.Drawing.Size(344, 27);
            this.txbSDT.TabIndex = 18;
            // 
            // txbGioiTinh
            // 
            this.txbGioiTinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbGioiTinh.Location = new System.Drawing.Point(528, 202);
            this.txbGioiTinh.Name = "txbGioiTinh";
            this.txbGioiTinh.Size = new System.Drawing.Size(344, 27);
            this.txbGioiTinh.TabIndex = 16;
            // 
            // txbNgaySinh
            // 
            this.txbNgaySinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNgaySinh.Location = new System.Drawing.Point(528, 149);
            this.txbNgaySinh.Name = "txbNgaySinh";
            this.txbNgaySinh.Size = new System.Drawing.Size(344, 27);
            this.txbNgaySinh.TabIndex = 15;
            // 
            // txbHoTen
            // 
            this.txbHoTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbHoTen.Location = new System.Drawing.Point(528, 97);
            this.txbHoTen.Name = "txbHoTen";
            this.txbHoTen.Size = new System.Drawing.Size(344, 27);
            this.txbHoTen.TabIndex = 14;
            // 
            // txbMaKH
            // 
            this.txbMaKH.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbMaKH.Location = new System.Drawing.Point(528, 48);
            this.txbMaKH.Name = "txbMaKH";
            this.txbMaKH.Size = new System.Drawing.Size(344, 27);
            this.txbMaKH.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(413, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "Địa chỉ:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(413, 259);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "SDT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(413, 205);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Giới tính:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(413, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Ngày sinh:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(413, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Họ tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(413, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Mã KH:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(85, 71);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(261, 297);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(413, 363);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 11;
            this.label7.Text = "Điểm:";
            // 
            // txbDiem
            // 
            this.txbDiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDiem.Location = new System.Drawing.Point(528, 360);
            this.txbDiem.Name = "txbDiem";
            this.txbDiem.Size = new System.Drawing.Size(344, 27);
            this.txbDiem.TabIndex = 17;
            // 
            // ColSTT
            // 
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.Width = 40;
            // 
            // ColMaKH
            // 
            this.ColMaKH.HeaderText = "Mã KH";
            this.ColMaKH.MinimumWidth = 6;
            this.ColMaKH.Name = "ColMaKH";
            // 
            // ColHoTen
            // 
            this.ColHoTen.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColHoTen.HeaderText = "Họ tên";
            this.ColHoTen.MinimumWidth = 6;
            this.ColHoTen.Name = "ColHoTen";
            // 
            // ColNgaySinh
            // 
            this.ColNgaySinh.HeaderText = "Ngày sinh";
            this.ColNgaySinh.MinimumWidth = 6;
            this.ColNgaySinh.Name = "ColNgaySinh";
            this.ColNgaySinh.Width = 110;
            // 
            // ColGioiTinh
            // 
            this.ColGioiTinh.HeaderText = "Giới tính";
            this.ColGioiTinh.MinimumWidth = 6;
            this.ColGioiTinh.Name = "ColGioiTinh";
            this.ColGioiTinh.Width = 80;
            // 
            // ColSDT
            // 
            this.ColSDT.HeaderText = "SĐT";
            this.ColSDT.MinimumWidth = 6;
            this.ColSDT.Name = "ColSDT";
            this.ColSDT.Width = 110;
            // 
            // ColDiaChi
            // 
            this.ColDiaChi.HeaderText = "Địa chỉ";
            this.ColDiaChi.MinimumWidth = 6;
            this.ColDiaChi.Name = "ColDiaChi";
            this.ColDiaChi.Width = 180;
            // 
            // ColDiem
            // 
            this.ColDiem.HeaderText = "Điểm";
            this.ColDiem.MinimumWidth = 6;
            this.ColDiem.Name = "ColDiem";
            this.ColDiem.Width = 75;
            // 
            // FormKhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1342, 721);
            this.Controls.Add(this.btnXoaNV);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnThemNV);
            this.Controls.Add(this.btnXuatFile);
            this.Controls.Add(this.btnChinhSua);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnNhanVien);
            this.Controls.Add(this.txbDiem);
            this.Controls.Add(this.txbDiaChi);
            this.Controls.Add(this.txbSDT);
            this.Controls.Add(this.txbGioiTinh);
            this.Controls.Add(this.txbNgaySinh);
            this.Controls.Add(this.txbHoTen);
            this.Controls.Add(this.txbMaKH);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormKhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormKhachHang";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnXoaNV;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThemNV;
        private System.Windows.Forms.Button btnXuatFile;
        private System.Windows.Forms.Button btnChinhSua;
        private System.Windows.Forms.Button btnKhachHang;
        private System.Windows.Forms.Button btnNhanVien;
        private System.Windows.Forms.TextBox txbDiaChi;
        private System.Windows.Forms.TextBox txbSDT;
        private System.Windows.Forms.TextBox txbGioiTinh;
        private System.Windows.Forms.TextBox txbNgaySinh;
        private System.Windows.Forms.TextBox txbHoTen;
        private System.Windows.Forms.TextBox txbMaKH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbDiem;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColHoTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNgaySinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColGioiTinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiaChi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDiem;
    }
}