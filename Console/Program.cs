using MongoDB.Driver;
using Classes;
using Classes.Factory;
using Classes.Visitor;
using Classes.SudokuTypes;
using Classes.Memento;
using System.Security.AccessControl;
//string connectionString = "mongodb://localhost:27017";
//
//var client = new MongoClient(connectionString);
//
//
//client?.Cluster?.Dispose();

// ================ SUDOKU GENERATOR ================

//Random random = new Random();
//
//int[,] sudoku = new int[9,9]; 
//
//bool IsValidInsert(int[,] sudoku, int row, int col, int num)
//{
//    for (int i = 0; i<9; i++)
//    {
//        if (sudoku[row, i] == num || sudoku[i,col] == num)
//        {
//            return false;
//        }
//    }
//
//    int startRow = row / 3 * 3;
//    int startCol = col / 3 * 3;
//
//    for(int i = startRow; i<startRow+3; i++)
//    {
//        for (int j = startCol; i < startCol + 3; i++)
//        {
//            if (sudoku[startRow, startCol] == num)
//            {
//                return false ;
//            }
//        }
//    }
//
//    return true;
//}
//
//void FillFirstRow(int[,] sudoku)
//{
//    List<int> numbers = new List<int>() { 1,2,3,4,5,6,7,8,9 };
//    Shuffle(numbers);
//    
//    for (int i = 0; i < 9; i++)
//    {
//        sudoku[0, i] = numbers[i];
//    }
//
//}
//
//void Shuffle<T>(List<T> list)
//{
//    int n = list.Count; 
//    while (n > 1)
//    {
//        n--;
//        int k = random.Next(n+1);
//        T value = list[k];
//        list[k] = list[n];
//        list[n] = value;
//    }
//}
//bool FillRemaining(int[,] sudoku)
//{
//    int row = -1;
//    int col = -0;
//    bool isEmpty = true;
//
//    for(int i = 0; i<9; i++)
//    {
//        for (int j = 0; j < 9; j++)
//        {
//            if (sudoku[i, j] == 0)
//            {
//                isEmpty = false;
//                row = i;
//                col = j;
//                break;
//            }
//        }
//        if (!isEmpty)
//        {
//            break;
//        }
//    }
//
//    if (isEmpty)
//    {
//        return true;
//    }
//    List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
//
//    Shuffle(numbers);
//
//    foreach (int i in numbers)
//    {
//        if(IsValidInsert(sudoku, row, col, i))
//        {
//            sudoku[row, col] = i;
//            if (FillRemaining(sudoku))
//            {
//                return true ;
//            }
//            sudoku[row, col] = 0;
//        }
//    }
//    return false;
//}
//
//
//int[,] GenerateSudoku()
//{
//    int[,] sudoku = new int[9, 9];
//
//    FillFirstRow(sudoku);
//    FillRemaining(sudoku);
//
//    return sudoku;
//}
//
//int[,] sudokuBoard = GenerateSudoku();


//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        Console.Write(sudokuBoard[i, j] + " ");
//    }
//    Console.WriteLine();
//}


//Sudoku big = new SudokuBig(10);
//Sudoku sm = new SudokuSmall(10);
//Sudoku med = new SudokuMedium(10);
//med.GenerateSudoku();
//big.GenerateSudoku();
//sm.GenerateSudoku();

//for (int i = 0; i < 16; i++)
//{
//    for (int j = 0; j < 16; j++)
//    {
//        Console.Write(big.sudokuTable[i, j] + " ");
//    }
//    Console.WriteLine();
//}



//==================================ТЕСТУВАННЯ ФАБРИКИ СУДОКУ ЗА СКЛАДНІСТЮ (МАЛО ЧИ БАГАТО КЛІТИНОК ЗАПОВНЕНО)==================================
ISudokuFactory fabrick = new NormalFactory();
var newSudoku = fabrick.CreateMediumSudoku();

ISudokuFactory second_fabrick = new HardFactory();
var hardSudoku = second_fabrick.CreateMediumSudoku();
//==================================СТВОРЕННЯ VISITOR ДЛЯ ПІДГОТОВКИ СУДОКУ ДЛЯ ГРИ==================================
IVisitor visitor = new SudokuVisitor();
newSudoku.Accept(visitor);
var MediumSudoku = fabrick.CreateMediumSudoku();

//==================================ТЕСТУВАННЯ ЗБЕРІГАННЯ СНАПШОТІВ СТАНУ СУДОКУ==================================
SudokuCaretaker caretaker = new SudokuCaretaker(MediumSudoku);
caretaker.SaveBackup();

//==================================ТЕСТУВАННЯ ОДИНАКА-ГЕНЕРАТОРА СУДОКУ==================================
var generator = SudokuService.Instance;

generator.SetSudoku(MediumSudoku);
generator.GenerateSudoku();

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(MediumSudoku.sudokuTable[i, j] + " ");
    }
    Console.WriteLine();
}

MediumSudoku.Accept(visitor);
Console.WriteLine();

for (int i = 0; i < 9; i++)
{
    for (int j = 0; j < 9; j++)
    {
        Console.Write(MediumSudoku.sudokuTable[i, j] + " ");
    }
    Console.WriteLine();
}





