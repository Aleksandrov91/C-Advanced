using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter_2
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            var b = Console.ReadLine();
            var c = Console.ReadLine();

            if (b == "mm")
            {
                a = a / 1000;
            }
            else if (b == "cm")
            {
                a = a / 100;
            }
            else if (b == "m")
            {
                a = a;
            }
            else if (b == "mi")
            {
                a = a / 0.000621371192;
            }
            else if (b == "in")
            {
                a = a / 39.3700787;
            }
            else if (b == "km")
            {
                a = a / 0.001;
            }
            else if (b == "ft")
            {
                a = a / 3.2808399;
            }
            else if (b == "yd")
            {
                a = a / 1.0936133;
            }

            if (c == "mm")
            {
                a = a * 1000;
            }
            else if (c == "cm")
            {
                a = a * 100;
            }
            else if (c == "m")
            {
                a = a;
            }
            else if (c == "mi")
            {
                a = a * 0.000621371192;
            }
            else if (c == "in")
            {
                a = a * 39.3700787;
            }
            else if (c == "km")
            {
                a = a * 0.001;
            }
            else if (c == "ft")
            {
                a = a * 3.2808399;
            }
            else if (c == "yd")
            {
                a = a * 1.0936133;
            }

            Console.WriteLine(a + " " + c);

        }
    }
}
