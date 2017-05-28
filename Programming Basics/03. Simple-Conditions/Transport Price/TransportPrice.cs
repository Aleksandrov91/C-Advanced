using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class TransportPrice
    {
        static void Main(string[] args)
        {
            Double km = double.Parse(Console.ReadLine());
            string t = Console.ReadLine();

            if (t == "day" && km < 20)
            {
                double sum =0.7 + (km * 0.79);
                Console.WriteLine(sum);
            }
            else if (t == "night" && km < 20)
            {
                double sum =0.7 + (km * 0.9);
                Console.WriteLine(sum);
            }
            else if (km >= 20 && km < 100)
            {
                double sum = km * 0.09;
                Console.WriteLine(sum);
            }
            else if (km >= 100)
            {
                double sum = km * 0.06;
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Incorrect Input");
            }
        }
    }
}
