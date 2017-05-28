using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Count_Real_Numbers
{
    public class CountRealNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ').Select(double.Parse);

            var realNums = new SortedDictionary<double, int>();

            foreach (var num in input)
            {
                if (!realNums.ContainsKey(num))
                {
                    realNums[num] = 0;
                }
                realNums[num]++;
            }
            foreach (var item in realNums)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }
    }
}
