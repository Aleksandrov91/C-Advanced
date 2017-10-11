namespace _03.Card_Power
{
    using System;
    using System.Collections.Generic;
    using Models;

    public class Startup
    {
        public static void Main()
        {
            
        }

        private static void AddCardsToDeck(ref List<Card> deck)
        {
            foreach (CardSuit cardSuit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardRank cardRank in Enum.GetValues(typeof(CardRank)))
                {
                    // deck.Add(new Card(cardRank, cardSuit));
                }
            }
        }
    }
}
