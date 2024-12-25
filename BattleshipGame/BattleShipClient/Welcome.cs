using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattleShipClient
{
    public partial class Welcome : Form
    {
        // Import the user32.dll to send messages to the OS
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constants for Windows Messages
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
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
                    
                    Program.userLogin = txtUsername.Text;
                    Program.client = new SynchronousSocketClient(txtServerIP.Text);
                    
                    char comm = (char)11;                
                    string message = comm+ " " + txtUsername.Text + " <EOF>";
                    Program.client.Send(message);
                    
                    var answer = Program.client.Receive()[0];
                    
                    
                    if (answer == (char)10)
                    {
                        
                        DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        MessageBox.Show("Typed nick is occupied", "Error!");
                    }                 
                }
                catch (Exception)
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

        private void Welcome_Load(object sender, EventArgs e)
        {

        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);

            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture(); // Release mouse capture
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0); // Simulate the drag
            }
        }

    }
}
