using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleshipGame
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (tb_Accountname.Text == "" || tb_serverIP.Text == "")
            {
                MessageBox.Show("Please enter information to play game!");
            }

            string welcomeMessage = $"WelcomeMessage|{tb_Accountname.Text}|{tb_serverIP.Text}";
            SendMessageToServer(welcomeMessage, tb_serverIP.Text);



        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void SendMessageToServer(string message, string IP)
        {
            try
            {
                TcpClient client = new TcpClient(IP, 2508);
                NetworkStream stream = client.GetStream();

                byte[] data = Encoding.UTF8.GetBytes(message);
                stream.Write(data, 0, data.Length);

                byte[] responseData = new byte[256];
                int bytes = stream.Read(responseData, 0, responseData.Length);
                string response = Encoding.UTF8.GetString(responseData, 0, bytes);

                MessageBox.Show(response);

                stream.Close();
                client.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error connecting to server: " + ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            Signup signup = new Signup();
            signup.ShowDialog();
        }
    }
}
