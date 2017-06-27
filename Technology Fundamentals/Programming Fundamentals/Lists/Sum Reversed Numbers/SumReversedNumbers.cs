using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Reversed_Numbers
{
    public class SumReversedNumbers
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var result = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                char[] temp = input[i].ToCharArray();
                Array.Reverse(temp);
                var text = new string(temp);
                int num = int.Parse(text);
                result.Add(num);
            }
            result.Reverse();
            int sum = result.Sum();
            Console.WriteLine(sum);
        }
    }
}
