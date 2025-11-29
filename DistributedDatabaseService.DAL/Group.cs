namespace DistributedDatabaseService.DAL;

public class Group
{
    public int GroupId { get; set; }
    public string Name { get; set; }
    public int Year { get; set; }
    
    // Зовнішній ключ до факультету
    public int FacultyId { get; set; }
    public Faculty Faculty { get; set; }
    
    // Навігаційна властивість - один до багатьох
    public ICollection<Student> Students { get; set; }
}

