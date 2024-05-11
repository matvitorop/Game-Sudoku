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




//User user = new User
//{
//    Nickname = "AmateusXXX",
//    Password = "password"
//};
////
////collection.InsertOne(user);
//
//var db = DatabaseManager.Instance;
//User currUser = db.AddOrGetUser(user);
//
//if(currUser == null)
//{
//    Console.WriteLine("Невiрний пароль");
//}
//else
//{
//    Console.WriteLine($"{currUser.Nickname}");
//}
//
//
//
//
//db.UpdateEasySudoku(currUser);
//db.UpdateNormalSudoku(currUser);
//db.UpdateHardSudoku(currUser);