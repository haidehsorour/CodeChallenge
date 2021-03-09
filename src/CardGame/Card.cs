using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class Card : ICard
    {
        private Suit suit;
        private Value value;
        public Card(Suit suit, Value value)
        {
            this.suit = suit;
            this.value = value;
        }

        public Suit Suit { get { return suit; } }
        public Value Value { get { return value; } }

        public bool Equals(ICard other)
        {
            return Suit == other.Suit && Value == other.Value;
        }
    }
}
