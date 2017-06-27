namespace _12.Little_John
{
    using System;
    using System.Text;
    using System.Text.RegularExpressions;

    public class LittleJohn
    {
        public static void Main()
        {
            string arrowMatcher = "(>>>----->>)|(>>----->)|(>----->)";

            var smallArrowsCount = 0;
            var mediumArrowsCount = 0;
            var largeArrowsCount = 0;

            var input = new StringBuilder();

            for (int i = 0; i < 4; i++)
            {
                input.Append(Console.ReadLine()).Append(" ");
            }

            var matches = Regex.Matches(input.ToString(), arrowMatcher);

            foreach (Match match in matches)
            {
                if (match.Groups[1].Value != string.Empty)
                {
                    largeArrowsCount++;
                }
                else if (match.Groups[2].Value != string.Empty)
                {
                    mediumArrowsCount++;
                }
                else if (match.Groups[3].Value != string.Empty)
                {
                    smallArrowsCount++;
                }
            }

            var arrowCount = smallArrowsCount.ToString() + mediumArrowsCount.ToString() + largeArrowsCount.ToString();

            var binary = Convert.ToString(Convert.ToInt32(arrowCount, 10), 2);
            var reversedBinary = ReverseString(binary);
            var cryptedMessage = binary + reversedBinary;
            var dec = Convert.ToString(Convert.ToInt32(cryptedMessage, 2), 10);
            Console.WriteLine(dec);
        }

        public static string ReverseString(string s)
        {
            char[] arr = s.ToCharArray();
            Array.Reverse(arr);
            return new string(arr);
        }
    }
}
