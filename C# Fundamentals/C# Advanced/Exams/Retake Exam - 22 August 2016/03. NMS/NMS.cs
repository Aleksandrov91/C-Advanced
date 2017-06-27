namespace _03.NMS
{
    using System;
    using System.Text;

    public class NMS
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine();
            var text = new StringBuilder();
            var result = new StringBuilder();

            while (inputLine != "---NMS SEND---")
            {
                text.Append(inputLine);
                inputLine = Console.ReadLine();
            }

            var delimiter = Console.ReadLine();

            for (int i = 1; i < text.Length; i++)
            {
                if (char.ToLower(text[i - 1]) <= char.ToLower(text[i]))
                {
                    result.Append(text[i - 1]);
                }
                else
                {
                    result.Append(text[i - 1]).Append(delimiter);
                }
            }

            result.Append(text[text.Length - 1]);

            Console.WriteLine(result);
        }
    }
}
