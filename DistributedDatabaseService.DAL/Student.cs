namespace DistributedDatabaseService.DAL;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }
    public DateTime? DateOfBirth { get; set; }
    public DateTime EnrollmentDate { get; set; } = DateTime.Now;
    
    // Зовнішній ключ до групи
    public int? GroupId { get; set; }
    public Group? Group { get; set; }
    
    // Навігаційна властивість для відношення "багато до багатьох"
    public ICollection<StudentCourse> StudentCourses { get; set; }
}
