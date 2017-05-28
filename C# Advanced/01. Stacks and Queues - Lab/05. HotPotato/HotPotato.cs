using System;
using System.Collections.Generic;

namespace _05.HotPotato
{
    public class HotPotato
    {
        public static void Main()
        {
            var childs = Console.ReadLine().Split();
            var count = int.Parse(Console.ReadLine());
            var game = new Queue<string>(childs);

            while (game.Count != 1)
            {
                for (int i = 1; i < count; i++)
                {
                    game.Enqueue(game.Dequeue());
                }

                Console.WriteLine($"Removed {game.Dequeue()}");
            }

            Console.WriteLine($"Last is {game.Dequeue()}");
        }
    }
}
