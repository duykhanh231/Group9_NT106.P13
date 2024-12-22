namespace Login_Register
{
    partial class ForgotPassword_2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ForgotPassword_2));
            gb = new GroupBox();
            lklbQuayLai = new LinkLabel();
            btnXacNhan = new Button();
            lbXacNhanMatKhau = new Label();
            txbXacNhanMatKhau = new TextBox();
            txbMatKhauMoi = new TextBox();
            label2 = new Label();
            lbtext = new Label();
            gb.SuspendLayout();
            SuspendLayout();
            // 
            // gb
            // 
            gb.BackColor = Color.Transparent;
            gb.Controls.Add(lklbQuayLai);
            gb.Controls.Add(btnXacNhan);
            gb.Controls.Add(lbXacNhanMatKhau);
            gb.Controls.Add(txbXacNhanMatKhau);
            gb.Controls.Add(txbMatKhauMoi);
            gb.Controls.Add(label2);
            gb.ForeColor = Color.Transparent;
            gb.Location = new Point(-2, 7);
            gb.Margin = new Padding(3, 4, 3, 4);
            gb.Name = "gb";
            gb.Padding = new Padding(3, 4, 3, 4);
            gb.Size = new Size(801, 529);
            gb.TabIndex = 19;
            gb.TabStop = false;
            // 
            // lklbQuayLai
            // 
            lklbQuayLai.AutoSize = true;
            lklbQuayLai.Location = new Point(345, 499);
            lklbQuayLai.Name = "lklbQuayLai";
            lklbQuayLai.Size = new Size(63, 20);
            lklbQuayLai.TabIndex = 21;
            lklbQuayLai.TabStop = true;
            lklbQuayLai.Text = "Quay lại";
            lklbQuayLai.LinkClicked += lklbQuayLai_LinkClicked;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Gray;
            btnXacNhan.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.FromArgb(255, 192, 128);
            btnXacNhan.Location = new Point(278, 438);
            btnXacNhan.Margin = new Padding(3, 4, 3, 4);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(219, 39);
            btnXacNhan.TabIndex = 16;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // lbXacNhanMatKhau
            // 
            lbXacNhanMatKhau.AutoSize = true;
            lbXacNhanMatKhau.BackColor = Color.Gray;
            lbXacNhanMatKhau.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbXacNhanMatKhau.ForeColor = Color.FromArgb(255, 192, 128);
            lbXacNhanMatKhau.Location = new Point(122, 378);
            lbXacNhanMatKhau.Name = "lbXacNhanMatKhau";
            lbXacNhanMatKhau.Size = new Size(222, 25);
            lbXacNhanMatKhau.TabIndex = 15;
            lbXacNhanMatKhau.Text = "Xác nhận mật khẩu:";
            // 
            // txbXacNhanMatKhau
            // 
            txbXacNhanMatKhau.BackColor = SystemColors.ActiveBorder;
            txbXacNhanMatKhau.Location = new Point(359, 373);
            txbXacNhanMatKhau.Margin = new Padding(3, 4, 3, 4);
            txbXacNhanMatKhau.Multiline = true;
            txbXacNhanMatKhau.Name = "txbXacNhanMatKhau";
            txbXacNhanMatKhau.Size = new Size(302, 30);
            txbXacNhanMatKhau.TabIndex = 14;
            // 
            // txbMatKhauMoi
            // 
            txbMatKhauMoi.BackColor = SystemColors.ActiveBorder;
            txbMatKhauMoi.Location = new Point(359, 321);
            txbMatKhauMoi.Margin = new Padding(3, 4, 3, 4);
            txbMatKhauMoi.Multiline = true;
            txbMatKhauMoi.Name = "txbMatKhauMoi";
            txbMatKhauMoi.Size = new Size(302, 30);
            txbMatKhauMoi.TabIndex = 12;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 192, 128);
            label2.Location = new Point(122, 326);
            label2.Name = "label2";
            label2.Size = new Size(160, 25);
            label2.TabIndex = 2;
            label2.Text = "Mật khẩu mới:";
            // 
            // lbtext
            // 
            lbtext.AutoSize = true;
            lbtext.BackColor = Color.Transparent;
            lbtext.Font = new Font("Gill Sans Ultra Bold", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtext.ForeColor = Color.FromArgb(192, 192, 0);
            lbtext.Location = new Point(227, 83);
            lbtext.Name = "lbtext";
            lbtext.Size = new Size(346, 46);
            lbtext.TabIndex = 20;
            lbtext.Text = "Đặt lại mật khẩu";
            // 
            // ForgotPassword_2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 535);
            Controls.Add(lbtext);
            Controls.Add(gb);
            Name = "ForgotPassword_2";
            Text = "ForgotPassword_2";
            gb.ResumeLayout(false);
            gb.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gb;
        private Button btnXacNhan;
        private Label lbXacNhanMatKhau;
        private TextBox txbXacNhanMatKhau;
        private TextBox txbMatKhauMoi;
        private Label label2;
        private Label lbtext;
        private LinkLabel lklbQuayLai;
    }
}