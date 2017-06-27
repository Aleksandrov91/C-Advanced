namespace _13.Office_Stuff
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class OfficeStuff
    {
        public static void Main()
        {
            var lines = int.Parse(Console.ReadLine());
            var officeStuffs = new SortedDictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < lines; i++)
            {
                var input = Console.ReadLine();
                var inputData = input.Split('-');
                var company = inputData[0].Substring(1).Trim();
                var amount = int.Parse(inputData[1]);
                var product = inputData[2].Substring(0, inputData[2].Length - 1).Trim();

                if (!officeStuffs.ContainsKey(company))
                {
                    officeStuffs[company] = new Dictionary<string, int>();
                }

                if (!officeStuffs[company].ContainsKey(product))
                {
                    officeStuffs[company][product] = 0;
                }

                officeStuffs[company][product] += amount;
            }

            foreach (var company in officeStuffs)
            {
                Console.Write($"{company.Key}: ");

                Console.WriteLine($"{string.Join(", ", company.Value.Select(x => $"{x.Key}-{x.Value}"))}");
            }
        }
    }
}
