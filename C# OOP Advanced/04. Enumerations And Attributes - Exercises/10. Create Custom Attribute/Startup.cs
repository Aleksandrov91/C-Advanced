namespace _10.Create_Custom_Attribute
{
    using System;
    using Attributes;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            while (input != "END")
            {
                var attributes = typeof(Weapon).GetCustomAttributes(false);


                foreach (MyCustomAttribute attr in attributes)
                {
                    switch (input)
                    {
                        case "Author":
                            Console.WriteLine($"Author: {attr.Author}");
                            break;
                        case "Revision":
                            Console.WriteLine($"Revision: {attr.Revision}");
                            break;
                        case "Description":
                            Console.WriteLine($"Class description: {attr.Description}");
                            break;
                        case "Reviewers":
                            Console.WriteLine($"Reviewers: {string.Join(", ", attr.Reviewers)}");
                            break;
                        default:
                            break;
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}
