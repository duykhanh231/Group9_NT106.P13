using Google.Api;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Google.Cloud.Firestore;
using Login_Register.Class;
using System.Net.Mail;
using System.Net;
using System.Net;
using System.Net.Mail;
namespace Login_Register
{
    public partial class ForgotPassword : Form
    {
        private string recipientEmail;

        public ForgotPassword()
        {
            InitializeComponent();
            FirestoreHelper.SetEnvironmentVariable();
        }

        private void InitializeComponent()
        {
            ComponentResourceManager resources = new ComponentResourceManager(typeof(ForgotPassword));
            gb = new GroupBox();
            lklbQuayLai = new LinkLabel();
            lbChiDan_2 = new Label();
            lbChiDan_1 = new Label();
            txbNhapOTP = new TextBox();
            btnXacNhan = new Button();
            txbEmail = new TextBox();
            btnGuiMa = new Button();
            lbNhapOTP = new Label();
            lbEmail = new Label();
            lbtext = new Label();
            gb.SuspendLayout();
            SuspendLayout();
            // 
            // gb
            // 
            gb.BackColor = Color.Transparent;
            gb.Controls.Add(lklbQuayLai);
            gb.Controls.Add(lbChiDan_2);
            gb.Controls.Add(lbChiDan_1);
            gb.Controls.Add(txbNhapOTP);
            gb.Controls.Add(btnXacNhan);
            gb.Controls.Add(txbEmail);
            gb.Controls.Add(btnGuiMa);
            gb.Controls.Add(lbNhapOTP);
            gb.Controls.Add(lbEmail);
            gb.ForeColor = Color.Transparent;
            gb.Location = new Point(4, 3);
            gb.Margin = new Padding(3, 4, 3, 4);
            gb.Name = "gb";
            gb.Padding = new Padding(3, 4, 3, 4);
            gb.Size = new Size(806, 547);
            gb.TabIndex = 17;
            gb.TabStop = false;
            gb.Enter += gb_Enter;
            // 
            // lklbQuayLai
            // 
            lklbQuayLai.AutoSize = true;
            lklbQuayLai.Location = new Point(318, 523);
            lklbQuayLai.Name = "lklbQuayLai";
            lklbQuayLai.Size = new Size(138, 20);
            lklbQuayLai.TabIndex = 17;
            lklbQuayLai.TabStop = true;
            lklbQuayLai.Text = "Quay lại đăng nhập";
            lklbQuayLai.LinkClicked += lklbQuayLai_LinkClicked;
            // 
            // lbChiDan_2
            // 
            lbChiDan_2.AutoSize = true;
            lbChiDan_2.BackColor = Color.Gray;
            lbChiDan_2.Font = new Font("Gill Sans Ultra Bold", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbChiDan_2.ForeColor = Color.FromArgb(255, 192, 128);
            lbChiDan_2.Location = new Point(157, 395);
            lbChiDan_2.Name = "lbChiDan_2";
            lbChiDan_2.Size = new Size(249, 18);
            lbChiDan_2.TabIndex = 16;
            lbChiDan_2.Text = "Nhập OTP bạn nhận được từ email";
            // 
            // lbChiDan_1
            // 
            lbChiDan_1.AutoSize = true;
            lbChiDan_1.BackColor = Color.Gray;
            lbChiDan_1.Font = new Font("Gill Sans Ultra Bold", 7.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbChiDan_1.ForeColor = Color.FromArgb(255, 192, 128);
            lbChiDan_1.Location = new Point(157, 324);
            lbChiDan_1.Name = "lbChiDan_1";
            lbChiDan_1.Size = new Size(381, 18);
            lbChiDan_1.TabIndex = 15;
            lbChiDan_1.Text = "Vui lòng nhâp email để tìm kiếm tài khoản của bạn";
            // 
            // txbNhapOTP
            // 
            txbNhapOTP.BackColor = SystemColors.ActiveBorder;
            txbNhapOTP.Location = new Point(312, 430);
            txbNhapOTP.Margin = new Padding(3, 4, 3, 4);
            txbNhapOTP.Multiline = true;
            txbNhapOTP.Name = "txbNhapOTP";
            txbNhapOTP.Size = new Size(302, 30);
            txbNhapOTP.TabIndex = 14;
            // 
            // btnXacNhan
            // 
            btnXacNhan.BackColor = Color.Gray;
            btnXacNhan.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnXacNhan.ForeColor = Color.FromArgb(255, 192, 128);
            btnXacNhan.Location = new Point(157, 480);
            btnXacNhan.Margin = new Padding(3, 4, 3, 4);
            btnXacNhan.Name = "btnXacNhan";
            btnXacNhan.Size = new Size(457, 39);
            btnXacNhan.TabIndex = 11;
            btnXacNhan.Text = "Xác nhận";
            btnXacNhan.UseVisualStyleBackColor = false;
            btnXacNhan.Click += btnXacNhan_Click;
            // 
            // txbEmail
            // 
            txbEmail.BackColor = SystemColors.ActiveBorder;
            txbEmail.Location = new Point(312, 280);
            txbEmail.Margin = new Padding(3, 4, 3, 4);
            txbEmail.Multiline = true;
            txbEmail.Name = "txbEmail";
            txbEmail.Size = new Size(302, 30);
            txbEmail.TabIndex = 13;
            // 
            // btnGuiMa
            // 
            btnGuiMa.BackColor = Color.Gray;
            btnGuiMa.Font = new Font("Gill Sans Ultra Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnGuiMa.ForeColor = Color.FromArgb(255, 192, 128);
            btnGuiMa.Location = new Point(157, 352);
            btnGuiMa.Margin = new Padding(3, 4, 3, 4);
            btnGuiMa.Name = "btnGuiMa";
            btnGuiMa.Size = new Size(457, 39);
            btnGuiMa.TabIndex = 10;
            btnGuiMa.Text = "Gửi mã";
            btnGuiMa.UseVisualStyleBackColor = false;
            btnGuiMa.Click += btnGuiMa_Click;
            // 
            // lbNhapOTP
            // 
            lbNhapOTP.AutoSize = true;
            lbNhapOTP.BackColor = Color.Gray;
            lbNhapOTP.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbNhapOTP.ForeColor = Color.FromArgb(255, 192, 128);
            lbNhapOTP.Location = new Point(180, 430);
            lbNhapOTP.Name = "lbNhapOTP";
            lbNhapOTP.Size = new Size(120, 25);
            lbNhapOTP.TabIndex = 3;
            lbNhapOTP.Text = "Nhập OTP:";
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.BackColor = Color.Gray;
            lbEmail.Font = new Font("Gill Sans Ultra Bold", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbEmail.ForeColor = Color.FromArgb(255, 192, 128);
            lbEmail.Location = new Point(157, 285);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(77, 25);
            lbEmail.TabIndex = 1;
            lbEmail.Text = "Email:";
            // 
            // lbtext
            // 
            lbtext.AutoSize = true;
            lbtext.BackColor = Color.Transparent;
            lbtext.Font = new Font("Gill Sans Ultra Bold", 19.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbtext.ForeColor = Color.FromArgb(192, 192, 0);
            lbtext.Location = new Point(244, 77);
            lbtext.Name = "lbtext";
            lbtext.Size = new Size(296, 46);
            lbtext.TabIndex = 18;
            lbtext.Text = "Tìm mật khẩu";
            // 
            // ForgotPassword
            // 
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(810, 554);
            Controls.Add(lbtext);
            Controls.Add(gb);
            Name = "ForgotPassword";
            Text = "FogotPassword";
            Load += ForgotPassword_Load;
            gb.ResumeLayout(false);
            gb.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void ForgotPassword_Load(object sender, EventArgs e)
        {

        }

        private void lklbQuayLai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            string inputEmail = txbEmail.Text.Trim();
            string inputOTP = txbNhapOTP.Text.Trim();

            if (string.IsNullOrEmpty(inputEmail) || string.IsNullOrEmpty(inputOTP))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ email và mã khôi phục.");
                return;
            }

            var db = FirestoreHelper.Database;
            if (db == null)
            {
                MessageBox.Show("Kết nối Firestore thất bại.");
                return;
            }

            try
            {
                // Tìm tài khoản người dùng dựa trên email
                Query query = db.Collection("Userdata").WhereEqualTo("Email", inputEmail);
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                if (querySnapshot.Documents.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy tài khoản người dùng với email này.");
                    return;
                }

                // Lấy thông tin mã khôi phục và thời gian hết hạn
                DocumentSnapshot userDoc = querySnapshot.Documents[0];
                string recoveryCode = userDoc.GetValue<string>("RecoveryCode");
                DateTime recoveryCodeExpiry = userDoc.GetValue<DateTime>("RecoveryCodeExpiry");

                // Kiểm tra mã khôi phục
                if (inputOTP != recoveryCode)
                {
                    MessageBox.Show("Mã khôi phục không chính xác.");
                    return;
                }

                // Kiểm tra thời gian hết hạn
                if (DateTime.UtcNow > recoveryCodeExpiry)
                {
                    MessageBox.Show("Mã khôi phục đã hết hạn.");
                    return;
                }

                MessageBox.Show("Xác nhận thành công! Bạn có thể đổi mật khẩu mới.");

                // Thêm logic điều hướng tới giao diện đổi mật khẩu nếu cần
                Hide();
                ForgotPassword_2 changePassword = new ForgotPassword_2(inputEmail); // Ví dụ form đổi mật khẩu
                changePassword.ShowDialog();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }


        private async void btnGuiMa_Click(object sender, EventArgs e)
        {
            string inputEmail = txbEmail.Text.Trim();

            if (string.IsNullOrEmpty(inputEmail))
            {
                MessageBox.Show("Vui lòng nhập email.");
                return;
            }

            var db = FirestoreHelper.Database;
            if (db == null)
            {
                MessageBox.Show("Kết nối Firestore thất bại.");
                return;
            }

            try
            {
                // Kiểm tra email có tồn tại không
                bool emailExists = await IsEmailExist(inputEmail);

                if (!emailExists)
                {
                    MessageBox.Show("Không tìm thấy email.");
                    return;
                }

                // Tạo mã khôi phục và lưu vào Firebase
                string recoveryCode = GenerateRecoveryCode();
                await SaveRecoveryCodeToFirestore(inputEmail, recoveryCode);

                // Gửi mã khôi phục qua email
                SendRecoveryEmail(inputEmail, recoveryCode);

                MessageBox.Show("Mã khôi phục đã được gửi tới email của bạn.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }

        private async Task<bool> IsEmailExist(string email)
        {
            var db = FirestoreHelper.Database;
            if (db == null) return false;

            Query query = db.Collection("Userdata").WhereEqualTo("Email", email);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

            return querySnapshot.Documents.Count > 0;
        }

        private string GenerateRecoveryCode()
        {
            Random random = new Random();
            return random.Next(100000, 999999).ToString(); // Mã 6 chữ số
        }

        private async Task SaveRecoveryCodeToFirestore(string email, string recoveryCode)
        {
            var db = FirestoreHelper.Database;
            if (db == null) throw new InvalidOperationException("Kết nối Firestore thất bại.");

            // Lưu mã khôi phục vào tài liệu của người dùng
            Query query = db.Collection("Userdata").WhereEqualTo("Email", email);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

            if (querySnapshot.Documents.Count > 0)
            {
                DocumentReference userDoc = querySnapshot.Documents[0].Reference;
                await userDoc.UpdateAsync(new Dictionary<string, object>
        {
            { "RecoveryCode", recoveryCode },
            { "RecoveryCodeExpiry", DateTime.UtcNow.AddMinutes(15) } // Mã khôi phục hết hạn sau 15 phút
        });
            }
            else
            {
                throw new InvalidOperationException("Không tìm thấy tài khoản người dùng.");
            }
        }

        private void SendRecoveryEmail(string recipientEmail, string recoveryCode)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("your-email@gmail.com");
                mail.To.Add(recipientEmail);
                mail.Subject = "Khôi phục mật khẩu";
                mail.Body = $"Mã khôi phục của bạn là: {recoveryCode}\n\nMã này có hiệu lực trong 15 phút.";

                smtpServer.Port = 587;
                smtpServer.Credentials = new NetworkCredential("your-email@gmail.com", "your-app-password");
                smtpServer.EnableSsl = true;

                smtpServer.Send(mail);

                MessageBox.Show("Mã khôi phục đã được gửi tới email của bạn.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi khi gửi email: {ex.Message}");
            }
        }

        private void gb_Enter(object sender, EventArgs e)
        {

        }
    }
}
