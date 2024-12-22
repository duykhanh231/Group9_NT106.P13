using BattleshipGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class SearchEnemy : Form
    {
        public volatile System.Windows.Forms.Timer updateTimer;
        public string enemyNick = "";
        string enemyAddressIPAndPort = "";
        public Button agreeButton;
        public List<string> onlineEnemyList = new List<string>();
        public SearchEnemy()
        {
            InitializeComponent();
            this.Text = "BattleShip - " + Program.userLogin;
        }

        private void SetTimer()
        {
            // Create a timer with a 15 seconds interval.
            updateTimer = new System.Windows.Forms.Timer();// (15000);//61000
            // Hook up the Elapsed event for the timer. 
            updateTimer.Interval = 5000;
            updateTimer.Tick += new EventHandler(OnEnemyTimedEvent);
            //pdateTimer.Elapsed += OnEnemyTimedEvent;
            //updateTimer.AutoReset = true;
            updateTimer.Enabled = true;
            GetEnemies();
        }
        private void OnEnemyTimedEvent(Object source, EventArgs e)//ElapsedEventArgs e)
        {
            GetEnemies();
            Thread.Sleep(200);
            updateTimer.Enabled = false;
            GetOffers();
        }
        public void GetEnemies()
        {
            //Send GetEnemies communique
            char comm = (char)13;
            string message = comm + " " + Program.userLogin + " <EOF>"; //enemies except me
            Program.client.Send(message);
            //Receive answer in program's thread           
        }
        public void GetOffers()
        {
            //Send Getoffers communique
            char comm = (char)7;
            string message = comm + " " + Program.userLogin + " <EOF>"; //enemies except me
            Program.client.Send(message);
            //Receive answer in program;s thread          
        }
        private void dgvAvailableEnemies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int row = e.RowIndex;
                //Get clicked row enemy details
                enemyAddressIPAndPort = dgvAvailableEnemies.Rows[row].Cells[0].Value.ToString();
                enemyNick = dgvAvailableEnemies.Rows[row].Cells[1].Value.ToString();
                btnConnect.Text = "Play with " + enemyNick;
            }
        }
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (enemyNick != "")
            {
                updateTimer.Enabled = false;
                //Send Offer communique
                string message = (char)8 + " " + Program.userLogin + " " + enemyNick + " <EOF>"; //enemies except me
                Program.client.Send(message);
                //Receive answer in program's thread       
                agreeButton = (Button)sender;
                agreeButton.Enabled = false;
            }
        }
        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK/*Program.dialog != 2*/)
            {
                DialogResult = DialogResult.No;
                //Program.dialog = 0;
                //Send CloseApp communique
                char comm = (char)14;
                string message = comm + " " + Program.userLogin + " " + enemyNick + " <EOF>";
                Program.client.Send(message);
            }
            if (updateTimer.Enabled == true)
            {
                updateTimer.Enabled = false;
            }
        }
        private void SearchEnemies(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAvailableEnemies.Rows) //you receive msg
            {
                row.Visible = row.Cells[1].Value.ToString().ToLower().StartsWith(txtSearchEnemies.Text.ToLower());//receiver
            }
        }
        private void SearchEnemy_Load(object sender, EventArgs e)
        {
            dgvAvailableEnemies.ClearSelection();
            SetTimer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblSearchEnemies_Click(object sender, EventArgs e)
        {

        }
    }
}
