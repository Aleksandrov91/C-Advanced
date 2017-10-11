namespace _08.Card_Game
{
    using System;
    using System.Collections.Generic;
    using Comparators;

    public class Startup
    {
        public static void Main()
        {
            var deck = new SortedSet<Card>(new CardComparator());
            GenerateDeck(ref deck);

            var firstPlayerName = Console.ReadLine();
            var secondPlayerName = Console.ReadLine();

            var firstPlayer = new Player(firstPlayerName);
            var secondPlayer = new Player(secondPlayerName);

            AddPlayerCard(firstPlayer, deck);
            AddPlayerCard(secondPlayer, deck);

            var winner = firstPlayer.BiggestCard.CompareTo(secondPlayer.BiggestCard);

            if (winner >= 0)
            {
                Console.WriteLine(firstPlayer);
            }
            else
            {
                Console.WriteLine(secondPlayer);
            }
        }

        private static void GenerateDeck(ref SortedSet<Card> deck)
        {
            foreach (CardSuit cardSuit in Enum.GetValues(typeof(CardSuit)))
            {
                foreach (CardRank cardRank in Enum.GetValues(typeof(CardRank)))
                {
                    deck.Add(new Card(cardRank.ToString(), cardSuit.ToString()));
                }
            }
        }

        private static void AddPlayerCard(Player player, SortedSet<Card> deck)
        {
            while (player.HandOfCardsCount < 5)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                try
                {
                    var card = new Card(input[0], input[2]);
                
                    if (deck.Contains(card))
                    {
                        player.AddCard(card);
                        deck.Remove(card);
                    }
                    else
                    {
                        Console.WriteLine("Card is not in the deck.");
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
