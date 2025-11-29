namespace DistributedDatabaseService.DAL;

public class Student
{
    public int StudentId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    // Навігаційна властивість для відношення "багато до багатьох"
    public ICollection<StudentCourse> StudentCourses { get; set; }
}

