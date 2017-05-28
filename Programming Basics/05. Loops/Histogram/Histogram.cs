using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Histogram
{
    class Histogram
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1Broi = 0;
            double p2Broi = 0;
            double p3Broi = 0;
            double p4Broi = 0;
            double p5Broi = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a < 200)
                {
                    p1Broi += 1;
                }
                else if (a < 400)
                {
                    p2Broi += 1;
                }
                else if (a < 600)
                {
                    p3Broi += 1;
                }
                else if (a < 800)
                {
                    p4Broi += 1;
                }
                else if (a >= 800)
                {
                    p5Broi += 1;
                }
            }
            double p1 = (p1Broi / n) * 100;
            double p2 = (p2Broi / n) * 100;
            double p3 = (p3Broi / n) * 100;
            double p4 = (p4Broi / n) * 100;
            double p5 = (p5Broi / n) * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
            Console.WriteLine("{0:f2}%", p4);
            Console.WriteLine("{0:f2}%", p5);
        }
    }
}
