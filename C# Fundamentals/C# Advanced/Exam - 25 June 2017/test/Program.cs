using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] {1, 2, 3, 4, 5, 5, 5, 1, 1, 3};

            foreach (var i in arr.Distinct())
            {
                Console.WriteLine(i);
            }

            Console.WriteLine(string.Join(" ", arr.Distinct()));
        }
    }
}
