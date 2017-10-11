namespace _16.Extract_Hyperlinks
{
    using System;
    using System.Text;

    public class ExtractHyperlinks
    {
        public static void Main()
        {
            var line = Console.ReadLine();
            var html = new StringBuilder();
            while (line != "END")
            {
                html.Append(line);
                line = Console.ReadLine();
            }
        }
    }
}
