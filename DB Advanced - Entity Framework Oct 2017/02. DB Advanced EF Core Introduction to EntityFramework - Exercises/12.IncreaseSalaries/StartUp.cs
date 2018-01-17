namespace _12.IncreaseSalaries
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
            decimal salaryIncreacement = 1.12M;

            using (SoftUniContext context = new SoftUniContext())
            {
                List<Employee> employeesInDepartments = context.Employees
                    .Where(d => d.Department.Name == "Engineering" ||
                           d.Department.Name == "Tool Design" ||
                           d.Department.Name == "Marketing" ||
                           d.Department.Name == "Information Services")
                    .ToList();

                employeesInDepartments.ForEach(e => e.Salary *= salaryIncreacement);

                context.UpdateRange(employeesInDepartments);

                context.SaveChanges();

                foreach (var employee in employeesInDepartments.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} (${employee.Salary:F2})");
                }
            }
        }
    }
}
