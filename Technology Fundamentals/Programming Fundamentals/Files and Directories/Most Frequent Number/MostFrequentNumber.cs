using System;
using System.Linq;
using System.IO;

namespace Most_Frequent_Number
{
    public class MostFrequentNumber
    {
        public static void Main()
        {
            var input = File.ReadAllText("../../Input.txt").Split().Select(int.Parse).ToList();
            int count = 1;
            int maxCount = 0;
            int freqNum = 0;
            for (int i = 0; i < input.Count; i++)
            {
                var firstNum = input[i];
                for (int j = i + 1; j < input.Count; j++)
                {
                    var secondNum = input[j];
                    if (firstNum == secondNum)
                    {
                        count++;
                    }
                }

                if (count > maxCount)
                {
                    freqNum = firstNum;
                    maxCount = count;
                    count = 1;
                }

                count = 1;
            }

            File.WriteAllText("../../Result.txt", freqNum.ToString());
        }
    }
}
