using ChoosingSudoku;
using Classes.MongoDB;

namespace Login
{
    public partial class Form1 : Form
    {
        private readonly DatabaseManager _dbManager;

        public Form1()
        {
            InitializeComponent();
            _dbManager = DatabaseManager.Instance;
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            string login = tb_login.Text.Trim();
            string password = tb_password.Text.Trim();

            if (IsValidLoginInput(login, password))
            {
                User user = new User
                {
                    Nickname = login,
                    Password = password
                };

                User currentUser = _dbManager.AddOrGetUser(user);
                if (currentUser != null)
                {
                    OpenSudokuForm(currentUser);
                }
                else
                {
                    ShowErrorMessage("Wrong password");
                }
            }
            else
            {
                ShowErrorMessage("Enter login and password");
            }
        }

        private bool IsValidLoginInput(string login, string password)
        {
            return !string.IsNullOrEmpty(login) && !string.IsNullOrEmpty(password);
        }

        private void OpenSudokuForm(User currentUser)
        {
            ChoosingSudoku.Form1 chooseSudokuForm = new ChoosingSudoku.Form1(this, currentUser);
            this.Hide();
            ClearLoginForm();
            chooseSudokuForm.Show();
        }

        private void ClearLoginForm()
        {
            tb_login.Text = string.Empty;
            tb_password.Text = string.Empty;
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message);
        }
    }
}
