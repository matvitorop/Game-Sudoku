namespace ChoosingSudoku
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
            button1 = new Button();
            compl_hard = new RadioButton();
            compl_med = new RadioButton();
            compl_easy = new RadioButton();
            format_16 = new RadioButton();
            format_9 = new RadioButton();
            format_4 = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            lb_usersScore = new Label();
            dgw_Users = new DataGridView();
            lb_UserScore = new Label();
            lb_nickname = new Label();
            lb_EasySudoku = new Label();
            lb_NormalSudoku = new Label();
            lb_HardSudoku = new Label();
            lb_score = new Label();
            lb_scoreRes = new Label();
            lb_HardSudokuRes = new Label();
            lb_NormalSudokuRes = new Label();
            lb_EasySudokuRes = new Label();
            lb_NicknameRes = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Users).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(0, 192, 0);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            button1.Location = new Point(88, 218);
            button1.Name = "button1";
            button1.Size = new Size(157, 58);
            button1.TabIndex = 19;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            button1.Click += OnStartButtonClick;
            // 
            // compl_hard
            // 
            compl_hard.AutoSize = true;
            compl_hard.Font = new Font("Modern No. 20", 14.25F);
            compl_hard.Location = new Point(6, 75);
            compl_hard.Name = "compl_hard";
            compl_hard.Size = new Size(68, 25);
            compl_hard.TabIndex = 18;
            compl_hard.Text = "Hard";
            compl_hard.UseVisualStyleBackColor = true;
            compl_hard.CheckedChanged += OnDifficultyCheckedChanged;
            // 
            // compl_med
            // 
            compl_med.AutoSize = true;
            compl_med.Font = new Font("Modern No. 20", 14.25F);
            compl_med.Location = new Point(6, 44);
            compl_med.Name = "compl_med";
            compl_med.Size = new Size(86, 25);
            compl_med.TabIndex = 17;
            compl_med.Text = "Normal";
            compl_med.UseVisualStyleBackColor = true;
            compl_med.CheckedChanged += OnDifficultyCheckedChanged;
            // 
            // compl_easy
            // 
            compl_easy.AutoSize = true;
            compl_easy.Font = new Font("Modern No. 20", 14.25F);
            compl_easy.Location = new Point(6, 13);
            compl_easy.Name = "compl_easy";
            compl_easy.Size = new Size(66, 25);
            compl_easy.TabIndex = 16;
            compl_easy.Text = "Easy";
            compl_easy.UseVisualStyleBackColor = true;
            compl_easy.CheckedChanged += OnDifficultyCheckedChanged;
            // 
            // format_16
            // 
            format_16.AutoSize = true;
            format_16.Font = new Font("Modern No. 20", 14.25F);
            format_16.Location = new Point(10, 73);
            format_16.Name = "format_16";
            format_16.Size = new Size(73, 25);
            format_16.TabIndex = 15;
            format_16.Text = "16x16";
            format_16.UseVisualStyleBackColor = true;
            format_16.CheckedChanged += OnSizeCheckedChanged;
            // 
            // format_9
            // 
            format_9.AutoSize = true;
            format_9.Font = new Font("Modern No. 20", 14.25F);
            format_9.Location = new Point(10, 43);
            format_9.Name = "format_9";
            format_9.Size = new Size(55, 25);
            format_9.TabIndex = 14;
            format_9.Text = "9x9";
            format_9.UseVisualStyleBackColor = true;
            format_9.CheckedChanged += OnSizeCheckedChanged;
            // 
            // format_4
            // 
            format_4.AutoSize = true;
            format_4.Font = new Font("Modern No. 20", 14.25F);
            format_4.Location = new Point(10, 12);
            format_4.Name = "format_4";
            format_4.Size = new Size(55, 25);
            format_4.TabIndex = 13;
            format_4.Text = "4x4";
            format_4.UseVisualStyleBackColor = true;
            format_4.CheckedChanged += OnSizeCheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Underline);
            label3.Location = new Point(189, 67);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 12;
            label3.Text = "Complexity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold | FontStyle.Underline);
            label2.Location = new Point(35, 67);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 11;
            label2.Text = "Format:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 9);
            label1.Name = "label1";
            label1.Size = new Size(246, 29);
            label1.TabIndex = 10;
            label1.Text = "Choose your sudoku";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(format_4);
            groupBox1.Controls.Add(format_9);
            groupBox1.Controls.Add(format_16);
            groupBox1.Location = new Point(35, 95);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(101, 104);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(compl_easy);
            groupBox2.Controls.Add(compl_med);
            groupBox2.Controls.Add(compl_hard);
            groupBox2.Location = new Point(194, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(101, 104);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // lb_usersScore
            // 
            lb_usersScore.AutoSize = true;
            lb_usersScore.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lb_usersScore.Location = new Point(786, 9);
            lb_usersScore.Name = "lb_usersScore";
            lb_usersScore.Size = new Size(170, 29);
            lb_usersScore.TabIndex = 22;
            lb_usersScore.Text = "Players score";
            // 
            // dgw_Users
            // 
            dgw_Users.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgw_Users.BackgroundColor = SystemColors.ActiveCaption;
            dgw_Users.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgw_Users.Location = new Point(714, 49);
            dgw_Users.Name = "dgw_Users";
            dgw_Users.Size = new Size(308, 227);
            dgw_Users.TabIndex = 23;
            dgw_Users.CellContentClick += OnUserCellContentClick;
            // 
            // lb_UserScore
            // 
            lb_UserScore.AutoSize = true;
            lb_UserScore.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            lb_UserScore.Location = new Point(415, 9);
            lb_UserScore.Name = "lb_UserScore";
            lb_UserScore.Size = new Size(149, 29);
            lb_UserScore.TabIndex = 24;
            lb_UserScore.Text = "Your score:";
            // 
            // lb_nickname
            // 
            lb_nickname.AutoSize = true;
            lb_nickname.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            lb_nickname.Location = new Point(385, 58);
            lb_nickname.Name = "lb_nickname";
            lb_nickname.Size = new Size(101, 21);
            lb_nickname.TabIndex = 25;
            lb_nickname.Text = "Nickname:";
            // 
            // lb_EasySudoku
            // 
            lb_EasySudoku.AutoSize = true;
            lb_EasySudoku.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            lb_EasySudoku.Location = new Point(385, 95);
            lb_EasySudoku.Name = "lb_EasySudoku";
            lb_EasySudoku.Size = new Size(127, 21);
            lb_EasySudoku.TabIndex = 26;
            lb_EasySudoku.Text = "Easy Sudoku:";
            // 
            // lb_NormalSudoku
            // 
            lb_NormalSudoku.AutoSize = true;
            lb_NormalSudoku.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            lb_NormalSudoku.Location = new Point(385, 138);
            lb_NormalSudoku.Name = "lb_NormalSudoku";
            lb_NormalSudoku.Size = new Size(149, 21);
            lb_NormalSudoku.TabIndex = 27;
            lb_NormalSudoku.Text = "Normal Sudoku:";
            // 
            // lb_HardSudoku
            // 
            lb_HardSudoku.AutoSize = true;
            lb_HardSudoku.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            lb_HardSudoku.Location = new Point(385, 184);
            lb_HardSudoku.Name = "lb_HardSudoku";
            lb_HardSudoku.Size = new Size(129, 21);
            lb_HardSudoku.TabIndex = 28;
            lb_HardSudoku.Text = "Hard Sudoku:";
            // 
            // lb_score
            // 
            lb_score.AutoSize = true;
            lb_score.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            lb_score.Location = new Point(385, 232);
            lb_score.Name = "lb_score";
            lb_score.Size = new Size(115, 21);
            lb_score.TabIndex = 29;
            lb_score.Text = "Total Score:";
            // 
            // lb_scoreRes
            // 
            lb_scoreRes.AutoSize = true;
            lb_scoreRes.Font = new Font("Modern No. 20", 14.25F);
            lb_scoreRes.ForeColor = SystemColors.ControlLightLight;
            lb_scoreRes.Location = new Point(540, 236);
            lb_scoreRes.Name = "lb_scoreRes";
            lb_scoreRes.Size = new Size(19, 21);
            lb_scoreRes.TabIndex = 34;
            lb_scoreRes.Text = "5";
            // 
            // lb_HardSudokuRes
            // 
            lb_HardSudokuRes.AutoSize = true;
            lb_HardSudokuRes.Font = new Font("Modern No. 20", 14.25F);
            lb_HardSudokuRes.ForeColor = SystemColors.ControlLightLight;
            lb_HardSudokuRes.Location = new Point(540, 188);
            lb_HardSudokuRes.Name = "lb_HardSudokuRes";
            lb_HardSudokuRes.Size = new Size(19, 21);
            lb_HardSudokuRes.TabIndex = 33;
            lb_HardSudokuRes.Text = "4";
            // 
            // lb_NormalSudokuRes
            // 
            lb_NormalSudokuRes.AutoSize = true;
            lb_NormalSudokuRes.Font = new Font("Modern No. 20", 14.25F);
            lb_NormalSudokuRes.ForeColor = SystemColors.ControlLightLight;
            lb_NormalSudokuRes.Location = new Point(540, 142);
            lb_NormalSudokuRes.Name = "lb_NormalSudokuRes";
            lb_NormalSudokuRes.Size = new Size(19, 21);
            lb_NormalSudokuRes.TabIndex = 32;
            lb_NormalSudokuRes.Text = "3";
            // 
            // lb_EasySudokuRes
            // 
            lb_EasySudokuRes.AutoSize = true;
            lb_EasySudokuRes.Font = new Font("Modern No. 20", 14.25F);
            lb_EasySudokuRes.ForeColor = SystemColors.ControlLightLight;
            lb_EasySudokuRes.Location = new Point(540, 99);
            lb_EasySudokuRes.Name = "lb_EasySudokuRes";
            lb_EasySudokuRes.Size = new Size(19, 21);
            lb_EasySudokuRes.TabIndex = 31;
            lb_EasySudokuRes.Text = "2";
            // 
            // lb_NicknameRes
            // 
            lb_NicknameRes.AutoSize = true;
            lb_NicknameRes.Font = new Font("Modern No. 20", 14.25F);
            lb_NicknameRes.ForeColor = SystemColors.ControlLightLight;
            lb_NicknameRes.Location = new Point(540, 62);
            lb_NicknameRes.Name = "lb_NicknameRes";
            lb_NicknameRes.Size = new Size(19, 21);
            lb_NicknameRes.TabIndex = 30;
            lb_NicknameRes.Text = "1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.RoyalBlue;
            ClientSize = new Size(1045, 297);
            Controls.Add(lb_scoreRes);
            Controls.Add(lb_HardSudokuRes);
            Controls.Add(lb_NormalSudokuRes);
            Controls.Add(lb_EasySudokuRes);
            Controls.Add(lb_NicknameRes);
            Controls.Add(lb_score);
            Controls.Add(lb_HardSudoku);
            Controls.Add(lb_NormalSudoku);
            Controls.Add(lb_EasySudoku);
            Controls.Add(lb_nickname);
            Controls.Add(lb_UserScore);
            Controls.Add(dgw_Users);
            Controls.Add(lb_usersScore);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "This is Sudoku!";
            FormClosing += OnFormClosing;
            VisibleChanged += OnVisibleChanged;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgw_Users).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton compl_hard;
        private RadioButton compl_med;
        private RadioButton compl_easy;
        private RadioButton format_16;
        private RadioButton format_9;
        private RadioButton format_4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label lb_usersScore;
        private DataGridView dgw_Users;
        private Label lb_UserScore;
        private Label lb_nickname;
        private Label lb_EasySudoku;
        private Label lb_NormalSudoku;
        private Label lb_HardSudoku;
        private Label lb_score;
        private Label lb_scoreRes;
        private Label lb_HardSudokuRes;
        private Label lb_NormalSudokuRes;
        private Label lb_EasySudokuRes;
        private Label lb_NicknameRes;
    }
}
