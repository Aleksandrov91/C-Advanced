using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vacantion_Trip
{
    class VacantionTrip
    {
        static void Main(string[] args)
        {
            var budget = double.Parse(Console.ReadLine());
            string season = Console.ReadLine();

            if (season == "summer")
            {
                if (budget <= 100)
                {
                    budget *= 0.3;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Camp - " + "{0:f2}", budget);
                }
                else if (budget <= 1000)
                {
                    budget *= 0.4;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Camp - " + "{0:f2}", budget);
                }
                else if (budget > 1000)
                {
                    budget *= 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - " + "{0:f2}", budget);
                }
            }
            else
            {
                if (budget <= 100)
                {
                    budget *= 0.7;
                    Console.WriteLine("Somewhere in Bulgaria");
                    Console.WriteLine("Hotel - " + "{0:f2}", budget);
                }
                else if (budget <= 1000)
                {
                    budget *= 0.8;
                    Console.WriteLine("Somewhere in Balkans");
                    Console.WriteLine("Hotel - " + "{0:f2}", budget);
                }
                else if (budget > 1000)
                {
                    budget *= 0.9;
                    Console.WriteLine("Somewhere in Europe");
                    Console.WriteLine("Hotel - " + "{0:f2}", budget);
                }
            }
        }
    }
}
