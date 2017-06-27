namespace _05.Concatenate_Strings
{
    using System;
    using System.Text;

    public class ConcatenateStrings
    {
        public static void Main()
        {
            var n = int.Parse(Console.ReadLine());
            var sb = new StringBuilder();

            for (int i = 0; i < n; i++)
            {
                var word = Console.ReadLine();
                sb.Append(word).Append(" ");
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
