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
            SuspendLayout();
            // 
            // AccountName
            // 
            AccountName.AutoSize = true;
            AccountName.BackColor = Color.Transparent;
            AccountName.Font = new Font("Snap ITC", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            AccountName.ForeColor = Color.DarkGoldenrod;
            AccountName.Location = new Point(12, 103);
            AccountName.Name = "AccountName";
            AccountName.Size = new Size(330, 44);
            AccountName.TabIndex = 0;
            AccountName.Text = "Băng Hải Tặc : ";
            // 
            // tb_Accountname
            // 
            tb_Accountname.BackColor = SystemColors.ButtonFace;
            tb_Accountname.BorderStyle = BorderStyle.None;
            tb_Accountname.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
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
            serverIP.Font = new Font("Snap ITC", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            serverIP.ForeColor = Color.DarkGoldenrod;
            serverIP.Location = new Point(12, 184);
            serverIP.Name = "serverIP";
            serverIP.Size = new Size(386, 36);
            serverIP.TabIndex = 2;
            serverIP.Text = "Tọa Độ ( ServerIP ) : ";
            // 
            // tb_serverIP
            // 
            tb_serverIP.BackColor = SystemColors.ButtonFace;
            tb_serverIP.BorderStyle = BorderStyle.None;
            tb_serverIP.Font = new Font("Arial", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_serverIP.Location = new Point(413, 172);
            tb_serverIP.Multiline = true;
            tb_serverIP.Name = "tb_serverIP";
            tb_serverIP.Size = new Size(327, 48);
            tb_serverIP.TabIndex = 3;
            // 
            // btn_connect
            // 
            btn_connect.BackColor = SystemColors.ActiveCaption;
            btn_connect.Font = new Font("Snap ITC", 16.2F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btn_connect.Location = new Point(107, 298);
            btn_connect.Name = "btn_connect";
            btn_connect.Size = new Size(159, 68);
            btn_connect.TabIndex = 4;
            btn_connect.Text = "Let Go";
            btn_connect.UseVisualStyleBackColor = false;
            btn_connect.Click += btn_connect_Click;
            // 
            // Welcome
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1391, 766);
            Controls.Add(btn_connect);
            Controls.Add(tb_serverIP);
            Controls.Add(serverIP);
            Controls.Add(tb_Accountname);
            Controls.Add(AccountName);
            Name = "Welcome";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label AccountName;
        private TextBox tb_Accountname;
        private Label serverIP;
        private TextBox tb_serverIP;
        private Button btn_connect;
    }
}