using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Equal_Sums
{
    public class EqualSums
    {
        public static void Main()
        {
            var input = File.ReadAllText("../../Input.txt").Split().Select(int.Parse).ToList();
            var result = new List<int>();
            for (int i = 0; i < input.Count; i++)
            {
                int currentIndex = i;
                int leftSum = 0;
                int rightSum = 0;
                for (int k = 0; k <= i - 1; k++)
                {
                    leftSum += input[k];
                }

                for (int j = i + 1; j < input.Count; j++)
                {
                    rightSum += input[j];
                }

                if (leftSum == rightSum)
                {
                    result.Add(currentIndex);
                    break;
                }
                else if (leftSum == 0 && rightSum == 0)
                {
                    result.Add(currentIndex);
                    break;
                }
            }

            if (result.Count == 0)
            {
                File.WriteAllText("Result.txt", "no");
                return;
            }

            File.WriteAllText("Result.txt", string.Join(string.Empty, result));
        }
    }
}
