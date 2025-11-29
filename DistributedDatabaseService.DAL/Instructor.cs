namespace DistributedDatabaseService.DAL;

public class Instructor
{
    public int InstructorId { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string? Email { get; set; }
    public string? Title { get; set; }
    
    // Зовнішній ключ до факультету
    public int? FacultyId { get; set; }
    public Faculty? Faculty { get; set; }
    
    // Навігаційна властивість - один до багатьох
    public ICollection<Course> Courses { get; set; }
}

