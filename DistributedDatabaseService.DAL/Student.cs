using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace DistributedDatabaseService.DAL;

public class Student
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public string? Id { get; set; }
    
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public DateTime EnrollmentDate { get; set; } = DateTime.Now;
    
    // Зовнішній ключ до групи
    public int? GroupId { get; set; }
    
    [BsonIgnore]
    public Group? Group { get; set; }
    
    // Навігаційна властивість для відношення "багато до багатьох"
    [BsonIgnore]
    public ICollection<StudentCourse> StudentCourses { get; set; }
}
