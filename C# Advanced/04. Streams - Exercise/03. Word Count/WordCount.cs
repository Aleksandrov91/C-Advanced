using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.Word_Count
{
    public class WordCount
    {
        public static void Main()
        {
            var wordsCount = new Dictionary<string, int>();
            var destinationFile = @"../../result.txt";

            Console.WriteLine("Enter the path to the word file:");
            var wordsPath = Console.ReadLine();
            while (!File.Exists(wordsPath))
            {
                Console.WriteLine("Invalid file.");
                Console.WriteLine("Please enter path again:");
                wordsPath = Console.ReadLine();
            }

            while (Path.GetExtension(wordsPath) != ".txt")
            {
                Console.WriteLine("Invalid file.");
                Console.WriteLine("Please enter path again:");
                wordsPath = Console.ReadLine();
            }
            Console.WriteLine("Enter the path to the text file:");
            var textFile = Console.ReadLine();

            while (!File.Exists(textFile))
            {
                Console.WriteLine("Invalid file.");
                Console.WriteLine("Please enter path again:");
                textFile = Console.ReadLine();
            }

            while (Path.GetExtension(textFile) != ".txt")
            {
                Console.WriteLine("Invalid file.");
                Console.WriteLine("Please enter path again:");
                textFile = Console.ReadLine();
            }

            using (StreamReader reader = new StreamReader(wordsPath))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    wordsCount.Add(line.ToLower(), 0);

                    line = reader.ReadLine();
                }
            }

            using (StreamReader reader = new StreamReader(textFile))
            {
                var line = reader.ReadLine();

                while (line != null)
                {
                    var lineArgs = Regex.Split(line, "\\W+");

                    for (int i = 0; i < lineArgs.Length; i++)
                    {
                        var currentWord = lineArgs[i].ToLower();
                        if (wordsCount.ContainsKey(currentWord))
                        {
                            wordsCount[currentWord]++;
                        }
                    }

                    line = reader.ReadLine();
                }
            }

            using (StreamWriter writer = new StreamWriter(destinationFile))
            {
                foreach (var word in wordsCount.OrderByDescending(c => c.Value))
                {
                    writer.WriteLine($"{word.Key} - {word.Value}");
                }
            }

            Console.WriteLine($"File has been saved in: {Path.GetFullPath(destinationFile)}");
        }
    }
}
