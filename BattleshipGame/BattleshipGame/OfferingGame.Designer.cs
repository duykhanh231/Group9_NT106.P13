namespace Client
{
    partial class OfferingGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OfferingGame));
            lblGameRequest = new Label();
            pictureBox1 = new PictureBox();
            accept = new Button();
            decline = new Button();
            pictureBox2 = new PictureBox();
            enemies = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblGameRequest
            // 
            lblGameRequest.AutoSize = true;
            lblGameRequest.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameRequest.ForeColor = Color.White;
            lblGameRequest.Location = new Point(26, 161);
            lblGameRequest.Margin = new Padding(2, 0, 2, 0);
            lblGameRequest.Name = "lblGameRequest";
            lblGameRequest.Size = new Size(480, 41);
            lblGameRequest.TabIndex = 0;
            lblGameRequest.Text = "You have a game request from:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(321, 46);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(104, 101);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // accept
            // 
            accept.BackColor = Color.MediumSeaGreen;
            accept.FlatStyle = FlatStyle.Flat;
            accept.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            accept.ForeColor = Color.White;
            accept.Location = new Point(233, 282);
            accept.Margin = new Padding(2);
            accept.Name = "accept";
            accept.Size = new Size(109, 46);
            accept.TabIndex = 3;
            accept.Text = "Accept";
            accept.UseVisualStyleBackColor = false;
            accept.Click += accept_Click;
            // 
            // decline
            // 
            decline.BackColor = Color.IndianRed;
            decline.FlatStyle = FlatStyle.Flat;
            decline.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            decline.ForeColor = Color.White;
            decline.Location = new Point(402, 282);
            decline.Margin = new Padding(2);
            decline.Name = "decline";
            decline.Size = new Size(109, 46);
            decline.TabIndex = 4;
            decline.Text = "Decline";
            decline.UseVisualStyleBackColor = false;
            decline.Click += Decline_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.SteelBlue;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(687, 8);
            pictureBox2.Margin = new Padding(2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 38);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // enemies
            // 
            enemies.FormattingEnabled = true;
            enemies.Location = new Point(511, 174);
            enemies.Name = "enemies";
            enemies.Size = new Size(207, 28);
            enemies.TabIndex = 8;
            // 
            // OfferingGame
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(730, 418);
            Controls.Add(enemies);
            Controls.Add(pictureBox2);
            Controls.Add(decline);
            Controls.Add(accept);
            Controls.Add(pictureBox1);
            Controls.Add(lblGameRequest);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "OfferingGame";
            Text = "OfferingGame";
            Load += OfferingGame_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGameRequest;
        private PictureBox pictureBox1;
        private Button accept;
        private Button decline;
        private PictureBox pictureBox2;
        private ComboBox enemies;
    }
}