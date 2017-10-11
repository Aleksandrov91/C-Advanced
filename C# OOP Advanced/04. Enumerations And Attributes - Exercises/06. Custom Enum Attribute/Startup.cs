namespace _06.Custom_Enum_Attribute
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var attributesInfo = Console.ReadLine();
            object[] attributes;

            if (attributesInfo == "Rank")
            {
                attributes = typeof(CardRank).GetCustomAttributes(false);
            }
            else
            {
                attributes = typeof(CardSuit).GetCustomAttributes(false);
            }
            
            foreach (TypeAttribute attr in attributes)
            {
                Console.WriteLine($"Type = {attr.Type}, Description = {attr.Description}");
            }
        }
    }
}
