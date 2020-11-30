namespace SalesManagement
{
    partial class ThongKe
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBox_tKTheoThang = new System.Windows.Forms.CheckBox();
            this.checkBox_tKTheoNam = new System.Windows.Forms.CheckBox();
            this.button_thongKe = new System.Windows.Forms.Button();
            this.button_menu = new System.Windows.Forms.Button();
            this.button_back = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(420, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Thống kê tài chính";
            // 
            // checkBox_tKTheoThang
            // 
            this.checkBox_tKTheoThang.AutoSize = true;
            this.checkBox_tKTheoThang.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_tKTheoThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tKTheoThang.Location = new System.Drawing.Point(143, 493);
            this.checkBox_tKTheoThang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_tKTheoThang.Name = "checkBox_tKTheoThang";
            this.checkBox_tKTheoThang.Size = new System.Drawing.Size(165, 22);
            this.checkBox_tKTheoThang.TabIndex = 2;
            this.checkBox_tKTheoThang.Text = "Thống kê theo tháng";
            this.checkBox_tKTheoThang.UseVisualStyleBackColor = false;
            // 
            // checkBox_tKTheoNam
            // 
            this.checkBox_tKTheoNam.AutoSize = true;
            this.checkBox_tKTheoNam.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_tKTheoNam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_tKTheoNam.Location = new System.Drawing.Point(359, 493);
            this.checkBox_tKTheoNam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.checkBox_tKTheoNam.Name = "checkBox_tKTheoNam";
            this.checkBox_tKTheoNam.Size = new System.Drawing.Size(158, 22);
            this.checkBox_tKTheoNam.TabIndex = 3;
            this.checkBox_tKTheoNam.Text = "Thống kê theo năm";
            this.checkBox_tKTheoNam.UseVisualStyleBackColor = false;
            // 
            // button_thongKe
            // 
            this.button_thongKe.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.button_thongKe.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_thongKe.Location = new System.Drawing.Point(607, 493);
            this.button_thongKe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_thongKe.Name = "button_thongKe";
            this.button_thongKe.Size = new System.Drawing.Size(184, 66);
            this.button_thongKe.TabIndex = 4;
            this.button_thongKe.Text = "Thống kê";
            this.button_thongKe.UseVisualStyleBackColor = false;
            // 
            // button_menu
            // 
            this.button_menu.BackgroundImage = global::SalesManagement.Properties.Resources.home;
            this.button_menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_menu.Location = new System.Drawing.Point(0, -1);
            this.button_menu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_menu.Name = "button_menu";
            this.button_menu.Size = new System.Drawing.Size(61, 52);
            this.button_menu.TabIndex = 47;
            this.button_menu.UseVisualStyleBackColor = true;
            this.button_menu.Click += new System.EventHandler(this.button_menu_Click);
            // 
            // button_back
            // 
            this.button_back.BackgroundImage = global::SalesManagement.Properties.Resources.back1;
            this.button_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_back.Location = new System.Drawing.Point(59, -1);
            this.button_back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_back.Name = "button_back";
            this.button_back.Size = new System.Drawing.Size(63, 52);
            this.button_back.TabIndex = 46;
            this.button_back.UseVisualStyleBackColor = true;
            this.button_back.Click += new System.EventHandler(this.button_back_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(127, 61);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(809, 407);
            this.chart1.TabIndex = 48;
            this.chart1.Text = "chart1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(143, 537);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(245, 22);
            this.dateTimePicker1.TabIndex = 50;
            // 
            // ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SalesManagement.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(1067, 596);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.button_menu);
            this.Controls.Add(this.button_back);
            this.Controls.Add(this.button_thongKe);
            this.Controls.Add(this.checkBox_tKTheoNam);
            this.Controls.Add(this.checkBox_tKTheoThang);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox_tKTheoThang;
        private System.Windows.Forms.CheckBox checkBox_tKTheoNam;
        private System.Windows.Forms.Button button_thongKe;
        private System.Windows.Forms.Button button_menu;
        private System.Windows.Forms.Button button_back;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}