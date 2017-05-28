using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delene_bez_ostatuk
{
    class DeleneBezOstatuk
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            double p1Broi = 0;
            double p2Broi = 0;
            double p3Broi = 0;
            for (int i = 0; i < n; i++)
            {
                int a = int.Parse(Console.ReadLine());
                if (a % 2 == 0)
                {
                    p1Broi++;
                }
                if (a % 3 == 0)
                {
                    p2Broi++;
                }
                if (a %4 == 0)
                {
                    p3Broi++;
                }
            }
            double p1 = (p1Broi / n) * 100;
            double p2 = (p2Broi / n) * 100;
            double p3 = (p3Broi / n) * 100;
            Console.WriteLine("{0:f2}%", p1);
            Console.WriteLine("{0:f2}%", p2);
            Console.WriteLine("{0:f2}%", p3);
        }
    }
}
