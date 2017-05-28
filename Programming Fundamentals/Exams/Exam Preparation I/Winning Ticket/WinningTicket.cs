using System;
using System.Linq;

namespace Winning_Ticket
{
    public class WinningTicket
    {
        public static void Main()
        {
            var tickets = Console.ReadLine()
                .Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim());

            foreach (var ticket in tickets)
            {
                if (ticket.Length != 20)
                {
                    Console.WriteLine("invalid ticket");
                    continue;
                }

                var left = ticket.Take(10).ToArray();
                var right = ticket.Skip(10).Take(10).ToArray();
                var leftWinning = GetNumOfSymbols(left);
                var rightWinning = GetNumOfSymbols(right);

                if (leftWinning.Count >= 10 && rightWinning.Count >= 10 && leftWinning.Symbol == rightWinning.Symbol)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftWinning.Count, rightWinning.Count)}{leftWinning.Symbol} Jackpot!");
                }
                else if (leftWinning.Count >= 6 && rightWinning.Count >= 6 && leftWinning.Symbol == rightWinning.Symbol)
                {
                    Console.WriteLine($"ticket \"{ticket}\" - {Math.Min(leftWinning.Count, rightWinning.Count)}{leftWinning.Symbol}");
                }
                else
                {
                    Console.WriteLine($"ticket \"{ticket}\" - no match");
                }
            }
        }

        public static Ticket GetNumOfSymbols(char[] ticket)
        {
            var winningSymbols = new[] { '@', '$', '#', '^' };
            var count = 1;
            var maxCount = 0;
            var winningSymbol = default(char);

            for (int i = 1; i < ticket.Length; i++)
            {
                var currentSymbol = ticket[i];
                var previousSymbol = ticket[i - 1];

                if (winningSymbols.Contains(currentSymbol))
                {
                    if (currentSymbol == previousSymbol)
                    {
                        count++;
                        if (count > maxCount)
                        {
                            maxCount = count;
                            winningSymbol = previousSymbol;
                        }
                    }
                    else
                    {
                        maxCount = count;
                        winningSymbol = previousSymbol;
                        count = 1;
                    }
                }                
            }

            return new Ticket
            {
                Count = maxCount,
                Symbol = winningSymbol
            };
        }
    }

    public class Ticket
    {
        public int Count { get; set; }

        public char Symbol { get; set; }
    }
}
