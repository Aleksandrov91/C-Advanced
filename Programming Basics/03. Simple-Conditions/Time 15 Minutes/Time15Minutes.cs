using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Time_15_Minutes
{
    class Time15Minutes
    {
        static void Main(string[] args)
        {
            double hour = double.Parse(Console.ReadLine());
            double mins = double.Parse(Console.ReadLine());
            mins += 15;

            if (mins >= 60)
            {
                mins = mins - 60;
                hour = hour + 1;
            }
            if (hour > 23)
            {
                hour = hour - 24;
            }
            if (mins < 10)
            {
                Console.WriteLine(hour + ":" + "0" + mins);
            }
            else
            {
                Console.WriteLine(hour + ":" + mins);
            }
        }
    }
}
