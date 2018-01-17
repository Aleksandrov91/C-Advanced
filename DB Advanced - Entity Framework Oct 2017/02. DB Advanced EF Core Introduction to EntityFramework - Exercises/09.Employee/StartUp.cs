namespace _09.Employee
{
    using _00.DatabaseModel.Data;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int employeeId = 147;

            using (SoftUniContext context = new SoftUniContext())
            {
                var employeeDetails = context.Employees
                    .Where(e => e.EmployeeId == employeeId)
                    .Select(e => new
                    {
                        Id = e.EmployeeId,
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        JobTitle = e.JobTitle
                    })
                    .SingleOrDefault();

                var employeeProjects = context.EmployeesProjects
                    .Include(p => p.Project)
                    .Where(e => e.EmployeeId == employeeDetails.Id)
                    .OrderBy(p => p.Project.Name)
                    .Select(p => new
                    {
                        ProjectName = p.Project.Name
                    })
                    .ToList();

                Console.WriteLine($"{employeeDetails.FirstName} {employeeDetails.LastName} - {employeeDetails.JobTitle}");

                foreach (var project in employeeProjects)
                {
                    Console.WriteLine(project.ProjectName);
                }
            }
        }
    }
}
