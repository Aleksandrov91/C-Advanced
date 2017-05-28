using System;
using System.Collections.Generic;
using System.Linq;

namespace Phonebook
{
    public class PhonebookUpgrade
    {
        public static void Main()
        {
            var phonebook = new SortedDictionary<string, string>();

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
                else if (command == "ListAll")
                {
                    ListAll(phonebook);
                }
                else if (command == "END")
                {
                    break;
                }
            }
        }

        public static void ListAll(SortedDictionary<string, string> phonebook)
        {
            foreach (var item in phonebook)
            {
                Console.WriteLine($"{item.Key} -> {item.Value}");
            }
        }

        public static SortedDictionary<string, string> Add(string[] input, SortedDictionary<string, string> phonebook)
        {
            var name = input[1];
            var number = input[2];
            phonebook[name] = number;
            return phonebook;
        }

        public static void Search(string[] input, SortedDictionary<string, string> phonebook)
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
