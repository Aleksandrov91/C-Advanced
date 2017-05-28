using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speed_Info
{
    class SpeedInfo
    {
        static void Main(string[] args)
        {
            decimal speed = decimal.Parse(Console.ReadLine());

            if (speed <= 10)
            {
                Console.WriteLine("Slow");
            }
            else if (speed <= 50)
            {
                Console.WriteLine("Average");
            }
            else if (speed <= 150)
            {
                Console.WriteLine("Fast");
            }
            else if (speed <= 1000)
            {
                Console.WriteLine("Ultra Fast");
            }
            else
            {
                Console.WriteLine("Extremely Fast");
            }
        }
    }
}
