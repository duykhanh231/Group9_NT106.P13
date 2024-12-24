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
    public partial class OfferingGame : Form
    {
        string enemiesNicks;
        public OfferingGame(string enemiesNicks)
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
            this.enemiesNicks = enemiesNicks;
        }

        private void BYes_Click(object sender, EventArgs e)
        {
            if (cboEnemyNick.Text == "")
            {
                MessageBox.Show("You must select enemy or click No", "Error!");
            }
            else
            {
                //Get recipient ID from Combobox
                Program.enemySelect.enemyNick = cboEnemyNick.SelectedValue.ToString();
                Program.enemyNick = cboEnemyNick.SelectedValue.ToString();
                DialogResult = DialogResult.Yes;
            }
        }

        private void BNo_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }

        private void OfferingGame_Load(object sender, EventArgs e)
        {
            List<string> eNicks = enemiesNicks.Split(' ').ToList();
            eNicks.RemoveAt(eNicks.Count()-1); //EOF
            eNicks.RemoveAt(0);//communique value

            cboEnemyNick.DataSource = eNicks;
            cboEnemyNick.AutoCompleteMode = AutoCompleteMode.Append;
            cboEnemyNick.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
