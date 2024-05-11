using MainWindow;
using Classes.MongoDB;
using System.Windows.Forms;
namespace ChoosingSudoku
{
    public partial class Form1 : Form
    {
        string difficulty = "";
        int size;

        User currentUser;
        Form loginForm;
        List<User> users;
        DatabaseManager dbMenager;

        public Form1()
        {
            InitializeComponent();
        }
        public Form1(Form loginForm, User user)
        {
            InitializeComponent();
            dbMenager = DatabaseManager.Instance;
            this.loginForm = loginForm;
            this.currentUser = user;

            lb_NicknameRes.Text = currentUser.Nickname;
            lb_EasySudokuRes.Text = currentUser.EasySudokuCount.ToString();
            lb_NormalSudokuRes.Text = currentUser.NormalSudokuCount.ToString();
            lb_HardSudokuRes.Text = currentUser.HardSudokuCount.ToString();
            lb_scoreRes.Text = currentUser.TotalScore.ToString();

            users = dbMenager.GetAllUsersWithoutPassword();
            
            if (users != null)
            {
                dgw_Users.DataSource = users;
                dgw_Users.Columns["Id"].Visible = false;
                dgw_Users.Columns["Password"].Visible = false;
                dgw_Users.Columns["HardSudokuCount"].Visible = false;
                dgw_Users.Columns["NormalSudokuCount"].Visible = false;
                dgw_Users.Columns["EasySudokuCount"].Visible = false;
            }
            
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

        private void dgw_Users_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                // getting object from list
                User selectedUser = users[e.RowIndex];

                // printing data to datagrid
                MessageBox.Show($"Nickname: {selectedUser.Nickname}\n" +
                                $"Hard Sudoku Count: {selectedUser.HardSudokuCount}\n" +
                                $"Medium Sudoku Count: {selectedUser.NormalSudokuCount}\n" +
                                $"Easy Sudoku Count: {selectedUser.EasySudokuCount}\n" +
                                $"Total Score: {selectedUser.TotalScore}",
                                "User",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
        }
    }
}
