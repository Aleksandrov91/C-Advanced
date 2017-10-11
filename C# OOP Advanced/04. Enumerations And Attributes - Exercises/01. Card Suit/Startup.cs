namespace _01.Card_Suit
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var cardTypes = Enum.GetValues(typeof(CardSuits));

            Console.WriteLine("Card Suits:");
            foreach (var cardType in cardTypes)
            {
                Console.WriteLine($"Ordinal value: {(int)cardType}; Name value: {cardType}");
            }
        }
    }
}
