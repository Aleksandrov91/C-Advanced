using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_to_BGN
{
    class USDtoBGN
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            double sum = a * 1.79549;
            double sum2 = Math.Round(sum, 2);
            Console.WriteLine(sum2 + " BGN");
        }
    }
}
