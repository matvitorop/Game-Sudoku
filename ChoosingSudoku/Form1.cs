using MainWindow;
using Classes.MongoDB;
using System.Windows.Forms;

namespace ChoosingSudoku
{
    public partial class Form1 : Form
    {
        private string _difficulty = "";
        private int _size;

        private User _currentUser;
        private Form _loginForm;
        private List<User> _users;
        private readonly DatabaseManager _dbManager;

        public Form1()
        {
            InitializeComponent();
            _dbManager = DatabaseManager.Instance;
        }

        public Form1(Form loginForm, User user) : this()
        {
            _loginForm = loginForm;
            _currentUser = user;
            UpdateUsers();
        }

        private void OnStartButtonClick(object sender, EventArgs e)
        {
            if (IsValidSelection())
            {
                var playWindow = new Playing(this, _size, _difficulty, _currentUser);
                playWindow.Show();
                Hide();
            }
            else
            {
                ShowWarning("Choose size and complexity mode of sudoku");
            }
        }

        private bool IsValidSelection()
        {
            return !string.IsNullOrEmpty(_difficulty) && _size != 0;
        }

        private void ShowWarning(string message)
        {
            MessageBox.Show(message, "Попередження", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void OnSizeCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                _size = int.Parse(radioButton.Tag.ToString());
            }
        }

        private void OnDifficultyCheckedChanged(object sender, EventArgs e)
        {
            if (sender is RadioButton radioButton && radioButton.Checked)
            {
                _difficulty = radioButton.Tag.ToString();
            }
        }

        private void OnFormClosing(object sender, FormClosingEventArgs e)
        {
            _loginForm?.Show();
        }

        private void OnUserCellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var selectedUser = _users[e.RowIndex];
                ShowUserDetails(selectedUser);
            }
        }

        private void ShowUserDetails(User user)
        {
            var message = $"Nickname: {user.Nickname}\n" +
                          $"Hard Sudoku Count: {user.HardSudokuCount}\n" +
                          $"Medium Sudoku Count: {user.NormalSudokuCount}\n" +
                          $"Easy Sudoku Count: {user.EasySudokuCount}\n" +
                          $"Total Score: {user.TotalScore}";
            MessageBox.Show(message, "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void OnVisibleChanged(object sender, EventArgs e)
        {
            UpdateUsers();
        }

        private void UpdateUsers()
        {
            _currentUser = _dbManager.AddOrGetUser(_currentUser);

            UpdateUserDetails(_currentUser);

            _users = _dbManager.GetAllUsersWithoutPassword();
            UpdateUserGrid(_users);
        }

        private void UpdateUserDetails(User user)
        {
            lb_NicknameRes.Text = user.Nickname;
            lb_EasySudokuRes.Text = user.EasySudokuCount.ToString();
            lb_NormalSudokuRes.Text = user.NormalSudokuCount.ToString();
            lb_HardSudokuRes.Text = user.HardSudokuCount.ToString();
            lb_scoreRes.Text = user.TotalScore.ToString();
        }

        private void UpdateUserGrid(List<User> users)
        {
            if (users != null)
            {
                dgw_Users.DataSource = users;
                HideUnnecessaryColumns(dgw_Users);
            }
        }

        private void HideUnnecessaryColumns(DataGridView dataGridView)
        {
            dataGridView.Columns["Id"].Visible = false;
            dataGridView.Columns["Password"].Visible = false;
            dataGridView.Columns["HardSudokuCount"].Visible = false;
            dataGridView.Columns["NormalSudokuCount"].Visible = false;
            dataGridView.Columns["EasySudokuCount"].Visible = false;
        }
    }
}
