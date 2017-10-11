namespace _08.Card_Game
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Player
    {
        private ISet<Card> handOfCards;

        public Player(string name)
        {
            this.Name = name;
            this.handOfCards = new SortedSet<Card>();
        }

        public string Name { get; }

        public int HandOfCardsCount
        {
            get { return this.handOfCards.Count; }
        }

        public Card BiggestCard
        {
            get { return this.handOfCards.Last(); }
        }

        public void AddCard(Card card)
        {
            //if (this.handOfCards.Contains(card))
            //{
            //    throw new ArgumentException("Card is not in the deck.");
            //}

            this.handOfCards.Add(card);
        }

        public override string ToString()
        {
            return $"{this.Name} wins with {this.BiggestCard.Rank} of {this.BiggestCard.Suit}.";
        }
    }
}
