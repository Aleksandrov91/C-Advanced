namespace _06.AddingNewAddressAndUpdatingEmployee
{
    using _00.DatabaseModel.Data;
    using _00.DatabaseModel.Data.Models;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            Address adress = new Address
            {
                AddressText = "Vitoshka 15",
                TownId = 4
            };

            using (SoftUniContext context = new SoftUniContext())
            {
                Employee employee = context.Employees
                    .Where(e => e.LastName == "Nakov")
                    .SingleOrDefault();

                employee.Address = adress;

                context.SaveChanges();

                var employees = context.Employees
                    .OrderByDescending(e => e.AddressId)
                    .Take(10)
                    .Select(e => new
                    {
                        AddressText = e.Address.AddressText
                    });

                foreach (var e in employees)
                {
                    Console.WriteLine(e.AddressText);
                }
            };
        }
    }
}
