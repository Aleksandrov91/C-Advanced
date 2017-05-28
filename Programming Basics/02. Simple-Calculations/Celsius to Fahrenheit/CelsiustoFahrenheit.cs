using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celsius_to_Fahrenheit
{
    class CelsiustoFahrenheit
    {
        static void Main(string[] args)
        {
            var c = double.Parse(Console.ReadLine());
            var sum = c * 1.8 + 32;
            var sum2 = Math.Round(sum, 2);
            Console.WriteLine(sum2);
        }
    }
}
