using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_3___Хотелска_стая
{
    class Hotel
    {
        static void Main(string[] args)
        {
            string mounth = Console.ReadLine().ToLower();
            int noshtuvki = int.Parse(Console.ReadLine());

            double studio = 0;
            double apartament = 0;

            if (noshtuvki > 7 && noshtuvki <= 14)
            {
                if (mounth == "may" || mounth == "october")
                {
                    studio = 50 - (50 * 0.05);
                    apartament = 65;
                }
                else if (mounth == "june" || mounth == "september")
                {
                    studio = 75.20;
                    apartament = 68.70;
                }
                else if (mounth == "july" || mounth == "august")
                {
                    studio = 76;
                    apartament = 77;
                }
            }
            else if (noshtuvki > 14)
            {
                if (mounth == "may" || mounth == "october")
                {
                    studio = 50 - (50 * 0.30);
                    apartament = 65 - (65 * 0.10);
                }
                else if (mounth == "june" || mounth == "september")
                {
                    studio = 75.20 - (75.20 * 0.20);
                    apartament = 68.70 - (68.70 * 0.1);
                }
                else if (mounth == "july" || mounth == "august")
                {
                    studio = 76;
                    apartament = 77 - (77 * 0.1);
                }
            }
            else
            {
                if (mounth == "may" || mounth == "october")
                {
                    studio = 50;
                    apartament = 65;
                }
                else if (mounth == "june" || mounth == "september")
                {
                    studio = 75.20;
                    apartament = 68.70;
                }
                else if (mounth == "july" || mounth == "august")
                {
                    studio = 76;
                    apartament = 77;
                }
            }
            double pochivkaVstudio = noshtuvki * studio;
            double pochivkaVapartament = noshtuvki * apartament;

            Console.WriteLine("Apartment: {0:f2} lv.", pochivkaVapartament);
            Console.WriteLine("Studio: {0:f2} lv.", pochivkaVstudio);
        }
    }
}
