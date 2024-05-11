namespace MainWindow
{
    partial class Playing
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
            bt_backup = new Button();
            bt_save = new Button();
            bt_check = new Button();
            bt_start = new Button();
            SuspendLayout();
            // 
            // bt_backup
            // 
            bt_backup.Enabled = false;
            bt_backup.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            bt_backup.Location = new Point(187, 39);
            bt_backup.Name = "bt_backup";
            bt_backup.Size = new Size(120, 165);
            bt_backup.TabIndex = 0;
            bt_backup.Text = "Back to the save";
            bt_backup.UseVisualStyleBackColor = true;
            bt_backup.Click += bt_backup_Click;
            // 
            // bt_save
            // 
            bt_save.Enabled = false;
            bt_save.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            bt_save.Location = new Point(63, 96);
            bt_save.Name = "bt_save";
            bt_save.Size = new Size(118, 51);
            bt_save.TabIndex = 1;
            bt_save.Text = "Save";
            bt_save.UseVisualStyleBackColor = true;
            bt_save.Click += bt_save_Click;
            // 
            // bt_check
            // 
            bt_check.Enabled = false;
            bt_check.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            bt_check.Location = new Point(63, 153);
            bt_check.Name = "bt_check";
            bt_check.Size = new Size(118, 51);
            bt_check.TabIndex = 2;
            bt_check.Text = "Finish (check)";
            bt_check.UseVisualStyleBackColor = true;
            bt_check.Click += bt_check_Click;
            // 
            // bt_start
            // 
            bt_start.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            bt_start.Location = new Point(63, 39);
            bt_start.Name = "bt_start";
            bt_start.Size = new Size(118, 51);
            bt_start.TabIndex = 3;
            bt_start.Text = "Start";
            bt_start.UseVisualStyleBackColor = true;
            bt_start.Click += button4_Click;
            // 
            // Playing
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkGoldenrod;
            ClientSize = new Size(370, 253);
            Controls.Add(bt_start);
            Controls.Add(bt_check);
            Controls.Add(bt_save);
            Controls.Add(bt_backup);
            Name = "Playing";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "This is Sudoku!";
            FormClosing += Playing_FormClosing;
            ResumeLayout(false);
        }

        #endregion

        private Button bt_backup;
        private Button bt_save;
        private Button bt_check;
        private Button bt_start;
    }
}
