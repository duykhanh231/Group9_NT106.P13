namespace BattleShipClient
{
    partial class SearchEnemies
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchEnemies));
            this.lblSearchEnemy = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.dgvAvailableEnemies = new System.Windows.Forms.DataGridView();
            this.IPAndPort = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EnemyNick = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableEnemies)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSearchEnemy
            // 
            this.lblSearchEnemy.AutoSize = true;
            this.lblSearchEnemy.Font = new System.Drawing.Font("Comic Sans MS", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchEnemy.ForeColor = System.Drawing.Color.White;
            this.lblSearchEnemy.Location = new System.Drawing.Point(440, 58);
            this.lblSearchEnemy.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSearchEnemy.Name = "lblSearchEnemy";
            this.lblSearchEnemy.Size = new System.Drawing.Size(311, 55);
            this.lblSearchEnemy.TabIndex = 2;
            this.lblSearchEnemy.Text = "Search enemy:";
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnConnect.Font = new System.Drawing.Font("Comic Sans MS", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnConnect.ForeColor = System.Drawing.Color.White;
            this.btnConnect.Location = new System.Drawing.Point(379, 657);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(468, 57);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Select this enemy and play";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // dgvAvailableEnemies
            // 
            this.dgvAvailableEnemies.AllowUserToAddRows = false;
            this.dgvAvailableEnemies.AllowUserToDeleteRows = false;
            this.dgvAvailableEnemies.AllowUserToResizeRows = false;
            this.dgvAvailableEnemies.BackgroundColor = System.Drawing.Color.SteelBlue;
            this.dgvAvailableEnemies.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAvailableEnemies.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAvailableEnemies.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAvailableEnemies.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IPAndPort,
            this.EnemyNick});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAvailableEnemies.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAvailableEnemies.Location = new System.Drawing.Point(152, 153);
            this.dgvAvailableEnemies.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAvailableEnemies.MultiSelect = false;
            this.dgvAvailableEnemies.Name = "dgvAvailableEnemies";
            this.dgvAvailableEnemies.ReadOnly = true;
            this.dgvAvailableEnemies.RowHeadersVisible = false;
            this.dgvAvailableEnemies.RowHeadersWidth = 62;
            this.dgvAvailableEnemies.Size = new System.Drawing.Size(947, 466);
            this.dgvAvailableEnemies.TabIndex = 7;
            this.dgvAvailableEnemies.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVAvailableEnemies_CellClick);
            // 
            // IPAndPort
            // 
            this.IPAndPort.HeaderText = "IPAndPort";
            this.IPAndPort.MinimumWidth = 8;
            this.IPAndPort.Name = "IPAndPort";
            this.IPAndPort.ReadOnly = true;
            this.IPAndPort.Visible = false;
            this.IPAndPort.Width = 150;
            // 
            // EnemyNick
            // 
            this.EnemyNick.HeaderText = "Enemy nick";
            this.EnemyNick.MinimumWidth = 8;
            this.EnemyNick.Name = "EnemyNick";
            this.EnemyNick.ReadOnly = true;
            this.EnemyNick.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.EnemyNick.Width = 249;
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(800, 55);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearch.MaxLength = 16;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(299, 58);
            this.txtSearch.TabIndex = 8;
            this.txtSearch.TextChanged += new System.EventHandler(this.SearchEnemy);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1246, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 46);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SearchEnemies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1300, 800);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dgvAvailableEnemies);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblSearchEnemy);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "SearchEnemies";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Battleship - enemy selection";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CloseApp);
            this.Load += new System.EventHandler(this.EnemySelectionPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAvailableEnemies)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSearchEnemy;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.DataGridViewTextBoxColumn IPAndPort;
        private System.Windows.Forms.DataGridViewTextBoxColumn EnemyNick;
        private System.Windows.Forms.TextBox txtSearch;
        public System.Windows.Forms.DataGridView dgvAvailableEnemies;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}