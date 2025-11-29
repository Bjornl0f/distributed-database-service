# Changelog

## [0.3.0] - 2025-11-29

### Додано
- MongoDB налаштування в appsettings.json
- Клас MongoDBSettings для конфігурації MongoDB
- MongoDB клієнт в DI-контейнер
- StudentService для CRUD операцій з MongoDB
- UpdateService для синхронізації даних SQL Server → MongoDB з транзакціями (ACID)
- BsonId атрибути для моделі Student для підтримки MongoDB

## [0.2.0] - 2025-11-29

### Додано
- Налаштування DbContext в Program.cs
- Міграція InitialCreate для початкової структури БД
- DataSeeder сервіс для заповнення бази початковими даними
- Нові поля в існуючі моделі (Email, DateOfBirth, EnrollmentDate, Description, MaxStudents, Grade)
- Нові таблиці: Group, Faculty, Instructor зі зв'язками
- Міграція AddNewTablesAndFields
- Встановлено MongoDB.Driver пакет

## [0.1.0] - 2025-11-29

### Додано
- Створено .NET solution з двома проектами
- ASP.NET Core Web API проект (DistributedDatabaseService)
- Class Library проект для DAL (DistributedDatabaseService.DAL)
- Встановлено Entity Framework Core 8 пакети
- Додано моделі: Student, Course, StudentCourse
- Додано LabDbContext з налаштуванням зв'язку багато-до-багатьох
- Налаштовано підключення до SQL Server в appsettings.json
