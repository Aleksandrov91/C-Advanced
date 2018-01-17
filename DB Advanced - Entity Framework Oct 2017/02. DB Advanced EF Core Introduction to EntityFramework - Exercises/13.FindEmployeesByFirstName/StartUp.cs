namespace _13.FindEmployeesByFirstName
{
    using _00.DatabaseModel.Data;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string employeeStartString = "Sa";

            using (SoftUniContext context = new SoftUniContext())
            {
                var employees = context.Employees
                    .Where(e => e.FirstName.StartsWith(employeeStartString))
                    .OrderBy(e => e.FirstName)
                    .ThenBy(e => e.LastName)
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        e.JobTitle,
                        e.Salary
                    })
                    .ToList();

                Console.WriteLine(string.Join("\r\n", employees.Select(e => $"{e.FirstName} {e.LastName} - {e.JobTitle} - (${e.Salary:F2})")));
            }
        }
    }
}
