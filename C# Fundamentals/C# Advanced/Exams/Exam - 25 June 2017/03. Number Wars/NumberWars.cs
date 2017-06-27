using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Number_Wars
{
    public class NumberWars
    {
        private static Queue<string> firstPlayerCards;
        private static Queue<string> secondPlayerCards;
        private static int turns = 1;
        private static bool hasWinner = false;

        public static void Main()
        {
            firstPlayerCards = new Queue<string>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Reverse());
            secondPlayerCards = new Queue<string>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Reverse());

            while (firstPlayerCards.Count != 0 && secondPlayerCards.Count != 0 && turns <= 1000000)
            {
                var equals = PutCard(firstPlayerCards.Dequeue(), secondPlayerCards.Dequeue());
                if (equals)
                {
                    MakeWar();
                }
                if (hasWinner)
                {
                    break;
                }
                turns++;
            }

            CheckWinner();
        }

        private static void CheckWinner()
        {
            if (secondPlayerCards.Count == 0 && firstPlayerCards.Count != 0 ||
                secondPlayerCards.Count < firstPlayerCards.Count)
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }
            else if (firstPlayerCards.Count == 0 && secondPlayerCards.Count != 0 ||
                firstPlayerCards.Count < secondPlayerCards.Count)
            {
                Console.WriteLine($"Second player wins after {turns} turns");
            }
            else if (firstPlayerCards.Count == secondPlayerCards.Count)
            {
                Console.WriteLine($"Draw after {turns}");
            }
        }

        private static bool PutCard(string firstCard, string secondCard)
        {
            var firstCardPower = int.Parse(firstCard.Substring(0, firstCard.Length - 1));
            var secondCardPower = int.Parse(secondCard.Substring(0, secondCard.Length - 1));
            var firstCharPower = (int)(firstCard[firstCard.Length - 1] - 'a');
            var secondCharPower = (int)(secondCard[secondCard.Length - 1] - 'a');
            int firstCardTotalPower = firstCardPower + firstCharPower;
            int secondCardTotalPower = secondCardPower + secondCharPower;

            if (firstCardPower > secondCardPower)
            {
                if (firstCardTotalPower >= secondCardTotalPower)
                {
                    firstPlayerCards.Enqueue(firstCard);
                    firstPlayerCards.Enqueue(secondCard);
                    return false;

                else
                {
                    firstPlayerCards.Enqueue(secondCard);
                    firstPlayerCards.Enqueue(firstCard);
                    return false;
                }
                
            }
            else if (firstCardPower < secondCardPower)
            {
                if (firstCardTotalPower > secondCardTotalPower)
                {
                    secondPlayerCards.Enqueue(firstCard);
                    secondPlayerCards.Enqueue(secondCard);
                    return false;
                }
                else
                {
                    secondPlayerCards.Enqueue(secondCard);
                    secondPlayerCards.Enqueue(firstCard);
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        private static void MakeWar()
        {
            if (firstPlayerCards.Count < 3 && secondPlayerCards.Count >= 3 ||
                secondPlayerCards.Count < 3 && firstPlayerCards.Count > 3)
            {
                CheckWinner();
                return;
            }
            else if (firstPlayerCards.Count == secondPlayerCards.Count)
            {
                Console.WriteLine($"Draws after {turns}");
                return;
            }

            var cards = new List<string>();
            var firstPWarPower = 0;
            var secondPWarPower = 0;
            for (int i = 0; i < 3; i++)
            {
                var firstPCard = firstPlayerCards.Dequeue();
                var secondPCard = secondPlayerCards.Dequeue();
                cards.Add(firstPCard);
                cards.Add(secondPCard);
                var firstCharPower = (int)(firstPCard[firstPCard.Length - 1] - 'a');
                var secondCharPower = (int)(secondPCard[secondPCard.Length - 1] - 'a');

                firstPWarPower += firstCharPower;
                secondPWarPower += secondCharPower;
            }

            cards = cards.OrderByDescending(x => x).ToList();

            if (firstPWarPower > secondPWarPower)
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    firstPlayerCards.Enqueue(cards[i]);
                }
            }
            else if (firstPWarPower < secondPWarPower)
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    secondPlayerCards.Enqueue(cards[i]);
                }
            }
            else
            {
                MakeWar();
            }
        }
    }
}
