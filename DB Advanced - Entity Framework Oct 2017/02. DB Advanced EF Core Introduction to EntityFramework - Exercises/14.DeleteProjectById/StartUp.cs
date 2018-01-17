namespace _14.DeleteProjectById
{
    using _00.DatabaseModel.Data;
    using _00.DatabaseModel.Data.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                int projectId = 2;

                Project project = context.Projects.Find(projectId);

                List<EmployeeProject> employeeProjects = context.EmployeesProjects
                    .Where(p => p.ProjectId == projectId)
                    .ToList();

                context.Projects.Remove(project);

                context.EmployeesProjects.RemoveRange(employeeProjects);

                context.SaveChanges();

                var projects = context.Projects
                    .Select(p => new
                    {
                        p.Name
                    })
                    .Take(10)
                    .ToList();

                Console.WriteLine(string.Join("\r\n", projects.Select(p => p.Name)));
            }
        }
    }
}
