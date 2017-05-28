using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20.Поспаливата_котка_Том
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            int daysOff = days * 127;
            int daysOnWork = (365 - days) * 63;
            int timeForGame = daysOff + daysOnWork;
            int hh = Math.Abs((30000 - timeForGame) / 60);
            int mm = Math.Abs((30000 - timeForGame) % 60);
            if (timeForGame > 30000)
            {
                Console.WriteLine("Tom will run away");
                Console.WriteLine("{0} hours and {1} minutes more for play", hh, mm);
            }
            else
            {
                Console.WriteLine("Tom sleeps well");
                Console.WriteLine("{0} hours and {1} minutes less for play", hh, mm);
            }
        }
    }
}
