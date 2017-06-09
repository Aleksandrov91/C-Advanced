﻿using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace _06.Zipping_Sliced_Files
{
    public class ZippingSlicedFiles
    {
        public static void Main()
        {
            var sourceFile = string.Empty;
            var destinationDirectory = string.Empty;
            Console.WriteLine("1 - for slice a file to n parts");
            Console.WriteLine("2 - for assemble parts in one file");
            Console.Write("Choose action (1 or 2): ");
            var choise = int.Parse(Console.ReadLine());
            switch (choise)
            {
                case 1:
                    Console.Write("Enter number of parts: ");
                    int parts = int.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the path to file:");
                    sourceFile = Console.ReadLine();

                    while (!File.Exists(sourceFile))
                    {
                        Console.WriteLine("Invalid file.");
                        Console.WriteLine("Please enter path again:");
                        sourceFile = Console.ReadLine();
                    }

                    destinationDirectory = @"../../SlicedDir/";
                    CreateFolder(destinationDirectory);
                    Slice(sourceFile, destinationDirectory, parts);
                    Console.WriteLine($"Your file has been comrpressed in {Path.GetFullPath(destinationDirectory)}");
                    break;
                case 2:
                    Console.WriteLine("Enter the directory path to files:");
                    sourceFile = Console.ReadLine();
                    destinationDirectory = @"../../AssembledDir/";
                    var files = Directory.GetFiles(sourceFile).ToList();
                    if (files.Count == 0)
                    {
                        Console.WriteLine("The choosen folder is empty. Try again.");
                        return;
                    }
                    CreateFolder(destinationDirectory);
                    Assemble(files, destinationDirectory);
                    Console.WriteLine($"Your files has been decompressed in {Path.GetFullPath(destinationDirectory)}");
                    break;
                default:
                    Console.WriteLine("Wrong selection. Please try again.");
                    return;
            }
        }

        private static void CreateFolder(string directory)
        {
            bool exists = Directory.Exists(directory);

            if (!exists)
            {
                Directory.CreateDirectory(directory);
            }
        }

        private static void Assemble(List<string> files, string destinationDirectory)
        {
            var lastDot = files[0].LastIndexOf('.');
            var fileExtension = Path.GetExtension(files[0].Substring(0, lastDot));
            using (FileStream writer = new FileStream(destinationDirectory + "\\" + "Assembled" + fileExtension, FileMode.Create,
                FileAccess.Write))
            {
                foreach (var file in files)
                {
                    using (FileStream reader = new FileStream(file, FileMode.Open))
                    using (GZipStream unZipStream = new GZipStream(reader, CompressionMode.Decompress, false))
                    {
                        var buffer = new byte[4096];
                        int readBytes = unZipStream.Read(buffer, 0, buffer.Length);

                        while (readBytes != 0)
                        {
                            writer.Write(buffer, 0, readBytes);
                            readBytes = unZipStream.Read(buffer, 0, readBytes);
                        }
                    }
                }
            }


            Console.WriteLine("Assembling Done.");
        }

        private static void Slice(string sourcePath, string destinationDirectory, int parts)
        {
            var fileExtension = Path.GetExtension(sourcePath);

            using (FileStream reader = new FileStream(sourcePath, FileMode.Open))
            {
                int partLength = (int)Math.Ceiling((double)reader.Length / parts);
                var buffer = new byte[partLength];

                var i = 0;
                while (true)
                {
                    int readBytes = reader.Read(buffer, 0, buffer.Length);

                    if (readBytes == 0)
                    {
                        break;
                    }

                    using (FileStream outputFile =
                        new FileStream($"{destinationDirectory}\\part-{i}{fileExtension}.gz", FileMode.CreateNew, FileAccess.Write))
                    using (GZipStream zipStream = new GZipStream(outputFile, CompressionMode.Compress))
                    {
                        zipStream.Write(buffer, 0, readBytes);
                        i++;
                    }
                }
            }

            Console.WriteLine("Slicing Done.");
        }
    }
}
