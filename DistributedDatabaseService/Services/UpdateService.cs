using System.Transactions;
using DistributedDatabaseService.DAL;

namespace DistributedDatabaseService.Services
{
    public class UpdateService : IHostedService
    {
        private readonly IServiceScopeFactory _serviceScopeFactory;

        public UpdateService(IServiceScopeFactory serviceScopeFactory)
        {
            _serviceScopeFactory = serviceScopeFactory;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            await using (var scope = _serviceScopeFactory.CreateAsyncScope())
            {
                var mongoService = scope.ServiceProvider.GetRequiredService<StudentService>();
                var dbContext = scope.ServiceProvider.GetRequiredService<LabDbContext>();
                
                using (var transaction = new TransactionScope(TransactionScopeAsyncFlowOption.Enabled))
                {
                    try
                    {
                        var students = dbContext.Students.ToList();
                        
                        foreach (var student in students)
                        {
                            var studentForMongo = new Student()
                            {
                                StudentId = student.StudentId,
                                FirstName = student.FirstName,
                                LastName = student.LastName,
                                Email = student.Email,
                                DateOfBirth = student.DateOfBirth,
                                EnrollmentDate = student.EnrollmentDate,
                                GroupId = student.GroupId
                            };
                            
                            studentForMongo.Id = student.FirstName + student.LastName + student.StudentId;
                            
                            await mongoService.CreateAsync(studentForMongo);
                        }
                        
                        transaction.Complete();
                    }
                    catch (Exception ex)
                    {
                        transaction.Dispose();
                        throw;
                    }
                }
            }
        }

        public Task StopAsync(CancellationToken cancellationToken)
        {
            return Task.CompletedTask;
        }
    }
}

