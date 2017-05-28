using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Max_Sequence_of_Equal_Elements
{
    public class MaxSequenceOfEqualElements
    {
        public static void Main()
        {
            var input = File.ReadAllText("../../Input.txt").Split().Select(int.Parse).ToList();
            var result = new List<int>();
            var temp = new List<int>();
            for (int i = 0; i < input.Count - 1; i++)
            {
                var currentNum = input[i];
                var nextNum = input[i + 1];
                if (currentNum == nextNum)
                {
                    temp.Add(currentNum);
                    if (temp.Count >= result.Count)
                    {
                        result.Clear();
                        result.AddRange(temp);
                        result.Add(currentNum);
                    }
                }
                else if (temp.Count >= result.Count)
                {
                    result.Clear();
                    result.AddRange(temp);
                    result.Add(currentNum);
                    temp.Clear();
                }
                else
                {
                    temp.Clear();
                }
            }

            File.WriteAllText("../../Result.txt", string.Join(" ", result));
        }
    }
}
