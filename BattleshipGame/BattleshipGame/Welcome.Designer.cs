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
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AccountName
            // 
            AccountName.AutoSize = true;
            AccountName.BackColor = Color.Transparent;
            AccountName.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AccountName.ForeColor = Color.Snow;
            AccountName.Location = new Point(79, 162);
            AccountName.Margin = new Padding(5, 0, 5, 0);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(257, 74);
            AccountName.TabIndex = 0;
            AccountName.Text = "Moniker:";
            // 
            // tb_Accountname
            // 
            tb_Accountname.BackColor = SystemColors.ButtonFace;
            tb_Accountname.BorderStyle = BorderStyle.None;
            tb_Accountname.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_Accountname.Location = new Point(671, 154);
            tb_Accountname.Margin = new Padding(5);
            tb_Accountname.Multiline = true;
            tb_Accountname.Name = "tb_Accountname";
            tb_Accountname.Size = new Size(531, 82);
            tb_Accountname.TabIndex = 1;
            // 
            // serverIP
            // 
            serverIP.AutoSize = true;
            serverIP.BackColor = Color.Transparent;
            serverIP.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            serverIP.ForeColor = Color.Snow;
            serverIP.Location = new Point(79, 291);
            serverIP.Margin = new Padding(5, 0, 5, 0);
            serverIP.Name = "serverIP";
            serverIP.Size = new Size(331, 74);
            serverIP.TabIndex = 2;
            serverIP.Text = "Server IP: ";
            // 
            // tb_serverIP
            // 
            tb_serverIP.BackColor = SystemColors.ButtonFace;
            tb_serverIP.BorderStyle = BorderStyle.None;
            tb_serverIP.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tb_serverIP.Location = new Point(671, 275);
            tb_serverIP.Margin = new Padding(5);
            tb_serverIP.Multiline = true;
            tb_serverIP.Name = "tb_serverIP";
            tb_serverIP.Size = new Size(531, 77);
            tb_serverIP.TabIndex = 3;
            // 
            // btn_connect
            // 
            btn_connect.BackColor = Color.SteelBlue;
            btn_connect.FlatStyle = FlatStyle.Flat;
            btn_connect.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_connect.ForeColor = Color.Snow;
            btn_connect.Location = new Point(671, 503);
            btn_connect.Margin = new Padding(5);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(258, 109);
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
            pictureBox1.Location = new Point(2189, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(59, 61);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2260, 1226);
            Controls.Add(pictureBox1);
            Controls.Add(btn_connect);
            Controls.Add(tb_serverIP);
            Controls.Add(serverIP);
            Controls.Add(tb_Accountname);
            Controls.Add(AccountName);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(5);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
    }
}