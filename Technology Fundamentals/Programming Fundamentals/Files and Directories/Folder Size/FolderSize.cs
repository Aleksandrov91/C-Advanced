using System;
using System.IO;

namespace Folder_Size
{
    public class FolderSize
    {
        public static void Main()
        {
            var files = Directory.GetFiles("TestFolder");
            double sum = 0;
            foreach (var file in files)
            {
                FileInfo fileInfo = new FileInfo(file);
                sum += fileInfo.Length;
            }
            sum = (sum / 1024.0 / 1024.0);
            Console.WriteLine(sum);
        }
    }
}
