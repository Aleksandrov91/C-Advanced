namespace _12.Character_Multiplier
{
    using System;
    using System.Collections.Generic;

    public class CharacterMultiplier
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(' ');
            var firstString = new Queue<char>(input[0].ToCharArray());
            var secondString = new Queue<char>(input[1].ToCharArray());
            var result = 0;
            while (firstString.Count != 0 || secondString.Count != 0)
            {
                var sum = 1;
                if (firstString.Count != 0)
                {
                    sum *= firstString.Dequeue();
                }

                if (secondString.Count != 0)
                {
                    sum *= secondString.Dequeue();
                }

                result += sum;
            }

            Console.WriteLine(result);
        }
    }
}
