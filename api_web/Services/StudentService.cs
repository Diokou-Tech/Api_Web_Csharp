using api_web.Interfaces;
using api_web.Models;
using System.Collections.Generic;
using MongoDB.Driver;

namespace api_web.Services
{
    public class StudentService : IStudentService
    {
        private readonly IMongoCollection<Student> _students;

        public StudentService( ISettingDB setting)
        {
            var mongoClient = new MongoClient(setting.ConnectionString);
            var database = mongoClient.GetDatabase(setting.DatabaseName);
            _students = database.GetCollection<Student>(setting.StudentCollectionName);
        }
        public Student Create(Student student)
        {
            _students.InsertOne(student);
            return student;
        }

        public List<Student> Get()
        {
            return _students.Find(student => true).ToList();
        }

        public Student Get(string id)
        {
            return _students.Find(student => student.Id == id).FirstOrDefault();
        }

        public void Remove(string id)
        {
            _students.DeleteOne(s => s.Id == id);
        }

        public void Update(string id, Student student)
        {
            _students.ReplaceOne(s => s.Id == id, student);
        }
    }
}
