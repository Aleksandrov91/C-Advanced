using System;
using System.Collections.Generic;

namespace _06.MathPotato
{
    public class MathPotato
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split();
            var count = int.Parse(Console.ReadLine());
            var game = new Queue<string>(input);
            int cycle = 1;

            while (game.Count != 1)
            {
                for (int i = 1; i < count; i++)
                {
                    game.Enqueue(game.Dequeue());
                }

                if (IsPrime(cycle))
                {
                    Console.WriteLine($"Prime {game.Peek()}");
                }
                else
                {
                    Console.WriteLine($"Removed {game.Dequeue()}");
                }

                cycle++;
            }

            Console.WriteLine($"Last is {game.Dequeue()}");
        }

        public static bool IsPrime(int number)
        {
            if ((number & 1) == 0)
            {
                if (number == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the end.
            for (int i = 3; (i * i) <= number; i += 2)
            {
                if ((number % i) == 0)
                {
                    return false;
                }
            }

            return number != 1;
        }
    }
}
