using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class InvalidNumber
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());

            if (a == 0 || a >= 100 && a <= 200)
            {
        
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
    }
}
