using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Factorial
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nsbor = 1;
            while (n > 1)
            {
                nsbor = nsbor * n;
                n--;
            }
            Console.WriteLine(nsbor);
        }
    }
}
