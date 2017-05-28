using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Stupid_Password_Generator
{
    class StupidPasswordGenerator
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int l = int.Parse(Console.ReadLine());
            for (int s1 = 1; s1 <= n; s1++)
  //            for (var d2 = 1; d2 <= n; d2++)
                for (int s2 = 1; s2 <= n; s2++)
  //            for (var d2 = 1; d2 <= n; d2++)
                    for (var s3 = 'a'; s3 < 'a' + 1; s3++)
  //                for (var l1 = 'a'; l1< 'a' + l; l1++)
                        for (var s4 = 'a'; s4 < 'a' + 1; s4++)
  //                    for (var l2 = 'a'; l2< 'a' + l; l2++)
                            for (int s5 = Math.Max(s1, s2) + 1; s5 <= n; s5++)
                            {
                                Console.Write("{0}{1}{2}{3}{4} ", s1, s2, s3, s4, s5);
                            }
            Console.WriteLine();
            
            //        Console.WriteLine();
        }
    }
}
