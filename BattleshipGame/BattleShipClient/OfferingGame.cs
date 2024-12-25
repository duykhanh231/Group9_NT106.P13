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
    public partial class OfferingGame : Form
    {
        string enemiesNicks;
        // Import the user32.dll to send messages to the OS
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        // Constants for Windows Messages
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HTCAPTION = 0x2;
        public OfferingGame(string enemiesNicks)
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
            this.enemiesNicks = enemiesNicks;
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (cboEnemyNick.Text == "")
            {
                MessageBox.Show("You must select enemy or click No", "Error!");
            }
            else
            {
                
                Program.enemySelect.enemyNick = cboEnemyNick.SelectedValue.ToString();
                Program.enemyNick = cboEnemyNick.SelectedValue.ToString();
                DialogResult = DialogResult.Yes;
            }
        }

        private void btnDecline_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void OfferingGame_Load(object sender, EventArgs e)
        {
            List<string> eNicks = enemiesNicks.Split(' ').ToList();
            eNicks.RemoveAt(eNicks.Count()-1); 
            eNicks.RemoveAt(0);

            cboEnemyNick.DataSource = eNicks;
            cboEnemyNick.AutoCompleteMode = AutoCompleteMode.Append;
            cboEnemyNick.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
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
