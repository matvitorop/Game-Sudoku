using MainWindow;
using Classes.MongoDB;
namespace ChoosingSudoku
{
    public partial class Form1 : Form
    {
        string difficulty = "";
        int size;
        User currentUser;
        Form loginForm;
        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form loginForm, User user)
        {
            InitializeComponent();
            this.loginForm = loginForm;
            this.currentUser = user;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //checking data and creating playground if variables are valid

            if (difficulty != "" && size != 0)
            {
                Playing playWindow = new Playing(this, size, difficulty);
                playWindow.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Choose size and complexity mode of sudoku", "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        //radiobuttons, that initializing variables for next window
        private void format_4_CheckedChanged(object sender, EventArgs e)
        {
            size = 4;
        }

        private void format_9_CheckedChanged(object sender, EventArgs e)
        {
            size = 9;
        }

        private void format_16_CheckedChanged(object sender, EventArgs e)
        {
            size = 16;
        }

        private void compl_easy_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = "easy";
        }

        private void compl_med_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = "normal";
        }

        private void compl_hard_CheckedChanged(object sender, EventArgs e)
        {
            difficulty = "hard";
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (loginForm != null)
            {
                loginForm.Show();
            }
        }
    }
}
