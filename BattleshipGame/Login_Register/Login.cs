using Google.Cloud.Firestore;
using Login_Register.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login_Register
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void btnTaoTaiKhoan_Click(object sender, EventArgs e)
        {
            Hide();
            Register register = new Register();
            register.ShowDialog();
            Close();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            string username = txbUserName.Text.Trim();
            string password = txbPassword.Text;
            var db = FirestoreHelper.Database;
            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Vui lòng nhập tên đăng nhập");
                return;
            }

            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu");
                return;
            }
            DocumentReference docRef = db.Collection("Userdata").Document(username);
            UserData data = docRef.GetSnapshotAsync().Result.ConvertTo<UserData>();
            if (data != null)
            {
                if (password == Security.Decrypt(data.Password))
                {
                    MessageBox.Show("Đăng nhập thành công");
                }
                else
                {
                    MessageBox.Show("Mật khẩu không đúng");
                }
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }


        }

        private void lklbQuenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            ForgotPassword fogotpassword = new ForgotPassword();
            fogotpassword.ShowDialog();
            Close();
        }
    }
}
