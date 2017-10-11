namespace _08.Card_Game.Comparators
{
    using System.Collections.Generic;
    public class CardComparator : IComparer<Card>
    {
        public int Compare(Card x, Card y)
        {
            var result = x.Rank.CompareTo(y.Rank);
            if (result == 0)
            {
                result = x.Suit.CompareTo(y.Suit);
            }

            return result;
        }
    }
}