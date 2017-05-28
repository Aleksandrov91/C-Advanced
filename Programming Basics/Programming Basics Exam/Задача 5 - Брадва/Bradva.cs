using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_5___Брадва
{
    class Bradva
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(new string('-', 3 * n));
                    Console.Write(new string('*', n));
                    Console.Write(new string('-', n));
                }
                Console.WriteLine();
            }
            
        }
    }
}
