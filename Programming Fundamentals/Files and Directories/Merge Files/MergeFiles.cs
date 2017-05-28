using System.Collections.Generic;
using System.IO;

namespace Merge_Files
{
    public class MergeFiles
    {
        public static void Main()
        {
            var firstFile = File.ReadAllLines("FileOne.txt");
            var secondFIle = File.ReadAllLines("FileTwo.txt");
            var result = new List<int>();

            for (int i = 0; i < firstFile.Length; i++)
            {
                var currentNum = int.Parse(firstFile[i]);
                result.Add(currentNum);
            }

            for (int i = 0; i < secondFIle.Length; i++)
            {
                var currentNum = int.Parse(secondFIle[i]);
                result.Add(currentNum);
            }

            result.Sort();
            File.WriteAllText("result.txt", string.Join("\r\n", result));
        }
    }
}
