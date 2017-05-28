using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Sum_Digits
{
    class SumDigits
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int newN = 0;
            int nsbor = 0;
            int oldnsbor = 0;
            while (n > 0)
            {
                newN = n % 10;
                n = n / 10;
                nsbor = newN;
                oldnsbor = oldnsbor + nsbor;
            }
            Console.WriteLine(oldnsbor);
        }
    }
}
