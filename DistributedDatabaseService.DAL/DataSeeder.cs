namespace DistributedDatabaseService.DAL;

public class DataSeeder
{
    private readonly LabDbContext _context;

    public DataSeeder(LabDbContext context)
    {
        _context = context;
    }

    public void Seed()
    {
        if (_context.Students.Any() || _context.Courses.Any())
            return;

        // Створення курсів
        var courses = new List<Course>
        {
            new Course { Title = "Математика", Credits = 5 },
            new Course { Title = "Фізика", Credits = 4 },
            new Course { Title = "Програмування", Credits = 6 },
            new Course { Title = "Бази даних", Credits = 5 },
            new Course { Title = "Алгоритми", Credits = 4 }
        };

        _context.Courses.AddRange(courses);
        _context.SaveChanges();

        // Створення студентів
        var students = new List<Student>
        {
            new Student { FirstName = "Іван", LastName = "Петренко" },
            new Student { FirstName = "Марія", LastName = "Коваленко" },
            new Student { FirstName = "Олексій", LastName = "Шевченко" },
            new Student { FirstName = "Анна", LastName = "Бондаренко" },
            new Student { FirstName = "Дмитро", LastName = "Мельник" }
        };

        _context.Students.AddRange(students);
        _context.SaveChanges();

        // Створення зв'язків студент-курс
        var studentCourses = new List<StudentCourse>
        {
            new StudentCourse { StudentId = students[0].StudentId, CourseId = courses[0].CourseId },
            new StudentCourse { StudentId = students[0].StudentId, CourseId = courses[2].CourseId },
            new StudentCourse { StudentId = students[1].StudentId, CourseId = courses[1].CourseId },
            new StudentCourse { StudentId = students[1].StudentId, CourseId = courses[3].CourseId },
            new StudentCourse { StudentId = students[2].StudentId, CourseId = courses[2].CourseId },
            new StudentCourse { StudentId = students[2].StudentId, CourseId = courses[4].CourseId },
            new StudentCourse { StudentId = students[3].StudentId, CourseId = courses[0].CourseId },
            new StudentCourse { StudentId = students[3].StudentId, CourseId = courses[3].CourseId },
            new StudentCourse { StudentId = students[4].StudentId, CourseId = courses[1].CourseId },
            new StudentCourse { StudentId = students[4].StudentId, CourseId = courses[2].CourseId }
        };

        _context.StudentCourses.AddRange(studentCourses);
        _context.SaveChanges();
    }
}

