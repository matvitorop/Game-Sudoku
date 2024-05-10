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

        public void InsertUser(User user)
        {
            usersCollection.InsertOne(user);
        }

        public void UpdateUser(User user)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Id, user.Id);
            usersCollection.ReplaceOne(filter, user);
        }

        public User FindUser(string nickname)
        {
            var filter = Builders<User>.Filter.Eq(u => u.Nickname, nickname);
            return usersCollection.Find(filter).FirstOrDefault();
        }
    }
}
