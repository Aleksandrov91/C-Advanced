using System;
using System.Collections.Generic;
using System.Linq;

namespace Hands_of_Cards
{
    public class HandsOfCards
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var cardsPower = GetCardPower();
            var cardsType = GetCardType();
            var cards = new Dictionary<string, HashSet<int>>();


            while (input != "JOKER")
            {
                var name = input.Split(':');
                var playerCards = name[1].Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries).Distinct().ToList();
                foreach (var card in playerCards)
                {
                    var cardPower = card.Substring(0 , card.Length - 1);
                    var cardType = card.Substring(card.Length - 1);
                    var sum = cardsPower[cardPower] * cardsType[cardType];
                    if (!cards.ContainsKey(name[0]))
                    {
                        cards[name[0]] = new HashSet<int>();
                    }
                    cards[name[0]].Add(sum);
                }
                input = Console.ReadLine();
            }

            foreach (var player in cards)
            {
                Console.WriteLine($"{player.Key}: {player.Value.Sum()}");
            }
        }

        public static Dictionary<string, int> GetCardPower()
        {
            var cardPower = new Dictionary<string, int>();
            for (int i = 2; i <= 10; i++)
            {
                var key = i.ToString(); // {"2", 2}
                cardPower[key] = i;
            }

            cardPower["J"] = 11;
            cardPower["Q"] = 12;
            cardPower["K"] = 13;
            cardPower["A"] = 14;

            return cardPower;
        }

        public static Dictionary<string, int> GetCardType()
        {
            var cardType = new Dictionary<string, int>();
            cardType["S"] = 4;
            cardType["H"] = 3;
            cardType["D"] = 2;
            cardType["C"] = 1;

            return cardType;
        }
    }
}
