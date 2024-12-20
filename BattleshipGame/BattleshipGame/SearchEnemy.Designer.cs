namespace Client
{
    partial class SearchEnemy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEnemy));
            pictureBox1 = new PictureBox();
            listView1 = new ListView();
            panel1 = new Panel();
            lblEnemy = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
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
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // listView1
            // 
            listView1.BackColor = SystemColors.ActiveCaption;
            listView1.Font = new Font("Comic Sans MS", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            listView1.ForeColor = Color.White;
            listView1.Location = new Point(194, 312);
            listView1.Name = "listView1";
            listView1.Size = new Size(1864, 833);
            listView1.TabIndex = 7;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(lblEnemy);
            panel1.Location = new Point(194, 211);
            panel1.Name = "panel1";
            panel1.Size = new Size(1864, 119);
            panel1.TabIndex = 8;
            // 
            // lblEnemy
            // 
            lblEnemy.AutoSize = true;
            lblEnemy.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnemy.ForeColor = Color.White;
            lblEnemy.Location = new Point(676, 24);
            lblEnemy.Name = "lblEnemy";
            lblEnemy.Size = new Size(559, 74);
            lblEnemy.TabIndex = 0;
            lblEnemy.Text = "FIND YOUR ENEMY";
            // 
            // SearchEnemy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2260, 1226);
            Controls.Add(panel1);
            Controls.Add(listView1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchEnemy";
            Text = "Search Enemy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ListView listView1;
        private Panel panel1;
        private Label lblEnemy;
    }
}