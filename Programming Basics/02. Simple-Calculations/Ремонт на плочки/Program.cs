using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ремонт_на_плочки
{
    class Program
    {
        static void Main(string[] args)
        {
            double N = double.Parse(Console.ReadLine());
            double W = double.Parse(Console.ReadLine());
            double L = double.Parse(Console.ReadLine());
            double M = double.Parse(Console.ReadLine());
            double O = double.Parse(Console.ReadLine());
            double plosht = N * N;
            double plochka = W * L;
            double peika = M * O;
            Console.WriteLine((plosht - peika) / plochka);
            Console.WriteLine(((plosht - peika) / plochka) * 0.2);
        }
    }
}
