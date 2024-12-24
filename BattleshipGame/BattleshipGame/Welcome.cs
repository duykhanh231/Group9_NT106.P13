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
                MessageBox.Show("At least one of required fields is not filed!", "Error!");
            }
            else if (tb_Accountname.Text.Split(' ').Count() > 1)
            {
                MessageBox.Show("Nick can't contain any spaces!", "Error!");
            }
            else
            {
                try
                {
                    //Set login
                    Program.userLogin = tb_Accountname.Text;
                    Program.client = new SynchronousSocketClient(tb_serverIP.Text);
                    //Send Join communique
                    char comm = (char)11;
                    string message = comm + " " + tb_Accountname.Text + " <EOF>";
                    Program.client.Send(message);
                    //Receive answer
                    var answer = Program.client.Receive()[0];

                    //If answer is OK
                    if (answer == (char)10)
                    {
                        //Program.dialog = 1;
                        //this.Close();
                        DialogResult = DialogResult.Yes;
                    }
                    else//Else if answer is Fail - char(9)
                    {
                        MessageBox.Show("Typed nick is occupied", "Error!");
                    }
                }
                catch (Exception)//Cannot connect to server
                {
                    MessageBox.Show("Problem with server connection or address ipv4 is incorrect!", "Error!");
                }
            }
        }

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        private void EnterClicked(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                btn_connect_Click(sender, e);
            }
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
