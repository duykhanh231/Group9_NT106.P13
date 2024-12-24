using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipClient
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || txtServerIP.Text == "")
            {
                MessageBox.Show("At least one of required fields is not filed!", "Error!");
            }
            else if (txtUsername.Text.Split(' ').Count()>1)
            {
                MessageBox.Show("Nick can't contain any spaces!", "Error!");
            }
            else
            {
                try
                {
                    //Set login
                    Program.userLogin = txtUsername.Text;
                    Program.client = new SynchronousSocketClient(txtServerIP.Text);
                    //Send Join communique
                    char comm = (char)11;                
                    string message = comm+ " " + txtUsername.Text + " <EOF>";
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

        private void EnterClicked(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Return)
            {
                btnConnect_Click(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void ServerConnectionPanel_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    if (Program.dialog != 1)
        //    {
        //        Program.dialog = -1;
        //    }
        //}
    }
}
