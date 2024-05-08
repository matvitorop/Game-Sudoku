using MainWindow;
namespace ChoosingSudoku
{
    public partial class Form1 : Form
    {
        string difficulty = "";
        int size;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (difficulty!="" && size != 0)
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
    }
}
