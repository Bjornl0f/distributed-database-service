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

## Сервіси

- `StudentService` - CRUD операції для студентів в MongoDB
- `UpdateService` - синхронізація даних між SQL Server та MongoDB з використанням транзакцій

## Налаштування

### SQL Server
Connection string в `appsettings.json`:
```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\mssqllocaldb;Database=SchoolDb;..."
}
```

### MongoDB
```json
"MongoDBSettings": {
  "ConnectionString": "mongodb://localhost:27017",
  "DatabaseName": "SchoolDb"
}
```

## Міграції

```bash
dotnet ef migrations add <MigrationName> --project DistributedDatabaseService.DAL --startup-project DistributedDatabaseService
dotnet ef database update --project DistributedDatabaseService.DAL --startup-project DistributedDatabaseService
```
