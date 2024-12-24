﻿using BattleshipGame;
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
    public partial class OfferingGame : Form
    {
        string enemiesNicks;
        public OfferingGame(string enemiesNicks)
        {
            InitializeComponent();
            DialogResult = DialogResult.No;
            this.enemiesNicks = enemiesNicks;
        }

        

        private void accept_Click(object sender, EventArgs e)
        {
            if (enemies.Text == "")
            {
                MessageBox.Show("You must select enemy or click No", "Error!");
            }
            else
            {
                
                Program.enemySelect.enemyNick = enemies.SelectedValue.ToString();
                Program.enemyNick = enemies.SelectedValue.ToString();
                DialogResult = DialogResult.Yes;
            }
        }

        private void Decline_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.No;
        }
        private void OfferingGame_Load(object sender, EventArgs e)
        {
            List<string> eNicks = enemiesNicks.Split(' ').ToList();
            eNicks.RemoveAt(eNicks.Count() - 1); 
            eNicks.RemoveAt(0);

            enemies.DataSource = eNicks;
            enemies.AutoCompleteMode = AutoCompleteMode.Append;
            enemies.AutoCompleteSource = AutoCompleteSource.ListItems;
        }
    }
}
