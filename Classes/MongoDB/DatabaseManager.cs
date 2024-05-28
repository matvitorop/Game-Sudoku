using MongoDB.Driver;

namespace Classes.MongoDB
{
    public class DatabaseManager
    {
        //singleton db connection
        private static DatabaseManager? _instance;
        
        private readonly IMongoCollection<User> _usersCollection;

        //connecting
        private DatabaseManager()
        {
            string connectionString = "mongodb://localhost:27017";
            MongoClient client = new MongoClient(connectionString);
            IMongoDatabase database = client.GetDatabase("Sudoku-Users");

            
            _usersCollection = database.GetCollection<User>("Users");
        }
        //current Manager
        public static DatabaseManager? Instance
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
        //function for SIMPLE authorization 
        public User AddOrGetUser(User user)
        {
            var filterByUsername = Builders<User>.Filter.Eq(u => u.Nickname, user.Nickname);
            var existingUser = _usersCollection.Find(filterByUsername).FirstOrDefault();

            if (existingUser != null)
            {
                if (existingUser.Password == user.Password)
                {
                    return existingUser;
                }

                return null;
            }

            _usersCollection.InsertOne(user);
            return user;
        }
        //getting all users without password
        public List<User> GetAllUsersWithoutPassword()
        {
            var projection = Builders<User>.Projection.Exclude(u => u.Password);
            var allUsers = _usersCollection.Find(_ => true).Project<User>(projection).ToList();
            return allUsers;
        }

        private FilterDefinition<User> GetUserByFilter(User user)
        {
            return Builders<User>.Filter.Eq(u => u.Nickname, user.Nickname);
        }


        //updating fields
        public void UpdateScore(User user, int value)
        {
            var filter = GetUserByFilter(user);

            var update = Builders<User>
                .Update
                .Inc(a => a.TotalScore, value);

            _usersCollection.UpdateOne(filter, update);
        }

        public void UpdateEasySudoku(User user)
        {
            var filter = GetUserByFilter(user);

            var update = Builders<User>
                .Update
                .Inc(a => a.EasySudokuCount, 1);

            _usersCollection.UpdateOne(filter, update);
        }

        public void UpdateNormalSudoku(User user)
        {
            var filter = GetUserByFilter(user);

            var update = Builders<User>
                .Update
                .Inc(a => a.NormalSudokuCount, 1);

            _usersCollection.UpdateOne(filter, update);
        }

        public void UpdateHardSudoku(User user)
        {
            var filter = GetUserByFilter(user);

            var update = Builders<User>
                .Update
                .Inc(a => a.HardSudokuCount, 1);

            _usersCollection.UpdateOne(filter, update);
        }
    }
}
