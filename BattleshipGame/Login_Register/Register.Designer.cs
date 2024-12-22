namespace Login_Register
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            gb = new GroupBox();
            btnDangKy = new Button();
            lklbDangNhap = new LinkLabel();
            txbXacNhan = new TextBox();
            txbEmail = new TextBox();
            txbUserName = new TextBox();
            txbMatKhau = new TextBox();
            lbEmail = new Label();
            lbXacNhan = new Label();
            lbMatKhau = new Label();
            lbUserName = new Label();
            lbtext = new Label();
            gb.SuspendLayout();
            SuspendLayout();
            // 
            // gb
            // 
            gb.BackColor = Color.Transparent;
            gb.Controls.Add(lbtext);
            gb.Controls.Add(btnDangKy);
            gb.Controls.Add(lklbDangNhap);
            gb.Controls.Add(txbXacNhan);
            gb.Controls.Add(txbEmail);
            gb.Controls.Add(txbUserName);
            gb.Controls.Add(txbMatKhau);
            gb.Controls.Add(lbEmail);
            gb.Controls.Add(lbXacNhan);
            gb.Controls.Add(lbMatKhau);
            gb.Controls.Add(lbUserName);
            gb.Location = new Point(3, 5);
            gb.Margin = new Padding(3, 4, 3, 4);
            gb.Name = "gb";
            gb.Padding = new Padding(3, 4, 3, 4);
            gb.Size = new Size(796, 547);
            gb.TabIndex = 13;
            gb.TabStop = false;
            // 
            // btnDangKy
            // 
            btnDangKy.BackColor = Color.Gray;
            btnDangKy.Font = new Font("Gill Sans Ultra Bold", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangKy.ForeColor = Color.FromArgb(255, 192, 128);
            btnDangKy.Location = new Point(224, 454);
            btnDangKy.Margin = new Padding(3, 4, 3, 4);
            btnDangKy.Name = "btnDangKy";
            btnDangKy.Size = new Size(271, 46);
            btnDangKy.TabIndex = 10;
            btnDangKy.Text = "Đăng ký";
            btnDangKy.UseVisualStyleBackColor = false;
            btnDangKy.Click += btnDangKy_Click_1;
            // 
            // lklbDangNhap
            // 
            lklbDangNhap.AutoSize = true;
            lklbDangNhap.BackColor = SystemColors.ActiveCaption;
            lklbDangNhap.Location = new Point(290, 504);
            lklbDangNhap.Name = "lklbDangNhap";
            lklbDangNhap.Size = new Size(147, 20);
            lklbDangNhap.TabIndex = 9;
            lklbDangNhap.TabStop = true;
            lklbDangNhap.Text = "Bạn đã có tài khoản?";
            lklbDangNhap.LinkClicked += lklbDangNhap_LinkClicked;
            // 
            // txbXacNhan
            // 
            txbXacNhan.BackColor = SystemColors.ActiveBorder;
            txbXacNhan.Location = new Point(352, 374);
            txbXacNhan.Margin = new Padding(3, 4, 3, 4);
            txbXacNhan.Multiline = true;
            txbXacNhan.Name = "txbXacNhan";
            txbXacNhan.PasswordChar = '●';
            txbXacNhan.Size = new Size(313, 30);
            txbXacNhan.TabIndex = 7;
            txbXacNhan.UseSystemPasswordChar = true;
            // 
            // txbEmail
            // 
            txbEmail.BackColor = SystemColors.ActiveBorder;
            txbEmail.Location = new Point(352, 416);
            txbEmail.Margin = new Padding(3, 4, 3, 4);
            txbEmail.Multiline = true;
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(313, 30);
            txbEmail.TabIndex = 6;
            // 
            // txbUserName
            // 
            txbUserName.BackColor = SystemColors.ActiveBorder;
            txbUserName.Location = new Point(352, 282);
            txbUserName.Margin = new Padding(3, 4, 3, 4);
            txbUserName.Multiline = true;
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(313, 30);
            txbUserName.TabIndex = 5;
            // 
            // txbMatKhau
            // 
            txbMatKhau.BackColor = SystemColors.ActiveBorder;
            txbMatKhau.Location = new Point(352, 328);
            txbMatKhau.Margin = new Padding(3, 4, 3, 4);
            txbMatKhau.Multiline = true;
            txbMatKhau.Name = "txbMatKhau";
            txbMatKhau.PasswordChar = '●';
            txbMatKhau.Size = new Size(313, 30);
            txbMatKhau.TabIndex = 4;
            txbMatKhau.UseSystemPasswordChar = true;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.Gray;
            lbEmail.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.ForeColor = Color.FromArgb(255, 192, 128);
            lbEmail.Location = new Point(110, 421);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(77, 25);
            lbEmail.TabIndex = 3;
            lbEmail.Text = "Email:";
            // 
            // lbXacNhan
            // 
            lbXacNhan.AutoSize = true;
            lbXacNhan.BackColor = Color.Gray;
            lbXacNhan.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbXacNhan.ForeColor = Color.FromArgb(255, 192, 128);
            lbXacNhan.Location = new Point(110, 379);
            lbXacNhan.Name = "lbXacNhan";
            lbXacNhan.Size = new Size(222, 25);
            lbXacNhan.TabIndex = 2;
            lbXacNhan.Text = "Xác nhận mật khẩu:";
            // 
            // lbMatKhau
            // 
            lbMatKhau.AutoSize = true;
            lbMatKhau.BackColor = Color.Gray;
            lbMatKhau.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbMatKhau.ForeColor = Color.FromArgb(255, 192, 128);
            lbMatKhau.Location = new Point(110, 333);
            lbMatKhau.Name = "lbMatKhau";
            lbMatKhau.Size = new Size(116, 25);
            lbMatKhau.TabIndex = 1;
            lbMatKhau.Text = "Mật khẩu:";
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Gray;
            lbUserName.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.ForeColor = Color.FromArgb(255, 192, 128);
            lbUserName.Location = new Point(110, 287);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(132, 25);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "User Name:";
            // 
            // lbtext
            // 
            lbtext.AutoSize = true;
            lbtext.BackColor = Color.Transparent;
            lbtext.Font = new Font("Gill Sans Ultra Bold", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtext.ForeColor = Color.FromArgb(192, 192, 0);
            lbtext.Location = new Point(281, 73);
            lbtext.Name = "lbtext";
            lbtext.Size = new Size(184, 46);
            lbtext.TabIndex = 14;
            lbtext.Text = "Đăng ký";
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 553);
            Controls.Add(gb);
            Name = "Register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Register";
            gb.ResumeLayout(false);
            gb.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox gb;
        private Button btnDangKy;
        private LinkLabel lklbDangNhap;
        private TextBox txbXacNhan;
        private TextBox txbEmail;
        private TextBox txbUserName;
        private TextBox txbMatKhau;
        private Label lbEmail;
        private Label lbXacNhan;
        private Label lbMatKhau;
        private Label lbUserName;
        private Label lbtext;
    }
}