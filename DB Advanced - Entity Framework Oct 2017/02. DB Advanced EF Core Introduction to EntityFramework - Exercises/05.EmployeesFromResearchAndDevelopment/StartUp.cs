namespace _05.EmployeesFromResearchAndDevelopment
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
                var employees = context.Employees
                    .Where(e => e.Department.Name == "Research and Development")
                    .OrderBy(e => e.Salary)
                    .ThenByDescending(e => e.FirstName)
                    .Select(e => new
                    {
                        FirstName = e.FirstName,
                        LastName = e.LastName,
                        DepartmentName = e.Department.Name,
                        Salary = e.Salary
                    })
                    .ToList();

                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} from {employee.DepartmentName} - ${employee.Salary:F2}");
                }
            }
        }
    }
}
