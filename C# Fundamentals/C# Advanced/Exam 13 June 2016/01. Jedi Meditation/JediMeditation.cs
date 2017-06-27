using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _01.Jedi_Meditation
{
    public class JediMeditation
    {
        public static bool isTereYoda = false;
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var jediMasters = new StringBuilder();
            var jediKnights = new StringBuilder();
            var toshkoSlav = new StringBuilder();
            var padawans = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var line = Console.ReadLine().Split(new[] {' '}, StringSplitOptions.RemoveEmptyEntries);
                PutJediOnHisPlace(line, jediMasters, jediKnights, toshkoSlav, padawans);
            }

            if (isTereYoda)
            {
                Console.WriteLine($"{jediMasters}{jediKnights}{toshkoSlav}{padawans}");
            }
            else
            {
                Console.WriteLine($"{toshkoSlav}{jediMasters}{jediKnights}{padawans}");
            }

        }

        private static void PutJediOnHisPlace(string[] line, StringBuilder jediMasters, StringBuilder jediKnights, StringBuilder toshkoSlav, StringBuilder padawans)
        {
            foreach (var jedi in line)
            {
                switch (jedi[0])
                {
                    case 'm':
                        jediMasters.Append(jedi).Append(" ");
                        break;
                    case 'k':
                        jediKnights.Append(jedi).Append(" ");
                        break;
                    case 's':
                    case 't':
                        toshkoSlav.Append(jedi).Append(" ");
                        break;
                    case 'y':
                        isTereYoda = true;
                        break;
                    case 'p':
                        padawans.Append(jedi).Append(" ");
                        break;
                }
            }
        }
    }
}
