using System.Data;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;
namespace api_web.Models
{
    public class Student
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        [BsonElement("_id")]
        public string Id { get; set; } = string.Empty;
        [BsonElement("name")]
        public string Name { get; set; } = string.Empty;
        [BsonElement("graduated")]
        public bool IsGraduated { get; set; }
        [BsonElement("gender")]
        public string Gender { get; set; }
        [BsonElement("age")]
        public int Age { get; set; }
        [BsonElement("courses")]
        public string[] Courses { get; set; }
    }
}
