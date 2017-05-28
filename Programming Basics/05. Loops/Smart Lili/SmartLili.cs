using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smart_Lili
{
    class SmartLili
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            double washMachinePrice = double.Parse(Console.ReadLine());
            double toyPrice = double.Parse(Console.ReadLine());
            double toy = 0;
            double money = 0;
            double pari = 0;

            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    pari += 10;
                    money += pari;
                    money--;
                }
                else
                {
                    toy++;
                }
            }
            double toyPechalba = (toy * toyPrice);
            double SubraniPari = toyPechalba + money;
            double ostatuk = SubraniPari - washMachinePrice;
            if (washMachinePrice < SubraniPari)
            {
                Console.WriteLine("Yes! {0:f2}", ostatuk);
            }
            else
            {
                Console.WriteLine("No! {0:f2}", Math.Abs(ostatuk));
            }
        }
    }
}
