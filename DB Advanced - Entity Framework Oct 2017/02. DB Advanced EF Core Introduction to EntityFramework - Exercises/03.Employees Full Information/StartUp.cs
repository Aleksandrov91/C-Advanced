namespace _03.Employees_Full_Information
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
                    .OrderBy(i => i.EmployeeId)
                    .Select(e => new
                    {
                        e.FirstName,
                        e.LastName,
                        e.MiddleName,
                        e.Salary,
                        e.JobTitle
                    })                    
                    .ToList();

                foreach (var employee in employees)
                {
                    Console.WriteLine($"{employee.FirstName} {employee.LastName} {employee.MiddleName} {employee.JobTitle} {employee.Salary:F2}");
                }
            }
        }
    }
}
