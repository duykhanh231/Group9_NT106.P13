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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void lklbDangNhap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            Login login = new Login();
            login.ShowDialog();
            Close();
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {

        }

        private async Task<bool> CheckIfUserAlreadyExistAsync()
        {
            string username = txbUserName.Text.Trim();
            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("Userdata").Document(username);
            var snapshot = await docRef.GetSnapshotAsync();
            return snapshot.Exists;
        }
        private async Task<bool> CheckIfEmailAlreadyExistAsync(string email)
        {
            var db = FirestoreHelper.Database;
            Query query = db.Collection("Userdata").WhereEqualTo("Email", email);
            QuerySnapshot querySnapshot = await query.GetSnapshotAsync();

            return querySnapshot.Documents.Count > 0;
        }


        private bool IsPasswordConfirmed()
        {
            string password = txbMatKhau.Text.Trim();
            string confirmPassword = txbXacNhan.Text.Trim();
            return password == confirmPassword;
        }

        private async void btnDangKy_Click_1(object sender, EventArgs e)
        {
            if (!IsPasswordConfirmed())
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            if (await CheckIfUserAlreadyExistAsync())
            {
                
                MessageBox.Show("Tài khoản đã tồn tại");
                return;
            }
            string email = txbEmail.Text.Trim();

            if (await CheckIfEmailAlreadyExistAsync(email))
            {
                MessageBox.Show("Email đã tồn tại");
                return;
            }

            var data = GetWriteData();
            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("Userdata").Document(data.Username);
            await docRef.SetAsync(data);
            MessageBox.Show("Đăng ký thành công");
        }

        private UserData GetWriteData()
        {
            
            string username = txbUserName.Text.Trim();
            string password = Security.Encrypt(txbMatKhau.Text);
            string confirmpassword = Security.Encrypt(txbXacNhan.Text.Trim());
            string email = txbEmail.Text.Trim();
            return new UserData()
            {
                Username = username,
                Password = password,
                Confirmpassword = confirmpassword,
                Email = email,
            };
        }
        private bool CheckIfUserAlreadyExist()
        {
            string username = txbUserName.Text.Trim();
            var db = FirestoreHelper.Database;
            DocumentReference docRef = db.Collection("Userdata").Document(username);
            var snapshot = docRef.GetSnapshotAsync().Result;
            if (snapshot.Exists)
            {
                return true;
            }
            return false;
        }
    }
}
