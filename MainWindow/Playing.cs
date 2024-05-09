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

        Form choosingForm;

        int size;
        string difficulty;

        ISudokuFactory sudokuFactory;

        Sudoku sudoku;

        BaseHandler factory_one = new ReturnEasyFactory();
        BaseHandler factory_two = new ReturnNormalFactory();
        BaseHandler factory_three = new ReturnHardFactory();

        Button[,] buttons;

        SudokuService sudokuService = SudokuService.Instance;

        IVisitor visitor = new SudokuVisitor();

        SudokuCaretaker sudokuSnapshots;
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
            //===============================Œ¡–Œ¡ ¿ –≈«”À‹“¿“”===============================
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Playing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (choosingForm != null)
            {
                bt_start.Enabled = true;
                choosingForm.Show();
            }
        }

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

            Color GetSquareColor(int x, int y, int size)
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
        }

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
