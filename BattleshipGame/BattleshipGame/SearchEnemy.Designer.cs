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
            panel1 = new Panel();
            lblEnemy = new Label();
            dgvAvailableEnemies = new DataGridView();
            btnConnect = new Button();
            txtSearchEnemies = new TextBox();
            lblSearchEnemies = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableEnemies).BeginInit();
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
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
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
            // dgvAvailableEnemies
            // 
            dgvAvailableEnemies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableEnemies.Location = new Point(194, 323);
            dgvAvailableEnemies.Name = "dgvAvailableEnemies";
            dgvAvailableEnemies.RowHeadersWidth = 82;
            dgvAvailableEnemies.Size = new Size(1864, 740);
            dgvAvailableEnemies.TabIndex = 9;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.MediumSeaGreen;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(814, 1108);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(653, 81);
            btnConnect.TabIndex = 10;
            btnConnect.Text = "Select this enemy and Play!";
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // txtSearchEnemies
            // 
            txtSearchEnemies.BackColor = Color.SteelBlue;
            txtSearchEnemies.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchEnemies.ForeColor = Color.White;
            txtSearchEnemies.Location = new Point(1676, 88);
            txtSearchEnemies.Name = "txtSearchEnemies";
            txtSearchEnemies.Size = new Size(382, 67);
            txtSearchEnemies.TabIndex = 11;
            txtSearchEnemies.TextChanged += SearchEnemies;
            // 
            // lblSearchEnemies
            // 
            lblSearchEnemies.AutoSize = true;
            lblSearchEnemies.BackColor = Color.SteelBlue;
            lblSearchEnemies.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchEnemies.ForeColor = Color.White;
            lblSearchEnemies.Location = new Point(1467, 91);
            lblSearchEnemies.Name = "lblSearchEnemies";
            lblSearchEnemies.Size = new Size(171, 60);
            lblSearchEnemies.TabIndex = 12;
            lblSearchEnemies.Text = "Search";
            // 
            // SearchEnemy
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(2260, 1226);
            Controls.Add(lblSearchEnemies);
            Controls.Add(txtSearchEnemies);
            Controls.Add(btnConnect);
            Controls.Add(dgvAvailableEnemies);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SearchEnemy";
            Text = "Search Enemy";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvAvailableEnemies).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label lblEnemy;
        private DataGridView dgvAvailableEnemies;
        private Button btnConnect;
        private TextBox txtSearchEnemies;
        private Label lblSearchEnemies;
    }
}