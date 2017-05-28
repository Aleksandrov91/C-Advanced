using System.IO;

namespace Index_of_Letters
{
    public class IndexOfLetters
    {
        public static void Main()
        {
            var input = File.ReadAllText("../../Input.txt");
            var result = new int[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                var currentChar = input[i];
                result[i] = (currentChar - 'a');
                string results = $"{currentChar} -> {result[i]}\r\n";
                File.AppendAllText ("../../Result.txt", results);
            }
        }
    }
}
