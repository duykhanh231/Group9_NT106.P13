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
            pictureBox1.Location = new Point(1347, 8);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 38);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SteelBlue;
            panel1.Controls.Add(lblEnemy);
            panel1.Location = new Point(119, 132);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1147, 74);
            panel1.TabIndex = 8;
            // 
            // lblEnemy
            // 
            lblEnemy.AutoSize = true;
            lblEnemy.Font = new Font("Comic Sans MS", 19.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEnemy.ForeColor = Color.White;
            lblEnemy.Location = new Point(416, 15);
            lblEnemy.Margin = new Padding(2, 0, 2, 0);
            lblEnemy.Name = "lblEnemy";
            lblEnemy.Size = new Size(361, 48);
            lblEnemy.TabIndex = 0;
            lblEnemy.Text = "FIND YOUR ENEMY";
            // 
            // dgvAvailableEnemies
            // 
            dgvAvailableEnemies.AllowUserToAddRows = false;
            dgvAvailableEnemies.AllowUserToDeleteRows = false;
            dgvAvailableEnemies.AllowUserToResizeRows = false;
            dgvAvailableEnemies.BackgroundColor = Color.White;
            dgvAvailableEnemies.BorderStyle = BorderStyle.Fixed3D;
            dgvAvailableEnemies.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAvailableEnemies.Location = new Point(119, 202);
            dgvAvailableEnemies.Margin = new Padding(2);
            dgvAvailableEnemies.MultiSelect = false;
            dgvAvailableEnemies.Name = "dgvAvailableEnemies";
            dgvAvailableEnemies.ReadOnly = true;
            dgvAvailableEnemies.RowHeadersVisible = false;
            dgvAvailableEnemies.RowHeadersWidth = 82;
            dgvAvailableEnemies.Size = new Size(1147, 462);
            dgvAvailableEnemies.TabIndex = 7;
            dgvAvailableEnemies.CellContentClick += dgvAvailableEnemies_CellContentClick;
            // 
            // btnConnect
            // 
            btnConnect.BackColor = Color.MediumSeaGreen;
            btnConnect.FlatStyle = FlatStyle.Flat;
            btnConnect.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConnect.ForeColor = Color.White;
            btnConnect.Location = new Point(501, 692);
            btnConnect.Margin = new Padding(2);
            btnConnect.Name = "btnConnect";
            btnConnect.Size = new Size(402, 51);
            btnConnect.TabIndex = 10;
            btnConnect.Text = "Select this enemy and Play!";
            btnConnect.UseVisualStyleBackColor = false;
            // 
            // txtSearchEnemies
            // 
            txtSearchEnemies.BackColor = Color.White;
            txtSearchEnemies.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtSearchEnemies.ForeColor = Color.Black;
            txtSearchEnemies.Location = new Point(1031, 55);
            txtSearchEnemies.Margin = new Padding(2);
            txtSearchEnemies.Name = "txtSearchEnemies";
            txtSearchEnemies.Size = new Size(237, 45);
            txtSearchEnemies.TabIndex = 11;
            txtSearchEnemies.TextChanged += SearchEnemies;
            // 
            // lblSearchEnemies
            // 
            lblSearchEnemies.AutoSize = true;
            lblSearchEnemies.BackColor = Color.Transparent;
            lblSearchEnemies.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSearchEnemies.ForeColor = Color.White;
            lblSearchEnemies.Location = new Point(903, 57);
            lblSearchEnemies.Margin = new Padding(2, 0, 2, 0);
            lblSearchEnemies.Name = "lblSearchEnemies";
            lblSearchEnemies.Size = new Size(121, 38);
            lblSearchEnemies.TabIndex = 12;
            lblSearchEnemies.Text = "Search:";
            lblSearchEnemies.Click += lblSearchEnemies_Click;
            // 
            // SearchEnemy
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1393, 689);
            Controls.Add(lblSearchEnemies);
            Controls.Add(txtSearchEnemies);
            Controls.Add(btnConnect);
            Controls.Add(dgvAvailableEnemies);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "SearchEnemy";
            Text = "Search Enemy";
            Load += SearchEnemy_Load_1;
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
        private Button btnConnect;
        private TextBox txtSearchEnemies;
        private Label lblSearchEnemies;
        public DataGridView dgvAvailableEnemies;
    }
}