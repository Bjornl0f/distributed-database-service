namespace DistributedDatabaseService.DAL;

public class Course
{
    public int CourseId { get; set; }
    public string Title { get; set; }
    public int Credits { get; set; }
    // Навігаційна властивість для відношення "багато до багатьох"
    public ICollection<StudentCourse> StudentCourses { get; set; }
}

