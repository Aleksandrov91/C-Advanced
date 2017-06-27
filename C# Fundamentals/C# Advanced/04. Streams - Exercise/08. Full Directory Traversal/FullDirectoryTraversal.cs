using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _08.Full_Directory_Traversal
{
    public class FullDirectoryTraversal
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

            var filesByExtension = new SortedDictionary<string, Dictionary<string, string>>();

            DirSearch(path, filesByExtension);

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

        private static void DirSearch(string path, SortedDictionary<string, Dictionary<string, string>> filesByExtension)
        {
            var directories = Directory.GetDirectories(path);

            foreach (var directory in directories)
            {
                var files = Directory.GetFiles(directory);

                foreach (var file in files)
                {
                    var fileInfo = new FileInfo(file);
                    var fileName = Path.GetFileName(file);
                    var extension = Path.GetExtension(file);
                    var fileSize = CovertToKb(fileInfo.Length);

                    if (!filesByExtension.ContainsKey(extension))
                    {
                        filesByExtension[extension] = new Dictionary<string, string>() { { fileName, fileSize } };
                    }
                    else
                    {
                        filesByExtension[extension][fileName] = fileSize;
                    }
                }

                DirSearch(directory, filesByExtension);
            }
        }

        private static string CovertToKb(long fileInfo)
        {
            return $"{fileInfo / 1024.0:F3} kb";
        }
    }
}
