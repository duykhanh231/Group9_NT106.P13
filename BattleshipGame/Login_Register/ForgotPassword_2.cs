using Google.Cloud.Firestore;
using Login_Register.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register
{
    public partial class ForgotPassword_2 : Form
    {
        private string _userEmail;
        public ForgotPassword_2(string userEmail)
        {
            InitializeComponent();
            _userEmail = userEmail;
        }

        private async void btnXacNhan_Click(object sender, EventArgs e)
        {
            string newPassword = txbMatKhauMoi.Text.Trim();
            string confirmPassword = txbXacNhanMatKhau.Text.Trim(); // Lấy mật khẩu xác nhận.

            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu mới.");
                return;
            }



            if (newPassword != confirmPassword)
            {
                MessageBox.Show("Mật khẩu xác nhận không khớp với mật khẩu mới.");
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
                // Tìm tài liệu của người dùng dựa trên email.
                Query query = db.Collection("Userdata").WhereEqualTo("Email", _userEmail);
                QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

                if (querySnapshot.Documents.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy người dùng.");
                    return;
                }

                // Cập nhật mật khẩu mới.
                DocumentSnapshot userDoc = querySnapshot.Documents[0];
                DocumentReference docRef = userDoc.Reference;
                string encryptedPassword = Security.Encrypt(newPassword);
                await docRef.UpdateAsync("Password", encryptedPassword);
                

                MessageBox.Show("Mật khẩu đã được cập nhật thành công!");
                /*Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();*/
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}");
            }
        }


        private void lklbQuayLai_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ForgotPassword forgotpassword = new ForgotPassword();
            forgotpassword.ShowDialog();
            Close();
        }

       
    }
}
