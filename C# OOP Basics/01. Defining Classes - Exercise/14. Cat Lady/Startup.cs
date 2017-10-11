namespace _14.Cat_Lady
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var cats = new List<Cat>();
            var inputLine = Console.ReadLine();

            while (inputLine != "End")
            {
                var inputData = inputLine.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var catBreed = inputData[0];
                var catName = inputData[1];
                var catParams = double.Parse(inputData[2]);
                Cat cat;

                switch (catBreed)
                {
                    case "StreetExtraordinaire":
                        cat = new StreetExtraordinaire(catName, catParams);
                        cats.Add(cat);
                        break;
                    case "Siamese":
                        cat = new Siamese(catName, catParams);
                        cats.Add(cat);
                        break;
                    case "Cymric":
                        cat = new Cymric(catName, catParams);
                        cats.Add(cat);
                        break;
                }

                inputLine = Console.ReadLine();
            }

            var catToPrint = Console.ReadLine();

            Console.WriteLine(cats.FirstOrDefault(c => c.Name == catToPrint).ToString());
        }
    }
}
