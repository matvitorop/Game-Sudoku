using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;

namespace Classes.MongoDB
{
    public class User
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }

        [BsonElement("Nickname")]
        public string Nickname { get; set; }

        [BsonElement("Password")]
        public string Password { get; set; }

        [BsonElement("HardSudokuCount")]
        public int HardSudokuCount { get; set; }

        [BsonElement("MediumSudokuCount")]
        public int MediumSudokuCount { get; set; }

        [BsonElement("EasySudokuCount")]
        public int EasySudokuCount { get; set; }

        [BsonElement("TotalScore")]
        public int TotalScore { get; set; }

    }
}
