using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class Phonebook
    {
        public static void Main()
        {
            var phonebook = new Dictionary<string, string>();

            while (true)
            {
                var input = Console.ReadLine().Split(' ');
                var command = input[0];

                if (command == "S")
                {
                    Search(input, phonebook);
                }
                else if (command == "A")
                {
                    Add(input, phonebook);
                }
                else if (command == "END")
                {
                    break;
                }
            }
        }

        public static Dictionary<string, string> Add(string[] input, Dictionary<string, string> phonebook)
        {
            var name = input[1];
            var number = input[2];
            phonebook[name] = number;
            return phonebook;
        }

        public static void Search(string[] input, Dictionary<string, string> phonebook)
        {
            var name = input[1];

            bool isExist = phonebook.ContainsKey(name);
            if (isExist)
            {
                Console.WriteLine($"{name} -> {phonebook[name]}");
            }
            else
            {
                Console.WriteLine($"Contact {name} does not exist.");
            }
        }
    }
}
