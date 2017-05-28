using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_4___Болница
{
    class Hospital
    {
        static void Main(string[] args)
        {
            int period = int.Parse(Console.ReadLine());
            int lekari = 7;
            int treatedPatients = 0;
            int sumTreated = 0;
            int unTreatedPatients = 0;
            int sumUntreatedPatients = 0;
            for (int i = 1; i <= period; i++)
            {
                int pacienti = int.Parse(Console.ReadLine());
                if (i % 3 == 0 && unTreatedPatients > treatedPatients)
                {
                    lekari++;
                }

                if (pacienti <= lekari)
                {
                    unTreatedPatients = 0;
                    treatedPatients = pacienti;
                }
                else
                {
                    unTreatedPatients = Math.Max(pacienti, lekari) - Math.Min(pacienti, lekari);
                    //unTreatedPatients = (pacienti + lekari) - lekari - lekari;
                    treatedPatients = pacienti - unTreatedPatients;
                }
                sumTreated = sumTreated + treatedPatients;
                sumUntreatedPatients = sumUntreatedPatients + unTreatedPatients;
            }
            Console.WriteLine("Treated patients: {0}.", sumTreated);
            Console.WriteLine("Untreated patients: {0}.", sumUntreatedPatients);
        }
    }
}
