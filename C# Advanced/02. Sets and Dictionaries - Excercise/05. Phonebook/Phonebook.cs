using System;
using System.Collections.Generic;

namespace _05.Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var phonebook = new Dictionary<string, string>();

            while (input != "search")
            {
                var args = input.Split('-');
                var name = args[0];
                var phonenumber = args[1];

                if (!phonebook.ContainsKey(name))
                {
                    phonebook[name] = phonenumber;
                }
                else
                {
                    phonebook[name] = phonenumber;
                }

                input = Console.ReadLine();
            }

            input = Console.ReadLine();

            while (input != "stop")
            {
                if (phonebook.ContainsKey(input))
                {
                    Console.WriteLine($"{input} -> {phonebook[input]}");
                }
                else
                {
                    Console.WriteLine($"Contact {input} does not exist.");
                }

                input = Console.ReadLine();
            }
        }
    }
}
