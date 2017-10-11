namespace _01.ListyIterator
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var customCollection = new ListyIterator<string>();

            string inputLine;

            while ((inputLine = Console.ReadLine()) != "END")
            {
                var inputArgs = inputLine.Split(new []{' '}, StringSplitOptions.RemoveEmptyEntries).ToList();
                var command = inputArgs[0];
                inputArgs.RemoveAt(0);

                switch (command)
                {
                    case "Create":
                        customCollection.Create(inputArgs);
                        break;
                    case "Move":
                        Console.WriteLine(customCollection.Move());
                        break;
                    case "Print":
                        try
                        {
                            Console.WriteLine(customCollection.Print());
                        }
                        catch (ArgumentException e)
                        {
                            Console.WriteLine(e.Message);
                        }

                        break;
                    case "HasNext":
                        Console.WriteLine(customCollection.HasNext());
                        break;
                    case "PrintAll":
                        foreach (var element in customCollection)
                        {
                            Console.Write(element + " ");
                        }

                        Console.WriteLine();
                        break;
                }
            }
        }
    }
}
