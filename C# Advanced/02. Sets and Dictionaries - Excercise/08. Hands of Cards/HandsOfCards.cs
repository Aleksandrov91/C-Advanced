using System;
using System.Collections.Generic;

namespace _08.Hands_of_Cards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var input = Console.ReadLine();

            var handOfCards = new Dictionary<string, HashSet<string>>();

            while (input != "JOKER")
            {
                var args = input.Split(new[] { ':' }, StringSplitOptions.RemoveEmptyEntries);
                var name = args[0];
                var cards = args[1].Split(new[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (!handOfCards.ContainsKey(name))
                {
                    handOfCards[name] = new HashSet<string>();
                }

                handOfCards[name].UnionWith(cards);

                input = Console.ReadLine();
            }

            foreach (var player in handOfCards)
            {
                var playerResult = 0;
                Console.Write($"{player.Key}: ");

                foreach (var result in player.Value)
                {
                    playerResult += SumCards(result);
                }

                Console.WriteLine(playerResult);
            }
        }

        public static int SumCards(string card)
        {
            var value = 0;

            for (int i = 0; i < card.Length; i++)
            {

                var cardPower = card.Substring(0, card.Length - 1);
                var cardType = card.Substring(card.Length - 1);

                value = CardPower(cardPower) * CardType(cardType);
            }

            return value;
        }

        public static int CardPower(string cardPower)
        {
            var power = 0;

            switch (cardPower)
            {
                case "J":
                    power = 11;
                    break;
                case "Q":
                    power = 12;
                    break;
                case "K":
                    power = 13;
                    break;
                case "A":
                    power = 14;
                    break;
                default:
                    int.TryParse(cardPower, out power);
                    break;
            }

            return power;
        }

        public static int CardType(string cardType)
        {
            var multiplier = 0;

            switch (cardType)
            {
                case "C":
                    multiplier = 1;
                    break;
                case "H":
                    multiplier = 3;
                    break;
                case "D":
                    multiplier = 2;
                    break;
                case "S":
                    multiplier = 4;
                    break;
            }

            return multiplier;
        }
    }
}
