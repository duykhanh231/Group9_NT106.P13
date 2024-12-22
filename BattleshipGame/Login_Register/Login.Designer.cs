namespace Login_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            gb = new GroupBox();
            btnTaoTaiKhoan = new Button();
            lbPassword = new Label();
            label1 = new Label();
            txbUserName = new TextBox();
            txbPassword = new TextBox();
            lklbQuenMatKhau = new LinkLabel();
            lbUserName = new Label();
            btnDangNhap = new Button();
            lbtext = new Label();
            gb.SuspendLayout();
            SuspendLayout();
            // 
            // gb
            // 
            gb.BackColor = Color.Transparent;
            gb.Controls.Add(btnTaoTaiKhoan);
            gb.Controls.Add(lbPassword);
            gb.Controls.Add(label1);
            gb.Controls.Add(txbUserName);
            gb.Controls.Add(txbPassword);
            gb.Controls.Add(lklbQuenMatKhau);
            gb.Controls.Add(lbUserName);
            gb.Controls.Add(btnDangNhap);
            gb.Location = new Point(-1, 2);
            gb.Margin = new Padding(3, 4, 3, 4);
            gb.Name = "gb";
            gb.Padding = new Padding(3, 4, 3, 4);
            gb.Size = new Size(800, 541);
            gb.TabIndex = 8;
            gb.TabStop = false;
            // 
            // btnTaoTaiKhoan
            // 
            btnTaoTaiKhoan.BackColor = Color.Gray;
            btnTaoTaiKhoan.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaoTaiKhoan.ForeColor = Color.FromArgb(255, 192, 128);
            btnTaoTaiKhoan.Location = new Point(249, 479);
            btnTaoTaiKhoan.Margin = new Padding(3, 4, 3, 4);
            btnTaoTaiKhoan.Name = "btnTaoTaiKhoan";
            btnTaoTaiKhoan.Size = new Size(251, 46);
            btnTaoTaiKhoan.TabIndex = 6;
            btnTaoTaiKhoan.Text = "Tạo tài khoản mới";
            btnTaoTaiKhoan.UseVisualStyleBackColor = false;
            btnTaoTaiKhoan.Click += btnTaoTaiKhoan_Click;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.BackColor = Color.Gray;
            lbPassword.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbPassword.ForeColor = Color.FromArgb(255, 192, 128);
            lbPassword.Location = new Point(135, 325);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(119, 25);
            lbPassword.TabIndex = 1;
            lbPassword.Text = "Password:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(121, 455);
            label1.Name = "label1";
            label1.Size = new Size(477, 20);
            label1.TabIndex = 7;
            label1.Text = "------------------------------------------------------------------------------";
            // 
            // txbUserName
            // 
            txbUserName.BackColor = SystemColors.ActiveBorder;
            txbUserName.Location = new Point(301, 261);
            txbUserName.Margin = new Padding(3, 4, 3, 4);
            txbUserName.Multiline = true;
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(370, 35);
            txbUserName.TabIndex = 2;
            // 
            // txbPassword
            // 
            txbPassword.BackColor = SystemColors.ActiveBorder;
            txbPassword.Location = new Point(301, 315);
            txbPassword.Margin = new Padding(3, 4, 3, 4);
            txbPassword.Multiline = true;
            txbPassword.Name = "txbPassword";
            txbPassword.PasswordChar = '●';
            txbPassword.Size = new Size(370, 35);
            txbPassword.TabIndex = 3;
            // 
            // lklbQuenMatKhau
            // 
            lklbQuenMatKhau.AutoSize = true;
            lklbQuenMatKhau.Location = new Point(318, 435);
            lklbQuenMatKhau.Name = "lklbQuenMatKhau";
            lklbQuenMatKhau.Size = new Size(116, 20);
            lklbQuenMatKhau.TabIndex = 5;
            lklbQuenMatKhau.TabStop = true;
            lklbQuenMatKhau.Text = "Quên mật khẩu?";
            lklbQuenMatKhau.LinkClicked += lklbQuenMatKhau_LinkClicked;
            // 
            // lbUserName
            // 
            lbUserName.AutoSize = true;
            lbUserName.BackColor = Color.Gray;
            lbUserName.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbUserName.ForeColor = Color.FromArgb(255, 192, 128);
            lbUserName.Location = new Point(135, 271);
            lbUserName.Name = "lbUserName";
            lbUserName.Size = new Size(132, 25);
            lbUserName.TabIndex = 0;
            lbUserName.Text = "User Name:";
            // 
            // btnDangNhap
            // 
            btnDangNhap.BackColor = Color.Gray;
            btnDangNhap.Font = new Font("Gill Sans Ultra Bold", 13.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnDangNhap.ForeColor = Color.FromArgb(255, 192, 128);
            btnDangNhap.Location = new Point(135, 381);
            btnDangNhap.Margin = new Padding(3, 4, 3, 4);
            btnDangNhap.Name = "btnDangNhap";
            btnDangNhap.Size = new Size(480, 50);
            btnDangNhap.TabIndex = 4;
            btnDangNhap.Text = "Đăng nhập";
            btnDangNhap.UseVisualStyleBackColor = false;
            btnDangNhap.Click += btnDangNhap_Click;
            // 
            // lbtext
            // 
            lbtext.AutoSize = true;
            lbtext.BackColor = Color.Transparent;
            lbtext.Font = new Font("Gill Sans Ultra Bold", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtext.ForeColor = Color.FromArgb(192, 192, 0);
            lbtext.Location = new Point(267, 71);
            lbtext.Name = "lbtext";
            lbtext.Size = new Size(232, 46);
            lbtext.TabIndex = 11;
            lbtext.Text = "Đăng nhập";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 542);
            Controls.Add(lbtext);
            Controls.Add(gb);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            Load += Login_Load;
            gb.ResumeLayout(false);
            gb.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb;
        private Button btnTaoTaiKhoan;
        private Label lbPassword;
        private Label label1;
        private TextBox txbUserName;
        private TextBox txbPassword;
        private LinkLabel lklbQuenMatKhau;
        private Label lbUserName;
        private Button btnDangNhap;
        private Label lbtext;
    }
}