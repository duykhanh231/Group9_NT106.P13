namespace BattleshipGame
{
    partial class Welcome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            AccountName = new Label();
            tb_Accountname = new TextBox();
            serverIP = new Label();
            tb_serverIP = new TextBox();
            btn_connect = new Button();
            pictureBox1 = new PictureBox();
            btnSignup = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // AccountName
            // 
            AccountName.AutoSize = true;
            AccountName.BackColor = Color.Transparent;
            AccountName.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountName.ForeColor = Color.Snow;
            AccountName.Location = new Point(49, 101);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(164, 48);
            AccountName.TabIndex = 0;
            AccountName.Text = "Moniker:";
            // 
            // tb_Accountname
            // 
            tb_Accountname.BackColor = SystemColors.ButtonFace;
            tb_Accountname.BorderStyle = BorderStyle.None;
            tb_Accountname.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_Accountname.Location = new Point(413, 96);
            tb_Accountname.Multiline = true;
            tb_Accountname.Name = "tb_Accountname";
            tb_Accountname.Size = new Size(327, 51);
            tb_Accountname.TabIndex = 1;
            // 
            // serverIP
            // 
            serverIP.AutoSize = true;
            serverIP.BackColor = Color.Transparent;
            serverIP.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serverIP.ForeColor = Color.Snow;
            serverIP.Location = new Point(49, 182);
            serverIP.Name = "serverIP";
            serverIP.Size = new Size(198, 48);
            serverIP.TabIndex = 2;
            serverIP.Text = "Server IP:";
            // 
            // tb_serverIP
            // 
            tb_serverIP.BackColor = SystemColors.ButtonFace;
            tb_serverIP.BorderStyle = BorderStyle.None;
            tb_serverIP.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_serverIP.Location = new Point(413, 172);
            tb_serverIP.Multiline = true;
            tb_serverIP.Name = "tb_serverIP";
            tb_serverIP.Size = new Size(327, 48);
            tb_serverIP.TabIndex = 3;
            // 
            // btn_connect
            // 
            btn_connect.BackColor = Color.SteelBlue;
            btn_connect.FlatStyle = FlatStyle.Flat;
            btn_connect.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_connect.ForeColor = Color.Snow;
            btn_connect.Location = new Point(413, 314);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(159, 68);
            btn_connect.TabIndex = 4;
            btn_connect.Text = "Let Go!";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.Control;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1347, 8);
            pictureBox1.Margin = new Padding(2, 2, 2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.MediumSeaGreen;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(598, 314);
            btnSignup.Margin = new Padding(2, 2, 2, 2);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(142, 68);
            btnSignup.TabIndex = 6;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            btnSignup.Click += btnSignup_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SteelBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1148, 11);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1195, 689);
            Controls.Add(pictureBox2);
            Controls.Add(btnSignup);
            Controls.Add(pictureBox1);
            Controls.Add(btn_connect);
            Controls.Add(tb_serverIP);
            Controls.Add(serverIP);
            Controls.Add(tb_Accountname);
            Controls.Add(AccountName);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AccountName;
        private TextBox tb_Accountname;
        private Label serverIP;
        private TextBox tb_serverIP;
        private Button btn_connect;
        private PictureBox pictureBox1;
        private Button btnSignup;
        private PictureBox pictureBox2;
    }
}