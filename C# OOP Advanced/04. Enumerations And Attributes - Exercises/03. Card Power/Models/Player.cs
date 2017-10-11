namespace _03.Card_Power.Models
{
    using System.Collections.Generic;
    using _03.Card_Power;
    public class Player : IEqualityComparer<Card>
    {
        private HashSet<Card> handOfCards;

        public Player(string name)
        {
            this.Name = name;
            this.handOfCards = new HashSet<Card>();
        }

        public string Name { get; set; }

        //public IList<Card> HandOfCards
        //{
        //    get { return this.handOfCards; }
        //}

        public void AddCard(Card card)
        {
            this.handOfCards.Add(card);
        }

        public bool Equals(Card x, Card y)
        {
            if (x.Rank.Equals(y.Rank))
            {
                if (x.Suit.Equals(y.Suit))
                {
                    return true;
                }
            }

            return false;
        }

        public int GetHashCode(Card obj)
        {
            return this.handOfCards.GetHashCode();
        }
    }
}
