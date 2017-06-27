namespace Number_Wars
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class NumberWars
    {
        private static Queue<string> firstPlayerCards;
        private static Queue<string> secondPlayerCards;
        private static List<string> cards = new List<string>();

        public static void Main(string[] args)
        {
            firstPlayerCards = new Queue<string>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            secondPlayerCards = new Queue<string>(Console.ReadLine()
                .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));
            var turn = 0;
            while (firstPlayerCards.Count != 0 && secondPlayerCards.Count != 0 && turn <= 1_000_000)
            {
                turn++;
                MakeATurn();
            }

            PrintWinner(turn);
        }

        private static void PrintWinner(int turns)
        {
            if (firstPlayerCards.Count > secondPlayerCards.Count)
            {
                Console.WriteLine($"First player wins after {turns} turns");
            }
            else if (secondPlayerCards.Count > firstPlayerCards.Count)
            {
                Console.WriteLine($"Second player winds after {turns} turns");
            }
            else
            {
                Console.WriteLine($"Draw after {turns} turns");
            }
        }

        private static void MakeATurn()
        {
            var firstCard = firstPlayerCards.Dequeue();
            var secondCard = secondPlayerCards.Dequeue();

            var firstCardPower = long.Parse(firstCard.Substring(0, firstCard.Length - 1));
            var secondCardPower = long.Parse(secondCard.Substring(0, secondCard.Length - 1));

            if (firstCardPower > secondCardPower)
            {
                firstPlayerCards.Enqueue(firstCard);
                firstPlayerCards.Enqueue(secondCard);
            }
            else if (firstCardPower < secondCardPower)
            {
                secondPlayerCards.Enqueue(secondCard);
                secondPlayerCards.Enqueue(firstCard);
            }
            else
            {
                MakeWar();
            }
        }

        private static void MakeWar()
        {
            if (firstPlayerCards.Count < 3 || secondPlayerCards.Count < 3)
            {
                return;
            }

            var firstPWarPower = 0L;
            var secondPWarPower = 0L;
            for (int i = 0; i < 3; i++)
            {
                var firstPCard = firstPlayerCards.Dequeue();
                var secondPCard = secondPlayerCards.Dequeue();
                cards.Add(firstPCard);
                cards.Add(secondPCard);
                //var firstCharPower = (int)(firstPCard[firstPCard.Length - 1] - 'a' + 1);
                var firstCharPower = (int)(firstPCard[firstPCard.Length - 1]);
                //var secondCharPower = (int)(secondPCard[secondPCard.Length - 1] - 'a' + 1);
                var secondCharPower = (int)secondPCard[secondPCard.Length - 1];

                firstPWarPower += firstCharPower;
                secondPWarPower += secondCharPower;
            }

            cards = cards
                .OrderByDescending(x => int.Parse(x.Substring(0, x.Length - 1)))
                /*.ThenByDescending(x => string.Join(string.Empty, x.Select(ch => (int)ch - 'a' + 1)))*/
                .ThenByDescending(x => x[x.Length - 1]).ToList();

            if (firstPWarPower > secondPWarPower)
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    firstPlayerCards.Enqueue(cards[i]);
                }

                cards.Clear();
            }
            else if (firstPWarPower < secondPWarPower)
            {
                for (int i = 0; i < cards.Count; i++)
                {
                    secondPlayerCards.Enqueue(cards[i]);
                }

                cards.Clear();
            }
            else
            {
                MakeWar();
            }
        }
    }
}
