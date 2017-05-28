using System;

namespace Last_K_Numbers_Sums
{
    public class LastKNumbersSums
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            long[] sequence = new long[n];
            sequence[0] = 1;
            for (int i = 1; i < sequence.Length; i++)
            {
                if (i < k)
                {
                    for (int j = 0; j < i; j++)
                    {
                        sequence[i] += sequence[j];
                    }
                }
                else
                {
                    for (int q = k; q > 0; q--)
                    {
                        sequence[i] += sequence[i - q];
                    }
                }
            }

            Console.WriteLine(string.Join(" ", sequence));
        }
    }
}
