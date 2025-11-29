namespace DistributedDatabaseService.DAL;

public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }
    public string? Description { get; set; }
    public int MaxStudents { get; set; } = 30;
    
    // Зовнішній ключ до викладача
    public int? InstructorId { get; set; }
    public Instructor? Instructor { get; set; }
    
    // Навігаційна властивість для відношення "багато до багатьох"
    public ICollection<StudentCourse> StudentCourses { get; set; }
}
