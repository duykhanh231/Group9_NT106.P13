using Client;

namespace BattleshipGame
{
    static class Program
    {
        public static string userLogin;
        public static string serverAddress;
        public static SynchronousSocketClient client;
        public static SearchEnemy enemySelect;
        public static Setup main;
        public static string enemyNick;
        
        public static volatile bool isThreadRunning = false;

        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            userLogin = "";
            serverAddress = "";

            Welcome servConn;

            DialogResult dialogResult = DialogResult.No;
            
            while (dialogResult != DialogResult.Cancel)
            {
                if (dialogResult == DialogResult.No)
                {
                    isThreadRunning = false;
                    servConn = new Welcome();
                    dialogResult = servConn.ShowDialog();
                }
                if (dialogResult == DialogResult.Yes) 
                {
                    if (isThreadRunning == false) 
                    {
                        isThreadRunning = true;
                        new Thread(() =>
                        {
                            Thread.CurrentThread.IsBackground = true;
                            ReceivingMessages();
                        }).Start();
                    }
                    enemySelect = new SearchEnemy();
                    dialogResult = enemySelect.ShowDialog();
                }
                if (dialogResult == DialogResult.OK ) 
                {
                    main = new Setup(enemyNick);
                    dialogResult = main.ShowDialog();
                }
            }
        }
        public static void ReceivingMessages()
        {
            while (isThreadRunning == true)
            {
                try
                {
                    var answer = client.Receive();
                    switch (answer[0])
                    {
                        
                        case (char)12:
                            {
                                List<string> onlineEnemyListTmp = new List<string>();

                                
                                string[] enemies = enemies = answer.Split(' ');
                                string[] enemy;
                                foreach (var item in enemies)
                                {
                                    enemy = item.Split(';');
                                    if (enemy.Count() > 1)
                                    {
                                        onlineEnemyListTmp.Add(enemy[0]);  
                                        if (enemySelect.onlineEnemyList.Contains(enemy[0]))
                                        {
                                            enemySelect.onlineEnemyList.Remove(enemy[0]);
                                        }
                                        else 
                                        {
                                            DataGridViewRow dgvRow = new DataGridViewRow();
                                            dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = enemy[1] });
                                            dgvRow.Cells.Add(new DataGridViewTextBoxCell { Value = enemy[0] });
                                            MethodInvoker inv1 = delegate
                                            {
                                                enemySelect.dgvAvailableEnemies.Rows.Add(dgvRow);
                                            }; enemySelect.Invoke(inv1);

                                        }
                                    }
                                }
                                
                                string enemyVal = "";
                                for (int i = enemySelect.dgvAvailableEnemies.Rows.Count - 1; i >= 0; i--)
                                {
                                    enemyVal = enemySelect.dgvAvailableEnemies.Rows[i].Cells[1].Value.ToString();
                                    if (enemySelect.onlineEnemyList.Contains(enemyVal))
                                    {
                                        enemySelect.onlineEnemyList.Remove(enemyVal);
                                        MethodInvoker inv2 = delegate
                                        {
                                            enemySelect.dgvAvailableEnemies.Rows.RemoveAt(i);
                                        }; enemySelect.Invoke(inv2);

                                    }
                                }
                                
                                enemySelect.onlineEnemyList = new List<string>(onlineEnemyListTmp);
                                enemySelect.dgvAvailableEnemies.ClearSelection();
                                break;
                            }
                        
                        case (char)7:
                            {
                                MethodInvoker inv2 = delegate
                                {
                                    string message = "";
                                    DialogResult dlg = DialogResult.No;
                                   
                                    if (answer.Split(' ').Count() > 2) 
                                    {
                                                                    
                                        OfferingGame offeringGame = new OfferingGame(answer);
                                        dlg = offeringGame.ShowDialog();
                                    }
                                    if (dlg == DialogResult.Yes)
                                    {
                                        if (enemyNick != "")
                                        {
                                           
                                            message = (char)12 + " " + userLogin + " " + enemyNick + " <EOF>"; 
                                            client.Send(message);
                                            enemyNick = enemySelect.enemyNick;
                                            enemySelect.DialogResult = DialogResult.OK;
                                            
                                        }
                                    }
                                    else
                                    {
                                        if (answer.Split(' ').Count() > 2)
                                        {
                                            
                                            message = (char)12 + " " + userLogin + " " + userLogin + " <EOF>"; 
                                            client.Send(message);
                                        }
                                        enemySelect.updateTimer.Enabled = true;
                                        
                                    }
                                }; enemySelect.Invoke(inv2);

                                break;
                            }
                        
                        case (char)10:
                            {
                                enemyNick = enemySelect.enemyNick;
                                enemySelect.DialogResult = DialogResult.OK;
                                break;
                            }
                        
                        case (char)9:
                            {
                                MethodInvoker inv = delegate
                                {
                                    enemySelect.agreeButton.Enabled = true;
                                    enemySelect.updateTimer.Enabled = true;
                                }; enemySelect.Invoke(inv);
                                
                                break;
                            }
                        
                        case (char)16:
                            {
                                MethodInvoker inv = delegate
                                {
                                    
                                    main.clickedButton.Visible = false;
                                    main.PrepareBattleField();
                                    Application.DoEvents();
                                    ((Panel)main.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = false;
                                }; main.Invoke(inv);
                                break;
                            }
                        
                        case (char)0:
                            {
                                MethodInvoker inv = delegate
                                {
                                    
                                    main.clickedButton.Visible = false;
                                    main.PrepareBattleField();
                                    ((Panel)main.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = true;
                                }; main.Invoke(inv);
                                break;
                            }
                        
                        case (char)17:
                            {
                                MethodInvoker inv = delegate
                                {
                                    main.enemyGiveUpBeforeStart = true;
                                    ((Panel)main.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = false;
                                    MessageBox.Show("Enemy gave up, you won!", "Congratulations!");
                                    main.normalEnd = true;
                                    main.DialogResult = DialogResult.Yes;
                                }; main.Invoke(inv);
                                break;
                            }
                        
                        case (char)4:
                            {
                                MethodInvoker inv = delegate
                                {
                                    main.clickedButton.BackColor = Color.Silver;
                                    ((Panel)main.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = false;
                                }; main.Invoke(inv);
                                break;
                            }
                        
                        case (char)5:
                            {
                                MethodInvoker inv = delegate
                                {
                                    int x = Int32.Parse(main.clickedButton.Name.Substring(0, 1));
                                    int y = Int32.Parse(main.clickedButton.Name.Substring(1, 1)); 
                                    main.enemyMap[x, y] = true;
                                    main.clickedButton.BackColor = Color.Crimson;
                                    ((Panel)main.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = true;
                                }; main.Invoke(inv);
                                break;
                            }
                        
                        case (char)3:
                            {
                                MethodInvoker inv = delegate
                                {
                                    int x = Int32.Parse(main.clickedButton.Name.Substring(0, 1)); 
                                    int y = Int32.Parse(main.clickedButton.Name.Substring(1, 1)); 
                                    main.enemyMap[x, y] = true;
                                    main.clickedButton.BackColor = Color.Tomato;
                                    ((Panel)main.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = true;
                                }; main.Invoke(inv);
                                break;
                            }
                        
                        case (char)1:
                            {
                                MethodInvoker inv = delegate
                                {
                                    int x = Int32.Parse(main.clickedButton.Name.Substring(0, 1)); 
                                    int y = Int32.Parse(main.clickedButton.Name.Substring(1, 1)); 
                                    main.enemyMap[x, y] = true;
                                    main.clickedButton.BackColor = Color.Crimson;
                                    ((Panel)main.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = false;
                                    MessageBox.Show("You win!", "Success!");
                                    main.normalEnd = true;
                                    main.DialogResult = DialogResult.Yes;
                                }; main.Invoke(inv);
                                break;
                            }
                        
                        case (char)6:
                            {
                                MethodInvoker inv = delegate
                                {
                                    string message = "";
                                    int x = -1;
                                    int y = -1;
                                    if (answer[0] == (char)6)
                                    {
                                        x = Int32.Parse(answer.Split(' ')[1]);
                                        y = Int32.Parse(answer.Split(' ')[2]);
                                        main.GetShotAndResponse(x, y);
                                        if (main.masts == 0)
                                        {
                                            ((Panel)main.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = false;
                                            message = (char)1 + " " + userLogin + " " + enemyNick + " <EOF>";
                                            client.Send(message);
                                            main.normalEnd = true;
                                            MessageBox.Show("You lose!", ":(");
                                            main.DialogResult = DialogResult.Yes;
                                        }
                                    }
                                }; main.Invoke(inv);
                                break;
                            }

                    }
                }
                catch (Exception)
                {
                    isThreadRunning = false;
                }
            }
        }
    }
}