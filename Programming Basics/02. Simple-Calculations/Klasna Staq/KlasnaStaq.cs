using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasna_Staq
{
    class KlasnaStaq
    {
        static void Main(string[] args)
        {
            double h = double.Parse(Console.ReadLine());
            double w = double.Parse(Console.ReadLine());
            double hcm = h * 100;
            double wcm = (w * 100) - 100;
            double hroom = Math.Floor(hcm / 120);
            double wroom = Math.Floor(wcm / 70);
            double answer = hroom * wroom;
            Console.WriteLine(answer - 3);
        }
    }
}
