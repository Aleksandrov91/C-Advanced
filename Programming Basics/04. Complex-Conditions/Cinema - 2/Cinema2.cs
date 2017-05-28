using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema___2
{
    class Cinema2
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine().ToLower();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            double total = 0;

            if (type == "premiere")
            {
                total = 12 * (r * c);
            }
            else if (type == "normal")
            {
                total = 7.5 * (r * c);
            }
            else if (type == "discount")
            {
                total = 5 * (r * c);
            }
            if (total > 0)
            {
                Console.WriteLine("{0:f2}" + " leva", total);
            }
        }
    }
}
