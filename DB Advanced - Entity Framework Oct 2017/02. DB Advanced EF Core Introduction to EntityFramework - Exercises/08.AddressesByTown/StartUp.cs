namespace _08.AddressesByTown
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
                var addresses = context.Addresses
                    .Include(a => a.Town)
                    .Include(a => a.Employees)
                    .OrderByDescending(e => e.Employees.Count())
                    .ThenBy(t => t.Town.Name)
                    .ThenBy(a => a.AddressText)
                    .Select(a => new
                    {
                        AddressText = a.AddressText,
                        TownName = a.Town.Name,
                        EmployeesCount = a.Employees.Count
                    })
                    .Take(10)
                    .ToList();

                foreach (var adress in addresses)
                {
                    Console.WriteLine($"{adress.AddressText}, {adress.TownName} - {adress.EmployeesCount} employees");
                }
            }
        }
    }
}
