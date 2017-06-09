using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _07.Directory_Traversal
{
    public class DirectoryTraversal
    {
        public static void Main()
        {
            Console.WriteLine("Please enter a directory path:");
            var path = Console.ReadLine();

            while (!Directory.Exists(path))
            {
                Console.WriteLine("Invalid path. Please enter valid path:");
                path = Console.ReadLine();
            }

            var files = Directory.GetFiles(path);
            var filesByExtension = new SortedDictionary<string, Dictionary<string, string>>();

            for (int i = 0; i < files.Length; i++)
            {
                var fileInfo = new FileInfo(files[i]);
                var currentFile = Path.GetFileName(files[i]);
                var extension = Path.GetExtension(files[i]);
                string fileSize = CovertToKb(fileInfo.Length);

                if (!filesByExtension.ContainsKey(extension))
                {
                    filesByExtension[extension] = new Dictionary<string, string>(){{currentFile, fileSize}};
                }
                else
                {
                    filesByExtension[extension].Add(currentFile, fileSize);
                }
            }

            var resultPath = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\\report.txt";
            using (StreamWriter writer = new StreamWriter(resultPath))
            {
                foreach (var kvp in filesByExtension.OrderByDescending(x => x.Value.Count))
                {
                    writer.WriteLine(kvp.Key);
                    foreach (var entry in kvp.Value.OrderBy(x => x.Value))
                    {
                        writer.WriteLine($"--{entry.Key} - {entry.Value}");
                    }
                }
            }

            Console.WriteLine("File has been saved on your desktop");
        }


        private static string CovertToKb(long fileInfo)
        {
            return $"{fileInfo / 1024.0:F3} kb";
        }
    }
}
