using System.Windows.Forms;
using Classes;
using Classes.CoR;
using Classes.Factory;
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
        public Playing(Form form, int size, string difficulty)
        {
            InitializeComponent();

            choosingForm = form;
            
            this.size = size;
            this.difficulty = difficulty;
            
            factory_two.SetNextHandler(factory_three);
            factory_one.SetNextHandler(factory_two);

            sudokuFactory = factory_one.HandleRequest(difficulty);

            switch (size)
            {
                case 4:
                    sudoku = sudokuFactory.CreateSmallSudoku();
                    break;
                case 9:
                    sudoku = sudokuFactory.CreateMediumSudoku();
                    break;
                case 16:
                    sudoku = sudokuFactory.CreateMediumSudoku();
                    break;

                default:
                    break;
            }

            sudokuService.SetSudoku(sudoku);
            sudokuService.GenerateSudoku();

            buttons = new Button[size, size];
        }
        public Playing()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sudoku.Accept(visitor);

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    Button button = new Button();
                    buttons[i,j] = button;
                    button.Size = new Size(50, 50);
                    button.Text = sudokuService.GetSudokuNumber(i,j).ToString();
                    button.Location = new Point(i*50, j*50);
                    this.Controls.Add(button);
                }
                
            }
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
