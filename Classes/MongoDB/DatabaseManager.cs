using Classes.SudokuTypes;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.MongoDB
{
    public class DatabaseManager
    {
        private static DatabaseManager _instance;
        
        private readonly IMongoCollection<User> usersCollection;

        private DatabaseManager()
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("Sudoku-Users");

            
            usersCollection = database.GetCollection<User>("Users");
        }

        public static DatabaseManager Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DatabaseManager();
                }
                return _instance;
            }
        }

        public User AddOrGetUser(User user)
        {
            var filterByUsername = Builders<User>.Filter.Eq(u => u.Nickname, user.Nickname);
            var existingUser = usersCollection.Find(filterByUsername).FirstOrDefault();

            if (existingUser != null)
            {
                if (existingUser.Password == user.Password)
                {
                    return existingUser;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                usersCollection.InsertOne(user);
                return user;
            }
        }

        public void UpdateScore(User user, int value)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Nickname, user.Nickname);

            var update = Builders<User>
                .Update
                .Inc(a => a.TotalScore, value);

            usersCollection.UpdateOne(filter, update);
        }

        public void UpdateEasySudoku(User user)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Nickname, user.Nickname);

            var update = Builders<User>
                .Update
                .Inc(a => a.EasySudokuCount, 1);

            usersCollection.UpdateOne(filter, update);
        }

        public void UpdateNormalSudoku(User user)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Nickname, user.Nickname);

            var update = Builders<User>
                .Update
                .Inc(a => a.MediumSudokuCount, 1);

            usersCollection.UpdateOne(filter, update);
        }

        public void UpdateHardSudoku(User user)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Nickname, user.Nickname);

            var update = Builders<User>
                .Update
                .Inc(a => a.HardSudokuCount, 1);

            usersCollection.UpdateOne(filter, update);
        }




        //=========================МОЖЛИВЕ ВИДАЛЕННЯ=========================
        public User FindUser(string nickname)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Nickname, nickname);
            return usersCollection.Find(filter).FirstOrDefault();
        }
    }
}
