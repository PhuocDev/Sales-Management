﻿namespace SalesManagement
{
    partial class FormLichSuHoaDon
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvCTHD = new System.Windows.Forms.DataGridView();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.dgvLichSuHD = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColMaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDVT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColDonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.btnThongKe = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuHD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCTHD
            // 
            this.dgvCTHD.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColSTT,
            this.ColMaSP,
            this.ColTenSP,
            this.ColSoLuong,
            this.ColDVT,
            this.ColDonGia,
            this.ColThanhTien});
            this.dgvCTHD.Location = new System.Drawing.Point(46, 388);
            this.dgvCTHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvCTHD.Name = "dgvCTHD";
            this.dgvCTHD.ReadOnly = true;
            this.dgvCTHD.RowHeadersVisible = false;
            this.dgvCTHD.RowHeadersWidth = 51;
            this.dgvCTHD.RowTemplate.Height = 24;
            this.dgvCTHD.Size = new System.Drawing.Size(1246, 293);
            this.dgvCTHD.TabIndex = 32;
            this.dgvCTHD.TabStop = false;
            // 
            // button_menu
            // 
            this.button_menu.BackgroundImage = global::SalesManagement.Properties.Resources.home;
            this.button_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_menu.Location = new System.Drawing.Point(-1, -1);
            this.button_menu.Margin = new System.Windows.Forms.Padding(4);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(61, 52);
            this.button_menu.TabIndex = 51;
            this.button_menu.TabStop = false;
            this.button_menu.UseVisualStyleBackColor = true;
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::SalesManagement.Properties.Resources.back1;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.Location = new System.Drawing.Point(59, -1);
            this.button_back.Margin = new System.Windows.Forms.Padding(4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(63, 52);
            this.button_back.TabIndex = 52;
            this.button_back.TabStop = false;
            this.button_back.UseVisualStyleBackColor = true;
            // 
            // dgvLichSuHD
            // 
            this.dgvLichSuHD.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvLichSuHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLichSuHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dgvLichSuHD.Location = new System.Drawing.Point(46, 123);
            this.dgvLichSuHD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvLichSuHD.Name = "dgvLichSuHD";
            this.dgvLichSuHD.ReadOnly = true;
            this.dgvLichSuHD.RowHeadersVisible = false;
            this.dgvLichSuHD.RowHeadersWidth = 51;
            this.dgvLichSuHD.RowTemplate.Height = 24;
            this.dgvLichSuHD.Size = new System.Drawing.Size(1246, 222);
            this.dgvLichSuHD.TabIndex = 53;
            this.dgvLichSuHD.TabStop = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Mã hóa đơn";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn7
            // 
            dataGridViewCellStyle3.Format = "C0";
            dataGridViewCellStyle3.NullValue = null;
            this.dataGridViewTextBoxColumn7.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewTextBoxColumn7.FillWeight = 90F;
            this.dataGridViewTextBoxColumn7.HeaderText = "Tổng tiền";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "Thời gian";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.FillWeight = 75F;
            this.dataGridViewTextBoxColumn4.HeaderText = "Mã khách hàng";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.FillWeight = 75F;
            this.dataGridViewTextBoxColumn5.HeaderText = "Mã nhân viên";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // ColSTT
            // 
            this.ColSTT.HeaderText = "STT";
            this.ColSTT.MinimumWidth = 6;
            this.ColSTT.Name = "ColSTT";
            this.ColSTT.ReadOnly = true;
            this.ColSTT.Width = 40;
            // 
            // ColMaSP
            // 
            this.ColMaSP.HeaderText = "Mã sản phẩm";
            this.ColMaSP.MinimumWidth = 6;
            this.ColMaSP.Name = "ColMaSP";
            this.ColMaSP.ReadOnly = true;
            this.ColMaSP.Width = 150;
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
            this.ColSoLuong.Width = 90;
            // 
            // ColDVT
            // 
            this.ColDVT.FillWeight = 75F;
            this.ColDVT.HeaderText = "Đ.V.Tính";
            this.ColDVT.MinimumWidth = 6;
            this.ColDVT.Name = "ColDVT";
            this.ColDVT.ReadOnly = true;
            this.ColDVT.Width = 90;
            // 
            // ColDonGia
            // 
            dataGridViewCellStyle1.Format = "C0";
            dataGridViewCellStyle1.NullValue = null;
            this.ColDonGia.DefaultCellStyle = dataGridViewCellStyle1;
            this.ColDonGia.FillWeight = 75F;
            this.ColDonGia.HeaderText = "Đơn giá";
            this.ColDonGia.MinimumWidth = 6;
            this.ColDonGia.Name = "ColDonGia";
            this.ColDonGia.ReadOnly = true;
            this.ColDonGia.Width = 90;
            // 
            // ColThanhTien
            // 
            dataGridViewCellStyle2.Format = "C0";
            dataGridViewCellStyle2.NullValue = null;
            this.ColThanhTien.DefaultCellStyle = dataGridViewCellStyle2;
            this.ColThanhTien.FillWeight = 90F;
            this.ColThanhTien.HeaderText = "Thành tiền";
            this.ColThanhTien.MinimumWidth = 6;
            this.ColThanhTien.Name = "ColThanhTien";
            this.ColThanhTien.ReadOnly = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(156, 56);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(277, 27);
            this.dateTimePicker1.TabIndex = 54;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker2.Location = new System.Drawing.Point(907, 57);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(277, 27);
            this.dateTimePicker2.TabIndex = 57;
            // 
            // btnThongKe
            // 
            this.btnThongKe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnThongKe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongKe.Location = new System.Drawing.Point(593, 44);
            this.btnThongKe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThongKe.Name = "btnThongKe";
            this.btnThongKe.Size = new System.Drawing.Size(155, 55);
            this.btnThongKe.TabIndex = 58;
            this.btnThongKe.Text = "Thống kê";
            this.btnThongKe.UseVisualStyleBackColor = false;
            // 
            // FormLichSuHoaDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesManagement.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(1341, 721);
            this.Controls.Add(this.btnThongKe);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.dgvLichSuHD);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.dgvCTHD);
            this.Name = "FormLichSuHoaDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLichSuHoaDon";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTHD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLichSuHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCTHD;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataGridView dgvLichSuHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColMaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDVT;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColThanhTien;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Button btnThongKe;
    }
}