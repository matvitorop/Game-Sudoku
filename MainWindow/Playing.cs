using Classes.CoR;
using Classes.Factory;
using Classes.Memento;
using Classes.MongoDB;
using Classes.SudokuTypes;
using Classes.Visitor;

namespace MainWindow
{
    public partial class Playing : Form
    {
        private readonly Form choosingForm;
        private readonly int size;
        private readonly Difficult difficulty;
        private readonly User currentUser;
        private readonly DatabaseManager? dbManager = DatabaseManager.Instance;
        private ISudokuFactory? sudokuFactory;
        private Sudoku sudoku;
        private Button[,] buttons;
        private readonly SudokuService? sudokuService = SudokuService.Instance;
        private readonly IVisitor visitor = new SudokuVisitor();
        private SudokuCaretaker sudokuSnapshots;

        public Playing(Form form, int size, Difficult difficulty, User currentUser)
        {
            InitializeComponent();

            choosingForm = form;
            this.size = size;
            this.difficulty = difficulty;
            this.currentUser = currentUser;

            InitializeFactoryChain();
            sudokuFactory = GetSudokuFactory(difficulty);

            InitializeSudoku();
            sudokuService.SetSudoku(sudoku);
            sudokuService.GenerateSudoku();

            sudokuSnapshots = new SudokuCaretaker(sudoku);
            buttons = new Button[size, size];
        }

        public Playing()
        {
            InitializeComponent();
        }

        private void Playing_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (choosingForm != null)
            {
                choosingForm.Show();
            }
        }

        private void InitializeFactoryChain()
        {
            BaseHandler factoryOne = new ReturnEasyFactory();
            BaseHandler factoryTwo = new ReturnNormalFactory();
            BaseHandler factoryThree = new ReturnHardFactory();

            factoryTwo.SetNextHandler(factoryThree);
            factoryOne.SetNextHandler(factoryTwo);
        }

        private ISudokuFactory? GetSudokuFactory(Difficult difficult)
        {
            BaseHandler factoryOne = new ReturnEasyFactory();
            BaseHandler factoryTwo = new ReturnNormalFactory();
            BaseHandler factoryThree = new ReturnHardFactory();

            factoryTwo.SetNextHandler(factoryThree);
            factoryOne.SetNextHandler(factoryTwo);

            return factoryOne.HandleRequest(difficult);
        }

        private void InitializeSudoku()
        {
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
                    throw new ArgumentException("Invalid sudoku size");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EnableButtons();
            sudoku.Accept(visitor);

            if (!IsValidSize(size))
            {
                MessageBox.Show("Wrong sudoku size");
                return;
            }

            InitializePlayground();
        }

        private void EnableButtons()
        {
            bt_backup.Enabled = true;
            bt_check.Enabled = true;
            bt_save.Enabled = true;
            bt_start.Enabled = false;
        }

        private bool IsValidSize(int size)
        {
            return size == 4 || size == 9 || size == 16;
        }

        private void InitializePlayground()
        {
            int buttonSize = 50;
            int spacing = 5;
            int windowSize = size * (buttonSize + spacing) + spacing;

            PositionButtons(windowSize);

            this.ClientSize = new Size(windowSize + 277, windowSize);

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    CreateSudokuButton(i, j, buttonSize, spacing);
                }
            }
        }

        private void PositionButtons(int windowSize)
        {
            bt_start.Location = new Point(windowSize + 15, 5);
            bt_check.Location = new Point(windowSize + 15, 5 + bt_start.Height + 5);
            bt_save.Location = new Point(windowSize + 15, 5 + bt_start.Height + 5 + bt_check.Height + 5);
            bt_backup.Location = new Point(windowSize + 15 + bt_start.Width + 5, 5);
        }

        private void CreateSudokuButton(int i, int j, int buttonSize, int spacing)
        {
            Button button = new Button
            {
                Size = new Size(buttonSize, buttonSize),
                Location = new Point(spacing + i * (buttonSize + spacing), spacing + j * (buttonSize + spacing)),
                Font = new Font("Modern No. 20", 14.25f)
            };

            buttons[i, j] = button;
            int x = i;
            int y = j;

            button.Text = sudokuService.GetSudokuNumber(x, y).ToString();
            button.BackColor = GetSquareColor(x, y, size);

            if (button.Text != "0")
            {
                button.Enabled = false;
            }
            else
            {
                button.ForeColor = Color.Blue;
                button.Click += (btnSender, btnEvent) => SudokuButtonClickHandler(btnSender, x, y);
            }

            this.Controls.Add(button);
        }

        private void SudokuButtonClickHandler(object sender, int x, int y)
        {
            Button button = (Button)sender;
            int currentValue = int.Parse(button.Text);
            int newValue = (currentValue % size) + 1;

            button.Text = newValue.ToString();
            sudokuService.SetSudokuNumber(x, y, newValue);
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
                MessageBox.Show("Save not found. Try to save again.");
            }
        }

        private void bt_check_Click(object sender, EventArgs e)
        {
            if (sudokuService.ValidateSudoku())
            {
                int score = CalculateScore();
                dbManager.UpdateScore(currentUser, score);

                MessageBox.Show("Victory");
                this.Close();
            }
            else
            {
                MessageBox.Show("Fail");
                this.Close();
            }
        }

        private int CalculateScore()
        {
            int score = 0;
            switch (difficulty)
            {
                case Difficult.Easy:
                    score += 4;
                    dbManager.UpdateHardSudoku(currentUser);
                    break;
                case Difficult.Normal:
                    score += 2;
                    dbManager.UpdateNormalSudoku(currentUser);
                    break;
                case Difficult.Hard:
                    score += 1;
                    dbManager.UpdateEasySudoku(currentUser);
                    break;
            }

            switch (size)
            {
                case 4:
                    score *= 150;
                    break;
                case 9:
                    score *= 400;
                    break;
                case 16:
                    score *= 1250;
                    break;
            }

            return score;
        }

        private Color GetSquareColor(int x, int y, int size)
        {
            int squareSize = (int)Math.Sqrt(size);
            int squareX = x / squareSize;
            int squareY = y / squareSize;

            return (squareX + squareY) % 2 == 0 ? Color.LightGray : Color.White;
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
