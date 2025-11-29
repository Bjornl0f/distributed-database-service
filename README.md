# Distributed Database Service

Сервіс з розподіленою базою даних SQL та MongoDB.

## Структура проекту

- **DistributedDatabaseService** - ASP.NET Core Web API проект
- **DistributedDatabaseService.DAL** - Data Access Layer (Entity Framework Core 8)

## Моделі даних

- `Student` - студент (StudentId, FirstName, LastName)
- `Course` - курс (CourseId, Title, Credits)
- `StudentCourse` - зв'язок багато-до-багатьох між студентами та курсами

## Налаштування

Connection string до SQL Server налаштовується в `appsettings.json`.
