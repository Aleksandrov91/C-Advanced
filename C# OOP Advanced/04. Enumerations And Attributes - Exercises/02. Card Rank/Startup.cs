namespace _02.Card_Rank
{
    using System;

    public class Startup
    {
        public static void Main()
        {
            var cardRank = Enum.GetValues(typeof(CardRank));

            Console.WriteLine("Card Ranks:");
            foreach (var card in cardRank)
            {
                Console.WriteLine($"Ordinal value: {(int)card}; Name value: {card}");
            }
        }
    }
}
