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
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            button1.Location = new Point(107, 249);
            button1.Name = "button1";
            button1.Size = new Size(157, 58);
            button1.TabIndex = 19;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
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
            compl_hard.CheckedChanged += compl_hard_CheckedChanged;
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
            compl_med.CheckedChanged += compl_med_CheckedChanged;
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
            compl_easy.CheckedChanged += compl_easy_CheckedChanged;
            // 
            // format_16
            // 
            format_16.AutoSize = true;
            format_16.Enabled = false;
            format_16.Font = new Font("Modern No. 20", 14.25F);
            format_16.Location = new Point(10, 73);
            format_16.Name = "format_16";
            format_16.Size = new Size(73, 25);
            format_16.TabIndex = 15;
            format_16.Text = "16x16";
            format_16.UseVisualStyleBackColor = true;
            format_16.CheckedChanged += format_16_CheckedChanged;
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
            format_9.CheckedChanged += format_9_CheckedChanged;
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
            format_4.CheckedChanged += format_4_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold);
            label3.Location = new Point(223, 67);
            label3.Name = "label3";
            label3.Size = new Size(137, 25);
            label3.TabIndex = 12;
            label3.Text = "Complexity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Modern No. 20", 17.9999981F, FontStyle.Bold);
            label2.Location = new Point(55, 67);
            label2.Name = "label2";
            label2.Size = new Size(95, 25);
            label2.TabIndex = 11;
            label2.Text = "Format:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Modern No. 20", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(65, 9);
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
            groupBox1.Location = new Point(55, 95);
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
            groupBox2.Location = new Point(223, 95);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(101, 104);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(384, 339);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "This is Sudoku!";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
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
    }
}
