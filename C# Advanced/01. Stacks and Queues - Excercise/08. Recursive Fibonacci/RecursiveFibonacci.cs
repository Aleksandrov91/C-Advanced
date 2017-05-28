using System;

namespace _08.Recursive_Fibonacci
{
    public class RecursiveFibonacci
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());

            Console.WriteLine(GetFibonacci(n, 1, 0, 1)); 
        }

        public static long GetFibonacci(int n, int count, long a, long b)
        {
            var temp = a;
            a = b;
            b = temp + b;

            count++;

            if (count == n)
            {
                return b;
            }
            else
            {
                return GetFibonacci(n, count, a, b);
            }            
        }
    }
}
