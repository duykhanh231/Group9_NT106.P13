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
            lblRequester = new Label();
            pictureBox1 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // lblGameRequest
            // 
            lblGameRequest.AutoSize = true;
            lblGameRequest.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblGameRequest.ForeColor = Color.White;
            lblGameRequest.Location = new Point(42, 258);
            lblGameRequest.Name = "lblGameRequest";
            lblGameRequest.Size = new Size(766, 67);
            lblGameRequest.TabIndex = 0;
            lblGameRequest.Text = "You have a game request from:";
            // 
            // lblRequester
            // 
            lblRequester.AutoSize = true;
            lblRequester.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRequester.ForeColor = Color.White;
            lblRequester.Location = new Point(829, 258);
            lblRequester.Name = "lblRequester";
            lblRequester.Size = new Size(314, 67);
            lblRequester.TabIndex = 1;
            lblRequester.Text = "lblRequester";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(521, 74);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(169, 161);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.LightSeaGreen;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(378, 451);
            button1.Name = "button1";
            button1.Size = new Size(177, 74);
            button1.TabIndex = 3;
            button1.Text = "Accept";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.IndianRed;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(653, 451);
            button2.Name = "button2";
            button2.Size = new Size(177, 74);
            button2.TabIndex = 4;
            button2.Text = "Decline";
            button2.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ActiveCaption;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(1116, 12);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(59, 61);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // OfferingGame
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaption;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1187, 669);
            Controls.Add(pictureBox2);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox1);
            Controls.Add(lblRequester);
            Controls.Add(lblGameRequest);
            FormBorderStyle = FormBorderStyle.None;
            Name = "OfferingGame";
            Text = "OfferingGame";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblGameRequest;
        private Label lblRequester;
        private PictureBox pictureBox1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox2;
    }
}