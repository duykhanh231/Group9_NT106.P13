namespace Client
{
    partial class Signup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Signup));
            lblUsername = new Label();
            lblPassword = new Label();
            lblConfirmPassword = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            btnSignup = new Button();
            SuspendLayout();
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold);
            lblUsername.ForeColor = Color.White;
            lblUsername.Location = new Point(176, 121);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(189, 60);
            lblUsername.TabIndex = 0;
            lblUsername.Text = "Moniker";
            // 
            // lblPassword
            // 
            lblPassword.AutoSize = true;
            lblPassword.BackColor = Color.Transparent;
            lblPassword.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold);
            lblPassword.ForeColor = Color.White;
            lblPassword.Location = new Point(176, 262);
            lblPassword.Name = "lblPassword";
            lblPassword.Size = new Size(212, 60);
            lblPassword.TabIndex = 1;
            lblPassword.Text = "Password";
            // 
            // lblConfirmPassword
            // 
            lblConfirmPassword.AutoSize = true;
            lblConfirmPassword.BackColor = Color.Transparent;
            lblConfirmPassword.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold);
            lblConfirmPassword.ForeColor = Color.White;
            lblConfirmPassword.Location = new Point(176, 383);
            lblConfirmPassword.Name = "lblConfirmPassword";
            lblConfirmPassword.Size = new Size(392, 60);
            lblConfirmPassword.TabIndex = 2;
            lblConfirmPassword.Text = "Confirm Password";
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold);
            textBox1.ForeColor = Color.Black;
            textBox1.Location = new Point(588, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(374, 67);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold);
            textBox2.ForeColor = Color.Black;
            textBox2.Location = new Point(588, 259);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(374, 67);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.BackColor = Color.White;
            textBox3.Font = new Font("Comic Sans MS", 16.125F, FontStyle.Bold);
            textBox3.ForeColor = Color.Black;
            textBox3.Location = new Point(588, 383);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(374, 67);
            textBox3.TabIndex = 5;
            // 
            // btnSignup
            // 
            btnSignup.BackColor = Color.MediumSeaGreen;
            btnSignup.FlatStyle = FlatStyle.Flat;
            btnSignup.Font = new Font("Comic Sans MS", 13.875F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSignup.ForeColor = Color.White;
            btnSignup.Location = new Point(495, 567);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(183, 69);
            btnSignup.TabIndex = 6;
            btnSignup.Text = "Sign up";
            btnSignup.UseVisualStyleBackColor = false;
            // 
            // Signup
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1162, 714);
            Controls.Add(btnSignup);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblConfirmPassword);
            Controls.Add(lblPassword);
            Controls.Add(lblUsername);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Signup";
            Text = "Signup";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblUsername;
        private Label lblPassword;
        private Label lblConfirmPassword;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button btnSignup;
    }
}