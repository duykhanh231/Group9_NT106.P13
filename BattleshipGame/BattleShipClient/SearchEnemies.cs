using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Threading;

namespace BattleShipClient
{
    public partial class SearchEnemies : Form
    {
        public volatile System.Windows.Forms.Timer updateTimer;
        public string enemyNick = "";
        string enemyAddressIPAndPort = "";
        public Button agreeButton;
        public List<string> onlineEnemyList = new List<string>();
        public SearchEnemies()
        {         
            InitializeComponent();
            this.Text = "BattleShip - " + Program.userLogin;                  
        }
        private void SetTimer()
        {
           
            updateTimer = new System.Windows.Forms.Timer();
             
            updateTimer.Interval = 5000;
            updateTimer.Tick += new EventHandler(OnEnemyTimedEvent);
            
            updateTimer.Enabled = true;
            GetEnemies();
        }
        private void OnEnemyTimedEvent(Object source, EventArgs e)
        {
            GetEnemies();
            Thread.Sleep(200);
            updateTimer.Enabled = false;
            GetOffers();
        }
        public void GetEnemies()
        {
            
            char comm = (char)13;
            string message = comm + " " + Program.userLogin + " <EOF>"; 
            Program.client.Send(message);
                       
        }
        public void GetOffers()
        {
            
            char comm = (char)7;
            string message = comm + " " + Program.userLogin + " <EOF>"; 
            Program.client.Send(message);
                    
        }
        private void DGVAvailableEnemies_CellClick(object sender, DataGridViewCellEventArgs e)
        {
                if (e.RowIndex >= 0)
                {
                    int row = e.RowIndex;
                   
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
                
                string message = (char)8 + " " + Program.userLogin + " " + enemyNick +" <EOF>"; 
                Program.client.Send(message);
                      
                agreeButton = (Button)sender;
                agreeButton.Enabled = false;
            }
        }
        private void CloseApp(object sender, FormClosingEventArgs e)
        {
            if (DialogResult != DialogResult.OK)
            {
                DialogResult = DialogResult.No;
               
                char comm = (char)14;
                string message = comm + " " + Program.userLogin + " "+ enemyNick+ " <EOF>";
                Program.client.Send(message);              
            }
            if (updateTimer.Enabled == true)
            {
                updateTimer.Enabled = false;
            }
        }
        private void SearchEnemy(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAvailableEnemies.Rows) 
            {
                row.Visible = row.Cells[1].Value.ToString().ToLower().StartsWith(txtSearch.Text.ToLower());//receiver
            }
        }
        private void EnemySelectionPanel_Load(object sender, EventArgs e)
        {
            dgvAvailableEnemies.ClearSelection();
            SetTimer();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
