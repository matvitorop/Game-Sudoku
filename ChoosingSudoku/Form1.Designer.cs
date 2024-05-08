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
            radioButton4 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(128, 255, 128);
            button1.Font = new Font("Modern No. 20", 14.25F, FontStyle.Bold);
            button1.Location = new Point(100, 249);
            button1.Name = "button1";
            button1.Size = new Size(157, 58);
            button1.TabIndex = 19;
            button1.Text = "Play";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Font = new Font("Modern No. 20", 14.25F);
            radioButton4.Location = new Point(223, 197);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(68, 25);
            radioButton4.TabIndex = 18;
            radioButton4.TabStop = true;
            radioButton4.Text = "Hard";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Font = new Font("Modern No. 20", 14.25F);
            radioButton5.Location = new Point(223, 152);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(86, 25);
            radioButton5.TabIndex = 17;
            radioButton5.TabStop = true;
            radioButton5.Text = "Normal";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Font = new Font("Modern No. 20", 14.25F);
            radioButton6.Location = new Point(223, 107);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(66, 25);
            radioButton6.TabIndex = 16;
            radioButton6.TabStop = true;
            radioButton6.Text = "Easy";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Font = new Font("Modern No. 20", 14.25F);
            radioButton3.Location = new Point(39, 197);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(73, 25);
            radioButton3.TabIndex = 15;
            radioButton3.TabStop = true;
            radioButton3.Text = "16x16";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Font = new Font("Modern No. 20", 14.25F);
            radioButton2.Location = new Point(39, 152);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(55, 25);
            radioButton2.TabIndex = 14;
            radioButton2.TabStop = true;
            radioButton2.Text = "9x9";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Font = new Font("Modern No. 20", 14.25F);
            radioButton1.Location = new Point(39, 107);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(55, 25);
            radioButton1.TabIndex = 13;
            radioButton1.TabStop = true;
            radioButton1.Text = "4x4";
            radioButton1.UseVisualStyleBackColor = true;
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
            label2.Location = new Point(39, 67);
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Highlight;
            ClientSize = new Size(384, 339);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton5);
            Controls.Add(radioButton6);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "This is Sudoku!";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private RadioButton radioButton4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}
