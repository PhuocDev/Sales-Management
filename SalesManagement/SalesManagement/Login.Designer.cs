namespace SalesManagement
{
    partial class Login
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
            this.textBox_passWord = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.textBox1 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.button_dangNhap = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox_passWord
            // 
            this.textBox_passWord.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox_passWord.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox_passWord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox_passWord.HintForeColor = System.Drawing.Color.Empty;
            this.textBox_passWord.HintText = "";
            this.textBox_passWord.isPassword = true;
            this.textBox_passWord.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox_passWord.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox_passWord.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox_passWord.LineThickness = 3;
            this.textBox_passWord.Location = new System.Drawing.Point(50, 219);
            this.textBox_passWord.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_passWord.Name = "textBox_passWord";
            this.textBox_passWord.Size = new System.Drawing.Size(222, 30);
            this.textBox_passWord.TabIndex = 1;
            this.textBox_passWord.Text = "Password";
            this.textBox_passWord.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox_passWord.Enter += new System.EventHandler(this.textBox_passWord_Enter);
            this.textBox_passWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_passWord_KeyDown);
            // 
            // textBox1
            // 
            this.textBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textBox1.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.HintForeColor = System.Drawing.Color.Empty;
            this.textBox1.HintText = "";
            this.textBox1.isPassword = false;
            this.textBox1.LineFocusedColor = System.Drawing.Color.Blue;
            this.textBox1.LineIdleColor = System.Drawing.Color.Gray;
            this.textBox1.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.textBox1.LineThickness = 3;
            this.textBox1.Location = new System.Drawing.Point(50, 162);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(222, 30);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "Username";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyDown);
            this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // button_dangNhap
            // 
            this.button_dangNhap.BackColor = System.Drawing.Color.White;
            this.button_dangNhap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_dangNhap.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangNhap.ForeColor = System.Drawing.Color.Black;
            this.button_dangNhap.Location = new System.Drawing.Point(50, 308);
            this.button_dangNhap.Margin = new System.Windows.Forms.Padding(2);
            this.button_dangNhap.Name = "button_dangNhap";
            this.button_dangNhap.Size = new System.Drawing.Size(222, 33);
            this.button_dangNhap.TabIndex = 2;
            this.button_dangNhap.Text = "Login";
            this.button_dangNhap.UseVisualStyleBackColor = false;
            this.button_dangNhap.Click += new System.EventHandler(this.button_dangNhap_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(108, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Login";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(326, 384);
            this.Controls.Add(this.button_dangNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_passWord);
            this.Controls.Add(this.textBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Underline | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox_passWord;
        private Bunifu.Framework.UI.BunifuMaterialTextbox textBox1;
        private System.Windows.Forms.Button button_dangNhap;
        private System.Windows.Forms.Label label2;
    }
}