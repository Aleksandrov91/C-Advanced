namespace _10._DepartmentsWithMoreThan5Employees
{
    using _00.DatabaseModel.Data;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            using (SoftUniContext context = new SoftUniContext())
            {
                var departments = context.Departments
                    .Where(d => d.Employees.Count > 5)
                    .OrderBy(e => e.Employees.Count)
                    .ThenBy(d => d.Name)
                    .Select(d => new
                    {
                        DepartmentName = d.Name,
                        ManagerFirstName = d.Manager.FirstName,
                        ManagerLastName = d.Manager.LastName,
                        Employees = d.Employees
                    })
                    .ToList();

                foreach (var department in departments)
                {
                    Console.WriteLine($"{department.DepartmentName} - {department.ManagerFirstName} {department.ManagerLastName}");

                    foreach (var employee in department.Employees.OrderBy(e => e.FirstName).ThenBy(e => e.LastName))
                    {
                        Console.WriteLine($"{employee.FirstName} {employee.LastName} - {employee.JobTitle}");
                    }

                    Console.WriteLine("----------");
                }
            }
        }
    }
}
