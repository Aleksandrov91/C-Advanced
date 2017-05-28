using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inches_To_Centimeters
{
    class InchesToCentimeters
    {
        static void Main(string[] args)
        {
            Console.Write("Inches: ");
            var inches = double.Parse(Console.ReadLine());
            var result = inches * 2.54;
            Console.Write("Centimeters: ");
            Console.WriteLine(result);

        }
    }
}
