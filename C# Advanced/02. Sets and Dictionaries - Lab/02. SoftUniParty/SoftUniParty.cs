using System;
using System.Collections.Generic;

namespace _02.SoftUniParty
{
    public class SoftUniParty
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var reservations = new SortedSet<string>();

            while (true)
            {
                if (input == "PARTY")
                {
                    while (true)
                    {
                        if (input == "END")
                        {
                            Console.WriteLine(reservations.Count);
                            Console.WriteLine(string.Join("\r\n", reservations));
                            return;
                        }

                        reservations.RemoveWhere(x => x == input);

                        //if (reservations.Contains(input))
                        //{
                        //    reservations.Remove(input);
                        //}

                        input = Console.ReadLine();
                    }
                }
                else
                {
                    reservations.Add(input);
                }

                input = Console.ReadLine();
            }            
        }
    }
}
