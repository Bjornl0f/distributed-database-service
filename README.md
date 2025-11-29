# Distributed Database Service

Сервіс з розподіленою базою даних SQL та MongoDB.

## Структура проекту

- **DistributedDatabaseService** - ASP.NET Core Web API проект
- **DistributedDatabaseService.DAL** - Data Access Layer (Entity Framework Core 8 + MongoDB)

## Моделі даних (SQL Server)

- `Student` - студент (StudentId, FirstName, LastName, Email, DateOfBirth, EnrollmentDate, GroupId)
- `Course` - курс (CourseId, Title, Credits, Description, MaxStudents, InstructorId)
- `StudentCourse` - зв'язок багато-до-багатьох (EnrollmentDate, Grade)
- `Group` - група (GroupId, Name, Year, FacultyId)
- `Faculty` - факультет (FacultyId, Name, Dean)
- `Instructor` - викладач (InstructorId, FirstName, LastName, Email, Title, FacultyId)

## Зв'язки

- Student → Group (багато до одного)
- Group → Faculty (багато до одного)
- Instructor → Faculty (багато до одного)
- Course → Instructor (багато до одного)
- Student ↔ Course (багато до багатьох через StudentCourse)

## Налаштування

Connection string до SQL Server налаштовується в `appsettings.json`.

## Міграції

```bash
dotnet ef migrations add <MigrationName> --project DistributedDatabaseService.DAL --startup-project DistributedDatabaseService
dotnet ef database update --project DistributedDatabaseService.DAL --startup-project DistributedDatabaseService
```
