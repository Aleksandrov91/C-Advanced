using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_of_Figures
{
    class AreaOfFigures
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            
                switch (type)
            {
                case "square":
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(a * a, 3));
                break;
                case "rectangle":
                double c = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(c * b, 3));
                break;
                case "circle":
                double r = double.Parse(Console.ReadLine());
                double S = Math.PI * r * r;
                Console.WriteLine(Math.Round(S, 3));
                break;
                case "triangle":
                double d = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                Console.WriteLine(Math.Round(0.5 * (d * h), 3));
                break;
                default:
                Console.WriteLine("Wrong parrameters");
                break;
            }
        }
    }
}
