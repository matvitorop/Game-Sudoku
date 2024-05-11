namespace Login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lb_Welcome = new Label();
            lb_login = new Label();
            lb_password = new Label();
            tb_login = new TextBox();
            tb_password = new TextBox();
            bt_login = new Button();
            SuspendLayout();
            // 
            // lb_Welcome
            // 
            lb_Welcome.AutoSize = true;
            lb_Welcome.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lb_Welcome.Location = new Point(32, 24);
            lb_Welcome.Name = "lb_Welcome";
            lb_Welcome.Size = new Size(255, 29);
            lb_Welcome.TabIndex = 0;
            lb_Welcome.Text = "Welcome to Sudoku!";
            // 
            // lb_login
            // 
            lb_login.AutoSize = true;
            lb_login.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold);
            lb_login.Location = new Point(32, 95);
            lb_login.Name = "lb_login";
            lb_login.Size = new Size(126, 25);
            lb_login.TabIndex = 1;
            lb_login.Text = "Nickname:";
            // 
            // lb_password
            // 
            lb_password.AutoSize = true;
            lb_password.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold);
            lb_password.Location = new Point(32, 213);
            lb_password.Name = "lb_password";
            lb_password.Size = new Size(117, 25);
            lb_password.TabIndex = 2;
            lb_password.Text = "Password:";
            // 
            // tb_login
            // 
            tb_login.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            tb_login.Location = new Point(32, 138);
            tb_login.MaxLength = 18;
            tb_login.Name = "tb_login";
            tb_login.Size = new Size(266, 28);
            tb_login.TabIndex = 3;
            // 
            // tb_password
            // 
            tb_password.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            tb_password.Location = new Point(32, 256);
            tb_password.MaxLength = 18;
            tb_password.Name = "tb_password";
            tb_password.Size = new Size(266, 28);
            tb_password.TabIndex = 4;
            // 
            // bt_login
            // 
            bt_login.BackColor = Color.FromArgb(0, 192, 0);
            bt_login.FlatAppearance.BorderColor = Color.Black;
            bt_login.FlatAppearance.BorderSize = 3;
            bt_login.FlatStyle = FlatStyle.Popup;
            bt_login.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bt_login.Location = new Point(84, 317);
            bt_login.Name = "bt_login";
            bt_login.Size = new Size(160, 63);
            bt_login.TabIndex = 5;
            bt_login.Text = "Login";
            bt_login.UseVisualStyleBackColor = false;
            bt_login.Click += bt_login_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SteelBlue;
            ClientSize = new Size(327, 407);
            Controls.Add(bt_login);
            Controls.Add(tb_password);
            Controls.Add(tb_login);
            Controls.Add(lb_password);
            Controls.Add(lb_login);
            Controls.Add(lb_Welcome);
            Name = "Form1";
            Text = "This is Sudoku!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lb_Welcome;
        private Label lb_login;
        private Label lb_password;
        private TextBox tb_login;
        private TextBox tb_password;
        private Button bt_login;
    }
}
