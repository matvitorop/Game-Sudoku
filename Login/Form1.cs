using ChoosingSudoku;
using Classes.MongoDB;
namespace Login
{
    public partial class Form1 : Form
    {
        DatabaseManager dbMenager;
        public Form1()
        {
            InitializeComponent();
            dbMenager = DatabaseManager.Instance;
        }

        private void bt_login_Click(object sender, EventArgs e)
        {
            if(tb_login.Text!="" && tb_password.Text != "")
            {
                User user = new User
                {
                    Nickname = tb_login.Text,
                    Password = tb_password.Text
                };

                var currentUser = dbMenager.AddOrGetUser(user);
                if (currentUser != null)
                {
                    ChoosingSudoku.Form1 chooseSudokuForm = new ChoosingSudoku.Form1(this, currentUser);
                    this.Hide();
                    tb_login.Text = "";
                    tb_password.Text = "";
                    chooseSudokuForm.Show();

                }
                else
                {
                    MessageBox.Show($"Невірний пароль");
                }
            }
        }
    }
}
