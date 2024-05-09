using System.Windows.Forms;
using Classes;
using Classes.CoR;
using Classes.Factory;
using Classes.Memento;
using Classes.SudokuTypes;
using Classes.Visitor;
namespace MainWindow
{
    public partial class Playing : Form
    {
        //ÃŒ∆Õ¿ «¿—“Œ—”¬¿“» ≤“≈–¿“Œ–

        //fields for stable work and oprimizing by different pattern
        
        Form choosingForm; //previous form

        //variables for generating factory and size of sudoku
        int size; 
        string difficulty;

        //factory
        ISudokuFactory sudokuFactory;

        //current sudoku
        Sudoku sudoku;

        //CoR for creating factory
        BaseHandler factory_one = new ReturnEasyFactory();
        BaseHandler factory_two = new ReturnNormalFactory();
        BaseHandler factory_three = new ReturnHardFactory();

        //array for playground
        Button[,] buttons;

        //sudoku menager
        SudokuService sudokuService = SudokuService.Instance;

        //visitor for prepearing sudoku before a game
        IVisitor visitor = new SudokuVisitor();

        //sudoku snapshots caretaker
        SudokuCaretaker sudokuSnapshots;

        //initializing variables
        public Playing(Form form, int size, string difficulty)
        {
            InitializeComponent();

            choosingForm = form;

            this.size = size;
            this.difficulty = difficulty;

            factory_two.SetNextHandler(factory_three);
            factory_one.SetNextHandler(factory_two);

            sudokuFactory = factory_one.HandleRequest(difficulty);

            //===================================ÃŒ∆À»¬¿ «¿Ã≤Õ¿===================================
            switch (size)
            {
                case 4:
                    sudoku = sudokuFactory.CreateSmallSudoku();
                    break;
                case 9:
                    sudoku = sudokuFactory.CreateMediumSudoku();
                    break;
                case 16:
                    sudoku = sudokuFactory.CreateBigSudoku();
                    break;

                default:
                    break;
            }

            sudokuService.SetSudoku(sudoku);
            sudokuService.GenerateSudoku();

            sudokuSnapshots = new SudokuCaretaker(sudoku);

            buttons = new Button[size, size];
        }
        public Playing()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (sudokuService.ValidateSudoku())
            {
                MessageBox.Show("œÂÂÏÓ„‡");
            }
            else
            {
                MessageBox.Show("œÓ‡ÁÍ‡");
            }
            //===============================œŒ“–≤¡Õ¿ Œ¡–Œ¡ ¿ –≈«”À‹“¿“”===============================
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //
        //}
        //action for closing window
        private void Playing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (choosingForm != null)
            {
                bt_start.Enabled = true;
                choosingForm.Show();
            }
        }
        
        //generating playground of buttons, that containing numbers and event
        private void button4_Click(object sender, EventArgs e)
        {
            bt_backup.Enabled = true;
            bt_check.Enabled = true;
            bt_save.Enabled = true;
            //===============================ÃŒ∆À»¬»… –≈‘¿ “Œ–»Õ√===============================
            bt_start.Enabled = false;
            sudoku.Accept(visitor);

            int gridSize = size;
            if (gridSize != 4 && gridSize != 9 && gridSize != 16)
            {
                MessageBox.Show("ÕÂ‚≥ÌËÈ ÓÁÏ≥ ÒÛ‰ÓÍÛ.");
                return;
            }

            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    Button button = new Button();
                    buttons[i, j] = button;
                    button.Size = new Size(50, 50);
                    button.Location = new Point(i * 50, j * 50);
                    int x = i;
                    int y = j;

                    button.Text = sudokuService.GetSudokuNumber(x, y).ToString();

                    Font buttonFont = new Font("Modern No. 20", 14.25f);
                    button.Font = buttonFont;

                    Color squareColor = GetSquareColor(x, y, size);
                    button.BackColor = squareColor;


                    if (button.Text != "0")
                    {
                        button.Enabled = false;
                    }
                    else
                    {
                        button.ForeColor = Color.Blue;
                        //Font buttonFont = new Font("Modern No. 20", 14.25f);
                        //button.Font = buttonFont;
                    }

                    button.Click += (btnSender, btnEvent) =>
                    {
                        int currentValue = int.Parse(((Button)btnSender).Text);

                        int newValue = (currentValue % size) + 1;

                        ((Button)btnSender).Text = newValue.ToString();

                        sudokuService.setSudokuNumber(x, y, newValue);
                    };

                    this.Controls.Add(button);
                }
            }
        }
        //buttons for backups
        private void bt_save_Click(object sender, EventArgs e)
        {
            sudokuSnapshots.SaveBackup();
        }

        private void bt_backup_Click(object sender, EventArgs e)
        {
            if (sudokuSnapshots.Restore())
            {
                UpdateGridFromSnapshot();
            }
            else
            {
                MessageBox.Show("¬≥‰ÒÛÚÌ≥ Á·ÂÂÊÂÌÌˇ");
            }
        }

        //methods for intermediate results and actions
        private Color GetSquareColor(int x, int y, int size)
        {
            int squareSize = (int)Math.Sqrt(size);

            int squareX = x / squareSize;
            int squareY = y / squareSize;

            if ((squareX + squareY) % 2 == 0)
            {
                return Color.LightGray;
            }
            else
            {
                return Color.White;
            }
        }

        private void UpdateGridFromSnapshot()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    buttons[i, j].Text = sudokuService.GetSudokuNumber(i, j).ToString();
                }
            }
        }
    }
}
