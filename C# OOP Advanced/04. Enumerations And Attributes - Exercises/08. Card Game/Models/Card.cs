namespace _08.Card_Game
{
    using System;

    public class Card : IComparable<Card>
    {
        private CardRank rank;
        private CardSuit suit;

        public Card(string cardRank, string cardSuit)
        {
            if (!Enum.TryParse(cardRank, out this.rank) || !Enum.TryParse(cardSuit, out this.suit))
            {
                throw new ArgumentException("No such card exists.");
            }
        }

        public CardRank Rank
        {
            get { return this.rank; }
        }

        public CardSuit Suit
        {
            get { return this.suit; }
        }

        private int CardPower()
        {
            return (int)this.rank + (int)this.suit;
        }

        public override string ToString()
        {
            return $"Card name: {this.Rank} of {this.Suit}; Card power: {this.CardPower()}";
        }

        public int CompareTo(Card other)
        {
            if (ReferenceEquals(this, other)) return 0;
            if (ReferenceEquals(null, other)) return 1;
            var rankComparison = this.suit.CompareTo(other.suit);
            if (rankComparison != 0) return rankComparison;
            return this.rank.CompareTo(other.rank);
        }
    }
}
