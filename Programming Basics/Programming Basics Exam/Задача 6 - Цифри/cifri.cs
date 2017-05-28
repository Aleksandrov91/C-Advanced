using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_6___Цифри
{
    class cifri
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = a / 100;
            int c = a / 10 % 10;
            int d = a % 10;
            int row = b + c;
            int col = b + d;
            for (int i = 0; i < row; i++)
            {
                for (int j = 1; j <= col; j++)
                {
                    if (a % 5 == 0)
                    {
                        a = a - b;
                        Console.Write(a + " ");
                    }
                    else if (a % 3 == 0)
                    {
                        a = a - c;
                        Console.Write(a + " ");
                    }
                    else
                    {
                        a = a + d;
                        Console.Write(a + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
