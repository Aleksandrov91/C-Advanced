using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transport_Price
{
    class ZelenchukovaBorsa
    {
        static void Main(string[] args)
        {
            double cena_zelenchuk = double.Parse(Console.ReadLine());
            double cena_plod = double.Parse(Console.ReadLine());
            double kg_zel = double.Parse(Console.ReadLine());
            double kg_plod = double.Parse(Console.ReadLine());
            double pechalba_zel = cena_zelenchuk * kg_zel;
            double pechalba_plod = cena_plod * kg_plod;
            Console.WriteLine((pechalba_plod + pechalba_zel) / 1.94);
        }
    }
}
