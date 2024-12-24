namespace BattleshipGame
{
    public partial class Setup : Form
    {
        string enemyNick;
        public bool enemyGiveUpBeforeStart = false;
        public bool normalEnd = false;
        public Button clickedButton;

        public int masts = 20;
        public Setup()
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.enemyNick = enemyNick;

        }

        public Setup(string enemyNick)
        {
            InitializeComponent();
            DoubleBuffered = true;
            this.enemyNick = enemyNick;
        }

        public bool[,] yourMap = new bool[10, 10];
        public bool[,] yourMapTmp = new bool[10, 10];
        public bool[,] enemyMap = new bool[10, 10];
        List<Button> selectedButtons = new List<Button>();

        private void setDefaultValuesInMap(bool value, bool[,] Map)
        {
            for (int i = 0; i < Map.GetLength(1); i++)
            {
                for (int j = 0; j < Map.GetLength(0); j++)
                {
                    Map[i, j] = value;
                }
            }
        }
        private void GenerateMap(string name, int xStartPos, int yStartPos)
        {
            Panel buttonPanel = new Panel();
            buttonPanel.Name = name;
            buttonPanel.Size = new Size(231, 231);
            int xButtonSize = 21;
            int yButtonSize = 21;
            for (int i = 0; i < 11; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    if (i == 0 && j == 0) continue; //don't create left top corner
                    Button button = new Button();
                    buttonPanel.Controls.Add(button);
                    button.Location = new System.Drawing.Point(j * xButtonSize, i * yButtonSize);
                    button.Size = new Size(xButtonSize, yButtonSize);
                    button.ForeColor = System.Drawing.Color.Black;
                    //this.Controls.Add(button);
                    if (i > 0 && j > 0) //double digits: 00, 01, ..., 99
                    {
                        button.Name = (i - 1).ToString() + (j - 1).ToString();
                        //button.Text = (i - 1).ToString() + (j - 1).ToString();
                        button.Font = new Font(button.Font.FontFamily, 6);
                        if (name == "PYou")
                        {
                            button.Click += new System.EventHandler(this.setMastbuttonClick);
                        }
                        else if (name == "PEnemy")
                        {
                            button.Click += new System.EventHandler(this.buttonClick);
                        }
                    }
                    else
                    {
                        button.Enabled = false;
                        if (i == 0 && j > 0) //letters: A, B, ..., J
                        {
                            button.Text = ((char)(64 + j)).ToString();
                            button.Name = ((char)(64 + j)).ToString();
                            button.Font = new Font(button.Font.FontFamily, 6);
                        }
                        else if (i != 0 || j != 0) // digits: 1, 2, ..., 10
                        {
                            button.Text = i.ToString();
                            button.Name = "L" + i.ToString();
                            button.Font = new Font(button.Font.FontFamily, 6);
                        }
                    }
                }
            }
            this.Controls.Add(buttonPanel);
            buttonPanel.Location = new Point(xStartPos, yStartPos);
        }
        private void SetShips()
        {
            GenerateMap("PYou", 204, 190);
            setDefaultValuesInMap(false, yourMap);
            for (int i = 0; i < yourMapTmp.GetLength(1); i++)
            {
                for (int j = 0; j < yourMapTmp.GetLength(0); j++)
                {
                    yourMapTmp[i, j] = false;
                }
            }
        }
        private void DisableOrEnableButtonIfExists(Panel panel, int x1, int y1, bool DisOrEn)
        {
            Button button;
            button = (Button)panel.Controls.Find(x1.ToString() + y1.ToString(), true).FirstOrDefault();
            if (button != null)
            {
                if (DisOrEn == false)
                {
                    button.Enabled = false;
                }
                else
                {
                    button.Enabled = true;
                }
            }
        }
        private int IsLeftNeighbor(int x, int y)
        {
            int x1 = x;
            int y1 = y - 1;
            if (y1 > -1)
            {
                if (yourMap[x1, y1] == true) //check if neighbour has neighbour
                {
                    return 1 + IsLeftNeighbor(x1, y1);
                }
                else //no neigbour
                {
                    return 0;
                }
            }
            else //no neighbour
            {
                return 0;
            }
        }
        private int IsRightNeighbor(int x, int y)
        {
            int x1 = x;
            int y1 = y + 1;
            if (y1 < 10)
            {
                if (yourMap[x1, y1] == true) //check if neighbour has neighbor
                {
                    return 1 + IsRightNeighbor(x1, y1);
                }
                else //no neigbor
                {
                    return 0;
                }
            }
            else //no neighbor
            {
                return 0;
            }
        }
        private int IsUpNeighbor(int x, int y)
        {
            int x1 = x - 1;
            int y1 = y;
            if (x1 > -1)
            {
                if (yourMap[x1, y1] == true) //check if neighbor has neighbor
                {
                    return 1 + IsUpNeighbor(x1, y1);
                }
                else //no neigbour
                {
                    return 0;
                }
            }
            else //no neighbour
            {
                return 0;
            }
        }
        private int IsDownNeighbor(int x, int y)
        {
            int x1 = x + 1;
            int y1 = y;
            if (x1 < 10)
            {
                if (yourMap[x1, y1] == true) //check if neighbor has neighbor
                {
                    return 1 + IsDownNeighbor(x1, y1);
                }
                else //no neigbor
                {
                    return 0;
                }
            }
            else //no neighbor
            {
                return 0;
            }
        }
        private void DisableOrEnableAllCorners(Panel panel, int x, int y, bool trueOrFalse)
        {
            DisableOrEnableButtonIfExists(panel, x - 1, y - 1, trueOrFalse);
            DisableOrEnableButtonIfExists(panel, x - 1, y + 1, trueOrFalse);
            DisableOrEnableButtonIfExists(panel, x + 1, y + 1, trueOrFalse);
            DisableOrEnableButtonIfExists(panel, x + 1, y - 1, trueOrFalse);
        }
        bool Check1Masts()
        {
            int leftNo = 0;
            int rightNo = 0;
            int upNo = 0;
            int downNo = 0;

            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (yourMap[i, j] == true)
                    {
                        leftNo = IsLeftNeighbor(i, j);
                        rightNo = IsRightNeighbor(i, j);
                        upNo = IsUpNeighbor(i, j);
                        downNo = IsDownNeighbor(i, j);
                        if (leftNo == 0 && rightNo == 0 && downNo == 0 && upNo == 0)
                        {
                            yourMapTmp[i, j] = true;
                            counter++;
                        }
                        if (counter > 4) return false;
                    }

                }
            }
            if (counter < 4) return false;
            return true;
        }
        bool Check2Masts()
        {
            int leftNo = 0;
            int rightNo = 0;
            int upNo = 0;
            int downNo = 0;
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (yourMap[i, j] == true)
                    {
                        if (yourMapTmp[i, j] == true) continue;
                        downNo = IsDownNeighbor(i, j);
                        upNo = IsUpNeighbor(i, j);
                        if (downNo == 1 && upNo == 0)
                        {
                            yourMapTmp[i, j] = true;
                            yourMapTmp[i + 1, j] = true;
                            counter++;
                        }
                        else if (downNo == 0 && upNo == 0)
                        {
                            rightNo = IsRightNeighbor(i, j);
                            leftNo = IsLeftNeighbor(i, j);
                            if (rightNo == 1 && leftNo == 0)
                            {
                                yourMapTmp[i, j] = true;
                                yourMapTmp[i, j + 1] = true;
                                counter++;
                            }
                        }
                        if (counter > 3) return false;
                    }
                }
            }
            if (counter < 3) return false;
            return true;
        }
        bool Check3Masts()
        {
            int leftNo = 0;
            int rightNo = 0;
            int upNo = 0;
            int downNo = 0;
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (yourMap[i, j] == true)
                    {
                        if (yourMapTmp[i, j] == true) continue;
                        downNo = IsDownNeighbor(i, j);
                        upNo = IsUpNeighbor(i, j);
                        if (downNo == 2 && upNo == 0)
                        {
                            yourMapTmp[i, j] = true;
                            yourMapTmp[i + 1, j] = true;
                            yourMapTmp[i + 2, j] = true;
                            counter++;
                        }
                        else if (downNo == 0 && upNo == 0)
                        {
                            rightNo = IsRightNeighbor(i, j);
                            leftNo = IsLeftNeighbor(i, j);
                            if (rightNo == 2 && leftNo == 0)
                            {
                                yourMapTmp[i, j] = true;
                                yourMapTmp[i, j + 1] = true;
                                yourMapTmp[i, j + 2] = true;
                                counter++;
                            }
                        }
                        if (counter > 2) return false;
                    }
                }
            }
            if (counter < 2) return false;
            return true;
        }
        bool Check4Masts()
        {
            int leftNo = 0;
            int rightNo = 0;
            int upNo = 0;
            int downNo = 0;
            int counter = 0;
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (yourMap[i, j] == true)
                    {
                        if (yourMapTmp[i, j] == true) continue;
                        downNo = IsDownNeighbor(i, j);
                        upNo = IsUpNeighbor(i, j);
                        if (downNo == 3 && upNo == 0)
                        {
                            yourMapTmp[i, j] = true;
                            yourMapTmp[i + 1, j] = true;
                            yourMapTmp[i + 2, j] = true;
                            yourMapTmp[i + 3, j] = true;
                            counter++;
                        }
                        else if (downNo == 0 && upNo == 0)
                        {
                            rightNo = IsRightNeighbor(i, j);
                            leftNo = IsLeftNeighbor(i, j);
                            if (rightNo == 3 && leftNo == 0)
                            {
                                yourMapTmp[i, j] = true;
                                yourMapTmp[i, j + 1] = true;
                                yourMapTmp[i, j + 2] = true;
                                yourMapTmp[i, j + 3] = true;
                                counter++;
                            }
                        }
                        if (counter > 1) return false;
                    }
                }
            }
            if (counter < 1) return false;
            return true;
        }
        public void PrepareBattleField()
        {
            //Hide panel for setting masts
            pnlMatsSet.Visible = false;
            Panel matched = (Panel)this.Controls.Find("PYou", true).FirstOrDefault();
            matched.Visible = false;
            matched.Enabled = false;
            if (matched != null)
            {
                matched.Location = new Point(matched.Location.X - 164, matched.Location.Y);
            }
            matched.Visible = true;
            //for enemy
            GenerateMap("PEnemy", 360, 190);
            //Make visible mast tip panel
            pnlMatsSet.Visible = true;
            Array.Clear(yourMapTmp, 0, yourMapTmp.Length);
        }
        void playbuttonClick(object sender, EventArgs e)
        {
            clickedButton = (Button)sender;
            //check masts
            bool checkResult = false;
            Array.Clear(yourMapTmp, 0, yourMapTmp.Length);
            checkResult = Check1Masts();
            if (checkResult == false)
            {
                MessageBox.Show("You have set wrong number of 1-masts", "Error");
                return;
            }
            checkResult = Check2Masts();
            if (checkResult == false)
            {
                MessageBox.Show("You have set wrong number of 2-masts", "Error");
                return;
            }
            checkResult = Check3Masts();
            if (checkResult == false)
            {
                MessageBox.Show("You have set wrong number of 3-masts", "Error");
                return;
            }
            checkResult = Check4Masts();
            if (checkResult == false)
            {
                MessageBox.Show("You have set wrong number of 4-masts", "Error");
                return;
            }

            //Send StartGame communique
            char comm = (char)0;
            string message = comm + " " + Program.userLogin + " " + Program.enemyNick + " <EOF>";
            Program.client.Send(message);
            enemyGiveUpBeforeStart = true;
            //Receive answer in Program's thread
            clickedButton.Enabled = false;
        }
        public void GetShotAndResponse(int x, int y)
        {
            Button button;
            Panel panel = (Panel)this.Controls.Find("PYou", true).FirstOrDefault();
            button = (Button)panel.Controls.Find(x.ToString() + y.ToString(), true).FirstOrDefault();
            string message = "";
            
            if (yourMap[x, y] == true)
            {
                yourMapTmp[x, y] = true;

                
                masts--;

                
                button.BackColor = Color.Tomato;
                Application.DoEvents();
                if (masts == 0)
                {
                    Application.DoEvents();
                    return;
                }
                else
                {
                    
                    message = (char)5 + " " + enemyNick + " <EOF>";
                    Program.client.Send(message);
                    
                    ((Panel)this.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = false;
                }
            }
            else
            {
                message = (char)4 + " " + enemyNick + " <EOF>";
                Program.client.Send(message);
                button.BackColor = Color.Silver;
                
                ((Panel)this.Controls.Find("PEnemy", true).FirstOrDefault()).Enabled = true;
            }
            Application.DoEvents();
        }
        void setMastbuttonClick(object sender, EventArgs e)
        {
            var clickedButton = (Button)sender;
            int x = Int32.Parse(clickedButton.Name.Substring(0, 1)); 
            int y = Int32.Parse(clickedButton.Name.Substring(1, 1)); 
            int leftNo = IsLeftNeighbor(x, y);
            int rightNo = IsRightNeighbor(x, y);
            int upNo = IsUpNeighbor(x, y);
            int downNo = IsDownNeighbor(x, y);

            
            if (clickedButton.BackColor != Color.MediumBlue) 
            {
                
                if ((leftNo + rightNo < 4) && (upNo + downNo < 4))
                {
                    clickedButton.BackColor = Color.MediumBlue;
                    
                    selectedButtons.Add(clickedButton);
                    
                    DisableOrEnableAllCorners((Panel)clickedButton.Parent, x, y, false);
                    
                    yourMap[x, y] = true;
                }
            }
            else
            {
                clickedButton.BackColor = Color.Transparent;
               
                DisableOrEnableAllCorners((Panel)clickedButton.Parent, x, y, true);
                
                selectedButtons.Remove(clickedButton);
                
                foreach (Button btn in selectedButtons)
                {
                    DisableOrEnableAllCorners((Panel)btn.Parent, Int32.Parse(btn.Name[0].ToString()), Int32.Parse(btn.Name[1].ToString()), false);
                }
                
                yourMap[x, y] = false;
            }
            
        }
        void buttonClick(object sender, EventArgs e)
        {
            clickedButton = (Button)sender;
            clickedButton.Enabled = false;
            int x = Int32.Parse(clickedButton.Name.Substring(0, 1)); 
            int y = Int32.Parse(clickedButton.Name.Substring(1, 1)); 
            
            string message = "";
            message = (char)6 + " " + enemyNick + " " + x.ToString() + " " + y.ToString() + " <EOF>";
            Program.client.Send(message);
                  
        }

        private void Setup_Load(object sender, EventArgs e)
        {
            this.Text = "Battleship - you're playing with " + enemyNick;
            SetShips();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
