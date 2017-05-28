using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Cubic_Messages
{
    public class CubicMessages
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "Over!")
            {
                var nums = new List<int>();
                var length = int.Parse(Console.ReadLine());
                string pattern = $@"^([0-9]+)([a-zA-Z]{{{length}}})([^a-zA-Z]*)$";
                var regex = new Regex(pattern);
                var match = regex.Match(input);
                var decryptedText = match.Groups[2].ToString();
                GetNumbers(match.Groups[1].ToString(), nums);
                GetNumbers(match.Groups[3].ToString(), nums);
                var result = Verification(decryptedText, nums);
                if (decryptedText != string.Empty)
                {
                    Console.WriteLine($"{decryptedText} == {result}");
                }

                input = Console.ReadLine();
            }
        }

        public static void GetNumbers(string numbers, List<int> indexes)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (char.IsDigit(numbers[i]))
                {
                    indexes.Add(int.Parse(numbers[i].ToString()));
                }
            }
        }

        public static string Verification(string decryptedText, List<int> nums)
        {
            var sb = new StringBuilder();
            for (int i = 0; i < nums.Count; i++)
            {
                if (nums[i] >= 0 && nums[i] < decryptedText.Length)
                {
                    sb.Append(decryptedText[nums[i]]);
                }
                else
                {
                    sb.Append(" ");
                }
            }

            return sb.ToString();
        }
    }
}
