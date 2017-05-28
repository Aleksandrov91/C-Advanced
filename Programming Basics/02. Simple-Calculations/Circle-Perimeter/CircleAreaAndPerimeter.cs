using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circle_Perimeter
{
    class CircleAreaAndPerimeter
    {
        static void Main(string[] args)
        {
            var a = double.Parse(Console.ReadLine());
            var area = Math.PI * a * a;
            var perimeter = 2 * Math.PI * a;
            Console.WriteLine("Area = {0}", area);
            Console.WriteLine("Perimeter = {0}", perimeter);
        }
    }
}
