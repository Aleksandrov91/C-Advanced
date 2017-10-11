using System;

namespace Sieve_of_Eratosthenes
{
    public class SieveOfEratosthenes
    {
        public static void Main()
        {
            int input = int.Parse(Console.ReadLine());
            var isPrime = new bool[input + 1];

            for (int parsed = 0; parsed < isPrime.Length; parsed++)
            {
                isPrime[parsed] = true;
            }

            isPrime[0] = false;
            isPrime[1] = false;

            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    for (int j = 2; (j * i) < isPrime.Length; j++)
                    {
                        isPrime[j * i] = false;
                    }
                }                
            }

            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i] == true)
                {
                    Console.Write(i + " ");
                }
            }
            
        }
    }
}
