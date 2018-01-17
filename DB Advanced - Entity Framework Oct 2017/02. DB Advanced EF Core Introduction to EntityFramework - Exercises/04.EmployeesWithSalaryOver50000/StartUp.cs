namespace _04.EmployeesWithSalaryOver50000
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
                var employeesWithSalary = context.Employees
                    .Where(e => e.Salary > 50000)
                    .OrderBy(e => e.FirstName)
                    .Select(e => new
                    {
                        e.FirstName
                    })
                    .ToList();

                foreach (var employee in employeesWithSalary)
                {
                    Console.WriteLine(employee.FirstName);
                }
            }


        }
    }
}
