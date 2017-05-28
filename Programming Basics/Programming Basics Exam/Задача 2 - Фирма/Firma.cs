using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_2___Фирма
{
    class Firma
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int rabotnici = int.Parse(Console.ReadLine());

            double obuchenie = (days - (days * 0.1)) * 8;
            int izvunredniChasove = rabotnici * (2 * days);
            double totalHours = Math.Truncate(obuchenie + izvunredniChasove);

            if (hours <= totalHours)
            {
                double leftHours = totalHours - hours;
                Console.WriteLine("Yes!{0} hours left.", leftHours);
            }
            else
            {
                double needHours = hours - totalHours;
                Console.WriteLine("Not enough time!{0} hours needed.", needHours);
            }
        }
    }
}
