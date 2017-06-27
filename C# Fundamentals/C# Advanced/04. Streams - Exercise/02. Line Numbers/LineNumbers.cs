using System;
using System.IO;

namespace _02.Line_Numbers
{
    public class LineNumbers
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a path to text file:");
            var path = Console.ReadLine();
            var destinationFile = @"../../result.txt";

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
                using (StreamWriter writer = new StreamWriter(destinationFile))
                {
                    var lineNumber = 0;
                    var line = reader.ReadLine();

                    while (line != null)
                    {
                        writer.WriteLine($"Line {lineNumber}: {line}");
                        lineNumber++;
                        line = reader.ReadLine();
                    }
                }
            }

            Console.WriteLine($"File has been saved in: {Path.GetFullPath(destinationFile)}");
        }
    }
}
