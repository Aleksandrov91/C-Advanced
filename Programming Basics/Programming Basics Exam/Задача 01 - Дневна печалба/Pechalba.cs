using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задача_01___Дневна_печалба
{
    class Pechalba
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double m = double.Parse(Console.ReadLine());
            double kurs = double.Parse(Console.ReadLine());

            double mesechnaZaplata = n * m;
            double godishnaZaplata = mesechnaZaplata * 12;
            double bonus = godishnaZaplata + (2.5 * mesechnaZaplata);
            double danuci = bonus * 0.25;
            double chistGodishenDohod = bonus - danuci;
            double dohodVbgn = chistGodishenDohod * kurs;
            dohodVbgn = dohodVbgn / 365;

            Console.WriteLine("{0:f2}", dohodVbgn);
        }
    }
}
