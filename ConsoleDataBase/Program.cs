using ConsoleDataBase.Models;
using Microsoft.EntityFrameworkCore;

namespace ConsoleDataBase
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ConsoleDataBaseContextFactory consoleDataBaseContextFactory = new ConsoleDataBaseContextFactory();
            var context = consoleDataBaseContextFactory.CreateDbContext(args);
            using (context)
            {
                var employeeProject = context.EmployeeProjects.Include(employeeProject => employeeProject.Project).ThenInclude(project => project.Client);
                var diffInDays = context.Employees.Select(i => new { Id = i.Id, BD = i.DateOfBirth, Diff = EF.Functions.DateDiffDay(DateTime.UtcNow, i.DateOfBirth) }).ToList();
                foreach (var days in diffInDays)
                {
                    Console.WriteLine(days);
                }

                var transaction = context.Database.BeginTransaction();
                try
                {
                    var client1 = context.Clients.Find(3);
                    var client2 = context.Clients.Find(5);
                    client1.Address = "Boston";
                    client2.PhoneNumber = "+2-666-333-22";
                    context.SaveChanges();
                    transaction.Commit();
                }
                catch (Exception e)
                {
                    Console.WriteLine($"{e.Message}");
                    transaction.Rollback();
                }

                var employee = new Employee { Id = 6, FirstName = "Anna", LastName = "Fisher", DateOfBirth = DateTime.Parse("10.09.2000"), HiredDate = DateTime.UtcNow, OfficeId = 5, TitleId = 2 };
                var title = new Title { Id = 6, Name = "Dr." };
                var client = new Client { Id = 6, Name = "Sun", Address = "London", EMail = "sun@gmail.com", PhoneNumber = "+3-555-333-88" };
                var project = new Project { Id = 6, Name = "Project6", Budget = 350000m, ClientId = 6, StartedDate = DateTime.UtcNow };
                context.Employees.Add(employee);
                context.Titles.Add(title);
                context.Clients.Add(client);
                context.SaveChanges();
                context.Projects.Add(project);
                context.SaveChanges();
                var employee2 = context.Employees.Find(1);
                context.Employees.Remove(employee2);
                context.SaveChanges();
                var employees = context.Employees.Where(i => !EF.Functions.Like(i.Title.Name, "%a%")).GroupBy(i => i.TitleId);
            }
        }
    }
}