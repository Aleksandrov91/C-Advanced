namespace _15.RemoveTowns
{
    using _00.DatabaseModel.Data;
    using _00.DatabaseModel.Data.Models;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string townName = Console.ReadLine();

            using (SoftUniContext context = new SoftUniContext())
            {
                Town town = context.Towns
                    .Where(t => t.Name == townName)
                    .SingleOrDefault();

                List<Address> adressess = context.Addresses
                    .Where(a => a.TownId == town.TownId)
                    .ToList();

                var employees = context.Employees
                    .Where(e => adressess.Any(a => a.AddressId == e.AddressId))
                    .ToList();

                employees.ForEach(e => e.Address = null);

                context.RemoveRange(adressess);
                context.Remove(town);

                context.SaveChanges();

                Console.WriteLine($"{adressess.Count} address in {town.Name} was deleted");
            }
        }
    }
}
