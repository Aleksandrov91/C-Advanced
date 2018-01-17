namespace _07.EmployeesAndProjects
{
    using _00.DatabaseModel.Data;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {

                var emps = context.Employees
                    .Include(e => e.EmployeesProjects)
                    .ThenInclude(e => e.Project)
                    .Where(ep => ep.EmployeesProjects
                          .Any(p => p.Project.StartDate.Year >= 2001 &&
                                    p.Project.StartDate.Year <= 2003))
                    .Select(e => new
                    {
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        ManagerFirstName = e.Manager.FirstName,
                        ManagerLastName = e.Manager.LastName,
                        EmployeeProjects = e.EmployeesProjects
                                           .Select(ep => new
                                           {
                                               ep.Project.Name,
                                               ep.Project.StartDate,
                                               ep.Project.EndDate
                                           })
                    })
                    .Take(30)
                    .ToList();

                foreach (var employee in emps)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} - Manager: {employee.ManagerFirstName} {employee.ManagerLastName}");

                    foreach (var employeeProject in employee.EmployeeProjects)
                    {
                        string endDate = employeeProject.EndDate == null ? "not finished" : employeeProject.EndDate.ToString();
                        Console.WriteLine($"--{employeeProject.Name} - {employeeProject.StartDate} - {endDate}");
                    }
                }

                //var employeesWithProjects = context.EmployeesProjects
                //    .Include(ep => ep.Employee)
                //    .Include(p => p.Project)
                //    .Where(ep => ep.Employee.EmployeesProjects
                //           .Any(p => p.Project.StartDate.Year >= 2001 && 
                //                p.Project.StartDate.Year <= 2003))
                //    .Select(e => new
                //    {
                //        Id = e.Employee.EmployeeId,
                //        FirstName = e.Employee.FirstName,
                //        LastName = e.Employee.LastName,
                //        ManagerFirstName = e.Employee.Manager.FirstName,
                //        ManagerLastName = e.Employee.Manager.LastName,
                //        ProjectName = e.Project.Name,
                //        StartDate = e.Project.StartDate,
                //        EndDate = e.Project.EndDate
                //    })
                //    .GroupBy(e => new
                //    {
                //        e.Id,
                //        e.FirstName,
                //        e.LastName,
                //        e.ManagerFirstName,
                //        e.ManagerLastName
                //    })
                //    .Take(30)
                //    .ToList();

                //foreach (var emp in employeesWithProjects)
                //{
                //    Console.WriteLine($"{emp.Key.FirstName} {emp.Key.LastName} - Manager: {emp.Key.ManagerFirstName} {emp.Key.ManagerLastName}");

                //    foreach (var project in emp)
                //    {
                //        string endDate = project.EndDate == null ? "not finished" : project.EndDate.ToString();
                //        Console.WriteLine($"--{project.ProjectName} - {project.StartDate} - {endDate}");
                //    }
                //}
            }

        }
    }
}
