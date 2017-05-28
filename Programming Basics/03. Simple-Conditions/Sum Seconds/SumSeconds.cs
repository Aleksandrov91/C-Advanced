using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class SumSeconds
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            int sum = a + b + c;
            if (sum < 10)
            {
                Console.WriteLine("0:0{0}", sum);
            }
            else if (sum < 60)
            {
                Console.WriteLine("0:{0}",sum);
            }
            else if (sum < 70)
            {
                Console.WriteLine("1:0{0}",(sum - 60));
            }
            else if (sum < 120)
            {
                Console.WriteLine("1:{0}",(sum - 60));
            }
            else if (sum < 130)
            {
                Console.WriteLine("2:0{0}",(sum - 120));
            }
            else if (sum < 180)
            {
                Console.WriteLine("2:" + (sum - 120));
            }
        }
    }
}
