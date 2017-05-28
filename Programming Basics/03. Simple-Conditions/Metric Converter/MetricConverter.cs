using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
            string b = Console.ReadLine();
            string c = Console.ReadLine();

            double m = 1;
            double cm = m * 100;
            double mm = m * 1000;
            double mi = m * 0.000621371192;
            double inch = m * 39.3700787;
            double km = m * 0.001;
            double ft = m * 3.2808399;
            double yd = m * 1.0936133;

            switch (b)
            {
                case "m":
                    a = a / m;
                    break;
                case "mm":
                    a = a / mm;
                    break;
                case "cm":
                    a = a / cm;
                    break;
                case "mi":
                    a = a / mi;
                    break;
                case "in":
                    a = a / inch;
                    break;
                case "km":
                    a = a / km;
                    break;
                case "ft":
                    a = a / ft;
                    break;
                case "yd":
                    a = a / yd;
                    break;
            }
            switch (c)
            {
                case "m":
                    a = a * m;
                    break;
                case "mm":
                    a = a * mm;
                    break;
                case "cm":
                    a = a * cm;
                    break;
                case "mi":
                    a = a * mi;
                    break;
                case "in":
                    a = a * inch;
                    break;
                case "km":
                    a = a * km;
                    break;
                case "ft":
                    a = a * ft;
                    break;
                case "yd":
                    a = a * yd;
                    break;
            }
            Console.WriteLine(a + " " + c);
        }
    }
}
