using System;
using System.Collections.Generic;
using System.Text;

namespace CodingChallenge.CardGame
{
    public class PackOfCardsCreator : IPackOfCardsCreator
    {
        public IPackOfCards Create()
        {
            return new PackOfCards();
        }
    }
}
