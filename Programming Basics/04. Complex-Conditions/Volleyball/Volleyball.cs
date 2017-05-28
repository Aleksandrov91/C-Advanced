using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Volleyball
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int p = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            double weekends = 48;
            double weekendsInSofia = weekends - h;
            double gamesInSofia = weekendsInSofia * (3.0 / 4);
            double gamesInBornCity = h;
            double gamesInHolidays = p * (2.0 / 3);
            double allGames = gamesInSofia + gamesInBornCity + gamesInHolidays;
            if (type == "leap")
            {
                double total = allGames + (allGames * 0.15);
                Console.WriteLine(Math.Truncate(total));
            }
            else
            {
                Console.WriteLine(Math.Truncate(allGames));
            }

        }
    }
}
