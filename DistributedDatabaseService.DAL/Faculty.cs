namespace DistributedDatabaseService.DAL;

public class Faculty
{
    public int FacultyId { get; set; }
    public string Name { get; set; }
    public string? Dean { get; set; }
    
    // Навігаційна властивість - один до багатьох
    public ICollection<Group> Groups { get; set; }
    public ICollection<Instructor> Instructors { get; set; }
}

