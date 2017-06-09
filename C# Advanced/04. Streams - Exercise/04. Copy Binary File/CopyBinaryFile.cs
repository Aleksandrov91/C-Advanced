using System;
using System.IO;

namespace _04.Copy_Binary_File
{
    public class CopyBinaryFile
    {
        public static void Main()
        {
            Console.WriteLine("Please write path to file:");
            var path = Console.ReadLine();

            while (!File.Exists(path))
            {
                Console.WriteLine("Invalid file.");
                Console.WriteLine("Please enter path again:");
                path = Console.ReadLine();
            }

            var fileExtension = Path.GetExtension(path);
            var fileName = Path.GetFileNameWithoutExtension(path);

            var coppiedFile = @"../../" + fileName + "-copy" + fileExtension;

            using (FileStream source = new FileStream(path, FileMode.Open))
            {
                using (FileStream destination = new FileStream(coppiedFile, FileMode.Create))
                {
                    while (true)
                    {
                        var buffer = new byte[4096];
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }

            Console.WriteLine($"File has been copied in: {Path.GetFullPath(coppiedFile)}");
        }
    }
}
