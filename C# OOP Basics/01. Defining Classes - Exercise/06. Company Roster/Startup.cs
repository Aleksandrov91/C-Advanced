namespace _06.Company_Roster
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var numberOfEmployee = int.Parse(Console.ReadLine());
            var employees = new List<Employee>();

            for (int i = 0; i < numberOfEmployee; i++)
            {
                var employeeArgs = Console.ReadLine()
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var employeeName = employeeArgs[0];
                var employeeSalary = double.Parse(employeeArgs[1]);
                var employeePosition = employeeArgs[2];
                var employeeDepartment = employeeArgs[3];

                var employee = new Employee(employeeName, employeeSalary, employeePosition, employeeDepartment);

                if (employeeArgs.Length > 4)
                {
                    if (int.TryParse(employeeArgs[4], out int age))
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = employeeArgs[4];
                    }
                }

                if (employeeArgs.Length > 5)
                {
                    employee.Age = int.Parse(employeeArgs[5]);
                }

                employees.Add(employee);
            }

            var departments = employees.GroupBy(e => e.Department);
            var department = departments.OrderByDescending(d => d.Average(e => e.Salary)).FirstOrDefault();

            Console.WriteLine($"Highest Average Salary: {department.Key}");

            foreach (var employee in department.OrderByDescending(e => e.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
