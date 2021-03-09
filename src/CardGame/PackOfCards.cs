using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class PackOfCards : IPackOfCards
    {
        private readonly IList<ICard> cards = new List<ICard>();
        private readonly IList<ICard> removeCards = new List<ICard>();

        public int Count { get { return cards.Count; } }
        public PackOfCards()
        {
            foreach (var suit in (Suit[])Enum.GetValues(typeof(Suit)))
            {
                foreach (var value in (Value[])Enum.GetValues(typeof(Value)))
                {
                    cards.Add(new Card(suit, value));
                }
            }
        }

        public void Shuffle()
        {
            AddToListRemoveCards();
            Random num = new Random();
            for (int i = cards.Count - 1; i >= 0; i--)
            {
                int ran = num.Next(cards.Count);
                ICard temp = cards.ElementAt(ran);
                cards.RemoveAt(ran);
                cards.Insert(i, temp);
            }
        }

        public ICard TakeCardFromTopOfPack()
        {
            var result = cards.ElementAt(0);
            cards.RemoveAt(0);
            removeCards.Add(result);
            return result;
        }

        private void AddToListRemoveCards() 
        {
            if (Count != 52)
            {
                if (removeCards.Count != 0)
                    for (int i = removeCards.Count - 1; i >= 0; i--)
                    {
                        cards.Add(removeCards[i]);
                        removeCards.RemoveAt(i);
                    }
            }
        }

        public IEnumerator<ICard> GetEnumerator()
        {
            return cards.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
