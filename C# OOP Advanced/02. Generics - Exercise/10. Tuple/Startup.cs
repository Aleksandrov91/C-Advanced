namespace _10.Tuple
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var inputLine = Console.ReadLine().Split(' ');

            var stringTuple = new Tuple<string, string, string>(inputLine[0] + " " + inputLine[1], inputLine[2], inputLine[3]);
            Console.WriteLine(stringTuple.ToString());

            inputLine = Console.ReadLine().Split(' ');
            var stringAdnInt = new Tuple<string, int, bool>(inputLine[0], int.Parse(inputLine[1]), inputLine[2].Equals("drunk"));
            Console.WriteLine(stringAdnInt.ToString());

            inputLine = Console.ReadLine().Split(' ');
            var intAndDouble = new Tuple<string, double, string>(inputLine[0], double.Parse(inputLine[1]), inputLine[2]);
            Console.WriteLine(intAndDouble.ToString());
        }
    }
}
