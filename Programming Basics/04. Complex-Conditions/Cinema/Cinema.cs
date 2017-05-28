using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Cinema
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            
            switch (type)
            {
                case "premiere":
                    double total = 12 * (r * c);
                    Console.WriteLine("{0:f2}" + " leva", total);
                    break;
                case "normal":
                    double total2 = 7.5 * (r * c);
                    Console.WriteLine("{0:f2}" + " leva", total2);
                    break;
                case "discount":
                    double total3 = 5 * (r * c);
                    Console.WriteLine("{0:f2}" + " leva", total3);
                    break;
                default:
                    break;
            }
        }
    }
}
