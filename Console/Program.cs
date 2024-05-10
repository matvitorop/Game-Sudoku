using MongoDB.Driver;
using Classes;
using Classes.Factory;
using Classes.Visitor;
using Classes.SudokuTypes;
using Classes.Memento;
using System.Security.AccessControl;
using Classes.MongoDB;
//string connectionString = "mongodb://localhost:27017";
//
//var client = new MongoClient(connectionString);
//
//
//client?.Cluster?.Dispose();

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

//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        Console.Write(MediumSudoku.sudokuTable[i, j] + " ");
//    }
//    Console.WriteLine();
//}
//
////MediumSudoku.Accept(visitor);
//Console.WriteLine();
//
//
//if (generator.ValidateSudoku())
//{
//    Console.WriteLine("Ура");
//}
//else
//{
//    Console.WriteLine("Ну чому!");
//}
//
//MediumSudoku.Accept(visitor);
//for (int i = 0; i < 9; i++)
//{
//    for (int j = 0; j < 9; j++)
//    {
//        Console.Write(MediumSudoku.sudokuTable[i, j] + " ");
//    }
//    Console.WriteLine();
//}

//string connectionString = "mongodb://localhost:27017";
//
//var client = new MongoClient(connectionString);
//
//var db = client.GetDatabase("Sudoku-Users");
//
//var collection = db.GetCollection<User>("Users");
//
User user = new User
{
    Nickname = "AmateusXXX",
    Password = "password",
    HardSudokuCount = 5,
    MediumSudokuCount = 10,
    EasySudokuCount = 15,
    TotalScore = 5000
};
//
//collection.InsertOne(user);

var db = DatabaseManager.Instance;
db.InsertUser(user);

