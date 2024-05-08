using System.Windows.Forms;
namespace MainWindow
{
    public partial class Playing : Form
    {
        Form choosingForm;
        public Playing(Form form)
        {
            InitializeComponent();
            choosingForm = form;
        }
        public Playing()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Playing_Load(object sender, EventArgs e)
        {

        }

        private void Playing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (choosingForm != null)
            {
                choosingForm.Show();
            }
        }

        private void Playing_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
