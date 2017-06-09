using System;
using System.IO;

namespace _01.Odd_Lines
{
    public class OddLines
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a path to text file:");
            var path = Console.ReadLine();

            while (!File.Exists(path))
            {
                Console.WriteLine("Invalid file.");
                Console.WriteLine("Please enter path again:");
                path = Console.ReadLine();
            }

            while (Path.GetExtension(path) != ".txt")
            {
                Console.WriteLine("Invalid file.");
                Console.WriteLine("Please enter path again:");
                path = Console.ReadLine();
            }

            using (StreamReader reader = new StreamReader(path))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine(line);
                    }

                    lineNumber++;
                    line = reader.ReadLine();
                }
            }
        }
    }
}
